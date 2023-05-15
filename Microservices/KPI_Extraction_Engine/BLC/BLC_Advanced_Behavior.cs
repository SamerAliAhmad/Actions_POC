using System;
using SmartrTools;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Get_Kpi_By_KPI_ID_Adv
        public Kpi Get_Kpi_By_KPI_ID_Adv(Params_Get_Kpi_By_KPI_ID i_Params_Get_Kpi_By_KPI_ID)
        {
            Kpi oKpi = null;
            var i_Params_Get_Kpi_By_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_KPI_ID_Adv", i_Params_Get_Kpi_By_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.Kpi oDBEntry = _AppContext.Get_Kpi_By_KPI_ID_Adv(i_Params_Get_Kpi_By_KPI_ID.KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Kpi").Replace("%2", i_Params_Get_Kpi_By_KPI_ID.KPI_ID.ToString()));
            }
            oKpi = new Kpi();
            Props.Copy_Prop_Values(oDBEntry, oKpi);
            oKpi.Dimension = new Dimension();
            Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
            oKpi.Kpi_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
            oKpi.Max_data_level_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
            oKpi.Min_data_level_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
            oKpi.Setup_category = new Setup_category();
            Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_KPI_ID_Adv", i_Params_Get_Kpi_By_KPI_ID_json, false);
            }
            return oKpi;
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
        #region Get_Organization_By_ORGANIZATION_ID_Adv
        public Organization Get_Organization_By_ORGANIZATION_ID_Adv(Params_Get_Organization_By_ORGANIZATION_ID i_Params_Get_Organization_By_ORGANIZATION_ID)
        {
            Organization oOrganization = null;
            var i_Params_Get_Organization_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            DALC.Organization oDBEntry = _AppContext.Get_Organization_By_ORGANIZATION_ID_Adv(i_Params_Get_Organization_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization").Replace("%2", i_Params_Get_Organization_By_ORGANIZATION_ID.ORGANIZATION_ID.ToString()));
            }
            oOrganization = new Organization();
            Props.Copy_Prop_Values(oDBEntry, oOrganization);
            oOrganization.Organization_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_By_ORGANIZATION_ID_json, false);
            }
            return oOrganization;
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
        #region Get_Data_source_By_DATA_SOURCE_ID_Adv
        public Data_source Get_Data_source_By_DATA_SOURCE_ID_Adv(Params_Get_Data_source_By_DATA_SOURCE_ID i_Params_Get_Data_source_By_DATA_SOURCE_ID)
        {
            Data_source oData_source = null;
            var i_Params_Get_Data_source_By_DATA_SOURCE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Data_source_By_DATA_SOURCE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Data_source_By_DATA_SOURCE_ID_Adv", i_Params_Get_Data_source_By_DATA_SOURCE_ID_json, false);
            }
            #region Body Section.
            DALC.Data_source oDBEntry = _AppContext.Get_Data_source_By_DATA_SOURCE_ID_Adv(i_Params_Get_Data_source_By_DATA_SOURCE_ID.DATA_SOURCE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Data_source").Replace("%2", i_Params_Get_Data_source_By_DATA_SOURCE_ID.DATA_SOURCE_ID.ToString()));
            }
            oData_source = new Data_source();
            Props.Copy_Prop_Values(oDBEntry, oData_source);
            oData_source.Data_source_authentication = new Data_source_authentication();
            Props.Copy_Prop_Values(oDBEntry.Data_source_authentication, oData_source.Data_source_authentication);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Data_source_By_DATA_SOURCE_ID_Adv", i_Params_Get_Data_source_By_DATA_SOURCE_ID_json, false);
            }
            return oData_source;
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
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv
        public Organization_data_source_kpi Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            Organization_data_source_kpi oOrganization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_data_source_kpi oDBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_data_source_kpi").Replace("%2", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID.ToString()));
            }
            oOrganization_data_source_kpi = new Organization_data_source_kpi();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
            oOrganization_data_source_kpi.Data_source = new Data_source();
            Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
            oOrganization_data_source_kpi.Kpi = new Kpi();
            Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
            oOrganization_data_source_kpi.Organization = new Organization();
            Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oOrganization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_FLOOR_ID_Adv
        public Floor Get_Floor_By_FLOOR_ID_Adv(Params_Get_Floor_By_FLOOR_ID i_Params_Get_Floor_By_FLOOR_ID)
        {
            Floor oFloor = null;
            var i_Params_Get_Floor_By_FLOOR_ID_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_FLOOR_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_FLOOR_ID_Adv", i_Params_Get_Floor_By_FLOOR_ID_json, false);
            }
            #region Body Section.
            DALC.Floor oDBEntry = _AppContext.Get_Floor_By_FLOOR_ID_Adv(i_Params_Get_Floor_By_FLOOR_ID.FLOOR_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Floor").Replace("%2", i_Params_Get_Floor_By_FLOOR_ID.FLOOR_ID.ToString()));
            }
            oFloor = new Floor();
            Props.Copy_Prop_Values(oDBEntry, oFloor);
            oFloor.Entity = new Entity();
            Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_FLOOR_ID_Adv", i_Params_Get_Floor_By_FLOOR_ID_json, false);
            }
            return oFloor;
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
        #region Get_Space_By_SPACE_ID_Adv
        public Space Get_Space_By_SPACE_ID_Adv(Params_Get_Space_By_SPACE_ID i_Params_Get_Space_By_SPACE_ID)
        {
            Space oSpace = null;
            var i_Params_Get_Space_By_SPACE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_SPACE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_SPACE_ID_Adv", i_Params_Get_Space_By_SPACE_ID_json, false);
            }
            #region Body Section.
            DALC.Space oDBEntry = _AppContext.Get_Space_By_SPACE_ID_Adv(i_Params_Get_Space_By_SPACE_ID.SPACE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Space").Replace("%2", i_Params_Get_Space_By_SPACE_ID.SPACE_ID.ToString()));
            }
            oSpace = new Space();
            Props.Copy_Prop_Values(oDBEntry, oSpace);
            oSpace.Floor = new Floor();
            Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_SPACE_ID_Adv", i_Params_Get_Space_By_SPACE_ID_json, false);
            }
            return oSpace;
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
        #region Get_Kpi_By_KPI_ID_List_Adv
        public List<Kpi> Get_Kpi_By_KPI_ID_List_Adv(Params_Get_Kpi_By_KPI_ID_List i_Params_Get_Kpi_By_KPI_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_KPI_ID_List_Adv", i_Params_Get_Kpi_By_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_KPI_ID_List_Adv(i_Params_Get_Kpi_By_KPI_ID_List.KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_KPI_ID_List_Adv", i_Params_Get_Kpi_By_KPI_ID_List_json, false);
            }
            return oList_Kpi;
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
        #region Get_Organization_By_ORGANIZATION_ID_List_Adv
        public List<Organization> Get_Organization_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_By_ORGANIZATION_ID_List i_Params_Get_Organization_By_ORGANIZATION_ID_List)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization;
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
        #region Get_Data_source_By_DATA_SOURCE_ID_List_Adv
        public List<Data_source> Get_Data_source_By_DATA_SOURCE_ID_List_Adv(Params_Get_Data_source_By_DATA_SOURCE_ID_List i_Params_Get_Data_source_By_DATA_SOURCE_ID_List)
        {
            List<Data_source> oList_Data_source = null;
            var i_Params_Get_Data_source_By_DATA_SOURCE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Data_source_By_DATA_SOURCE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Data_source_By_DATA_SOURCE_ID_List_Adv", i_Params_Get_Data_source_By_DATA_SOURCE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Data_source> oList_DBEntry = _AppContext.Get_Data_source_By_DATA_SOURCE_ID_List_Adv(i_Params_Get_Data_source_By_DATA_SOURCE_ID_List.DATA_SOURCE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Data_source = new List<Data_source>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Data_source oData_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry, oData_source);
                        oData_source.Data_source_authentication = new Data_source_authentication();
                        Props.Copy_Prop_Values(oDBEntry.Data_source_authentication, oData_source.Data_source_authentication);
                        oList_Data_source.Add(oData_source);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Data_source_By_DATA_SOURCE_ID_List_Adv", i_Params_Get_Data_source_By_DATA_SOURCE_ID_List_json, false);
            }
            return oList_Data_source;
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
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_FLOOR_ID_List_Adv
        public List<Floor> Get_Floor_By_FLOOR_ID_List_Adv(Params_Get_Floor_By_FLOOR_ID_List i_Params_Get_Floor_By_FLOOR_ID_List)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_FLOOR_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_FLOOR_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_FLOOR_ID_List_Adv", i_Params_Get_Floor_By_FLOOR_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_FLOOR_ID_List_Adv(i_Params_Get_Floor_By_FLOOR_ID_List.FLOOR_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oFloor.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_FLOOR_ID_List_Adv", i_Params_Get_Floor_By_FLOOR_ID_List_json, false);
            }
            return oList_Floor;
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
        #region Get_Space_By_SPACE_ID_List_Adv
        public List<Space> Get_Space_By_SPACE_ID_List_Adv(Params_Get_Space_By_SPACE_ID_List i_Params_Get_Space_By_SPACE_ID_List)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_SPACE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_SPACE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_SPACE_ID_List_Adv", i_Params_Get_Space_By_SPACE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_SPACE_ID_List_Adv(i_Params_Get_Space_By_SPACE_ID_List.SPACE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oSpace.Floor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_SPACE_ID_List_Adv", i_Params_Get_Space_By_SPACE_ID_List_json, false);
            }
            return oList_Space;
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
        #region Get_Kpi_By_OWNER_ID_Adv
        public List<Kpi> Get_Kpi_By_OWNER_ID_Adv(Params_Get_Kpi_By_OWNER_ID i_Params_Get_Kpi_By_OWNER_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_OWNER_ID_Adv", i_Params_Get_Kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_OWNER_ID_Adv(i_Params_Get_Kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_OWNER_ID_Adv", i_Params_Get_Kpi_By_OWNER_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_DIMENSION_ID_Adv
        public List<Kpi> Get_Kpi_By_DIMENSION_ID_Adv(Params_Get_Kpi_By_DIMENSION_ID i_Params_Get_Kpi_By_DIMENSION_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_DIMENSION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_DIMENSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_DIMENSION_ID_Adv", i_Params_Get_Kpi_By_DIMENSION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_DIMENSION_ID_Adv(i_Params_Get_Kpi_By_DIMENSION_ID.DIMENSION_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_DIMENSION_ID_Adv", i_Params_Get_Kpi_By_DIMENSION_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID_Adv
        public List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID_Adv(Params_Get_Kpi_By_SETUP_CATEGORY_ID i_Params_Get_Kpi_By_SETUP_CATEGORY_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_SETUP_CATEGORY_ID_Adv", i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_SETUP_CATEGORY_ID_Adv(i_Params_Get_Kpi_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_SETUP_CATEGORY_ID_Adv", i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_Adv
        public List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_Adv(Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_Adv(i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID.MIN_DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_Adv
        public List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_Adv(Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_Adv(i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID.MAX_DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_OWNER_ID_IS_DELETED_Adv
        public List<Kpi> Get_Kpi_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Kpi_By_OWNER_ID_IS_DELETED i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID_Adv
        public List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID_Adv(Params_Get_Kpi_By_KPI_TYPE_SETUP_ID i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_KPI_TYPE_SETUP_ID_Adv", i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_KPI_TYPE_SETUP_ID_Adv(i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID.KPI_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_KPI_TYPE_SETUP_ID_Adv", i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_json, false);
            }
            return oList_Kpi;
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
        #region Get_Organization_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization> Get_Organization_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Organization_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_By_OWNER_ID_IS_DELETED)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Organization_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_By_OWNER_ID_Adv
        public List<Organization> Get_Organization_By_OWNER_ID_Adv(Params_Get_Organization_By_OWNER_ID i_Params_Get_Organization_By_OWNER_ID)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_OWNER_ID_Adv", i_Params_Get_Organization_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_OWNER_ID_Adv(i_Params_Get_Organization_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_OWNER_ID_Adv", i_Params_Get_Organization_By_OWNER_ID_json, false);
            }
            return oList_Organization;
        }
        #endregion
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv
        public List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv(Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv", i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv(i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID.ORGANIZATION_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_Adv", i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_json, false);
            }
            return oList_Organization;
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
        #region Get_Data_source_By_OWNER_ID_Adv
        public List<Data_source> Get_Data_source_By_OWNER_ID_Adv(Params_Get_Data_source_By_OWNER_ID i_Params_Get_Data_source_By_OWNER_ID)
        {
            List<Data_source> oList_Data_source = null;
            var i_Params_Get_Data_source_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Data_source_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Data_source_By_OWNER_ID_Adv", i_Params_Get_Data_source_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Data_source> oList_DBEntry = _AppContext.Get_Data_source_By_OWNER_ID_Adv(i_Params_Get_Data_source_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Data_source = new List<Data_source>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Data_source oData_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry, oData_source);
                        oData_source.Data_source_authentication = new Data_source_authentication();
                        Props.Copy_Prop_Values(oDBEntry.Data_source_authentication, oData_source.Data_source_authentication);
                        oList_Data_source.Add(oData_source);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Data_source_By_OWNER_ID_Adv", i_Params_Get_Data_source_By_OWNER_ID_json, false);
            }
            return oList_Data_source;
        }
        #endregion
        #region Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_Adv
        public List<Data_source> Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_Adv(Params_Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID i_Params_Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID)
        {
            List<Data_source> oList_Data_source = null;
            var i_Params_Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_Adv", i_Params_Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Data_source> oList_DBEntry = _AppContext.Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_Adv(i_Params_Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID.DATA_SOURCE_AUTHENTICATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Data_source = new List<Data_source>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Data_source oData_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry, oData_source);
                        oData_source.Data_source_authentication = new Data_source_authentication();
                        Props.Copy_Prop_Values(oDBEntry.Data_source_authentication, oData_source.Data_source_authentication);
                        oList_Data_source.Add(oData_source);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_Adv", i_Params_Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_json, false);
            }
            return oList_Data_source;
        }
        #endregion
        #region Get_Data_source_By_OWNER_ID_IS_DELETED_Adv
        public List<Data_source> Get_Data_source_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Data_source_By_OWNER_ID_IS_DELETED i_Params_Get_Data_source_By_OWNER_ID_IS_DELETED)
        {
            List<Data_source> oList_Data_source = null;
            var i_Params_Get_Data_source_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Data_source_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Data_source_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Data_source_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Data_source> oList_DBEntry = _AppContext.Get_Data_source_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Data_source_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Data_source_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Data_source = new List<Data_source>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Data_source oData_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry, oData_source);
                        oData_source.Data_source_authentication = new Data_source_authentication();
                        Props.Copy_Prop_Values(oDBEntry.Data_source_authentication, oData_source.Data_source_authentication);
                        oList_Data_source.Add(oData_source);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Data_source_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Data_source_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Data_source;
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
        #region Get_Organization_data_source_kpi_By_OWNER_ID_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_Adv(Params_Get_Organization_data_source_kpi_By_OWNER_ID i_Params_Get_Organization_data_source_kpi_By_OWNER_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_OWNER_ID_Adv(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv(Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID.DATA_SOURCE_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_Adv(Params_Get_Organization_data_source_kpi_By_KPI_ID i_Params_Get_Organization_data_source_kpi_By_KPI_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_KPI_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_KPI_ID_Adv(i_Params_Get_Organization_data_source_kpi_By_KPI_ID.KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_KPI_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_OWNER_ID_IS_DELETED_Adv
        public List<Floor> Get_Floor_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Floor_By_OWNER_ID_IS_DELETED i_Params_Get_Floor_By_OWNER_ID_IS_DELETED)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Floor_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Floor_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Floor_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oFloor.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Floor_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Floor_By_OWNER_ID_Adv
        public List<Floor> Get_Floor_By_OWNER_ID_Adv(Params_Get_Floor_By_OWNER_ID i_Params_Get_Floor_By_OWNER_ID)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_OWNER_ID_Adv", i_Params_Get_Floor_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_OWNER_ID_Adv(i_Params_Get_Floor_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oFloor.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_OWNER_ID_Adv", i_Params_Get_Floor_By_OWNER_ID_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Floor_By_ENTITY_ID_Adv
        public List<Floor> Get_Floor_By_ENTITY_ID_Adv(Params_Get_Floor_By_ENTITY_ID i_Params_Get_Floor_By_ENTITY_ID)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_ENTITY_ID_Adv", i_Params_Get_Floor_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_ENTITY_ID_Adv(i_Params_Get_Floor_By_ENTITY_ID.ENTITY_ID);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oFloor.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_ENTITY_ID_Adv", i_Params_Get_Floor_By_ENTITY_ID_json, false);
            }
            return oList_Floor;
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
        #region Get_Space_By_OWNER_ID_Adv
        public List<Space> Get_Space_By_OWNER_ID_Adv(Params_Get_Space_By_OWNER_ID i_Params_Get_Space_By_OWNER_ID)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_OWNER_ID_Adv", i_Params_Get_Space_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_OWNER_ID_Adv(i_Params_Get_Space_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oSpace.Floor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_OWNER_ID_Adv", i_Params_Get_Space_By_OWNER_ID_json, false);
            }
            return oList_Space;
        }
        #endregion
        #region Get_Space_By_FLOOR_ID_Adv
        public List<Space> Get_Space_By_FLOOR_ID_Adv(Params_Get_Space_By_FLOOR_ID i_Params_Get_Space_By_FLOOR_ID)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_FLOOR_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_FLOOR_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_FLOOR_ID_Adv", i_Params_Get_Space_By_FLOOR_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_FLOOR_ID_Adv(i_Params_Get_Space_By_FLOOR_ID.FLOOR_ID);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oSpace.Floor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_FLOOR_ID_Adv", i_Params_Get_Space_By_FLOOR_ID_json, false);
            }
            return oList_Space;
        }
        #endregion
        #region Get_Space_By_OWNER_ID_IS_DELETED_Adv
        public List<Space> Get_Space_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Space_By_OWNER_ID_IS_DELETED i_Params_Get_Space_By_OWNER_ID_IS_DELETED)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Space_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Space_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Space_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oSpace.Floor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Space_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Space;
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
        #region Get_Kpi_By_DIMENSION_ID_List_Adv
        public List<Kpi> Get_Kpi_By_DIMENSION_ID_List_Adv(Params_Get_Kpi_By_DIMENSION_ID_List i_Params_Get_Kpi_By_DIMENSION_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_DIMENSION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_DIMENSION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_DIMENSION_ID_List_Adv", i_Params_Get_Kpi_By_DIMENSION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_DIMENSION_ID_List_Adv(i_Params_Get_Kpi_By_DIMENSION_ID_List.DIMENSION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_DIMENSION_ID_List_Adv", i_Params_Get_Kpi_By_DIMENSION_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID_List_Adv
        public List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID_List_Adv(Params_Get_Kpi_By_SETUP_CATEGORY_ID_List i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_SETUP_CATEGORY_ID_List_Adv", i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_SETUP_CATEGORY_ID_List_Adv(i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_SETUP_CATEGORY_ID_List_Adv", i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_Adv
        public List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_Adv(Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_Adv(i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List.MIN_DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_Adv
        public List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_Adv(Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_Adv(i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List.MAX_DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID_List_Adv
        public List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID_List_Adv(Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_KPI_TYPE_SETUP_ID_List_Adv", i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_KPI_TYPE_SETUP_ID_List_Adv(i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List.KPI_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_KPI_TYPE_SETUP_ID_List_Adv", i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Kpi;
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
        #region Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv
        public List<Organization> Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv(Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List)
        {
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv", i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv(i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List.ORGANIZATION_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_Adv", i_Params_Get_Organization_By_ORGANIZATION_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Organization;
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
        #region Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_List_Adv
        public List<Data_source> Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_List_Adv(Params_Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_List i_Params_Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_List)
        {
            List<Data_source> oList_Data_source = null;
            var i_Params_Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_List_Adv", i_Params_Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Data_source> oList_DBEntry = _AppContext.Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_List_Adv(i_Params_Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_List.DATA_SOURCE_AUTHENTICATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Data_source = new List<Data_source>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Data_source oData_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry, oData_source);
                        oData_source.Data_source_authentication = new Data_source_authentication();
                        Props.Copy_Prop_Values(oDBEntry.Data_source_authentication, oData_source.Data_source_authentication);
                        oList_Data_source.Add(oData_source);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_List_Adv", i_Params_Get_Data_source_By_DATA_SOURCE_AUTHENTICATION_ID_List_json, false);
            }
            return oList_Data_source;
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
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv(Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List.DATA_SOURCE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_List_Adv(Params_Get_Organization_data_source_kpi_By_KPI_ID_List i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_KPI_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_KPI_ID_List_Adv(i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List.KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_KPI_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_Adv", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_ENTITY_ID_List_Adv
        public List<Floor> Get_Floor_By_ENTITY_ID_List_Adv(Params_Get_Floor_By_ENTITY_ID_List i_Params_Get_Floor_By_ENTITY_ID_List)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_ENTITY_ID_List_Adv", i_Params_Get_Floor_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_ENTITY_ID_List_Adv(i_Params_Get_Floor_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oFloor.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_ENTITY_ID_List_Adv", i_Params_Get_Floor_By_ENTITY_ID_List_json, false);
            }
            return oList_Floor;
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
        #region Get_Space_By_FLOOR_ID_List_Adv
        public List<Space> Get_Space_By_FLOOR_ID_List_Adv(Params_Get_Space_By_FLOOR_ID_List i_Params_Get_Space_By_FLOOR_ID_List)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_FLOOR_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_FLOOR_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_FLOOR_ID_List_Adv", i_Params_Get_Space_By_FLOOR_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_FLOOR_ID_List_Adv(i_Params_Get_Space_By_FLOOR_ID_List.FLOOR_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oSpace.Floor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_FLOOR_ID_List_Adv", i_Params_Get_Space_By_FLOOR_ID_List_json, false);
            }
            return oList_Space;
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
        #region Get_Kpi_By_Where_Adv
        public List<Kpi> Get_Kpi_By_Where_Adv(Params_Get_Kpi_By_Where i_Params_Get_Kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_Where_Adv", i_Params_Get_Kpi_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Kpi_By_Where.OWNER_ID == null || i_Params_Get_Kpi_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Kpi_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Kpi_By_Where.OFFSET == null)
            {
                i_Params_Get_Kpi_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Kpi_By_Where.FETCH_NEXT == null || i_Params_Get_Kpi_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Kpi_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_Where_Adv(i_Params_Get_Kpi_By_Where.NAME, i_Params_Get_Kpi_By_Where.UNIT, i_Params_Get_Kpi_By_Where.OWNER_ID, i_Params_Get_Kpi_By_Where.OFFSET, i_Params_Get_Kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            i_Params_Get_Kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_Where_Adv", i_Params_Get_Kpi_By_Where_json, false);
            }
            return oList_Kpi;
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
        #region Get_Organization_By_Where_Adv
        public List<Organization> Get_Organization_By_Where_Adv(Params_Get_Organization_By_Where i_Params_Get_Organization_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_Where_Adv", i_Params_Get_Organization_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_By_Where.OWNER_ID == null || i_Params_Get_Organization_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Organization_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_By_Where.OFFSET == null)
            {
                i_Params_Get_Organization_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Organization_By_Where.FETCH_NEXT == null || i_Params_Get_Organization_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_Where_Adv(i_Params_Get_Organization_By_Where.ORGANIZATION_NAME, i_Params_Get_Organization_By_Where.ORGANIZATION_EMAIL, i_Params_Get_Organization_By_Where.ORGANIZATION_PHONE_NUMBER, i_Params_Get_Organization_By_Where.ORGANIZATION_ADDRESS, i_Params_Get_Organization_By_Where.OWNER_ID, i_Params_Get_Organization_By_Where.OFFSET, i_Params_Get_Organization_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            i_Params_Get_Organization_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_Where_Adv", i_Params_Get_Organization_By_Where_json, false);
            }
            return oList_Organization;
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
        #region Get_Data_source_By_Where_Adv
        public List<Data_source> Get_Data_source_By_Where_Adv(Params_Get_Data_source_By_Where i_Params_Get_Data_source_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Data_source> oList_Data_source = null;
            var i_Params_Get_Data_source_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Data_source_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Data_source_By_Where_Adv", i_Params_Get_Data_source_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Data_source_By_Where.OWNER_ID == null || i_Params_Get_Data_source_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Data_source_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Data_source_By_Where.OFFSET == null)
            {
                i_Params_Get_Data_source_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Data_source_By_Where.FETCH_NEXT == null || i_Params_Get_Data_source_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Data_source_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Data_source> oList_DBEntry = _AppContext.Get_Data_source_By_Where_Adv(i_Params_Get_Data_source_By_Where.NAME, i_Params_Get_Data_source_By_Where.API_URL, i_Params_Get_Data_source_By_Where.OWNER_ID, i_Params_Get_Data_source_By_Where.OFFSET, i_Params_Get_Data_source_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Data_source = new List<Data_source>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Data_source oData_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry, oData_source);
                        oData_source.Data_source_authentication = new Data_source_authentication();
                        Props.Copy_Prop_Values(oDBEntry.Data_source_authentication, oData_source.Data_source_authentication);
                        oList_Data_source.Add(oData_source);
                    }
                }
            }
            i_Params_Get_Data_source_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Data_source_By_Where_Adv", i_Params_Get_Data_source_By_Where_json, false);
            }
            return oList_Data_source;
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
        #region Get_Organization_data_source_kpi_By_Where_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_Adv(Params_Get_Organization_data_source_kpi_By_Where i_Params_Get_Organization_data_source_kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_Where_Adv", i_Params_Get_Organization_data_source_kpi_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_data_source_kpi_By_Where.OWNER_ID == null || i_Params_Get_Organization_data_source_kpi_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_data_source_kpi_By_Where.OFFSET == null)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Organization_data_source_kpi_By_Where.FETCH_NEXT == null || i_Params_Get_Organization_data_source_kpi_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_Where_Adv(i_Params_Get_Organization_data_source_kpi_By_Where.DESCRIPTION, i_Params_Get_Organization_data_source_kpi_By_Where.OWNER_ID, i_Params_Get_Organization_data_source_kpi_By_Where.OFFSET, i_Params_Get_Organization_data_source_kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            i_Params_Get_Organization_data_source_kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_Where_Adv", i_Params_Get_Organization_data_source_kpi_By_Where_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_Where_Adv
        public List<Floor> Get_Floor_By_Where_Adv(Params_Get_Floor_By_Where i_Params_Get_Floor_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_Where_Adv", i_Params_Get_Floor_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Floor_By_Where.OWNER_ID == null || i_Params_Get_Floor_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Floor_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Floor_By_Where.OFFSET == null)
            {
                i_Params_Get_Floor_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Floor_By_Where.FETCH_NEXT == null || i_Params_Get_Floor_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Floor_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_Where_Adv(i_Params_Get_Floor_By_Where.SHELL_GLTF_URL, i_Params_Get_Floor_By_Where.CLIPPED_GLTF_URL, i_Params_Get_Floor_By_Where.ADVANCED_GLTF_URL, i_Params_Get_Floor_By_Where.UNIT, i_Params_Get_Floor_By_Where.NAME, i_Params_Get_Floor_By_Where.OWNER_ID, i_Params_Get_Floor_By_Where.OFFSET, i_Params_Get_Floor_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oFloor.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            i_Params_Get_Floor_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_Where_Adv", i_Params_Get_Floor_By_Where_json, false);
            }
            return oList_Floor;
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
        #region Get_Space_By_Where_Adv
        public List<Space> Get_Space_By_Where_Adv(Params_Get_Space_By_Where i_Params_Get_Space_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_Where_Adv", i_Params_Get_Space_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Space_By_Where.OWNER_ID == null || i_Params_Get_Space_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Space_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Space_By_Where.OFFSET == null)
            {
                i_Params_Get_Space_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Space_By_Where.FETCH_NEXT == null || i_Params_Get_Space_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Space_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_Where_Adv(i_Params_Get_Space_By_Where.NAME, i_Params_Get_Space_By_Where.UNIT, i_Params_Get_Space_By_Where.OWNER_ID, i_Params_Get_Space_By_Where.OFFSET, i_Params_Get_Space_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oSpace.Floor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            i_Params_Get_Space_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_Where_Adv", i_Params_Get_Space_By_Where_json, false);
            }
            return oList_Space;
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
        #region Get_Kpi_By_Where_In_List_Adv
        public List<Kpi> Get_Kpi_By_Where_In_List_Adv(Params_Get_Kpi_By_Where_In_List i_Params_Get_Kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_Where_In_List_Adv", i_Params_Get_Kpi_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Kpi_By_Where_In_List.OWNER_ID == null || i_Params_Get_Kpi_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Kpi_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Kpi_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Kpi_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Kpi_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Kpi_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Kpi_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Kpi_By_Where_In_List.DIMENSION_ID_LIST == null)
            {
                i_Params_Get_Kpi_By_Where_In_List.DIMENSION_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Kpi_By_Where_In_List.SETUP_CATEGORY_ID_LIST == null)
            {
                i_Params_Get_Kpi_By_Where_In_List.SETUP_CATEGORY_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Kpi_By_Where_In_List.KPI_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Kpi_By_Where_In_List.KPI_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Kpi_By_Where_In_List.MIN_DATA_LEVEL_SETUP_ID_LIST == null)
            {
                i_Params_Get_Kpi_By_Where_In_List.MIN_DATA_LEVEL_SETUP_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Kpi_By_Where_In_List.MAX_DATA_LEVEL_SETUP_ID_LIST == null)
            {
                i_Params_Get_Kpi_By_Where_In_List.MAX_DATA_LEVEL_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_Where_In_List_Adv(i_Params_Get_Kpi_By_Where_In_List.NAME, i_Params_Get_Kpi_By_Where_In_List.UNIT, i_Params_Get_Kpi_By_Where_In_List.DIMENSION_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.SETUP_CATEGORY_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.KPI_TYPE_SETUP_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.MIN_DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.MAX_DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.OWNER_ID, i_Params_Get_Kpi_By_Where_In_List.OFFSET, i_Params_Get_Kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oKpi.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oKpi.Dimension);
                        oKpi.Kpi_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Kpi_type_setup, oKpi.Kpi_type_setup);
                        oKpi.Max_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Max_data_level_setup, oKpi.Max_data_level_setup);
                        oKpi.Min_data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Min_data_level_setup, oKpi.Min_data_level_setup);
                        oKpi.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oKpi.Setup_category);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            i_Params_Get_Kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_Where_In_List_Adv", i_Params_Get_Kpi_By_Where_In_List_json, false);
            }
            return oList_Kpi;
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
        #region Get_Organization_By_Where_In_List_Adv
        public List<Organization> Get_Organization_By_Where_In_List_Adv(Params_Get_Organization_By_Where_In_List i_Params_Get_Organization_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization> oList_Organization = null;
            var i_Params_Get_Organization_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_By_Where_In_List_Adv", i_Params_Get_Organization_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_By_Where_In_List.OWNER_ID == null || i_Params_Get_Organization_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Organization_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Organization_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Organization_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Organization_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Organization> oList_DBEntry = _AppContext.Get_Organization_By_Where_In_List_Adv(i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_NAME, i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_EMAIL, i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_PHONE_NUMBER, i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_ADDRESS, i_Params_Get_Organization_By_Where_In_List.ORGANIZATION_TYPE_SETUP_ID_LIST, i_Params_Get_Organization_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_By_Where_In_List.OFFSET, i_Params_Get_Organization_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization = new List<Organization>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization oOrganization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization);
                        oOrganization.Organization_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Organization_type_setup, oOrganization.Organization_type_setup);
                        oList_Organization.Add(oOrganization);
                    }
                }
            }
            i_Params_Get_Organization_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_By_Where_In_List_Adv", i_Params_Get_Organization_By_Where_In_List_json, false);
            }
            return oList_Organization;
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
        #region Get_Data_source_By_Where_In_List_Adv
        public List<Data_source> Get_Data_source_By_Where_In_List_Adv(Params_Get_Data_source_By_Where_In_List i_Params_Get_Data_source_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Data_source> oList_Data_source = null;
            var i_Params_Get_Data_source_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Data_source_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Data_source_By_Where_In_List_Adv", i_Params_Get_Data_source_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Data_source_By_Where_In_List.OWNER_ID == null || i_Params_Get_Data_source_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Data_source_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Data_source_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Data_source_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Data_source_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Data_source_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Data_source_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Data_source_By_Where_In_List.DATA_SOURCE_AUTHENTICATION_ID_LIST == null)
            {
                i_Params_Get_Data_source_By_Where_In_List.DATA_SOURCE_AUTHENTICATION_ID_LIST = new List<int?>();
            }
            List<DALC.Data_source> oList_DBEntry = _AppContext.Get_Data_source_By_Where_In_List_Adv(i_Params_Get_Data_source_By_Where_In_List.NAME, i_Params_Get_Data_source_By_Where_In_List.API_URL, i_Params_Get_Data_source_By_Where_In_List.DATA_SOURCE_AUTHENTICATION_ID_LIST, i_Params_Get_Data_source_By_Where_In_List.OWNER_ID, i_Params_Get_Data_source_By_Where_In_List.OFFSET, i_Params_Get_Data_source_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Data_source = new List<Data_source>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Data_source oData_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry, oData_source);
                        oData_source.Data_source_authentication = new Data_source_authentication();
                        Props.Copy_Prop_Values(oDBEntry.Data_source_authentication, oData_source.Data_source_authentication);
                        oList_Data_source.Add(oData_source);
                    }
                }
            }
            i_Params_Get_Data_source_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Data_source_By_Where_In_List_Adv", i_Params_Get_Data_source_By_Where_In_List_json, false);
            }
            return oList_Data_source;
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
        #region Get_Organization_data_source_kpi_By_Where_In_List_Adv
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_In_List_Adv(Params_Get_Organization_data_source_kpi_By_Where_In_List i_Params_Get_Organization_data_source_kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_Where_In_List_Adv", i_Params_Get_Organization_data_source_kpi_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OWNER_ID == null || i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Organization_data_source_kpi_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Organization_data_source_kpi_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Organization_data_source_kpi_By_Where_In_List.DATA_SOURCE_ID_LIST == null)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where_In_List.DATA_SOURCE_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Organization_data_source_kpi_By_Where_In_List.KPI_ID_LIST == null)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where_In_List.KPI_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Organization_data_source_kpi_By_Where_In_List.ORGANIZATION_ID_LIST == null)
            {
                i_Params_Get_Organization_data_source_kpi_By_Where_In_List.ORGANIZATION_ID_LIST = new List<int?>();
            }
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_Where_In_List_Adv(i_Params_Get_Organization_data_source_kpi_By_Where_In_List.DESCRIPTION, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.DATA_SOURCE_ID_LIST, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.KPI_ID_LIST, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OFFSET, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oOrganization_data_source_kpi.Data_source = new Data_source();
                        Props.Copy_Prop_Values(oDBEntry.Data_source, oOrganization_data_source_kpi.Data_source);
                        oOrganization_data_source_kpi.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oOrganization_data_source_kpi.Kpi);
                        oOrganization_data_source_kpi.Organization = new Organization();
                        Props.Copy_Prop_Values(oDBEntry.Organization, oOrganization_data_source_kpi.Organization);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            i_Params_Get_Organization_data_source_kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_Where_In_List_Adv", i_Params_Get_Organization_data_source_kpi_By_Where_In_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_Where_In_List_Adv
        public List<Floor> Get_Floor_By_Where_In_List_Adv(Params_Get_Floor_By_Where_In_List i_Params_Get_Floor_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_Where_In_List_Adv", i_Params_Get_Floor_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Floor_By_Where_In_List.OWNER_ID == null || i_Params_Get_Floor_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Floor_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Floor_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Floor_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Floor_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Floor_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Floor_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Floor_By_Where_In_List.ENTITY_ID_LIST == null)
            {
                i_Params_Get_Floor_By_Where_In_List.ENTITY_ID_LIST = new List<long?>();
            }
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_Where_In_List_Adv(i_Params_Get_Floor_By_Where_In_List.SHELL_GLTF_URL, i_Params_Get_Floor_By_Where_In_List.CLIPPED_GLTF_URL, i_Params_Get_Floor_By_Where_In_List.ADVANCED_GLTF_URL, i_Params_Get_Floor_By_Where_In_List.UNIT, i_Params_Get_Floor_By_Where_In_List.NAME, i_Params_Get_Floor_By_Where_In_List.ENTITY_ID_LIST, i_Params_Get_Floor_By_Where_In_List.OWNER_ID, i_Params_Get_Floor_By_Where_In_List.OFFSET, i_Params_Get_Floor_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oFloor.Entity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry.Entity, oFloor.Entity);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            i_Params_Get_Floor_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_Where_In_List_Adv", i_Params_Get_Floor_By_Where_In_List_json, false);
            }
            return oList_Floor;
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
        #region Get_Space_By_Where_In_List_Adv
        public List<Space> Get_Space_By_Where_In_List_Adv(Params_Get_Space_By_Where_In_List i_Params_Get_Space_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_Where_In_List_Adv", i_Params_Get_Space_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Space_By_Where_In_List.OWNER_ID == null || i_Params_Get_Space_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Space_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Space_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Space_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Space_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Space_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Space_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Space_By_Where_In_List.FLOOR_ID_LIST == null)
            {
                i_Params_Get_Space_By_Where_In_List.FLOOR_ID_LIST = new List<long?>();
            }
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_Where_In_List_Adv(i_Params_Get_Space_By_Where_In_List.NAME, i_Params_Get_Space_By_Where_In_List.UNIT, i_Params_Get_Space_By_Where_In_List.FLOOR_ID_LIST, i_Params_Get_Space_By_Where_In_List.OWNER_ID, i_Params_Get_Space_By_Where_In_List.OFFSET, i_Params_Get_Space_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oSpace.Floor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry.Floor, oSpace.Floor);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            i_Params_Get_Space_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_Where_In_List_Adv", i_Params_Get_Space_By_Where_In_List_json, false);
            }
            return oList_Space;
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
    }
}
