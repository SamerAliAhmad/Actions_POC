using System;
using SmartrTools;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Get_Site_view_By_SITE_VIEW_ID_Adv
        public Site_view Get_Site_view_By_SITE_VIEW_ID_Adv(Params_Get_Site_view_By_SITE_VIEW_ID i_Params_Get_Site_view_By_SITE_VIEW_ID)
        {
            Site_view oSite_view = null;
            var i_Params_Get_Site_view_By_SITE_VIEW_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_SITE_VIEW_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_SITE_VIEW_ID_Adv", i_Params_Get_Site_view_By_SITE_VIEW_ID_json, false);
            }
            #region Body Section.
            DALC.Site_view oDBEntry = _AppContext.Get_Site_view_By_SITE_VIEW_ID_Adv(i_Params_Get_Site_view_By_SITE_VIEW_ID.SITE_VIEW_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Site_view").Replace("%2", i_Params_Get_Site_view_By_SITE_VIEW_ID.SITE_VIEW_ID.ToString()));
            }
            oSite_view = new Site_view();
            Props.Copy_Prop_Values(oDBEntry, oSite_view);
            oSite_view.Site = new Site();
            Props.Copy_Prop_Values(oDBEntry.Site, oSite_view.Site);
            oSite_view.View_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.View_type_setup, oSite_view.View_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_SITE_VIEW_ID_Adv", i_Params_Get_Site_view_By_SITE_VIEW_ID_json, false);
            }
            return oSite_view;
        }
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv
        public Removed_extrusion Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv(Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID)
        {
            Removed_extrusion oRemoved_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_json, false);
            }
            #region Body Section.
            DALC.Removed_extrusion oDBEntry = _AppContext.Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv(i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID.REMOVED_EXTRUSION_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Removed_extrusion").Replace("%2", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID.REMOVED_EXTRUSION_ID.ToString()));
            }
            oRemoved_extrusion = new Removed_extrusion();
            Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
            oRemoved_extrusion.Data_level_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_json, false);
            }
            return oRemoved_extrusion;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_VIEW_ID_Adv
        public Entity_view Get_Entity_view_By_ENTITY_VIEW_ID_Adv(Params_Get_Entity_view_By_ENTITY_VIEW_ID i_Params_Get_Entity_view_By_ENTITY_VIEW_ID)
        {
            Entity_view oEntity_view = null;
            var i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_ENTITY_VIEW_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_ENTITY_VIEW_ID_Adv", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_json, false);
            }
            #region Body Section.
            DALC.Entity_view oDBEntry = _AppContext.Get_Entity_view_By_ENTITY_VIEW_ID_Adv(i_Params_Get_Entity_view_By_ENTITY_VIEW_ID.ENTITY_VIEW_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Entity_view").Replace("%2", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID.ENTITY_VIEW_ID.ToString()));
            }
            oEntity_view = new Entity_view();
            Props.Copy_Prop_Values(oDBEntry, oEntity_view);
            oEntity_view.Entity = new Entity();
            Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
            oEntity_view.View_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_ENTITY_VIEW_ID_Adv", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_json, false);
            }
            return oEntity_view;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_Adv
        public Area_kpi_user_access Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_Adv(Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID)
        {
            Area_kpi_user_access oArea_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_Adv", i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_json, false);
            }
            #region Body Section.
            DALC.Area_kpi_user_access oDBEntry = _AppContext.Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_Adv(i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID.AREA_KPI_USER_ACCESS_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Area_kpi_user_access").Replace("%2", i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID.AREA_KPI_USER_ACCESS_ID.ToString()));
            }
            oArea_kpi_user_access = new Area_kpi_user_access();
            Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
            oArea_kpi_user_access.Area = new Area();
            Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi_user_access.Area);
            oArea_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
            Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi_user_access.Organization_data_source_kpi);
            oArea_kpi_user_access.User = new User();
            Props.Copy_Prop_Values(oDBEntry.User, oArea_kpi_user_access.User);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_Adv", i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_json, false);
            }
            return oArea_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_Adv
        public Site_kpi_user_access Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_Adv(Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID)
        {
            Site_kpi_user_access oSite_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_Adv", i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_json, false);
            }
            #region Body Section.
            DALC.Site_kpi_user_access oDBEntry = _AppContext.Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_Adv(i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID.SITE_KPI_USER_ACCESS_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Site_kpi_user_access").Replace("%2", i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID.SITE_KPI_USER_ACCESS_ID.ToString()));
            }
            oSite_kpi_user_access = new Site_kpi_user_access();
            Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
            oSite_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
            Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi_user_access.Organization_data_source_kpi);
            oSite_kpi_user_access.Site = new Site();
            Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi_user_access.Site);
            oSite_kpi_user_access.User = new User();
            Props.Copy_Prop_Values(oDBEntry.User, oSite_kpi_user_access.User);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_Adv", i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_json, false);
            }
            return oSite_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_ENTITY_KPI_ID_Adv
        public Entity_kpi Get_Entity_kpi_By_ENTITY_KPI_ID_Adv(Params_Get_Entity_kpi_By_ENTITY_KPI_ID i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID)
        {
            Entity_kpi oEntity_kpi = null;
            var i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_ENTITY_KPI_ID_Adv", i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.Entity_kpi oDBEntry = _AppContext.Get_Entity_kpi_By_ENTITY_KPI_ID_Adv(i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID.ENTITY_KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Entity_kpi").Replace("%2", i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID.ENTITY_KPI_ID.ToString()));
            }
            oEntity_kpi = new Entity_kpi();
            Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
            oEntity_kpi.Entity = new Entity();
            Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi.Entity);
            oEntity_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
            Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi.Organization_data_source_kpi);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_ENTITY_KPI_ID_Adv", i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_json, false);
            }
            return oEntity_kpi;
        }
        #endregion
        #region Get_Entity_By_ENTITY_ID_Adv
        public Entity Get_Entity_By_ENTITY_ID_Adv(Params_Get_Entity_By_ENTITY_ID i_Params_Get_Entity_By_ENTITY_ID)
        {
            Entity oEntity = null;
            var i_Params_Get_Entity_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_ID_Adv", i_Params_Get_Entity_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            DALC.Entity oDBEntry = _AppContext.Get_Entity_By_ENTITY_ID_Adv(i_Params_Get_Entity_By_ENTITY_ID.ENTITY_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Entity").Replace("%2", i_Params_Get_Entity_By_ENTITY_ID.ENTITY_ID.ToString()));
            }
            oEntity = new Entity();
            Props.Copy_Prop_Values(oDBEntry, oEntity);
            oEntity.Area = new Area();
            Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
            oEntity.District = new District();
            Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
            oEntity.Region = new Region();
            Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
            oEntity.Site = new Site();
            Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
            oEntity.Top_level = new Top_level();
            Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
            oEntity.Entity_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_ID_Adv", i_Params_Get_Entity_By_ENTITY_ID_json, false);
            }
            return oEntity;
        }
        #endregion
        #region Get_District_kpi_By_DISTRICT_KPI_ID_Adv
        public District_kpi Get_District_kpi_By_DISTRICT_KPI_ID_Adv(Params_Get_District_kpi_By_DISTRICT_KPI_ID i_Params_Get_District_kpi_By_DISTRICT_KPI_ID)
        {
            District_kpi oDistrict_kpi = null;
            var i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_DISTRICT_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_DISTRICT_KPI_ID_Adv", i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.District_kpi oDBEntry = _AppContext.Get_District_kpi_By_DISTRICT_KPI_ID_Adv(i_Params_Get_District_kpi_By_DISTRICT_KPI_ID.DISTRICT_KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "District_kpi").Replace("%2", i_Params_Get_District_kpi_By_DISTRICT_KPI_ID.DISTRICT_KPI_ID.ToString()));
            }
            oDistrict_kpi = new District_kpi();
            Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
            oDistrict_kpi.District = new District();
            Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi.District);
            oDistrict_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
            Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi.Organization_data_source_kpi);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_DISTRICT_KPI_ID_Adv", i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_json, false);
            }
            return oDistrict_kpi;
        }
        #endregion
        #region Get_User_level_access_By_USER_LEVEL_ACCESS_ID_Adv
        public User_level_access Get_User_level_access_By_USER_LEVEL_ACCESS_ID_Adv(Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID i_Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID)
        {
            User_level_access oUser_level_access = null;
            var i_Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_USER_LEVEL_ACCESS_ID_Adv", i_Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID_json, false);
            }
            #region Body Section.
            DALC.User_level_access oDBEntry = _AppContext.Get_User_level_access_By_USER_LEVEL_ACCESS_ID_Adv(i_Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID.USER_LEVEL_ACCESS_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "User_level_access").Replace("%2", i_Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID.USER_LEVEL_ACCESS_ID.ToString()));
            }
            oUser_level_access = new User_level_access();
            Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
            oUser_level_access.Organization_level_access = new Organization_level_access();
            Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
            oUser_level_access.Data_level_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
            oUser_level_access.User = new User();
            Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_USER_LEVEL_ACCESS_ID_Adv", i_Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID_json, false);
            }
            return oUser_level_access;
        }
        #endregion
        #region Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_Adv
        public User_districtnex_module Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_Adv(Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID i_Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID)
        {
            User_districtnex_module oUser_districtnex_module = null;
            var i_Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_Adv", i_Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_json, false);
            }
            #region Body Section.
            DALC.User_districtnex_module oDBEntry = _AppContext.Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_Adv(i_Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID.USER_DISTRICTNEX_MODULE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "User_districtnex_module").Replace("%2", i_Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID.USER_DISTRICTNEX_MODULE_ID.ToString()));
            }
            oUser_districtnex_module = new User_districtnex_module();
            Props.Copy_Prop_Values(oDBEntry, oUser_districtnex_module);
            oUser_districtnex_module.Districtnex_module = new Districtnex_module();
            Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oUser_districtnex_module.Districtnex_module);
            oUser_districtnex_module.User = new User();
            Props.Copy_Prop_Values(oDBEntry.User, oUser_districtnex_module.User);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_Adv", i_Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_json, false);
            }
            return oUser_districtnex_module;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_Adv
        public Entity_kpi_user_access Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_Adv(Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID)
        {
            Entity_kpi_user_access oEntity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_Adv", i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_json, false);
            }
            #region Body Section.
            DALC.Entity_kpi_user_access oDBEntry = _AppContext.Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_Adv(i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID.ENTITY_KPI_USER_ACCESS_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Entity_kpi_user_access").Replace("%2", i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID.ENTITY_KPI_USER_ACCESS_ID.ToString()));
            }
            oEntity_kpi_user_access = new Entity_kpi_user_access();
            Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
            oEntity_kpi_user_access.Entity = new Entity();
            Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi_user_access.Entity);
            oEntity_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
            Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi_user_access.Organization_data_source_kpi);
            oEntity_kpi_user_access.User = new User();
            Props.Copy_Prop_Values(oDBEntry.User, oEntity_kpi_user_access.User);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_Adv", i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_json, false);
            }
            return oEntity_kpi_user_access;
        }
        #endregion
        #region Get_District_view_By_DISTRICT_VIEW_ID_Adv
        public District_view Get_District_view_By_DISTRICT_VIEW_ID_Adv(Params_Get_District_view_By_DISTRICT_VIEW_ID i_Params_Get_District_view_By_DISTRICT_VIEW_ID)
        {
            District_view oDistrict_view = null;
            var i_Params_Get_District_view_By_DISTRICT_VIEW_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_view_By_DISTRICT_VIEW_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_view_By_DISTRICT_VIEW_ID_Adv", i_Params_Get_District_view_By_DISTRICT_VIEW_ID_json, false);
            }
            #region Body Section.
            DALC.District_view oDBEntry = _AppContext.Get_District_view_By_DISTRICT_VIEW_ID_Adv(i_Params_Get_District_view_By_DISTRICT_VIEW_ID.DISTRICT_VIEW_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "District_view").Replace("%2", i_Params_Get_District_view_By_DISTRICT_VIEW_ID.DISTRICT_VIEW_ID.ToString()));
            }
            oDistrict_view = new District_view();
            Props.Copy_Prop_Values(oDBEntry, oDistrict_view);
            oDistrict_view.District = new District();
            Props.Copy_Prop_Values(oDBEntry.District, oDistrict_view.District);
            oDistrict_view.View_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.View_type_setup, oDistrict_view.View_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_view_By_DISTRICT_VIEW_ID_Adv", i_Params_Get_District_view_By_DISTRICT_VIEW_ID_json, false);
            }
            return oDistrict_view;
        }
        #endregion
        #region Get_Area_By_AREA_ID_Adv
        public Area Get_Area_By_AREA_ID_Adv(Params_Get_Area_By_AREA_ID i_Params_Get_Area_By_AREA_ID)
        {
            Area oArea = null;
            var i_Params_Get_Area_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_AREA_ID_Adv", i_Params_Get_Area_By_AREA_ID_json, false);
            }
            #region Body Section.
            DALC.Area oDBEntry = _AppContext.Get_Area_By_AREA_ID_Adv(i_Params_Get_Area_By_AREA_ID.AREA_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Area").Replace("%2", i_Params_Get_Area_By_AREA_ID.AREA_ID.ToString()));
            }
            oArea = new Area();
            Props.Copy_Prop_Values(oDBEntry, oArea);
            oArea.District = new District();
            Props.Copy_Prop_Values(oDBEntry.District, oArea.District);
            oArea.Region = new Region();
            Props.Copy_Prop_Values(oDBEntry.Region, oArea.Region);
            oArea.Top_level = new Top_level();
            Props.Copy_Prop_Values(oDBEntry.Top_level, oArea.Top_level);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_AREA_ID_Adv", i_Params_Get_Area_By_AREA_ID_json, false);
            }
            return oArea;
        }
        #endregion
        #region Get_Area_view_By_AREA_VIEW_ID_Adv
        public Area_view Get_Area_view_By_AREA_VIEW_ID_Adv(Params_Get_Area_view_By_AREA_VIEW_ID i_Params_Get_Area_view_By_AREA_VIEW_ID)
        {
            Area_view oArea_view = null;
            var i_Params_Get_Area_view_By_AREA_VIEW_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_AREA_VIEW_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_AREA_VIEW_ID_Adv", i_Params_Get_Area_view_By_AREA_VIEW_ID_json, false);
            }
            #region Body Section.
            DALC.Area_view oDBEntry = _AppContext.Get_Area_view_By_AREA_VIEW_ID_Adv(i_Params_Get_Area_view_By_AREA_VIEW_ID.AREA_VIEW_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Area_view").Replace("%2", i_Params_Get_Area_view_By_AREA_VIEW_ID.AREA_VIEW_ID.ToString()));
            }
            oArea_view = new Area_view();
            Props.Copy_Prop_Values(oDBEntry, oArea_view);
            oArea_view.Area = new Area();
            Props.Copy_Prop_Values(oDBEntry.Area, oArea_view.Area);
            oArea_view.View_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.View_type_setup, oArea_view.View_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_AREA_VIEW_ID_Adv", i_Params_Get_Area_view_By_AREA_VIEW_ID_json, false);
            }
            return oArea_view;
        }
        #endregion
        #region Get_Site_kpi_By_SITE_KPI_ID_Adv
        public Site_kpi Get_Site_kpi_By_SITE_KPI_ID_Adv(Params_Get_Site_kpi_By_SITE_KPI_ID i_Params_Get_Site_kpi_By_SITE_KPI_ID)
        {
            Site_kpi oSite_kpi = null;
            var i_Params_Get_Site_kpi_By_SITE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_SITE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_SITE_KPI_ID_Adv", i_Params_Get_Site_kpi_By_SITE_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.Site_kpi oDBEntry = _AppContext.Get_Site_kpi_By_SITE_KPI_ID_Adv(i_Params_Get_Site_kpi_By_SITE_KPI_ID.SITE_KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Site_kpi").Replace("%2", i_Params_Get_Site_kpi_By_SITE_KPI_ID.SITE_KPI_ID.ToString()));
            }
            oSite_kpi = new Site_kpi();
            Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
            oSite_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
            Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi.Organization_data_source_kpi);
            oSite_kpi.Site = new Site();
            Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi.Site);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_SITE_KPI_ID_Adv", i_Params_Get_Site_kpi_By_SITE_KPI_ID_json, false);
            }
            return oSite_kpi;
        }
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv
        public Organization_relation Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv(Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID)
        {
            Organization_relation oOrganization_relation = null;
            var i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_relation oDBEntry = _AppContext.Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv(i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID.ORGANIZATION_RELATION_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_relation").Replace("%2", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID.ORGANIZATION_RELATION_ID.ToString()));
            }
            oOrganization_relation = new Organization_relation();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
            oOrganization_relation.User = new User();
            Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_ORGANIZATION_RELATION_ID_Adv", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_json, false);
            }
            return oOrganization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_Adv
        public Setup Get_Setup_By_SETUP_ID_Adv(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID_Adv", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_ID_Adv(i_Params_Get_Setup_By_SETUP_ID.SETUP_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Setup").Replace("%2", i_Params_Get_Setup_By_SETUP_ID.SETUP_ID.ToString()));
            }
            oSetup = new Setup();
            Props.Copy_Prop_Values(oDBEntry, oSetup);
            oSetup.Setup_category = new Setup_category();
            Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID_Adv", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Area_kpi_By_AREA_KPI_ID_Adv
        public Area_kpi Get_Area_kpi_By_AREA_KPI_ID_Adv(Params_Get_Area_kpi_By_AREA_KPI_ID i_Params_Get_Area_kpi_By_AREA_KPI_ID)
        {
            Area_kpi oArea_kpi = null;
            var i_Params_Get_Area_kpi_By_AREA_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_AREA_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_AREA_KPI_ID_Adv", i_Params_Get_Area_kpi_By_AREA_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.Area_kpi oDBEntry = _AppContext.Get_Area_kpi_By_AREA_KPI_ID_Adv(i_Params_Get_Area_kpi_By_AREA_KPI_ID.AREA_KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Area_kpi").Replace("%2", i_Params_Get_Area_kpi_By_AREA_KPI_ID.AREA_KPI_ID.ToString()));
            }
            oArea_kpi = new Area_kpi();
            Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
            oArea_kpi.Area = new Area();
            Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi.Area);
            oArea_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
            Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi.Organization_data_source_kpi);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_AREA_KPI_ID_Adv", i_Params_Get_Area_kpi_By_AREA_KPI_ID_json, false);
            }
            return oArea_kpi;
        }
        #endregion
        #region Get_Region_By_REGION_ID_Adv
        public Region Get_Region_By_REGION_ID_Adv(Params_Get_Region_By_REGION_ID i_Params_Get_Region_By_REGION_ID)
        {
            Region oRegion = null;
            var i_Params_Get_Region_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_REGION_ID_Adv", i_Params_Get_Region_By_REGION_ID_json, false);
            }
            #region Body Section.
            DALC.Region oDBEntry = _AppContext.Get_Region_By_REGION_ID_Adv(i_Params_Get_Region_By_REGION_ID.REGION_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Region").Replace("%2", i_Params_Get_Region_By_REGION_ID.REGION_ID.ToString()));
            }
            oRegion = new Region();
            Props.Copy_Prop_Values(oDBEntry, oRegion);
            oRegion.Top_level = new Top_level();
            Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_REGION_ID_Adv", i_Params_Get_Region_By_REGION_ID_json, false);
            }
            return oRegion;
        }
        #endregion
        #region Get_District_By_DISTRICT_ID_Adv
        public District Get_District_By_DISTRICT_ID_Adv(Params_Get_District_By_DISTRICT_ID i_Params_Get_District_By_DISTRICT_ID)
        {
            District oDistrict = null;
            var i_Params_Get_District_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_DISTRICT_ID_Adv", i_Params_Get_District_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            DALC.District oDBEntry = _AppContext.Get_District_By_DISTRICT_ID_Adv(i_Params_Get_District_By_DISTRICT_ID.DISTRICT_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "District").Replace("%2", i_Params_Get_District_By_DISTRICT_ID.DISTRICT_ID.ToString()));
            }
            oDistrict = new District();
            Props.Copy_Prop_Values(oDBEntry, oDistrict);
            oDistrict.Region = new Region();
            Props.Copy_Prop_Values(oDBEntry.Region, oDistrict.Region);
            oDistrict.Top_level = new Top_level();
            Props.Copy_Prop_Values(oDBEntry.Top_level, oDistrict.Top_level);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_DISTRICT_ID_Adv", i_Params_Get_District_By_DISTRICT_ID_json, false);
            }
            return oDistrict;
        }
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_Adv
        public District_kpi_user_access Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_Adv(Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID)
        {
            District_kpi_user_access oDistrict_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_Adv", i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_json, false);
            }
            #region Body Section.
            DALC.District_kpi_user_access oDBEntry = _AppContext.Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_Adv(i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID.DISTRICT_KPI_USER_ACCESS_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "District_kpi_user_access").Replace("%2", i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID.DISTRICT_KPI_USER_ACCESS_ID.ToString()));
            }
            oDistrict_kpi_user_access = new District_kpi_user_access();
            Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
            oDistrict_kpi_user_access.District = new District();
            Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi_user_access.District);
            oDistrict_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
            Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi_user_access.Organization_data_source_kpi);
            oDistrict_kpi_user_access.User = new User();
            Props.Copy_Prop_Values(oDBEntry.User, oDistrict_kpi_user_access.User);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_Adv", i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_json, false);
            }
            return oDistrict_kpi_user_access;
        }
        #endregion
        #region Get_User_By_USER_ID_Adv
        public User Get_User_By_USER_ID_Adv(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
        {
            User oUser = null;
            var i_Params_Get_User_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_ID_Adv", i_Params_Get_User_By_USER_ID_json, false);
            }
            #region PreEvent_Get_User_By_USER_ID_Adv
            if (OnPreEvent_Get_User_By_USER_ID_Adv != null)
            {
                OnPreEvent_Get_User_By_USER_ID_Adv(i_Params_Get_User_By_USER_ID);
            }
            #endregion
            #region Body Section.
            DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID_Adv(i_Params_Get_User_By_USER_ID.USER_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "User").Replace("%2", i_Params_Get_User_By_USER_ID.USER_ID.ToString()));
            }
            oUser = new User();
            Props.Copy_Prop_Values(oDBEntry, oUser);
            oUser.Organization = new Organization();
            Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
            oUser.User_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
            #endregion
            #region PostEvent_Get_User_By_USER_ID_Adv
            if (OnPostEvent_Get_User_By_USER_ID_Adv != null)
            {
                OnPostEvent_Get_User_By_USER_ID_Adv(oUser, i_Params_Get_User_By_USER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_ID_Adv", i_Params_Get_User_By_USER_ID_json, false);
            }
            return oUser;
        }
        #endregion
        #region Get_Site_By_SITE_ID_Adv
        public Site Get_Site_By_SITE_ID_Adv(Params_Get_Site_By_SITE_ID i_Params_Get_Site_By_SITE_ID)
        {
            Site oSite = null;
            var i_Params_Get_Site_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_SITE_ID_Adv", i_Params_Get_Site_By_SITE_ID_json, false);
            }
            #region Body Section.
            DALC.Site oDBEntry = _AppContext.Get_Site_By_SITE_ID_Adv(i_Params_Get_Site_By_SITE_ID.SITE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Site").Replace("%2", i_Params_Get_Site_By_SITE_ID.SITE_ID.ToString()));
            }
            oSite = new Site();
            Props.Copy_Prop_Values(oDBEntry, oSite);
            oSite.Area = new Area();
            Props.Copy_Prop_Values(oDBEntry.Area, oSite.Area);
            oSite.District = new District();
            Props.Copy_Prop_Values(oDBEntry.District, oSite.District);
            oSite.Region = new Region();
            Props.Copy_Prop_Values(oDBEntry.Region, oSite.Region);
            oSite.Top_level = new Top_level();
            Props.Copy_Prop_Values(oDBEntry.Top_level, oSite.Top_level);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_SITE_ID_Adv", i_Params_Get_Site_By_SITE_ID_json, false);
            }
            return oSite;
        }
        #endregion
        #region Get_User_theme_By_USER_THEME_ID_Adv
        public User_theme Get_User_theme_By_USER_THEME_ID_Adv(Params_Get_User_theme_By_USER_THEME_ID i_Params_Get_User_theme_By_USER_THEME_ID)
        {
            User_theme oUser_theme = null;
            var i_Params_Get_User_theme_By_USER_THEME_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_theme_By_USER_THEME_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_theme_By_USER_THEME_ID_Adv", i_Params_Get_User_theme_By_USER_THEME_ID_json, false);
            }
            #region Body Section.
            DALC.User_theme oDBEntry = _AppContext.Get_User_theme_By_USER_THEME_ID_Adv(i_Params_Get_User_theme_By_USER_THEME_ID.USER_THEME_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "User_theme").Replace("%2", i_Params_Get_User_theme_By_USER_THEME_ID.USER_THEME_ID.ToString()));
            }
            oUser_theme = new User_theme();
            Props.Copy_Prop_Values(oDBEntry, oUser_theme);
            oUser_theme.Organization_theme = new Organization_theme();
            Props.Copy_Prop_Values(oDBEntry.Organization_theme, oUser_theme.Organization_theme);
            oUser_theme.User = new User();
            Props.Copy_Prop_Values(oDBEntry.User, oUser_theme.User);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_theme_By_USER_THEME_ID_Adv", i_Params_Get_User_theme_By_USER_THEME_ID_json, false);
            }
            return oUser_theme;
        }
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID_Adv
        public Region_view Get_Region_view_By_REGION_VIEW_ID_Adv(Params_Get_Region_view_By_REGION_VIEW_ID i_Params_Get_Region_view_By_REGION_VIEW_ID)
        {
            Region_view oRegion_view = null;
            var i_Params_Get_Region_view_By_REGION_VIEW_ID_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_REGION_VIEW_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_REGION_VIEW_ID_Adv", i_Params_Get_Region_view_By_REGION_VIEW_ID_json, false);
            }
            #region Body Section.
            DALC.Region_view oDBEntry = _AppContext.Get_Region_view_By_REGION_VIEW_ID_Adv(i_Params_Get_Region_view_By_REGION_VIEW_ID.REGION_VIEW_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Region_view").Replace("%2", i_Params_Get_Region_view_By_REGION_VIEW_ID.REGION_VIEW_ID.ToString()));
            }
            oRegion_view = new Region_view();
            Props.Copy_Prop_Values(oDBEntry, oRegion_view);
            oRegion_view.Region = new Region();
            Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
            oRegion_view.View_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_REGION_VIEW_ID_Adv", i_Params_Get_Region_view_By_REGION_VIEW_ID_json, false);
            }
            return oRegion_view;
        }
        #endregion
        #region Get_Site_view_By_SITE_VIEW_ID_List_Adv
        public List<Site_view> Get_Site_view_By_SITE_VIEW_ID_List_Adv(Params_Get_Site_view_By_SITE_VIEW_ID_List i_Params_Get_Site_view_By_SITE_VIEW_ID_List)
        {
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_SITE_VIEW_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_SITE_VIEW_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_SITE_VIEW_ID_List_Adv", i_Params_Get_Site_view_By_SITE_VIEW_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_SITE_VIEW_ID_List_Adv(i_Params_Get_Site_view_By_SITE_VIEW_ID_List.SITE_VIEW_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oSite_view.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_view.Site);
                        oSite_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oSite_view.View_type_setup);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_SITE_VIEW_ID_List_Adv", i_Params_Get_Site_view_By_SITE_VIEW_ID_List_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv(Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv(i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List.REMOVED_EXTRUSION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_VIEW_ID_List_Adv
        public List<Entity_view> Get_Entity_view_By_ENTITY_VIEW_ID_List_Adv(Params_Get_Entity_view_By_ENTITY_VIEW_ID_List i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_ENTITY_VIEW_ID_List_Adv", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_ENTITY_VIEW_ID_List_Adv(i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List.ENTITY_VIEW_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_ENTITY_VIEW_ID_List_Adv", i_Params_Get_Entity_view_By_ENTITY_VIEW_ID_List_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_Adv
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_Adv(Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_Adv", i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_Adv(i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List.AREA_KPI_USER_ACCESS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oArea_kpi_user_access.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi_user_access.Area);
                        oArea_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi_user_access.Organization_data_source_kpi);
                        oArea_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oArea_kpi_user_access.User);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_Adv", i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_Adv
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_Adv(Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_Adv", i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_Adv(i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List.SITE_KPI_USER_ACCESS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oSite_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi_user_access.Organization_data_source_kpi);
                        oSite_kpi_user_access.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi_user_access.Site);
                        oSite_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oSite_kpi_user_access.User);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_Adv", i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_ENTITY_KPI_ID_List_Adv
        public List<Entity_kpi> Get_Entity_kpi_By_ENTITY_KPI_ID_List_Adv(Params_Get_Entity_kpi_By_ENTITY_KPI_ID_List i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_List)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_ENTITY_KPI_ID_List_Adv", i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_ENTITY_KPI_ID_List_Adv(i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_List.ENTITY_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oEntity_kpi.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi.Entity);
                        oEntity_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi.Organization_data_source_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_ENTITY_KPI_ID_List_Adv", i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_List_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_ENTITY_ID_List_Adv
        public List<Entity> Get_Entity_By_ENTITY_ID_List_Adv(Params_Get_Entity_By_ENTITY_ID_List i_Params_Get_Entity_By_ENTITY_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_ID_List_Adv", i_Params_Get_Entity_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_ENTITY_ID_List_Adv(i_Params_Get_Entity_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_ID_List_Adv", i_Params_Get_Entity_By_ENTITY_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_DISTRICT_KPI_ID_List_Adv
        public List<District_kpi> Get_District_kpi_By_DISTRICT_KPI_ID_List_Adv(Params_Get_District_kpi_By_DISTRICT_KPI_ID_List i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_List)
        {
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_DISTRICT_KPI_ID_List_Adv", i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_DISTRICT_KPI_ID_List_Adv(i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_List.DISTRICT_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oDistrict_kpi.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi.District);
                        oDistrict_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi.Organization_data_source_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_DISTRICT_KPI_ID_List_Adv", i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_List_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List_Adv
        public List<User_level_access> Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List_Adv(Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List i_Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List)
        {
            List<User_level_access> oList_User_level_access = null;
            var i_Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List_Adv", i_Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User_level_access> oList_DBEntry = _AppContext.Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List_Adv(i_Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List.USER_LEVEL_ACCESS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
                        oUser_level_access.Organization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
                        oUser_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
                        oUser_level_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List_Adv", i_Params_Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List_json, false);
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List_Adv
        public List<User_districtnex_module> Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List_Adv(Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List i_Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            var i_Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List_Adv", i_Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User_districtnex_module> oList_DBEntry = _AppContext.Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List_Adv(i_Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List.USER_DISTRICTNEX_MODULE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oUser_districtnex_module);
                        oUser_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oUser_districtnex_module.Districtnex_module);
                        oUser_districtnex_module.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_districtnex_module.User);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List_Adv", i_Params_Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List_json, false);
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_Adv
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_Adv(Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_Adv", i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_Adv(i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List.ENTITY_KPI_USER_ACCESS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oEntity_kpi_user_access.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi_user_access.Entity);
                        oEntity_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi_user_access.Organization_data_source_kpi);
                        oEntity_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oEntity_kpi_user_access.User);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_Adv", i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_District_view_By_DISTRICT_VIEW_ID_List_Adv
        public List<District_view> Get_District_view_By_DISTRICT_VIEW_ID_List_Adv(Params_Get_District_view_By_DISTRICT_VIEW_ID_List i_Params_Get_District_view_By_DISTRICT_VIEW_ID_List)
        {
            List<District_view> oList_District_view = null;
            var i_Params_Get_District_view_By_DISTRICT_VIEW_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_view_By_DISTRICT_VIEW_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_view_By_DISTRICT_VIEW_ID_List_Adv", i_Params_Get_District_view_By_DISTRICT_VIEW_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_view> oList_DBEntry = _AppContext.Get_District_view_By_DISTRICT_VIEW_ID_List_Adv(i_Params_Get_District_view_By_DISTRICT_VIEW_ID_List.DISTRICT_VIEW_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_view = new List<District_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_view);
                        oDistrict_view.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_view.District);
                        oDistrict_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oDistrict_view.View_type_setup);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_view_By_DISTRICT_VIEW_ID_List_Adv", i_Params_Get_District_view_By_DISTRICT_VIEW_ID_List_json, false);
            }
            return oList_District_view;
        }
        #endregion
        #region Get_Area_By_AREA_ID_List_Adv
        public List<Area> Get_Area_By_AREA_ID_List_Adv(Params_Get_Area_By_AREA_ID_List i_Params_Get_Area_By_AREA_ID_List)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_AREA_ID_List_Adv", i_Params_Get_Area_By_AREA_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_AREA_ID_List_Adv(i_Params_Get_Area_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oArea.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oArea.District);
                        oArea.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oArea.Region);
                        oArea.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oArea.Top_level);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_AREA_ID_List_Adv", i_Params_Get_Area_By_AREA_ID_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_AREA_VIEW_ID_List_Adv
        public List<Area_view> Get_Area_view_By_AREA_VIEW_ID_List_Adv(Params_Get_Area_view_By_AREA_VIEW_ID_List i_Params_Get_Area_view_By_AREA_VIEW_ID_List)
        {
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_AREA_VIEW_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_AREA_VIEW_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_AREA_VIEW_ID_List_Adv", i_Params_Get_Area_view_By_AREA_VIEW_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_AREA_VIEW_ID_List_Adv(i_Params_Get_Area_view_By_AREA_VIEW_ID_List.AREA_VIEW_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oArea_view.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_view.Area);
                        oArea_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oArea_view.View_type_setup);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_AREA_VIEW_ID_List_Adv", i_Params_Get_Area_view_By_AREA_VIEW_ID_List_json, false);
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Site_kpi_By_SITE_KPI_ID_List_Adv
        public List<Site_kpi> Get_Site_kpi_By_SITE_KPI_ID_List_Adv(Params_Get_Site_kpi_By_SITE_KPI_ID_List i_Params_Get_Site_kpi_By_SITE_KPI_ID_List)
        {
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_SITE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_SITE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_SITE_KPI_ID_List_Adv", i_Params_Get_Site_kpi_By_SITE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_SITE_KPI_ID_List_Adv(i_Params_Get_Site_kpi_By_SITE_KPI_ID_List.SITE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oSite_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi.Organization_data_source_kpi);
                        oSite_kpi.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi.Site);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_SITE_KPI_ID_List_Adv", i_Params_Get_Site_kpi_By_SITE_KPI_ID_List_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv(Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv(i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List.ORGANIZATION_RELATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_Adv", i_Params_Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_ID_List_Adv(Params_Get_Setup_By_SETUP_ID_List i_Params_Get_Setup_By_SETUP_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID_List_Adv", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_ID_List_Adv(i_Params_Get_Setup_By_SETUP_ID_List.SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID_List_Adv", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_AREA_KPI_ID_List_Adv
        public List<Area_kpi> Get_Area_kpi_By_AREA_KPI_ID_List_Adv(Params_Get_Area_kpi_By_AREA_KPI_ID_List i_Params_Get_Area_kpi_By_AREA_KPI_ID_List)
        {
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_AREA_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_AREA_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_AREA_KPI_ID_List_Adv", i_Params_Get_Area_kpi_By_AREA_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_AREA_KPI_ID_List_Adv(i_Params_Get_Area_kpi_By_AREA_KPI_ID_List.AREA_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oArea_kpi.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi.Area);
                        oArea_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi.Organization_data_source_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_AREA_KPI_ID_List_Adv", i_Params_Get_Area_kpi_By_AREA_KPI_ID_List_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Region_By_REGION_ID_List_Adv
        public List<Region> Get_Region_By_REGION_ID_List_Adv(Params_Get_Region_By_REGION_ID_List i_Params_Get_Region_By_REGION_ID_List)
        {
            List<Region> oList_Region = null;
            var i_Params_Get_Region_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_REGION_ID_List_Adv", i_Params_Get_Region_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Region> oList_DBEntry = _AppContext.Get_Region_By_REGION_ID_List_Adv(i_Params_Get_Region_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Region = new List<Region>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values(oDBEntry, oRegion);
                        oRegion.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_REGION_ID_List_Adv", i_Params_Get_Region_By_REGION_ID_List_json, false);
            }
            return oList_Region;
        }
        #endregion
        #region Get_District_By_DISTRICT_ID_List_Adv
        public List<District> Get_District_By_DISTRICT_ID_List_Adv(Params_Get_District_By_DISTRICT_ID_List i_Params_Get_District_By_DISTRICT_ID_List)
        {
            List<District> oList_District = null;
            var i_Params_Get_District_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_DISTRICT_ID_List_Adv", i_Params_Get_District_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_DISTRICT_ID_List_Adv(i_Params_Get_District_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oDistrict.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oDistrict.Region);
                        oDistrict.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oDistrict.Top_level);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_DISTRICT_ID_List_Adv", i_Params_Get_District_By_DISTRICT_ID_List_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_Adv
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_Adv(Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_Adv", i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_Adv(i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List.DISTRICT_KPI_USER_ACCESS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oDistrict_kpi_user_access.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi_user_access.District);
                        oDistrict_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi_user_access.Organization_data_source_kpi);
                        oDistrict_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oDistrict_kpi_user_access.User);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_Adv", i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_USER_ID_List_Adv
        public List<User> Get_User_By_USER_ID_List_Adv(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_ID_List_Adv", i_Params_Get_User_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_USER_ID_List_Adv(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_ID_List_Adv", i_Params_Get_User_By_USER_ID_List_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_Site_By_SITE_ID_List_Adv
        public List<Site> Get_Site_By_SITE_ID_List_Adv(Params_Get_Site_By_SITE_ID_List i_Params_Get_Site_By_SITE_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_SITE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_SITE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_SITE_ID_List_Adv", i_Params_Get_Site_By_SITE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_SITE_ID_List_Adv(i_Params_Get_Site_By_SITE_ID_List.SITE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oSite.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oSite.Area);
                        oSite.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oSite.District);
                        oSite.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oSite.Region);
                        oSite.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oSite.Top_level);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_SITE_ID_List_Adv", i_Params_Get_Site_By_SITE_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_User_theme_By_USER_THEME_ID_List_Adv
        public List<User_theme> Get_User_theme_By_USER_THEME_ID_List_Adv(Params_Get_User_theme_By_USER_THEME_ID_List i_Params_Get_User_theme_By_USER_THEME_ID_List)
        {
            List<User_theme> oList_User_theme = null;
            var i_Params_Get_User_theme_By_USER_THEME_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_theme_By_USER_THEME_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_theme_By_USER_THEME_ID_List_Adv", i_Params_Get_User_theme_By_USER_THEME_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User_theme> oList_DBEntry = _AppContext.Get_User_theme_By_USER_THEME_ID_List_Adv(i_Params_Get_User_theme_By_USER_THEME_ID_List.USER_THEME_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User_theme = new List<User_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values(oDBEntry, oUser_theme);
                        oUser_theme.Organization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_theme, oUser_theme.Organization_theme);
                        oUser_theme.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_theme.User);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_theme_By_USER_THEME_ID_List_Adv", i_Params_Get_User_theme_By_USER_THEME_ID_List_json, false);
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID_List_Adv
        public List<Region_view> Get_Region_view_By_REGION_VIEW_ID_List_Adv(Params_Get_Region_view_By_REGION_VIEW_ID_List i_Params_Get_Region_view_By_REGION_VIEW_ID_List)
        {
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_REGION_VIEW_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_REGION_VIEW_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_REGION_VIEW_ID_List_Adv", i_Params_Get_Region_view_By_REGION_VIEW_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_REGION_VIEW_ID_List_Adv(i_Params_Get_Region_view_By_REGION_VIEW_ID_List.REGION_VIEW_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_REGION_VIEW_ID_List_Adv", i_Params_Get_Region_view_By_REGION_VIEW_ID_List_json, false);
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Site_view_By_OWNER_ID_IS_DELETED_Adv
        public List<Site_view> Get_Site_view_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Site_view_By_OWNER_ID_IS_DELETED i_Params_Get_Site_view_By_OWNER_ID_IS_DELETED)
        {
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Site_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Site_view_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Site_view_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oSite_view.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_view.Site);
                        oSite_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oSite_view.View_type_setup);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Site_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_VIEW_TYPE_SETUP_ID_Adv
        public List<Site_view> Get_Site_view_By_VIEW_TYPE_SETUP_ID_Adv(Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID)
        {
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_VIEW_TYPE_SETUP_ID_Adv", i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_VIEW_TYPE_SETUP_ID_Adv(i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oSite_view.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_view.Site);
                        oSite_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oSite_view.View_type_setup);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_VIEW_TYPE_SETUP_ID_Adv", i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_OWNER_ID_Adv
        public List<Site_view> Get_Site_view_By_OWNER_ID_Adv(Params_Get_Site_view_By_OWNER_ID i_Params_Get_Site_view_By_OWNER_ID)
        {
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_OWNER_ID_Adv", i_Params_Get_Site_view_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_OWNER_ID_Adv(i_Params_Get_Site_view_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oSite_view.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_view.Site);
                        oSite_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oSite_view.View_type_setup);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_OWNER_ID_Adv", i_Params_Get_Site_view_By_OWNER_ID_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_SITE_ID_Adv
        public List<Site_view> Get_Site_view_By_SITE_ID_Adv(Params_Get_Site_view_By_SITE_ID i_Params_Get_Site_view_By_SITE_ID)
        {
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_SITE_ID_Adv", i_Params_Get_Site_view_By_SITE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_SITE_ID_Adv(i_Params_Get_Site_view_By_SITE_ID.SITE_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oSite_view.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_view.Site);
                        oSite_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oSite_view.View_type_setup);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_SITE_ID_Adv", i_Params_Get_Site_view_By_SITE_ID_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_Adv(Params_Get_Removed_extrusion_By_OWNER_ID i_Params_Get_Removed_extrusion_By_OWNER_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_OWNER_ID_Adv", i_Params_Get_Removed_extrusion_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_OWNER_ID_Adv(i_Params_Get_Removed_extrusion_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_OWNER_ID_Adv", i_Params_Get_Removed_extrusion_By_OWNER_ID_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_Adv(Params_Get_Removed_extrusion_By_LEVEL_ID i_Params_Get_Removed_extrusion_By_LEVEL_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_LEVEL_ID_Adv", i_Params_Get_Removed_extrusion_By_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_LEVEL_ID_Adv(i_Params_Get_Removed_extrusion_By_LEVEL_ID.LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_LEVEL_ID_Adv", i_Params_Get_Removed_extrusion_By_LEVEL_ID_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv(Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv(i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Entity_view_By_OWNER_ID_Adv
        public List<Entity_view> Get_Entity_view_By_OWNER_ID_Adv(Params_Get_Entity_view_By_OWNER_ID i_Params_Get_Entity_view_By_OWNER_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_OWNER_ID_Adv", i_Params_Get_Entity_view_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_OWNER_ID_Adv(i_Params_Get_Entity_view_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_OWNER_ID_Adv", i_Params_Get_Entity_view_By_OWNER_ID_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID_Adv
        public List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID_Adv(Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_VIEW_TYPE_SETUP_ID_Adv", i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_VIEW_TYPE_SETUP_ID_Adv(i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_VIEW_TYPE_SETUP_ID_Adv", i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_OWNER_ID_IS_DELETED_Adv
        public List<Entity_view> Get_Entity_view_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Entity_view_By_OWNER_ID_IS_DELETED i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Entity_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_ID_Adv
        public List<Entity_view> Get_Entity_view_By_ENTITY_ID_Adv(Params_Get_Entity_view_By_ENTITY_ID i_Params_Get_Entity_view_By_ENTITY_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_ENTITY_ID_Adv", i_Params_Get_Entity_view_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_ENTITY_ID_Adv(i_Params_Get_Entity_view_By_ENTITY_ID.ENTITY_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_ENTITY_ID_Adv", i_Params_Get_Entity_view_By_ENTITY_ID_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_OWNER_ID_Adv
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_OWNER_ID_Adv(Params_Get_Area_kpi_user_access_By_OWNER_ID i_Params_Get_Area_kpi_user_access_By_OWNER_ID)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_OWNER_ID_Adv", i_Params_Get_Area_kpi_user_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_OWNER_ID_Adv(i_Params_Get_Area_kpi_user_access_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oArea_kpi_user_access.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi_user_access.Area);
                        oArea_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi_user_access.Organization_data_source_kpi);
                        oArea_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oArea_kpi_user_access.User);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_OWNER_ID_Adv", i_Params_Get_Area_kpi_user_access_By_OWNER_ID_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_USER_ID_Adv
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_USER_ID_Adv(Params_Get_Area_kpi_user_access_By_USER_ID i_Params_Get_Area_kpi_user_access_By_USER_ID)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_USER_ID_Adv", i_Params_Get_Area_kpi_user_access_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_USER_ID_Adv(i_Params_Get_Area_kpi_user_access_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oArea_kpi_user_access.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi_user_access.Area);
                        oArea_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi_user_access.Organization_data_source_kpi);
                        oArea_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oArea_kpi_user_access.User);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_USER_ID_Adv", i_Params_Get_Area_kpi_user_access_By_USER_ID_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_ID_Adv
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_ID_Adv(Params_Get_Area_kpi_user_access_By_AREA_ID i_Params_Get_Area_kpi_user_access_By_AREA_ID)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_AREA_ID_Adv", i_Params_Get_Area_kpi_user_access_By_AREA_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_AREA_ID_Adv(i_Params_Get_Area_kpi_user_access_By_AREA_ID.AREA_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oArea_kpi_user_access.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi_user_access.Area);
                        oArea_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi_user_access.Organization_data_source_kpi);
                        oArea_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oArea_kpi_user_access.User);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_AREA_ID_Adv", i_Params_Get_Area_kpi_user_access_By_AREA_ID_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oArea_kpi_user_access.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi_user_access.Area);
                        oArea_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi_user_access.Organization_data_source_kpi);
                        oArea_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oArea_kpi_user_access.User);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED i_Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oArea_kpi_user_access.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi_user_access.Area);
                        oArea_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi_user_access.Organization_data_source_kpi);
                        oArea_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oArea_kpi_user_access.User);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_OWNER_ID_Adv
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_OWNER_ID_Adv(Params_Get_Site_kpi_user_access_By_OWNER_ID i_Params_Get_Site_kpi_user_access_By_OWNER_ID)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_OWNER_ID_Adv", i_Params_Get_Site_kpi_user_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_OWNER_ID_Adv(i_Params_Get_Site_kpi_user_access_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oSite_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi_user_access.Organization_data_source_kpi);
                        oSite_kpi_user_access.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi_user_access.Site);
                        oSite_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oSite_kpi_user_access.User);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_OWNER_ID_Adv", i_Params_Get_Site_kpi_user_access_By_OWNER_ID_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_USER_ID_Adv
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_USER_ID_Adv(Params_Get_Site_kpi_user_access_By_USER_ID i_Params_Get_Site_kpi_user_access_By_USER_ID)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_USER_ID_Adv", i_Params_Get_Site_kpi_user_access_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_USER_ID_Adv(i_Params_Get_Site_kpi_user_access_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oSite_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi_user_access.Organization_data_source_kpi);
                        oSite_kpi_user_access.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi_user_access.Site);
                        oSite_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oSite_kpi_user_access.User);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_USER_ID_Adv", i_Params_Get_Site_kpi_user_access_By_USER_ID_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_ID_Adv
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_ID_Adv(Params_Get_Site_kpi_user_access_By_SITE_ID i_Params_Get_Site_kpi_user_access_By_SITE_ID)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_SITE_ID_Adv", i_Params_Get_Site_kpi_user_access_By_SITE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_SITE_ID_Adv(i_Params_Get_Site_kpi_user_access_By_SITE_ID.SITE_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oSite_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi_user_access.Organization_data_source_kpi);
                        oSite_kpi_user_access.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi_user_access.Site);
                        oSite_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oSite_kpi_user_access.User);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_SITE_ID_Adv", i_Params_Get_Site_kpi_user_access_By_SITE_ID_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oSite_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi_user_access.Organization_data_source_kpi);
                        oSite_kpi_user_access.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi_user_access.Site);
                        oSite_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oSite_kpi_user_access.User);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED i_Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oSite_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi_user_access.Organization_data_source_kpi);
                        oSite_kpi_user_access.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi_user_access.Site);
                        oSite_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oSite_kpi_user_access.User);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_OWNER_ID_IS_DELETED_Adv
        public List<Entity_kpi> Get_Entity_kpi_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED i_Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oEntity_kpi.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi.Entity);
                        oEntity_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi.Organization_data_source_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_kpi_By_OWNER_ID_Adv
        public List<Entity_kpi> Get_Entity_kpi_By_OWNER_ID_Adv(Params_Get_Entity_kpi_By_OWNER_ID i_Params_Get_Entity_kpi_By_OWNER_ID)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_OWNER_ID_Adv", i_Params_Get_Entity_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_OWNER_ID_Adv(i_Params_Get_Entity_kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oEntity_kpi.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi.Entity);
                        oEntity_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi.Organization_data_source_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_OWNER_ID_Adv", i_Params_Get_Entity_kpi_By_OWNER_ID_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        public List<Entity_kpi> Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oEntity_kpi.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi.Entity);
                        oEntity_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi.Organization_data_source_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_kpi_By_ENTITY_ID_Adv
        public List<Entity_kpi> Get_Entity_kpi_By_ENTITY_ID_Adv(Params_Get_Entity_kpi_By_ENTITY_ID i_Params_Get_Entity_kpi_By_ENTITY_ID)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_ENTITY_ID_Adv", i_Params_Get_Entity_kpi_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_ENTITY_ID_Adv(i_Params_Get_Entity_kpi_By_ENTITY_ID.ENTITY_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oEntity_kpi.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi.Entity);
                        oEntity_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi.Organization_data_source_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_ENTITY_ID_Adv", i_Params_Get_Entity_kpi_By_ENTITY_ID_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_OWNER_ID_IS_DELETED_Adv
        public List<Entity> Get_Entity_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Entity_By_OWNER_ID_IS_DELETED i_Params_Get_Entity_By_OWNER_ID_IS_DELETED)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Entity_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Entity_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_OWNER_ID_Adv
        public List<Entity> Get_Entity_By_OWNER_ID_Adv(Params_Get_Entity_By_OWNER_ID i_Params_Get_Entity_By_OWNER_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_OWNER_ID_Adv", i_Params_Get_Entity_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_OWNER_ID_Adv(i_Params_Get_Entity_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_OWNER_ID_Adv", i_Params_Get_Entity_By_OWNER_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_SITE_ID_Adv
        public List<Entity> Get_Entity_By_SITE_ID_Adv(Params_Get_Entity_By_SITE_ID i_Params_Get_Entity_By_SITE_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_SITE_ID_Adv", i_Params_Get_Entity_By_SITE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_SITE_ID_Adv(i_Params_Get_Entity_By_SITE_ID.SITE_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_SITE_ID_Adv", i_Params_Get_Entity_By_SITE_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_AREA_ID_Adv
        public List<Entity> Get_Entity_By_AREA_ID_Adv(Params_Get_Entity_By_AREA_ID i_Params_Get_Entity_By_AREA_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_AREA_ID_Adv", i_Params_Get_Entity_By_AREA_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_AREA_ID_Adv(i_Params_Get_Entity_By_AREA_ID.AREA_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_AREA_ID_Adv", i_Params_Get_Entity_By_AREA_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_DISTRICT_ID_Adv
        public List<Entity> Get_Entity_By_DISTRICT_ID_Adv(Params_Get_Entity_By_DISTRICT_ID i_Params_Get_Entity_By_DISTRICT_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_DISTRICT_ID_Adv", i_Params_Get_Entity_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_DISTRICT_ID_Adv(i_Params_Get_Entity_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_DISTRICT_ID_Adv", i_Params_Get_Entity_By_DISTRICT_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_REGION_ID_Adv
        public List<Entity> Get_Entity_By_REGION_ID_Adv(Params_Get_Entity_By_REGION_ID i_Params_Get_Entity_By_REGION_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_REGION_ID_Adv", i_Params_Get_Entity_By_REGION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_REGION_ID_Adv(i_Params_Get_Entity_By_REGION_ID.REGION_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_REGION_ID_Adv", i_Params_Get_Entity_By_REGION_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID_Adv
        public List<Entity> Get_Entity_By_TOP_LEVEL_ID_Adv(Params_Get_Entity_By_TOP_LEVEL_ID i_Params_Get_Entity_By_TOP_LEVEL_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_TOP_LEVEL_ID_Adv", i_Params_Get_Entity_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_TOP_LEVEL_ID_Adv(i_Params_Get_Entity_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_TOP_LEVEL_ID_Adv", i_Params_Get_Entity_By_TOP_LEVEL_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID_Adv
        public List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID_Adv(Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID_Adv", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_ENTITY_TYPE_SETUP_ID_Adv(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID.ENTITY_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID_Adv", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_OWNER_ID_Adv
        public List<District_kpi> Get_District_kpi_By_OWNER_ID_Adv(Params_Get_District_kpi_By_OWNER_ID i_Params_Get_District_kpi_By_OWNER_ID)
        {
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_OWNER_ID_Adv", i_Params_Get_District_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_OWNER_ID_Adv(i_Params_Get_District_kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oDistrict_kpi.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi.District);
                        oDistrict_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi.Organization_data_source_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_OWNER_ID_Adv", i_Params_Get_District_kpi_By_OWNER_ID_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        public List<District_kpi> Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oDistrict_kpi.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi.District);
                        oDistrict_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi.Organization_data_source_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_District_kpi_By_OWNER_ID_IS_DELETED_Adv
        public List<District_kpi> Get_District_kpi_By_OWNER_ID_IS_DELETED_Adv(Params_Get_District_kpi_By_OWNER_ID_IS_DELETED i_Params_Get_District_kpi_By_OWNER_ID_IS_DELETED)
        {
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_District_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_District_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_District_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oDistrict_kpi.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi.District);
                        oDistrict_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi.Organization_data_source_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_District_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_District_kpi_By_DISTRICT_ID_Adv
        public List<District_kpi> Get_District_kpi_By_DISTRICT_ID_Adv(Params_Get_District_kpi_By_DISTRICT_ID i_Params_Get_District_kpi_By_DISTRICT_ID)
        {
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_DISTRICT_ID_Adv", i_Params_Get_District_kpi_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_DISTRICT_ID_Adv(i_Params_Get_District_kpi_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oDistrict_kpi.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi.District);
                        oDistrict_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi.Organization_data_source_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_DISTRICT_ID_Adv", i_Params_Get_District_kpi_By_DISTRICT_ID_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_User_level_access_By_OWNER_ID_Adv
        public List<User_level_access> Get_User_level_access_By_OWNER_ID_Adv(Params_Get_User_level_access_By_OWNER_ID i_Params_Get_User_level_access_By_OWNER_ID)
        {
            List<User_level_access> oList_User_level_access = null;
            var i_Params_Get_User_level_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_OWNER_ID_Adv", i_Params_Get_User_level_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.User_level_access> oList_DBEntry = _AppContext.Get_User_level_access_By_OWNER_ID_Adv(i_Params_Get_User_level_access_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
                        oUser_level_access.Organization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
                        oUser_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
                        oUser_level_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_OWNER_ID_Adv", i_Params_Get_User_level_access_By_OWNER_ID_json, false);
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv
        public List<User_level_access> Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv(Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID)
        {
            List<User_level_access> oList_User_level_access = null;
            var i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv", i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_json, false);
            }
            #region Body Section.
            List<DALC.User_level_access> oList_DBEntry = _AppContext.Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv(i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID.ORGANIZATION_LEVEL_ACCESS_ID);
            if (oList_DBEntry != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
                        oUser_level_access.Organization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
                        oUser_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
                        oUser_level_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_Adv", i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_json, false);
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_USER_ID_Adv
        public List<User_level_access> Get_User_level_access_By_USER_ID_Adv(Params_Get_User_level_access_By_USER_ID i_Params_Get_User_level_access_By_USER_ID)
        {
            List<User_level_access> oList_User_level_access = null;
            var i_Params_Get_User_level_access_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_USER_ID_Adv", i_Params_Get_User_level_access_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.User_level_access> oList_DBEntry = _AppContext.Get_User_level_access_By_USER_ID_Adv(i_Params_Get_User_level_access_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
                        oUser_level_access.Organization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
                        oUser_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
                        oUser_level_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_USER_ID_Adv", i_Params_Get_User_level_access_By_USER_ID_json, false);
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_LEVEL_ID_Adv
        public List<User_level_access> Get_User_level_access_By_LEVEL_ID_Adv(Params_Get_User_level_access_By_LEVEL_ID i_Params_Get_User_level_access_By_LEVEL_ID)
        {
            List<User_level_access> oList_User_level_access = null;
            var i_Params_Get_User_level_access_By_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_LEVEL_ID_Adv", i_Params_Get_User_level_access_By_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.User_level_access> oList_DBEntry = _AppContext.Get_User_level_access_By_LEVEL_ID_Adv(i_Params_Get_User_level_access_By_LEVEL_ID.LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
                        oUser_level_access.Organization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
                        oUser_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
                        oUser_level_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_LEVEL_ID_Adv", i_Params_Get_User_level_access_By_LEVEL_ID_json, false);
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_DATA_LEVEL_SETUP_ID_Adv
        public List<User_level_access> Get_User_level_access_By_DATA_LEVEL_SETUP_ID_Adv(Params_Get_User_level_access_By_DATA_LEVEL_SETUP_ID i_Params_Get_User_level_access_By_DATA_LEVEL_SETUP_ID)
        {
            List<User_level_access> oList_User_level_access = null;
            var i_Params_Get_User_level_access_By_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_User_level_access_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.User_level_access> oList_DBEntry = _AppContext.Get_User_level_access_By_DATA_LEVEL_SETUP_ID_Adv(i_Params_Get_User_level_access_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
                        oUser_level_access.Organization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
                        oUser_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
                        oUser_level_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_User_level_access_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_OWNER_ID_IS_DELETED_Adv
        public List<User_level_access> Get_User_level_access_By_OWNER_ID_IS_DELETED_Adv(Params_Get_User_level_access_By_OWNER_ID_IS_DELETED i_Params_Get_User_level_access_By_OWNER_ID_IS_DELETED)
        {
            List<User_level_access> oList_User_level_access = null;
            var i_Params_Get_User_level_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_User_level_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User_level_access> oList_DBEntry = _AppContext.Get_User_level_access_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_User_level_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_User_level_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
                        oUser_level_access.Organization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
                        oUser_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
                        oUser_level_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_User_level_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID_Adv
        public List<User_level_access> Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID_Adv(Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID)
        {
            List<User_level_access> oList_User_level_access = null;
            var i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.User_level_access> oList_DBEntry = _AppContext.Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID_Adv(i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.USER_ID, i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
                        oUser_level_access.Organization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
                        oUser_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
                        oUser_level_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_districtnex_module_By_OWNER_ID_Adv
        public List<User_districtnex_module> Get_User_districtnex_module_By_OWNER_ID_Adv(Params_Get_User_districtnex_module_By_OWNER_ID i_Params_Get_User_districtnex_module_By_OWNER_ID)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            var i_Params_Get_User_districtnex_module_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_districtnex_module_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_districtnex_module_By_OWNER_ID_Adv", i_Params_Get_User_districtnex_module_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.User_districtnex_module> oList_DBEntry = _AppContext.Get_User_districtnex_module_By_OWNER_ID_Adv(i_Params_Get_User_districtnex_module_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oUser_districtnex_module);
                        oUser_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oUser_districtnex_module.Districtnex_module);
                        oUser_districtnex_module.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_districtnex_module.User);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_districtnex_module_By_OWNER_ID_Adv", i_Params_Get_User_districtnex_module_By_OWNER_ID_json, false);
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_User_districtnex_module_By_USER_ID_Adv
        public List<User_districtnex_module> Get_User_districtnex_module_By_USER_ID_Adv(Params_Get_User_districtnex_module_By_USER_ID i_Params_Get_User_districtnex_module_By_USER_ID)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            var i_Params_Get_User_districtnex_module_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_districtnex_module_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_districtnex_module_By_USER_ID_Adv", i_Params_Get_User_districtnex_module_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.User_districtnex_module> oList_DBEntry = _AppContext.Get_User_districtnex_module_By_USER_ID_Adv(i_Params_Get_User_districtnex_module_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oUser_districtnex_module);
                        oUser_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oUser_districtnex_module.Districtnex_module);
                        oUser_districtnex_module.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_districtnex_module.User);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_districtnex_module_By_USER_ID_Adv", i_Params_Get_User_districtnex_module_By_USER_ID_json, false);
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv
        public List<User_districtnex_module> Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv(Params_Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID i_Params_Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            var i_Params_Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv", i_Params_Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_json, false);
            }
            #region Body Section.
            List<DALC.User_districtnex_module> oList_DBEntry = _AppContext.Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv(i_Params_Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID.DISTRICTNEX_MODULE_ID);
            if (oList_DBEntry != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oUser_districtnex_module);
                        oUser_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oUser_districtnex_module.Districtnex_module);
                        oUser_districtnex_module.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_districtnex_module.User);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_Adv", i_Params_Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_json, false);
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_User_districtnex_module_By_OWNER_ID_IS_DELETED_Adv
        public List<User_districtnex_module> Get_User_districtnex_module_By_OWNER_ID_IS_DELETED_Adv(Params_Get_User_districtnex_module_By_OWNER_ID_IS_DELETED i_Params_Get_User_districtnex_module_By_OWNER_ID_IS_DELETED)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            var i_Params_Get_User_districtnex_module_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_districtnex_module_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_districtnex_module_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_User_districtnex_module_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User_districtnex_module> oList_DBEntry = _AppContext.Get_User_districtnex_module_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_User_districtnex_module_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_User_districtnex_module_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oUser_districtnex_module);
                        oUser_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oUser_districtnex_module.Districtnex_module);
                        oUser_districtnex_module.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_districtnex_module.User);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_districtnex_module_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_User_districtnex_module_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_OWNER_ID_Adv
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_OWNER_ID_Adv(Params_Get_Entity_kpi_user_access_By_OWNER_ID i_Params_Get_Entity_kpi_user_access_By_OWNER_ID)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_OWNER_ID_Adv", i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_OWNER_ID_Adv(i_Params_Get_Entity_kpi_user_access_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oEntity_kpi_user_access.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi_user_access.Entity);
                        oEntity_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi_user_access.Organization_data_source_kpi);
                        oEntity_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oEntity_kpi_user_access.User);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_OWNER_ID_Adv", i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_USER_ID_Adv
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_USER_ID_Adv(Params_Get_Entity_kpi_user_access_By_USER_ID i_Params_Get_Entity_kpi_user_access_By_USER_ID)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_USER_ID_Adv", i_Params_Get_Entity_kpi_user_access_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_USER_ID_Adv(i_Params_Get_Entity_kpi_user_access_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oEntity_kpi_user_access.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi_user_access.Entity);
                        oEntity_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi_user_access.Organization_data_source_kpi);
                        oEntity_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oEntity_kpi_user_access.User);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_USER_ID_Adv", i_Params_Get_Entity_kpi_user_access_By_USER_ID_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_ID_Adv
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_ID_Adv(Params_Get_Entity_kpi_user_access_By_ENTITY_ID i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_ENTITY_ID_Adv", i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_ENTITY_ID_Adv(i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID.ENTITY_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oEntity_kpi_user_access.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi_user_access.Entity);
                        oEntity_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi_user_access.Organization_data_source_kpi);
                        oEntity_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oEntity_kpi_user_access.User);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_ENTITY_ID_Adv", i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oEntity_kpi_user_access.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi_user_access.Entity);
                        oEntity_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi_user_access.Organization_data_source_kpi);
                        oEntity_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oEntity_kpi_user_access.User);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oEntity_kpi_user_access.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi_user_access.Entity);
                        oEntity_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi_user_access.Organization_data_source_kpi);
                        oEntity_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oEntity_kpi_user_access.User);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_District_view_By_OWNER_ID_Adv
        public List<District_view> Get_District_view_By_OWNER_ID_Adv(Params_Get_District_view_By_OWNER_ID i_Params_Get_District_view_By_OWNER_ID)
        {
            List<District_view> oList_District_view = null;
            var i_Params_Get_District_view_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_view_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_view_By_OWNER_ID_Adv", i_Params_Get_District_view_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_view> oList_DBEntry = _AppContext.Get_District_view_By_OWNER_ID_Adv(i_Params_Get_District_view_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_District_view = new List<District_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_view);
                        oDistrict_view.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_view.District);
                        oDistrict_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oDistrict_view.View_type_setup);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_view_By_OWNER_ID_Adv", i_Params_Get_District_view_By_OWNER_ID_json, false);
            }
            return oList_District_view;
        }
        #endregion
        #region Get_District_view_By_DISTRICT_ID_Adv
        public List<District_view> Get_District_view_By_DISTRICT_ID_Adv(Params_Get_District_view_By_DISTRICT_ID i_Params_Get_District_view_By_DISTRICT_ID)
        {
            List<District_view> oList_District_view = null;
            var i_Params_Get_District_view_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_view_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_view_By_DISTRICT_ID_Adv", i_Params_Get_District_view_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_view> oList_DBEntry = _AppContext.Get_District_view_By_DISTRICT_ID_Adv(i_Params_Get_District_view_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_District_view = new List<District_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_view);
                        oDistrict_view.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_view.District);
                        oDistrict_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oDistrict_view.View_type_setup);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_view_By_DISTRICT_ID_Adv", i_Params_Get_District_view_By_DISTRICT_ID_json, false);
            }
            return oList_District_view;
        }
        #endregion
        #region Get_District_view_By_VIEW_TYPE_SETUP_ID_Adv
        public List<District_view> Get_District_view_By_VIEW_TYPE_SETUP_ID_Adv(Params_Get_District_view_By_VIEW_TYPE_SETUP_ID i_Params_Get_District_view_By_VIEW_TYPE_SETUP_ID)
        {
            List<District_view> oList_District_view = null;
            var i_Params_Get_District_view_By_VIEW_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_view_By_VIEW_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_view_By_VIEW_TYPE_SETUP_ID_Adv", i_Params_Get_District_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_view> oList_DBEntry = _AppContext.Get_District_view_By_VIEW_TYPE_SETUP_ID_Adv(i_Params_Get_District_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_District_view = new List<District_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_view);
                        oDistrict_view.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_view.District);
                        oDistrict_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oDistrict_view.View_type_setup);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_view_By_VIEW_TYPE_SETUP_ID_Adv", i_Params_Get_District_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            return oList_District_view;
        }
        #endregion
        #region Get_District_view_By_OWNER_ID_IS_DELETED_Adv
        public List<District_view> Get_District_view_By_OWNER_ID_IS_DELETED_Adv(Params_Get_District_view_By_OWNER_ID_IS_DELETED i_Params_Get_District_view_By_OWNER_ID_IS_DELETED)
        {
            List<District_view> oList_District_view = null;
            var i_Params_Get_District_view_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_District_view_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_view_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_District_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.District_view> oList_DBEntry = _AppContext.Get_District_view_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_District_view_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_District_view_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_District_view = new List<District_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_view);
                        oDistrict_view.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_view.District);
                        oDistrict_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oDistrict_view.View_type_setup);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_view_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_District_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_District_view;
        }
        #endregion
        #region Get_Area_By_OWNER_ID_IS_DELETED_Adv
        public List<Area> Get_Area_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Area_By_OWNER_ID_IS_DELETED i_Params_Get_Area_By_OWNER_ID_IS_DELETED)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Area_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Area_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Area_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oArea.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oArea.District);
                        oArea.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oArea.Region);
                        oArea.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oArea.Top_level);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Area_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_OWNER_ID_Adv
        public List<Area> Get_Area_By_OWNER_ID_Adv(Params_Get_Area_By_OWNER_ID i_Params_Get_Area_By_OWNER_ID)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_OWNER_ID_Adv", i_Params_Get_Area_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_OWNER_ID_Adv(i_Params_Get_Area_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oArea.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oArea.District);
                        oArea.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oArea.Region);
                        oArea.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oArea.Top_level);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_OWNER_ID_Adv", i_Params_Get_Area_By_OWNER_ID_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_DISTRICT_ID_Adv
        public List<Area> Get_Area_By_DISTRICT_ID_Adv(Params_Get_Area_By_DISTRICT_ID i_Params_Get_Area_By_DISTRICT_ID)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_DISTRICT_ID_Adv", i_Params_Get_Area_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_DISTRICT_ID_Adv(i_Params_Get_Area_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oArea.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oArea.District);
                        oArea.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oArea.Region);
                        oArea.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oArea.Top_level);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_DISTRICT_ID_Adv", i_Params_Get_Area_By_DISTRICT_ID_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_REGION_ID_Adv
        public List<Area> Get_Area_By_REGION_ID_Adv(Params_Get_Area_By_REGION_ID i_Params_Get_Area_By_REGION_ID)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_REGION_ID_Adv", i_Params_Get_Area_By_REGION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_REGION_ID_Adv(i_Params_Get_Area_By_REGION_ID.REGION_ID);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oArea.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oArea.District);
                        oArea.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oArea.Region);
                        oArea.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oArea.Top_level);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_REGION_ID_Adv", i_Params_Get_Area_By_REGION_ID_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_TOP_LEVEL_ID_Adv
        public List<Area> Get_Area_By_TOP_LEVEL_ID_Adv(Params_Get_Area_By_TOP_LEVEL_ID i_Params_Get_Area_By_TOP_LEVEL_ID)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_TOP_LEVEL_ID_Adv", i_Params_Get_Area_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_TOP_LEVEL_ID_Adv(i_Params_Get_Area_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oArea.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oArea.District);
                        oArea.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oArea.Region);
                        oArea.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oArea.Top_level);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_TOP_LEVEL_ID_Adv", i_Params_Get_Area_By_TOP_LEVEL_ID_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_OWNER_ID_Adv
        public List<Area_view> Get_Area_view_By_OWNER_ID_Adv(Params_Get_Area_view_By_OWNER_ID i_Params_Get_Area_view_By_OWNER_ID)
        {
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_OWNER_ID_Adv", i_Params_Get_Area_view_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_OWNER_ID_Adv(i_Params_Get_Area_view_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oArea_view.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_view.Area);
                        oArea_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oArea_view.View_type_setup);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_OWNER_ID_Adv", i_Params_Get_Area_view_By_OWNER_ID_json, false);
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_AREA_ID_Adv
        public List<Area_view> Get_Area_view_By_AREA_ID_Adv(Params_Get_Area_view_By_AREA_ID i_Params_Get_Area_view_By_AREA_ID)
        {
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_AREA_ID_Adv", i_Params_Get_Area_view_By_AREA_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_AREA_ID_Adv(i_Params_Get_Area_view_By_AREA_ID.AREA_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oArea_view.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_view.Area);
                        oArea_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oArea_view.View_type_setup);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_AREA_ID_Adv", i_Params_Get_Area_view_By_AREA_ID_json, false);
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_VIEW_TYPE_SETUP_ID_Adv
        public List<Area_view> Get_Area_view_By_VIEW_TYPE_SETUP_ID_Adv(Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID)
        {
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_VIEW_TYPE_SETUP_ID_Adv", i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_VIEW_TYPE_SETUP_ID_Adv(i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oArea_view.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_view.Area);
                        oArea_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oArea_view.View_type_setup);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_VIEW_TYPE_SETUP_ID_Adv", i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_OWNER_ID_IS_DELETED_Adv
        public List<Area_view> Get_Area_view_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Area_view_By_OWNER_ID_IS_DELETED i_Params_Get_Area_view_By_OWNER_ID_IS_DELETED)
        {
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Area_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Area_view_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Area_view_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oArea_view.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_view.Area);
                        oArea_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oArea_view.View_type_setup);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Area_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Site_kpi_By_OWNER_ID_Adv
        public List<Site_kpi> Get_Site_kpi_By_OWNER_ID_Adv(Params_Get_Site_kpi_By_OWNER_ID i_Params_Get_Site_kpi_By_OWNER_ID)
        {
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_OWNER_ID_Adv", i_Params_Get_Site_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_OWNER_ID_Adv(i_Params_Get_Site_kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oSite_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi.Organization_data_source_kpi);
                        oSite_kpi.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi.Site);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_OWNER_ID_Adv", i_Params_Get_Site_kpi_By_OWNER_ID_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        public List<Site_kpi> Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oSite_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi.Organization_data_source_kpi);
                        oSite_kpi.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi.Site);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Site_kpi_By_OWNER_ID_IS_DELETED_Adv
        public List<Site_kpi> Get_Site_kpi_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED i_Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED)
        {
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oSite_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi.Organization_data_source_kpi);
                        oSite_kpi.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi.Site);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Site_kpi_By_SITE_ID_Adv
        public List<Site_kpi> Get_Site_kpi_By_SITE_ID_Adv(Params_Get_Site_kpi_By_SITE_ID i_Params_Get_Site_kpi_By_SITE_ID)
        {
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_SITE_ID_Adv", i_Params_Get_Site_kpi_By_SITE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_SITE_ID_Adv(i_Params_Get_Site_kpi_By_SITE_ID.SITE_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oSite_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi.Organization_data_source_kpi);
                        oSite_kpi.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi.Site);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_SITE_ID_Adv", i_Params_Get_Site_kpi_By_SITE_ID_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_relation> Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_relation_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_OWNER_ID_Adv
        public List<Organization_relation> Get_Organization_relation_By_OWNER_ID_Adv(Params_Get_Organization_relation_By_OWNER_ID i_Params_Get_Organization_relation_By_OWNER_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_OWNER_ID_Adv", i_Params_Get_Organization_relation_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_OWNER_ID_Adv(i_Params_Get_Organization_relation_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_OWNER_ID_Adv", i_Params_Get_Organization_relation_By_OWNER_ID_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv
        public List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv(Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv", i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv(i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID.PARENT_ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_PARENT_ORGANIZATION_ID_Adv", i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv
        public List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv(Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv", i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv(i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID.CHILD_ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_CHILD_ORGANIZATION_ID_Adv", i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_USER_ID_Adv
        public List<Organization_relation> Get_Organization_relation_By_USER_ID_Adv(Params_Get_Organization_relation_By_USER_ID i_Params_Get_Organization_relation_By_USER_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_USER_ID_Adv", i_Params_Get_Organization_relation_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_USER_ID_Adv(i_Params_Get_Organization_relation_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_USER_ID_Adv", i_Params_Get_Organization_relation_By_USER_ID_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Setup_By_OWNER_ID_IS_DELETED i_Params_Get_Setup_By_OWNER_ID_IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_Adv(Params_Get_Setup_By_SETUP_CATEGORY_ID i_Params_Get_Setup_By_SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_Adv(i_Params_Get_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID, i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE);
            if (oDBEntry != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values(oDBEntry, oSetup);
                oSetup.Setup_category = new Setup_category();
                Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_Adv(Params_Get_Setup_By_OWNER_ID i_Params_Get_Setup_By_OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID_Adv", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID_Adv(i_Params_Get_Setup_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID_Adv", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_OWNER_ID_IS_DELETED_Adv
        public List<Area_kpi> Get_Area_kpi_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED i_Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED)
        {
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oArea_kpi.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi.Area);
                        oArea_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi.Organization_data_source_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Area_kpi_By_OWNER_ID_Adv
        public List<Area_kpi> Get_Area_kpi_By_OWNER_ID_Adv(Params_Get_Area_kpi_By_OWNER_ID i_Params_Get_Area_kpi_By_OWNER_ID)
        {
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_OWNER_ID_Adv", i_Params_Get_Area_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_OWNER_ID_Adv(i_Params_Get_Area_kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oArea_kpi.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi.Area);
                        oArea_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi.Organization_data_source_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_OWNER_ID_Adv", i_Params_Get_Area_kpi_By_OWNER_ID_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Area_kpi_By_AREA_ID_Adv
        public List<Area_kpi> Get_Area_kpi_By_AREA_ID_Adv(Params_Get_Area_kpi_By_AREA_ID i_Params_Get_Area_kpi_By_AREA_ID)
        {
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_AREA_ID_Adv", i_Params_Get_Area_kpi_By_AREA_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_AREA_ID_Adv(i_Params_Get_Area_kpi_By_AREA_ID.AREA_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oArea_kpi.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi.Area);
                        oArea_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi.Organization_data_source_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_AREA_ID_Adv", i_Params_Get_Area_kpi_By_AREA_ID_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        public List<Area_kpi> Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oArea_kpi.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi.Area);
                        oArea_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi.Organization_data_source_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Region_By_OWNER_ID_IS_DELETED_Adv
        public List<Region> Get_Region_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Region_By_OWNER_ID_IS_DELETED i_Params_Get_Region_By_OWNER_ID_IS_DELETED)
        {
            List<Region> oList_Region = null;
            var i_Params_Get_Region_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Region_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Region> oList_DBEntry = _AppContext.Get_Region_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Region_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Region_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Region = new List<Region>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values(oDBEntry, oRegion);
                        oRegion.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Region_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_By_OWNER_ID_Adv
        public List<Region> Get_Region_By_OWNER_ID_Adv(Params_Get_Region_By_OWNER_ID i_Params_Get_Region_By_OWNER_ID)
        {
            List<Region> oList_Region = null;
            var i_Params_Get_Region_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_OWNER_ID_Adv", i_Params_Get_Region_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Region> oList_DBEntry = _AppContext.Get_Region_By_OWNER_ID_Adv(i_Params_Get_Region_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Region = new List<Region>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values(oDBEntry, oRegion);
                        oRegion.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_OWNER_ID_Adv", i_Params_Get_Region_By_OWNER_ID_json, false);
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_By_TOP_LEVEL_ID_Adv
        public List<Region> Get_Region_By_TOP_LEVEL_ID_Adv(Params_Get_Region_By_TOP_LEVEL_ID i_Params_Get_Region_By_TOP_LEVEL_ID)
        {
            List<Region> oList_Region = null;
            var i_Params_Get_Region_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_TOP_LEVEL_ID_Adv", i_Params_Get_Region_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Region> oList_DBEntry = _AppContext.Get_Region_By_TOP_LEVEL_ID_Adv(i_Params_Get_Region_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Region = new List<Region>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values(oDBEntry, oRegion);
                        oRegion.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_TOP_LEVEL_ID_Adv", i_Params_Get_Region_By_TOP_LEVEL_ID_json, false);
            }
            return oList_Region;
        }
        #endregion
        #region Get_District_By_OWNER_ID_IS_DELETED_Adv
        public List<District> Get_District_By_OWNER_ID_IS_DELETED_Adv(Params_Get_District_By_OWNER_ID_IS_DELETED i_Params_Get_District_By_OWNER_ID_IS_DELETED)
        {
            List<District> oList_District = null;
            var i_Params_Get_District_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_District_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_District_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_District_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_District_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oDistrict.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oDistrict.Region);
                        oDistrict.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oDistrict.Top_level);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_District_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_OWNER_ID_Adv
        public List<District> Get_District_By_OWNER_ID_Adv(Params_Get_District_By_OWNER_ID i_Params_Get_District_By_OWNER_ID)
        {
            List<District> oList_District = null;
            var i_Params_Get_District_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_OWNER_ID_Adv", i_Params_Get_District_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_OWNER_ID_Adv(i_Params_Get_District_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oDistrict.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oDistrict.Region);
                        oDistrict.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oDistrict.Top_level);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_OWNER_ID_Adv", i_Params_Get_District_By_OWNER_ID_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_REGION_ID_Adv
        public List<District> Get_District_By_REGION_ID_Adv(Params_Get_District_By_REGION_ID i_Params_Get_District_By_REGION_ID)
        {
            List<District> oList_District = null;
            var i_Params_Get_District_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_REGION_ID_Adv", i_Params_Get_District_By_REGION_ID_json, false);
            }
            #region Body Section.
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_REGION_ID_Adv(i_Params_Get_District_By_REGION_ID.REGION_ID);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oDistrict.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oDistrict.Region);
                        oDistrict.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oDistrict.Top_level);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_REGION_ID_Adv", i_Params_Get_District_By_REGION_ID_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_TOP_LEVEL_ID_Adv
        public List<District> Get_District_By_TOP_LEVEL_ID_Adv(Params_Get_District_By_TOP_LEVEL_ID i_Params_Get_District_By_TOP_LEVEL_ID)
        {
            List<District> oList_District = null;
            var i_Params_Get_District_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_TOP_LEVEL_ID_Adv", i_Params_Get_District_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_TOP_LEVEL_ID_Adv(i_Params_Get_District_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oDistrict.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oDistrict.Region);
                        oDistrict.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oDistrict.Top_level);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_TOP_LEVEL_ID_Adv", i_Params_Get_District_By_TOP_LEVEL_ID_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv(Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED i_Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oDistrict_kpi_user_access.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi_user_access.District);
                        oDistrict_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi_user_access.Organization_data_source_kpi);
                        oDistrict_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oDistrict_kpi_user_access.User);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_OWNER_ID_Adv
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_OWNER_ID_Adv(Params_Get_District_kpi_user_access_By_OWNER_ID i_Params_Get_District_kpi_user_access_By_OWNER_ID)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_OWNER_ID_Adv", i_Params_Get_District_kpi_user_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_OWNER_ID_Adv(i_Params_Get_District_kpi_user_access_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oDistrict_kpi_user_access.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi_user_access.District);
                        oDistrict_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi_user_access.Organization_data_source_kpi);
                        oDistrict_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oDistrict_kpi_user_access.User);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_OWNER_ID_Adv", i_Params_Get_District_kpi_user_access_By_OWNER_ID_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_USER_ID_Adv
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_USER_ID_Adv(Params_Get_District_kpi_user_access_By_USER_ID i_Params_Get_District_kpi_user_access_By_USER_ID)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_USER_ID_Adv", i_Params_Get_District_kpi_user_access_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_USER_ID_Adv(i_Params_Get_District_kpi_user_access_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oDistrict_kpi_user_access.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi_user_access.District);
                        oDistrict_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi_user_access.Organization_data_source_kpi);
                        oDistrict_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oDistrict_kpi_user_access.User);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_USER_ID_Adv", i_Params_Get_District_kpi_user_access_By_USER_ID_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_ID_Adv
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_ID_Adv(Params_Get_District_kpi_user_access_By_DISTRICT_ID i_Params_Get_District_kpi_user_access_By_DISTRICT_ID)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_DISTRICT_ID_Adv", i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_DISTRICT_ID_Adv(i_Params_Get_District_kpi_user_access_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oDistrict_kpi_user_access.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi_user_access.District);
                        oDistrict_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi_user_access.Organization_data_source_kpi);
                        oDistrict_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oDistrict_kpi_user_access.User);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_DISTRICT_ID_Adv", i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oDistrict_kpi_user_access.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi_user_access.District);
                        oDistrict_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi_user_access.Organization_data_source_kpi);
                        oDistrict_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oDistrict_kpi_user_access.User);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_OWNER_ID_IS_DELETED_Adv
        public List<User> Get_User_By_OWNER_ID_IS_DELETED_Adv(Params_Get_User_By_OWNER_ID_IS_DELETED i_Params_Get_User_By_OWNER_ID_IS_DELETED)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_User_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_User_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_User_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_User_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_USERNAME_OWNER_ID_Adv
        public User Get_User_By_USERNAME_OWNER_ID_Adv(Params_Get_User_By_USERNAME_OWNER_ID i_Params_Get_User_By_USERNAME_OWNER_ID)
        {
            User oUser = null;
            var i_Params_Get_User_By_USERNAME_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USERNAME_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USERNAME_OWNER_ID_Adv", i_Params_Get_User_By_USERNAME_OWNER_ID_json, false);
            }
            #region Body Section.
            DALC.User oDBEntry = _AppContext.Get_User_By_USERNAME_OWNER_ID_Adv(i_Params_Get_User_By_USERNAME_OWNER_ID.USERNAME, i_Params_Get_User_By_USERNAME_OWNER_ID.OWNER_ID);
            if (oDBEntry != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values(oDBEntry, oUser);
                oUser.Organization = new Organization();
                Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                oUser.User_type_setup = new Setup();
                Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USERNAME_OWNER_ID_Adv", i_Params_Get_User_By_USERNAME_OWNER_ID_json, false);
            }
            return oUser;
        }
        #endregion
        #region Get_User_By_EMAIL_OWNER_ID_Adv
        public User Get_User_By_EMAIL_OWNER_ID_Adv(Params_Get_User_By_EMAIL_OWNER_ID i_Params_Get_User_By_EMAIL_OWNER_ID)
        {
            User oUser = null;
            var i_Params_Get_User_By_EMAIL_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_EMAIL_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_EMAIL_OWNER_ID_Adv", i_Params_Get_User_By_EMAIL_OWNER_ID_json, false);
            }
            #region Body Section.
            DALC.User oDBEntry = _AppContext.Get_User_By_EMAIL_OWNER_ID_Adv(i_Params_Get_User_By_EMAIL_OWNER_ID.EMAIL, i_Params_Get_User_By_EMAIL_OWNER_ID.OWNER_ID);
            if (oDBEntry != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values(oDBEntry, oUser);
                oUser.Organization = new Organization();
                Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                oUser.User_type_setup = new Setup();
                Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_EMAIL_OWNER_ID_Adv", i_Params_Get_User_By_EMAIL_OWNER_ID_json, false);
            }
            return oUser;
        }
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID_Adv
        public List<User> Get_User_By_USER_TYPE_SETUP_ID_Adv(Params_Get_User_By_USER_TYPE_SETUP_ID i_Params_Get_User_By_USER_TYPE_SETUP_ID)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_USER_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_TYPE_SETUP_ID_Adv", i_Params_Get_User_By_USER_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_USER_TYPE_SETUP_ID_Adv(i_Params_Get_User_By_USER_TYPE_SETUP_ID.USER_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_TYPE_SETUP_ID_Adv", i_Params_Get_User_By_USER_TYPE_SETUP_ID_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_ORGANIZATION_ID_Adv
        public List<User> Get_User_By_ORGANIZATION_ID_Adv(Params_Get_User_By_ORGANIZATION_ID i_Params_Get_User_By_ORGANIZATION_ID)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_ORGANIZATION_ID_Adv", i_Params_Get_User_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_ORGANIZATION_ID_Adv(i_Params_Get_User_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_ORGANIZATION_ID_Adv", i_Params_Get_User_By_ORGANIZATION_ID_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_OWNER_ID_Adv
        public List<User> Get_User_By_OWNER_ID_Adv(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_OWNER_ID_Adv", i_Params_Get_User_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_OWNER_ID_Adv(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_OWNER_ID_Adv", i_Params_Get_User_By_OWNER_ID_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_IS_RECEIVE_EMAIL_Adv
        public List<User> Get_User_By_IS_RECEIVE_EMAIL_Adv(Params_Get_User_By_IS_RECEIVE_EMAIL i_Params_Get_User_By_IS_RECEIVE_EMAIL)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_IS_RECEIVE_EMAIL_json = JsonConvert.SerializeObject(i_Params_Get_User_By_IS_RECEIVE_EMAIL);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_IS_RECEIVE_EMAIL_Adv", i_Params_Get_User_By_IS_RECEIVE_EMAIL_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_IS_RECEIVE_EMAIL_Adv(i_Params_Get_User_By_IS_RECEIVE_EMAIL.IS_RECEIVE_EMAIL);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_IS_RECEIVE_EMAIL_Adv", i_Params_Get_User_By_IS_RECEIVE_EMAIL_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_IS_DELETED_Adv
        public List<User> Get_User_By_IS_DELETED_Adv(Params_Get_User_By_IS_DELETED i_Params_Get_User_By_IS_DELETED)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_By_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_IS_DELETED_Adv", i_Params_Get_User_By_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_IS_DELETED_Adv(i_Params_Get_User_By_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_IS_DELETED_Adv", i_Params_Get_User_By_IS_DELETED_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv
        public List<User> Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv(Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv", i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv(i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.OWNER_ID, i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_ACTIVE, i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_Adv", i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_Site_By_OWNER_ID_IS_DELETED_Adv
        public List<Site> Get_Site_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Site_By_OWNER_ID_IS_DELETED i_Params_Get_Site_By_OWNER_ID_IS_DELETED)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Site_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Site_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Site_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oSite.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oSite.Area);
                        oSite.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oSite.District);
                        oSite.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oSite.Region);
                        oSite.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oSite.Top_level);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Site_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_OWNER_ID_Adv
        public List<Site> Get_Site_By_OWNER_ID_Adv(Params_Get_Site_By_OWNER_ID i_Params_Get_Site_By_OWNER_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_OWNER_ID_Adv", i_Params_Get_Site_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_OWNER_ID_Adv(i_Params_Get_Site_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oSite.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oSite.Area);
                        oSite.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oSite.District);
                        oSite.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oSite.Region);
                        oSite.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oSite.Top_level);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_OWNER_ID_Adv", i_Params_Get_Site_By_OWNER_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_AREA_ID_Adv
        public List<Site> Get_Site_By_AREA_ID_Adv(Params_Get_Site_By_AREA_ID i_Params_Get_Site_By_AREA_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_AREA_ID_Adv", i_Params_Get_Site_By_AREA_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_AREA_ID_Adv(i_Params_Get_Site_By_AREA_ID.AREA_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oSite.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oSite.Area);
                        oSite.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oSite.District);
                        oSite.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oSite.Region);
                        oSite.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oSite.Top_level);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_AREA_ID_Adv", i_Params_Get_Site_By_AREA_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_DISTRICT_ID_Adv
        public List<Site> Get_Site_By_DISTRICT_ID_Adv(Params_Get_Site_By_DISTRICT_ID i_Params_Get_Site_By_DISTRICT_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_DISTRICT_ID_Adv", i_Params_Get_Site_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_DISTRICT_ID_Adv(i_Params_Get_Site_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oSite.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oSite.Area);
                        oSite.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oSite.District);
                        oSite.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oSite.Region);
                        oSite.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oSite.Top_level);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_DISTRICT_ID_Adv", i_Params_Get_Site_By_DISTRICT_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_REGION_ID_Adv
        public List<Site> Get_Site_By_REGION_ID_Adv(Params_Get_Site_By_REGION_ID i_Params_Get_Site_By_REGION_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_REGION_ID_Adv", i_Params_Get_Site_By_REGION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_REGION_ID_Adv(i_Params_Get_Site_By_REGION_ID.REGION_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oSite.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oSite.Area);
                        oSite.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oSite.District);
                        oSite.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oSite.Region);
                        oSite.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oSite.Top_level);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_REGION_ID_Adv", i_Params_Get_Site_By_REGION_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_TOP_LEVEL_ID_Adv
        public List<Site> Get_Site_By_TOP_LEVEL_ID_Adv(Params_Get_Site_By_TOP_LEVEL_ID i_Params_Get_Site_By_TOP_LEVEL_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_TOP_LEVEL_ID_Adv", i_Params_Get_Site_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_TOP_LEVEL_ID_Adv(i_Params_Get_Site_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oSite.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oSite.Area);
                        oSite.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oSite.District);
                        oSite.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oSite.Region);
                        oSite.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oSite.Top_level);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_TOP_LEVEL_ID_Adv", i_Params_Get_Site_By_TOP_LEVEL_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_User_theme_By_OWNER_ID_Adv
        public List<User_theme> Get_User_theme_By_OWNER_ID_Adv(Params_Get_User_theme_By_OWNER_ID i_Params_Get_User_theme_By_OWNER_ID)
        {
            List<User_theme> oList_User_theme = null;
            var i_Params_Get_User_theme_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_theme_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_theme_By_OWNER_ID_Adv", i_Params_Get_User_theme_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.User_theme> oList_DBEntry = _AppContext.Get_User_theme_By_OWNER_ID_Adv(i_Params_Get_User_theme_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_User_theme = new List<User_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values(oDBEntry, oUser_theme);
                        oUser_theme.Organization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_theme, oUser_theme.Organization_theme);
                        oUser_theme.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_theme.User);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_theme_By_OWNER_ID_Adv", i_Params_Get_User_theme_By_OWNER_ID_json, false);
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_User_theme_By_USER_ID_Adv
        public List<User_theme> Get_User_theme_By_USER_ID_Adv(Params_Get_User_theme_By_USER_ID i_Params_Get_User_theme_By_USER_ID)
        {
            List<User_theme> oList_User_theme = null;
            var i_Params_Get_User_theme_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_theme_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_theme_By_USER_ID_Adv", i_Params_Get_User_theme_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.User_theme> oList_DBEntry = _AppContext.Get_User_theme_By_USER_ID_Adv(i_Params_Get_User_theme_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_User_theme = new List<User_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values(oDBEntry, oUser_theme);
                        oUser_theme.Organization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_theme, oUser_theme.Organization_theme);
                        oUser_theme.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_theme.User);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_theme_By_USER_ID_Adv", i_Params_Get_User_theme_By_USER_ID_json, false);
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_User_theme_By_ORGANIZATION_THEME_ID_Adv
        public List<User_theme> Get_User_theme_By_ORGANIZATION_THEME_ID_Adv(Params_Get_User_theme_By_ORGANIZATION_THEME_ID i_Params_Get_User_theme_By_ORGANIZATION_THEME_ID)
        {
            List<User_theme> oList_User_theme = null;
            var i_Params_Get_User_theme_By_ORGANIZATION_THEME_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_theme_By_ORGANIZATION_THEME_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_theme_By_ORGANIZATION_THEME_ID_Adv", i_Params_Get_User_theme_By_ORGANIZATION_THEME_ID_json, false);
            }
            #region Body Section.
            List<DALC.User_theme> oList_DBEntry = _AppContext.Get_User_theme_By_ORGANIZATION_THEME_ID_Adv(i_Params_Get_User_theme_By_ORGANIZATION_THEME_ID.ORGANIZATION_THEME_ID);
            if (oList_DBEntry != null)
            {
                oList_User_theme = new List<User_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values(oDBEntry, oUser_theme);
                        oUser_theme.Organization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_theme, oUser_theme.Organization_theme);
                        oUser_theme.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_theme.User);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_theme_By_ORGANIZATION_THEME_ID_Adv", i_Params_Get_User_theme_By_ORGANIZATION_THEME_ID_json, false);
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_User_theme_By_OWNER_ID_IS_DELETED_Adv
        public List<User_theme> Get_User_theme_By_OWNER_ID_IS_DELETED_Adv(Params_Get_User_theme_By_OWNER_ID_IS_DELETED i_Params_Get_User_theme_By_OWNER_ID_IS_DELETED)
        {
            List<User_theme> oList_User_theme = null;
            var i_Params_Get_User_theme_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_theme_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_theme_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_User_theme_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User_theme> oList_DBEntry = _AppContext.Get_User_theme_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_User_theme_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_User_theme_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User_theme = new List<User_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values(oDBEntry, oUser_theme);
                        oUser_theme.Organization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_theme, oUser_theme.Organization_theme);
                        oUser_theme.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_theme.User);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_theme_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_User_theme_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_Region_view_By_OWNER_ID_Adv
        public List<Region_view> Get_Region_view_By_OWNER_ID_Adv(Params_Get_Region_view_By_OWNER_ID i_Params_Get_Region_view_By_OWNER_ID)
        {
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_OWNER_ID_Adv", i_Params_Get_Region_view_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_OWNER_ID_Adv(i_Params_Get_Region_view_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_OWNER_ID_Adv", i_Params_Get_Region_view_By_OWNER_ID_json, false);
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_REGION_ID_Adv
        public List<Region_view> Get_Region_view_By_REGION_ID_Adv(Params_Get_Region_view_By_REGION_ID i_Params_Get_Region_view_By_REGION_ID)
        {
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_REGION_ID_Adv", i_Params_Get_Region_view_By_REGION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_REGION_ID_Adv(i_Params_Get_Region_view_By_REGION_ID.REGION_ID);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_REGION_ID_Adv", i_Params_Get_Region_view_By_REGION_ID_json, false);
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_VIEW_TYPE_SETUP_ID_Adv
        public List<Region_view> Get_Region_view_By_VIEW_TYPE_SETUP_ID_Adv(Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID)
        {
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_VIEW_TYPE_SETUP_ID_Adv", i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_VIEW_TYPE_SETUP_ID_Adv(i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID.VIEW_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_VIEW_TYPE_SETUP_ID_Adv", i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_json, false);
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_OWNER_ID_IS_DELETED_Adv
        public List<Region_view> Get_Region_view_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Region_view_By_OWNER_ID_IS_DELETED i_Params_Get_Region_view_By_OWNER_ID_IS_DELETED)
        {
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Region_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Region_view_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Region_view_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Region_view_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        public List<Site_view> Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_Adv(Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_List i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_List)
        {
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_Adv", i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_Adv(i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_List.VIEW_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oSite_view.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_view.Site);
                        oSite_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oSite_view.View_type_setup);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_Adv", i_Params_Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_SITE_ID_List_Adv
        public List<Site_view> Get_Site_view_By_SITE_ID_List_Adv(Params_Get_Site_view_By_SITE_ID_List i_Params_Get_Site_view_By_SITE_ID_List)
        {
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_SITE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_SITE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_SITE_ID_List_Adv", i_Params_Get_Site_view_By_SITE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_SITE_ID_List_Adv(i_Params_Get_Site_view_By_SITE_ID_List.SITE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oSite_view.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_view.Site);
                        oSite_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oSite_view.View_type_setup);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_SITE_ID_List_Adv", i_Params_Get_Site_view_By_SITE_ID_List_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_List_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_List_Adv(Params_Get_Removed_extrusion_By_LEVEL_ID_List i_Params_Get_Removed_extrusion_By_LEVEL_ID_List)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_LEVEL_ID_List_Adv", i_Params_Get_Removed_extrusion_By_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_LEVEL_ID_List_Adv(i_Params_Get_Removed_extrusion_By_LEVEL_ID_List.LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_LEVEL_ID_List_Adv", i_Params_Get_Removed_extrusion_By_LEVEL_ID_List_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv(Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv(i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List.DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        public List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_Adv(Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_Adv", i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_Adv(i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List.VIEW_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_Adv", i_Params_Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_ID_List_Adv
        public List<Entity_view> Get_Entity_view_By_ENTITY_ID_List_Adv(Params_Get_Entity_view_By_ENTITY_ID_List i_Params_Get_Entity_view_By_ENTITY_ID_List)
        {
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_ENTITY_ID_List_Adv", i_Params_Get_Entity_view_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_ENTITY_ID_List_Adv(i_Params_Get_Entity_view_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_ENTITY_ID_List_Adv", i_Params_Get_Entity_view_By_ENTITY_ID_List_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_USER_ID_List_Adv
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_USER_ID_List_Adv(Params_Get_Area_kpi_user_access_By_USER_ID_List i_Params_Get_Area_kpi_user_access_By_USER_ID_List)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_USER_ID_List_Adv", i_Params_Get_Area_kpi_user_access_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_USER_ID_List_Adv(i_Params_Get_Area_kpi_user_access_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oArea_kpi_user_access.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi_user_access.Area);
                        oArea_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi_user_access.Organization_data_source_kpi);
                        oArea_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oArea_kpi_user_access.User);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_USER_ID_List_Adv", i_Params_Get_Area_kpi_user_access_By_USER_ID_List_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_ID_List_Adv
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_ID_List_Adv(Params_Get_Area_kpi_user_access_By_AREA_ID_List i_Params_Get_Area_kpi_user_access_By_AREA_ID_List)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_AREA_ID_List_Adv", i_Params_Get_Area_kpi_user_access_By_AREA_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_AREA_ID_List_Adv(i_Params_Get_Area_kpi_user_access_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oArea_kpi_user_access.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi_user_access.Area);
                        oArea_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi_user_access.Organization_data_source_kpi);
                        oArea_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oArea_kpi_user_access.User);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_AREA_ID_List_Adv", i_Params_Get_Area_kpi_user_access_By_AREA_ID_List_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oArea_kpi_user_access.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi_user_access.Area);
                        oArea_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi_user_access.Organization_data_source_kpi);
                        oArea_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oArea_kpi_user_access.User);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_USER_ID_List_Adv
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_USER_ID_List_Adv(Params_Get_Site_kpi_user_access_By_USER_ID_List i_Params_Get_Site_kpi_user_access_By_USER_ID_List)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_USER_ID_List_Adv", i_Params_Get_Site_kpi_user_access_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_USER_ID_List_Adv(i_Params_Get_Site_kpi_user_access_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oSite_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi_user_access.Organization_data_source_kpi);
                        oSite_kpi_user_access.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi_user_access.Site);
                        oSite_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oSite_kpi_user_access.User);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_USER_ID_List_Adv", i_Params_Get_Site_kpi_user_access_By_USER_ID_List_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_ID_List_Adv
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_ID_List_Adv(Params_Get_Site_kpi_user_access_By_SITE_ID_List i_Params_Get_Site_kpi_user_access_By_SITE_ID_List)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_SITE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_SITE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_SITE_ID_List_Adv", i_Params_Get_Site_kpi_user_access_By_SITE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_SITE_ID_List_Adv(i_Params_Get_Site_kpi_user_access_By_SITE_ID_List.SITE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oSite_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi_user_access.Organization_data_source_kpi);
                        oSite_kpi_user_access.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi_user_access.Site);
                        oSite_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oSite_kpi_user_access.User);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_SITE_ID_List_Adv", i_Params_Get_Site_kpi_user_access_By_SITE_ID_List_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oSite_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi_user_access.Organization_data_source_kpi);
                        oSite_kpi_user_access.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi_user_access.Site);
                        oSite_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oSite_kpi_user_access.User);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        public List<Entity_kpi> Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oEntity_kpi.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi.Entity);
                        oEntity_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi.Organization_data_source_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_kpi_By_ENTITY_ID_List_Adv
        public List<Entity_kpi> Get_Entity_kpi_By_ENTITY_ID_List_Adv(Params_Get_Entity_kpi_By_ENTITY_ID_List i_Params_Get_Entity_kpi_By_ENTITY_ID_List)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_ENTITY_ID_List_Adv", i_Params_Get_Entity_kpi_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_ENTITY_ID_List_Adv(i_Params_Get_Entity_kpi_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oEntity_kpi.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi.Entity);
                        oEntity_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi.Organization_data_source_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_ENTITY_ID_List_Adv", i_Params_Get_Entity_kpi_By_ENTITY_ID_List_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_SITE_ID_List_Adv
        public List<Entity> Get_Entity_By_SITE_ID_List_Adv(Params_Get_Entity_By_SITE_ID_List i_Params_Get_Entity_By_SITE_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_SITE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_SITE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_SITE_ID_List_Adv", i_Params_Get_Entity_By_SITE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_SITE_ID_List_Adv(i_Params_Get_Entity_By_SITE_ID_List.SITE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_SITE_ID_List_Adv", i_Params_Get_Entity_By_SITE_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_AREA_ID_List_Adv
        public List<Entity> Get_Entity_By_AREA_ID_List_Adv(Params_Get_Entity_By_AREA_ID_List i_Params_Get_Entity_By_AREA_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_AREA_ID_List_Adv", i_Params_Get_Entity_By_AREA_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_AREA_ID_List_Adv(i_Params_Get_Entity_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_AREA_ID_List_Adv", i_Params_Get_Entity_By_AREA_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_DISTRICT_ID_List_Adv
        public List<Entity> Get_Entity_By_DISTRICT_ID_List_Adv(Params_Get_Entity_By_DISTRICT_ID_List i_Params_Get_Entity_By_DISTRICT_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_DISTRICT_ID_List_Adv", i_Params_Get_Entity_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_DISTRICT_ID_List_Adv(i_Params_Get_Entity_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_DISTRICT_ID_List_Adv", i_Params_Get_Entity_By_DISTRICT_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_REGION_ID_List_Adv
        public List<Entity> Get_Entity_By_REGION_ID_List_Adv(Params_Get_Entity_By_REGION_ID_List i_Params_Get_Entity_By_REGION_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_REGION_ID_List_Adv", i_Params_Get_Entity_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_REGION_ID_List_Adv(i_Params_Get_Entity_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_REGION_ID_List_Adv", i_Params_Get_Entity_By_REGION_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID_List_Adv
        public List<Entity> Get_Entity_By_TOP_LEVEL_ID_List_Adv(Params_Get_Entity_By_TOP_LEVEL_ID_List i_Params_Get_Entity_By_TOP_LEVEL_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_TOP_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_TOP_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_TOP_LEVEL_ID_List_Adv", i_Params_Get_Entity_By_TOP_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_TOP_LEVEL_ID_List_Adv(i_Params_Get_Entity_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_TOP_LEVEL_ID_List_Adv", i_Params_Get_Entity_By_TOP_LEVEL_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_Adv
        public List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_Adv(Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_Adv", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_Adv(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List.ENTITY_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_Adv", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        public List<District_kpi> Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oDistrict_kpi.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi.District);
                        oDistrict_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi.Organization_data_source_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_District_kpi_By_DISTRICT_ID_List_Adv
        public List<District_kpi> Get_District_kpi_By_DISTRICT_ID_List_Adv(Params_Get_District_kpi_By_DISTRICT_ID_List i_Params_Get_District_kpi_By_DISTRICT_ID_List)
        {
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_DISTRICT_ID_List_Adv", i_Params_Get_District_kpi_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_DISTRICT_ID_List_Adv(i_Params_Get_District_kpi_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oDistrict_kpi.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi.District);
                        oDistrict_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi.Organization_data_source_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_DISTRICT_ID_List_Adv", i_Params_Get_District_kpi_By_DISTRICT_ID_List_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv
        public List<User_level_access> Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv(Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List)
        {
            List<User_level_access> oList_User_level_access = null;
            var i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv", i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User_level_access> oList_DBEntry = _AppContext.Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv(i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List.ORGANIZATION_LEVEL_ACCESS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
                        oUser_level_access.Organization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
                        oUser_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
                        oUser_level_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_Adv", i_Params_Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List_json, false);
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_USER_ID_List_Adv
        public List<User_level_access> Get_User_level_access_By_USER_ID_List_Adv(Params_Get_User_level_access_By_USER_ID_List i_Params_Get_User_level_access_By_USER_ID_List)
        {
            List<User_level_access> oList_User_level_access = null;
            var i_Params_Get_User_level_access_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_USER_ID_List_Adv", i_Params_Get_User_level_access_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User_level_access> oList_DBEntry = _AppContext.Get_User_level_access_By_USER_ID_List_Adv(i_Params_Get_User_level_access_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
                        oUser_level_access.Organization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
                        oUser_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
                        oUser_level_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_USER_ID_List_Adv", i_Params_Get_User_level_access_By_USER_ID_List_json, false);
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_LEVEL_ID_List_Adv
        public List<User_level_access> Get_User_level_access_By_LEVEL_ID_List_Adv(Params_Get_User_level_access_By_LEVEL_ID_List i_Params_Get_User_level_access_By_LEVEL_ID_List)
        {
            List<User_level_access> oList_User_level_access = null;
            var i_Params_Get_User_level_access_By_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_LEVEL_ID_List_Adv", i_Params_Get_User_level_access_By_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User_level_access> oList_DBEntry = _AppContext.Get_User_level_access_By_LEVEL_ID_List_Adv(i_Params_Get_User_level_access_By_LEVEL_ID_List.LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
                        oUser_level_access.Organization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
                        oUser_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
                        oUser_level_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_LEVEL_ID_List_Adv", i_Params_Get_User_level_access_By_LEVEL_ID_List_json, false);
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv
        public List<User_level_access> Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv(Params_Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List i_Params_Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List)
        {
            List<User_level_access> oList_User_level_access = null;
            var i_Params_Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User_level_access> oList_DBEntry = _AppContext.Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv(i_Params_Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List.DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
                        oUser_level_access.Organization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
                        oUser_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
                        oUser_level_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_districtnex_module_By_USER_ID_List_Adv
        public List<User_districtnex_module> Get_User_districtnex_module_By_USER_ID_List_Adv(Params_Get_User_districtnex_module_By_USER_ID_List i_Params_Get_User_districtnex_module_By_USER_ID_List)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            var i_Params_Get_User_districtnex_module_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_districtnex_module_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_districtnex_module_By_USER_ID_List_Adv", i_Params_Get_User_districtnex_module_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User_districtnex_module> oList_DBEntry = _AppContext.Get_User_districtnex_module_By_USER_ID_List_Adv(i_Params_Get_User_districtnex_module_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oUser_districtnex_module);
                        oUser_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oUser_districtnex_module.Districtnex_module);
                        oUser_districtnex_module.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_districtnex_module.User);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_districtnex_module_By_USER_ID_List_Adv", i_Params_Get_User_districtnex_module_By_USER_ID_List_json, false);
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv
        public List<User_districtnex_module> Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv(Params_Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List i_Params_Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            var i_Params_Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv", i_Params_Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User_districtnex_module> oList_DBEntry = _AppContext.Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv(i_Params_Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List.DISTRICTNEX_MODULE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oUser_districtnex_module);
                        oUser_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oUser_districtnex_module.Districtnex_module);
                        oUser_districtnex_module.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_districtnex_module.User);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_Adv", i_Params_Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List_json, false);
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_USER_ID_List_Adv
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_USER_ID_List_Adv(Params_Get_Entity_kpi_user_access_By_USER_ID_List i_Params_Get_Entity_kpi_user_access_By_USER_ID_List)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_USER_ID_List_Adv", i_Params_Get_Entity_kpi_user_access_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_USER_ID_List_Adv(i_Params_Get_Entity_kpi_user_access_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oEntity_kpi_user_access.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi_user_access.Entity);
                        oEntity_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi_user_access.Organization_data_source_kpi);
                        oEntity_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oEntity_kpi_user_access.User);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_USER_ID_List_Adv", i_Params_Get_Entity_kpi_user_access_By_USER_ID_List_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_ID_List_Adv
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_ID_List_Adv(Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_ENTITY_ID_List_Adv", i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_ENTITY_ID_List_Adv(i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oEntity_kpi_user_access.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi_user_access.Entity);
                        oEntity_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi_user_access.Organization_data_source_kpi);
                        oEntity_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oEntity_kpi_user_access.User);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_ENTITY_ID_List_Adv", i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oEntity_kpi_user_access.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi_user_access.Entity);
                        oEntity_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi_user_access.Organization_data_source_kpi);
                        oEntity_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oEntity_kpi_user_access.User);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_District_view_By_DISTRICT_ID_List_Adv
        public List<District_view> Get_District_view_By_DISTRICT_ID_List_Adv(Params_Get_District_view_By_DISTRICT_ID_List i_Params_Get_District_view_By_DISTRICT_ID_List)
        {
            List<District_view> oList_District_view = null;
            var i_Params_Get_District_view_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_view_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_view_By_DISTRICT_ID_List_Adv", i_Params_Get_District_view_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_view> oList_DBEntry = _AppContext.Get_District_view_By_DISTRICT_ID_List_Adv(i_Params_Get_District_view_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_view = new List<District_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_view);
                        oDistrict_view.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_view.District);
                        oDistrict_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oDistrict_view.View_type_setup);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_view_By_DISTRICT_ID_List_Adv", i_Params_Get_District_view_By_DISTRICT_ID_List_json, false);
            }
            return oList_District_view;
        }
        #endregion
        #region Get_District_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        public List<District_view> Get_District_view_By_VIEW_TYPE_SETUP_ID_List_Adv(Params_Get_District_view_By_VIEW_TYPE_SETUP_ID_List i_Params_Get_District_view_By_VIEW_TYPE_SETUP_ID_List)
        {
            List<District_view> oList_District_view = null;
            var i_Params_Get_District_view_By_VIEW_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_view_By_VIEW_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_view_By_VIEW_TYPE_SETUP_ID_List_Adv", i_Params_Get_District_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_view> oList_DBEntry = _AppContext.Get_District_view_By_VIEW_TYPE_SETUP_ID_List_Adv(i_Params_Get_District_view_By_VIEW_TYPE_SETUP_ID_List.VIEW_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_view = new List<District_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_view);
                        oDistrict_view.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_view.District);
                        oDistrict_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oDistrict_view.View_type_setup);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_view_By_VIEW_TYPE_SETUP_ID_List_Adv", i_Params_Get_District_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            return oList_District_view;
        }
        #endregion
        #region Get_Area_By_DISTRICT_ID_List_Adv
        public List<Area> Get_Area_By_DISTRICT_ID_List_Adv(Params_Get_Area_By_DISTRICT_ID_List i_Params_Get_Area_By_DISTRICT_ID_List)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_DISTRICT_ID_List_Adv", i_Params_Get_Area_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_DISTRICT_ID_List_Adv(i_Params_Get_Area_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oArea.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oArea.District);
                        oArea.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oArea.Region);
                        oArea.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oArea.Top_level);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_DISTRICT_ID_List_Adv", i_Params_Get_Area_By_DISTRICT_ID_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_REGION_ID_List_Adv
        public List<Area> Get_Area_By_REGION_ID_List_Adv(Params_Get_Area_By_REGION_ID_List i_Params_Get_Area_By_REGION_ID_List)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_REGION_ID_List_Adv", i_Params_Get_Area_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_REGION_ID_List_Adv(i_Params_Get_Area_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oArea.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oArea.District);
                        oArea.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oArea.Region);
                        oArea.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oArea.Top_level);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_REGION_ID_List_Adv", i_Params_Get_Area_By_REGION_ID_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_TOP_LEVEL_ID_List_Adv
        public List<Area> Get_Area_By_TOP_LEVEL_ID_List_Adv(Params_Get_Area_By_TOP_LEVEL_ID_List i_Params_Get_Area_By_TOP_LEVEL_ID_List)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_TOP_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_TOP_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_TOP_LEVEL_ID_List_Adv", i_Params_Get_Area_By_TOP_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_TOP_LEVEL_ID_List_Adv(i_Params_Get_Area_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oArea.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oArea.District);
                        oArea.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oArea.Region);
                        oArea.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oArea.Top_level);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_TOP_LEVEL_ID_List_Adv", i_Params_Get_Area_By_TOP_LEVEL_ID_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_AREA_ID_List_Adv
        public List<Area_view> Get_Area_view_By_AREA_ID_List_Adv(Params_Get_Area_view_By_AREA_ID_List i_Params_Get_Area_view_By_AREA_ID_List)
        {
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_AREA_ID_List_Adv", i_Params_Get_Area_view_By_AREA_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_AREA_ID_List_Adv(i_Params_Get_Area_view_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oArea_view.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_view.Area);
                        oArea_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oArea_view.View_type_setup);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_AREA_ID_List_Adv", i_Params_Get_Area_view_By_AREA_ID_List_json, false);
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        public List<Area_view> Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_Adv(Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List)
        {
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_Adv", i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_Adv(i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List.VIEW_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oArea_view.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_view.Area);
                        oArea_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oArea_view.View_type_setup);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_Adv", i_Params_Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        public List<Site_kpi> Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oSite_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi.Organization_data_source_kpi);
                        oSite_kpi.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi.Site);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Site_kpi_By_SITE_ID_List_Adv
        public List<Site_kpi> Get_Site_kpi_By_SITE_ID_List_Adv(Params_Get_Site_kpi_By_SITE_ID_List i_Params_Get_Site_kpi_By_SITE_ID_List)
        {
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_SITE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_SITE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_SITE_ID_List_Adv", i_Params_Get_Site_kpi_By_SITE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_SITE_ID_List_Adv(i_Params_Get_Site_kpi_By_SITE_ID_List.SITE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oSite_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi.Organization_data_source_kpi);
                        oSite_kpi.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi.Site);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_SITE_ID_List_Adv", i_Params_Get_Site_kpi_By_SITE_ID_List_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv(Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List.PARENT_ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv(Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List.CHILD_ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_USER_ID_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_USER_ID_List_Adv(Params_Get_Organization_relation_By_USER_ID_List i_Params_Get_Organization_relation_By_USER_ID_List)
        {
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_USER_ID_List_Adv", i_Params_Get_Organization_relation_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_USER_ID_List_Adv(i_Params_Get_Organization_relation_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_USER_ID_List_Adv", i_Params_Get_Organization_relation_By_USER_ID_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(Params_Get_Setup_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_AREA_ID_List_Adv
        public List<Area_kpi> Get_Area_kpi_By_AREA_ID_List_Adv(Params_Get_Area_kpi_By_AREA_ID_List i_Params_Get_Area_kpi_By_AREA_ID_List)
        {
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_AREA_ID_List_Adv", i_Params_Get_Area_kpi_By_AREA_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_AREA_ID_List_Adv(i_Params_Get_Area_kpi_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oArea_kpi.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi.Area);
                        oArea_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi.Organization_data_source_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_AREA_ID_List_Adv", i_Params_Get_Area_kpi_By_AREA_ID_List_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        public List<Area_kpi> Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oArea_kpi.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi.Area);
                        oArea_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi.Organization_data_source_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Region_By_TOP_LEVEL_ID_List_Adv
        public List<Region> Get_Region_By_TOP_LEVEL_ID_List_Adv(Params_Get_Region_By_TOP_LEVEL_ID_List i_Params_Get_Region_By_TOP_LEVEL_ID_List)
        {
            List<Region> oList_Region = null;
            var i_Params_Get_Region_By_TOP_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_TOP_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_TOP_LEVEL_ID_List_Adv", i_Params_Get_Region_By_TOP_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Region> oList_DBEntry = _AppContext.Get_Region_By_TOP_LEVEL_ID_List_Adv(i_Params_Get_Region_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Region = new List<Region>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values(oDBEntry, oRegion);
                        oRegion.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_TOP_LEVEL_ID_List_Adv", i_Params_Get_Region_By_TOP_LEVEL_ID_List_json, false);
            }
            return oList_Region;
        }
        #endregion
        #region Get_District_By_REGION_ID_List_Adv
        public List<District> Get_District_By_REGION_ID_List_Adv(Params_Get_District_By_REGION_ID_List i_Params_Get_District_By_REGION_ID_List)
        {
            List<District> oList_District = null;
            var i_Params_Get_District_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_REGION_ID_List_Adv", i_Params_Get_District_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_REGION_ID_List_Adv(i_Params_Get_District_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oDistrict.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oDistrict.Region);
                        oDistrict.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oDistrict.Top_level);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_REGION_ID_List_Adv", i_Params_Get_District_By_REGION_ID_List_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_TOP_LEVEL_ID_List_Adv
        public List<District> Get_District_By_TOP_LEVEL_ID_List_Adv(Params_Get_District_By_TOP_LEVEL_ID_List i_Params_Get_District_By_TOP_LEVEL_ID_List)
        {
            List<District> oList_District = null;
            var i_Params_Get_District_By_TOP_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_By_TOP_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_TOP_LEVEL_ID_List_Adv", i_Params_Get_District_By_TOP_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_TOP_LEVEL_ID_List_Adv(i_Params_Get_District_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oDistrict.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oDistrict.Region);
                        oDistrict.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oDistrict.Top_level);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_TOP_LEVEL_ID_List_Adv", i_Params_Get_District_By_TOP_LEVEL_ID_List_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_District_kpi_user_access_By_USER_ID_List_Adv
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_USER_ID_List_Adv(Params_Get_District_kpi_user_access_By_USER_ID_List i_Params_Get_District_kpi_user_access_By_USER_ID_List)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_USER_ID_List_Adv", i_Params_Get_District_kpi_user_access_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_USER_ID_List_Adv(i_Params_Get_District_kpi_user_access_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oDistrict_kpi_user_access.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi_user_access.District);
                        oDistrict_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi_user_access.Organization_data_source_kpi);
                        oDistrict_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oDistrict_kpi_user_access.User);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_USER_ID_List_Adv", i_Params_Get_District_kpi_user_access_By_USER_ID_List_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_ID_List_Adv
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_ID_List_Adv(Params_Get_District_kpi_user_access_By_DISTRICT_ID_List i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_List)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_DISTRICT_ID_List_Adv", i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_DISTRICT_ID_List_Adv(i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oDistrict_kpi_user_access.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi_user_access.District);
                        oDistrict_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi_user_access.Organization_data_source_kpi);
                        oDistrict_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oDistrict_kpi_user_access.User);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_DISTRICT_ID_List_Adv", i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_List_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oDistrict_kpi_user_access.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi_user_access.District);
                        oDistrict_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi_user_access.Organization_data_source_kpi);
                        oDistrict_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oDistrict_kpi_user_access.User);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID_List_Adv
        public List<User> Get_User_By_USER_TYPE_SETUP_ID_List_Adv(Params_Get_User_By_USER_TYPE_SETUP_ID_List i_Params_Get_User_By_USER_TYPE_SETUP_ID_List)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_USER_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_TYPE_SETUP_ID_List_Adv", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_USER_TYPE_SETUP_ID_List_Adv(i_Params_Get_User_By_USER_TYPE_SETUP_ID_List.USER_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_TYPE_SETUP_ID_List_Adv", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_ORGANIZATION_ID_List_Adv
        public List<User> Get_User_By_ORGANIZATION_ID_List_Adv(Params_Get_User_By_ORGANIZATION_ID_List i_Params_Get_User_By_ORGANIZATION_ID_List)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_ORGANIZATION_ID_List_Adv", i_Params_Get_User_By_ORGANIZATION_ID_List_json, false);
            }
            #region PreEvent_Get_User_By_ORGANIZATION_ID_List_Adv
            if (OnPreEvent_Get_User_By_ORGANIZATION_ID_List_Adv != null)
            {
                OnPreEvent_Get_User_By_ORGANIZATION_ID_List_Adv(i_Params_Get_User_By_ORGANIZATION_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_ORGANIZATION_ID_List_Adv(i_Params_Get_User_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_User_By_ORGANIZATION_ID_List_Adv
            if (OnPostEvent_Get_User_By_ORGANIZATION_ID_List_Adv != null)
            {
                OnPostEvent_Get_User_By_ORGANIZATION_ID_List_Adv(oList_User, i_Params_Get_User_By_ORGANIZATION_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_ORGANIZATION_ID_List_Adv", i_Params_Get_User_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_Site_By_AREA_ID_List_Adv
        public List<Site> Get_Site_By_AREA_ID_List_Adv(Params_Get_Site_By_AREA_ID_List i_Params_Get_Site_By_AREA_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_AREA_ID_List_Adv", i_Params_Get_Site_By_AREA_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_AREA_ID_List_Adv(i_Params_Get_Site_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oSite.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oSite.Area);
                        oSite.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oSite.District);
                        oSite.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oSite.Region);
                        oSite.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oSite.Top_level);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_AREA_ID_List_Adv", i_Params_Get_Site_By_AREA_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_DISTRICT_ID_List_Adv
        public List<Site> Get_Site_By_DISTRICT_ID_List_Adv(Params_Get_Site_By_DISTRICT_ID_List i_Params_Get_Site_By_DISTRICT_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_DISTRICT_ID_List_Adv", i_Params_Get_Site_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_DISTRICT_ID_List_Adv(i_Params_Get_Site_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oSite.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oSite.Area);
                        oSite.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oSite.District);
                        oSite.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oSite.Region);
                        oSite.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oSite.Top_level);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_DISTRICT_ID_List_Adv", i_Params_Get_Site_By_DISTRICT_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_REGION_ID_List_Adv
        public List<Site> Get_Site_By_REGION_ID_List_Adv(Params_Get_Site_By_REGION_ID_List i_Params_Get_Site_By_REGION_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_REGION_ID_List_Adv", i_Params_Get_Site_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_REGION_ID_List_Adv(i_Params_Get_Site_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oSite.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oSite.Area);
                        oSite.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oSite.District);
                        oSite.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oSite.Region);
                        oSite.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oSite.Top_level);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_REGION_ID_List_Adv", i_Params_Get_Site_By_REGION_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_TOP_LEVEL_ID_List_Adv
        public List<Site> Get_Site_By_TOP_LEVEL_ID_List_Adv(Params_Get_Site_By_TOP_LEVEL_ID_List i_Params_Get_Site_By_TOP_LEVEL_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_TOP_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_TOP_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_TOP_LEVEL_ID_List_Adv", i_Params_Get_Site_By_TOP_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_TOP_LEVEL_ID_List_Adv(i_Params_Get_Site_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oSite.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oSite.Area);
                        oSite.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oSite.District);
                        oSite.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oSite.Region);
                        oSite.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oSite.Top_level);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_TOP_LEVEL_ID_List_Adv", i_Params_Get_Site_By_TOP_LEVEL_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_User_theme_By_USER_ID_List_Adv
        public List<User_theme> Get_User_theme_By_USER_ID_List_Adv(Params_Get_User_theme_By_USER_ID_List i_Params_Get_User_theme_By_USER_ID_List)
        {
            List<User_theme> oList_User_theme = null;
            var i_Params_Get_User_theme_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_theme_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_theme_By_USER_ID_List_Adv", i_Params_Get_User_theme_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User_theme> oList_DBEntry = _AppContext.Get_User_theme_By_USER_ID_List_Adv(i_Params_Get_User_theme_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User_theme = new List<User_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values(oDBEntry, oUser_theme);
                        oUser_theme.Organization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_theme, oUser_theme.Organization_theme);
                        oUser_theme.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_theme.User);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_theme_By_USER_ID_List_Adv", i_Params_Get_User_theme_By_USER_ID_List_json, false);
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_User_theme_By_ORGANIZATION_THEME_ID_List_Adv
        public List<User_theme> Get_User_theme_By_ORGANIZATION_THEME_ID_List_Adv(Params_Get_User_theme_By_ORGANIZATION_THEME_ID_List i_Params_Get_User_theme_By_ORGANIZATION_THEME_ID_List)
        {
            List<User_theme> oList_User_theme = null;
            var i_Params_Get_User_theme_By_ORGANIZATION_THEME_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_theme_By_ORGANIZATION_THEME_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_theme_By_ORGANIZATION_THEME_ID_List_Adv", i_Params_Get_User_theme_By_ORGANIZATION_THEME_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User_theme> oList_DBEntry = _AppContext.Get_User_theme_By_ORGANIZATION_THEME_ID_List_Adv(i_Params_Get_User_theme_By_ORGANIZATION_THEME_ID_List.ORGANIZATION_THEME_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User_theme = new List<User_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values(oDBEntry, oUser_theme);
                        oUser_theme.Organization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_theme, oUser_theme.Organization_theme);
                        oUser_theme.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_theme.User);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_theme_By_ORGANIZATION_THEME_ID_List_Adv", i_Params_Get_User_theme_By_ORGANIZATION_THEME_ID_List_json, false);
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_Region_view_By_REGION_ID_List_Adv
        public List<Region_view> Get_Region_view_By_REGION_ID_List_Adv(Params_Get_Region_view_By_REGION_ID_List i_Params_Get_Region_view_By_REGION_ID_List)
        {
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_REGION_ID_List_Adv", i_Params_Get_Region_view_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_REGION_ID_List_Adv(i_Params_Get_Region_view_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_REGION_ID_List_Adv", i_Params_Get_Region_view_By_REGION_ID_List_json, false);
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        public List<Region_view> Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv(Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_List i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_List)
        {
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv", i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv(i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_List.VIEW_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv", i_Params_Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Site_view_By_Where_Adv
        public List<Site_view> Get_Site_view_By_Where_Adv(Params_Get_Site_view_By_Where i_Params_Get_Site_view_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_Where_Adv", i_Params_Get_Site_view_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Site_view_By_Where.OWNER_ID == null || i_Params_Get_Site_view_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Site_view_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Site_view_By_Where.OFFSET == null)
            {
                i_Params_Get_Site_view_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Site_view_By_Where.FETCH_NEXT == null || i_Params_Get_Site_view_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Site_view_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_Where_Adv(i_Params_Get_Site_view_By_Where.DESCRIPTION, i_Params_Get_Site_view_By_Where.OWNER_ID, i_Params_Get_Site_view_By_Where.OFFSET, i_Params_Get_Site_view_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oSite_view.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_view.Site);
                        oSite_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oSite_view.View_type_setup);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            i_Params_Get_Site_view_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_Where_Adv", i_Params_Get_Site_view_By_Where_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Removed_extrusion_By_Where_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_Where_Adv(Params_Get_Removed_extrusion_By_Where i_Params_Get_Removed_extrusion_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_Where_Adv", i_Params_Get_Removed_extrusion_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Removed_extrusion_By_Where.OWNER_ID == null || i_Params_Get_Removed_extrusion_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Removed_extrusion_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Removed_extrusion_By_Where.OFFSET == null)
            {
                i_Params_Get_Removed_extrusion_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Removed_extrusion_By_Where.FETCH_NEXT == null || i_Params_Get_Removed_extrusion_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Removed_extrusion_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_Where_Adv(i_Params_Get_Removed_extrusion_By_Where.EXTRUSION_IDENTIFIER, i_Params_Get_Removed_extrusion_By_Where.OWNER_ID, i_Params_Get_Removed_extrusion_By_Where.OFFSET, i_Params_Get_Removed_extrusion_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            i_Params_Get_Removed_extrusion_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_Where_Adv", i_Params_Get_Removed_extrusion_By_Where_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Entity_view_By_Where_Adv
        public List<Entity_view> Get_Entity_view_By_Where_Adv(Params_Get_Entity_view_By_Where i_Params_Get_Entity_view_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_Where_Adv", i_Params_Get_Entity_view_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Entity_view_By_Where.OWNER_ID == null || i_Params_Get_Entity_view_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Entity_view_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Entity_view_By_Where.OFFSET == null)
            {
                i_Params_Get_Entity_view_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Entity_view_By_Where.FETCH_NEXT == null || i_Params_Get_Entity_view_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Entity_view_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_Where_Adv(i_Params_Get_Entity_view_By_Where.DESCRIPTION, i_Params_Get_Entity_view_By_Where.OWNER_ID, i_Params_Get_Entity_view_By_Where.OFFSET, i_Params_Get_Entity_view_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            i_Params_Get_Entity_view_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_Where_Adv", i_Params_Get_Entity_view_By_Where_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_Where_Adv
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_Where_Adv(Params_Get_Area_kpi_user_access_By_Where i_Params_Get_Area_kpi_user_access_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_Where_Adv", i_Params_Get_Area_kpi_user_access_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Area_kpi_user_access_By_Where.OWNER_ID == null || i_Params_Get_Area_kpi_user_access_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Area_kpi_user_access_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Area_kpi_user_access_By_Where.OFFSET == null)
            {
                i_Params_Get_Area_kpi_user_access_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Area_kpi_user_access_By_Where.FETCH_NEXT == null || i_Params_Get_Area_kpi_user_access_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Area_kpi_user_access_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_Where_Adv(i_Params_Get_Area_kpi_user_access_By_Where.DESCRIPTION, i_Params_Get_Area_kpi_user_access_By_Where.OWNER_ID, i_Params_Get_Area_kpi_user_access_By_Where.OFFSET, i_Params_Get_Area_kpi_user_access_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oArea_kpi_user_access.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi_user_access.Area);
                        oArea_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi_user_access.Organization_data_source_kpi);
                        oArea_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oArea_kpi_user_access.User);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            i_Params_Get_Area_kpi_user_access_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_Where_Adv", i_Params_Get_Area_kpi_user_access_By_Where_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_Where_Adv
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_Where_Adv(Params_Get_Site_kpi_user_access_By_Where i_Params_Get_Site_kpi_user_access_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_Where_Adv", i_Params_Get_Site_kpi_user_access_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Site_kpi_user_access_By_Where.OWNER_ID == null || i_Params_Get_Site_kpi_user_access_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Site_kpi_user_access_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Site_kpi_user_access_By_Where.OFFSET == null)
            {
                i_Params_Get_Site_kpi_user_access_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Site_kpi_user_access_By_Where.FETCH_NEXT == null || i_Params_Get_Site_kpi_user_access_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Site_kpi_user_access_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_Where_Adv(i_Params_Get_Site_kpi_user_access_By_Where.DESCRIPTION, i_Params_Get_Site_kpi_user_access_By_Where.OWNER_ID, i_Params_Get_Site_kpi_user_access_By_Where.OFFSET, i_Params_Get_Site_kpi_user_access_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oSite_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi_user_access.Organization_data_source_kpi);
                        oSite_kpi_user_access.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi_user_access.Site);
                        oSite_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oSite_kpi_user_access.User);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            i_Params_Get_Site_kpi_user_access_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_Where_Adv", i_Params_Get_Site_kpi_user_access_By_Where_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_Where_Adv
        public List<Entity_kpi> Get_Entity_kpi_By_Where_Adv(Params_Get_Entity_kpi_By_Where i_Params_Get_Entity_kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_Where_Adv", i_Params_Get_Entity_kpi_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Entity_kpi_By_Where.OWNER_ID == null || i_Params_Get_Entity_kpi_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Entity_kpi_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Entity_kpi_By_Where.OFFSET == null)
            {
                i_Params_Get_Entity_kpi_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Entity_kpi_By_Where.FETCH_NEXT == null || i_Params_Get_Entity_kpi_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Entity_kpi_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_Where_Adv(i_Params_Get_Entity_kpi_By_Where.DESCRIPTION, i_Params_Get_Entity_kpi_By_Where.OWNER_ID, i_Params_Get_Entity_kpi_By_Where.OFFSET, i_Params_Get_Entity_kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oEntity_kpi.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi.Entity);
                        oEntity_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi.Organization_data_source_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            i_Params_Get_Entity_kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_Where_Adv", i_Params_Get_Entity_kpi_By_Where_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_Where_Adv
        public List<Entity> Get_Entity_By_Where_Adv(Params_Get_Entity_By_Where i_Params_Get_Entity_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_Where_Adv", i_Params_Get_Entity_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Entity_By_Where.OWNER_ID == null || i_Params_Get_Entity_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Entity_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Entity_By_Where.OFFSET == null)
            {
                i_Params_Get_Entity_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Entity_By_Where.FETCH_NEXT == null || i_Params_Get_Entity_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Entity_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_Where_Adv(i_Params_Get_Entity_By_Where.NAME, i_Params_Get_Entity_By_Where.GLA_UNIT, i_Params_Get_Entity_By_Where.UNIT, i_Params_Get_Entity_By_Where.IMAGE_URL, i_Params_Get_Entity_By_Where.SOLID_GLTF_URL, i_Params_Get_Entity_By_Where.OWNER_ID, i_Params_Get_Entity_By_Where.OFFSET, i_Params_Get_Entity_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            i_Params_Get_Entity_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_Where_Adv", i_Params_Get_Entity_By_Where_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_Where_Adv
        public List<District_kpi> Get_District_kpi_By_Where_Adv(Params_Get_District_kpi_By_Where i_Params_Get_District_kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_Where_Adv", i_Params_Get_District_kpi_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_District_kpi_By_Where.OWNER_ID == null || i_Params_Get_District_kpi_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_District_kpi_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_District_kpi_By_Where.OFFSET == null)
            {
                i_Params_Get_District_kpi_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_District_kpi_By_Where.FETCH_NEXT == null || i_Params_Get_District_kpi_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_District_kpi_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_Where_Adv(i_Params_Get_District_kpi_By_Where.DESCRIPTION, i_Params_Get_District_kpi_By_Where.OWNER_ID, i_Params_Get_District_kpi_By_Where.OFFSET, i_Params_Get_District_kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oDistrict_kpi.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi.District);
                        oDistrict_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi.Organization_data_source_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            i_Params_Get_District_kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_Where_Adv", i_Params_Get_District_kpi_By_Where_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_User_level_access_By_Where_Adv
        public List<User_level_access> Get_User_level_access_By_Where_Adv(Params_Get_User_level_access_By_Where i_Params_Get_User_level_access_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<User_level_access> oList_User_level_access = null;
            var i_Params_Get_User_level_access_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_Where_Adv", i_Params_Get_User_level_access_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_User_level_access_By_Where.OWNER_ID == null || i_Params_Get_User_level_access_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_User_level_access_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_User_level_access_By_Where.OFFSET == null)
            {
                i_Params_Get_User_level_access_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_User_level_access_By_Where.FETCH_NEXT == null || i_Params_Get_User_level_access_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_User_level_access_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.User_level_access> oList_DBEntry = _AppContext.Get_User_level_access_By_Where_Adv(i_Params_Get_User_level_access_By_Where.DESCRIPTION, i_Params_Get_User_level_access_By_Where.OWNER_ID, i_Params_Get_User_level_access_By_Where.OFFSET, i_Params_Get_User_level_access_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
                        oUser_level_access.Organization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
                        oUser_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
                        oUser_level_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            i_Params_Get_User_level_access_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_Where_Adv", i_Params_Get_User_level_access_By_Where_json, false);
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_districtnex_module_By_Where_Adv
        public List<User_districtnex_module> Get_User_districtnex_module_By_Where_Adv(Params_Get_User_districtnex_module_By_Where i_Params_Get_User_districtnex_module_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<User_districtnex_module> oList_User_districtnex_module = null;
            var i_Params_Get_User_districtnex_module_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_User_districtnex_module_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_districtnex_module_By_Where_Adv", i_Params_Get_User_districtnex_module_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_User_districtnex_module_By_Where.OWNER_ID == null || i_Params_Get_User_districtnex_module_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_User_districtnex_module_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_User_districtnex_module_By_Where.OFFSET == null)
            {
                i_Params_Get_User_districtnex_module_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_User_districtnex_module_By_Where.FETCH_NEXT == null || i_Params_Get_User_districtnex_module_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_User_districtnex_module_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.User_districtnex_module> oList_DBEntry = _AppContext.Get_User_districtnex_module_By_Where_Adv(i_Params_Get_User_districtnex_module_By_Where.DESCRIPTION, i_Params_Get_User_districtnex_module_By_Where.OWNER_ID, i_Params_Get_User_districtnex_module_By_Where.OFFSET, i_Params_Get_User_districtnex_module_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oUser_districtnex_module);
                        oUser_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oUser_districtnex_module.Districtnex_module);
                        oUser_districtnex_module.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_districtnex_module.User);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            i_Params_Get_User_districtnex_module_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_districtnex_module_By_Where_Adv", i_Params_Get_User_districtnex_module_By_Where_json, false);
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_Where_Adv
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_Where_Adv(Params_Get_Entity_kpi_user_access_By_Where i_Params_Get_Entity_kpi_user_access_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_Where_Adv", i_Params_Get_Entity_kpi_user_access_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Entity_kpi_user_access_By_Where.OWNER_ID == null || i_Params_Get_Entity_kpi_user_access_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Entity_kpi_user_access_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Entity_kpi_user_access_By_Where.OFFSET == null)
            {
                i_Params_Get_Entity_kpi_user_access_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Entity_kpi_user_access_By_Where.FETCH_NEXT == null || i_Params_Get_Entity_kpi_user_access_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Entity_kpi_user_access_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_Where_Adv(i_Params_Get_Entity_kpi_user_access_By_Where.DESCRIPTION, i_Params_Get_Entity_kpi_user_access_By_Where.OWNER_ID, i_Params_Get_Entity_kpi_user_access_By_Where.OFFSET, i_Params_Get_Entity_kpi_user_access_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oEntity_kpi_user_access.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi_user_access.Entity);
                        oEntity_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi_user_access.Organization_data_source_kpi);
                        oEntity_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oEntity_kpi_user_access.User);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            i_Params_Get_Entity_kpi_user_access_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_Where_Adv", i_Params_Get_Entity_kpi_user_access_By_Where_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_District_view_By_Where_Adv
        public List<District_view> Get_District_view_By_Where_Adv(Params_Get_District_view_By_Where i_Params_Get_District_view_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<District_view> oList_District_view = null;
            var i_Params_Get_District_view_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_District_view_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_view_By_Where_Adv", i_Params_Get_District_view_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_District_view_By_Where.OWNER_ID == null || i_Params_Get_District_view_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_District_view_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_District_view_By_Where.OFFSET == null)
            {
                i_Params_Get_District_view_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_District_view_By_Where.FETCH_NEXT == null || i_Params_Get_District_view_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_District_view_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.District_view> oList_DBEntry = _AppContext.Get_District_view_By_Where_Adv(i_Params_Get_District_view_By_Where.DESCRIPTION, i_Params_Get_District_view_By_Where.OWNER_ID, i_Params_Get_District_view_By_Where.OFFSET, i_Params_Get_District_view_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_District_view = new List<District_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_view);
                        oDistrict_view.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_view.District);
                        oDistrict_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oDistrict_view.View_type_setup);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            i_Params_Get_District_view_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_view_By_Where_Adv", i_Params_Get_District_view_By_Where_json, false);
            }
            return oList_District_view;
        }
        #endregion
        #region Get_Area_By_Where_Adv
        public List<Area> Get_Area_By_Where_Adv(Params_Get_Area_By_Where i_Params_Get_Area_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_Where_Adv", i_Params_Get_Area_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Area_By_Where.OWNER_ID == null || i_Params_Get_Area_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Area_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Area_By_Where.OFFSET == null)
            {
                i_Params_Get_Area_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Area_By_Where.FETCH_NEXT == null || i_Params_Get_Area_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Area_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_Where_Adv(i_Params_Get_Area_By_Where.NAME, i_Params_Get_Area_By_Where.LOCATION, i_Params_Get_Area_By_Where.UNIT, i_Params_Get_Area_By_Where.IMAGE_URL, i_Params_Get_Area_By_Where.LOGO_URL, i_Params_Get_Area_By_Where.SOLID_GLTF_URL, i_Params_Get_Area_By_Where.AREA_COLOR, i_Params_Get_Area_By_Where.BORDER_COLOR, i_Params_Get_Area_By_Where.STUDY_ZONE_NAME, i_Params_Get_Area_By_Where.OWNER_ID, i_Params_Get_Area_By_Where.OFFSET, i_Params_Get_Area_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oArea.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oArea.District);
                        oArea.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oArea.Region);
                        oArea.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oArea.Top_level);
                        oList_Area.Add(oArea);
                    }
                }
            }
            i_Params_Get_Area_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_Where_Adv", i_Params_Get_Area_By_Where_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_Where_Adv
        public List<Area_view> Get_Area_view_By_Where_Adv(Params_Get_Area_view_By_Where i_Params_Get_Area_view_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_Where_Adv", i_Params_Get_Area_view_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Area_view_By_Where.OWNER_ID == null || i_Params_Get_Area_view_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Area_view_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Area_view_By_Where.OFFSET == null)
            {
                i_Params_Get_Area_view_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Area_view_By_Where.FETCH_NEXT == null || i_Params_Get_Area_view_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Area_view_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_Where_Adv(i_Params_Get_Area_view_By_Where.DESCRIPTION, i_Params_Get_Area_view_By_Where.OWNER_ID, i_Params_Get_Area_view_By_Where.OFFSET, i_Params_Get_Area_view_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oArea_view.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_view.Area);
                        oArea_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oArea_view.View_type_setup);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            i_Params_Get_Area_view_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_Where_Adv", i_Params_Get_Area_view_By_Where_json, false);
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Site_kpi_By_Where_Adv
        public List<Site_kpi> Get_Site_kpi_By_Where_Adv(Params_Get_Site_kpi_By_Where i_Params_Get_Site_kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_Where_Adv", i_Params_Get_Site_kpi_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Site_kpi_By_Where.OWNER_ID == null || i_Params_Get_Site_kpi_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Site_kpi_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Site_kpi_By_Where.OFFSET == null)
            {
                i_Params_Get_Site_kpi_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Site_kpi_By_Where.FETCH_NEXT == null || i_Params_Get_Site_kpi_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Site_kpi_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_Where_Adv(i_Params_Get_Site_kpi_By_Where.DESCRIPTION, i_Params_Get_Site_kpi_By_Where.OWNER_ID, i_Params_Get_Site_kpi_By_Where.OFFSET, i_Params_Get_Site_kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oSite_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi.Organization_data_source_kpi);
                        oSite_kpi.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi.Site);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            i_Params_Get_Site_kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_Where_Adv", i_Params_Get_Site_kpi_By_Where_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Organization_relation_By_Where_Adv
        public List<Organization_relation> Get_Organization_relation_By_Where_Adv(Params_Get_Organization_relation_By_Where i_Params_Get_Organization_relation_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_Where_Adv", i_Params_Get_Organization_relation_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_relation_By_Where.OWNER_ID == null || i_Params_Get_Organization_relation_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Organization_relation_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_relation_By_Where.OFFSET == null)
            {
                i_Params_Get_Organization_relation_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Organization_relation_By_Where.FETCH_NEXT == null || i_Params_Get_Organization_relation_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_relation_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_Where_Adv(i_Params_Get_Organization_relation_By_Where.DESCRIPTION, i_Params_Get_Organization_relation_By_Where.OWNER_ID, i_Params_Get_Organization_relation_By_Where.OFFSET, i_Params_Get_Organization_relation_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            i_Params_Get_Organization_relation_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_Where_Adv", i_Params_Get_Organization_relation_By_Where_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_Where_Adv
        public List<Setup> Get_Setup_By_Where_Adv(Params_Get_Setup_By_Where i_Params_Get_Setup_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where_Adv", i_Params_Get_Setup_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Setup_By_Where.OWNER_ID == null || i_Params_Get_Setup_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Setup_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Setup_By_Where.OFFSET == null)
            {
                i_Params_Get_Setup_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Setup_By_Where.FETCH_NEXT == null || i_Params_Get_Setup_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Setup_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where_Adv(i_Params_Get_Setup_By_Where.VALUE, i_Params_Get_Setup_By_Where.DESCRIPTION, i_Params_Get_Setup_By_Where.OWNER_ID, i_Params_Get_Setup_By_Where.OFFSET, i_Params_Get_Setup_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where_Adv", i_Params_Get_Setup_By_Where_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_Where_Adv
        public List<Area_kpi> Get_Area_kpi_By_Where_Adv(Params_Get_Area_kpi_By_Where i_Params_Get_Area_kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_Where_Adv", i_Params_Get_Area_kpi_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Area_kpi_By_Where.OWNER_ID == null || i_Params_Get_Area_kpi_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Area_kpi_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Area_kpi_By_Where.OFFSET == null)
            {
                i_Params_Get_Area_kpi_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Area_kpi_By_Where.FETCH_NEXT == null || i_Params_Get_Area_kpi_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Area_kpi_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_Where_Adv(i_Params_Get_Area_kpi_By_Where.DESCRIPTION, i_Params_Get_Area_kpi_By_Where.OWNER_ID, i_Params_Get_Area_kpi_By_Where.OFFSET, i_Params_Get_Area_kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oArea_kpi.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi.Area);
                        oArea_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi.Organization_data_source_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            i_Params_Get_Area_kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_Where_Adv", i_Params_Get_Area_kpi_By_Where_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Region_By_Where_Adv
        public List<Region> Get_Region_By_Where_Adv(Params_Get_Region_By_Where i_Params_Get_Region_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Region> oList_Region = null;
            var i_Params_Get_Region_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_Where_Adv", i_Params_Get_Region_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Region_By_Where.OWNER_ID == null || i_Params_Get_Region_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Region_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Region_By_Where.OFFSET == null)
            {
                i_Params_Get_Region_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Region_By_Where.FETCH_NEXT == null || i_Params_Get_Region_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Region_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Region> oList_DBEntry = _AppContext.Get_Region_By_Where_Adv(i_Params_Get_Region_By_Where.NAME, i_Params_Get_Region_By_Where.LOCATION, i_Params_Get_Region_By_Where.UNIT, i_Params_Get_Region_By_Where.IMAGE_URL, i_Params_Get_Region_By_Where.LOGO_URL, i_Params_Get_Region_By_Where.AREA_COLOR, i_Params_Get_Region_By_Where.BORDER_COLOR, i_Params_Get_Region_By_Where.STUDY_ZONE_NAME, i_Params_Get_Region_By_Where.OWNER_ID, i_Params_Get_Region_By_Where.OFFSET, i_Params_Get_Region_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Region = new List<Region>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values(oDBEntry, oRegion);
                        oRegion.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            i_Params_Get_Region_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_Where_Adv", i_Params_Get_Region_By_Where_json, false);
            }
            return oList_Region;
        }
        #endregion
        #region Get_District_By_Where_Adv
        public List<District> Get_District_By_Where_Adv(Params_Get_District_By_Where i_Params_Get_District_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<District> oList_District = null;
            var i_Params_Get_District_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_District_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_Where_Adv", i_Params_Get_District_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_District_By_Where.OWNER_ID == null || i_Params_Get_District_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_District_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_District_By_Where.OFFSET == null)
            {
                i_Params_Get_District_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_District_By_Where.FETCH_NEXT == null || i_Params_Get_District_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_District_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_Where_Adv(i_Params_Get_District_By_Where.NAME, i_Params_Get_District_By_Where.LOCATION, i_Params_Get_District_By_Where.UNIT, i_Params_Get_District_By_Where.IMAGE_URL, i_Params_Get_District_By_Where.LOGO_URL, i_Params_Get_District_By_Where.SOLID_GLTF_URL, i_Params_Get_District_By_Where.AREA_COLOR, i_Params_Get_District_By_Where.BORDER_COLOR, i_Params_Get_District_By_Where.STUDY_ZONE_NAME, i_Params_Get_District_By_Where.OWNER_ID, i_Params_Get_District_By_Where.OFFSET, i_Params_Get_District_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oDistrict.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oDistrict.Region);
                        oDistrict.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oDistrict.Top_level);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            i_Params_Get_District_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_Where_Adv", i_Params_Get_District_By_Where_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_District_kpi_user_access_By_Where_Adv
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_Where_Adv(Params_Get_District_kpi_user_access_By_Where i_Params_Get_District_kpi_user_access_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_Where_Adv", i_Params_Get_District_kpi_user_access_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_District_kpi_user_access_By_Where.OWNER_ID == null || i_Params_Get_District_kpi_user_access_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_District_kpi_user_access_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_District_kpi_user_access_By_Where.OFFSET == null)
            {
                i_Params_Get_District_kpi_user_access_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_District_kpi_user_access_By_Where.FETCH_NEXT == null || i_Params_Get_District_kpi_user_access_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_District_kpi_user_access_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_Where_Adv(i_Params_Get_District_kpi_user_access_By_Where.DESCRIPTION, i_Params_Get_District_kpi_user_access_By_Where.OWNER_ID, i_Params_Get_District_kpi_user_access_By_Where.OFFSET, i_Params_Get_District_kpi_user_access_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oDistrict_kpi_user_access.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi_user_access.District);
                        oDistrict_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi_user_access.Organization_data_source_kpi);
                        oDistrict_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oDistrict_kpi_user_access.User);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            i_Params_Get_District_kpi_user_access_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_Where_Adv", i_Params_Get_District_kpi_user_access_By_Where_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_Where_Adv
        public List<User> Get_User_By_Where_Adv(Params_Get_User_By_Where i_Params_Get_User_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<User> oList_User = null;
            var i_Params_Get_User_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_User_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_Where_Adv", i_Params_Get_User_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_User_By_Where.OWNER_ID == null || i_Params_Get_User_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_User_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_User_By_Where.OFFSET == null)
            {
                i_Params_Get_User_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_User_By_Where.FETCH_NEXT == null || i_Params_Get_User_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_User_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_Where_Adv(i_Params_Get_User_By_Where.FIRST_NAME, i_Params_Get_User_By_Where.LAST_NAME, i_Params_Get_User_By_Where.USERNAME, i_Params_Get_User_By_Where.PASSWORD, i_Params_Get_User_By_Where.EMAIL, i_Params_Get_User_By_Where.PHONE_NUMBER, i_Params_Get_User_By_Where.IMAGE_URL, i_Params_Get_User_By_Where.USER_DISTRICTNEX_WALKTHROUGH, i_Params_Get_User_By_Where.USER_ADMIN_WALKTHROUGH, i_Params_Get_User_By_Where.OWNER_ID, i_Params_Get_User_By_Where.OFFSET, i_Params_Get_User_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            i_Params_Get_User_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_Where_Adv", i_Params_Get_User_By_Where_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_Site_By_Where_Adv
        public List<Site> Get_Site_By_Where_Adv(Params_Get_Site_By_Where i_Params_Get_Site_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_Where_Adv", i_Params_Get_Site_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Site_By_Where.OWNER_ID == null || i_Params_Get_Site_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Site_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Site_By_Where.OFFSET == null)
            {
                i_Params_Get_Site_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Site_By_Where.FETCH_NEXT == null || i_Params_Get_Site_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Site_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_Where_Adv(i_Params_Get_Site_By_Where.NAME, i_Params_Get_Site_By_Where.LOCATION, i_Params_Get_Site_By_Where.UNIT, i_Params_Get_Site_By_Where.IMAGE_URL, i_Params_Get_Site_By_Where.LOGO_URL, i_Params_Get_Site_By_Where.SOLID_GLTF_URL, i_Params_Get_Site_By_Where.AREA_COLOR, i_Params_Get_Site_By_Where.BORDER_COLOR, i_Params_Get_Site_By_Where.STUDY_ZONE_NAME, i_Params_Get_Site_By_Where.OWNER_ID, i_Params_Get_Site_By_Where.OFFSET, i_Params_Get_Site_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oSite.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oSite.Area);
                        oSite.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oSite.District);
                        oSite.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oSite.Region);
                        oSite.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oSite.Top_level);
                        oList_Site.Add(oSite);
                    }
                }
            }
            i_Params_Get_Site_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_Where_Adv", i_Params_Get_Site_By_Where_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_User_theme_By_Where_Adv
        public List<User_theme> Get_User_theme_By_Where_Adv(Params_Get_User_theme_By_Where i_Params_Get_User_theme_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<User_theme> oList_User_theme = null;
            var i_Params_Get_User_theme_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_User_theme_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_theme_By_Where_Adv", i_Params_Get_User_theme_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_User_theme_By_Where.OWNER_ID == null || i_Params_Get_User_theme_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_User_theme_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_User_theme_By_Where.OFFSET == null)
            {
                i_Params_Get_User_theme_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_User_theme_By_Where.FETCH_NEXT == null || i_Params_Get_User_theme_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_User_theme_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.User_theme> oList_DBEntry = _AppContext.Get_User_theme_By_Where_Adv(i_Params_Get_User_theme_By_Where.DESCRIPTION, i_Params_Get_User_theme_By_Where.OWNER_ID, i_Params_Get_User_theme_By_Where.OFFSET, i_Params_Get_User_theme_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_User_theme = new List<User_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values(oDBEntry, oUser_theme);
                        oUser_theme.Organization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_theme, oUser_theme.Organization_theme);
                        oUser_theme.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_theme.User);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            i_Params_Get_User_theme_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_theme_By_Where_Adv", i_Params_Get_User_theme_By_Where_json, false);
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_Region_view_By_Where_Adv
        public List<Region_view> Get_Region_view_By_Where_Adv(Params_Get_Region_view_By_Where i_Params_Get_Region_view_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_Where_Adv", i_Params_Get_Region_view_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Region_view_By_Where.OWNER_ID == null || i_Params_Get_Region_view_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Region_view_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Region_view_By_Where.OFFSET == null)
            {
                i_Params_Get_Region_view_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Region_view_By_Where.FETCH_NEXT == null || i_Params_Get_Region_view_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Region_view_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_Where_Adv(i_Params_Get_Region_view_By_Where.DESCRIPTION, i_Params_Get_Region_view_By_Where.OWNER_ID, i_Params_Get_Region_view_By_Where.OFFSET, i_Params_Get_Region_view_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            i_Params_Get_Region_view_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_Where_Adv", i_Params_Get_Region_view_By_Where_json, false);
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Site_view_By_Where_In_List_Adv
        public List<Site_view> Get_Site_view_By_Where_In_List_Adv(Params_Get_Site_view_By_Where_In_List i_Params_Get_Site_view_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site_view> oList_Site_view = null;
            var i_Params_Get_Site_view_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_view_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_view_By_Where_In_List_Adv", i_Params_Get_Site_view_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Site_view_By_Where_In_List.OWNER_ID == null || i_Params_Get_Site_view_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Site_view_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Site_view_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Site_view_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Site_view_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Site_view_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Site_view_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Site_view_By_Where_In_List.SITE_ID_LIST == null)
            {
                i_Params_Get_Site_view_By_Where_In_List.SITE_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Site_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Site_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Site_view> oList_DBEntry = _AppContext.Get_Site_view_By_Where_In_List_Adv(i_Params_Get_Site_view_By_Where_In_List.DESCRIPTION, i_Params_Get_Site_view_By_Where_In_List.SITE_ID_LIST, i_Params_Get_Site_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST, i_Params_Get_Site_view_By_Where_In_List.OWNER_ID, i_Params_Get_Site_view_By_Where_In_List.OFFSET, i_Params_Get_Site_view_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site_view = new List<Site_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values(oDBEntry, oSite_view);
                        oSite_view.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_view.Site);
                        oSite_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oSite_view.View_type_setup);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            i_Params_Get_Site_view_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_view_By_Where_In_List_Adv", i_Params_Get_Site_view_By_Where_In_List_json, false);
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Removed_extrusion_By_Where_In_List_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_Where_In_List_Adv(Params_Get_Removed_extrusion_By_Where_In_List i_Params_Get_Removed_extrusion_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_Where_In_List_Adv", i_Params_Get_Removed_extrusion_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Removed_extrusion_By_Where_In_List.OWNER_ID == null || i_Params_Get_Removed_extrusion_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Removed_extrusion_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Removed_extrusion_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Removed_extrusion_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Removed_extrusion_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Removed_extrusion_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Removed_extrusion_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Removed_extrusion_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST == null)
            {
                i_Params_Get_Removed_extrusion_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_Where_In_List_Adv(i_Params_Get_Removed_extrusion_By_Where_In_List.EXTRUSION_IDENTIFIER, i_Params_Get_Removed_extrusion_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Removed_extrusion_By_Where_In_List.OWNER_ID, i_Params_Get_Removed_extrusion_By_Where_In_List.OFFSET, i_Params_Get_Removed_extrusion_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            i_Params_Get_Removed_extrusion_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_Where_In_List_Adv", i_Params_Get_Removed_extrusion_By_Where_In_List_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Entity_view_By_Where_In_List_Adv
        public List<Entity_view> Get_Entity_view_By_Where_In_List_Adv(Params_Get_Entity_view_By_Where_In_List i_Params_Get_Entity_view_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity_view> oList_Entity_view = null;
            var i_Params_Get_Entity_view_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_view_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_view_By_Where_In_List_Adv", i_Params_Get_Entity_view_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Entity_view_By_Where_In_List.OWNER_ID == null || i_Params_Get_Entity_view_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Entity_view_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Entity_view_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Entity_view_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Entity_view_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Entity_view_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Entity_view_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Entity_view_By_Where_In_List.ENTITY_ID_LIST == null)
            {
                i_Params_Get_Entity_view_By_Where_In_List.ENTITY_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Entity_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Entity_view> oList_DBEntry = _AppContext.Get_Entity_view_By_Where_In_List_Adv(i_Params_Get_Entity_view_By_Where_In_List.DESCRIPTION, i_Params_Get_Entity_view_By_Where_In_List.ENTITY_ID_LIST, i_Params_Get_Entity_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST, i_Params_Get_Entity_view_By_Where_In_List.OWNER_ID, i_Params_Get_Entity_view_By_Where_In_List.OFFSET, i_Params_Get_Entity_view_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_view.Entity);
                        oEntity_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oEntity_view.View_type_setup);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            i_Params_Get_Entity_view_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_view_By_Where_In_List_Adv", i_Params_Get_Entity_view_By_Where_In_List_json, false);
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_Where_In_List_Adv
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_Where_In_List_Adv(Params_Get_Area_kpi_user_access_By_Where_In_List i_Params_Get_Area_kpi_user_access_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_Where_In_List_Adv", i_Params_Get_Area_kpi_user_access_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Area_kpi_user_access_By_Where_In_List.OWNER_ID == null || i_Params_Get_Area_kpi_user_access_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Area_kpi_user_access_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Area_kpi_user_access_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Area_kpi_user_access_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Area_kpi_user_access_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Area_kpi_user_access_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Area_kpi_user_access_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Area_kpi_user_access_By_Where_In_List.USER_ID_LIST == null)
            {
                i_Params_Get_Area_kpi_user_access_By_Where_In_List.USER_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Area_kpi_user_access_By_Where_In_List.AREA_ID_LIST == null)
            {
                i_Params_Get_Area_kpi_user_access_By_Where_In_List.AREA_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Area_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST == null)
            {
                i_Params_Get_Area_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>();
            }
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_Where_In_List_Adv(i_Params_Get_Area_kpi_user_access_By_Where_In_List.DESCRIPTION, i_Params_Get_Area_kpi_user_access_By_Where_In_List.USER_ID_LIST, i_Params_Get_Area_kpi_user_access_By_Where_In_List.AREA_ID_LIST, i_Params_Get_Area_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_Area_kpi_user_access_By_Where_In_List.OWNER_ID, i_Params_Get_Area_kpi_user_access_By_Where_In_List.OFFSET, i_Params_Get_Area_kpi_user_access_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oArea_kpi_user_access.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi_user_access.Area);
                        oArea_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi_user_access.Organization_data_source_kpi);
                        oArea_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oArea_kpi_user_access.User);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            i_Params_Get_Area_kpi_user_access_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_Where_In_List_Adv", i_Params_Get_Area_kpi_user_access_By_Where_In_List_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_Where_In_List_Adv
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_Where_In_List_Adv(Params_Get_Site_kpi_user_access_By_Where_In_List i_Params_Get_Site_kpi_user_access_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_Where_In_List_Adv", i_Params_Get_Site_kpi_user_access_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Site_kpi_user_access_By_Where_In_List.OWNER_ID == null || i_Params_Get_Site_kpi_user_access_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Site_kpi_user_access_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Site_kpi_user_access_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Site_kpi_user_access_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Site_kpi_user_access_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Site_kpi_user_access_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Site_kpi_user_access_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Site_kpi_user_access_By_Where_In_List.USER_ID_LIST == null)
            {
                i_Params_Get_Site_kpi_user_access_By_Where_In_List.USER_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Site_kpi_user_access_By_Where_In_List.SITE_ID_LIST == null)
            {
                i_Params_Get_Site_kpi_user_access_By_Where_In_List.SITE_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Site_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST == null)
            {
                i_Params_Get_Site_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>();
            }
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_Where_In_List_Adv(i_Params_Get_Site_kpi_user_access_By_Where_In_List.DESCRIPTION, i_Params_Get_Site_kpi_user_access_By_Where_In_List.USER_ID_LIST, i_Params_Get_Site_kpi_user_access_By_Where_In_List.SITE_ID_LIST, i_Params_Get_Site_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_Site_kpi_user_access_By_Where_In_List.OWNER_ID, i_Params_Get_Site_kpi_user_access_By_Where_In_List.OFFSET, i_Params_Get_Site_kpi_user_access_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oSite_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi_user_access.Organization_data_source_kpi);
                        oSite_kpi_user_access.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi_user_access.Site);
                        oSite_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oSite_kpi_user_access.User);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            i_Params_Get_Site_kpi_user_access_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_Where_In_List_Adv", i_Params_Get_Site_kpi_user_access_By_Where_In_List_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_Where_In_List_Adv
        public List<Entity_kpi> Get_Entity_kpi_By_Where_In_List_Adv(Params_Get_Entity_kpi_By_Where_In_List i_Params_Get_Entity_kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_Where_In_List_Adv", i_Params_Get_Entity_kpi_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Entity_kpi_By_Where_In_List.OWNER_ID == null || i_Params_Get_Entity_kpi_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Entity_kpi_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Entity_kpi_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Entity_kpi_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Entity_kpi_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Entity_kpi_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Entity_kpi_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Entity_kpi_By_Where_In_List.ENTITY_ID_LIST == null)
            {
                i_Params_Get_Entity_kpi_By_Where_In_List.ENTITY_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST == null)
            {
                i_Params_Get_Entity_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>();
            }
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_Where_In_List_Adv(i_Params_Get_Entity_kpi_By_Where_In_List.DESCRIPTION, i_Params_Get_Entity_kpi_By_Where_In_List.ENTITY_ID_LIST, i_Params_Get_Entity_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_Entity_kpi_By_Where_In_List.OWNER_ID, i_Params_Get_Entity_kpi_By_Where_In_List.OFFSET, i_Params_Get_Entity_kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oEntity_kpi.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi.Entity);
                        oEntity_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi.Organization_data_source_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            i_Params_Get_Entity_kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_Where_In_List_Adv", i_Params_Get_Entity_kpi_By_Where_In_List_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_Where_In_List_Adv
        public List<Entity> Get_Entity_By_Where_In_List_Adv(Params_Get_Entity_By_Where_In_List i_Params_Get_Entity_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_Where_In_List_Adv", i_Params_Get_Entity_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Entity_By_Where_In_List.OWNER_ID == null || i_Params_Get_Entity_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Entity_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Entity_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Entity_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Entity_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Entity_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Entity_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Entity_By_Where_In_List.SITE_ID_LIST == null)
            {
                i_Params_Get_Entity_By_Where_In_List.SITE_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_By_Where_In_List.AREA_ID_LIST == null)
            {
                i_Params_Get_Entity_By_Where_In_List.AREA_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_By_Where_In_List.DISTRICT_ID_LIST == null)
            {
                i_Params_Get_Entity_By_Where_In_List.DISTRICT_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_By_Where_In_List.REGION_ID_LIST == null)
            {
                i_Params_Get_Entity_By_Where_In_List.REGION_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_By_Where_In_List.TOP_LEVEL_ID_LIST == null)
            {
                i_Params_Get_Entity_By_Where_In_List.TOP_LEVEL_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_By_Where_In_List.ENTITY_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Entity_By_Where_In_List.ENTITY_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_Where_In_List_Adv(i_Params_Get_Entity_By_Where_In_List.NAME, i_Params_Get_Entity_By_Where_In_List.GLA_UNIT, i_Params_Get_Entity_By_Where_In_List.UNIT, i_Params_Get_Entity_By_Where_In_List.IMAGE_URL, i_Params_Get_Entity_By_Where_In_List.SOLID_GLTF_URL, i_Params_Get_Entity_By_Where_In_List.SITE_ID_LIST, i_Params_Get_Entity_By_Where_In_List.AREA_ID_LIST, i_Params_Get_Entity_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_Entity_By_Where_In_List.REGION_ID_LIST, i_Params_Get_Entity_By_Where_In_List.TOP_LEVEL_ID_LIST, i_Params_Get_Entity_By_Where_In_List.ENTITY_TYPE_SETUP_ID_LIST, i_Params_Get_Entity_By_Where_In_List.OWNER_ID, i_Params_Get_Entity_By_Where_In_List.OFFSET, i_Params_Get_Entity_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oEntity.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oEntity.Area);
                        oEntity.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oEntity.District);
                        oEntity.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oEntity.Region);
                        oEntity.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oEntity.Site);
                        oEntity.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oEntity.Top_level);
                        oEntity.Entity_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Entity_type_setup, oEntity.Entity_type_setup);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            i_Params_Get_Entity_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_Where_In_List_Adv", i_Params_Get_Entity_By_Where_In_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_Where_In_List_Adv
        public List<District_kpi> Get_District_kpi_By_Where_In_List_Adv(Params_Get_District_kpi_By_Where_In_List i_Params_Get_District_kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_Where_In_List_Adv", i_Params_Get_District_kpi_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_District_kpi_By_Where_In_List.OWNER_ID == null || i_Params_Get_District_kpi_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_District_kpi_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_District_kpi_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_District_kpi_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_District_kpi_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_District_kpi_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_District_kpi_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_District_kpi_By_Where_In_List.DISTRICT_ID_LIST == null)
            {
                i_Params_Get_District_kpi_By_Where_In_List.DISTRICT_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_District_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST == null)
            {
                i_Params_Get_District_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>();
            }
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_Where_In_List_Adv(i_Params_Get_District_kpi_By_Where_In_List.DESCRIPTION, i_Params_Get_District_kpi_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_District_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_District_kpi_By_Where_In_List.OWNER_ID, i_Params_Get_District_kpi_By_Where_In_List.OFFSET, i_Params_Get_District_kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oDistrict_kpi.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi.District);
                        oDistrict_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi.Organization_data_source_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            i_Params_Get_District_kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_Where_In_List_Adv", i_Params_Get_District_kpi_By_Where_In_List_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_User_level_access_By_Where_In_List_Adv
        public List<User_level_access> Get_User_level_access_By_Where_In_List_Adv(Params_Get_User_level_access_By_Where_In_List i_Params_Get_User_level_access_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<User_level_access> oList_User_level_access = null;
            var i_Params_Get_User_level_access_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_User_level_access_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_level_access_By_Where_In_List_Adv", i_Params_Get_User_level_access_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_User_level_access_By_Where_In_List.OWNER_ID == null || i_Params_Get_User_level_access_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_User_level_access_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_User_level_access_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_User_level_access_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_User_level_access_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_User_level_access_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_User_level_access_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_User_level_access_By_Where_In_List.ORGANIZATION_LEVEL_ACCESS_ID_LIST == null)
            {
                i_Params_Get_User_level_access_By_Where_In_List.ORGANIZATION_LEVEL_ACCESS_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_User_level_access_By_Where_In_List.USER_ID_LIST == null)
            {
                i_Params_Get_User_level_access_By_Where_In_List.USER_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_User_level_access_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST == null)
            {
                i_Params_Get_User_level_access_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.User_level_access> oList_DBEntry = _AppContext.Get_User_level_access_By_Where_In_List_Adv(i_Params_Get_User_level_access_By_Where_In_List.DESCRIPTION, i_Params_Get_User_level_access_By_Where_In_List.ORGANIZATION_LEVEL_ACCESS_ID_LIST, i_Params_Get_User_level_access_By_Where_In_List.USER_ID_LIST, i_Params_Get_User_level_access_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_User_level_access_By_Where_In_List.OWNER_ID, i_Params_Get_User_level_access_By_Where_In_List.OFFSET, i_Params_Get_User_level_access_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values(oDBEntry, oUser_level_access);
                        oUser_level_access.Organization_level_access = new Organization_level_access();
                        Props.Copy_Prop_Values(oDBEntry.Organization_level_access, oUser_level_access.Organization_level_access);
                        oUser_level_access.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oUser_level_access.Data_level_setup);
                        oUser_level_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_level_access.User);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            i_Params_Get_User_level_access_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_level_access_By_Where_In_List_Adv", i_Params_Get_User_level_access_By_Where_In_List_json, false);
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_districtnex_module_By_Where_In_List_Adv
        public List<User_districtnex_module> Get_User_districtnex_module_By_Where_In_List_Adv(Params_Get_User_districtnex_module_By_Where_In_List i_Params_Get_User_districtnex_module_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<User_districtnex_module> oList_User_districtnex_module = null;
            var i_Params_Get_User_districtnex_module_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_User_districtnex_module_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_districtnex_module_By_Where_In_List_Adv", i_Params_Get_User_districtnex_module_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_User_districtnex_module_By_Where_In_List.OWNER_ID == null || i_Params_Get_User_districtnex_module_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_User_districtnex_module_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_User_districtnex_module_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_User_districtnex_module_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_User_districtnex_module_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_User_districtnex_module_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_User_districtnex_module_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_User_districtnex_module_By_Where_In_List.USER_ID_LIST == null)
            {
                i_Params_Get_User_districtnex_module_By_Where_In_List.USER_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_User_districtnex_module_By_Where_In_List.DISTRICTNEX_MODULE_ID_LIST == null)
            {
                i_Params_Get_User_districtnex_module_By_Where_In_List.DISTRICTNEX_MODULE_ID_LIST = new List<int?>();
            }
            List<DALC.User_districtnex_module> oList_DBEntry = _AppContext.Get_User_districtnex_module_By_Where_In_List_Adv(i_Params_Get_User_districtnex_module_By_Where_In_List.DESCRIPTION, i_Params_Get_User_districtnex_module_By_Where_In_List.USER_ID_LIST, i_Params_Get_User_districtnex_module_By_Where_In_List.DISTRICTNEX_MODULE_ID_LIST, i_Params_Get_User_districtnex_module_By_Where_In_List.OWNER_ID, i_Params_Get_User_districtnex_module_By_Where_In_List.OFFSET, i_Params_Get_User_districtnex_module_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oUser_districtnex_module);
                        oUser_districtnex_module.Districtnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry.Districtnex_module, oUser_districtnex_module.Districtnex_module);
                        oUser_districtnex_module.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_districtnex_module.User);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            i_Params_Get_User_districtnex_module_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_districtnex_module_By_Where_In_List_Adv", i_Params_Get_User_districtnex_module_By_Where_In_List_json, false);
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_Where_In_List_Adv
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_Where_In_List_Adv(Params_Get_Entity_kpi_user_access_By_Where_In_List i_Params_Get_Entity_kpi_user_access_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_Where_In_List_Adv", i_Params_Get_Entity_kpi_user_access_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Entity_kpi_user_access_By_Where_In_List.OWNER_ID == null || i_Params_Get_Entity_kpi_user_access_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Entity_kpi_user_access_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Entity_kpi_user_access_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Entity_kpi_user_access_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Entity_kpi_user_access_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Entity_kpi_user_access_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Entity_kpi_user_access_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Entity_kpi_user_access_By_Where_In_List.USER_ID_LIST == null)
            {
                i_Params_Get_Entity_kpi_user_access_By_Where_In_List.USER_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_kpi_user_access_By_Where_In_List.ENTITY_ID_LIST == null)
            {
                i_Params_Get_Entity_kpi_user_access_By_Where_In_List.ENTITY_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Entity_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST == null)
            {
                i_Params_Get_Entity_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>();
            }
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_Where_In_List_Adv(i_Params_Get_Entity_kpi_user_access_By_Where_In_List.DESCRIPTION, i_Params_Get_Entity_kpi_user_access_By_Where_In_List.USER_ID_LIST, i_Params_Get_Entity_kpi_user_access_By_Where_In_List.ENTITY_ID_LIST, i_Params_Get_Entity_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_Entity_kpi_user_access_By_Where_In_List.OWNER_ID, i_Params_Get_Entity_kpi_user_access_By_Where_In_List.OFFSET, i_Params_Get_Entity_kpi_user_access_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oEntity_kpi_user_access.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oEntity_kpi_user_access.Entity);
                        oEntity_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oEntity_kpi_user_access.Organization_data_source_kpi);
                        oEntity_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oEntity_kpi_user_access.User);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            i_Params_Get_Entity_kpi_user_access_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_Where_In_List_Adv", i_Params_Get_Entity_kpi_user_access_By_Where_In_List_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_District_view_By_Where_In_List_Adv
        public List<District_view> Get_District_view_By_Where_In_List_Adv(Params_Get_District_view_By_Where_In_List i_Params_Get_District_view_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<District_view> oList_District_view = null;
            var i_Params_Get_District_view_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_District_view_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_view_By_Where_In_List_Adv", i_Params_Get_District_view_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_District_view_By_Where_In_List.OWNER_ID == null || i_Params_Get_District_view_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_District_view_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_District_view_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_District_view_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_District_view_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_District_view_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_District_view_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_District_view_By_Where_In_List.DISTRICT_ID_LIST == null)
            {
                i_Params_Get_District_view_By_Where_In_List.DISTRICT_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_District_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_District_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.District_view> oList_DBEntry = _AppContext.Get_District_view_By_Where_In_List_Adv(i_Params_Get_District_view_By_Where_In_List.DESCRIPTION, i_Params_Get_District_view_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_District_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST, i_Params_Get_District_view_By_Where_In_List.OWNER_ID, i_Params_Get_District_view_By_Where_In_List.OFFSET, i_Params_Get_District_view_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_District_view = new List<District_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_view);
                        oDistrict_view.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_view.District);
                        oDistrict_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oDistrict_view.View_type_setup);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            i_Params_Get_District_view_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_view_By_Where_In_List_Adv", i_Params_Get_District_view_By_Where_In_List_json, false);
            }
            return oList_District_view;
        }
        #endregion
        #region Get_Area_By_Where_In_List_Adv
        public List<Area> Get_Area_By_Where_In_List_Adv(Params_Get_Area_By_Where_In_List i_Params_Get_Area_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_Where_In_List_Adv", i_Params_Get_Area_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Area_By_Where_In_List.OWNER_ID == null || i_Params_Get_Area_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Area_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Area_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Area_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Area_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Area_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Area_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Area_By_Where_In_List.DISTRICT_ID_LIST == null)
            {
                i_Params_Get_Area_By_Where_In_List.DISTRICT_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Area_By_Where_In_List.REGION_ID_LIST == null)
            {
                i_Params_Get_Area_By_Where_In_List.REGION_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Area_By_Where_In_List.TOP_LEVEL_ID_LIST == null)
            {
                i_Params_Get_Area_By_Where_In_List.TOP_LEVEL_ID_LIST = new List<long?>();
            }
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_Where_In_List_Adv(i_Params_Get_Area_By_Where_In_List.NAME, i_Params_Get_Area_By_Where_In_List.LOCATION, i_Params_Get_Area_By_Where_In_List.UNIT, i_Params_Get_Area_By_Where_In_List.IMAGE_URL, i_Params_Get_Area_By_Where_In_List.LOGO_URL, i_Params_Get_Area_By_Where_In_List.SOLID_GLTF_URL, i_Params_Get_Area_By_Where_In_List.AREA_COLOR, i_Params_Get_Area_By_Where_In_List.BORDER_COLOR, i_Params_Get_Area_By_Where_In_List.STUDY_ZONE_NAME, i_Params_Get_Area_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_Area_By_Where_In_List.REGION_ID_LIST, i_Params_Get_Area_By_Where_In_List.TOP_LEVEL_ID_LIST, i_Params_Get_Area_By_Where_In_List.OWNER_ID, i_Params_Get_Area_By_Where_In_List.OFFSET, i_Params_Get_Area_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oArea.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oArea.District);
                        oArea.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oArea.Region);
                        oArea.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oArea.Top_level);
                        oList_Area.Add(oArea);
                    }
                }
            }
            i_Params_Get_Area_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_Where_In_List_Adv", i_Params_Get_Area_By_Where_In_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_Where_In_List_Adv
        public List<Area_view> Get_Area_view_By_Where_In_List_Adv(Params_Get_Area_view_By_Where_In_List i_Params_Get_Area_view_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area_view> oList_Area_view = null;
            var i_Params_Get_Area_view_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_view_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_view_By_Where_In_List_Adv", i_Params_Get_Area_view_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Area_view_By_Where_In_List.OWNER_ID == null || i_Params_Get_Area_view_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Area_view_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Area_view_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Area_view_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Area_view_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Area_view_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Area_view_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Area_view_By_Where_In_List.AREA_ID_LIST == null)
            {
                i_Params_Get_Area_view_By_Where_In_List.AREA_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Area_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Area_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Area_view> oList_DBEntry = _AppContext.Get_Area_view_By_Where_In_List_Adv(i_Params_Get_Area_view_By_Where_In_List.DESCRIPTION, i_Params_Get_Area_view_By_Where_In_List.AREA_ID_LIST, i_Params_Get_Area_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST, i_Params_Get_Area_view_By_Where_In_List.OWNER_ID, i_Params_Get_Area_view_By_Where_In_List.OFFSET, i_Params_Get_Area_view_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area_view = new List<Area_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values(oDBEntry, oArea_view);
                        oArea_view.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_view.Area);
                        oArea_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oArea_view.View_type_setup);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            i_Params_Get_Area_view_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_view_By_Where_In_List_Adv", i_Params_Get_Area_view_By_Where_In_List_json, false);
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Site_kpi_By_Where_In_List_Adv
        public List<Site_kpi> Get_Site_kpi_By_Where_In_List_Adv(Params_Get_Site_kpi_By_Where_In_List i_Params_Get_Site_kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_Where_In_List_Adv", i_Params_Get_Site_kpi_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Site_kpi_By_Where_In_List.OWNER_ID == null || i_Params_Get_Site_kpi_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Site_kpi_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Site_kpi_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Site_kpi_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Site_kpi_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Site_kpi_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Site_kpi_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Site_kpi_By_Where_In_List.SITE_ID_LIST == null)
            {
                i_Params_Get_Site_kpi_By_Where_In_List.SITE_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Site_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST == null)
            {
                i_Params_Get_Site_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>();
            }
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_Where_In_List_Adv(i_Params_Get_Site_kpi_By_Where_In_List.DESCRIPTION, i_Params_Get_Site_kpi_By_Where_In_List.SITE_ID_LIST, i_Params_Get_Site_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_Site_kpi_By_Where_In_List.OWNER_ID, i_Params_Get_Site_kpi_By_Where_In_List.OFFSET, i_Params_Get_Site_kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oSite_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oSite_kpi.Organization_data_source_kpi);
                        oSite_kpi.Site = new Site();
                        Props.Copy_Prop_Values(oDBEntry.Site, oSite_kpi.Site);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            i_Params_Get_Site_kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_Where_In_List_Adv", i_Params_Get_Site_kpi_By_Where_In_List_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Organization_relation_By_Where_In_List_Adv
        public List<Organization_relation> Get_Organization_relation_By_Where_In_List_Adv(Params_Get_Organization_relation_By_Where_In_List i_Params_Get_Organization_relation_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_relation> oList_Organization_relation = null;
            var i_Params_Get_Organization_relation_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_relation_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_relation_By_Where_In_List_Adv", i_Params_Get_Organization_relation_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_relation_By_Where_In_List.OWNER_ID == null || i_Params_Get_Organization_relation_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Organization_relation_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_relation_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Organization_relation_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Organization_relation_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Organization_relation_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_relation_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Organization_relation_By_Where_In_List.USER_ID_LIST == null)
            {
                i_Params_Get_Organization_relation_By_Where_In_List.USER_ID_LIST = new List<long?>();
            }
            List<DALC.Organization_relation> oList_DBEntry = _AppContext.Get_Organization_relation_By_Where_In_List_Adv(i_Params_Get_Organization_relation_By_Where_In_List.DESCRIPTION, i_Params_Get_Organization_relation_By_Where_In_List.USER_ID_LIST, i_Params_Get_Organization_relation_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_relation_By_Where_In_List.OFFSET, i_Params_Get_Organization_relation_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_relation);
                        oOrganization_relation.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oOrganization_relation.User);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            i_Params_Get_Organization_relation_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_relation_By_Where_In_List_Adv", i_Params_Get_Organization_relation_By_Where_In_List_json, false);
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        public List<Setup> Get_Setup_By_Where_In_List_Adv(Params_Get_Setup_By_Where_In_List i_Params_Get_Setup_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where_In_List_Adv", i_Params_Get_Setup_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Setup_By_Where_In_List.OWNER_ID == null || i_Params_Get_Setup_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Setup_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Setup_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Setup_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST == null)
            {
                i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST = new List<int?>();
            }
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where_In_List_Adv(i_Params_Get_Setup_By_Where_In_List.VALUE, i_Params_Get_Setup_By_Where_In_List.DESCRIPTION, i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST, i_Params_Get_Setup_By_Where_In_List.OWNER_ID, i_Params_Get_Setup_By_Where_In_List.OFFSET, i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where_In_List_Adv", i_Params_Get_Setup_By_Where_In_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_Where_In_List_Adv
        public List<Area_kpi> Get_Area_kpi_By_Where_In_List_Adv(Params_Get_Area_kpi_By_Where_In_List i_Params_Get_Area_kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_Where_In_List_Adv", i_Params_Get_Area_kpi_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Area_kpi_By_Where_In_List.OWNER_ID == null || i_Params_Get_Area_kpi_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Area_kpi_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Area_kpi_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Area_kpi_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Area_kpi_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Area_kpi_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Area_kpi_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Area_kpi_By_Where_In_List.AREA_ID_LIST == null)
            {
                i_Params_Get_Area_kpi_By_Where_In_List.AREA_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Area_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST == null)
            {
                i_Params_Get_Area_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>();
            }
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_Where_In_List_Adv(i_Params_Get_Area_kpi_By_Where_In_List.DESCRIPTION, i_Params_Get_Area_kpi_By_Where_In_List.AREA_ID_LIST, i_Params_Get_Area_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_Area_kpi_By_Where_In_List.OWNER_ID, i_Params_Get_Area_kpi_By_Where_In_List.OFFSET, i_Params_Get_Area_kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oArea_kpi.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oArea_kpi.Area);
                        oArea_kpi.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oArea_kpi.Organization_data_source_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            i_Params_Get_Area_kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_Where_In_List_Adv", i_Params_Get_Area_kpi_By_Where_In_List_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Region_By_Where_In_List_Adv
        public List<Region> Get_Region_By_Where_In_List_Adv(Params_Get_Region_By_Where_In_List i_Params_Get_Region_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Region> oList_Region = null;
            var i_Params_Get_Region_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Region_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_By_Where_In_List_Adv", i_Params_Get_Region_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Region_By_Where_In_List.OWNER_ID == null || i_Params_Get_Region_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Region_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Region_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Region_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Region_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Region_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Region_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Region_By_Where_In_List.TOP_LEVEL_ID_LIST == null)
            {
                i_Params_Get_Region_By_Where_In_List.TOP_LEVEL_ID_LIST = new List<long?>();
            }
            List<DALC.Region> oList_DBEntry = _AppContext.Get_Region_By_Where_In_List_Adv(i_Params_Get_Region_By_Where_In_List.NAME, i_Params_Get_Region_By_Where_In_List.LOCATION, i_Params_Get_Region_By_Where_In_List.UNIT, i_Params_Get_Region_By_Where_In_List.IMAGE_URL, i_Params_Get_Region_By_Where_In_List.LOGO_URL, i_Params_Get_Region_By_Where_In_List.AREA_COLOR, i_Params_Get_Region_By_Where_In_List.BORDER_COLOR, i_Params_Get_Region_By_Where_In_List.STUDY_ZONE_NAME, i_Params_Get_Region_By_Where_In_List.TOP_LEVEL_ID_LIST, i_Params_Get_Region_By_Where_In_List.OWNER_ID, i_Params_Get_Region_By_Where_In_List.OFFSET, i_Params_Get_Region_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Region = new List<Region>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values(oDBEntry, oRegion);
                        oRegion.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oRegion.Top_level);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            i_Params_Get_Region_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_By_Where_In_List_Adv", i_Params_Get_Region_By_Where_In_List_json, false);
            }
            return oList_Region;
        }
        #endregion
        #region Get_District_By_Where_In_List_Adv
        public List<District> Get_District_By_Where_In_List_Adv(Params_Get_District_By_Where_In_List i_Params_Get_District_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<District> oList_District = null;
            var i_Params_Get_District_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_District_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_Where_In_List_Adv", i_Params_Get_District_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_District_By_Where_In_List.OWNER_ID == null || i_Params_Get_District_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_District_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_District_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_District_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_District_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_District_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_District_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_District_By_Where_In_List.REGION_ID_LIST == null)
            {
                i_Params_Get_District_By_Where_In_List.REGION_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_District_By_Where_In_List.TOP_LEVEL_ID_LIST == null)
            {
                i_Params_Get_District_By_Where_In_List.TOP_LEVEL_ID_LIST = new List<long?>();
            }
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_Where_In_List_Adv(i_Params_Get_District_By_Where_In_List.NAME, i_Params_Get_District_By_Where_In_List.LOCATION, i_Params_Get_District_By_Where_In_List.UNIT, i_Params_Get_District_By_Where_In_List.IMAGE_URL, i_Params_Get_District_By_Where_In_List.LOGO_URL, i_Params_Get_District_By_Where_In_List.SOLID_GLTF_URL, i_Params_Get_District_By_Where_In_List.AREA_COLOR, i_Params_Get_District_By_Where_In_List.BORDER_COLOR, i_Params_Get_District_By_Where_In_List.STUDY_ZONE_NAME, i_Params_Get_District_By_Where_In_List.REGION_ID_LIST, i_Params_Get_District_By_Where_In_List.TOP_LEVEL_ID_LIST, i_Params_Get_District_By_Where_In_List.OWNER_ID, i_Params_Get_District_By_Where_In_List.OFFSET, i_Params_Get_District_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oDistrict.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oDistrict.Region);
                        oDistrict.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oDistrict.Top_level);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            i_Params_Get_District_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_Where_In_List_Adv", i_Params_Get_District_By_Where_In_List_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_District_kpi_user_access_By_Where_In_List_Adv
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_Where_In_List_Adv(Params_Get_District_kpi_user_access_By_Where_In_List i_Params_Get_District_kpi_user_access_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_Where_In_List_Adv", i_Params_Get_District_kpi_user_access_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_District_kpi_user_access_By_Where_In_List.OWNER_ID == null || i_Params_Get_District_kpi_user_access_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_District_kpi_user_access_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_District_kpi_user_access_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_District_kpi_user_access_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_District_kpi_user_access_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_District_kpi_user_access_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_District_kpi_user_access_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_District_kpi_user_access_By_Where_In_List.USER_ID_LIST == null)
            {
                i_Params_Get_District_kpi_user_access_By_Where_In_List.USER_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_District_kpi_user_access_By_Where_In_List.DISTRICT_ID_LIST == null)
            {
                i_Params_Get_District_kpi_user_access_By_Where_In_List.DISTRICT_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_District_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST == null)
            {
                i_Params_Get_District_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = new List<int?>();
            }
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_Where_In_List_Adv(i_Params_Get_District_kpi_user_access_By_Where_In_List.DESCRIPTION, i_Params_Get_District_kpi_user_access_By_Where_In_List.USER_ID_LIST, i_Params_Get_District_kpi_user_access_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_District_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_District_kpi_user_access_By_Where_In_List.OWNER_ID, i_Params_Get_District_kpi_user_access_By_Where_In_List.OFFSET, i_Params_Get_District_kpi_user_access_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oDistrict_kpi_user_access.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oDistrict_kpi_user_access.District);
                        oDistrict_kpi_user_access.Organization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry.Organization_data_source_kpi, oDistrict_kpi_user_access.Organization_data_source_kpi);
                        oDistrict_kpi_user_access.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oDistrict_kpi_user_access.User);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            i_Params_Get_District_kpi_user_access_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_Where_In_List_Adv", i_Params_Get_District_kpi_user_access_By_Where_In_List_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_Where_In_List_Adv
        public List<User> Get_User_By_Where_In_List_Adv(Params_Get_User_By_Where_In_List i_Params_Get_User_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<User> oList_User = null;
            var i_Params_Get_User_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_Where_In_List_Adv", i_Params_Get_User_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_User_By_Where_In_List.OWNER_ID == null || i_Params_Get_User_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_User_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_User_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_User_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_User_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_User_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_User_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_User_By_Where_In_List.ORGANIZATION_ID_LIST == null)
            {
                i_Params_Get_User_By_Where_In_List.ORGANIZATION_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_User_By_Where_In_List.USER_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_User_By_Where_In_List.USER_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_Where_In_List_Adv(i_Params_Get_User_By_Where_In_List.FIRST_NAME, i_Params_Get_User_By_Where_In_List.LAST_NAME, i_Params_Get_User_By_Where_In_List.USERNAME, i_Params_Get_User_By_Where_In_List.PASSWORD, i_Params_Get_User_By_Where_In_List.EMAIL, i_Params_Get_User_By_Where_In_List.PHONE_NUMBER, i_Params_Get_User_By_Where_In_List.IMAGE_URL, i_Params_Get_User_By_Where_In_List.USER_DISTRICTNEX_WALKTHROUGH, i_Params_Get_User_By_Where_In_List.USER_ADMIN_WALKTHROUGH, i_Params_Get_User_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_User_By_Where_In_List.USER_TYPE_SETUP_ID_LIST, i_Params_Get_User_By_Where_In_List.OWNER_ID, i_Params_Get_User_By_Where_In_List.OFFSET, i_Params_Get_User_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oUser.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oUser.Organization);
                        oUser.User_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.User_type_setup, oUser.User_type_setup);
                        oList_User.Add(oUser);
                    }
                }
            }
            i_Params_Get_User_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_Where_In_List_Adv", i_Params_Get_User_By_Where_In_List_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_Site_By_Where_In_List_Adv
        public List<Site> Get_Site_By_Where_In_List_Adv(Params_Get_Site_By_Where_In_List i_Params_Get_Site_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_Where_In_List_Adv", i_Params_Get_Site_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Site_By_Where_In_List.OWNER_ID == null || i_Params_Get_Site_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Site_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Site_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Site_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Site_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Site_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Site_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Site_By_Where_In_List.AREA_ID_LIST == null)
            {
                i_Params_Get_Site_By_Where_In_List.AREA_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Site_By_Where_In_List.DISTRICT_ID_LIST == null)
            {
                i_Params_Get_Site_By_Where_In_List.DISTRICT_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Site_By_Where_In_List.REGION_ID_LIST == null)
            {
                i_Params_Get_Site_By_Where_In_List.REGION_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Site_By_Where_In_List.TOP_LEVEL_ID_LIST == null)
            {
                i_Params_Get_Site_By_Where_In_List.TOP_LEVEL_ID_LIST = new List<long?>();
            }
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_Where_In_List_Adv(i_Params_Get_Site_By_Where_In_List.NAME, i_Params_Get_Site_By_Where_In_List.LOCATION, i_Params_Get_Site_By_Where_In_List.UNIT, i_Params_Get_Site_By_Where_In_List.IMAGE_URL, i_Params_Get_Site_By_Where_In_List.LOGO_URL, i_Params_Get_Site_By_Where_In_List.SOLID_GLTF_URL, i_Params_Get_Site_By_Where_In_List.AREA_COLOR, i_Params_Get_Site_By_Where_In_List.BORDER_COLOR, i_Params_Get_Site_By_Where_In_List.STUDY_ZONE_NAME, i_Params_Get_Site_By_Where_In_List.AREA_ID_LIST, i_Params_Get_Site_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_Site_By_Where_In_List.REGION_ID_LIST, i_Params_Get_Site_By_Where_In_List.TOP_LEVEL_ID_LIST, i_Params_Get_Site_By_Where_In_List.OWNER_ID, i_Params_Get_Site_By_Where_In_List.OFFSET, i_Params_Get_Site_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oSite.Area = new Area();
                        Props.Copy_Prop_Values(oDBEntry.Area, oSite.Area);
                        oSite.District = new District();
                        Props.Copy_Prop_Values(oDBEntry.District, oSite.District);
                        oSite.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oSite.Region);
                        oSite.Top_level = new Top_level();
                        Props.Copy_Prop_Values(oDBEntry.Top_level, oSite.Top_level);
                        oList_Site.Add(oSite);
                    }
                }
            }
            i_Params_Get_Site_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_Where_In_List_Adv", i_Params_Get_Site_By_Where_In_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_User_theme_By_Where_In_List_Adv
        public List<User_theme> Get_User_theme_By_Where_In_List_Adv(Params_Get_User_theme_By_Where_In_List i_Params_Get_User_theme_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<User_theme> oList_User_theme = null;
            var i_Params_Get_User_theme_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_User_theme_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_theme_By_Where_In_List_Adv", i_Params_Get_User_theme_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_User_theme_By_Where_In_List.OWNER_ID == null || i_Params_Get_User_theme_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_User_theme_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_User_theme_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_User_theme_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_User_theme_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_User_theme_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_User_theme_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_User_theme_By_Where_In_List.USER_ID_LIST == null)
            {
                i_Params_Get_User_theme_By_Where_In_List.USER_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_User_theme_By_Where_In_List.ORGANIZATION_THEME_ID_LIST == null)
            {
                i_Params_Get_User_theme_By_Where_In_List.ORGANIZATION_THEME_ID_LIST = new List<int?>();
            }
            List<DALC.User_theme> oList_DBEntry = _AppContext.Get_User_theme_By_Where_In_List_Adv(i_Params_Get_User_theme_By_Where_In_List.DESCRIPTION, i_Params_Get_User_theme_By_Where_In_List.USER_ID_LIST, i_Params_Get_User_theme_By_Where_In_List.ORGANIZATION_THEME_ID_LIST, i_Params_Get_User_theme_By_Where_In_List.OWNER_ID, i_Params_Get_User_theme_By_Where_In_List.OFFSET, i_Params_Get_User_theme_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_User_theme = new List<User_theme>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values(oDBEntry, oUser_theme);
                        oUser_theme.Organization_theme = new Organization_theme();
                        Props.Copy_Prop_Values(oDBEntry.Organization_theme, oUser_theme.Organization_theme);
                        oUser_theme.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oUser_theme.User);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            i_Params_Get_User_theme_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_theme_By_Where_In_List_Adv", i_Params_Get_User_theme_By_Where_In_List_json, false);
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_Region_view_By_Where_In_List_Adv
        public List<Region_view> Get_Region_view_By_Where_In_List_Adv(Params_Get_Region_view_By_Where_In_List i_Params_Get_Region_view_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Region_view> oList_Region_view = null;
            var i_Params_Get_Region_view_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Region_view_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Region_view_By_Where_In_List_Adv", i_Params_Get_Region_view_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Region_view_By_Where_In_List.OWNER_ID == null || i_Params_Get_Region_view_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Region_view_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Region_view_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Region_view_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Region_view_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Region_view_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Region_view_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Region_view_By_Where_In_List.REGION_ID_LIST == null)
            {
                i_Params_Get_Region_view_By_Where_In_List.REGION_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Region_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Region_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Region_view> oList_DBEntry = _AppContext.Get_Region_view_By_Where_In_List_Adv(i_Params_Get_Region_view_By_Where_In_List.DESCRIPTION, i_Params_Get_Region_view_By_Where_In_List.REGION_ID_LIST, i_Params_Get_Region_view_By_Where_In_List.VIEW_TYPE_SETUP_ID_LIST, i_Params_Get_Region_view_By_Where_In_List.OWNER_ID, i_Params_Get_Region_view_By_Where_In_List.OFFSET, i_Params_Get_Region_view_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Region_view = new List<Region_view>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values(oDBEntry, oRegion_view);
                        oRegion_view.Region = new Region();
                        Props.Copy_Prop_Values(oDBEntry.Region, oRegion_view.Region);
                        oRegion_view.View_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.View_type_setup, oRegion_view.View_type_setup);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            i_Params_Get_Region_view_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Region_view_By_Where_In_List_Adv", i_Params_Get_Region_view_By_Where_In_List_json, false);
            }
            return oList_Region_view;
        }
        #endregion
    }
}
