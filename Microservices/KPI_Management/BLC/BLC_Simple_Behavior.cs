using System;
using System.Linq;
using SmartrTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Members
        #region Used For Delete Operations
        private Kpi _Kpi;
        private List<Kpi> _List_Kpi;
        private Asset _Asset;
        private List<Asset> _List_Asset;
        private Ext_study_zone _Ext_study_zone;
        private List<Ext_study_zone> _List_Ext_study_zone;
        private Area_kpi_user_access _Area_kpi_user_access;
        private List<Area_kpi_user_access> _List_Area_kpi_user_access;
        private Site_kpi_user_access _Site_kpi_user_access;
        private List<Site_kpi_user_access> _List_Site_kpi_user_access;
        private Entity_kpi _Entity_kpi;
        private List<Entity_kpi> _List_Entity_kpi;
        private Entity _Entity;
        private List<Entity> _List_Entity;
        private District_kpi _District_kpi;
        private List<District_kpi> _List_District_kpi;
        private Entity_kpi_user_access _Entity_kpi_user_access;
        private List<Entity_kpi_user_access> _List_Entity_kpi_user_access;
        private Area _Area;
        private List<Area> _List_Area;
        private Site_kpi _Site_kpi;
        private List<Site_kpi> _List_Site_kpi;
        private Setup_category _Setup_category;
        private List<Setup_category> _List_Setup_category;
        private Setup _Setup;
        private List<Setup> _List_Setup;
        private Area_kpi _Area_kpi;
        private List<Area_kpi> _List_Area_kpi;
        private Space_asset _Space_asset;
        private List<Space_asset> _List_Space_asset;
        private District _District;
        private List<District> _List_District;
        private Organization_data_source_kpi _Organization_data_source_kpi;
        private List<Organization_data_source_kpi> _List_Organization_data_source_kpi;
        private Floor _Floor;
        private List<Floor> _List_Floor;
        private District_kpi_user_access _District_kpi_user_access;
        private List<District_kpi_user_access> _List_District_kpi_user_access;
        private User _User;
        private List<User> _List_User;
        private Space _Space;
        private List<Space> _List_Space;
        private Site _Site;
        private List<Site> _List_Site;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Kpi_Execution;
        private bool _Stop_Delete_Kpi_Execution;
        private bool _Stop_Edit_Asset_Execution;
        private bool _Stop_Delete_Asset_Execution;
        private bool _Stop_Edit_Ext_study_zone_Execution;
        private bool _Stop_Delete_Ext_study_zone_Execution;
        private bool _Stop_Edit_Area_kpi_user_access_Execution;
        private bool _Stop_Delete_Area_kpi_user_access_Execution;
        private bool _Stop_Edit_Site_kpi_user_access_Execution;
        private bool _Stop_Delete_Site_kpi_user_access_Execution;
        private bool _Stop_Edit_Entity_kpi_Execution;
        private bool _Stop_Delete_Entity_kpi_Execution;
        private bool _Stop_Edit_Entity_Execution;
        private bool _Stop_Delete_Entity_Execution;
        private bool _Stop_Edit_District_kpi_Execution;
        private bool _Stop_Delete_District_kpi_Execution;
        private bool _Stop_Edit_Entity_kpi_user_access_Execution;
        private bool _Stop_Delete_Entity_kpi_user_access_Execution;
        private bool _Stop_Edit_Area_Execution;
        private bool _Stop_Delete_Area_Execution;
        private bool _Stop_Edit_Site_kpi_Execution;
        private bool _Stop_Delete_Site_kpi_Execution;
        private bool _Stop_Edit_Setup_category_Execution;
        private bool _Stop_Delete_Setup_category_Execution;
        private bool _Stop_Edit_Setup_Execution;
        private bool _Stop_Delete_Setup_Execution;
        private bool _Stop_Edit_Area_kpi_Execution;
        private bool _Stop_Delete_Area_kpi_Execution;
        private bool _Stop_Edit_Space_asset_Execution;
        private bool _Stop_Delete_Space_asset_Execution;
        private bool _Stop_Edit_District_Execution;
        private bool _Stop_Delete_District_Execution;
        private bool _Stop_Edit_Organization_data_source_kpi_Execution;
        private bool _Stop_Delete_Organization_data_source_kpi_Execution;
        private bool _Stop_Edit_Floor_Execution;
        private bool _Stop_Delete_Floor_Execution;
        private bool _Stop_Edit_District_kpi_user_access_Execution;
        private bool _Stop_Delete_District_kpi_user_access_Execution;
        private bool _Stop_Edit_User_Execution;
        private bool _Stop_Delete_User_Execution;
        private bool _Stop_Edit_Space_Execution;
        private bool _Stop_Delete_Space_Execution;
        private bool _Stop_Edit_Site_Execution;
        private bool _Stop_Delete_Site_Execution;
        #endregion
        #endregion
        #region Get_Kpi_By_KPI_ID
        public Kpi Get_Kpi_By_KPI_ID(Params_Get_Kpi_By_KPI_ID i_Params_Get_Kpi_By_KPI_ID)
        {
            Kpi oKpi = null;
            var i_Params_Get_Kpi_By_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_KPI_ID", i_Params_Get_Kpi_By_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.Kpi oDBEntry = _AppContext.Get_Kpi_By_KPI_ID(i_Params_Get_Kpi_By_KPI_ID.KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Kpi").Replace("%2", i_Params_Get_Kpi_By_KPI_ID.KPI_ID.ToString()));
            }
            oKpi = new Kpi();
            Props.Copy_Prop_Values(oDBEntry, oKpi);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_KPI_ID", i_Params_Get_Kpi_By_KPI_ID_json, false);
            }
            return oKpi;
        }
        #endregion
        #region Get_Asset_By_ASSET_ID
        public Asset Get_Asset_By_ASSET_ID(Params_Get_Asset_By_ASSET_ID i_Params_Get_Asset_By_ASSET_ID)
        {
            Asset oAsset = null;
            var i_Params_Get_Asset_By_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_ID", i_Params_Get_Asset_By_ASSET_ID_json, false);
            }
            #region Body Section.
            DALC.Asset oDBEntry = _AppContext.Get_Asset_By_ASSET_ID(i_Params_Get_Asset_By_ASSET_ID.ASSET_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Asset").Replace("%2", i_Params_Get_Asset_By_ASSET_ID.ASSET_ID.ToString()));
            }
            oAsset = new Asset();
            Props.Copy_Prop_Values(oDBEntry, oAsset);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_ID", i_Params_Get_Asset_By_ASSET_ID_json, false);
            }
            return oAsset;
        }
        #endregion
        #region Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID
        public Ext_study_zone Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID(Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID)
        {
            Ext_study_zone oExt_study_zone = null;
            var i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID", i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_json, false);
            }
            #region Body Section.
            DALC.Ext_study_zone oDBEntry = _AppContext.Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID(i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID.EXT_STUDY_ZONE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Ext_study_zone").Replace("%2", i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID.EXT_STUDY_ZONE_ID.ToString()));
            }
            oExt_study_zone = new Ext_study_zone();
            Props.Copy_Prop_Values(oDBEntry, oExt_study_zone);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID", i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_json, false);
            }
            return oExt_study_zone;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID
        public Area_kpi_user_access Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID(Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID)
        {
            Area_kpi_user_access oArea_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID", i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_json, false);
            }
            #region Body Section.
            DALC.Area_kpi_user_access oDBEntry = _AppContext.Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID(i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID.AREA_KPI_USER_ACCESS_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Area_kpi_user_access").Replace("%2", i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID.AREA_KPI_USER_ACCESS_ID.ToString()));
            }
            oArea_kpi_user_access = new Area_kpi_user_access();
            Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID", i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_json, false);
            }
            return oArea_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID
        public Site_kpi_user_access Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID(Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID)
        {
            Site_kpi_user_access oSite_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID", i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_json, false);
            }
            #region Body Section.
            DALC.Site_kpi_user_access oDBEntry = _AppContext.Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID(i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID.SITE_KPI_USER_ACCESS_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Site_kpi_user_access").Replace("%2", i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID.SITE_KPI_USER_ACCESS_ID.ToString()));
            }
            oSite_kpi_user_access = new Site_kpi_user_access();
            Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID", i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_json, false);
            }
            return oSite_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_ENTITY_KPI_ID
        public Entity_kpi Get_Entity_kpi_By_ENTITY_KPI_ID(Params_Get_Entity_kpi_By_ENTITY_KPI_ID i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID)
        {
            Entity_kpi oEntity_kpi = null;
            var i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_ENTITY_KPI_ID", i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.Entity_kpi oDBEntry = _AppContext.Get_Entity_kpi_By_ENTITY_KPI_ID(i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID.ENTITY_KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Entity_kpi").Replace("%2", i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID.ENTITY_KPI_ID.ToString()));
            }
            oEntity_kpi = new Entity_kpi();
            Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_ENTITY_KPI_ID", i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_json, false);
            }
            return oEntity_kpi;
        }
        #endregion
        #region Get_Entity_By_ENTITY_ID
        public Entity Get_Entity_By_ENTITY_ID(Params_Get_Entity_By_ENTITY_ID i_Params_Get_Entity_By_ENTITY_ID)
        {
            Entity oEntity = null;
            var i_Params_Get_Entity_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_ID", i_Params_Get_Entity_By_ENTITY_ID_json, false);
            }
            #region PreEvent_Get_Entity_By_ENTITY_ID
            if (OnPreEvent_Get_Entity_By_ENTITY_ID != null)
            {
                OnPreEvent_Get_Entity_By_ENTITY_ID(i_Params_Get_Entity_By_ENTITY_ID);
            }
            #endregion
            #region Body Section.
            DALC.Entity oDBEntry = _AppContext.Get_Entity_By_ENTITY_ID(i_Params_Get_Entity_By_ENTITY_ID.ENTITY_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Entity").Replace("%2", i_Params_Get_Entity_By_ENTITY_ID.ENTITY_ID.ToString()));
            }
            oEntity = new Entity();
            Props.Copy_Prop_Values(oDBEntry, oEntity);
            #endregion
            #region PostEvent_Get_Entity_By_ENTITY_ID
            if (OnPostEvent_Get_Entity_By_ENTITY_ID != null)
            {
                OnPostEvent_Get_Entity_By_ENTITY_ID(ref oEntity, i_Params_Get_Entity_By_ENTITY_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_ID", i_Params_Get_Entity_By_ENTITY_ID_json, false);
            }
            return oEntity;
        }
        #endregion
        #region Get_District_kpi_By_DISTRICT_KPI_ID
        public District_kpi Get_District_kpi_By_DISTRICT_KPI_ID(Params_Get_District_kpi_By_DISTRICT_KPI_ID i_Params_Get_District_kpi_By_DISTRICT_KPI_ID)
        {
            District_kpi oDistrict_kpi = null;
            var i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_DISTRICT_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_DISTRICT_KPI_ID", i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.District_kpi oDBEntry = _AppContext.Get_District_kpi_By_DISTRICT_KPI_ID(i_Params_Get_District_kpi_By_DISTRICT_KPI_ID.DISTRICT_KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "District_kpi").Replace("%2", i_Params_Get_District_kpi_By_DISTRICT_KPI_ID.DISTRICT_KPI_ID.ToString()));
            }
            oDistrict_kpi = new District_kpi();
            Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_DISTRICT_KPI_ID", i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_json, false);
            }
            return oDistrict_kpi;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID
        public Entity_kpi_user_access Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID(Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID)
        {
            Entity_kpi_user_access oEntity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID", i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_json, false);
            }
            #region Body Section.
            DALC.Entity_kpi_user_access oDBEntry = _AppContext.Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID(i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID.ENTITY_KPI_USER_ACCESS_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Entity_kpi_user_access").Replace("%2", i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID.ENTITY_KPI_USER_ACCESS_ID.ToString()));
            }
            oEntity_kpi_user_access = new Entity_kpi_user_access();
            Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID", i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_json, false);
            }
            return oEntity_kpi_user_access;
        }
        #endregion
        #region Get_Area_By_AREA_ID
        public Area Get_Area_By_AREA_ID(Params_Get_Area_By_AREA_ID i_Params_Get_Area_By_AREA_ID)
        {
            Area oArea = null;
            var i_Params_Get_Area_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_AREA_ID", i_Params_Get_Area_By_AREA_ID_json, false);
            }
            #region PreEvent_Get_Area_By_AREA_ID
            if (OnPreEvent_Get_Area_By_AREA_ID != null)
            {
                OnPreEvent_Get_Area_By_AREA_ID(i_Params_Get_Area_By_AREA_ID);
            }
            #endregion
            #region Body Section.
            DALC.Area oDBEntry = _AppContext.Get_Area_By_AREA_ID(i_Params_Get_Area_By_AREA_ID.AREA_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Area").Replace("%2", i_Params_Get_Area_By_AREA_ID.AREA_ID.ToString()));
            }
            oArea = new Area();
            Props.Copy_Prop_Values(oDBEntry, oArea);
            #endregion
            #region PostEvent_Get_Area_By_AREA_ID
            if (OnPostEvent_Get_Area_By_AREA_ID != null)
            {
                OnPostEvent_Get_Area_By_AREA_ID(oArea, i_Params_Get_Area_By_AREA_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_AREA_ID", i_Params_Get_Area_By_AREA_ID_json, false);
            }
            return oArea;
        }
        #endregion
        #region Get_Site_kpi_By_SITE_KPI_ID
        public Site_kpi Get_Site_kpi_By_SITE_KPI_ID(Params_Get_Site_kpi_By_SITE_KPI_ID i_Params_Get_Site_kpi_By_SITE_KPI_ID)
        {
            Site_kpi oSite_kpi = null;
            var i_Params_Get_Site_kpi_By_SITE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_SITE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_SITE_KPI_ID", i_Params_Get_Site_kpi_By_SITE_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.Site_kpi oDBEntry = _AppContext.Get_Site_kpi_By_SITE_KPI_ID(i_Params_Get_Site_kpi_By_SITE_KPI_ID.SITE_KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Site_kpi").Replace("%2", i_Params_Get_Site_kpi_By_SITE_KPI_ID.SITE_KPI_ID.ToString()));
            }
            oSite_kpi = new Site_kpi();
            Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_SITE_KPI_ID", i_Params_Get_Site_kpi_By_SITE_KPI_ID_json, false);
            }
            return oSite_kpi;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(Params_Get_Setup_category_By_SETUP_CATEGORY_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID)
        {
            Setup_category oSetup_category = null;
            var i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            DALC.Setup_category oDBEntry = _AppContext.Get_Setup_category_By_SETUP_CATEGORY_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Setup_category").Replace("%2", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID.ToString()));
            }
            oSetup_category = new Setup_category();
            Props.Copy_Prop_Values(oDBEntry, oSetup_category);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_json, false);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID
        public Setup Get_Setup_By_SETUP_ID(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_ID(i_Params_Get_Setup_By_SETUP_ID.SETUP_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Setup").Replace("%2", i_Params_Get_Setup_By_SETUP_ID.SETUP_ID.ToString()));
            }
            oSetup = new Setup();
            Props.Copy_Prop_Values(oDBEntry, oSetup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Area_kpi_By_AREA_KPI_ID
        public Area_kpi Get_Area_kpi_By_AREA_KPI_ID(Params_Get_Area_kpi_By_AREA_KPI_ID i_Params_Get_Area_kpi_By_AREA_KPI_ID)
        {
            Area_kpi oArea_kpi = null;
            var i_Params_Get_Area_kpi_By_AREA_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_AREA_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_AREA_KPI_ID", i_Params_Get_Area_kpi_By_AREA_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.Area_kpi oDBEntry = _AppContext.Get_Area_kpi_By_AREA_KPI_ID(i_Params_Get_Area_kpi_By_AREA_KPI_ID.AREA_KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Area_kpi").Replace("%2", i_Params_Get_Area_kpi_By_AREA_KPI_ID.AREA_KPI_ID.ToString()));
            }
            oArea_kpi = new Area_kpi();
            Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_AREA_KPI_ID", i_Params_Get_Area_kpi_By_AREA_KPI_ID_json, false);
            }
            return oArea_kpi;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ASSET_ID
        public Space_asset Get_Space_asset_By_SPACE_ASSET_ID(Params_Get_Space_asset_By_SPACE_ASSET_ID i_Params_Get_Space_asset_By_SPACE_ASSET_ID)
        {
            Space_asset oSpace_asset = null;
            var i_Params_Get_Space_asset_By_SPACE_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_SPACE_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_SPACE_ASSET_ID", i_Params_Get_Space_asset_By_SPACE_ASSET_ID_json, false);
            }
            #region Body Section.
            DALC.Space_asset oDBEntry = _AppContext.Get_Space_asset_By_SPACE_ASSET_ID(i_Params_Get_Space_asset_By_SPACE_ASSET_ID.SPACE_ASSET_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Space_asset").Replace("%2", i_Params_Get_Space_asset_By_SPACE_ASSET_ID.SPACE_ASSET_ID.ToString()));
            }
            oSpace_asset = new Space_asset();
            Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_SPACE_ASSET_ID", i_Params_Get_Space_asset_By_SPACE_ASSET_ID_json, false);
            }
            return oSpace_asset;
        }
        #endregion
        #region Get_District_By_DISTRICT_ID
        public District Get_District_By_DISTRICT_ID(Params_Get_District_By_DISTRICT_ID i_Params_Get_District_By_DISTRICT_ID)
        {
            District oDistrict = null;
            var i_Params_Get_District_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_DISTRICT_ID", i_Params_Get_District_By_DISTRICT_ID_json, false);
            }
            #region PreEvent_Get_District_By_DISTRICT_ID
            if (OnPreEvent_Get_District_By_DISTRICT_ID != null)
            {
                OnPreEvent_Get_District_By_DISTRICT_ID(i_Params_Get_District_By_DISTRICT_ID);
            }
            #endregion
            #region Body Section.
            DALC.District oDBEntry = _AppContext.Get_District_By_DISTRICT_ID(i_Params_Get_District_By_DISTRICT_ID.DISTRICT_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "District").Replace("%2", i_Params_Get_District_By_DISTRICT_ID.DISTRICT_ID.ToString()));
            }
            oDistrict = new District();
            Props.Copy_Prop_Values(oDBEntry, oDistrict);
            #endregion
            #region PostEvent_Get_District_By_DISTRICT_ID
            if (OnPostEvent_Get_District_By_DISTRICT_ID != null)
            {
                OnPostEvent_Get_District_By_DISTRICT_ID(oDistrict, i_Params_Get_District_By_DISTRICT_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_DISTRICT_ID", i_Params_Get_District_By_DISTRICT_ID_json, false);
            }
            return oDistrict;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public Organization_data_source_kpi Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            Organization_data_source_kpi oOrganization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.Organization_data_source_kpi oDBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Organization_data_source_kpi").Replace("%2", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID.ToString()));
            }
            oOrganization_data_source_kpi = new Organization_data_source_kpi();
            Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oOrganization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_FLOOR_ID
        public Floor Get_Floor_By_FLOOR_ID(Params_Get_Floor_By_FLOOR_ID i_Params_Get_Floor_By_FLOOR_ID)
        {
            Floor oFloor = null;
            var i_Params_Get_Floor_By_FLOOR_ID_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_FLOOR_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_FLOOR_ID", i_Params_Get_Floor_By_FLOOR_ID_json, false);
            }
            #region Body Section.
            DALC.Floor oDBEntry = _AppContext.Get_Floor_By_FLOOR_ID(i_Params_Get_Floor_By_FLOOR_ID.FLOOR_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Floor").Replace("%2", i_Params_Get_Floor_By_FLOOR_ID.FLOOR_ID.ToString()));
            }
            oFloor = new Floor();
            Props.Copy_Prop_Values(oDBEntry, oFloor);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_FLOOR_ID", i_Params_Get_Floor_By_FLOOR_ID_json, false);
            }
            return oFloor;
        }
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID
        public District_kpi_user_access Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID(Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID)
        {
            District_kpi_user_access oDistrict_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID", i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_json, false);
            }
            #region Body Section.
            DALC.District_kpi_user_access oDBEntry = _AppContext.Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID(i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID.DISTRICT_KPI_USER_ACCESS_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "District_kpi_user_access").Replace("%2", i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID.DISTRICT_KPI_USER_ACCESS_ID.ToString()));
            }
            oDistrict_kpi_user_access = new District_kpi_user_access();
            Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID", i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_json, false);
            }
            return oDistrict_kpi_user_access;
        }
        #endregion
        #region Get_User_By_USER_ID
        public User Get_User_By_USER_ID(Params_Get_User_By_USER_ID i_Params_Get_User_By_USER_ID)
        {
            User oUser = null;
            var i_Params_Get_User_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_ID", i_Params_Get_User_By_USER_ID_json, false);
            }
            #region Body Section.
            DALC.User oDBEntry = _AppContext.Get_User_By_USER_ID(i_Params_Get_User_By_USER_ID.USER_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "User").Replace("%2", i_Params_Get_User_By_USER_ID.USER_ID.ToString()));
            }
            oUser = new User();
            Props.Copy_Prop_Values(oDBEntry, oUser);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_ID", i_Params_Get_User_By_USER_ID_json, false);
            }
            return oUser;
        }
        #endregion
        #region Get_Space_By_SPACE_ID
        public Space Get_Space_By_SPACE_ID(Params_Get_Space_By_SPACE_ID i_Params_Get_Space_By_SPACE_ID)
        {
            Space oSpace = null;
            var i_Params_Get_Space_By_SPACE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_SPACE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_SPACE_ID", i_Params_Get_Space_By_SPACE_ID_json, false);
            }
            #region Body Section.
            DALC.Space oDBEntry = _AppContext.Get_Space_By_SPACE_ID(i_Params_Get_Space_By_SPACE_ID.SPACE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Space").Replace("%2", i_Params_Get_Space_By_SPACE_ID.SPACE_ID.ToString()));
            }
            oSpace = new Space();
            Props.Copy_Prop_Values(oDBEntry, oSpace);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_SPACE_ID", i_Params_Get_Space_By_SPACE_ID_json, false);
            }
            return oSpace;
        }
        #endregion
        #region Get_Site_By_SITE_ID
        public Site Get_Site_By_SITE_ID(Params_Get_Site_By_SITE_ID i_Params_Get_Site_By_SITE_ID)
        {
            Site oSite = null;
            var i_Params_Get_Site_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_SITE_ID", i_Params_Get_Site_By_SITE_ID_json, false);
            }
            #region PreEvent_Get_Site_By_SITE_ID
            if (OnPreEvent_Get_Site_By_SITE_ID != null)
            {
                OnPreEvent_Get_Site_By_SITE_ID(i_Params_Get_Site_By_SITE_ID);
            }
            #endregion
            #region Body Section.
            DALC.Site oDBEntry = _AppContext.Get_Site_By_SITE_ID(i_Params_Get_Site_By_SITE_ID.SITE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Site").Replace("%2", i_Params_Get_Site_By_SITE_ID.SITE_ID.ToString()));
            }
            oSite = new Site();
            Props.Copy_Prop_Values(oDBEntry, oSite);
            #endregion
            #region PostEvent_Get_Site_By_SITE_ID
            if (OnPostEvent_Get_Site_By_SITE_ID != null)
            {
                OnPostEvent_Get_Site_By_SITE_ID(ref oSite, i_Params_Get_Site_By_SITE_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_SITE_ID", i_Params_Get_Site_By_SITE_ID_json, false);
            }
            return oSite;
        }
        #endregion
        #region Get_Kpi_By_KPI_ID_List
        public List<Kpi> Get_Kpi_By_KPI_ID_List(Params_Get_Kpi_By_KPI_ID_List i_Params_Get_Kpi_By_KPI_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_KPI_ID_List", i_Params_Get_Kpi_By_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_KPI_ID_List(i_Params_Get_Kpi_By_KPI_ID_List.KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_KPI_ID_List", i_Params_Get_Kpi_By_KPI_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Asset_By_ASSET_ID_List
        public List<Asset> Get_Asset_By_ASSET_ID_List(Params_Get_Asset_By_ASSET_ID_List i_Params_Get_Asset_By_ASSET_ID_List)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_ID_List", i_Params_Get_Asset_By_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_ASSET_ID_List(i_Params_Get_Asset_By_ASSET_ID_List.ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_ID_List", i_Params_Get_Asset_By_ASSET_ID_List_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List
        public List<Ext_study_zone> Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List(Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List)
        {
            List<Ext_study_zone> oList_Ext_study_zone = null;
            var i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List", i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Ext_study_zone> oList_DBEntry = _AppContext.Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List(i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List.EXT_STUDY_ZONE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Ext_study_zone = new List<Ext_study_zone>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Ext_study_zone oExt_study_zone = new Ext_study_zone();
                        Props.Copy_Prop_Values(oDBEntry, oExt_study_zone);
                        oList_Ext_study_zone.Add(oExt_study_zone);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List", i_Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List_json, false);
            }
            return oList_Ext_study_zone;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List(Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List", i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List(i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List.AREA_KPI_USER_ACCESS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List", i_Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List(Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List", i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List(i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List.SITE_KPI_USER_ACCESS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List", i_Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_ENTITY_KPI_ID_List
        public List<Entity_kpi> Get_Entity_kpi_By_ENTITY_KPI_ID_List(Params_Get_Entity_kpi_By_ENTITY_KPI_ID_List i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_List)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_ENTITY_KPI_ID_List", i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_ENTITY_KPI_ID_List(i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_List.ENTITY_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_ENTITY_KPI_ID_List", i_Params_Get_Entity_kpi_By_ENTITY_KPI_ID_List_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_ENTITY_ID_List
        public List<Entity> Get_Entity_By_ENTITY_ID_List(Params_Get_Entity_By_ENTITY_ID_List i_Params_Get_Entity_By_ENTITY_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_ID_List", i_Params_Get_Entity_By_ENTITY_ID_List_json, false);
            }
            #region PreEvent_Get_Entity_By_ENTITY_ID_List
            if (OnPreEvent_Get_Entity_By_ENTITY_ID_List != null)
            {
                OnPreEvent_Get_Entity_By_ENTITY_ID_List(i_Params_Get_Entity_By_ENTITY_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_ENTITY_ID_List(i_Params_Get_Entity_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Entity_By_ENTITY_ID_List
            if (OnPostEvent_Get_Entity_By_ENTITY_ID_List != null)
            {
                OnPostEvent_Get_Entity_By_ENTITY_ID_List(oList_Entity, i_Params_Get_Entity_By_ENTITY_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_ID_List", i_Params_Get_Entity_By_ENTITY_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_DISTRICT_KPI_ID_List
        public List<District_kpi> Get_District_kpi_By_DISTRICT_KPI_ID_List(Params_Get_District_kpi_By_DISTRICT_KPI_ID_List i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_List)
        {
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_DISTRICT_KPI_ID_List", i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_DISTRICT_KPI_ID_List(i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_List.DISTRICT_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_DISTRICT_KPI_ID_List", i_Params_Get_District_kpi_By_DISTRICT_KPI_ID_List_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List(Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List", i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List(i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List.ENTITY_KPI_USER_ACCESS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List", i_Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Area_By_AREA_ID_List
        public List<Area> Get_Area_By_AREA_ID_List(Params_Get_Area_By_AREA_ID_List i_Params_Get_Area_By_AREA_ID_List)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_AREA_ID_List", i_Params_Get_Area_By_AREA_ID_List_json, false);
            }
            #region PreEvent_Get_Area_By_AREA_ID_List
            if (OnPreEvent_Get_Area_By_AREA_ID_List != null)
            {
                OnPreEvent_Get_Area_By_AREA_ID_List(i_Params_Get_Area_By_AREA_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_AREA_ID_List(i_Params_Get_Area_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Area_By_AREA_ID_List
            if (OnPostEvent_Get_Area_By_AREA_ID_List != null)
            {
                OnPostEvent_Get_Area_By_AREA_ID_List(oList_Area, i_Params_Get_Area_By_AREA_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_AREA_ID_List", i_Params_Get_Area_By_AREA_ID_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Site_kpi_By_SITE_KPI_ID_List
        public List<Site_kpi> Get_Site_kpi_By_SITE_KPI_ID_List(Params_Get_Site_kpi_By_SITE_KPI_ID_List i_Params_Get_Site_kpi_By_SITE_KPI_ID_List)
        {
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_SITE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_SITE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_SITE_KPI_ID_List", i_Params_Get_Site_kpi_By_SITE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_SITE_KPI_ID_List(i_Params_Get_Site_kpi_By_SITE_KPI_ID_List.SITE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_SITE_KPI_ID_List", i_Params_Get_Site_kpi_By_SITE_KPI_ID_List_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        public List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List)
        {
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_SETUP_CATEGORY_ID_List(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        public List<Setup> Get_Setup_By_SETUP_ID_List(Params_Get_Setup_By_SETUP_ID_List i_Params_Get_Setup_By_SETUP_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID_List", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_ID_List(i_Params_Get_Setup_By_SETUP_ID_List.SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID_List", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_AREA_KPI_ID_List
        public List<Area_kpi> Get_Area_kpi_By_AREA_KPI_ID_List(Params_Get_Area_kpi_By_AREA_KPI_ID_List i_Params_Get_Area_kpi_By_AREA_KPI_ID_List)
        {
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_AREA_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_AREA_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_AREA_KPI_ID_List", i_Params_Get_Area_kpi_By_AREA_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_AREA_KPI_ID_List(i_Params_Get_Area_kpi_By_AREA_KPI_ID_List.AREA_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_AREA_KPI_ID_List", i_Params_Get_Area_kpi_By_AREA_KPI_ID_List_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ASSET_ID_List
        public List<Space_asset> Get_Space_asset_By_SPACE_ASSET_ID_List(Params_Get_Space_asset_By_SPACE_ASSET_ID_List i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_SPACE_ASSET_ID_List", i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_SPACE_ASSET_ID_List(i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List.SPACE_ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_SPACE_ASSET_ID_List", i_Params_Get_Space_asset_By_SPACE_ASSET_ID_List_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_District_By_DISTRICT_ID_List
        public List<District> Get_District_By_DISTRICT_ID_List(Params_Get_District_By_DISTRICT_ID_List i_Params_Get_District_By_DISTRICT_ID_List)
        {
            List<District> oList_District = null;
            var i_Params_Get_District_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_DISTRICT_ID_List", i_Params_Get_District_By_DISTRICT_ID_List_json, false);
            }
            #region PreEvent_Get_District_By_DISTRICT_ID_List
            if (OnPreEvent_Get_District_By_DISTRICT_ID_List != null)
            {
                OnPreEvent_Get_District_By_DISTRICT_ID_List(i_Params_Get_District_By_DISTRICT_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_DISTRICT_ID_List(i_Params_Get_District_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_District_By_DISTRICT_ID_List
            if (OnPostEvent_Get_District_By_DISTRICT_ID_List != null)
            {
                OnPostEvent_Get_District_By_DISTRICT_ID_List(oList_District, i_Params_Get_District_By_DISTRICT_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_DISTRICT_ID_List", i_Params_Get_District_By_DISTRICT_ID_List_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_FLOOR_ID_List
        public List<Floor> Get_Floor_By_FLOOR_ID_List(Params_Get_Floor_By_FLOOR_ID_List i_Params_Get_Floor_By_FLOOR_ID_List)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_FLOOR_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_FLOOR_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_FLOOR_ID_List", i_Params_Get_Floor_By_FLOOR_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_FLOOR_ID_List(i_Params_Get_Floor_By_FLOOR_ID_List.FLOOR_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_FLOOR_ID_List", i_Params_Get_Floor_By_FLOOR_ID_List_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List(Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List", i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List(i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List.DISTRICT_KPI_USER_ACCESS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List", i_Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_USER_ID_List
        public List<User> Get_User_By_USER_ID_List(Params_Get_User_By_USER_ID_List i_Params_Get_User_By_USER_ID_List)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_ID_List", i_Params_Get_User_By_USER_ID_List_json, false);
            }
            #region PreEvent_Get_User_By_USER_ID_List
            if (OnPreEvent_Get_User_By_USER_ID_List != null)
            {
                OnPreEvent_Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_USER_ID_List(i_Params_Get_User_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_User_By_USER_ID_List
            if (OnPostEvent_Get_User_By_USER_ID_List != null)
            {
                OnPostEvent_Get_User_By_USER_ID_List(oList_User, i_Params_Get_User_By_USER_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_ID_List", i_Params_Get_User_By_USER_ID_List_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_Space_By_SPACE_ID_List
        public List<Space> Get_Space_By_SPACE_ID_List(Params_Get_Space_By_SPACE_ID_List i_Params_Get_Space_By_SPACE_ID_List)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_SPACE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_SPACE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_SPACE_ID_List", i_Params_Get_Space_By_SPACE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_SPACE_ID_List(i_Params_Get_Space_By_SPACE_ID_List.SPACE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_SPACE_ID_List", i_Params_Get_Space_By_SPACE_ID_List_json, false);
            }
            return oList_Space;
        }
        #endregion
        #region Get_Site_By_SITE_ID_List
        public List<Site> Get_Site_By_SITE_ID_List(Params_Get_Site_By_SITE_ID_List i_Params_Get_Site_By_SITE_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_SITE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_SITE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_SITE_ID_List", i_Params_Get_Site_By_SITE_ID_List_json, false);
            }
            #region PreEvent_Get_Site_By_SITE_ID_List
            if (OnPreEvent_Get_Site_By_SITE_ID_List != null)
            {
                OnPreEvent_Get_Site_By_SITE_ID_List(i_Params_Get_Site_By_SITE_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_SITE_ID_List(i_Params_Get_Site_By_SITE_ID_List.SITE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Site_By_SITE_ID_List
            if (OnPostEvent_Get_Site_By_SITE_ID_List != null)
            {
                OnPostEvent_Get_Site_By_SITE_ID_List(ref oList_Site, i_Params_Get_Site_By_SITE_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_SITE_ID_List", i_Params_Get_Site_By_SITE_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Kpi_By_OWNER_ID
        public List<Kpi> Get_Kpi_By_OWNER_ID(Params_Get_Kpi_By_OWNER_ID i_Params_Get_Kpi_By_OWNER_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_OWNER_ID", i_Params_Get_Kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_OWNER_ID(i_Params_Get_Kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_OWNER_ID", i_Params_Get_Kpi_By_OWNER_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_DIMENSION_ID
        public List<Kpi> Get_Kpi_By_DIMENSION_ID(Params_Get_Kpi_By_DIMENSION_ID i_Params_Get_Kpi_By_DIMENSION_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_DIMENSION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_DIMENSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_DIMENSION_ID", i_Params_Get_Kpi_By_DIMENSION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_DIMENSION_ID(i_Params_Get_Kpi_By_DIMENSION_ID.DIMENSION_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_DIMENSION_ID", i_Params_Get_Kpi_By_DIMENSION_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID
        public List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID(Params_Get_Kpi_By_SETUP_CATEGORY_ID i_Params_Get_Kpi_By_SETUP_CATEGORY_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_SETUP_CATEGORY_ID", i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_SETUP_CATEGORY_ID(i_Params_Get_Kpi_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_SETUP_CATEGORY_ID", i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
        public List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID", i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID.MIN_DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID", i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
        public List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID", i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID.MAX_DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID", i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_OWNER_ID_IS_DELETED
        public List<Kpi> Get_Kpi_By_OWNER_ID_IS_DELETED(Params_Get_Kpi_By_OWNER_ID_IS_DELETED i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_OWNER_ID_IS_DELETED(i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID
        public List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID(Params_Get_Kpi_By_KPI_TYPE_SETUP_ID i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_KPI_TYPE_SETUP_ID", i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_KPI_TYPE_SETUP_ID(i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID.KPI_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_KPI_TYPE_SETUP_ID", i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Asset_By_OWNER_ID
        public List<Asset> Get_Asset_By_OWNER_ID(Params_Get_Asset_By_OWNER_ID i_Params_Get_Asset_By_OWNER_ID)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_OWNER_ID", i_Params_Get_Asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_OWNER_ID(i_Params_Get_Asset_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_OWNER_ID", i_Params_Get_Asset_By_OWNER_ID_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID
        public List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID(Params_Get_Asset_By_ASSET_TYPE_SETUP_ID i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_ASSET_TYPE_SETUP_ID(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID.ASSET_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_OWNER_ID_IS_DELETED
        public List<Asset> Get_Asset_By_OWNER_ID_IS_DELETED(Params_Get_Asset_By_OWNER_ID_IS_DELETED i_Params_Get_Asset_By_OWNER_ID_IS_DELETED)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_OWNER_ID_IS_DELETED", i_Params_Get_Asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_OWNER_ID_IS_DELETED(i_Params_Get_Asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_OWNER_ID_IS_DELETED", i_Params_Get_Asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Ext_study_zone_By_OWNER_ID
        public List<Ext_study_zone> Get_Ext_study_zone_By_OWNER_ID(Params_Get_Ext_study_zone_By_OWNER_ID i_Params_Get_Ext_study_zone_By_OWNER_ID)
        {
            List<Ext_study_zone> oList_Ext_study_zone = null;
            var i_Params_Get_Ext_study_zone_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Ext_study_zone_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Ext_study_zone_By_OWNER_ID", i_Params_Get_Ext_study_zone_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Ext_study_zone> oList_DBEntry = _AppContext.Get_Ext_study_zone_By_OWNER_ID(i_Params_Get_Ext_study_zone_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Ext_study_zone = new List<Ext_study_zone>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Ext_study_zone oExt_study_zone = new Ext_study_zone();
                        Props.Copy_Prop_Values(oDBEntry, oExt_study_zone);
                        oList_Ext_study_zone.Add(oExt_study_zone);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Ext_study_zone_By_OWNER_ID", i_Params_Get_Ext_study_zone_By_OWNER_ID_json, false);
            }
            return oList_Ext_study_zone;
        }
        #endregion
        #region Get_Ext_study_zone_By_OWNER_ID_IS_DELETED
        public List<Ext_study_zone> Get_Ext_study_zone_By_OWNER_ID_IS_DELETED(Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED i_Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED)
        {
            List<Ext_study_zone> oList_Ext_study_zone = null;
            var i_Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Ext_study_zone_By_OWNER_ID_IS_DELETED", i_Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Ext_study_zone> oList_DBEntry = _AppContext.Get_Ext_study_zone_By_OWNER_ID_IS_DELETED(i_Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Ext_study_zone = new List<Ext_study_zone>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Ext_study_zone oExt_study_zone = new Ext_study_zone();
                        Props.Copy_Prop_Values(oDBEntry, oExt_study_zone);
                        oList_Ext_study_zone.Add(oExt_study_zone);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Ext_study_zone_By_OWNER_ID_IS_DELETED", i_Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Ext_study_zone;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_OWNER_ID
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_OWNER_ID(Params_Get_Area_kpi_user_access_By_OWNER_ID i_Params_Get_Area_kpi_user_access_By_OWNER_ID)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_OWNER_ID", i_Params_Get_Area_kpi_user_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_OWNER_ID(i_Params_Get_Area_kpi_user_access_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_OWNER_ID", i_Params_Get_Area_kpi_user_access_By_OWNER_ID_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_USER_ID
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_USER_ID(Params_Get_Area_kpi_user_access_By_USER_ID i_Params_Get_Area_kpi_user_access_By_USER_ID)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_USER_ID", i_Params_Get_Area_kpi_user_access_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_USER_ID(i_Params_Get_Area_kpi_user_access_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_USER_ID", i_Params_Get_Area_kpi_user_access_By_USER_ID_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_ID
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_ID(Params_Get_Area_kpi_user_access_By_AREA_ID i_Params_Get_Area_kpi_user_access_By_AREA_ID)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_AREA_ID", i_Params_Get_Area_kpi_user_access_By_AREA_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_AREA_ID(i_Params_Get_Area_kpi_user_access_By_AREA_ID.AREA_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_AREA_ID", i_Params_Get_Area_kpi_user_access_By_AREA_ID_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED(Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED i_Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED(i_Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_OWNER_ID
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_OWNER_ID(Params_Get_Site_kpi_user_access_By_OWNER_ID i_Params_Get_Site_kpi_user_access_By_OWNER_ID)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_OWNER_ID", i_Params_Get_Site_kpi_user_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_OWNER_ID(i_Params_Get_Site_kpi_user_access_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_OWNER_ID", i_Params_Get_Site_kpi_user_access_By_OWNER_ID_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_USER_ID
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_USER_ID(Params_Get_Site_kpi_user_access_By_USER_ID i_Params_Get_Site_kpi_user_access_By_USER_ID)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_USER_ID", i_Params_Get_Site_kpi_user_access_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_USER_ID(i_Params_Get_Site_kpi_user_access_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_USER_ID", i_Params_Get_Site_kpi_user_access_By_USER_ID_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_ID
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_ID(Params_Get_Site_kpi_user_access_By_SITE_ID i_Params_Get_Site_kpi_user_access_By_SITE_ID)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_SITE_ID", i_Params_Get_Site_kpi_user_access_By_SITE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_SITE_ID(i_Params_Get_Site_kpi_user_access_By_SITE_ID.SITE_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_SITE_ID", i_Params_Get_Site_kpi_user_access_By_SITE_ID_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED(Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED i_Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED(i_Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_OWNER_ID_IS_DELETED
        public List<Entity_kpi> Get_Entity_kpi_By_OWNER_ID_IS_DELETED(Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED i_Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_OWNER_ID_IS_DELETED(i_Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_kpi_By_OWNER_ID
        public List<Entity_kpi> Get_Entity_kpi_By_OWNER_ID(Params_Get_Entity_kpi_By_OWNER_ID i_Params_Get_Entity_kpi_By_OWNER_ID)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_OWNER_ID", i_Params_Get_Entity_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_OWNER_ID(i_Params_Get_Entity_kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_OWNER_ID", i_Params_Get_Entity_kpi_By_OWNER_ID_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<Entity_kpi> Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_kpi_By_ENTITY_ID
        public List<Entity_kpi> Get_Entity_kpi_By_ENTITY_ID(Params_Get_Entity_kpi_By_ENTITY_ID i_Params_Get_Entity_kpi_By_ENTITY_ID)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_ENTITY_ID", i_Params_Get_Entity_kpi_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_ENTITY_ID(i_Params_Get_Entity_kpi_By_ENTITY_ID.ENTITY_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_ENTITY_ID", i_Params_Get_Entity_kpi_By_ENTITY_ID_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_OWNER_ID_IS_DELETED
        public List<Entity> Get_Entity_By_OWNER_ID_IS_DELETED(Params_Get_Entity_By_OWNER_ID_IS_DELETED i_Params_Get_Entity_By_OWNER_ID_IS_DELETED)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_OWNER_ID_IS_DELETED", i_Params_Get_Entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_OWNER_ID_IS_DELETED(i_Params_Get_Entity_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Entity_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_OWNER_ID_IS_DELETED", i_Params_Get_Entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_OWNER_ID
        public List<Entity> Get_Entity_By_OWNER_ID(Params_Get_Entity_By_OWNER_ID i_Params_Get_Entity_By_OWNER_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_OWNER_ID", i_Params_Get_Entity_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_OWNER_ID(i_Params_Get_Entity_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_OWNER_ID", i_Params_Get_Entity_By_OWNER_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_SITE_ID
        public List<Entity> Get_Entity_By_SITE_ID(Params_Get_Entity_By_SITE_ID i_Params_Get_Entity_By_SITE_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_SITE_ID", i_Params_Get_Entity_By_SITE_ID_json, false);
            }
            #region PreEvent_Get_Entity_By_SITE_ID
            if (OnPreEvent_Get_Entity_By_SITE_ID != null)
            {
                OnPreEvent_Get_Entity_By_SITE_ID(i_Params_Get_Entity_By_SITE_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_SITE_ID(i_Params_Get_Entity_By_SITE_ID.SITE_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Entity_By_SITE_ID
            if (OnPostEvent_Get_Entity_By_SITE_ID != null)
            {
                OnPostEvent_Get_Entity_By_SITE_ID(ref oList_Entity, i_Params_Get_Entity_By_SITE_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_SITE_ID", i_Params_Get_Entity_By_SITE_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_AREA_ID
        public List<Entity> Get_Entity_By_AREA_ID(Params_Get_Entity_By_AREA_ID i_Params_Get_Entity_By_AREA_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_AREA_ID", i_Params_Get_Entity_By_AREA_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_AREA_ID(i_Params_Get_Entity_By_AREA_ID.AREA_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_AREA_ID", i_Params_Get_Entity_By_AREA_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_DISTRICT_ID
        public List<Entity> Get_Entity_By_DISTRICT_ID(Params_Get_Entity_By_DISTRICT_ID i_Params_Get_Entity_By_DISTRICT_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_DISTRICT_ID", i_Params_Get_Entity_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_DISTRICT_ID(i_Params_Get_Entity_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_DISTRICT_ID", i_Params_Get_Entity_By_DISTRICT_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_REGION_ID
        public List<Entity> Get_Entity_By_REGION_ID(Params_Get_Entity_By_REGION_ID i_Params_Get_Entity_By_REGION_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_REGION_ID", i_Params_Get_Entity_By_REGION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_REGION_ID(i_Params_Get_Entity_By_REGION_ID.REGION_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_REGION_ID", i_Params_Get_Entity_By_REGION_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID
        public List<Entity> Get_Entity_By_TOP_LEVEL_ID(Params_Get_Entity_By_TOP_LEVEL_ID i_Params_Get_Entity_By_TOP_LEVEL_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_TOP_LEVEL_ID", i_Params_Get_Entity_By_TOP_LEVEL_ID_json, false);
            }
            #region PreEvent_Get_Entity_By_TOP_LEVEL_ID
            if (OnPreEvent_Get_Entity_By_TOP_LEVEL_ID != null)
            {
                OnPreEvent_Get_Entity_By_TOP_LEVEL_ID(i_Params_Get_Entity_By_TOP_LEVEL_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_TOP_LEVEL_ID(i_Params_Get_Entity_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Entity_By_TOP_LEVEL_ID
            if (OnPostEvent_Get_Entity_By_TOP_LEVEL_ID != null)
            {
                OnPostEvent_Get_Entity_By_TOP_LEVEL_ID(oList_Entity, i_Params_Get_Entity_By_TOP_LEVEL_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_TOP_LEVEL_ID", i_Params_Get_Entity_By_TOP_LEVEL_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID
        public List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID(Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_ENTITY_TYPE_SETUP_ID(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID.ENTITY_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_OWNER_ID
        public List<District_kpi> Get_District_kpi_By_OWNER_ID(Params_Get_District_kpi_By_OWNER_ID i_Params_Get_District_kpi_By_OWNER_ID)
        {
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_OWNER_ID", i_Params_Get_District_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_OWNER_ID(i_Params_Get_District_kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_OWNER_ID", i_Params_Get_District_kpi_By_OWNER_ID_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<District_kpi> Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_District_kpi_By_OWNER_ID_IS_DELETED
        public List<District_kpi> Get_District_kpi_By_OWNER_ID_IS_DELETED(Params_Get_District_kpi_By_OWNER_ID_IS_DELETED i_Params_Get_District_kpi_By_OWNER_ID_IS_DELETED)
        {
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_District_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_OWNER_ID_IS_DELETED(i_Params_Get_District_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_District_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_District_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_District_kpi_By_DISTRICT_ID
        public List<District_kpi> Get_District_kpi_By_DISTRICT_ID(Params_Get_District_kpi_By_DISTRICT_ID i_Params_Get_District_kpi_By_DISTRICT_ID)
        {
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_DISTRICT_ID", i_Params_Get_District_kpi_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_DISTRICT_ID(i_Params_Get_District_kpi_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_DISTRICT_ID", i_Params_Get_District_kpi_By_DISTRICT_ID_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_OWNER_ID
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_OWNER_ID(Params_Get_Entity_kpi_user_access_By_OWNER_ID i_Params_Get_Entity_kpi_user_access_By_OWNER_ID)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_OWNER_ID", i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_OWNER_ID(i_Params_Get_Entity_kpi_user_access_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_OWNER_ID", i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_USER_ID
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_USER_ID(Params_Get_Entity_kpi_user_access_By_USER_ID i_Params_Get_Entity_kpi_user_access_By_USER_ID)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_USER_ID", i_Params_Get_Entity_kpi_user_access_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_USER_ID(i_Params_Get_Entity_kpi_user_access_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_USER_ID", i_Params_Get_Entity_kpi_user_access_By_USER_ID_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_ID
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_ID(Params_Get_Entity_kpi_user_access_By_ENTITY_ID i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_ENTITY_ID", i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_ENTITY_ID(i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID.ENTITY_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_ENTITY_ID", i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED(Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED(i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Area_By_OWNER_ID_IS_DELETED
        public List<Area> Get_Area_By_OWNER_ID_IS_DELETED(Params_Get_Area_By_OWNER_ID_IS_DELETED i_Params_Get_Area_By_OWNER_ID_IS_DELETED)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_OWNER_ID_IS_DELETED", i_Params_Get_Area_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_OWNER_ID_IS_DELETED(i_Params_Get_Area_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Area_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_OWNER_ID_IS_DELETED", i_Params_Get_Area_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_OWNER_ID
        public List<Area> Get_Area_By_OWNER_ID(Params_Get_Area_By_OWNER_ID i_Params_Get_Area_By_OWNER_ID)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_OWNER_ID", i_Params_Get_Area_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_OWNER_ID(i_Params_Get_Area_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_OWNER_ID", i_Params_Get_Area_By_OWNER_ID_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_DISTRICT_ID
        public List<Area> Get_Area_By_DISTRICT_ID(Params_Get_Area_By_DISTRICT_ID i_Params_Get_Area_By_DISTRICT_ID)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_DISTRICT_ID", i_Params_Get_Area_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_DISTRICT_ID(i_Params_Get_Area_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_DISTRICT_ID", i_Params_Get_Area_By_DISTRICT_ID_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_REGION_ID
        public List<Area> Get_Area_By_REGION_ID(Params_Get_Area_By_REGION_ID i_Params_Get_Area_By_REGION_ID)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_REGION_ID", i_Params_Get_Area_By_REGION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_REGION_ID(i_Params_Get_Area_By_REGION_ID.REGION_ID);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_REGION_ID", i_Params_Get_Area_By_REGION_ID_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_TOP_LEVEL_ID
        public List<Area> Get_Area_By_TOP_LEVEL_ID(Params_Get_Area_By_TOP_LEVEL_ID i_Params_Get_Area_By_TOP_LEVEL_ID)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_TOP_LEVEL_ID", i_Params_Get_Area_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_TOP_LEVEL_ID(i_Params_Get_Area_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_TOP_LEVEL_ID", i_Params_Get_Area_By_TOP_LEVEL_ID_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Site_kpi_By_OWNER_ID
        public List<Site_kpi> Get_Site_kpi_By_OWNER_ID(Params_Get_Site_kpi_By_OWNER_ID i_Params_Get_Site_kpi_By_OWNER_ID)
        {
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_OWNER_ID", i_Params_Get_Site_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_OWNER_ID(i_Params_Get_Site_kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_OWNER_ID", i_Params_Get_Site_kpi_By_OWNER_ID_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<Site_kpi> Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Site_kpi_By_OWNER_ID_IS_DELETED
        public List<Site_kpi> Get_Site_kpi_By_OWNER_ID_IS_DELETED(Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED i_Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED)
        {
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_OWNER_ID_IS_DELETED(i_Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Site_kpi_By_SITE_ID
        public List<Site_kpi> Get_Site_kpi_By_SITE_ID(Params_Get_Site_kpi_By_SITE_ID i_Params_Get_Site_kpi_By_SITE_ID)
        {
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_SITE_ID", i_Params_Get_Site_kpi_By_SITE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_SITE_ID(i_Params_Get_Site_kpi_By_SITE_ID.SITE_ID);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_SITE_ID", i_Params_Get_Site_kpi_By_SITE_ID_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID
        public List<Setup_category> Get_Setup_category_By_OWNER_ID(Params_Get_Setup_category_By_OWNER_ID i_Params_Get_Setup_category_By_OWNER_ID)
        {
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_OWNER_ID", i_Params_Get_Setup_category_By_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Setup_category_By_OWNER_ID
            if (OnPreEvent_Get_Setup_category_By_OWNER_ID != null)
            {
                OnPreEvent_Get_Setup_category_By_OWNER_ID(i_Params_Get_Setup_category_By_OWNER_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_OWNER_ID(i_Params_Get_Setup_category_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Setup_category_By_OWNER_ID
            if (OnPostEvent_Get_Setup_category_By_OWNER_ID != null)
            {
                OnPostEvent_Get_Setup_category_By_OWNER_ID(oList_Setup_category, i_Params_Get_Setup_category_By_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_OWNER_ID", i_Params_Get_Setup_category_By_OWNER_ID_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID_IS_DELETED
        public List<Setup_category> Get_Setup_category_By_OWNER_ID_IS_DELETED(Params_Get_Setup_category_By_OWNER_ID_IS_DELETED i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED)
        {
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_OWNER_ID_IS_DELETED(i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID)
        {
            Setup_category oSetup_category = null;
            var i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
            if (OnPreEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID != null)
            {
                OnPreEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
            }
            #endregion
            #region Body Section.
            DALC.Setup_category oDBEntry = _AppContext.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME, i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID);
            if (oDBEntry != null)
            {
                oSetup_category = new Setup_category();
                Props.Copy_Prop_Values(oDBEntry, oSetup_category);
            }
            #endregion
            #region PostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
            if (OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID != null)
            {
                OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(oSetup_category, i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED(Params_Get_Setup_By_OWNER_ID_IS_DELETED i_Params_Get_Setup_By_OWNER_ID_IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID_IS_DELETED(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID(Params_Get_Setup_By_SETUP_CATEGORY_ID i_Params_Get_Setup_By_SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID(i_Params_Get_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_VALUE(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID, i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE);
            if (oDBEntry != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values(oDBEntry, oSetup);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID
        public List<Setup> Get_Setup_By_OWNER_ID(Params_Get_Setup_By_OWNER_ID i_Params_Get_Setup_By_OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID(i_Params_Get_Setup_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_OWNER_ID_IS_DELETED
        public List<Area_kpi> Get_Area_kpi_By_OWNER_ID_IS_DELETED(Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED i_Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED)
        {
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_OWNER_ID_IS_DELETED(i_Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Area_kpi_By_OWNER_ID
        public List<Area_kpi> Get_Area_kpi_By_OWNER_ID(Params_Get_Area_kpi_By_OWNER_ID i_Params_Get_Area_kpi_By_OWNER_ID)
        {
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_OWNER_ID", i_Params_Get_Area_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_OWNER_ID(i_Params_Get_Area_kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_OWNER_ID", i_Params_Get_Area_kpi_By_OWNER_ID_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Area_kpi_By_AREA_ID
        public List<Area_kpi> Get_Area_kpi_By_AREA_ID(Params_Get_Area_kpi_By_AREA_ID i_Params_Get_Area_kpi_By_AREA_ID)
        {
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_AREA_ID", i_Params_Get_Area_kpi_By_AREA_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_AREA_ID(i_Params_Get_Area_kpi_By_AREA_ID.AREA_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_AREA_ID", i_Params_Get_Area_kpi_By_AREA_ID_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<Area_kpi> Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Space_asset_By_OWNER_ID
        public List<Space_asset> Get_Space_asset_By_OWNER_ID(Params_Get_Space_asset_By_OWNER_ID i_Params_Get_Space_asset_By_OWNER_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_OWNER_ID", i_Params_Get_Space_asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_OWNER_ID(i_Params_Get_Space_asset_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_OWNER_ID", i_Params_Get_Space_asset_By_OWNER_ID_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ID
        public List<Space_asset> Get_Space_asset_By_SPACE_ID(Params_Get_Space_asset_By_SPACE_ID i_Params_Get_Space_asset_By_SPACE_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_SPACE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_SPACE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_SPACE_ID", i_Params_Get_Space_asset_By_SPACE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_SPACE_ID(i_Params_Get_Space_asset_By_SPACE_ID.SPACE_ID);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_SPACE_ID", i_Params_Get_Space_asset_By_SPACE_ID_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_ASSET_ID
        public List<Space_asset> Get_Space_asset_By_ASSET_ID(Params_Get_Space_asset_By_ASSET_ID i_Params_Get_Space_asset_By_ASSET_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_ASSET_ID", i_Params_Get_Space_asset_By_ASSET_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_ASSET_ID(i_Params_Get_Space_asset_By_ASSET_ID.ASSET_ID);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_ASSET_ID", i_Params_Get_Space_asset_By_ASSET_ID_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_OWNER_ID_IS_DELETED
        public List<Space_asset> Get_Space_asset_By_OWNER_ID_IS_DELETED(Params_Get_Space_asset_By_OWNER_ID_IS_DELETED i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_OWNER_ID_IS_DELETED", i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_OWNER_ID_IS_DELETED(i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_OWNER_ID_IS_DELETED", i_Params_Get_Space_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_EXTERNAL_ID
        public List<Space_asset> Get_Space_asset_By_EXTERNAL_ID(Params_Get_Space_asset_By_EXTERNAL_ID i_Params_Get_Space_asset_By_EXTERNAL_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_EXTERNAL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_EXTERNAL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_EXTERNAL_ID", i_Params_Get_Space_asset_By_EXTERNAL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_EXTERNAL_ID(i_Params_Get_Space_asset_By_EXTERNAL_ID.EXTERNAL_ID);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_EXTERNAL_ID", i_Params_Get_Space_asset_By_EXTERNAL_ID_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
        public List<Space_asset> Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL", i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL.IS_MERAKI_WIFI_SIGNAL);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL", i_Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_District_By_OWNER_ID_IS_DELETED
        public List<District> Get_District_By_OWNER_ID_IS_DELETED(Params_Get_District_By_OWNER_ID_IS_DELETED i_Params_Get_District_By_OWNER_ID_IS_DELETED)
        {
            List<District> oList_District = null;
            var i_Params_Get_District_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_District_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_OWNER_ID_IS_DELETED", i_Params_Get_District_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_OWNER_ID_IS_DELETED(i_Params_Get_District_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_District_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_OWNER_ID_IS_DELETED", i_Params_Get_District_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_OWNER_ID
        public List<District> Get_District_By_OWNER_ID(Params_Get_District_By_OWNER_ID i_Params_Get_District_By_OWNER_ID)
        {
            List<District> oList_District = null;
            var i_Params_Get_District_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_OWNER_ID", i_Params_Get_District_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_OWNER_ID(i_Params_Get_District_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_OWNER_ID", i_Params_Get_District_By_OWNER_ID_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_REGION_ID
        public List<District> Get_District_By_REGION_ID(Params_Get_District_By_REGION_ID i_Params_Get_District_By_REGION_ID)
        {
            List<District> oList_District = null;
            var i_Params_Get_District_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_REGION_ID", i_Params_Get_District_By_REGION_ID_json, false);
            }
            #region Body Section.
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_REGION_ID(i_Params_Get_District_By_REGION_ID.REGION_ID);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_REGION_ID", i_Params_Get_District_By_REGION_ID_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_TOP_LEVEL_ID
        public List<District> Get_District_By_TOP_LEVEL_ID(Params_Get_District_By_TOP_LEVEL_ID i_Params_Get_District_By_TOP_LEVEL_ID)
        {
            List<District> oList_District = null;
            var i_Params_Get_District_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_TOP_LEVEL_ID", i_Params_Get_District_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_TOP_LEVEL_ID(i_Params_Get_District_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_TOP_LEVEL_ID", i_Params_Get_District_By_TOP_LEVEL_ID_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID(Params_Get_Organization_data_source_kpi_By_OWNER_ID i_Params_Get_Organization_data_source_kpi_By_OWNER_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_OWNER_ID(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID(Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_DATA_SOURCE_ID(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID.DATA_SOURCE_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID(Params_Get_Organization_data_source_kpi_By_KPI_ID i_Params_Get_Organization_data_source_kpi_By_KPI_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_KPI_ID", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_KPI_ID(i_Params_Get_Organization_data_source_kpi_By_KPI_ID.KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_KPI_ID", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_ID(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_OWNER_ID_IS_DELETED
        public List<Floor> Get_Floor_By_OWNER_ID_IS_DELETED(Params_Get_Floor_By_OWNER_ID_IS_DELETED i_Params_Get_Floor_By_OWNER_ID_IS_DELETED)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_OWNER_ID_IS_DELETED", i_Params_Get_Floor_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_OWNER_ID_IS_DELETED(i_Params_Get_Floor_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Floor_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_OWNER_ID_IS_DELETED", i_Params_Get_Floor_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Floor_By_OWNER_ID
        public List<Floor> Get_Floor_By_OWNER_ID(Params_Get_Floor_By_OWNER_ID i_Params_Get_Floor_By_OWNER_ID)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_OWNER_ID", i_Params_Get_Floor_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_OWNER_ID(i_Params_Get_Floor_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_OWNER_ID", i_Params_Get_Floor_By_OWNER_ID_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Floor_By_ENTITY_ID
        public List<Floor> Get_Floor_By_ENTITY_ID(Params_Get_Floor_By_ENTITY_ID i_Params_Get_Floor_By_ENTITY_ID)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_ENTITY_ID", i_Params_Get_Floor_By_ENTITY_ID_json, false);
            }
            #region PreEvent_Get_Floor_By_ENTITY_ID
            if (OnPreEvent_Get_Floor_By_ENTITY_ID != null)
            {
                OnPreEvent_Get_Floor_By_ENTITY_ID(i_Params_Get_Floor_By_ENTITY_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_ENTITY_ID(i_Params_Get_Floor_By_ENTITY_ID.ENTITY_ID);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Floor_By_ENTITY_ID
            if (OnPostEvent_Get_Floor_By_ENTITY_ID != null)
            {
                OnPostEvent_Get_Floor_By_ENTITY_ID(oList_Floor, i_Params_Get_Floor_By_ENTITY_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_ENTITY_ID", i_Params_Get_Floor_By_ENTITY_ID_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED(Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED i_Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED(i_Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_OWNER_ID
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_OWNER_ID(Params_Get_District_kpi_user_access_By_OWNER_ID i_Params_Get_District_kpi_user_access_By_OWNER_ID)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_OWNER_ID", i_Params_Get_District_kpi_user_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_OWNER_ID(i_Params_Get_District_kpi_user_access_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_OWNER_ID", i_Params_Get_District_kpi_user_access_By_OWNER_ID_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_USER_ID
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_USER_ID(Params_Get_District_kpi_user_access_By_USER_ID i_Params_Get_District_kpi_user_access_By_USER_ID)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_USER_ID", i_Params_Get_District_kpi_user_access_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_USER_ID(i_Params_Get_District_kpi_user_access_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_USER_ID", i_Params_Get_District_kpi_user_access_By_USER_ID_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_ID
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_ID(Params_Get_District_kpi_user_access_By_DISTRICT_ID i_Params_Get_District_kpi_user_access_By_DISTRICT_ID)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_DISTRICT_ID", i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_DISTRICT_ID(i_Params_Get_District_kpi_user_access_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_DISTRICT_ID", i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_OWNER_ID_IS_DELETED
        public List<User> Get_User_By_OWNER_ID_IS_DELETED(Params_Get_User_By_OWNER_ID_IS_DELETED i_Params_Get_User_By_OWNER_ID_IS_DELETED)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_OWNER_ID_IS_DELETED", i_Params_Get_User_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_OWNER_ID_IS_DELETED(i_Params_Get_User_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_User_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_OWNER_ID_IS_DELETED", i_Params_Get_User_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_USERNAME_OWNER_ID
        public User Get_User_By_USERNAME_OWNER_ID(Params_Get_User_By_USERNAME_OWNER_ID i_Params_Get_User_By_USERNAME_OWNER_ID)
        {
            User oUser = null;
            var i_Params_Get_User_By_USERNAME_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USERNAME_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USERNAME_OWNER_ID", i_Params_Get_User_By_USERNAME_OWNER_ID_json, false);
            }
            #region Body Section.
            DALC.User oDBEntry = _AppContext.Get_User_By_USERNAME_OWNER_ID(i_Params_Get_User_By_USERNAME_OWNER_ID.USERNAME, i_Params_Get_User_By_USERNAME_OWNER_ID.OWNER_ID);
            if (oDBEntry != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values(oDBEntry, oUser);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USERNAME_OWNER_ID", i_Params_Get_User_By_USERNAME_OWNER_ID_json, false);
            }
            return oUser;
        }
        #endregion
        #region Get_User_By_EMAIL_OWNER_ID
        public User Get_User_By_EMAIL_OWNER_ID(Params_Get_User_By_EMAIL_OWNER_ID i_Params_Get_User_By_EMAIL_OWNER_ID)
        {
            User oUser = null;
            var i_Params_Get_User_By_EMAIL_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_EMAIL_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_EMAIL_OWNER_ID", i_Params_Get_User_By_EMAIL_OWNER_ID_json, false);
            }
            #region Body Section.
            DALC.User oDBEntry = _AppContext.Get_User_By_EMAIL_OWNER_ID(i_Params_Get_User_By_EMAIL_OWNER_ID.EMAIL, i_Params_Get_User_By_EMAIL_OWNER_ID.OWNER_ID);
            if (oDBEntry != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values(oDBEntry, oUser);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_EMAIL_OWNER_ID", i_Params_Get_User_By_EMAIL_OWNER_ID_json, false);
            }
            return oUser;
        }
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID
        public List<User> Get_User_By_USER_TYPE_SETUP_ID(Params_Get_User_By_USER_TYPE_SETUP_ID i_Params_Get_User_By_USER_TYPE_SETUP_ID)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_USER_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_TYPE_SETUP_ID", i_Params_Get_User_By_USER_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_USER_TYPE_SETUP_ID(i_Params_Get_User_By_USER_TYPE_SETUP_ID.USER_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_TYPE_SETUP_ID", i_Params_Get_User_By_USER_TYPE_SETUP_ID_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_ORGANIZATION_ID
        public List<User> Get_User_By_ORGANIZATION_ID(Params_Get_User_By_ORGANIZATION_ID i_Params_Get_User_By_ORGANIZATION_ID)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_ORGANIZATION_ID", i_Params_Get_User_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_ORGANIZATION_ID(i_Params_Get_User_By_ORGANIZATION_ID.ORGANIZATION_ID);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_ORGANIZATION_ID", i_Params_Get_User_By_ORGANIZATION_ID_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_OWNER_ID
        public List<User> Get_User_By_OWNER_ID(Params_Get_User_By_OWNER_ID i_Params_Get_User_By_OWNER_ID)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_OWNER_ID", i_Params_Get_User_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_OWNER_ID(i_Params_Get_User_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_OWNER_ID", i_Params_Get_User_By_OWNER_ID_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_IS_RECEIVE_EMAIL
        public List<User> Get_User_By_IS_RECEIVE_EMAIL(Params_Get_User_By_IS_RECEIVE_EMAIL i_Params_Get_User_By_IS_RECEIVE_EMAIL)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_IS_RECEIVE_EMAIL_json = JsonConvert.SerializeObject(i_Params_Get_User_By_IS_RECEIVE_EMAIL);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_IS_RECEIVE_EMAIL", i_Params_Get_User_By_IS_RECEIVE_EMAIL_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_IS_RECEIVE_EMAIL(i_Params_Get_User_By_IS_RECEIVE_EMAIL.IS_RECEIVE_EMAIL);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_IS_RECEIVE_EMAIL", i_Params_Get_User_By_IS_RECEIVE_EMAIL_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_IS_DELETED
        public List<User> Get_User_By_IS_DELETED(Params_Get_User_By_IS_DELETED i_Params_Get_User_By_IS_DELETED)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_By_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_IS_DELETED", i_Params_Get_User_By_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_IS_DELETED(i_Params_Get_User_By_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_IS_DELETED", i_Params_Get_User_By_IS_DELETED_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
        public List<User> Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED", i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.OWNER_ID, i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_ACTIVE, i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED", i_Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_Space_By_OWNER_ID
        public List<Space> Get_Space_By_OWNER_ID(Params_Get_Space_By_OWNER_ID i_Params_Get_Space_By_OWNER_ID)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_OWNER_ID", i_Params_Get_Space_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_OWNER_ID(i_Params_Get_Space_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_OWNER_ID", i_Params_Get_Space_By_OWNER_ID_json, false);
            }
            return oList_Space;
        }
        #endregion
        #region Get_Space_By_FLOOR_ID
        public List<Space> Get_Space_By_FLOOR_ID(Params_Get_Space_By_FLOOR_ID i_Params_Get_Space_By_FLOOR_ID)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_FLOOR_ID_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_FLOOR_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_FLOOR_ID", i_Params_Get_Space_By_FLOOR_ID_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_FLOOR_ID(i_Params_Get_Space_By_FLOOR_ID.FLOOR_ID);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_FLOOR_ID", i_Params_Get_Space_By_FLOOR_ID_json, false);
            }
            return oList_Space;
        }
        #endregion
        #region Get_Space_By_OWNER_ID_IS_DELETED
        public List<Space> Get_Space_By_OWNER_ID_IS_DELETED(Params_Get_Space_By_OWNER_ID_IS_DELETED i_Params_Get_Space_By_OWNER_ID_IS_DELETED)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_OWNER_ID_IS_DELETED", i_Params_Get_Space_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_OWNER_ID_IS_DELETED(i_Params_Get_Space_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Space_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_OWNER_ID_IS_DELETED", i_Params_Get_Space_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Space;
        }
        #endregion
        #region Get_Site_By_OWNER_ID_IS_DELETED
        public List<Site> Get_Site_By_OWNER_ID_IS_DELETED(Params_Get_Site_By_OWNER_ID_IS_DELETED i_Params_Get_Site_By_OWNER_ID_IS_DELETED)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_OWNER_ID_IS_DELETED", i_Params_Get_Site_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_OWNER_ID_IS_DELETED(i_Params_Get_Site_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Site_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_OWNER_ID_IS_DELETED", i_Params_Get_Site_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_OWNER_ID
        public List<Site> Get_Site_By_OWNER_ID(Params_Get_Site_By_OWNER_ID i_Params_Get_Site_By_OWNER_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_OWNER_ID", i_Params_Get_Site_By_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Site_By_OWNER_ID
            if (OnPreEvent_Get_Site_By_OWNER_ID != null)
            {
                OnPreEvent_Get_Site_By_OWNER_ID(i_Params_Get_Site_By_OWNER_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_OWNER_ID(i_Params_Get_Site_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Site_By_OWNER_ID
            if (OnPostEvent_Get_Site_By_OWNER_ID != null)
            {
                OnPostEvent_Get_Site_By_OWNER_ID(oList_Site, i_Params_Get_Site_By_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_OWNER_ID", i_Params_Get_Site_By_OWNER_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_AREA_ID
        public List<Site> Get_Site_By_AREA_ID(Params_Get_Site_By_AREA_ID i_Params_Get_Site_By_AREA_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_AREA_ID", i_Params_Get_Site_By_AREA_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_AREA_ID(i_Params_Get_Site_By_AREA_ID.AREA_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_AREA_ID", i_Params_Get_Site_By_AREA_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_DISTRICT_ID
        public List<Site> Get_Site_By_DISTRICT_ID(Params_Get_Site_By_DISTRICT_ID i_Params_Get_Site_By_DISTRICT_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_DISTRICT_ID", i_Params_Get_Site_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_DISTRICT_ID(i_Params_Get_Site_By_DISTRICT_ID.DISTRICT_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_DISTRICT_ID", i_Params_Get_Site_By_DISTRICT_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_REGION_ID
        public List<Site> Get_Site_By_REGION_ID(Params_Get_Site_By_REGION_ID i_Params_Get_Site_By_REGION_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_REGION_ID", i_Params_Get_Site_By_REGION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_REGION_ID(i_Params_Get_Site_By_REGION_ID.REGION_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_REGION_ID", i_Params_Get_Site_By_REGION_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_TOP_LEVEL_ID
        public List<Site> Get_Site_By_TOP_LEVEL_ID(Params_Get_Site_By_TOP_LEVEL_ID i_Params_Get_Site_By_TOP_LEVEL_ID)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_TOP_LEVEL_ID", i_Params_Get_Site_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_TOP_LEVEL_ID(i_Params_Get_Site_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_TOP_LEVEL_ID", i_Params_Get_Site_By_TOP_LEVEL_ID_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Kpi_By_DIMENSION_ID_List
        public List<Kpi> Get_Kpi_By_DIMENSION_ID_List(Params_Get_Kpi_By_DIMENSION_ID_List i_Params_Get_Kpi_By_DIMENSION_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_DIMENSION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_DIMENSION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_DIMENSION_ID_List", i_Params_Get_Kpi_By_DIMENSION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_DIMENSION_ID_List(i_Params_Get_Kpi_By_DIMENSION_ID_List.DIMENSION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_DIMENSION_ID_List", i_Params_Get_Kpi_By_DIMENSION_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID_List
        public List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID_List(Params_Get_Kpi_By_SETUP_CATEGORY_ID_List i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_SETUP_CATEGORY_ID_List", i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_SETUP_CATEGORY_ID_List(i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_SETUP_CATEGORY_ID_List", i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List
        public List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List(Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List(i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List.MIN_DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List
        public List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List(Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List(i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List.MAX_DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID_List
        public List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID_List(Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_KPI_TYPE_SETUP_ID_List", i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_KPI_TYPE_SETUP_ID_List(i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List.KPI_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_KPI_TYPE_SETUP_ID_List", i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID_List
        public List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID_List(Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID_List", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_ASSET_TYPE_SETUP_ID_List(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List.ASSET_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID_List", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_USER_ID_List
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_USER_ID_List(Params_Get_Area_kpi_user_access_By_USER_ID_List i_Params_Get_Area_kpi_user_access_By_USER_ID_List)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_USER_ID_List", i_Params_Get_Area_kpi_user_access_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_USER_ID_List(i_Params_Get_Area_kpi_user_access_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_USER_ID_List", i_Params_Get_Area_kpi_user_access_By_USER_ID_List_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_ID_List
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_ID_List(Params_Get_Area_kpi_user_access_By_AREA_ID_List i_Params_Get_Area_kpi_user_access_By_AREA_ID_List)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_AREA_ID_List", i_Params_Get_Area_kpi_user_access_By_AREA_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_AREA_ID_List(i_Params_Get_Area_kpi_user_access_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_AREA_ID_List", i_Params_Get_Area_kpi_user_access_By_AREA_ID_List_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_USER_ID_List
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_USER_ID_List(Params_Get_Site_kpi_user_access_By_USER_ID_List i_Params_Get_Site_kpi_user_access_By_USER_ID_List)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_USER_ID_List", i_Params_Get_Site_kpi_user_access_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_USER_ID_List(i_Params_Get_Site_kpi_user_access_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_USER_ID_List", i_Params_Get_Site_kpi_user_access_By_USER_ID_List_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_ID_List
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_ID_List(Params_Get_Site_kpi_user_access_By_SITE_ID_List i_Params_Get_Site_kpi_user_access_By_SITE_ID_List)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_SITE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_SITE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_SITE_ID_List", i_Params_Get_Site_kpi_user_access_By_SITE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_SITE_ID_List(i_Params_Get_Site_kpi_user_access_By_SITE_ID_List.SITE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_SITE_ID_List", i_Params_Get_Site_kpi_user_access_By_SITE_ID_List_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Entity_kpi> Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_kpi_By_ENTITY_ID_List
        public List<Entity_kpi> Get_Entity_kpi_By_ENTITY_ID_List(Params_Get_Entity_kpi_By_ENTITY_ID_List i_Params_Get_Entity_kpi_By_ENTITY_ID_List)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_ENTITY_ID_List", i_Params_Get_Entity_kpi_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_ENTITY_ID_List(i_Params_Get_Entity_kpi_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_ENTITY_ID_List", i_Params_Get_Entity_kpi_By_ENTITY_ID_List_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_SITE_ID_List
        public List<Entity> Get_Entity_By_SITE_ID_List(Params_Get_Entity_By_SITE_ID_List i_Params_Get_Entity_By_SITE_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_SITE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_SITE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_SITE_ID_List", i_Params_Get_Entity_By_SITE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_SITE_ID_List(i_Params_Get_Entity_By_SITE_ID_List.SITE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_SITE_ID_List", i_Params_Get_Entity_By_SITE_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_AREA_ID_List
        public List<Entity> Get_Entity_By_AREA_ID_List(Params_Get_Entity_By_AREA_ID_List i_Params_Get_Entity_By_AREA_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_AREA_ID_List", i_Params_Get_Entity_By_AREA_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_AREA_ID_List(i_Params_Get_Entity_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_AREA_ID_List", i_Params_Get_Entity_By_AREA_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_DISTRICT_ID_List
        public List<Entity> Get_Entity_By_DISTRICT_ID_List(Params_Get_Entity_By_DISTRICT_ID_List i_Params_Get_Entity_By_DISTRICT_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_DISTRICT_ID_List", i_Params_Get_Entity_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_DISTRICT_ID_List(i_Params_Get_Entity_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_DISTRICT_ID_List", i_Params_Get_Entity_By_DISTRICT_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_REGION_ID_List
        public List<Entity> Get_Entity_By_REGION_ID_List(Params_Get_Entity_By_REGION_ID_List i_Params_Get_Entity_By_REGION_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_REGION_ID_List", i_Params_Get_Entity_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_REGION_ID_List(i_Params_Get_Entity_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_REGION_ID_List", i_Params_Get_Entity_By_REGION_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID_List
        public List<Entity> Get_Entity_By_TOP_LEVEL_ID_List(Params_Get_Entity_By_TOP_LEVEL_ID_List i_Params_Get_Entity_By_TOP_LEVEL_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_TOP_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_TOP_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_TOP_LEVEL_ID_List", i_Params_Get_Entity_By_TOP_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_TOP_LEVEL_ID_List(i_Params_Get_Entity_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_TOP_LEVEL_ID_List", i_Params_Get_Entity_By_TOP_LEVEL_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID_List
        public List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID_List(Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List)
        {
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID_List", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_ENTITY_TYPE_SETUP_ID_List(i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List.ENTITY_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_ENTITY_TYPE_SETUP_ID_List", i_Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<District_kpi> Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_District_kpi_By_DISTRICT_ID_List
        public List<District_kpi> Get_District_kpi_By_DISTRICT_ID_List(Params_Get_District_kpi_By_DISTRICT_ID_List i_Params_Get_District_kpi_By_DISTRICT_ID_List)
        {
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_DISTRICT_ID_List", i_Params_Get_District_kpi_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_DISTRICT_ID_List(i_Params_Get_District_kpi_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_DISTRICT_ID_List", i_Params_Get_District_kpi_By_DISTRICT_ID_List_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_USER_ID_List
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_USER_ID_List(Params_Get_Entity_kpi_user_access_By_USER_ID_List i_Params_Get_Entity_kpi_user_access_By_USER_ID_List)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_USER_ID_List", i_Params_Get_Entity_kpi_user_access_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_USER_ID_List(i_Params_Get_Entity_kpi_user_access_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_USER_ID_List", i_Params_Get_Entity_kpi_user_access_By_USER_ID_List_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_ID_List
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_ID_List(Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_ENTITY_ID_List", i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_ENTITY_ID_List(i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_ENTITY_ID_List", i_Params_Get_Entity_kpi_user_access_By_ENTITY_ID_List_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Area_By_DISTRICT_ID_List
        public List<Area> Get_Area_By_DISTRICT_ID_List(Params_Get_Area_By_DISTRICT_ID_List i_Params_Get_Area_By_DISTRICT_ID_List)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_DISTRICT_ID_List", i_Params_Get_Area_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_DISTRICT_ID_List(i_Params_Get_Area_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_DISTRICT_ID_List", i_Params_Get_Area_By_DISTRICT_ID_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_REGION_ID_List
        public List<Area> Get_Area_By_REGION_ID_List(Params_Get_Area_By_REGION_ID_List i_Params_Get_Area_By_REGION_ID_List)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_REGION_ID_List", i_Params_Get_Area_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_REGION_ID_List(i_Params_Get_Area_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_REGION_ID_List", i_Params_Get_Area_By_REGION_ID_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_TOP_LEVEL_ID_List
        public List<Area> Get_Area_By_TOP_LEVEL_ID_List(Params_Get_Area_By_TOP_LEVEL_ID_List i_Params_Get_Area_By_TOP_LEVEL_ID_List)
        {
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_TOP_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_TOP_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_TOP_LEVEL_ID_List", i_Params_Get_Area_By_TOP_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_TOP_LEVEL_ID_List(i_Params_Get_Area_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_TOP_LEVEL_ID_List", i_Params_Get_Area_By_TOP_LEVEL_ID_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Site_kpi> Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Site_kpi_By_SITE_ID_List
        public List<Site_kpi> Get_Site_kpi_By_SITE_ID_List(Params_Get_Site_kpi_By_SITE_ID_List i_Params_Get_Site_kpi_By_SITE_ID_List)
        {
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_SITE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_SITE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_SITE_ID_List", i_Params_Get_Site_kpi_By_SITE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_SITE_ID_List(i_Params_Get_Site_kpi_By_SITE_ID_List.SITE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_SITE_ID_List", i_Params_Get_Site_kpi_By_SITE_ID_List_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(Params_Get_Setup_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_List(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_AREA_ID_List
        public List<Area_kpi> Get_Area_kpi_By_AREA_ID_List(Params_Get_Area_kpi_By_AREA_ID_List i_Params_Get_Area_kpi_By_AREA_ID_List)
        {
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_AREA_ID_List", i_Params_Get_Area_kpi_By_AREA_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_AREA_ID_List(i_Params_Get_Area_kpi_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_AREA_ID_List", i_Params_Get_Area_kpi_By_AREA_ID_List_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Area_kpi> Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ID_List
        public List<Space_asset> Get_Space_asset_By_SPACE_ID_List(Params_Get_Space_asset_By_SPACE_ID_List i_Params_Get_Space_asset_By_SPACE_ID_List)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_SPACE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_SPACE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_SPACE_ID_List", i_Params_Get_Space_asset_By_SPACE_ID_List_json, false);
            }
            #region PreEvent_Get_Space_asset_By_SPACE_ID_List
            if (OnPreEvent_Get_Space_asset_By_SPACE_ID_List != null)
            {
                OnPreEvent_Get_Space_asset_By_SPACE_ID_List(i_Params_Get_Space_asset_By_SPACE_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_SPACE_ID_List(i_Params_Get_Space_asset_By_SPACE_ID_List.SPACE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Space_asset_By_SPACE_ID_List
            if (OnPostEvent_Get_Space_asset_By_SPACE_ID_List != null)
            {
                OnPostEvent_Get_Space_asset_By_SPACE_ID_List(oList_Space_asset, i_Params_Get_Space_asset_By_SPACE_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_SPACE_ID_List", i_Params_Get_Space_asset_By_SPACE_ID_List_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_ASSET_ID_List
        public List<Space_asset> Get_Space_asset_By_ASSET_ID_List(Params_Get_Space_asset_By_ASSET_ID_List i_Params_Get_Space_asset_By_ASSET_ID_List)
        {
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_ASSET_ID_List", i_Params_Get_Space_asset_By_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_ASSET_ID_List(i_Params_Get_Space_asset_By_ASSET_ID_List.ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_ASSET_ID_List", i_Params_Get_Space_asset_By_ASSET_ID_List_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_District_By_REGION_ID_List
        public List<District> Get_District_By_REGION_ID_List(Params_Get_District_By_REGION_ID_List i_Params_Get_District_By_REGION_ID_List)
        {
            List<District> oList_District = null;
            var i_Params_Get_District_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_REGION_ID_List", i_Params_Get_District_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_REGION_ID_List(i_Params_Get_District_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_REGION_ID_List", i_Params_Get_District_By_REGION_ID_List_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_TOP_LEVEL_ID_List
        public List<District> Get_District_By_TOP_LEVEL_ID_List(Params_Get_District_By_TOP_LEVEL_ID_List i_Params_Get_District_By_TOP_LEVEL_ID_List)
        {
            List<District> oList_District = null;
            var i_Params_Get_District_By_TOP_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_By_TOP_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_TOP_LEVEL_ID_List", i_Params_Get_District_By_TOP_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_TOP_LEVEL_ID_List(i_Params_Get_District_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_TOP_LEVEL_ID_List", i_Params_Get_District_By_TOP_LEVEL_ID_List_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List(Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List(i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List.DATA_SOURCE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List", i_Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_List(Params_Get_Organization_data_source_kpi_By_KPI_ID_List i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_KPI_ID_List", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_KPI_ID_List(i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List.KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_KPI_ID_List", i_Params_Get_Organization_data_source_kpi_By_KPI_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List(Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List(i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List", i_Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_ENTITY_ID_List
        public List<Floor> Get_Floor_By_ENTITY_ID_List(Params_Get_Floor_By_ENTITY_ID_List i_Params_Get_Floor_By_ENTITY_ID_List)
        {
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_ENTITY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_ENTITY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_ENTITY_ID_List", i_Params_Get_Floor_By_ENTITY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_ENTITY_ID_List(i_Params_Get_Floor_By_ENTITY_ID_List.ENTITY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_ENTITY_ID_List", i_Params_Get_Floor_By_ENTITY_ID_List_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_District_kpi_user_access_By_USER_ID_List
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_USER_ID_List(Params_Get_District_kpi_user_access_By_USER_ID_List i_Params_Get_District_kpi_user_access_By_USER_ID_List)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_USER_ID_List", i_Params_Get_District_kpi_user_access_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_USER_ID_List(i_Params_Get_District_kpi_user_access_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_USER_ID_List", i_Params_Get_District_kpi_user_access_By_USER_ID_List_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_ID_List
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_ID_List(Params_Get_District_kpi_user_access_By_DISTRICT_ID_List i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_List)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_DISTRICT_ID_List", i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_DISTRICT_ID_List(i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_DISTRICT_ID_List", i_Params_Get_District_kpi_user_access_By_DISTRICT_ID_List_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List", i_Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID_List
        public List<User> Get_User_By_USER_TYPE_SETUP_ID_List(Params_Get_User_By_USER_TYPE_SETUP_ID_List i_Params_Get_User_By_USER_TYPE_SETUP_ID_List)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_USER_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_USER_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_USER_TYPE_SETUP_ID_List", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_USER_TYPE_SETUP_ID_List(i_Params_Get_User_By_USER_TYPE_SETUP_ID_List.USER_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_USER_TYPE_SETUP_ID_List", i_Params_Get_User_By_USER_TYPE_SETUP_ID_List_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_ORGANIZATION_ID_List
        public List<User> Get_User_By_ORGANIZATION_ID_List(Params_Get_User_By_ORGANIZATION_ID_List i_Params_Get_User_By_ORGANIZATION_ID_List)
        {
            List<User> oList_User = null;
            var i_Params_Get_User_By_ORGANIZATION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_ORGANIZATION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_ORGANIZATION_ID_List", i_Params_Get_User_By_ORGANIZATION_ID_List_json, false);
            }
            #region PreEvent_Get_User_By_ORGANIZATION_ID_List
            if (OnPreEvent_Get_User_By_ORGANIZATION_ID_List != null)
            {
                OnPreEvent_Get_User_By_ORGANIZATION_ID_List(i_Params_Get_User_By_ORGANIZATION_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_ORGANIZATION_ID_List(i_Params_Get_User_By_ORGANIZATION_ID_List.ORGANIZATION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_User_By_ORGANIZATION_ID_List
            if (OnPostEvent_Get_User_By_ORGANIZATION_ID_List != null)
            {
                OnPostEvent_Get_User_By_ORGANIZATION_ID_List(oList_User, i_Params_Get_User_By_ORGANIZATION_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_ORGANIZATION_ID_List", i_Params_Get_User_By_ORGANIZATION_ID_List_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_Space_By_FLOOR_ID_List
        public List<Space> Get_Space_By_FLOOR_ID_List(Params_Get_Space_By_FLOOR_ID_List i_Params_Get_Space_By_FLOOR_ID_List)
        {
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_FLOOR_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_FLOOR_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_FLOOR_ID_List", i_Params_Get_Space_By_FLOOR_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_FLOOR_ID_List(i_Params_Get_Space_By_FLOOR_ID_List.FLOOR_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_FLOOR_ID_List", i_Params_Get_Space_By_FLOOR_ID_List_json, false);
            }
            return oList_Space;
        }
        #endregion
        #region Get_Site_By_AREA_ID_List
        public List<Site> Get_Site_By_AREA_ID_List(Params_Get_Site_By_AREA_ID_List i_Params_Get_Site_By_AREA_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_AREA_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_AREA_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_AREA_ID_List", i_Params_Get_Site_By_AREA_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_AREA_ID_List(i_Params_Get_Site_By_AREA_ID_List.AREA_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_AREA_ID_List", i_Params_Get_Site_By_AREA_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_DISTRICT_ID_List
        public List<Site> Get_Site_By_DISTRICT_ID_List(Params_Get_Site_By_DISTRICT_ID_List i_Params_Get_Site_By_DISTRICT_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_DISTRICT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_DISTRICT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_DISTRICT_ID_List", i_Params_Get_Site_By_DISTRICT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_DISTRICT_ID_List(i_Params_Get_Site_By_DISTRICT_ID_List.DISTRICT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_DISTRICT_ID_List", i_Params_Get_Site_By_DISTRICT_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_REGION_ID_List
        public List<Site> Get_Site_By_REGION_ID_List(Params_Get_Site_By_REGION_ID_List i_Params_Get_Site_By_REGION_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_REGION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_REGION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_REGION_ID_List", i_Params_Get_Site_By_REGION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_REGION_ID_List(i_Params_Get_Site_By_REGION_ID_List.REGION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_REGION_ID_List", i_Params_Get_Site_By_REGION_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_TOP_LEVEL_ID_List
        public List<Site> Get_Site_By_TOP_LEVEL_ID_List(Params_Get_Site_By_TOP_LEVEL_ID_List i_Params_Get_Site_By_TOP_LEVEL_ID_List)
        {
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_TOP_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_TOP_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_TOP_LEVEL_ID_List", i_Params_Get_Site_By_TOP_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_TOP_LEVEL_ID_List(i_Params_Get_Site_By_TOP_LEVEL_ID_List.TOP_LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_TOP_LEVEL_ID_List", i_Params_Get_Site_By_TOP_LEVEL_ID_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Kpi_By_Where
        public List<Kpi> Get_Kpi_By_Where(Params_Get_Kpi_By_Where i_Params_Get_Kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_Where", i_Params_Get_Kpi_By_Where_json, false);
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
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_Where(i_Params_Get_Kpi_By_Where.NAME, i_Params_Get_Kpi_By_Where.UNIT, i_Params_Get_Kpi_By_Where.OWNER_ID, i_Params_Get_Kpi_By_Where.OFFSET, i_Params_Get_Kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            i_Params_Get_Kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_Where", i_Params_Get_Kpi_By_Where_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Asset_By_Where
        public List<Asset> Get_Asset_By_Where(Params_Get_Asset_By_Where i_Params_Get_Asset_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_Where", i_Params_Get_Asset_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Asset_By_Where.OWNER_ID == null || i_Params_Get_Asset_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Asset_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Asset_By_Where.OFFSET == null)
            {
                i_Params_Get_Asset_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Asset_By_Where.FETCH_NEXT == null || i_Params_Get_Asset_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Asset_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_Where(i_Params_Get_Asset_By_Where.NAME, i_Params_Get_Asset_By_Where.GLTF_URL, i_Params_Get_Asset_By_Where.OWNER_ID, i_Params_Get_Asset_By_Where.OFFSET, i_Params_Get_Asset_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            i_Params_Get_Asset_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_Where", i_Params_Get_Asset_By_Where_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Ext_study_zone_By_Where
        public List<Ext_study_zone> Get_Ext_study_zone_By_Where(Params_Get_Ext_study_zone_By_Where i_Params_Get_Ext_study_zone_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Ext_study_zone> oList_Ext_study_zone = null;
            var i_Params_Get_Ext_study_zone_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Ext_study_zone_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Ext_study_zone_By_Where", i_Params_Get_Ext_study_zone_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Ext_study_zone_By_Where.OWNER_ID == null || i_Params_Get_Ext_study_zone_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Ext_study_zone_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Ext_study_zone_By_Where.OFFSET == null)
            {
                i_Params_Get_Ext_study_zone_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Ext_study_zone_By_Where.FETCH_NEXT == null || i_Params_Get_Ext_study_zone_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Ext_study_zone_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Ext_study_zone> oList_DBEntry = _AppContext.Get_Ext_study_zone_By_Where(i_Params_Get_Ext_study_zone_By_Where.NAME, i_Params_Get_Ext_study_zone_By_Where.AREA_COLOR, i_Params_Get_Ext_study_zone_By_Where.BORDER_COLOR, i_Params_Get_Ext_study_zone_By_Where.STUDY_ZONE_NAME, i_Params_Get_Ext_study_zone_By_Where.OWNER_ID, i_Params_Get_Ext_study_zone_By_Where.OFFSET, i_Params_Get_Ext_study_zone_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Ext_study_zone = new List<Ext_study_zone>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Ext_study_zone oExt_study_zone = new Ext_study_zone();
                        Props.Copy_Prop_Values(oDBEntry, oExt_study_zone);
                        oList_Ext_study_zone.Add(oExt_study_zone);
                    }
                }
            }
            i_Params_Get_Ext_study_zone_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Ext_study_zone_By_Where", i_Params_Get_Ext_study_zone_By_Where_json, false);
            }
            return oList_Ext_study_zone;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_Where
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_Where(Params_Get_Area_kpi_user_access_By_Where i_Params_Get_Area_kpi_user_access_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_Where", i_Params_Get_Area_kpi_user_access_By_Where_json, false);
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
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_Where(i_Params_Get_Area_kpi_user_access_By_Where.DESCRIPTION, i_Params_Get_Area_kpi_user_access_By_Where.OWNER_ID, i_Params_Get_Area_kpi_user_access_By_Where.OFFSET, i_Params_Get_Area_kpi_user_access_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            i_Params_Get_Area_kpi_user_access_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_Where", i_Params_Get_Area_kpi_user_access_By_Where_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_Where
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_Where(Params_Get_Site_kpi_user_access_By_Where i_Params_Get_Site_kpi_user_access_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_Where", i_Params_Get_Site_kpi_user_access_By_Where_json, false);
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
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_Where(i_Params_Get_Site_kpi_user_access_By_Where.DESCRIPTION, i_Params_Get_Site_kpi_user_access_By_Where.OWNER_ID, i_Params_Get_Site_kpi_user_access_By_Where.OFFSET, i_Params_Get_Site_kpi_user_access_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            i_Params_Get_Site_kpi_user_access_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_Where", i_Params_Get_Site_kpi_user_access_By_Where_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_Where
        public List<Entity_kpi> Get_Entity_kpi_By_Where(Params_Get_Entity_kpi_By_Where i_Params_Get_Entity_kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_Where", i_Params_Get_Entity_kpi_By_Where_json, false);
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
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_Where(i_Params_Get_Entity_kpi_By_Where.DESCRIPTION, i_Params_Get_Entity_kpi_By_Where.OWNER_ID, i_Params_Get_Entity_kpi_By_Where.OFFSET, i_Params_Get_Entity_kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            i_Params_Get_Entity_kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_Where", i_Params_Get_Entity_kpi_By_Where_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_Where
        public List<Entity> Get_Entity_By_Where(Params_Get_Entity_By_Where i_Params_Get_Entity_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_Where", i_Params_Get_Entity_By_Where_json, false);
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
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_Where(i_Params_Get_Entity_By_Where.NAME, i_Params_Get_Entity_By_Where.GLA_UNIT, i_Params_Get_Entity_By_Where.UNIT, i_Params_Get_Entity_By_Where.IMAGE_URL, i_Params_Get_Entity_By_Where.SOLID_GLTF_URL, i_Params_Get_Entity_By_Where.OWNER_ID, i_Params_Get_Entity_By_Where.OFFSET, i_Params_Get_Entity_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            i_Params_Get_Entity_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_Where", i_Params_Get_Entity_By_Where_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_Where
        public List<District_kpi> Get_District_kpi_By_Where(Params_Get_District_kpi_By_Where i_Params_Get_District_kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_Where", i_Params_Get_District_kpi_By_Where_json, false);
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
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_Where(i_Params_Get_District_kpi_By_Where.DESCRIPTION, i_Params_Get_District_kpi_By_Where.OWNER_ID, i_Params_Get_District_kpi_By_Where.OFFSET, i_Params_Get_District_kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            i_Params_Get_District_kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_Where", i_Params_Get_District_kpi_By_Where_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_Where
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_Where(Params_Get_Entity_kpi_user_access_By_Where i_Params_Get_Entity_kpi_user_access_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_Where", i_Params_Get_Entity_kpi_user_access_By_Where_json, false);
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
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_Where(i_Params_Get_Entity_kpi_user_access_By_Where.DESCRIPTION, i_Params_Get_Entity_kpi_user_access_By_Where.OWNER_ID, i_Params_Get_Entity_kpi_user_access_By_Where.OFFSET, i_Params_Get_Entity_kpi_user_access_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            i_Params_Get_Entity_kpi_user_access_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_Where", i_Params_Get_Entity_kpi_user_access_By_Where_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Area_By_Where
        public List<Area> Get_Area_By_Where(Params_Get_Area_By_Where i_Params_Get_Area_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_Where", i_Params_Get_Area_By_Where_json, false);
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
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_Where(i_Params_Get_Area_By_Where.NAME, i_Params_Get_Area_By_Where.LOCATION, i_Params_Get_Area_By_Where.UNIT, i_Params_Get_Area_By_Where.IMAGE_URL, i_Params_Get_Area_By_Where.LOGO_URL, i_Params_Get_Area_By_Where.SOLID_GLTF_URL, i_Params_Get_Area_By_Where.AREA_COLOR, i_Params_Get_Area_By_Where.BORDER_COLOR, i_Params_Get_Area_By_Where.STUDY_ZONE_NAME, i_Params_Get_Area_By_Where.OWNER_ID, i_Params_Get_Area_By_Where.OFFSET, i_Params_Get_Area_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            i_Params_Get_Area_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_Where", i_Params_Get_Area_By_Where_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Site_kpi_By_Where
        public List<Site_kpi> Get_Site_kpi_By_Where(Params_Get_Site_kpi_By_Where i_Params_Get_Site_kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_Where", i_Params_Get_Site_kpi_By_Where_json, false);
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
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_Where(i_Params_Get_Site_kpi_By_Where.DESCRIPTION, i_Params_Get_Site_kpi_By_Where.OWNER_ID, i_Params_Get_Site_kpi_By_Where.OFFSET, i_Params_Get_Site_kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            i_Params_Get_Site_kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_Where", i_Params_Get_Site_kpi_By_Where_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Setup_category_By_Where
        public List<Setup_category> Get_Setup_category_By_Where(Params_Get_Setup_category_By_Where i_Params_Get_Setup_category_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_Where", i_Params_Get_Setup_category_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Setup_category_By_Where.OWNER_ID == null || i_Params_Get_Setup_category_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Setup_category_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Setup_category_By_Where.OFFSET == null)
            {
                i_Params_Get_Setup_category_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Setup_category_By_Where.FETCH_NEXT == null || i_Params_Get_Setup_category_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Setup_category_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_Where(i_Params_Get_Setup_category_By_Where.SETUP_CATEGORY_NAME, i_Params_Get_Setup_category_By_Where.DESCRIPTION, i_Params_Get_Setup_category_By_Where.OWNER_ID, i_Params_Get_Setup_category_By_Where.OFFSET, i_Params_Get_Setup_category_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            i_Params_Get_Setup_category_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_Where", i_Params_Get_Setup_category_By_Where_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_By_Where
        public List<Setup> Get_Setup_By_Where(Params_Get_Setup_By_Where i_Params_Get_Setup_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where", i_Params_Get_Setup_By_Where_json, false);
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
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where(i_Params_Get_Setup_By_Where.VALUE, i_Params_Get_Setup_By_Where.DESCRIPTION, i_Params_Get_Setup_By_Where.OWNER_ID, i_Params_Get_Setup_By_Where.OFFSET, i_Params_Get_Setup_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where", i_Params_Get_Setup_By_Where_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_Where
        public List<Area_kpi> Get_Area_kpi_By_Where(Params_Get_Area_kpi_By_Where i_Params_Get_Area_kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_Where", i_Params_Get_Area_kpi_By_Where_json, false);
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
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_Where(i_Params_Get_Area_kpi_By_Where.DESCRIPTION, i_Params_Get_Area_kpi_By_Where.OWNER_ID, i_Params_Get_Area_kpi_By_Where.OFFSET, i_Params_Get_Area_kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            i_Params_Get_Area_kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_Where", i_Params_Get_Area_kpi_By_Where_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Space_asset_By_Where
        public List<Space_asset> Get_Space_asset_By_Where(Params_Get_Space_asset_By_Where i_Params_Get_Space_asset_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_Where", i_Params_Get_Space_asset_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Space_asset_By_Where.OWNER_ID == null || i_Params_Get_Space_asset_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Space_asset_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Space_asset_By_Where.OFFSET == null)
            {
                i_Params_Get_Space_asset_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Space_asset_By_Where.FETCH_NEXT == null || i_Params_Get_Space_asset_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Space_asset_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_Where(i_Params_Get_Space_asset_By_Where.CUSTOM_NAME, i_Params_Get_Space_asset_By_Where.ASSET_ICON, i_Params_Get_Space_asset_By_Where.EXTERNAL_ID, i_Params_Get_Space_asset_By_Where.OWNER_ID, i_Params_Get_Space_asset_By_Where.OFFSET, i_Params_Get_Space_asset_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            i_Params_Get_Space_asset_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_Where", i_Params_Get_Space_asset_By_Where_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_District_By_Where
        public List<District> Get_District_By_Where(Params_Get_District_By_Where i_Params_Get_District_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<District> oList_District = null;
            var i_Params_Get_District_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_District_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_Where", i_Params_Get_District_By_Where_json, false);
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
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_Where(i_Params_Get_District_By_Where.NAME, i_Params_Get_District_By_Where.LOCATION, i_Params_Get_District_By_Where.UNIT, i_Params_Get_District_By_Where.IMAGE_URL, i_Params_Get_District_By_Where.LOGO_URL, i_Params_Get_District_By_Where.SOLID_GLTF_URL, i_Params_Get_District_By_Where.AREA_COLOR, i_Params_Get_District_By_Where.BORDER_COLOR, i_Params_Get_District_By_Where.STUDY_ZONE_NAME, i_Params_Get_District_By_Where.OWNER_ID, i_Params_Get_District_By_Where.OFFSET, i_Params_Get_District_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            i_Params_Get_District_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_Where", i_Params_Get_District_By_Where_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_Where
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where(Params_Get_Organization_data_source_kpi_By_Where i_Params_Get_Organization_data_source_kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_Where", i_Params_Get_Organization_data_source_kpi_By_Where_json, false);
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
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_Where(i_Params_Get_Organization_data_source_kpi_By_Where.DESCRIPTION, i_Params_Get_Organization_data_source_kpi_By_Where.OWNER_ID, i_Params_Get_Organization_data_source_kpi_By_Where.OFFSET, i_Params_Get_Organization_data_source_kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            i_Params_Get_Organization_data_source_kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_Where", i_Params_Get_Organization_data_source_kpi_By_Where_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_Where
        public List<Floor> Get_Floor_By_Where(Params_Get_Floor_By_Where i_Params_Get_Floor_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_Where", i_Params_Get_Floor_By_Where_json, false);
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
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_Where(i_Params_Get_Floor_By_Where.SHELL_GLTF_URL, i_Params_Get_Floor_By_Where.CLIPPED_GLTF_URL, i_Params_Get_Floor_By_Where.ADVANCED_GLTF_URL, i_Params_Get_Floor_By_Where.UNIT, i_Params_Get_Floor_By_Where.NAME, i_Params_Get_Floor_By_Where.OWNER_ID, i_Params_Get_Floor_By_Where.OFFSET, i_Params_Get_Floor_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            i_Params_Get_Floor_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_Where", i_Params_Get_Floor_By_Where_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_District_kpi_user_access_By_Where
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_Where(Params_Get_District_kpi_user_access_By_Where i_Params_Get_District_kpi_user_access_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_Where", i_Params_Get_District_kpi_user_access_By_Where_json, false);
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
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_Where(i_Params_Get_District_kpi_user_access_By_Where.DESCRIPTION, i_Params_Get_District_kpi_user_access_By_Where.OWNER_ID, i_Params_Get_District_kpi_user_access_By_Where.OFFSET, i_Params_Get_District_kpi_user_access_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            i_Params_Get_District_kpi_user_access_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_Where", i_Params_Get_District_kpi_user_access_By_Where_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_Where
        public List<User> Get_User_By_Where(Params_Get_User_By_Where i_Params_Get_User_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<User> oList_User = null;
            var i_Params_Get_User_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_User_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_Where", i_Params_Get_User_By_Where_json, false);
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
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_Where(i_Params_Get_User_By_Where.FIRST_NAME, i_Params_Get_User_By_Where.LAST_NAME, i_Params_Get_User_By_Where.USERNAME, i_Params_Get_User_By_Where.PASSWORD, i_Params_Get_User_By_Where.EMAIL, i_Params_Get_User_By_Where.PHONE_NUMBER, i_Params_Get_User_By_Where.IMAGE_URL, i_Params_Get_User_By_Where.USER_DISTRICTNEX_WALKTHROUGH, i_Params_Get_User_By_Where.USER_ADMIN_WALKTHROUGH, i_Params_Get_User_By_Where.OWNER_ID, i_Params_Get_User_By_Where.OFFSET, i_Params_Get_User_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            i_Params_Get_User_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_Where", i_Params_Get_User_By_Where_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_Space_By_Where
        public List<Space> Get_Space_By_Where(Params_Get_Space_By_Where i_Params_Get_Space_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_Where", i_Params_Get_Space_By_Where_json, false);
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
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_Where(i_Params_Get_Space_By_Where.NAME, i_Params_Get_Space_By_Where.UNIT, i_Params_Get_Space_By_Where.OWNER_ID, i_Params_Get_Space_By_Where.OFFSET, i_Params_Get_Space_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            i_Params_Get_Space_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_Where", i_Params_Get_Space_By_Where_json, false);
            }
            return oList_Space;
        }
        #endregion
        #region Get_Site_By_Where
        public List<Site> Get_Site_By_Where(Params_Get_Site_By_Where i_Params_Get_Site_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_Where", i_Params_Get_Site_By_Where_json, false);
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
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_Where(i_Params_Get_Site_By_Where.NAME, i_Params_Get_Site_By_Where.LOCATION, i_Params_Get_Site_By_Where.UNIT, i_Params_Get_Site_By_Where.IMAGE_URL, i_Params_Get_Site_By_Where.LOGO_URL, i_Params_Get_Site_By_Where.SOLID_GLTF_URL, i_Params_Get_Site_By_Where.AREA_COLOR, i_Params_Get_Site_By_Where.BORDER_COLOR, i_Params_Get_Site_By_Where.STUDY_ZONE_NAME, i_Params_Get_Site_By_Where.OWNER_ID, i_Params_Get_Site_By_Where.OFFSET, i_Params_Get_Site_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            i_Params_Get_Site_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_Where", i_Params_Get_Site_By_Where_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Get_Kpi_By_Where_In_List
        public List<Kpi> Get_Kpi_By_Where_In_List(Params_Get_Kpi_By_Where_In_List i_Params_Get_Kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_Where_In_List", i_Params_Get_Kpi_By_Where_In_List_json, false);
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
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_Where_In_List(i_Params_Get_Kpi_By_Where_In_List.NAME, i_Params_Get_Kpi_By_Where_In_List.UNIT, i_Params_Get_Kpi_By_Where_In_List.DIMENSION_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.SETUP_CATEGORY_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.KPI_TYPE_SETUP_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.MIN_DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.MAX_DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.OWNER_ID, i_Params_Get_Kpi_By_Where_In_List.OFFSET, i_Params_Get_Kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            i_Params_Get_Kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_Where_In_List", i_Params_Get_Kpi_By_Where_In_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Asset_By_Where_In_List
        public List<Asset> Get_Asset_By_Where_In_List(Params_Get_Asset_By_Where_In_List i_Params_Get_Asset_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_Where_In_List", i_Params_Get_Asset_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Asset_By_Where_In_List.OWNER_ID == null || i_Params_Get_Asset_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Asset_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Asset_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Asset_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Asset_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Asset_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Asset_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Asset_By_Where_In_List.ASSET_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Asset_By_Where_In_List.ASSET_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_Where_In_List(i_Params_Get_Asset_By_Where_In_List.NAME, i_Params_Get_Asset_By_Where_In_List.GLTF_URL, i_Params_Get_Asset_By_Where_In_List.ASSET_TYPE_SETUP_ID_LIST, i_Params_Get_Asset_By_Where_In_List.OWNER_ID, i_Params_Get_Asset_By_Where_In_List.OFFSET, i_Params_Get_Asset_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            i_Params_Get_Asset_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_Where_In_List", i_Params_Get_Asset_By_Where_In_List_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_Where_In_List
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_Where_In_List(Params_Get_Area_kpi_user_access_By_Where_In_List i_Params_Get_Area_kpi_user_access_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            var i_Params_Get_Area_kpi_user_access_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_user_access_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_user_access_By_Where_In_List", i_Params_Get_Area_kpi_user_access_By_Where_In_List_json, false);
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
            List<DALC.Area_kpi_user_access> oList_DBEntry = _AppContext.Get_Area_kpi_user_access_By_Where_In_List(i_Params_Get_Area_kpi_user_access_By_Where_In_List.DESCRIPTION, i_Params_Get_Area_kpi_user_access_By_Where_In_List.USER_ID_LIST, i_Params_Get_Area_kpi_user_access_By_Where_In_List.AREA_ID_LIST, i_Params_Get_Area_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_Area_kpi_user_access_By_Where_In_List.OWNER_ID, i_Params_Get_Area_kpi_user_access_By_Where_In_List.OFFSET, i_Params_Get_Area_kpi_user_access_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            i_Params_Get_Area_kpi_user_access_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_user_access_By_Where_In_List", i_Params_Get_Area_kpi_user_access_By_Where_In_List_json, false);
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_Where_In_List
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_Where_In_List(Params_Get_Site_kpi_user_access_By_Where_In_List i_Params_Get_Site_kpi_user_access_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            var i_Params_Get_Site_kpi_user_access_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_user_access_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_user_access_By_Where_In_List", i_Params_Get_Site_kpi_user_access_By_Where_In_List_json, false);
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
            List<DALC.Site_kpi_user_access> oList_DBEntry = _AppContext.Get_Site_kpi_user_access_By_Where_In_List(i_Params_Get_Site_kpi_user_access_By_Where_In_List.DESCRIPTION, i_Params_Get_Site_kpi_user_access_By_Where_In_List.USER_ID_LIST, i_Params_Get_Site_kpi_user_access_By_Where_In_List.SITE_ID_LIST, i_Params_Get_Site_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_Site_kpi_user_access_By_Where_In_List.OWNER_ID, i_Params_Get_Site_kpi_user_access_By_Where_In_List.OFFSET, i_Params_Get_Site_kpi_user_access_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            i_Params_Get_Site_kpi_user_access_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_user_access_By_Where_In_List", i_Params_Get_Site_kpi_user_access_By_Where_In_List_json, false);
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_Where_In_List
        public List<Entity_kpi> Get_Entity_kpi_By_Where_In_List(Params_Get_Entity_kpi_By_Where_In_List i_Params_Get_Entity_kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity_kpi> oList_Entity_kpi = null;
            var i_Params_Get_Entity_kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_By_Where_In_List", i_Params_Get_Entity_kpi_By_Where_In_List_json, false);
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
            List<DALC.Entity_kpi> oList_DBEntry = _AppContext.Get_Entity_kpi_By_Where_In_List(i_Params_Get_Entity_kpi_By_Where_In_List.DESCRIPTION, i_Params_Get_Entity_kpi_By_Where_In_List.ENTITY_ID_LIST, i_Params_Get_Entity_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_Entity_kpi_By_Where_In_List.OWNER_ID, i_Params_Get_Entity_kpi_By_Where_In_List.OFFSET, i_Params_Get_Entity_kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            i_Params_Get_Entity_kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_By_Where_In_List", i_Params_Get_Entity_kpi_By_Where_In_List_json, false);
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_Where_In_List
        public List<Entity> Get_Entity_By_Where_In_List(Params_Get_Entity_By_Where_In_List i_Params_Get_Entity_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity> oList_Entity = null;
            var i_Params_Get_Entity_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_By_Where_In_List", i_Params_Get_Entity_By_Where_In_List_json, false);
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
            List<DALC.Entity> oList_DBEntry = _AppContext.Get_Entity_By_Where_In_List(i_Params_Get_Entity_By_Where_In_List.NAME, i_Params_Get_Entity_By_Where_In_List.GLA_UNIT, i_Params_Get_Entity_By_Where_In_List.UNIT, i_Params_Get_Entity_By_Where_In_List.IMAGE_URL, i_Params_Get_Entity_By_Where_In_List.SOLID_GLTF_URL, i_Params_Get_Entity_By_Where_In_List.SITE_ID_LIST, i_Params_Get_Entity_By_Where_In_List.AREA_ID_LIST, i_Params_Get_Entity_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_Entity_By_Where_In_List.REGION_ID_LIST, i_Params_Get_Entity_By_Where_In_List.TOP_LEVEL_ID_LIST, i_Params_Get_Entity_By_Where_In_List.ENTITY_TYPE_SETUP_ID_LIST, i_Params_Get_Entity_By_Where_In_List.OWNER_ID, i_Params_Get_Entity_By_Where_In_List.OFFSET, i_Params_Get_Entity_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity = new List<Entity>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values(oDBEntry, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            i_Params_Get_Entity_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_By_Where_In_List", i_Params_Get_Entity_By_Where_In_List_json, false);
            }
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_Where_In_List
        public List<District_kpi> Get_District_kpi_By_Where_In_List(Params_Get_District_kpi_By_Where_In_List i_Params_Get_District_kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<District_kpi> oList_District_kpi = null;
            var i_Params_Get_District_kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_By_Where_In_List", i_Params_Get_District_kpi_By_Where_In_List_json, false);
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
            List<DALC.District_kpi> oList_DBEntry = _AppContext.Get_District_kpi_By_Where_In_List(i_Params_Get_District_kpi_By_Where_In_List.DESCRIPTION, i_Params_Get_District_kpi_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_District_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_District_kpi_By_Where_In_List.OWNER_ID, i_Params_Get_District_kpi_By_Where_In_List.OFFSET, i_Params_Get_District_kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            i_Params_Get_District_kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_By_Where_In_List", i_Params_Get_District_kpi_By_Where_In_List_json, false);
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_Where_In_List
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_Where_In_List(Params_Get_Entity_kpi_user_access_By_Where_In_List i_Params_Get_Entity_kpi_user_access_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            var i_Params_Get_Entity_kpi_user_access_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Entity_kpi_user_access_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Entity_kpi_user_access_By_Where_In_List", i_Params_Get_Entity_kpi_user_access_By_Where_In_List_json, false);
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
            List<DALC.Entity_kpi_user_access> oList_DBEntry = _AppContext.Get_Entity_kpi_user_access_By_Where_In_List(i_Params_Get_Entity_kpi_user_access_By_Where_In_List.DESCRIPTION, i_Params_Get_Entity_kpi_user_access_By_Where_In_List.USER_ID_LIST, i_Params_Get_Entity_kpi_user_access_By_Where_In_List.ENTITY_ID_LIST, i_Params_Get_Entity_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_Entity_kpi_user_access_By_Where_In_List.OWNER_ID, i_Params_Get_Entity_kpi_user_access_By_Where_In_List.OFFSET, i_Params_Get_Entity_kpi_user_access_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            i_Params_Get_Entity_kpi_user_access_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Entity_kpi_user_access_By_Where_In_List", i_Params_Get_Entity_kpi_user_access_By_Where_In_List_json, false);
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Area_By_Where_In_List
        public List<Area> Get_Area_By_Where_In_List(Params_Get_Area_By_Where_In_List i_Params_Get_Area_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area> oList_Area = null;
            var i_Params_Get_Area_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_By_Where_In_List", i_Params_Get_Area_By_Where_In_List_json, false);
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
            List<DALC.Area> oList_DBEntry = _AppContext.Get_Area_By_Where_In_List(i_Params_Get_Area_By_Where_In_List.NAME, i_Params_Get_Area_By_Where_In_List.LOCATION, i_Params_Get_Area_By_Where_In_List.UNIT, i_Params_Get_Area_By_Where_In_List.IMAGE_URL, i_Params_Get_Area_By_Where_In_List.LOGO_URL, i_Params_Get_Area_By_Where_In_List.SOLID_GLTF_URL, i_Params_Get_Area_By_Where_In_List.AREA_COLOR, i_Params_Get_Area_By_Where_In_List.BORDER_COLOR, i_Params_Get_Area_By_Where_In_List.STUDY_ZONE_NAME, i_Params_Get_Area_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_Area_By_Where_In_List.REGION_ID_LIST, i_Params_Get_Area_By_Where_In_List.TOP_LEVEL_ID_LIST, i_Params_Get_Area_By_Where_In_List.OWNER_ID, i_Params_Get_Area_By_Where_In_List.OFFSET, i_Params_Get_Area_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area = new List<Area>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values(oDBEntry, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            i_Params_Get_Area_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_By_Where_In_List", i_Params_Get_Area_By_Where_In_List_json, false);
            }
            return oList_Area;
        }
        #endregion
        #region Get_Site_kpi_By_Where_In_List
        public List<Site_kpi> Get_Site_kpi_By_Where_In_List(Params_Get_Site_kpi_By_Where_In_List i_Params_Get_Site_kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site_kpi> oList_Site_kpi = null;
            var i_Params_Get_Site_kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_kpi_By_Where_In_List", i_Params_Get_Site_kpi_By_Where_In_List_json, false);
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
            List<DALC.Site_kpi> oList_DBEntry = _AppContext.Get_Site_kpi_By_Where_In_List(i_Params_Get_Site_kpi_By_Where_In_List.DESCRIPTION, i_Params_Get_Site_kpi_By_Where_In_List.SITE_ID_LIST, i_Params_Get_Site_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_Site_kpi_By_Where_In_List.OWNER_ID, i_Params_Get_Site_kpi_By_Where_In_List.OFFSET, i_Params_Get_Site_kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            i_Params_Get_Site_kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_kpi_By_Where_In_List", i_Params_Get_Site_kpi_By_Where_In_List_json, false);
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Setup_By_Where_In_List
        public List<Setup> Get_Setup_By_Where_In_List(Params_Get_Setup_By_Where_In_List i_Params_Get_Setup_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where_In_List", i_Params_Get_Setup_By_Where_In_List_json, false);
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
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where_In_List(i_Params_Get_Setup_By_Where_In_List.VALUE, i_Params_Get_Setup_By_Where_In_List.DESCRIPTION, i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST, i_Params_Get_Setup_By_Where_In_List.OWNER_ID, i_Params_Get_Setup_By_Where_In_List.OFFSET, i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where_In_List", i_Params_Get_Setup_By_Where_In_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_Where_In_List
        public List<Area_kpi> Get_Area_kpi_By_Where_In_List(Params_Get_Area_kpi_By_Where_In_List i_Params_Get_Area_kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Area_kpi> oList_Area_kpi = null;
            var i_Params_Get_Area_kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Area_kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Area_kpi_By_Where_In_List", i_Params_Get_Area_kpi_By_Where_In_List_json, false);
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
            List<DALC.Area_kpi> oList_DBEntry = _AppContext.Get_Area_kpi_By_Where_In_List(i_Params_Get_Area_kpi_By_Where_In_List.DESCRIPTION, i_Params_Get_Area_kpi_By_Where_In_List.AREA_ID_LIST, i_Params_Get_Area_kpi_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_Area_kpi_By_Where_In_List.OWNER_ID, i_Params_Get_Area_kpi_By_Where_In_List.OFFSET, i_Params_Get_Area_kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            i_Params_Get_Area_kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Area_kpi_By_Where_In_List", i_Params_Get_Area_kpi_By_Where_In_List_json, false);
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Space_asset_By_Where_In_List
        public List<Space_asset> Get_Space_asset_By_Where_In_List(Params_Get_Space_asset_By_Where_In_List i_Params_Get_Space_asset_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Space_asset> oList_Space_asset = null;
            var i_Params_Get_Space_asset_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_asset_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_asset_By_Where_In_List", i_Params_Get_Space_asset_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Space_asset_By_Where_In_List.OWNER_ID == null || i_Params_Get_Space_asset_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Space_asset_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Space_asset_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Space_asset_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Space_asset_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Space_asset_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Space_asset_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Space_asset_By_Where_In_List.SPACE_ID_LIST == null)
            {
                i_Params_Get_Space_asset_By_Where_In_List.SPACE_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Space_asset_By_Where_In_List.ASSET_ID_LIST == null)
            {
                i_Params_Get_Space_asset_By_Where_In_List.ASSET_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Space_asset_By_Where_In_List.EXTERNAL_ID_LIST == null)
            {
                i_Params_Get_Space_asset_By_Where_In_List.EXTERNAL_ID_LIST = new List<string>();
            }
            List<DALC.Space_asset> oList_DBEntry = _AppContext.Get_Space_asset_By_Where_In_List(i_Params_Get_Space_asset_By_Where_In_List.CUSTOM_NAME, i_Params_Get_Space_asset_By_Where_In_List.ASSET_ICON, i_Params_Get_Space_asset_By_Where_In_List.SPACE_ID_LIST, i_Params_Get_Space_asset_By_Where_In_List.ASSET_ID_LIST, i_Params_Get_Space_asset_By_Where_In_List.EXTERNAL_ID_LIST, i_Params_Get_Space_asset_By_Where_In_List.OWNER_ID, i_Params_Get_Space_asset_By_Where_In_List.OFFSET, i_Params_Get_Space_asset_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values(oDBEntry, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            i_Params_Get_Space_asset_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_asset_By_Where_In_List", i_Params_Get_Space_asset_By_Where_In_List_json, false);
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_District_By_Where_In_List
        public List<District> Get_District_By_Where_In_List(Params_Get_District_By_Where_In_List i_Params_Get_District_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<District> oList_District = null;
            var i_Params_Get_District_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_District_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_By_Where_In_List", i_Params_Get_District_By_Where_In_List_json, false);
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
            List<DALC.District> oList_DBEntry = _AppContext.Get_District_By_Where_In_List(i_Params_Get_District_By_Where_In_List.NAME, i_Params_Get_District_By_Where_In_List.LOCATION, i_Params_Get_District_By_Where_In_List.UNIT, i_Params_Get_District_By_Where_In_List.IMAGE_URL, i_Params_Get_District_By_Where_In_List.LOGO_URL, i_Params_Get_District_By_Where_In_List.SOLID_GLTF_URL, i_Params_Get_District_By_Where_In_List.AREA_COLOR, i_Params_Get_District_By_Where_In_List.BORDER_COLOR, i_Params_Get_District_By_Where_In_List.STUDY_ZONE_NAME, i_Params_Get_District_By_Where_In_List.REGION_ID_LIST, i_Params_Get_District_By_Where_In_List.TOP_LEVEL_ID_LIST, i_Params_Get_District_By_Where_In_List.OWNER_ID, i_Params_Get_District_By_Where_In_List.OFFSET, i_Params_Get_District_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_District = new List<District>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            i_Params_Get_District_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_By_Where_In_List", i_Params_Get_District_By_Where_In_List_json, false);
            }
            return oList_District;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_Where_In_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_In_List(Params_Get_Organization_data_source_kpi_By_Where_In_List i_Params_Get_Organization_data_source_kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            var i_Params_Get_Organization_data_source_kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Organization_data_source_kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Organization_data_source_kpi_By_Where_In_List", i_Params_Get_Organization_data_source_kpi_By_Where_In_List_json, false);
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
            List<DALC.Organization_data_source_kpi> oList_DBEntry = _AppContext.Get_Organization_data_source_kpi_By_Where_In_List(i_Params_Get_Organization_data_source_kpi_By_Where_In_List.DESCRIPTION, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.DATA_SOURCE_ID_LIST, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.KPI_ID_LIST, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OWNER_ID, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.OFFSET, i_Params_Get_Organization_data_source_kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values(oDBEntry, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            i_Params_Get_Organization_data_source_kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Organization_data_source_kpi_By_Where_In_List", i_Params_Get_Organization_data_source_kpi_By_Where_In_List_json, false);
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_Where_In_List
        public List<Floor> Get_Floor_By_Where_In_List(Params_Get_Floor_By_Where_In_List i_Params_Get_Floor_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Floor> oList_Floor = null;
            var i_Params_Get_Floor_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Floor_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Floor_By_Where_In_List", i_Params_Get_Floor_By_Where_In_List_json, false);
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
            List<DALC.Floor> oList_DBEntry = _AppContext.Get_Floor_By_Where_In_List(i_Params_Get_Floor_By_Where_In_List.SHELL_GLTF_URL, i_Params_Get_Floor_By_Where_In_List.CLIPPED_GLTF_URL, i_Params_Get_Floor_By_Where_In_List.ADVANCED_GLTF_URL, i_Params_Get_Floor_By_Where_In_List.UNIT, i_Params_Get_Floor_By_Where_In_List.NAME, i_Params_Get_Floor_By_Where_In_List.ENTITY_ID_LIST, i_Params_Get_Floor_By_Where_In_List.OWNER_ID, i_Params_Get_Floor_By_Where_In_List.OFFSET, i_Params_Get_Floor_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Floor = new List<Floor>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values(oDBEntry, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            i_Params_Get_Floor_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Floor_By_Where_In_List", i_Params_Get_Floor_By_Where_In_List_json, false);
            }
            return oList_Floor;
        }
        #endregion
        #region Get_District_kpi_user_access_By_Where_In_List
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_Where_In_List(Params_Get_District_kpi_user_access_By_Where_In_List i_Params_Get_District_kpi_user_access_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            var i_Params_Get_District_kpi_user_access_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_District_kpi_user_access_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_District_kpi_user_access_By_Where_In_List", i_Params_Get_District_kpi_user_access_By_Where_In_List_json, false);
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
            List<DALC.District_kpi_user_access> oList_DBEntry = _AppContext.Get_District_kpi_user_access_By_Where_In_List(i_Params_Get_District_kpi_user_access_By_Where_In_List.DESCRIPTION, i_Params_Get_District_kpi_user_access_By_Where_In_List.USER_ID_LIST, i_Params_Get_District_kpi_user_access_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_District_kpi_user_access_By_Where_In_List.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, i_Params_Get_District_kpi_user_access_By_Where_In_List.OWNER_ID, i_Params_Get_District_kpi_user_access_By_Where_In_List.OFFSET, i_Params_Get_District_kpi_user_access_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values(oDBEntry, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            i_Params_Get_District_kpi_user_access_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_District_kpi_user_access_By_Where_In_List", i_Params_Get_District_kpi_user_access_By_Where_In_List_json, false);
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_Where_In_List
        public List<User> Get_User_By_Where_In_List(Params_Get_User_By_Where_In_List i_Params_Get_User_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<User> oList_User = null;
            var i_Params_Get_User_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_User_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_User_By_Where_In_List", i_Params_Get_User_By_Where_In_List_json, false);
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
            List<DALC.User> oList_DBEntry = _AppContext.Get_User_By_Where_In_List(i_Params_Get_User_By_Where_In_List.FIRST_NAME, i_Params_Get_User_By_Where_In_List.LAST_NAME, i_Params_Get_User_By_Where_In_List.USERNAME, i_Params_Get_User_By_Where_In_List.PASSWORD, i_Params_Get_User_By_Where_In_List.EMAIL, i_Params_Get_User_By_Where_In_List.PHONE_NUMBER, i_Params_Get_User_By_Where_In_List.IMAGE_URL, i_Params_Get_User_By_Where_In_List.USER_DISTRICTNEX_WALKTHROUGH, i_Params_Get_User_By_Where_In_List.USER_ADMIN_WALKTHROUGH, i_Params_Get_User_By_Where_In_List.ORGANIZATION_ID_LIST, i_Params_Get_User_By_Where_In_List.USER_TYPE_SETUP_ID_LIST, i_Params_Get_User_By_Where_In_List.OWNER_ID, i_Params_Get_User_By_Where_In_List.OFFSET, i_Params_Get_User_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_User = new List<User>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values(oDBEntry, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            i_Params_Get_User_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_User_By_Where_In_List", i_Params_Get_User_By_Where_In_List_json, false);
            }
            return oList_User;
        }
        #endregion
        #region Get_Space_By_Where_In_List
        public List<Space> Get_Space_By_Where_In_List(Params_Get_Space_By_Where_In_List i_Params_Get_Space_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Space> oList_Space = null;
            var i_Params_Get_Space_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Space_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Space_By_Where_In_List", i_Params_Get_Space_By_Where_In_List_json, false);
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
            List<DALC.Space> oList_DBEntry = _AppContext.Get_Space_By_Where_In_List(i_Params_Get_Space_By_Where_In_List.NAME, i_Params_Get_Space_By_Where_In_List.UNIT, i_Params_Get_Space_By_Where_In_List.FLOOR_ID_LIST, i_Params_Get_Space_By_Where_In_List.OWNER_ID, i_Params_Get_Space_By_Where_In_List.OFFSET, i_Params_Get_Space_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Space = new List<Space>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values(oDBEntry, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            i_Params_Get_Space_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Space_By_Where_In_List", i_Params_Get_Space_By_Where_In_List_json, false);
            }
            return oList_Space;
        }
        #endregion
        #region Get_Site_By_Where_In_List
        public List<Site> Get_Site_By_Where_In_List(Params_Get_Site_By_Where_In_List i_Params_Get_Site_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Site> oList_Site = null;
            var i_Params_Get_Site_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Site_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Site_By_Where_In_List", i_Params_Get_Site_By_Where_In_List_json, false);
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
            List<DALC.Site> oList_DBEntry = _AppContext.Get_Site_By_Where_In_List(i_Params_Get_Site_By_Where_In_List.NAME, i_Params_Get_Site_By_Where_In_List.LOCATION, i_Params_Get_Site_By_Where_In_List.UNIT, i_Params_Get_Site_By_Where_In_List.IMAGE_URL, i_Params_Get_Site_By_Where_In_List.LOGO_URL, i_Params_Get_Site_By_Where_In_List.SOLID_GLTF_URL, i_Params_Get_Site_By_Where_In_List.AREA_COLOR, i_Params_Get_Site_By_Where_In_List.BORDER_COLOR, i_Params_Get_Site_By_Where_In_List.STUDY_ZONE_NAME, i_Params_Get_Site_By_Where_In_List.AREA_ID_LIST, i_Params_Get_Site_By_Where_In_List.DISTRICT_ID_LIST, i_Params_Get_Site_By_Where_In_List.REGION_ID_LIST, i_Params_Get_Site_By_Where_In_List.TOP_LEVEL_ID_LIST, i_Params_Get_Site_By_Where_In_List.OWNER_ID, i_Params_Get_Site_By_Where_In_List.OFFSET, i_Params_Get_Site_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Site = new List<Site>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values(oDBEntry, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            i_Params_Get_Site_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Site_By_Where_In_List", i_Params_Get_Site_By_Where_In_List_json, false);
            }
            return oList_Site;
        }
        #endregion
        #region Delete_Kpi
        public void Delete_Kpi(Params_Delete_Kpi i_Params_Delete_Kpi)
        {
            var i_Params_Delete_Kpi_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi", i_Params_Delete_Kpi_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_KPI_ID oParams_Get_Kpi_By_KPI_ID = new Params_Get_Kpi_By_KPI_ID
                {
                    KPI_ID = i_Params_Delete_Kpi.KPI_ID
                };
                _Kpi = Get_Kpi_By_KPI_ID(oParams_Get_Kpi_By_KPI_ID);
                if (_Kpi != null)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi(i_Params_Delete_Kpi.KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi", i_Params_Delete_Kpi_json, false);
            }
        }
        #endregion
        #region Delete_Asset
        public void Delete_Asset(Params_Delete_Asset i_Params_Delete_Asset)
        {
            var i_Params_Delete_Asset_json = JsonConvert.SerializeObject(i_Params_Delete_Asset);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Asset", i_Params_Delete_Asset_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Asset_By_ASSET_ID oParams_Get_Asset_By_ASSET_ID = new Params_Get_Asset_By_ASSET_ID
                {
                    ASSET_ID = i_Params_Delete_Asset.ASSET_ID
                };
                _Asset = Get_Asset_By_ASSET_ID(oParams_Get_Asset_By_ASSET_ID);
                if (_Asset != null)
                {
                    if (_Stop_Delete_Asset_Execution)
                    {
                        _Stop_Delete_Asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Asset(i_Params_Delete_Asset.ASSET_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Asset", i_Params_Delete_Asset_json, false);
            }
        }
        #endregion
        #region Delete_Ext_study_zone
        public void Delete_Ext_study_zone(Params_Delete_Ext_study_zone i_Params_Delete_Ext_study_zone)
        {
            var i_Params_Delete_Ext_study_zone_json = JsonConvert.SerializeObject(i_Params_Delete_Ext_study_zone);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Ext_study_zone", i_Params_Delete_Ext_study_zone_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID oParams_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID = new Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID
                {
                    EXT_STUDY_ZONE_ID = i_Params_Delete_Ext_study_zone.EXT_STUDY_ZONE_ID
                };
                _Ext_study_zone = Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID(oParams_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID);
                if (_Ext_study_zone != null)
                {
                    if (_Stop_Delete_Ext_study_zone_Execution)
                    {
                        _Stop_Delete_Ext_study_zone_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Ext_study_zone(i_Params_Delete_Ext_study_zone.EXT_STUDY_ZONE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Ext_study_zone", i_Params_Delete_Ext_study_zone_json, false);
            }
        }
        #endregion
        #region Delete_Area_kpi_user_access
        public void Delete_Area_kpi_user_access(Params_Delete_Area_kpi_user_access i_Params_Delete_Area_kpi_user_access)
        {
            var i_Params_Delete_Area_kpi_user_access_json = JsonConvert.SerializeObject(i_Params_Delete_Area_kpi_user_access);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_kpi_user_access", i_Params_Delete_Area_kpi_user_access_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID oParams_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID = new Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID
                {
                    AREA_KPI_USER_ACCESS_ID = i_Params_Delete_Area_kpi_user_access.AREA_KPI_USER_ACCESS_ID
                };
                _Area_kpi_user_access = Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID(oParams_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID);
                if (_Area_kpi_user_access != null)
                {
                    if (_Stop_Delete_Area_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Area_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_kpi_user_access(i_Params_Delete_Area_kpi_user_access.AREA_KPI_USER_ACCESS_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_kpi_user_access", i_Params_Delete_Area_kpi_user_access_json, false);
            }
        }
        #endregion
        #region Delete_Site_kpi_user_access
        public void Delete_Site_kpi_user_access(Params_Delete_Site_kpi_user_access i_Params_Delete_Site_kpi_user_access)
        {
            var i_Params_Delete_Site_kpi_user_access_json = JsonConvert.SerializeObject(i_Params_Delete_Site_kpi_user_access);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_kpi_user_access", i_Params_Delete_Site_kpi_user_access_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID oParams_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID = new Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID
                {
                    SITE_KPI_USER_ACCESS_ID = i_Params_Delete_Site_kpi_user_access.SITE_KPI_USER_ACCESS_ID
                };
                _Site_kpi_user_access = Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID(oParams_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID);
                if (_Site_kpi_user_access != null)
                {
                    if (_Stop_Delete_Site_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Site_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_kpi_user_access(i_Params_Delete_Site_kpi_user_access.SITE_KPI_USER_ACCESS_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_kpi_user_access", i_Params_Delete_Site_kpi_user_access_json, false);
            }
        }
        #endregion
        #region Delete_Entity_kpi
        public void Delete_Entity_kpi(Params_Delete_Entity_kpi i_Params_Delete_Entity_kpi)
        {
            var i_Params_Delete_Entity_kpi_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_kpi);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_kpi", i_Params_Delete_Entity_kpi_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_kpi_By_ENTITY_KPI_ID oParams_Get_Entity_kpi_By_ENTITY_KPI_ID = new Params_Get_Entity_kpi_By_ENTITY_KPI_ID
                {
                    ENTITY_KPI_ID = i_Params_Delete_Entity_kpi.ENTITY_KPI_ID
                };
                _Entity_kpi = Get_Entity_kpi_By_ENTITY_KPI_ID(oParams_Get_Entity_kpi_By_ENTITY_KPI_ID);
                if (_Entity_kpi != null)
                {
                    if (_Stop_Delete_Entity_kpi_Execution)
                    {
                        _Stop_Delete_Entity_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_kpi(i_Params_Delete_Entity_kpi.ENTITY_KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_kpi", i_Params_Delete_Entity_kpi_json, false);
            }
        }
        #endregion
        #region Delete_Entity
        public void Delete_Entity(Params_Delete_Entity i_Params_Delete_Entity)
        {
            var i_Params_Delete_Entity_json = JsonConvert.SerializeObject(i_Params_Delete_Entity);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity", i_Params_Delete_Entity_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_ENTITY_ID oParams_Get_Entity_By_ENTITY_ID = new Params_Get_Entity_By_ENTITY_ID
                {
                    ENTITY_ID = i_Params_Delete_Entity.ENTITY_ID
                };
                _Entity = Get_Entity_By_ENTITY_ID(oParams_Get_Entity_By_ENTITY_ID);
                if (_Entity != null)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity(i_Params_Delete_Entity.ENTITY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity", i_Params_Delete_Entity_json, false);
            }
        }
        #endregion
        #region Delete_District_kpi
        public void Delete_District_kpi(Params_Delete_District_kpi i_Params_Delete_District_kpi)
        {
            var i_Params_Delete_District_kpi_json = JsonConvert.SerializeObject(i_Params_Delete_District_kpi);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_kpi", i_Params_Delete_District_kpi_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_kpi_By_DISTRICT_KPI_ID oParams_Get_District_kpi_By_DISTRICT_KPI_ID = new Params_Get_District_kpi_By_DISTRICT_KPI_ID
                {
                    DISTRICT_KPI_ID = i_Params_Delete_District_kpi.DISTRICT_KPI_ID
                };
                _District_kpi = Get_District_kpi_By_DISTRICT_KPI_ID(oParams_Get_District_kpi_By_DISTRICT_KPI_ID);
                if (_District_kpi != null)
                {
                    if (_Stop_Delete_District_kpi_Execution)
                    {
                        _Stop_Delete_District_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_kpi(i_Params_Delete_District_kpi.DISTRICT_KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_kpi", i_Params_Delete_District_kpi_json, false);
            }
        }
        #endregion
        #region Delete_Entity_kpi_user_access
        public void Delete_Entity_kpi_user_access(Params_Delete_Entity_kpi_user_access i_Params_Delete_Entity_kpi_user_access)
        {
            var i_Params_Delete_Entity_kpi_user_access_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_kpi_user_access);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_kpi_user_access", i_Params_Delete_Entity_kpi_user_access_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID oParams_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID = new Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID
                {
                    ENTITY_KPI_USER_ACCESS_ID = i_Params_Delete_Entity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID
                };
                _Entity_kpi_user_access = Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID(oParams_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID);
                if (_Entity_kpi_user_access != null)
                {
                    if (_Stop_Delete_Entity_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Entity_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_kpi_user_access(i_Params_Delete_Entity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_kpi_user_access", i_Params_Delete_Entity_kpi_user_access_json, false);
            }
        }
        #endregion
        #region Delete_Area
        public void Delete_Area(Params_Delete_Area i_Params_Delete_Area)
        {
            var i_Params_Delete_Area_json = JsonConvert.SerializeObject(i_Params_Delete_Area);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area", i_Params_Delete_Area_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_By_AREA_ID oParams_Get_Area_By_AREA_ID = new Params_Get_Area_By_AREA_ID
                {
                    AREA_ID = i_Params_Delete_Area.AREA_ID
                };
                _Area = Get_Area_By_AREA_ID(oParams_Get_Area_By_AREA_ID);
                if (_Area != null)
                {
                    if (_Stop_Delete_Area_Execution)
                    {
                        _Stop_Delete_Area_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area(i_Params_Delete_Area.AREA_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area", i_Params_Delete_Area_json, false);
            }
        }
        #endregion
        #region Delete_Site_kpi
        public void Delete_Site_kpi(Params_Delete_Site_kpi i_Params_Delete_Site_kpi)
        {
            var i_Params_Delete_Site_kpi_json = JsonConvert.SerializeObject(i_Params_Delete_Site_kpi);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_kpi", i_Params_Delete_Site_kpi_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_kpi_By_SITE_KPI_ID oParams_Get_Site_kpi_By_SITE_KPI_ID = new Params_Get_Site_kpi_By_SITE_KPI_ID
                {
                    SITE_KPI_ID = i_Params_Delete_Site_kpi.SITE_KPI_ID
                };
                _Site_kpi = Get_Site_kpi_By_SITE_KPI_ID(oParams_Get_Site_kpi_By_SITE_KPI_ID);
                if (_Site_kpi != null)
                {
                    if (_Stop_Delete_Site_kpi_Execution)
                    {
                        _Stop_Delete_Site_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_kpi(i_Params_Delete_Site_kpi.SITE_KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_kpi", i_Params_Delete_Site_kpi_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category
        public void Delete_Setup_category(Params_Delete_Setup_category i_Params_Delete_Setup_category)
        {
            var i_Params_Delete_Setup_category_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category", i_Params_Delete_Setup_category_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_SETUP_CATEGORY_ID oParams_Get_Setup_category_By_SETUP_CATEGORY_ID = new Params_Get_Setup_category_By_SETUP_CATEGORY_ID
                {
                    SETUP_CATEGORY_ID = i_Params_Delete_Setup_category.SETUP_CATEGORY_ID
                };
                _Setup_category = Get_Setup_category_By_SETUP_CATEGORY_ID(oParams_Get_Setup_category_By_SETUP_CATEGORY_ID);
                if (_Setup_category != null)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category(i_Params_Delete_Setup_category.SETUP_CATEGORY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category", i_Params_Delete_Setup_category_json, false);
            }
        }
        #endregion
        #region Delete_Setup
        public void Delete_Setup(Params_Delete_Setup i_Params_Delete_Setup)
        {
            var i_Params_Delete_Setup_json = JsonConvert.SerializeObject(i_Params_Delete_Setup);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup", i_Params_Delete_Setup_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_SETUP_ID oParams_Get_Setup_By_SETUP_ID = new Params_Get_Setup_By_SETUP_ID
                {
                    SETUP_ID = i_Params_Delete_Setup.SETUP_ID
                };
                _Setup = Get_Setup_By_SETUP_ID(oParams_Get_Setup_By_SETUP_ID);
                if (_Setup != null)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup(i_Params_Delete_Setup.SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup", i_Params_Delete_Setup_json, false);
            }
        }
        #endregion
        #region Delete_Area_kpi
        public void Delete_Area_kpi(Params_Delete_Area_kpi i_Params_Delete_Area_kpi)
        {
            var i_Params_Delete_Area_kpi_json = JsonConvert.SerializeObject(i_Params_Delete_Area_kpi);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_kpi", i_Params_Delete_Area_kpi_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_kpi_By_AREA_KPI_ID oParams_Get_Area_kpi_By_AREA_KPI_ID = new Params_Get_Area_kpi_By_AREA_KPI_ID
                {
                    AREA_KPI_ID = i_Params_Delete_Area_kpi.AREA_KPI_ID
                };
                _Area_kpi = Get_Area_kpi_By_AREA_KPI_ID(oParams_Get_Area_kpi_By_AREA_KPI_ID);
                if (_Area_kpi != null)
                {
                    if (_Stop_Delete_Area_kpi_Execution)
                    {
                        _Stop_Delete_Area_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_kpi(i_Params_Delete_Area_kpi.AREA_KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_kpi", i_Params_Delete_Area_kpi_json, false);
            }
        }
        #endregion
        #region Delete_Space_asset
        public void Delete_Space_asset(Params_Delete_Space_asset i_Params_Delete_Space_asset)
        {
            var i_Params_Delete_Space_asset_json = JsonConvert.SerializeObject(i_Params_Delete_Space_asset);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_asset", i_Params_Delete_Space_asset_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_asset_By_SPACE_ASSET_ID oParams_Get_Space_asset_By_SPACE_ASSET_ID = new Params_Get_Space_asset_By_SPACE_ASSET_ID
                {
                    SPACE_ASSET_ID = i_Params_Delete_Space_asset.SPACE_ASSET_ID
                };
                _Space_asset = Get_Space_asset_By_SPACE_ASSET_ID(oParams_Get_Space_asset_By_SPACE_ASSET_ID);
                if (_Space_asset != null)
                {
                    if (_Stop_Delete_Space_asset_Execution)
                    {
                        _Stop_Delete_Space_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_asset(i_Params_Delete_Space_asset.SPACE_ASSET_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Space_asset", i_Params_Delete_Space_asset_json, false);
            }
        }
        #endregion
        #region Delete_District
        public void Delete_District(Params_Delete_District i_Params_Delete_District)
        {
            var i_Params_Delete_District_json = JsonConvert.SerializeObject(i_Params_Delete_District);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District", i_Params_Delete_District_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_By_DISTRICT_ID oParams_Get_District_By_DISTRICT_ID = new Params_Get_District_By_DISTRICT_ID
                {
                    DISTRICT_ID = i_Params_Delete_District.DISTRICT_ID
                };
                _District = Get_District_By_DISTRICT_ID(oParams_Get_District_By_DISTRICT_ID);
                if (_District != null)
                {
                    if (_Stop_Delete_District_Execution)
                    {
                        _Stop_Delete_District_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District(i_Params_Delete_District.DISTRICT_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District", i_Params_Delete_District_json, false);
            }
        }
        #endregion
        #region Delete_Organization_data_source_kpi
        public void Delete_Organization_data_source_kpi(Params_Delete_Organization_data_source_kpi i_Params_Delete_Organization_data_source_kpi)
        {
            var i_Params_Delete_Organization_data_source_kpi_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_data_source_kpi);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_data_source_kpi", i_Params_Delete_Organization_data_source_kpi_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID = new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Delete_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID
                };
                _Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);
                if (_Organization_data_source_kpi != null)
                {
                    if (_Stop_Delete_Organization_data_source_kpi_Execution)
                    {
                        _Stop_Delete_Organization_data_source_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_data_source_kpi(i_Params_Delete_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_data_source_kpi", i_Params_Delete_Organization_data_source_kpi_json, false);
            }
        }
        #endregion
        #region Delete_Floor
        public void Delete_Floor(Params_Delete_Floor i_Params_Delete_Floor)
        {
            var i_Params_Delete_Floor_json = JsonConvert.SerializeObject(i_Params_Delete_Floor);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Floor", i_Params_Delete_Floor_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Floor_By_FLOOR_ID oParams_Get_Floor_By_FLOOR_ID = new Params_Get_Floor_By_FLOOR_ID
                {
                    FLOOR_ID = i_Params_Delete_Floor.FLOOR_ID
                };
                _Floor = Get_Floor_By_FLOOR_ID(oParams_Get_Floor_By_FLOOR_ID);
                if (_Floor != null)
                {
                    if (_Stop_Delete_Floor_Execution)
                    {
                        _Stop_Delete_Floor_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Floor(i_Params_Delete_Floor.FLOOR_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Floor", i_Params_Delete_Floor_json, false);
            }
        }
        #endregion
        #region Delete_District_kpi_user_access
        public void Delete_District_kpi_user_access(Params_Delete_District_kpi_user_access i_Params_Delete_District_kpi_user_access)
        {
            var i_Params_Delete_District_kpi_user_access_json = JsonConvert.SerializeObject(i_Params_Delete_District_kpi_user_access);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_kpi_user_access", i_Params_Delete_District_kpi_user_access_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID oParams_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID = new Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID
                {
                    DISTRICT_KPI_USER_ACCESS_ID = i_Params_Delete_District_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID
                };
                _District_kpi_user_access = Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID(oParams_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID);
                if (_District_kpi_user_access != null)
                {
                    if (_Stop_Delete_District_kpi_user_access_Execution)
                    {
                        _Stop_Delete_District_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_kpi_user_access(i_Params_Delete_District_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_kpi_user_access", i_Params_Delete_District_kpi_user_access_json, false);
            }
        }
        #endregion
        #region Delete_User
        public void Delete_User(Params_Delete_User i_Params_Delete_User)
        {
            var i_Params_Delete_User_json = JsonConvert.SerializeObject(i_Params_Delete_User);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User", i_Params_Delete_User_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_USER_ID oParams_Get_User_By_USER_ID = new Params_Get_User_By_USER_ID
                {
                    USER_ID = i_Params_Delete_User.USER_ID
                };
                _User = Get_User_By_USER_ID(oParams_Get_User_By_USER_ID);
                if (_User != null)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User(i_Params_Delete_User.USER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_User", i_Params_Delete_User_json, false);
            }
        }
        #endregion
        #region Delete_Space
        public void Delete_Space(Params_Delete_Space i_Params_Delete_Space)
        {
            var i_Params_Delete_Space_json = JsonConvert.SerializeObject(i_Params_Delete_Space);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space", i_Params_Delete_Space_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_By_SPACE_ID oParams_Get_Space_By_SPACE_ID = new Params_Get_Space_By_SPACE_ID
                {
                    SPACE_ID = i_Params_Delete_Space.SPACE_ID
                };
                _Space = Get_Space_By_SPACE_ID(oParams_Get_Space_By_SPACE_ID);
                if (_Space != null)
                {
                    if (_Stop_Delete_Space_Execution)
                    {
                        _Stop_Delete_Space_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space(i_Params_Delete_Space.SPACE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Space", i_Params_Delete_Space_json, false);
            }
        }
        #endregion
        #region Delete_Site
        public void Delete_Site(Params_Delete_Site i_Params_Delete_Site)
        {
            var i_Params_Delete_Site_json = JsonConvert.SerializeObject(i_Params_Delete_Site);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site", i_Params_Delete_Site_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_By_SITE_ID oParams_Get_Site_By_SITE_ID = new Params_Get_Site_By_SITE_ID
                {
                    SITE_ID = i_Params_Delete_Site.SITE_ID
                };
                _Site = Get_Site_By_SITE_ID(oParams_Get_Site_By_SITE_ID);
                if (_Site != null)
                {
                    if (_Stop_Delete_Site_Execution)
                    {
                        _Stop_Delete_Site_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site(i_Params_Delete_Site.SITE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site", i_Params_Delete_Site_json, false);
            }
        }
        #endregion
        #region Delete_Kpi_By_OWNER_ID
        public void Delete_Kpi_By_OWNER_ID(Params_Delete_Kpi_By_OWNER_ID i_Params_Delete_Kpi_By_OWNER_ID)
        {
            var i_Params_Delete_Kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi_By_OWNER_ID", i_Params_Delete_Kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_OWNER_ID oParams_Get_Kpi_By_OWNER_ID = new Params_Get_Kpi_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Kpi_By_OWNER_ID.OWNER_ID
                };
                _List_Kpi = Get_Kpi_By_OWNER_ID(oParams_Get_Kpi_By_OWNER_ID);
                if (_List_Kpi != null && _List_Kpi.Count > 0)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi_By_OWNER_ID(i_Params_Delete_Kpi_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi_By_OWNER_ID", i_Params_Delete_Kpi_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Kpi_By_DIMENSION_ID
        public void Delete_Kpi_By_DIMENSION_ID(Params_Delete_Kpi_By_DIMENSION_ID i_Params_Delete_Kpi_By_DIMENSION_ID)
        {
            var i_Params_Delete_Kpi_By_DIMENSION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi_By_DIMENSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi_By_DIMENSION_ID", i_Params_Delete_Kpi_By_DIMENSION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_DIMENSION_ID oParams_Get_Kpi_By_DIMENSION_ID = new Params_Get_Kpi_By_DIMENSION_ID
                {
                    DIMENSION_ID = i_Params_Delete_Kpi_By_DIMENSION_ID.DIMENSION_ID
                };
                _List_Kpi = Get_Kpi_By_DIMENSION_ID(oParams_Get_Kpi_By_DIMENSION_ID);
                if (_List_Kpi != null && _List_Kpi.Count > 0)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi_By_DIMENSION_ID(i_Params_Delete_Kpi_By_DIMENSION_ID.DIMENSION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi_By_DIMENSION_ID", i_Params_Delete_Kpi_By_DIMENSION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Kpi_By_SETUP_CATEGORY_ID
        public void Delete_Kpi_By_SETUP_CATEGORY_ID(Params_Delete_Kpi_By_SETUP_CATEGORY_ID i_Params_Delete_Kpi_By_SETUP_CATEGORY_ID)
        {
            var i_Params_Delete_Kpi_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi_By_SETUP_CATEGORY_ID", i_Params_Delete_Kpi_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_SETUP_CATEGORY_ID oParams_Get_Kpi_By_SETUP_CATEGORY_ID = new Params_Get_Kpi_By_SETUP_CATEGORY_ID
                {
                    SETUP_CATEGORY_ID = i_Params_Delete_Kpi_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID
                };
                _List_Kpi = Get_Kpi_By_SETUP_CATEGORY_ID(oParams_Get_Kpi_By_SETUP_CATEGORY_ID);
                if (_List_Kpi != null && _List_Kpi.Count > 0)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi_By_SETUP_CATEGORY_ID(i_Params_Delete_Kpi_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi_By_SETUP_CATEGORY_ID", i_Params_Delete_Kpi_By_SETUP_CATEGORY_ID_json, false);
            }
        }
        #endregion
        #region Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
        public void Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID i_Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID)
        {
            var i_Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID", i_Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID oParams_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID = new Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
                {
                    MIN_DATA_LEVEL_SETUP_ID = i_Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID.MIN_DATA_LEVEL_SETUP_ID
                };
                _List_Kpi = Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(oParams_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID);
                if (_List_Kpi != null && _List_Kpi.Count > 0)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(i_Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID.MIN_DATA_LEVEL_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID", i_Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
        public void Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID i_Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID)
        {
            var i_Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID", i_Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID oParams_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID = new Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
                {
                    MAX_DATA_LEVEL_SETUP_ID = i_Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID.MAX_DATA_LEVEL_SETUP_ID
                };
                _List_Kpi = Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(oParams_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID);
                if (_List_Kpi != null && _List_Kpi.Count > 0)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(i_Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID.MAX_DATA_LEVEL_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID", i_Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Kpi_By_OWNER_ID_IS_DELETED
        public void Delete_Kpi_By_OWNER_ID_IS_DELETED(Params_Delete_Kpi_By_OWNER_ID_IS_DELETED i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_OWNER_ID_IS_DELETED oParams_Get_Kpi_By_OWNER_ID_IS_DELETED = new Params_Get_Kpi_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Kpi = Get_Kpi_By_OWNER_ID_IS_DELETED(oParams_Get_Kpi_By_OWNER_ID_IS_DELETED);
                if (_List_Kpi != null && _List_Kpi.Count > 0)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi_By_OWNER_ID_IS_DELETED(i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Kpi_By_KPI_TYPE_SETUP_ID
        public void Delete_Kpi_By_KPI_TYPE_SETUP_ID(Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID i_Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi_By_KPI_TYPE_SETUP_ID", i_Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_KPI_TYPE_SETUP_ID oParams_Get_Kpi_By_KPI_TYPE_SETUP_ID = new Params_Get_Kpi_By_KPI_TYPE_SETUP_ID
                {
                    KPI_TYPE_SETUP_ID = i_Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID.KPI_TYPE_SETUP_ID
                };
                _List_Kpi = Get_Kpi_By_KPI_TYPE_SETUP_ID(oParams_Get_Kpi_By_KPI_TYPE_SETUP_ID);
                if (_List_Kpi != null && _List_Kpi.Count > 0)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi_By_KPI_TYPE_SETUP_ID(i_Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID.KPI_TYPE_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi_By_KPI_TYPE_SETUP_ID", i_Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Asset_By_OWNER_ID
        public void Delete_Asset_By_OWNER_ID(Params_Delete_Asset_By_OWNER_ID i_Params_Delete_Asset_By_OWNER_ID)
        {
            var i_Params_Delete_Asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Asset_By_OWNER_ID", i_Params_Delete_Asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Asset_By_OWNER_ID oParams_Get_Asset_By_OWNER_ID = new Params_Get_Asset_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Asset_By_OWNER_ID.OWNER_ID
                };
                _List_Asset = Get_Asset_By_OWNER_ID(oParams_Get_Asset_By_OWNER_ID);
                if (_List_Asset != null && _List_Asset.Count > 0)
                {
                    if (_Stop_Delete_Asset_Execution)
                    {
                        _Stop_Delete_Asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Asset_By_OWNER_ID(i_Params_Delete_Asset_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Asset_By_OWNER_ID", i_Params_Delete_Asset_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Asset_By_ASSET_TYPE_SETUP_ID
        public void Delete_Asset_By_ASSET_TYPE_SETUP_ID(Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Asset_By_ASSET_TYPE_SETUP_ID", i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Asset_By_ASSET_TYPE_SETUP_ID oParams_Get_Asset_By_ASSET_TYPE_SETUP_ID = new Params_Get_Asset_By_ASSET_TYPE_SETUP_ID
                {
                    ASSET_TYPE_SETUP_ID = i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID.ASSET_TYPE_SETUP_ID
                };
                _List_Asset = Get_Asset_By_ASSET_TYPE_SETUP_ID(oParams_Get_Asset_By_ASSET_TYPE_SETUP_ID);
                if (_List_Asset != null && _List_Asset.Count > 0)
                {
                    if (_Stop_Delete_Asset_Execution)
                    {
                        _Stop_Delete_Asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Asset_By_ASSET_TYPE_SETUP_ID(i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID.ASSET_TYPE_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Asset_By_ASSET_TYPE_SETUP_ID", i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Asset_By_OWNER_ID_IS_DELETED
        public void Delete_Asset_By_OWNER_ID_IS_DELETED(Params_Delete_Asset_By_OWNER_ID_IS_DELETED i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Asset_By_OWNER_ID_IS_DELETED", i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Asset_By_OWNER_ID_IS_DELETED oParams_Get_Asset_By_OWNER_ID_IS_DELETED = new Params_Get_Asset_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Asset = Get_Asset_By_OWNER_ID_IS_DELETED(oParams_Get_Asset_By_OWNER_ID_IS_DELETED);
                if (_List_Asset != null && _List_Asset.Count > 0)
                {
                    if (_Stop_Delete_Asset_Execution)
                    {
                        _Stop_Delete_Asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Asset_By_OWNER_ID_IS_DELETED(i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Asset_By_OWNER_ID_IS_DELETED", i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Ext_study_zone_By_OWNER_ID
        public void Delete_Ext_study_zone_By_OWNER_ID(Params_Delete_Ext_study_zone_By_OWNER_ID i_Params_Delete_Ext_study_zone_By_OWNER_ID)
        {
            var i_Params_Delete_Ext_study_zone_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Ext_study_zone_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Ext_study_zone_By_OWNER_ID", i_Params_Delete_Ext_study_zone_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Ext_study_zone_By_OWNER_ID oParams_Get_Ext_study_zone_By_OWNER_ID = new Params_Get_Ext_study_zone_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Ext_study_zone_By_OWNER_ID.OWNER_ID
                };
                _List_Ext_study_zone = Get_Ext_study_zone_By_OWNER_ID(oParams_Get_Ext_study_zone_By_OWNER_ID);
                if (_List_Ext_study_zone != null && _List_Ext_study_zone.Count > 0)
                {
                    if (_Stop_Delete_Ext_study_zone_Execution)
                    {
                        _Stop_Delete_Ext_study_zone_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Ext_study_zone_By_OWNER_ID(i_Params_Delete_Ext_study_zone_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Ext_study_zone_By_OWNER_ID", i_Params_Delete_Ext_study_zone_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED
        public void Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED(Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED", i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED oParams_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED = new Params_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Ext_study_zone = Get_Ext_study_zone_By_OWNER_ID_IS_DELETED(oParams_Get_Ext_study_zone_By_OWNER_ID_IS_DELETED);
                if (_List_Ext_study_zone != null && _List_Ext_study_zone.Count > 0)
                {
                    if (_Stop_Delete_Ext_study_zone_Execution)
                    {
                        _Stop_Delete_Ext_study_zone_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED(i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED", i_Params_Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Area_kpi_user_access_By_OWNER_ID
        public void Delete_Area_kpi_user_access_By_OWNER_ID(Params_Delete_Area_kpi_user_access_By_OWNER_ID i_Params_Delete_Area_kpi_user_access_By_OWNER_ID)
        {
            var i_Params_Delete_Area_kpi_user_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_kpi_user_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_kpi_user_access_By_OWNER_ID", i_Params_Delete_Area_kpi_user_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_kpi_user_access_By_OWNER_ID oParams_Get_Area_kpi_user_access_By_OWNER_ID = new Params_Get_Area_kpi_user_access_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Area_kpi_user_access_By_OWNER_ID.OWNER_ID
                };
                _List_Area_kpi_user_access = Get_Area_kpi_user_access_By_OWNER_ID(oParams_Get_Area_kpi_user_access_By_OWNER_ID);
                if (_List_Area_kpi_user_access != null && _List_Area_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Area_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Area_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_kpi_user_access_By_OWNER_ID(i_Params_Delete_Area_kpi_user_access_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_kpi_user_access_By_OWNER_ID", i_Params_Delete_Area_kpi_user_access_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_kpi_user_access_By_USER_ID
        public void Delete_Area_kpi_user_access_By_USER_ID(Params_Delete_Area_kpi_user_access_By_USER_ID i_Params_Delete_Area_kpi_user_access_By_USER_ID)
        {
            var i_Params_Delete_Area_kpi_user_access_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_kpi_user_access_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_kpi_user_access_By_USER_ID", i_Params_Delete_Area_kpi_user_access_By_USER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_kpi_user_access_By_USER_ID oParams_Get_Area_kpi_user_access_By_USER_ID = new Params_Get_Area_kpi_user_access_By_USER_ID
                {
                    USER_ID = i_Params_Delete_Area_kpi_user_access_By_USER_ID.USER_ID
                };
                _List_Area_kpi_user_access = Get_Area_kpi_user_access_By_USER_ID(oParams_Get_Area_kpi_user_access_By_USER_ID);
                if (_List_Area_kpi_user_access != null && _List_Area_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Area_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Area_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_kpi_user_access_By_USER_ID(i_Params_Delete_Area_kpi_user_access_By_USER_ID.USER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_kpi_user_access_By_USER_ID", i_Params_Delete_Area_kpi_user_access_By_USER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_kpi_user_access_By_AREA_ID
        public void Delete_Area_kpi_user_access_By_AREA_ID(Params_Delete_Area_kpi_user_access_By_AREA_ID i_Params_Delete_Area_kpi_user_access_By_AREA_ID)
        {
            var i_Params_Delete_Area_kpi_user_access_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_kpi_user_access_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_kpi_user_access_By_AREA_ID", i_Params_Delete_Area_kpi_user_access_By_AREA_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_kpi_user_access_By_AREA_ID oParams_Get_Area_kpi_user_access_By_AREA_ID = new Params_Get_Area_kpi_user_access_By_AREA_ID
                {
                    AREA_ID = i_Params_Delete_Area_kpi_user_access_By_AREA_ID.AREA_ID
                };
                _List_Area_kpi_user_access = Get_Area_kpi_user_access_By_AREA_ID(oParams_Get_Area_kpi_user_access_By_AREA_ID);
                if (_List_Area_kpi_user_access != null && _List_Area_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Area_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Area_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_kpi_user_access_By_AREA_ID(i_Params_Delete_Area_kpi_user_access_By_AREA_ID.AREA_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_kpi_user_access_By_AREA_ID", i_Params_Delete_Area_kpi_user_access_By_AREA_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var i_Params_Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID oParams_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID = new Params_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID
                };
                _List_Area_kpi_user_access = Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(oParams_Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);
                if (_List_Area_kpi_user_access != null && _List_Area_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Area_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Area_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED
        public void Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED(Params_Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED i_Params_Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED oParams_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED = new Params_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Area_kpi_user_access = Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED(oParams_Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED);
                if (_List_Area_kpi_user_access != null && _List_Area_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Area_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Area_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED(i_Params_Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Site_kpi_user_access_By_OWNER_ID
        public void Delete_Site_kpi_user_access_By_OWNER_ID(Params_Delete_Site_kpi_user_access_By_OWNER_ID i_Params_Delete_Site_kpi_user_access_By_OWNER_ID)
        {
            var i_Params_Delete_Site_kpi_user_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_kpi_user_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_kpi_user_access_By_OWNER_ID", i_Params_Delete_Site_kpi_user_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_kpi_user_access_By_OWNER_ID oParams_Get_Site_kpi_user_access_By_OWNER_ID = new Params_Get_Site_kpi_user_access_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Site_kpi_user_access_By_OWNER_ID.OWNER_ID
                };
                _List_Site_kpi_user_access = Get_Site_kpi_user_access_By_OWNER_ID(oParams_Get_Site_kpi_user_access_By_OWNER_ID);
                if (_List_Site_kpi_user_access != null && _List_Site_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Site_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Site_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_kpi_user_access_By_OWNER_ID(i_Params_Delete_Site_kpi_user_access_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_kpi_user_access_By_OWNER_ID", i_Params_Delete_Site_kpi_user_access_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_kpi_user_access_By_USER_ID
        public void Delete_Site_kpi_user_access_By_USER_ID(Params_Delete_Site_kpi_user_access_By_USER_ID i_Params_Delete_Site_kpi_user_access_By_USER_ID)
        {
            var i_Params_Delete_Site_kpi_user_access_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_kpi_user_access_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_kpi_user_access_By_USER_ID", i_Params_Delete_Site_kpi_user_access_By_USER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_kpi_user_access_By_USER_ID oParams_Get_Site_kpi_user_access_By_USER_ID = new Params_Get_Site_kpi_user_access_By_USER_ID
                {
                    USER_ID = i_Params_Delete_Site_kpi_user_access_By_USER_ID.USER_ID
                };
                _List_Site_kpi_user_access = Get_Site_kpi_user_access_By_USER_ID(oParams_Get_Site_kpi_user_access_By_USER_ID);
                if (_List_Site_kpi_user_access != null && _List_Site_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Site_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Site_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_kpi_user_access_By_USER_ID(i_Params_Delete_Site_kpi_user_access_By_USER_ID.USER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_kpi_user_access_By_USER_ID", i_Params_Delete_Site_kpi_user_access_By_USER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_kpi_user_access_By_SITE_ID
        public void Delete_Site_kpi_user_access_By_SITE_ID(Params_Delete_Site_kpi_user_access_By_SITE_ID i_Params_Delete_Site_kpi_user_access_By_SITE_ID)
        {
            var i_Params_Delete_Site_kpi_user_access_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_kpi_user_access_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_kpi_user_access_By_SITE_ID", i_Params_Delete_Site_kpi_user_access_By_SITE_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_kpi_user_access_By_SITE_ID oParams_Get_Site_kpi_user_access_By_SITE_ID = new Params_Get_Site_kpi_user_access_By_SITE_ID
                {
                    SITE_ID = i_Params_Delete_Site_kpi_user_access_By_SITE_ID.SITE_ID
                };
                _List_Site_kpi_user_access = Get_Site_kpi_user_access_By_SITE_ID(oParams_Get_Site_kpi_user_access_By_SITE_ID);
                if (_List_Site_kpi_user_access != null && _List_Site_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Site_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Site_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_kpi_user_access_By_SITE_ID(i_Params_Delete_Site_kpi_user_access_By_SITE_ID.SITE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_kpi_user_access_By_SITE_ID", i_Params_Delete_Site_kpi_user_access_By_SITE_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var i_Params_Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID oParams_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID = new Params_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID
                };
                _List_Site_kpi_user_access = Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(oParams_Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);
                if (_List_Site_kpi_user_access != null && _List_Site_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Site_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Site_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED
        public void Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED(Params_Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED i_Params_Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED oParams_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED = new Params_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Site_kpi_user_access = Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED(oParams_Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED);
                if (_List_Site_kpi_user_access != null && _List_Site_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Site_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Site_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED(i_Params_Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Entity_kpi_By_OWNER_ID_IS_DELETED
        public void Delete_Entity_kpi_By_OWNER_ID_IS_DELETED(Params_Delete_Entity_kpi_By_OWNER_ID_IS_DELETED i_Params_Delete_Entity_kpi_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Entity_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_Entity_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED oParams_Get_Entity_kpi_By_OWNER_ID_IS_DELETED = new Params_Get_Entity_kpi_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Entity_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Entity_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Entity_kpi = Get_Entity_kpi_By_OWNER_ID_IS_DELETED(oParams_Get_Entity_kpi_By_OWNER_ID_IS_DELETED);
                if (_List_Entity_kpi != null && _List_Entity_kpi.Count > 0)
                {
                    if (_Stop_Delete_Entity_kpi_Execution)
                    {
                        _Stop_Delete_Entity_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_kpi_By_OWNER_ID_IS_DELETED(i_Params_Delete_Entity_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Entity_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_Entity_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Entity_kpi_By_OWNER_ID
        public void Delete_Entity_kpi_By_OWNER_ID(Params_Delete_Entity_kpi_By_OWNER_ID i_Params_Delete_Entity_kpi_By_OWNER_ID)
        {
            var i_Params_Delete_Entity_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_kpi_By_OWNER_ID", i_Params_Delete_Entity_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_kpi_By_OWNER_ID oParams_Get_Entity_kpi_By_OWNER_ID = new Params_Get_Entity_kpi_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Entity_kpi_By_OWNER_ID.OWNER_ID
                };
                _List_Entity_kpi = Get_Entity_kpi_By_OWNER_ID(oParams_Get_Entity_kpi_By_OWNER_ID);
                if (_List_Entity_kpi != null && _List_Entity_kpi.Count > 0)
                {
                    if (_Stop_Delete_Entity_kpi_Execution)
                    {
                        _Stop_Delete_Entity_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_kpi_By_OWNER_ID(i_Params_Delete_Entity_kpi_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_kpi_By_OWNER_ID", i_Params_Delete_Entity_kpi_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var i_Params_Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID oParams_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID = new Params_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID
                };
                _List_Entity_kpi = Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(oParams_Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);
                if (_List_Entity_kpi != null && _List_Entity_kpi.Count > 0)
                {
                    if (_Stop_Delete_Entity_kpi_Execution)
                    {
                        _Stop_Delete_Entity_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_kpi_By_ENTITY_ID
        public void Delete_Entity_kpi_By_ENTITY_ID(Params_Delete_Entity_kpi_By_ENTITY_ID i_Params_Delete_Entity_kpi_By_ENTITY_ID)
        {
            var i_Params_Delete_Entity_kpi_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_kpi_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_kpi_By_ENTITY_ID", i_Params_Delete_Entity_kpi_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_kpi_By_ENTITY_ID oParams_Get_Entity_kpi_By_ENTITY_ID = new Params_Get_Entity_kpi_By_ENTITY_ID
                {
                    ENTITY_ID = i_Params_Delete_Entity_kpi_By_ENTITY_ID.ENTITY_ID
                };
                _List_Entity_kpi = Get_Entity_kpi_By_ENTITY_ID(oParams_Get_Entity_kpi_By_ENTITY_ID);
                if (_List_Entity_kpi != null && _List_Entity_kpi.Count > 0)
                {
                    if (_Stop_Delete_Entity_kpi_Execution)
                    {
                        _Stop_Delete_Entity_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_kpi_By_ENTITY_ID(i_Params_Delete_Entity_kpi_By_ENTITY_ID.ENTITY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_kpi_By_ENTITY_ID", i_Params_Delete_Entity_kpi_By_ENTITY_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_OWNER_ID_IS_DELETED
        public void Delete_Entity_By_OWNER_ID_IS_DELETED(Params_Delete_Entity_By_OWNER_ID_IS_DELETED i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_OWNER_ID_IS_DELETED", i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_OWNER_ID_IS_DELETED oParams_Get_Entity_By_OWNER_ID_IS_DELETED = new Params_Get_Entity_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Entity = Get_Entity_By_OWNER_ID_IS_DELETED(oParams_Get_Entity_By_OWNER_ID_IS_DELETED);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_OWNER_ID_IS_DELETED(i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_By_OWNER_ID_IS_DELETED", i_Params_Delete_Entity_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_OWNER_ID
        public void Delete_Entity_By_OWNER_ID(Params_Delete_Entity_By_OWNER_ID i_Params_Delete_Entity_By_OWNER_ID)
        {
            var i_Params_Delete_Entity_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_OWNER_ID", i_Params_Delete_Entity_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_OWNER_ID oParams_Get_Entity_By_OWNER_ID = new Params_Get_Entity_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Entity_By_OWNER_ID.OWNER_ID
                };
                _List_Entity = Get_Entity_By_OWNER_ID(oParams_Get_Entity_By_OWNER_ID);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_OWNER_ID(i_Params_Delete_Entity_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_By_OWNER_ID", i_Params_Delete_Entity_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_SITE_ID
        public void Delete_Entity_By_SITE_ID(Params_Delete_Entity_By_SITE_ID i_Params_Delete_Entity_By_SITE_ID)
        {
            var i_Params_Delete_Entity_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_SITE_ID", i_Params_Delete_Entity_By_SITE_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_SITE_ID oParams_Get_Entity_By_SITE_ID = new Params_Get_Entity_By_SITE_ID
                {
                    SITE_ID = i_Params_Delete_Entity_By_SITE_ID.SITE_ID
                };
                _List_Entity = Get_Entity_By_SITE_ID(oParams_Get_Entity_By_SITE_ID);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_SITE_ID(i_Params_Delete_Entity_By_SITE_ID.SITE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_By_SITE_ID", i_Params_Delete_Entity_By_SITE_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_AREA_ID
        public void Delete_Entity_By_AREA_ID(Params_Delete_Entity_By_AREA_ID i_Params_Delete_Entity_By_AREA_ID)
        {
            var i_Params_Delete_Entity_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_AREA_ID", i_Params_Delete_Entity_By_AREA_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_AREA_ID oParams_Get_Entity_By_AREA_ID = new Params_Get_Entity_By_AREA_ID
                {
                    AREA_ID = i_Params_Delete_Entity_By_AREA_ID.AREA_ID
                };
                _List_Entity = Get_Entity_By_AREA_ID(oParams_Get_Entity_By_AREA_ID);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_AREA_ID(i_Params_Delete_Entity_By_AREA_ID.AREA_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_By_AREA_ID", i_Params_Delete_Entity_By_AREA_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_DISTRICT_ID
        public void Delete_Entity_By_DISTRICT_ID(Params_Delete_Entity_By_DISTRICT_ID i_Params_Delete_Entity_By_DISTRICT_ID)
        {
            var i_Params_Delete_Entity_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_DISTRICT_ID", i_Params_Delete_Entity_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_DISTRICT_ID oParams_Get_Entity_By_DISTRICT_ID = new Params_Get_Entity_By_DISTRICT_ID
                {
                    DISTRICT_ID = i_Params_Delete_Entity_By_DISTRICT_ID.DISTRICT_ID
                };
                _List_Entity = Get_Entity_By_DISTRICT_ID(oParams_Get_Entity_By_DISTRICT_ID);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_DISTRICT_ID(i_Params_Delete_Entity_By_DISTRICT_ID.DISTRICT_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_By_DISTRICT_ID", i_Params_Delete_Entity_By_DISTRICT_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_REGION_ID
        public void Delete_Entity_By_REGION_ID(Params_Delete_Entity_By_REGION_ID i_Params_Delete_Entity_By_REGION_ID)
        {
            var i_Params_Delete_Entity_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_REGION_ID", i_Params_Delete_Entity_By_REGION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_REGION_ID oParams_Get_Entity_By_REGION_ID = new Params_Get_Entity_By_REGION_ID
                {
                    REGION_ID = i_Params_Delete_Entity_By_REGION_ID.REGION_ID
                };
                _List_Entity = Get_Entity_By_REGION_ID(oParams_Get_Entity_By_REGION_ID);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_REGION_ID(i_Params_Delete_Entity_By_REGION_ID.REGION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_By_REGION_ID", i_Params_Delete_Entity_By_REGION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_TOP_LEVEL_ID
        public void Delete_Entity_By_TOP_LEVEL_ID(Params_Delete_Entity_By_TOP_LEVEL_ID i_Params_Delete_Entity_By_TOP_LEVEL_ID)
        {
            var i_Params_Delete_Entity_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_TOP_LEVEL_ID", i_Params_Delete_Entity_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_TOP_LEVEL_ID oParams_Get_Entity_By_TOP_LEVEL_ID = new Params_Get_Entity_By_TOP_LEVEL_ID
                {
                    TOP_LEVEL_ID = i_Params_Delete_Entity_By_TOP_LEVEL_ID.TOP_LEVEL_ID
                };
                _List_Entity = Get_Entity_By_TOP_LEVEL_ID(oParams_Get_Entity_By_TOP_LEVEL_ID);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_TOP_LEVEL_ID(i_Params_Delete_Entity_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_By_TOP_LEVEL_ID", i_Params_Delete_Entity_By_TOP_LEVEL_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_By_ENTITY_TYPE_SETUP_ID
        public void Delete_Entity_By_ENTITY_TYPE_SETUP_ID(Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID i_Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_By_ENTITY_TYPE_SETUP_ID", i_Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID oParams_Get_Entity_By_ENTITY_TYPE_SETUP_ID = new Params_Get_Entity_By_ENTITY_TYPE_SETUP_ID
                {
                    ENTITY_TYPE_SETUP_ID = i_Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID.ENTITY_TYPE_SETUP_ID
                };
                _List_Entity = Get_Entity_By_ENTITY_TYPE_SETUP_ID(oParams_Get_Entity_By_ENTITY_TYPE_SETUP_ID);
                if (_List_Entity != null && _List_Entity.Count > 0)
                {
                    if (_Stop_Delete_Entity_Execution)
                    {
                        _Stop_Delete_Entity_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_By_ENTITY_TYPE_SETUP_ID(i_Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID.ENTITY_TYPE_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_By_ENTITY_TYPE_SETUP_ID", i_Params_Delete_Entity_By_ENTITY_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_District_kpi_By_OWNER_ID
        public void Delete_District_kpi_By_OWNER_ID(Params_Delete_District_kpi_By_OWNER_ID i_Params_Delete_District_kpi_By_OWNER_ID)
        {
            var i_Params_Delete_District_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_District_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_kpi_By_OWNER_ID", i_Params_Delete_District_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_kpi_By_OWNER_ID oParams_Get_District_kpi_By_OWNER_ID = new Params_Get_District_kpi_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_District_kpi_By_OWNER_ID.OWNER_ID
                };
                _List_District_kpi = Get_District_kpi_By_OWNER_ID(oParams_Get_District_kpi_By_OWNER_ID);
                if (_List_District_kpi != null && _List_District_kpi.Count > 0)
                {
                    if (_Stop_Delete_District_kpi_Execution)
                    {
                        _Stop_Delete_District_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_kpi_By_OWNER_ID(i_Params_Delete_District_kpi_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_kpi_By_OWNER_ID", i_Params_Delete_District_kpi_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var i_Params_Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID oParams_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID = new Params_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID
                };
                _List_District_kpi = Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(oParams_Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);
                if (_List_District_kpi != null && _List_District_kpi.Count > 0)
                {
                    if (_Stop_Delete_District_kpi_Execution)
                    {
                        _Stop_Delete_District_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
        }
        #endregion
        #region Delete_District_kpi_By_OWNER_ID_IS_DELETED
        public void Delete_District_kpi_By_OWNER_ID_IS_DELETED(Params_Delete_District_kpi_By_OWNER_ID_IS_DELETED i_Params_Delete_District_kpi_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_District_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_District_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_District_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_kpi_By_OWNER_ID_IS_DELETED oParams_Get_District_kpi_By_OWNER_ID_IS_DELETED = new Params_Get_District_kpi_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_District_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_District_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_District_kpi = Get_District_kpi_By_OWNER_ID_IS_DELETED(oParams_Get_District_kpi_By_OWNER_ID_IS_DELETED);
                if (_List_District_kpi != null && _List_District_kpi.Count > 0)
                {
                    if (_Stop_Delete_District_kpi_Execution)
                    {
                        _Stop_Delete_District_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_kpi_By_OWNER_ID_IS_DELETED(i_Params_Delete_District_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_District_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_District_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_District_kpi_By_DISTRICT_ID
        public void Delete_District_kpi_By_DISTRICT_ID(Params_Delete_District_kpi_By_DISTRICT_ID i_Params_Delete_District_kpi_By_DISTRICT_ID)
        {
            var i_Params_Delete_District_kpi_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Delete_District_kpi_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_kpi_By_DISTRICT_ID", i_Params_Delete_District_kpi_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_kpi_By_DISTRICT_ID oParams_Get_District_kpi_By_DISTRICT_ID = new Params_Get_District_kpi_By_DISTRICT_ID
                {
                    DISTRICT_ID = i_Params_Delete_District_kpi_By_DISTRICT_ID.DISTRICT_ID
                };
                _List_District_kpi = Get_District_kpi_By_DISTRICT_ID(oParams_Get_District_kpi_By_DISTRICT_ID);
                if (_List_District_kpi != null && _List_District_kpi.Count > 0)
                {
                    if (_Stop_Delete_District_kpi_Execution)
                    {
                        _Stop_Delete_District_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_kpi_By_DISTRICT_ID(i_Params_Delete_District_kpi_By_DISTRICT_ID.DISTRICT_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_kpi_By_DISTRICT_ID", i_Params_Delete_District_kpi_By_DISTRICT_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_kpi_user_access_By_OWNER_ID
        public void Delete_Entity_kpi_user_access_By_OWNER_ID(Params_Delete_Entity_kpi_user_access_By_OWNER_ID i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID)
        {
            var i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_kpi_user_access_By_OWNER_ID", i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_kpi_user_access_By_OWNER_ID oParams_Get_Entity_kpi_user_access_By_OWNER_ID = new Params_Get_Entity_kpi_user_access_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID.OWNER_ID
                };
                _List_Entity_kpi_user_access = Get_Entity_kpi_user_access_By_OWNER_ID(oParams_Get_Entity_kpi_user_access_By_OWNER_ID);
                if (_List_Entity_kpi_user_access != null && _List_Entity_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Entity_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Entity_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_kpi_user_access_By_OWNER_ID(i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_kpi_user_access_By_OWNER_ID", i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_kpi_user_access_By_USER_ID
        public void Delete_Entity_kpi_user_access_By_USER_ID(Params_Delete_Entity_kpi_user_access_By_USER_ID i_Params_Delete_Entity_kpi_user_access_By_USER_ID)
        {
            var i_Params_Delete_Entity_kpi_user_access_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_kpi_user_access_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_kpi_user_access_By_USER_ID", i_Params_Delete_Entity_kpi_user_access_By_USER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_kpi_user_access_By_USER_ID oParams_Get_Entity_kpi_user_access_By_USER_ID = new Params_Get_Entity_kpi_user_access_By_USER_ID
                {
                    USER_ID = i_Params_Delete_Entity_kpi_user_access_By_USER_ID.USER_ID
                };
                _List_Entity_kpi_user_access = Get_Entity_kpi_user_access_By_USER_ID(oParams_Get_Entity_kpi_user_access_By_USER_ID);
                if (_List_Entity_kpi_user_access != null && _List_Entity_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Entity_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Entity_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_kpi_user_access_By_USER_ID(i_Params_Delete_Entity_kpi_user_access_By_USER_ID.USER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_kpi_user_access_By_USER_ID", i_Params_Delete_Entity_kpi_user_access_By_USER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_kpi_user_access_By_ENTITY_ID
        public void Delete_Entity_kpi_user_access_By_ENTITY_ID(Params_Delete_Entity_kpi_user_access_By_ENTITY_ID i_Params_Delete_Entity_kpi_user_access_By_ENTITY_ID)
        {
            var i_Params_Delete_Entity_kpi_user_access_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_kpi_user_access_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_kpi_user_access_By_ENTITY_ID", i_Params_Delete_Entity_kpi_user_access_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_kpi_user_access_By_ENTITY_ID oParams_Get_Entity_kpi_user_access_By_ENTITY_ID = new Params_Get_Entity_kpi_user_access_By_ENTITY_ID
                {
                    ENTITY_ID = i_Params_Delete_Entity_kpi_user_access_By_ENTITY_ID.ENTITY_ID
                };
                _List_Entity_kpi_user_access = Get_Entity_kpi_user_access_By_ENTITY_ID(oParams_Get_Entity_kpi_user_access_By_ENTITY_ID);
                if (_List_Entity_kpi_user_access != null && _List_Entity_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Entity_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Entity_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_kpi_user_access_By_ENTITY_ID(i_Params_Delete_Entity_kpi_user_access_By_ENTITY_ID.ENTITY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_kpi_user_access_By_ENTITY_ID", i_Params_Delete_Entity_kpi_user_access_By_ENTITY_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var i_Params_Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID oParams_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID = new Params_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID
                };
                _List_Entity_kpi_user_access = Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(oParams_Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);
                if (_List_Entity_kpi_user_access != null && _List_Entity_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Entity_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Entity_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
        }
        #endregion
        #region Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED
        public void Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED(Params_Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED oParams_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED = new Params_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Entity_kpi_user_access = Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED(oParams_Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED);
                if (_List_Entity_kpi_user_access != null && _List_Entity_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_Entity_kpi_user_access_Execution)
                    {
                        _Stop_Delete_Entity_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED(i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Area_By_OWNER_ID_IS_DELETED
        public void Delete_Area_By_OWNER_ID_IS_DELETED(Params_Delete_Area_By_OWNER_ID_IS_DELETED i_Params_Delete_Area_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Area_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Area_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_By_OWNER_ID_IS_DELETED", i_Params_Delete_Area_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_By_OWNER_ID_IS_DELETED oParams_Get_Area_By_OWNER_ID_IS_DELETED = new Params_Get_Area_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Area_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Area_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Area = Get_Area_By_OWNER_ID_IS_DELETED(oParams_Get_Area_By_OWNER_ID_IS_DELETED);
                if (_List_Area != null && _List_Area.Count > 0)
                {
                    if (_Stop_Delete_Area_Execution)
                    {
                        _Stop_Delete_Area_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_By_OWNER_ID_IS_DELETED(i_Params_Delete_Area_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Area_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_By_OWNER_ID_IS_DELETED", i_Params_Delete_Area_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Area_By_OWNER_ID
        public void Delete_Area_By_OWNER_ID(Params_Delete_Area_By_OWNER_ID i_Params_Delete_Area_By_OWNER_ID)
        {
            var i_Params_Delete_Area_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_By_OWNER_ID", i_Params_Delete_Area_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_By_OWNER_ID oParams_Get_Area_By_OWNER_ID = new Params_Get_Area_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Area_By_OWNER_ID.OWNER_ID
                };
                _List_Area = Get_Area_By_OWNER_ID(oParams_Get_Area_By_OWNER_ID);
                if (_List_Area != null && _List_Area.Count > 0)
                {
                    if (_Stop_Delete_Area_Execution)
                    {
                        _Stop_Delete_Area_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_By_OWNER_ID(i_Params_Delete_Area_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_By_OWNER_ID", i_Params_Delete_Area_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_By_DISTRICT_ID
        public void Delete_Area_By_DISTRICT_ID(Params_Delete_Area_By_DISTRICT_ID i_Params_Delete_Area_By_DISTRICT_ID)
        {
            var i_Params_Delete_Area_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_By_DISTRICT_ID", i_Params_Delete_Area_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_By_DISTRICT_ID oParams_Get_Area_By_DISTRICT_ID = new Params_Get_Area_By_DISTRICT_ID
                {
                    DISTRICT_ID = i_Params_Delete_Area_By_DISTRICT_ID.DISTRICT_ID
                };
                _List_Area = Get_Area_By_DISTRICT_ID(oParams_Get_Area_By_DISTRICT_ID);
                if (_List_Area != null && _List_Area.Count > 0)
                {
                    if (_Stop_Delete_Area_Execution)
                    {
                        _Stop_Delete_Area_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_By_DISTRICT_ID(i_Params_Delete_Area_By_DISTRICT_ID.DISTRICT_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_By_DISTRICT_ID", i_Params_Delete_Area_By_DISTRICT_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_By_REGION_ID
        public void Delete_Area_By_REGION_ID(Params_Delete_Area_By_REGION_ID i_Params_Delete_Area_By_REGION_ID)
        {
            var i_Params_Delete_Area_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_By_REGION_ID", i_Params_Delete_Area_By_REGION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_By_REGION_ID oParams_Get_Area_By_REGION_ID = new Params_Get_Area_By_REGION_ID
                {
                    REGION_ID = i_Params_Delete_Area_By_REGION_ID.REGION_ID
                };
                _List_Area = Get_Area_By_REGION_ID(oParams_Get_Area_By_REGION_ID);
                if (_List_Area != null && _List_Area.Count > 0)
                {
                    if (_Stop_Delete_Area_Execution)
                    {
                        _Stop_Delete_Area_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_By_REGION_ID(i_Params_Delete_Area_By_REGION_ID.REGION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_By_REGION_ID", i_Params_Delete_Area_By_REGION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_By_TOP_LEVEL_ID
        public void Delete_Area_By_TOP_LEVEL_ID(Params_Delete_Area_By_TOP_LEVEL_ID i_Params_Delete_Area_By_TOP_LEVEL_ID)
        {
            var i_Params_Delete_Area_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_By_TOP_LEVEL_ID", i_Params_Delete_Area_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_By_TOP_LEVEL_ID oParams_Get_Area_By_TOP_LEVEL_ID = new Params_Get_Area_By_TOP_LEVEL_ID
                {
                    TOP_LEVEL_ID = i_Params_Delete_Area_By_TOP_LEVEL_ID.TOP_LEVEL_ID
                };
                _List_Area = Get_Area_By_TOP_LEVEL_ID(oParams_Get_Area_By_TOP_LEVEL_ID);
                if (_List_Area != null && _List_Area.Count > 0)
                {
                    if (_Stop_Delete_Area_Execution)
                    {
                        _Stop_Delete_Area_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_By_TOP_LEVEL_ID(i_Params_Delete_Area_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_By_TOP_LEVEL_ID", i_Params_Delete_Area_By_TOP_LEVEL_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_kpi_By_OWNER_ID
        public void Delete_Site_kpi_By_OWNER_ID(Params_Delete_Site_kpi_By_OWNER_ID i_Params_Delete_Site_kpi_By_OWNER_ID)
        {
            var i_Params_Delete_Site_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_kpi_By_OWNER_ID", i_Params_Delete_Site_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_kpi_By_OWNER_ID oParams_Get_Site_kpi_By_OWNER_ID = new Params_Get_Site_kpi_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Site_kpi_By_OWNER_ID.OWNER_ID
                };
                _List_Site_kpi = Get_Site_kpi_By_OWNER_ID(oParams_Get_Site_kpi_By_OWNER_ID);
                if (_List_Site_kpi != null && _List_Site_kpi.Count > 0)
                {
                    if (_Stop_Delete_Site_kpi_Execution)
                    {
                        _Stop_Delete_Site_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_kpi_By_OWNER_ID(i_Params_Delete_Site_kpi_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_kpi_By_OWNER_ID", i_Params_Delete_Site_kpi_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var i_Params_Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID oParams_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID = new Params_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID
                };
                _List_Site_kpi = Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(oParams_Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);
                if (_List_Site_kpi != null && _List_Site_kpi.Count > 0)
                {
                    if (_Stop_Delete_Site_kpi_Execution)
                    {
                        _Stop_Delete_Site_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_kpi_By_OWNER_ID_IS_DELETED
        public void Delete_Site_kpi_By_OWNER_ID_IS_DELETED(Params_Delete_Site_kpi_By_OWNER_ID_IS_DELETED i_Params_Delete_Site_kpi_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Site_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Site_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_Site_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED oParams_Get_Site_kpi_By_OWNER_ID_IS_DELETED = new Params_Get_Site_kpi_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Site_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Site_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Site_kpi = Get_Site_kpi_By_OWNER_ID_IS_DELETED(oParams_Get_Site_kpi_By_OWNER_ID_IS_DELETED);
                if (_List_Site_kpi != null && _List_Site_kpi.Count > 0)
                {
                    if (_Stop_Delete_Site_kpi_Execution)
                    {
                        _Stop_Delete_Site_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_kpi_By_OWNER_ID_IS_DELETED(i_Params_Delete_Site_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Site_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_Site_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Site_kpi_By_SITE_ID
        public void Delete_Site_kpi_By_SITE_ID(Params_Delete_Site_kpi_By_SITE_ID i_Params_Delete_Site_kpi_By_SITE_ID)
        {
            var i_Params_Delete_Site_kpi_By_SITE_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_kpi_By_SITE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_kpi_By_SITE_ID", i_Params_Delete_Site_kpi_By_SITE_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_kpi_By_SITE_ID oParams_Get_Site_kpi_By_SITE_ID = new Params_Get_Site_kpi_By_SITE_ID
                {
                    SITE_ID = i_Params_Delete_Site_kpi_By_SITE_ID.SITE_ID
                };
                _List_Site_kpi = Get_Site_kpi_By_SITE_ID(oParams_Get_Site_kpi_By_SITE_ID);
                if (_List_Site_kpi != null && _List_Site_kpi.Count > 0)
                {
                    if (_Stop_Delete_Site_kpi_Execution)
                    {
                        _Stop_Delete_Site_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_kpi_By_SITE_ID(i_Params_Delete_Site_kpi_By_SITE_ID.SITE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_kpi_By_SITE_ID", i_Params_Delete_Site_kpi_By_SITE_ID_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID
        public void Delete_Setup_category_By_OWNER_ID(Params_Delete_Setup_category_By_OWNER_ID i_Params_Delete_Setup_category_By_OWNER_ID)
        {
            var i_Params_Delete_Setup_category_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category_By_OWNER_ID", i_Params_Delete_Setup_category_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_OWNER_ID oParams_Get_Setup_category_By_OWNER_ID = new Params_Get_Setup_category_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Setup_category_By_OWNER_ID.OWNER_ID
                };
                _List_Setup_category = Get_Setup_category_By_OWNER_ID(oParams_Get_Setup_category_By_OWNER_ID);
                if (_List_Setup_category != null && _List_Setup_category.Count > 0)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category_By_OWNER_ID(i_Params_Delete_Setup_category_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category_By_OWNER_ID", i_Params_Delete_Setup_category_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_category_By_OWNER_ID_IS_DELETED(Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_OWNER_ID_IS_DELETED oParams_Get_Setup_category_By_OWNER_ID_IS_DELETED = new Params_Get_Setup_category_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Setup_category = Get_Setup_category_By_OWNER_ID_IS_DELETED(oParams_Get_Setup_category_By_OWNER_ID_IS_DELETED);
                if (_List_Setup_category != null && _List_Setup_category.Count > 0)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category_By_OWNER_ID_IS_DELETED(i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public void Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID)
        {
            var i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID oParams_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID = new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
                {
                    SETUP_CATEGORY_NAME = i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME,
                    OWNER_ID = i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID
                };
                _Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(oParams_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
                if (_Setup_category != null)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME, i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_By_OWNER_ID_IS_DELETED(Params_Delete_Setup_By_OWNER_ID_IS_DELETED i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_OWNER_ID_IS_DELETED oParams_Get_Setup_By_OWNER_ID_IS_DELETED = new Params_Get_Setup_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Setup = Get_Setup_By_OWNER_ID_IS_DELETED(oParams_Get_Setup_By_OWNER_ID_IS_DELETED);
                if (_List_Setup != null && _List_Setup.Count > 0)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_OWNER_ID_IS_DELETED(i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID
        public void Delete_Setup_By_SETUP_CATEGORY_ID(Params_Delete_Setup_By_SETUP_CATEGORY_ID i_Params_Delete_Setup_By_SETUP_CATEGORY_ID)
        {
            var i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_SETUP_CATEGORY_ID oParams_Get_Setup_By_SETUP_CATEGORY_ID = new Params_Get_Setup_By_SETUP_CATEGORY_ID
                {
                    SETUP_CATEGORY_ID = i_Params_Delete_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID
                };
                _List_Setup = Get_Setup_By_SETUP_CATEGORY_ID(oParams_Get_Setup_By_SETUP_CATEGORY_ID);
                if (_List_Setup != null && _List_Setup.Count > 0)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_SETUP_CATEGORY_ID(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
        public void Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE)
        {
            var i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE oParams_Get_Setup_By_SETUP_CATEGORY_ID_VALUE = new Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE
                {
                    SETUP_CATEGORY_ID = i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID,
                    VALUE = i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE
                };
                _Setup = Get_Setup_By_SETUP_CATEGORY_ID_VALUE(oParams_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
                if (_Setup != null)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID, i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID
        public void Delete_Setup_By_OWNER_ID(Params_Delete_Setup_By_OWNER_ID i_Params_Delete_Setup_By_OWNER_ID)
        {
            var i_Params_Delete_Setup_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_OWNER_ID", i_Params_Delete_Setup_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_OWNER_ID oParams_Get_Setup_By_OWNER_ID = new Params_Get_Setup_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Setup_By_OWNER_ID.OWNER_ID
                };
                _List_Setup = Get_Setup_By_OWNER_ID(oParams_Get_Setup_By_OWNER_ID);
                if (_List_Setup != null && _List_Setup.Count > 0)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_OWNER_ID(i_Params_Delete_Setup_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_OWNER_ID", i_Params_Delete_Setup_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_kpi_By_OWNER_ID_IS_DELETED
        public void Delete_Area_kpi_By_OWNER_ID_IS_DELETED(Params_Delete_Area_kpi_By_OWNER_ID_IS_DELETED i_Params_Delete_Area_kpi_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Area_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Area_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_Area_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED oParams_Get_Area_kpi_By_OWNER_ID_IS_DELETED = new Params_Get_Area_kpi_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Area_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Area_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Area_kpi = Get_Area_kpi_By_OWNER_ID_IS_DELETED(oParams_Get_Area_kpi_By_OWNER_ID_IS_DELETED);
                if (_List_Area_kpi != null && _List_Area_kpi.Count > 0)
                {
                    if (_Stop_Delete_Area_kpi_Execution)
                    {
                        _Stop_Delete_Area_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_kpi_By_OWNER_ID_IS_DELETED(i_Params_Delete_Area_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Area_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_Area_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Area_kpi_By_OWNER_ID
        public void Delete_Area_kpi_By_OWNER_ID(Params_Delete_Area_kpi_By_OWNER_ID i_Params_Delete_Area_kpi_By_OWNER_ID)
        {
            var i_Params_Delete_Area_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_kpi_By_OWNER_ID", i_Params_Delete_Area_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_kpi_By_OWNER_ID oParams_Get_Area_kpi_By_OWNER_ID = new Params_Get_Area_kpi_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Area_kpi_By_OWNER_ID.OWNER_ID
                };
                _List_Area_kpi = Get_Area_kpi_By_OWNER_ID(oParams_Get_Area_kpi_By_OWNER_ID);
                if (_List_Area_kpi != null && _List_Area_kpi.Count > 0)
                {
                    if (_Stop_Delete_Area_kpi_Execution)
                    {
                        _Stop_Delete_Area_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_kpi_By_OWNER_ID(i_Params_Delete_Area_kpi_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_kpi_By_OWNER_ID", i_Params_Delete_Area_kpi_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_kpi_By_AREA_ID
        public void Delete_Area_kpi_By_AREA_ID(Params_Delete_Area_kpi_By_AREA_ID i_Params_Delete_Area_kpi_By_AREA_ID)
        {
            var i_Params_Delete_Area_kpi_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_kpi_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_kpi_By_AREA_ID", i_Params_Delete_Area_kpi_By_AREA_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_kpi_By_AREA_ID oParams_Get_Area_kpi_By_AREA_ID = new Params_Get_Area_kpi_By_AREA_ID
                {
                    AREA_ID = i_Params_Delete_Area_kpi_By_AREA_ID.AREA_ID
                };
                _List_Area_kpi = Get_Area_kpi_By_AREA_ID(oParams_Get_Area_kpi_By_AREA_ID);
                if (_List_Area_kpi != null && _List_Area_kpi.Count > 0)
                {
                    if (_Stop_Delete_Area_kpi_Execution)
                    {
                        _Stop_Delete_Area_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_kpi_By_AREA_ID(i_Params_Delete_Area_kpi_By_AREA_ID.AREA_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_kpi_By_AREA_ID", i_Params_Delete_Area_kpi_By_AREA_ID_json, false);
            }
        }
        #endregion
        #region Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var i_Params_Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID oParams_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID = new Params_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID
                };
                _List_Area_kpi = Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(oParams_Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID);
                if (_List_Area_kpi != null && _List_Area_kpi.Count > 0)
                {
                    if (_Stop_Delete_Area_kpi_Execution)
                    {
                        _Stop_Delete_Area_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
        }
        #endregion
        #region Delete_Space_asset_By_OWNER_ID
        public void Delete_Space_asset_By_OWNER_ID(Params_Delete_Space_asset_By_OWNER_ID i_Params_Delete_Space_asset_By_OWNER_ID)
        {
            var i_Params_Delete_Space_asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Space_asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_asset_By_OWNER_ID", i_Params_Delete_Space_asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_asset_By_OWNER_ID oParams_Get_Space_asset_By_OWNER_ID = new Params_Get_Space_asset_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Space_asset_By_OWNER_ID.OWNER_ID
                };
                _List_Space_asset = Get_Space_asset_By_OWNER_ID(oParams_Get_Space_asset_By_OWNER_ID);
                if (_List_Space_asset != null && _List_Space_asset.Count > 0)
                {
                    if (_Stop_Delete_Space_asset_Execution)
                    {
                        _Stop_Delete_Space_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_asset_By_OWNER_ID(i_Params_Delete_Space_asset_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Space_asset_By_OWNER_ID", i_Params_Delete_Space_asset_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Space_asset_By_SPACE_ID
        public void Delete_Space_asset_By_SPACE_ID(Params_Delete_Space_asset_By_SPACE_ID i_Params_Delete_Space_asset_By_SPACE_ID)
        {
            var i_Params_Delete_Space_asset_By_SPACE_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Space_asset_By_SPACE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_asset_By_SPACE_ID", i_Params_Delete_Space_asset_By_SPACE_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_asset_By_SPACE_ID oParams_Get_Space_asset_By_SPACE_ID = new Params_Get_Space_asset_By_SPACE_ID
                {
                    SPACE_ID = i_Params_Delete_Space_asset_By_SPACE_ID.SPACE_ID
                };
                _List_Space_asset = Get_Space_asset_By_SPACE_ID(oParams_Get_Space_asset_By_SPACE_ID);
                if (_List_Space_asset != null && _List_Space_asset.Count > 0)
                {
                    if (_Stop_Delete_Space_asset_Execution)
                    {
                        _Stop_Delete_Space_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_asset_By_SPACE_ID(i_Params_Delete_Space_asset_By_SPACE_ID.SPACE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Space_asset_By_SPACE_ID", i_Params_Delete_Space_asset_By_SPACE_ID_json, false);
            }
        }
        #endregion
        #region Delete_Space_asset_By_ASSET_ID
        public void Delete_Space_asset_By_ASSET_ID(Params_Delete_Space_asset_By_ASSET_ID i_Params_Delete_Space_asset_By_ASSET_ID)
        {
            var i_Params_Delete_Space_asset_By_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Space_asset_By_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_asset_By_ASSET_ID", i_Params_Delete_Space_asset_By_ASSET_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_asset_By_ASSET_ID oParams_Get_Space_asset_By_ASSET_ID = new Params_Get_Space_asset_By_ASSET_ID
                {
                    ASSET_ID = i_Params_Delete_Space_asset_By_ASSET_ID.ASSET_ID
                };
                _List_Space_asset = Get_Space_asset_By_ASSET_ID(oParams_Get_Space_asset_By_ASSET_ID);
                if (_List_Space_asset != null && _List_Space_asset.Count > 0)
                {
                    if (_Stop_Delete_Space_asset_Execution)
                    {
                        _Stop_Delete_Space_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_asset_By_ASSET_ID(i_Params_Delete_Space_asset_By_ASSET_ID.ASSET_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Space_asset_By_ASSET_ID", i_Params_Delete_Space_asset_By_ASSET_ID_json, false);
            }
        }
        #endregion
        #region Delete_Space_asset_By_OWNER_ID_IS_DELETED
        public void Delete_Space_asset_By_OWNER_ID_IS_DELETED(Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_asset_By_OWNER_ID_IS_DELETED", i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_asset_By_OWNER_ID_IS_DELETED oParams_Get_Space_asset_By_OWNER_ID_IS_DELETED = new Params_Get_Space_asset_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Space_asset = Get_Space_asset_By_OWNER_ID_IS_DELETED(oParams_Get_Space_asset_By_OWNER_ID_IS_DELETED);
                if (_List_Space_asset != null && _List_Space_asset.Count > 0)
                {
                    if (_Stop_Delete_Space_asset_Execution)
                    {
                        _Stop_Delete_Space_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_asset_By_OWNER_ID_IS_DELETED(i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Space_asset_By_OWNER_ID_IS_DELETED", i_Params_Delete_Space_asset_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Space_asset_By_EXTERNAL_ID
        public void Delete_Space_asset_By_EXTERNAL_ID(Params_Delete_Space_asset_By_EXTERNAL_ID i_Params_Delete_Space_asset_By_EXTERNAL_ID)
        {
            var i_Params_Delete_Space_asset_By_EXTERNAL_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Space_asset_By_EXTERNAL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_asset_By_EXTERNAL_ID", i_Params_Delete_Space_asset_By_EXTERNAL_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_asset_By_EXTERNAL_ID oParams_Get_Space_asset_By_EXTERNAL_ID = new Params_Get_Space_asset_By_EXTERNAL_ID
                {
                    EXTERNAL_ID = i_Params_Delete_Space_asset_By_EXTERNAL_ID.EXTERNAL_ID
                };
                _List_Space_asset = Get_Space_asset_By_EXTERNAL_ID(oParams_Get_Space_asset_By_EXTERNAL_ID);
                if (_List_Space_asset != null && _List_Space_asset.Count > 0)
                {
                    if (_Stop_Delete_Space_asset_Execution)
                    {
                        _Stop_Delete_Space_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_asset_By_EXTERNAL_ID(i_Params_Delete_Space_asset_By_EXTERNAL_ID.EXTERNAL_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Space_asset_By_EXTERNAL_ID", i_Params_Delete_Space_asset_By_EXTERNAL_ID_json, false);
            }
        }
        #endregion
        #region Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
        public void Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL i_Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL)
        {
            var i_Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json = JsonConvert.SerializeObject(i_Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL", i_Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL oParams_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL = new Params_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
                {
                    IS_MERAKI_WIFI_SIGNAL = i_Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL.IS_MERAKI_WIFI_SIGNAL
                };
                _List_Space_asset = Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(oParams_Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL);
                if (_List_Space_asset != null && _List_Space_asset.Count > 0)
                {
                    if (_Stop_Delete_Space_asset_Execution)
                    {
                        _Stop_Delete_Space_asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(i_Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL.IS_MERAKI_WIFI_SIGNAL);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL", i_Params_Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL_json, false);
            }
        }
        #endregion
        #region Delete_District_By_OWNER_ID_IS_DELETED
        public void Delete_District_By_OWNER_ID_IS_DELETED(Params_Delete_District_By_OWNER_ID_IS_DELETED i_Params_Delete_District_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_District_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_District_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_By_OWNER_ID_IS_DELETED", i_Params_Delete_District_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_By_OWNER_ID_IS_DELETED oParams_Get_District_By_OWNER_ID_IS_DELETED = new Params_Get_District_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_District_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_District_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_District = Get_District_By_OWNER_ID_IS_DELETED(oParams_Get_District_By_OWNER_ID_IS_DELETED);
                if (_List_District != null && _List_District.Count > 0)
                {
                    if (_Stop_Delete_District_Execution)
                    {
                        _Stop_Delete_District_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_By_OWNER_ID_IS_DELETED(i_Params_Delete_District_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_District_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_By_OWNER_ID_IS_DELETED", i_Params_Delete_District_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_District_By_OWNER_ID
        public void Delete_District_By_OWNER_ID(Params_Delete_District_By_OWNER_ID i_Params_Delete_District_By_OWNER_ID)
        {
            var i_Params_Delete_District_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_District_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_By_OWNER_ID", i_Params_Delete_District_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_By_OWNER_ID oParams_Get_District_By_OWNER_ID = new Params_Get_District_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_District_By_OWNER_ID.OWNER_ID
                };
                _List_District = Get_District_By_OWNER_ID(oParams_Get_District_By_OWNER_ID);
                if (_List_District != null && _List_District.Count > 0)
                {
                    if (_Stop_Delete_District_Execution)
                    {
                        _Stop_Delete_District_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_By_OWNER_ID(i_Params_Delete_District_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_By_OWNER_ID", i_Params_Delete_District_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_District_By_REGION_ID
        public void Delete_District_By_REGION_ID(Params_Delete_District_By_REGION_ID i_Params_Delete_District_By_REGION_ID)
        {
            var i_Params_Delete_District_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_District_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_By_REGION_ID", i_Params_Delete_District_By_REGION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_By_REGION_ID oParams_Get_District_By_REGION_ID = new Params_Get_District_By_REGION_ID
                {
                    REGION_ID = i_Params_Delete_District_By_REGION_ID.REGION_ID
                };
                _List_District = Get_District_By_REGION_ID(oParams_Get_District_By_REGION_ID);
                if (_List_District != null && _List_District.Count > 0)
                {
                    if (_Stop_Delete_District_Execution)
                    {
                        _Stop_Delete_District_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_By_REGION_ID(i_Params_Delete_District_By_REGION_ID.REGION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_By_REGION_ID", i_Params_Delete_District_By_REGION_ID_json, false);
            }
        }
        #endregion
        #region Delete_District_By_TOP_LEVEL_ID
        public void Delete_District_By_TOP_LEVEL_ID(Params_Delete_District_By_TOP_LEVEL_ID i_Params_Delete_District_By_TOP_LEVEL_ID)
        {
            var i_Params_Delete_District_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Delete_District_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_By_TOP_LEVEL_ID", i_Params_Delete_District_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_By_TOP_LEVEL_ID oParams_Get_District_By_TOP_LEVEL_ID = new Params_Get_District_By_TOP_LEVEL_ID
                {
                    TOP_LEVEL_ID = i_Params_Delete_District_By_TOP_LEVEL_ID.TOP_LEVEL_ID
                };
                _List_District = Get_District_By_TOP_LEVEL_ID(oParams_Get_District_By_TOP_LEVEL_ID);
                if (_List_District != null && _List_District.Count > 0)
                {
                    if (_Stop_Delete_District_Execution)
                    {
                        _Stop_Delete_District_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_By_TOP_LEVEL_ID(i_Params_Delete_District_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_By_TOP_LEVEL_ID", i_Params_Delete_District_By_TOP_LEVEL_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_OWNER_ID
        public void Delete_Organization_data_source_kpi_By_OWNER_ID(Params_Delete_Organization_data_source_kpi_By_OWNER_ID i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID)
        {
            var i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_data_source_kpi_By_OWNER_ID", i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_data_source_kpi_By_OWNER_ID oParams_Get_Organization_data_source_kpi_By_OWNER_ID = new Params_Get_Organization_data_source_kpi_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID.OWNER_ID
                };
                _List_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_OWNER_ID(oParams_Get_Organization_data_source_kpi_By_OWNER_ID);
                if (_List_Organization_data_source_kpi != null && _List_Organization_data_source_kpi.Count > 0)
                {
                    if (_Stop_Delete_Organization_data_source_kpi_Execution)
                    {
                        _Stop_Delete_Organization_data_source_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_data_source_kpi_By_OWNER_ID(i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_data_source_kpi_By_OWNER_ID", i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID
        public void Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID(Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID i_Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID)
        {
            var i_Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID", i_Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID oParams_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID = new Params_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID
                {
                    DATA_SOURCE_ID = i_Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID.DATA_SOURCE_ID
                };
                _List_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_DATA_SOURCE_ID(oParams_Get_Organization_data_source_kpi_By_DATA_SOURCE_ID);
                if (_List_Organization_data_source_kpi != null && _List_Organization_data_source_kpi.Count > 0)
                {
                    if (_Stop_Delete_Organization_data_source_kpi_Execution)
                    {
                        _Stop_Delete_Organization_data_source_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID(i_Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID.DATA_SOURCE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID", i_Params_Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_KPI_ID
        public void Delete_Organization_data_source_kpi_By_KPI_ID(Params_Delete_Organization_data_source_kpi_By_KPI_ID i_Params_Delete_Organization_data_source_kpi_By_KPI_ID)
        {
            var i_Params_Delete_Organization_data_source_kpi_By_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_data_source_kpi_By_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_data_source_kpi_By_KPI_ID", i_Params_Delete_Organization_data_source_kpi_By_KPI_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_data_source_kpi_By_KPI_ID oParams_Get_Organization_data_source_kpi_By_KPI_ID = new Params_Get_Organization_data_source_kpi_By_KPI_ID
                {
                    KPI_ID = i_Params_Delete_Organization_data_source_kpi_By_KPI_ID.KPI_ID
                };
                _List_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_KPI_ID(oParams_Get_Organization_data_source_kpi_By_KPI_ID);
                if (_List_Organization_data_source_kpi != null && _List_Organization_data_source_kpi.Count > 0)
                {
                    if (_Stop_Delete_Organization_data_source_kpi_Execution)
                    {
                        _Stop_Delete_Organization_data_source_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_data_source_kpi_By_KPI_ID(i_Params_Delete_Organization_data_source_kpi_By_KPI_ID.KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_data_source_kpi_By_KPI_ID", i_Params_Delete_Organization_data_source_kpi_By_KPI_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_ORGANIZATION_ID
        public void Delete_Organization_data_source_kpi_By_ORGANIZATION_ID(Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID i_Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID)
        {
            var i_Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_data_source_kpi_By_ORGANIZATION_ID", i_Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID = new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID
                };
                _List_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_ID(oParams_Get_Organization_data_source_kpi_By_ORGANIZATION_ID);
                if (_List_Organization_data_source_kpi != null && _List_Organization_data_source_kpi.Count > 0)
                {
                    if (_Stop_Delete_Organization_data_source_kpi_Execution)
                    {
                        _Stop_Delete_Organization_data_source_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_data_source_kpi_By_ORGANIZATION_ID(i_Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID.ORGANIZATION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_data_source_kpi_By_ORGANIZATION_ID", i_Params_Delete_Organization_data_source_kpi_By_ORGANIZATION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED oParams_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED = new Params_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Organization_data_source_kpi = Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(oParams_Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED);
                if (_List_Organization_data_source_kpi != null && _List_Organization_data_source_kpi.Count > 0)
                {
                    if (_Stop_Delete_Organization_data_source_kpi_Execution)
                    {
                        _Stop_Delete_Organization_data_source_kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Floor_By_OWNER_ID_IS_DELETED
        public void Delete_Floor_By_OWNER_ID_IS_DELETED(Params_Delete_Floor_By_OWNER_ID_IS_DELETED i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Floor_By_OWNER_ID_IS_DELETED", i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Floor_By_OWNER_ID_IS_DELETED oParams_Get_Floor_By_OWNER_ID_IS_DELETED = new Params_Get_Floor_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Floor = Get_Floor_By_OWNER_ID_IS_DELETED(oParams_Get_Floor_By_OWNER_ID_IS_DELETED);
                if (_List_Floor != null && _List_Floor.Count > 0)
                {
                    if (_Stop_Delete_Floor_Execution)
                    {
                        _Stop_Delete_Floor_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Floor_By_OWNER_ID_IS_DELETED(i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Floor_By_OWNER_ID_IS_DELETED", i_Params_Delete_Floor_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Floor_By_OWNER_ID
        public void Delete_Floor_By_OWNER_ID(Params_Delete_Floor_By_OWNER_ID i_Params_Delete_Floor_By_OWNER_ID)
        {
            var i_Params_Delete_Floor_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Floor_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Floor_By_OWNER_ID", i_Params_Delete_Floor_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Floor_By_OWNER_ID oParams_Get_Floor_By_OWNER_ID = new Params_Get_Floor_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Floor_By_OWNER_ID.OWNER_ID
                };
                _List_Floor = Get_Floor_By_OWNER_ID(oParams_Get_Floor_By_OWNER_ID);
                if (_List_Floor != null && _List_Floor.Count > 0)
                {
                    if (_Stop_Delete_Floor_Execution)
                    {
                        _Stop_Delete_Floor_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Floor_By_OWNER_ID(i_Params_Delete_Floor_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Floor_By_OWNER_ID", i_Params_Delete_Floor_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Floor_By_ENTITY_ID
        public void Delete_Floor_By_ENTITY_ID(Params_Delete_Floor_By_ENTITY_ID i_Params_Delete_Floor_By_ENTITY_ID)
        {
            var i_Params_Delete_Floor_By_ENTITY_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Floor_By_ENTITY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Floor_By_ENTITY_ID", i_Params_Delete_Floor_By_ENTITY_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Floor_By_ENTITY_ID oParams_Get_Floor_By_ENTITY_ID = new Params_Get_Floor_By_ENTITY_ID
                {
                    ENTITY_ID = i_Params_Delete_Floor_By_ENTITY_ID.ENTITY_ID
                };
                _List_Floor = Get_Floor_By_ENTITY_ID(oParams_Get_Floor_By_ENTITY_ID);
                if (_List_Floor != null && _List_Floor.Count > 0)
                {
                    if (_Stop_Delete_Floor_Execution)
                    {
                        _Stop_Delete_Floor_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Floor_By_ENTITY_ID(i_Params_Delete_Floor_By_ENTITY_ID.ENTITY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Floor_By_ENTITY_ID", i_Params_Delete_Floor_By_ENTITY_ID_json, false);
            }
        }
        #endregion
        #region Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED
        public void Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED(Params_Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED i_Params_Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED oParams_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED = new Params_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_District_kpi_user_access = Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED(oParams_Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED);
                if (_List_District_kpi_user_access != null && _List_District_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_District_kpi_user_access_Execution)
                    {
                        _Stop_Delete_District_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED(i_Params_Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED", i_Params_Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_District_kpi_user_access_By_OWNER_ID
        public void Delete_District_kpi_user_access_By_OWNER_ID(Params_Delete_District_kpi_user_access_By_OWNER_ID i_Params_Delete_District_kpi_user_access_By_OWNER_ID)
        {
            var i_Params_Delete_District_kpi_user_access_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_District_kpi_user_access_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_kpi_user_access_By_OWNER_ID", i_Params_Delete_District_kpi_user_access_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_kpi_user_access_By_OWNER_ID oParams_Get_District_kpi_user_access_By_OWNER_ID = new Params_Get_District_kpi_user_access_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_District_kpi_user_access_By_OWNER_ID.OWNER_ID
                };
                _List_District_kpi_user_access = Get_District_kpi_user_access_By_OWNER_ID(oParams_Get_District_kpi_user_access_By_OWNER_ID);
                if (_List_District_kpi_user_access != null && _List_District_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_District_kpi_user_access_Execution)
                    {
                        _Stop_Delete_District_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_kpi_user_access_By_OWNER_ID(i_Params_Delete_District_kpi_user_access_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_kpi_user_access_By_OWNER_ID", i_Params_Delete_District_kpi_user_access_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_District_kpi_user_access_By_USER_ID
        public void Delete_District_kpi_user_access_By_USER_ID(Params_Delete_District_kpi_user_access_By_USER_ID i_Params_Delete_District_kpi_user_access_By_USER_ID)
        {
            var i_Params_Delete_District_kpi_user_access_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_District_kpi_user_access_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_kpi_user_access_By_USER_ID", i_Params_Delete_District_kpi_user_access_By_USER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_kpi_user_access_By_USER_ID oParams_Get_District_kpi_user_access_By_USER_ID = new Params_Get_District_kpi_user_access_By_USER_ID
                {
                    USER_ID = i_Params_Delete_District_kpi_user_access_By_USER_ID.USER_ID
                };
                _List_District_kpi_user_access = Get_District_kpi_user_access_By_USER_ID(oParams_Get_District_kpi_user_access_By_USER_ID);
                if (_List_District_kpi_user_access != null && _List_District_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_District_kpi_user_access_Execution)
                    {
                        _Stop_Delete_District_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_kpi_user_access_By_USER_ID(i_Params_Delete_District_kpi_user_access_By_USER_ID.USER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_kpi_user_access_By_USER_ID", i_Params_Delete_District_kpi_user_access_By_USER_ID_json, false);
            }
        }
        #endregion
        #region Delete_District_kpi_user_access_By_DISTRICT_ID
        public void Delete_District_kpi_user_access_By_DISTRICT_ID(Params_Delete_District_kpi_user_access_By_DISTRICT_ID i_Params_Delete_District_kpi_user_access_By_DISTRICT_ID)
        {
            var i_Params_Delete_District_kpi_user_access_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Delete_District_kpi_user_access_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_kpi_user_access_By_DISTRICT_ID", i_Params_Delete_District_kpi_user_access_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_kpi_user_access_By_DISTRICT_ID oParams_Get_District_kpi_user_access_By_DISTRICT_ID = new Params_Get_District_kpi_user_access_By_DISTRICT_ID
                {
                    DISTRICT_ID = i_Params_Delete_District_kpi_user_access_By_DISTRICT_ID.DISTRICT_ID
                };
                _List_District_kpi_user_access = Get_District_kpi_user_access_By_DISTRICT_ID(oParams_Get_District_kpi_user_access_By_DISTRICT_ID);
                if (_List_District_kpi_user_access != null && _List_District_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_District_kpi_user_access_Execution)
                    {
                        _Stop_Delete_District_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_kpi_user_access_By_DISTRICT_ID(i_Params_Delete_District_kpi_user_access_By_DISTRICT_ID.DISTRICT_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_kpi_user_access_By_DISTRICT_ID", i_Params_Delete_District_kpi_user_access_By_DISTRICT_ID_json, false);
            }
        }
        #endregion
        #region Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(Params_Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID i_Params_Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var i_Params_Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID oParams_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID = new Params_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Params_Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID
                };
                _List_District_kpi_user_access = Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(oParams_Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID);
                if (_List_District_kpi_user_access != null && _List_District_kpi_user_access.Count > 0)
                {
                    if (_Stop_Delete_District_kpi_user_access_Execution)
                    {
                        _Stop_Delete_District_kpi_user_access_Execution = false;
                        return;
                    }
                    _AppContext.Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(i_Params_Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID.ORGANIZATION_DATA_SOURCE_KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID", i_Params_Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_json, false);
            }
        }
        #endregion
        #region Delete_User_By_OWNER_ID_IS_DELETED
        public void Delete_User_By_OWNER_ID_IS_DELETED(Params_Delete_User_By_OWNER_ID_IS_DELETED i_Params_Delete_User_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_User_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_OWNER_ID_IS_DELETED", i_Params_Delete_User_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_OWNER_ID_IS_DELETED oParams_Get_User_By_OWNER_ID_IS_DELETED = new Params_Get_User_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_User_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_User_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_User = Get_User_By_OWNER_ID_IS_DELETED(oParams_Get_User_By_OWNER_ID_IS_DELETED);
                if (_List_User != null && _List_User.Count > 0)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_OWNER_ID_IS_DELETED(i_Params_Delete_User_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_User_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_User_By_OWNER_ID_IS_DELETED", i_Params_Delete_User_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_User_By_USERNAME_OWNER_ID
        public void Delete_User_By_USERNAME_OWNER_ID(Params_Delete_User_By_USERNAME_OWNER_ID i_Params_Delete_User_By_USERNAME_OWNER_ID)
        {
            var i_Params_Delete_User_By_USERNAME_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_USERNAME_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_USERNAME_OWNER_ID", i_Params_Delete_User_By_USERNAME_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_USERNAME_OWNER_ID oParams_Get_User_By_USERNAME_OWNER_ID = new Params_Get_User_By_USERNAME_OWNER_ID
                {
                    USERNAME = i_Params_Delete_User_By_USERNAME_OWNER_ID.USERNAME,
                    OWNER_ID = i_Params_Delete_User_By_USERNAME_OWNER_ID.OWNER_ID
                };
                _User = Get_User_By_USERNAME_OWNER_ID(oParams_Get_User_By_USERNAME_OWNER_ID);
                if (_User != null)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_USERNAME_OWNER_ID(i_Params_Delete_User_By_USERNAME_OWNER_ID.USERNAME, i_Params_Delete_User_By_USERNAME_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_User_By_USERNAME_OWNER_ID", i_Params_Delete_User_By_USERNAME_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_User_By_EMAIL_OWNER_ID
        public void Delete_User_By_EMAIL_OWNER_ID(Params_Delete_User_By_EMAIL_OWNER_ID i_Params_Delete_User_By_EMAIL_OWNER_ID)
        {
            var i_Params_Delete_User_By_EMAIL_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_EMAIL_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_EMAIL_OWNER_ID", i_Params_Delete_User_By_EMAIL_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_EMAIL_OWNER_ID oParams_Get_User_By_EMAIL_OWNER_ID = new Params_Get_User_By_EMAIL_OWNER_ID
                {
                    EMAIL = i_Params_Delete_User_By_EMAIL_OWNER_ID.EMAIL,
                    OWNER_ID = i_Params_Delete_User_By_EMAIL_OWNER_ID.OWNER_ID
                };
                _User = Get_User_By_EMAIL_OWNER_ID(oParams_Get_User_By_EMAIL_OWNER_ID);
                if (_User != null)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_EMAIL_OWNER_ID(i_Params_Delete_User_By_EMAIL_OWNER_ID.EMAIL, i_Params_Delete_User_By_EMAIL_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_User_By_EMAIL_OWNER_ID", i_Params_Delete_User_By_EMAIL_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_User_By_USER_TYPE_SETUP_ID
        public void Delete_User_By_USER_TYPE_SETUP_ID(Params_Delete_User_By_USER_TYPE_SETUP_ID i_Params_Delete_User_By_USER_TYPE_SETUP_ID)
        {
            var i_Params_Delete_User_By_USER_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_USER_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_USER_TYPE_SETUP_ID", i_Params_Delete_User_By_USER_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_USER_TYPE_SETUP_ID oParams_Get_User_By_USER_TYPE_SETUP_ID = new Params_Get_User_By_USER_TYPE_SETUP_ID
                {
                    USER_TYPE_SETUP_ID = i_Params_Delete_User_By_USER_TYPE_SETUP_ID.USER_TYPE_SETUP_ID
                };
                _List_User = Get_User_By_USER_TYPE_SETUP_ID(oParams_Get_User_By_USER_TYPE_SETUP_ID);
                if (_List_User != null && _List_User.Count > 0)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_USER_TYPE_SETUP_ID(i_Params_Delete_User_By_USER_TYPE_SETUP_ID.USER_TYPE_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_User_By_USER_TYPE_SETUP_ID", i_Params_Delete_User_By_USER_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_User_By_ORGANIZATION_ID
        public void Delete_User_By_ORGANIZATION_ID(Params_Delete_User_By_ORGANIZATION_ID i_Params_Delete_User_By_ORGANIZATION_ID)
        {
            var i_Params_Delete_User_By_ORGANIZATION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_ORGANIZATION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_ORGANIZATION_ID", i_Params_Delete_User_By_ORGANIZATION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_ORGANIZATION_ID oParams_Get_User_By_ORGANIZATION_ID = new Params_Get_User_By_ORGANIZATION_ID
                {
                    ORGANIZATION_ID = i_Params_Delete_User_By_ORGANIZATION_ID.ORGANIZATION_ID
                };
                _List_User = Get_User_By_ORGANIZATION_ID(oParams_Get_User_By_ORGANIZATION_ID);
                if (_List_User != null && _List_User.Count > 0)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_ORGANIZATION_ID(i_Params_Delete_User_By_ORGANIZATION_ID.ORGANIZATION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_User_By_ORGANIZATION_ID", i_Params_Delete_User_By_ORGANIZATION_ID_json, false);
            }
        }
        #endregion
        #region Delete_User_By_OWNER_ID
        public void Delete_User_By_OWNER_ID(Params_Delete_User_By_OWNER_ID i_Params_Delete_User_By_OWNER_ID)
        {
            var i_Params_Delete_User_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_OWNER_ID", i_Params_Delete_User_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_OWNER_ID oParams_Get_User_By_OWNER_ID = new Params_Get_User_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_User_By_OWNER_ID.OWNER_ID
                };
                _List_User = Get_User_By_OWNER_ID(oParams_Get_User_By_OWNER_ID);
                if (_List_User != null && _List_User.Count > 0)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_OWNER_ID(i_Params_Delete_User_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_User_By_OWNER_ID", i_Params_Delete_User_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_User_By_IS_RECEIVE_EMAIL
        public void Delete_User_By_IS_RECEIVE_EMAIL(Params_Delete_User_By_IS_RECEIVE_EMAIL i_Params_Delete_User_By_IS_RECEIVE_EMAIL)
        {
            var i_Params_Delete_User_By_IS_RECEIVE_EMAIL_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_IS_RECEIVE_EMAIL);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_IS_RECEIVE_EMAIL", i_Params_Delete_User_By_IS_RECEIVE_EMAIL_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_IS_RECEIVE_EMAIL oParams_Get_User_By_IS_RECEIVE_EMAIL = new Params_Get_User_By_IS_RECEIVE_EMAIL
                {
                    IS_RECEIVE_EMAIL = i_Params_Delete_User_By_IS_RECEIVE_EMAIL.IS_RECEIVE_EMAIL
                };
                _List_User = Get_User_By_IS_RECEIVE_EMAIL(oParams_Get_User_By_IS_RECEIVE_EMAIL);
                if (_List_User != null && _List_User.Count > 0)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_IS_RECEIVE_EMAIL(i_Params_Delete_User_By_IS_RECEIVE_EMAIL.IS_RECEIVE_EMAIL);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_User_By_IS_RECEIVE_EMAIL", i_Params_Delete_User_By_IS_RECEIVE_EMAIL_json, false);
            }
        }
        #endregion
        #region Delete_User_By_IS_DELETED
        public void Delete_User_By_IS_DELETED(Params_Delete_User_By_IS_DELETED i_Params_Delete_User_By_IS_DELETED)
        {
            var i_Params_Delete_User_By_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_IS_DELETED", i_Params_Delete_User_By_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_IS_DELETED oParams_Get_User_By_IS_DELETED = new Params_Get_User_By_IS_DELETED
                {
                    IS_DELETED = i_Params_Delete_User_By_IS_DELETED.IS_DELETED
                };
                _List_User = Get_User_By_IS_DELETED(oParams_Get_User_By_IS_DELETED);
                if (_List_User != null && _List_User.Count > 0)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_IS_DELETED(i_Params_Delete_User_By_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_User_By_IS_DELETED", i_Params_Delete_User_By_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
        public void Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED)
        {
            var i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED", i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED oParams_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED = new Params_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.OWNER_ID,
                    IS_ACTIVE = i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_ACTIVE,
                    IS_DELETED = i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_DELETED
                };
                _List_User = Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(oParams_Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED);
                if (_List_User != null && _List_User.Count > 0)
                {
                    if (_Stop_Delete_User_Execution)
                    {
                        _Stop_Delete_User_Execution = false;
                        return;
                    }
                    _AppContext.Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.OWNER_ID, i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_ACTIVE, i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED", i_Params_Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Space_By_OWNER_ID
        public void Delete_Space_By_OWNER_ID(Params_Delete_Space_By_OWNER_ID i_Params_Delete_Space_By_OWNER_ID)
        {
            var i_Params_Delete_Space_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Space_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_By_OWNER_ID", i_Params_Delete_Space_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_By_OWNER_ID oParams_Get_Space_By_OWNER_ID = new Params_Get_Space_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Space_By_OWNER_ID.OWNER_ID
                };
                _List_Space = Get_Space_By_OWNER_ID(oParams_Get_Space_By_OWNER_ID);
                if (_List_Space != null && _List_Space.Count > 0)
                {
                    if (_Stop_Delete_Space_Execution)
                    {
                        _Stop_Delete_Space_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_By_OWNER_ID(i_Params_Delete_Space_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Space_By_OWNER_ID", i_Params_Delete_Space_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Space_By_FLOOR_ID
        public void Delete_Space_By_FLOOR_ID(Params_Delete_Space_By_FLOOR_ID i_Params_Delete_Space_By_FLOOR_ID)
        {
            var i_Params_Delete_Space_By_FLOOR_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Space_By_FLOOR_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_By_FLOOR_ID", i_Params_Delete_Space_By_FLOOR_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_By_FLOOR_ID oParams_Get_Space_By_FLOOR_ID = new Params_Get_Space_By_FLOOR_ID
                {
                    FLOOR_ID = i_Params_Delete_Space_By_FLOOR_ID.FLOOR_ID
                };
                _List_Space = Get_Space_By_FLOOR_ID(oParams_Get_Space_By_FLOOR_ID);
                if (_List_Space != null && _List_Space.Count > 0)
                {
                    if (_Stop_Delete_Space_Execution)
                    {
                        _Stop_Delete_Space_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_By_FLOOR_ID(i_Params_Delete_Space_By_FLOOR_ID.FLOOR_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Space_By_FLOOR_ID", i_Params_Delete_Space_By_FLOOR_ID_json, false);
            }
        }
        #endregion
        #region Delete_Space_By_OWNER_ID_IS_DELETED
        public void Delete_Space_By_OWNER_ID_IS_DELETED(Params_Delete_Space_By_OWNER_ID_IS_DELETED i_Params_Delete_Space_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Space_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Space_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Space_By_OWNER_ID_IS_DELETED", i_Params_Delete_Space_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Space_By_OWNER_ID_IS_DELETED oParams_Get_Space_By_OWNER_ID_IS_DELETED = new Params_Get_Space_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Space_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Space_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Space = Get_Space_By_OWNER_ID_IS_DELETED(oParams_Get_Space_By_OWNER_ID_IS_DELETED);
                if (_List_Space != null && _List_Space.Count > 0)
                {
                    if (_Stop_Delete_Space_Execution)
                    {
                        _Stop_Delete_Space_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Space_By_OWNER_ID_IS_DELETED(i_Params_Delete_Space_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Space_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Space_By_OWNER_ID_IS_DELETED", i_Params_Delete_Space_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Site_By_OWNER_ID_IS_DELETED
        public void Delete_Site_By_OWNER_ID_IS_DELETED(Params_Delete_Site_By_OWNER_ID_IS_DELETED i_Params_Delete_Site_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Site_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Site_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_By_OWNER_ID_IS_DELETED", i_Params_Delete_Site_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_By_OWNER_ID_IS_DELETED oParams_Get_Site_By_OWNER_ID_IS_DELETED = new Params_Get_Site_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Site_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Site_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Site = Get_Site_By_OWNER_ID_IS_DELETED(oParams_Get_Site_By_OWNER_ID_IS_DELETED);
                if (_List_Site != null && _List_Site.Count > 0)
                {
                    if (_Stop_Delete_Site_Execution)
                    {
                        _Stop_Delete_Site_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_By_OWNER_ID_IS_DELETED(i_Params_Delete_Site_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Site_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_By_OWNER_ID_IS_DELETED", i_Params_Delete_Site_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Site_By_OWNER_ID
        public void Delete_Site_By_OWNER_ID(Params_Delete_Site_By_OWNER_ID i_Params_Delete_Site_By_OWNER_ID)
        {
            var i_Params_Delete_Site_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_By_OWNER_ID", i_Params_Delete_Site_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_By_OWNER_ID oParams_Get_Site_By_OWNER_ID = new Params_Get_Site_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Site_By_OWNER_ID.OWNER_ID
                };
                _List_Site = Get_Site_By_OWNER_ID(oParams_Get_Site_By_OWNER_ID);
                if (_List_Site != null && _List_Site.Count > 0)
                {
                    if (_Stop_Delete_Site_Execution)
                    {
                        _Stop_Delete_Site_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_By_OWNER_ID(i_Params_Delete_Site_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_By_OWNER_ID", i_Params_Delete_Site_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_By_AREA_ID
        public void Delete_Site_By_AREA_ID(Params_Delete_Site_By_AREA_ID i_Params_Delete_Site_By_AREA_ID)
        {
            var i_Params_Delete_Site_By_AREA_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_By_AREA_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_By_AREA_ID", i_Params_Delete_Site_By_AREA_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_By_AREA_ID oParams_Get_Site_By_AREA_ID = new Params_Get_Site_By_AREA_ID
                {
                    AREA_ID = i_Params_Delete_Site_By_AREA_ID.AREA_ID
                };
                _List_Site = Get_Site_By_AREA_ID(oParams_Get_Site_By_AREA_ID);
                if (_List_Site != null && _List_Site.Count > 0)
                {
                    if (_Stop_Delete_Site_Execution)
                    {
                        _Stop_Delete_Site_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_By_AREA_ID(i_Params_Delete_Site_By_AREA_ID.AREA_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_By_AREA_ID", i_Params_Delete_Site_By_AREA_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_By_DISTRICT_ID
        public void Delete_Site_By_DISTRICT_ID(Params_Delete_Site_By_DISTRICT_ID i_Params_Delete_Site_By_DISTRICT_ID)
        {
            var i_Params_Delete_Site_By_DISTRICT_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_By_DISTRICT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_By_DISTRICT_ID", i_Params_Delete_Site_By_DISTRICT_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_By_DISTRICT_ID oParams_Get_Site_By_DISTRICT_ID = new Params_Get_Site_By_DISTRICT_ID
                {
                    DISTRICT_ID = i_Params_Delete_Site_By_DISTRICT_ID.DISTRICT_ID
                };
                _List_Site = Get_Site_By_DISTRICT_ID(oParams_Get_Site_By_DISTRICT_ID);
                if (_List_Site != null && _List_Site.Count > 0)
                {
                    if (_Stop_Delete_Site_Execution)
                    {
                        _Stop_Delete_Site_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_By_DISTRICT_ID(i_Params_Delete_Site_By_DISTRICT_ID.DISTRICT_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_By_DISTRICT_ID", i_Params_Delete_Site_By_DISTRICT_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_By_REGION_ID
        public void Delete_Site_By_REGION_ID(Params_Delete_Site_By_REGION_ID i_Params_Delete_Site_By_REGION_ID)
        {
            var i_Params_Delete_Site_By_REGION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_By_REGION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_By_REGION_ID", i_Params_Delete_Site_By_REGION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_By_REGION_ID oParams_Get_Site_By_REGION_ID = new Params_Get_Site_By_REGION_ID
                {
                    REGION_ID = i_Params_Delete_Site_By_REGION_ID.REGION_ID
                };
                _List_Site = Get_Site_By_REGION_ID(oParams_Get_Site_By_REGION_ID);
                if (_List_Site != null && _List_Site.Count > 0)
                {
                    if (_Stop_Delete_Site_Execution)
                    {
                        _Stop_Delete_Site_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_By_REGION_ID(i_Params_Delete_Site_By_REGION_ID.REGION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_By_REGION_ID", i_Params_Delete_Site_By_REGION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Site_By_TOP_LEVEL_ID
        public void Delete_Site_By_TOP_LEVEL_ID(Params_Delete_Site_By_TOP_LEVEL_ID i_Params_Delete_Site_By_TOP_LEVEL_ID)
        {
            var i_Params_Delete_Site_By_TOP_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Site_By_TOP_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Site_By_TOP_LEVEL_ID", i_Params_Delete_Site_By_TOP_LEVEL_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Site_By_TOP_LEVEL_ID oParams_Get_Site_By_TOP_LEVEL_ID = new Params_Get_Site_By_TOP_LEVEL_ID
                {
                    TOP_LEVEL_ID = i_Params_Delete_Site_By_TOP_LEVEL_ID.TOP_LEVEL_ID
                };
                _List_Site = Get_Site_By_TOP_LEVEL_ID(oParams_Get_Site_By_TOP_LEVEL_ID);
                if (_List_Site != null && _List_Site.Count > 0)
                {
                    if (_Stop_Delete_Site_Execution)
                    {
                        _Stop_Delete_Site_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Site_By_TOP_LEVEL_ID(i_Params_Delete_Site_By_TOP_LEVEL_ID.TOP_LEVEL_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Site_By_TOP_LEVEL_ID", i_Params_Delete_Site_By_TOP_LEVEL_ID_json, false);
            }
        }
        #endregion
        #region Edit_Kpi
        public void Edit_Kpi(Kpi i_Kpi)
        {
            var i_Kpi_json = JsonConvert.SerializeObject(i_Kpi);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Kpi.KPI_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Kpi", i_Kpi_json, false);
            }
            #region Body Section.
            if (i_Kpi.KPI_ID == null || i_Kpi.KPI_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Kpi");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Kpi.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Kpi.IS_DELETED = false;
            }
            else
            {
                _Kpi = Get_Kpi_By_KPI_ID(new Params_Get_Kpi_By_KPI_ID
                {
                    KPI_ID = i_Kpi.KPI_ID
                });
            }
            i_Kpi.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Kpi.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Kpi.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Kpi_Execution)
            {
                _Stop_Edit_Kpi_Execution = false;
                return;
            }
            i_Kpi.KPI_ID = _AppContext.Edit_Kpi
            (
                i_Kpi.KPI_ID,
                i_Kpi.DIMENSION_ID,
                i_Kpi.SETUP_CATEGORY_ID,
                i_Kpi.NAME,
                i_Kpi.UNIT,
                i_Kpi.KPI_TYPE_SETUP_ID,
                i_Kpi.HAS_CORRELATION,
                i_Kpi.IS_TRENDLINE,
                i_Kpi.IS_DECIMAL_VALUE,
                i_Kpi.HAS_SQM,
                i_Kpi.IS_BY_SEVERITY,
                i_Kpi.IS_ADDITIVE_DATA,
                i_Kpi.MINIMUM_VALUE,
                i_Kpi.MAXIMUM_VALUE,
                i_Kpi.LATEST_DATA_CREATION_DATE,
                i_Kpi.IS_AUTO_GENERATE,
                i_Kpi.MIN_DATA_LEVEL_SETUP_ID,
                i_Kpi.MAX_DATA_LEVEL_SETUP_ID,
                i_Kpi.IS_EXTERNAL,
                i_Kpi.HAS_ALERTS,
                i_Kpi.ENTRY_USER_ID,
                i_Kpi.ENTRY_DATE,
                i_Kpi.LAST_UPDATE,
                i_Kpi.IS_DELETED,
                i_Kpi.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Kpi", i_Kpi_json, false);
            }
        }
        #endregion
        #region Edit_Asset
        public void Edit_Asset(Asset i_Asset)
        {
            var i_Asset_json = JsonConvert.SerializeObject(i_Asset);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Asset.ASSET_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Asset", i_Asset_json, false);
            }
            #region Body Section.
            if (i_Asset.ASSET_ID == null || i_Asset.ASSET_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Asset");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Asset.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Asset.IS_DELETED = false;
            }
            else
            {
                _Asset = Get_Asset_By_ASSET_ID(new Params_Get_Asset_By_ASSET_ID
                {
                    ASSET_ID = i_Asset.ASSET_ID
                });
            }
            i_Asset.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Asset.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Asset.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Asset_Execution)
            {
                _Stop_Edit_Asset_Execution = false;
                return;
            }
            i_Asset.ASSET_ID = _AppContext.Edit_Asset
            (
                i_Asset.ASSET_ID,
                i_Asset.ASSET_TYPE_SETUP_ID,
                i_Asset.NAME,
                i_Asset.GLTF_URL,
                i_Asset.ENTRY_USER_ID,
                i_Asset.ENTRY_DATE,
                i_Asset.LAST_UPDATE,
                i_Asset.IS_DELETED,
                i_Asset.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Asset", i_Asset_json, false);
            }
        }
        #endregion
        #region Edit_Ext_study_zone
        public void Edit_Ext_study_zone(Ext_study_zone i_Ext_study_zone)
        {
            var i_Ext_study_zone_json = JsonConvert.SerializeObject(i_Ext_study_zone);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Ext_study_zone.EXT_STUDY_ZONE_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Ext_study_zone", i_Ext_study_zone_json, false);
            }
            #region Body Section.
            if (i_Ext_study_zone.EXT_STUDY_ZONE_ID == null || i_Ext_study_zone.EXT_STUDY_ZONE_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Ext_study_zone");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Ext_study_zone.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Ext_study_zone.IS_DELETED = false;
            }
            else
            {
                _Ext_study_zone = Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID(new Params_Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID
                {
                    EXT_STUDY_ZONE_ID = i_Ext_study_zone.EXT_STUDY_ZONE_ID
                });
            }
            i_Ext_study_zone.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Ext_study_zone.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Ext_study_zone.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Ext_study_zone_Execution)
            {
                _Stop_Edit_Ext_study_zone_Execution = false;
                return;
            }
            i_Ext_study_zone.EXT_STUDY_ZONE_ID = _AppContext.Edit_Ext_study_zone
            (
                i_Ext_study_zone.EXT_STUDY_ZONE_ID,
                i_Ext_study_zone.NAME,
                i_Ext_study_zone.LATITUDE,
                i_Ext_study_zone.LONGITUDE,
                i_Ext_study_zone.AREA_COLOR,
                i_Ext_study_zone.BORDER_COLOR,
                i_Ext_study_zone.STUDY_ZONE_NAME,
                i_Ext_study_zone.ENTRY_USER_ID,
                i_Ext_study_zone.ENTRY_DATE,
                i_Ext_study_zone.LAST_UPDATE,
                i_Ext_study_zone.IS_DELETED,
                i_Ext_study_zone.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Ext_study_zone", i_Ext_study_zone_json, false);
            }
        }
        #endregion
        #region Edit_Area_kpi_user_access
        public void Edit_Area_kpi_user_access(Area_kpi_user_access i_Area_kpi_user_access)
        {
            var i_Area_kpi_user_access_json = JsonConvert.SerializeObject(i_Area_kpi_user_access);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Area_kpi_user_access.AREA_KPI_USER_ACCESS_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Area_kpi_user_access", i_Area_kpi_user_access_json, false);
            }
            #region Body Section.
            if (i_Area_kpi_user_access.AREA_KPI_USER_ACCESS_ID == null || i_Area_kpi_user_access.AREA_KPI_USER_ACCESS_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Area_kpi_user_access");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Area_kpi_user_access.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Area_kpi_user_access.IS_DELETED = false;
            }
            else
            {
                _Area_kpi_user_access = Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID(new Params_Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID
                {
                    AREA_KPI_USER_ACCESS_ID = i_Area_kpi_user_access.AREA_KPI_USER_ACCESS_ID
                });
            }
            i_Area_kpi_user_access.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Area_kpi_user_access.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Area_kpi_user_access.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Area_kpi_user_access_Execution)
            {
                _Stop_Edit_Area_kpi_user_access_Execution = false;
                return;
            }
            i_Area_kpi_user_access.AREA_KPI_USER_ACCESS_ID = _AppContext.Edit_Area_kpi_user_access
            (
                i_Area_kpi_user_access.AREA_KPI_USER_ACCESS_ID,
                i_Area_kpi_user_access.USER_ID,
                i_Area_kpi_user_access.AREA_ID,
                i_Area_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID,
                i_Area_kpi_user_access.ENTRY_USER_ID,
                i_Area_kpi_user_access.ENTRY_DATE,
                i_Area_kpi_user_access.LAST_UPDATE,
                i_Area_kpi_user_access.IS_DELETED,
                i_Area_kpi_user_access.OWNER_ID,
                i_Area_kpi_user_access.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Area_kpi_user_access", i_Area_kpi_user_access_json, false);
            }
        }
        #endregion
        #region Edit_Site_kpi_user_access
        public void Edit_Site_kpi_user_access(Site_kpi_user_access i_Site_kpi_user_access)
        {
            var i_Site_kpi_user_access_json = JsonConvert.SerializeObject(i_Site_kpi_user_access);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Site_kpi_user_access.SITE_KPI_USER_ACCESS_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Site_kpi_user_access", i_Site_kpi_user_access_json, false);
            }
            #region Body Section.
            if (i_Site_kpi_user_access.SITE_KPI_USER_ACCESS_ID == null || i_Site_kpi_user_access.SITE_KPI_USER_ACCESS_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Site_kpi_user_access");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Site_kpi_user_access.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Site_kpi_user_access.IS_DELETED = false;
            }
            else
            {
                _Site_kpi_user_access = Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID(new Params_Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID
                {
                    SITE_KPI_USER_ACCESS_ID = i_Site_kpi_user_access.SITE_KPI_USER_ACCESS_ID
                });
            }
            i_Site_kpi_user_access.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Site_kpi_user_access.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Site_kpi_user_access.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Site_kpi_user_access_Execution)
            {
                _Stop_Edit_Site_kpi_user_access_Execution = false;
                return;
            }
            i_Site_kpi_user_access.SITE_KPI_USER_ACCESS_ID = _AppContext.Edit_Site_kpi_user_access
            (
                i_Site_kpi_user_access.SITE_KPI_USER_ACCESS_ID,
                i_Site_kpi_user_access.USER_ID,
                i_Site_kpi_user_access.SITE_ID,
                i_Site_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID,
                i_Site_kpi_user_access.ENTRY_USER_ID,
                i_Site_kpi_user_access.ENTRY_DATE,
                i_Site_kpi_user_access.LAST_UPDATE,
                i_Site_kpi_user_access.IS_DELETED,
                i_Site_kpi_user_access.OWNER_ID,
                i_Site_kpi_user_access.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Site_kpi_user_access", i_Site_kpi_user_access_json, false);
            }
        }
        #endregion
        #region Edit_Entity_kpi
        public void Edit_Entity_kpi(Entity_kpi i_Entity_kpi)
        {
            var i_Entity_kpi_json = JsonConvert.SerializeObject(i_Entity_kpi);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Entity_kpi.ENTITY_KPI_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Entity_kpi", i_Entity_kpi_json, false);
            }
            #region Body Section.
            if (i_Entity_kpi.ENTITY_KPI_ID == null || i_Entity_kpi.ENTITY_KPI_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Entity_kpi");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Entity_kpi.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Entity_kpi.IS_DELETED = false;
            }
            else
            {
                _Entity_kpi = Get_Entity_kpi_By_ENTITY_KPI_ID(new Params_Get_Entity_kpi_By_ENTITY_KPI_ID
                {
                    ENTITY_KPI_ID = i_Entity_kpi.ENTITY_KPI_ID
                });
            }
            i_Entity_kpi.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Entity_kpi.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Entity_kpi.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Entity_kpi_Execution)
            {
                _Stop_Edit_Entity_kpi_Execution = false;
                return;
            }
            i_Entity_kpi.ENTITY_KPI_ID = _AppContext.Edit_Entity_kpi
            (
                i_Entity_kpi.ENTITY_KPI_ID,
                i_Entity_kpi.ENTITY_ID,
                i_Entity_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                i_Entity_kpi.ENTRY_USER_ID,
                i_Entity_kpi.ENTRY_DATE,
                i_Entity_kpi.LAST_UPDATE,
                i_Entity_kpi.IS_DELETED,
                i_Entity_kpi.OWNER_ID,
                i_Entity_kpi.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Entity_kpi", i_Entity_kpi_json, false);
            }
        }
        #endregion
        #region Edit_Entity
        public void Edit_Entity(Entity i_Entity)
        {
            var i_Entity_json = JsonConvert.SerializeObject(i_Entity);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Entity.ENTITY_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Entity", i_Entity_json, false);
            }
            #region Body Section.
            if (i_Entity.ENTITY_ID == null || i_Entity.ENTITY_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Entity");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Entity.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Entity.IS_DELETED = false;
            }
            else
            {
                _Entity = Get_Entity_By_ENTITY_ID(new Params_Get_Entity_By_ENTITY_ID
                {
                    ENTITY_ID = i_Entity.ENTITY_ID
                });
            }
            i_Entity.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Entity.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Entity.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Entity
            if (OnPreEvent_Edit_Entity != null)
            {
                OnPreEvent_Edit_Entity(i_Entity, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Entity_Execution)
            {
                _Stop_Edit_Entity_Execution = false;
                return;
            }
            i_Entity.ENTITY_ID = _AppContext.Edit_Entity
            (
                i_Entity.ENTITY_ID,
                i_Entity.SITE_ID,
                i_Entity.AREA_ID,
                i_Entity.DISTRICT_ID,
                i_Entity.REGION_ID,
                i_Entity.TOP_LEVEL_ID,
                i_Entity.ENTITY_TYPE_SETUP_ID,
                i_Entity.NAME,
                i_Entity.NUMBER_OF_FLOORS,
                i_Entity.GLA,
                i_Entity.GLA_UNIT,
                i_Entity.AREA,
                i_Entity.UNIT,
                i_Entity.SCALE,
                i_Entity.ROTATIONX,
                i_Entity.ROTATIONY,
                i_Entity.ROTATIONZ,
                i_Entity.GLTF_LATITUDE,
                i_Entity.GLTF_LONGITUDE,
                i_Entity.CENTER_LATITUDE,
                i_Entity.CENTER_LONGITUDE,
                i_Entity.RADIUS_IN_METERS,
                i_Entity.IMAGE_URL,
                i_Entity.SOLID_GLTF_URL,
                i_Entity.POPUL_ALT_X,
                i_Entity.POPUP_ALT_Y,
                i_Entity.POPUP_ALT_Z,
                i_Entity.ENTRY_USER_ID,
                i_Entity.ENTRY_DATE,
                i_Entity.LAST_UPDATE,
                i_Entity.IS_DELETED,
                i_Entity.OWNER_ID
            );
            #region PostEvent_Edit_Entity
            if (OnPostEvent_Edit_Entity != null)
            {
                OnPostEvent_Edit_Entity(i_Entity, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Entity", i_Entity_json, false);
            }
        }
        #endregion
        #region Edit_District_kpi
        public void Edit_District_kpi(District_kpi i_District_kpi)
        {
            var i_District_kpi_json = JsonConvert.SerializeObject(i_District_kpi);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_District_kpi.DISTRICT_KPI_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_District_kpi", i_District_kpi_json, false);
            }
            #region Body Section.
            if (i_District_kpi.DISTRICT_KPI_ID == null || i_District_kpi.DISTRICT_KPI_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_District_kpi");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_District_kpi.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_District_kpi.IS_DELETED = false;
            }
            else
            {
                _District_kpi = Get_District_kpi_By_DISTRICT_KPI_ID(new Params_Get_District_kpi_By_DISTRICT_KPI_ID
                {
                    DISTRICT_KPI_ID = i_District_kpi.DISTRICT_KPI_ID
                });
            }
            i_District_kpi.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_District_kpi.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_District_kpi.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_District_kpi_Execution)
            {
                _Stop_Edit_District_kpi_Execution = false;
                return;
            }
            i_District_kpi.DISTRICT_KPI_ID = _AppContext.Edit_District_kpi
            (
                i_District_kpi.DISTRICT_KPI_ID,
                i_District_kpi.DISTRICT_ID,
                i_District_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                i_District_kpi.ENTRY_USER_ID,
                i_District_kpi.ENTRY_DATE,
                i_District_kpi.LAST_UPDATE,
                i_District_kpi.IS_DELETED,
                i_District_kpi.OWNER_ID,
                i_District_kpi.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_District_kpi", i_District_kpi_json, false);
            }
        }
        #endregion
        #region Edit_Entity_kpi_user_access
        public void Edit_Entity_kpi_user_access(Entity_kpi_user_access i_Entity_kpi_user_access)
        {
            var i_Entity_kpi_user_access_json = JsonConvert.SerializeObject(i_Entity_kpi_user_access);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Entity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Entity_kpi_user_access", i_Entity_kpi_user_access_json, false);
            }
            #region Body Section.
            if (i_Entity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID == null || i_Entity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Entity_kpi_user_access");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Entity_kpi_user_access.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Entity_kpi_user_access.IS_DELETED = false;
            }
            else
            {
                _Entity_kpi_user_access = Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID(new Params_Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID
                {
                    ENTITY_KPI_USER_ACCESS_ID = i_Entity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID
                });
            }
            i_Entity_kpi_user_access.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Entity_kpi_user_access.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Entity_kpi_user_access.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Entity_kpi_user_access_Execution)
            {
                _Stop_Edit_Entity_kpi_user_access_Execution = false;
                return;
            }
            i_Entity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID = _AppContext.Edit_Entity_kpi_user_access
            (
                i_Entity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID,
                i_Entity_kpi_user_access.USER_ID,
                i_Entity_kpi_user_access.ENTITY_ID,
                i_Entity_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID,
                i_Entity_kpi_user_access.ENTRY_USER_ID,
                i_Entity_kpi_user_access.ENTRY_DATE,
                i_Entity_kpi_user_access.LAST_UPDATE,
                i_Entity_kpi_user_access.IS_DELETED,
                i_Entity_kpi_user_access.OWNER_ID,
                i_Entity_kpi_user_access.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Entity_kpi_user_access", i_Entity_kpi_user_access_json, false);
            }
        }
        #endregion
        #region Edit_Area
        public void Edit_Area(Area i_Area)
        {
            var i_Area_json = JsonConvert.SerializeObject(i_Area);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Area.AREA_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Area", i_Area_json, false);
            }
            #region Body Section.
            if (i_Area.AREA_ID == null || i_Area.AREA_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Area");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Area.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Area.IS_DELETED = false;
            }
            else
            {
                _Area = Get_Area_By_AREA_ID(new Params_Get_Area_By_AREA_ID
                {
                    AREA_ID = i_Area.AREA_ID
                });
            }
            i_Area.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Area.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Area.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Area
            if (OnPreEvent_Edit_Area != null)
            {
                OnPreEvent_Edit_Area(i_Area, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Area_Execution)
            {
                _Stop_Edit_Area_Execution = false;
                return;
            }
            i_Area.AREA_ID = _AppContext.Edit_Area
            (
                i_Area.AREA_ID,
                i_Area.DISTRICT_ID,
                i_Area.REGION_ID,
                i_Area.TOP_LEVEL_ID,
                i_Area.NAME,
                i_Area.LOCATION,
                i_Area.AREA,
                i_Area.UNIT,
                i_Area.SCALE,
                i_Area.ROTATIONX,
                i_Area.ROTATIONY,
                i_Area.ROTATIONZ,
                i_Area.GLTF_LATITUDE,
                i_Area.GLTF_LONGITUDE,
                i_Area.CENTER_LATITUDE,
                i_Area.CENTER_LONGITUDE,
                i_Area.RADIUS_IN_METERS,
                i_Area.IMAGE_URL,
                i_Area.LOGO_URL,
                i_Area.SOLID_GLTF_URL,
                i_Area.AREA_COLOR,
                i_Area.BORDER_COLOR,
                i_Area.STUDY_ZONE_NAME,
                i_Area.ENTRY_USER_ID,
                i_Area.ENTRY_DATE,
                i_Area.LAST_UPDATE,
                i_Area.IS_DELETED,
                i_Area.OWNER_ID
            );
            #region PostEvent_Edit_Area
            if (OnPostEvent_Edit_Area != null)
            {
                OnPostEvent_Edit_Area(i_Area, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Area", i_Area_json, false);
            }
        }
        #endregion
        #region Edit_Site_kpi
        public void Edit_Site_kpi(Site_kpi i_Site_kpi)
        {
            var i_Site_kpi_json = JsonConvert.SerializeObject(i_Site_kpi);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Site_kpi.SITE_KPI_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Site_kpi", i_Site_kpi_json, false);
            }
            #region Body Section.
            if (i_Site_kpi.SITE_KPI_ID == null || i_Site_kpi.SITE_KPI_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Site_kpi");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Site_kpi.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Site_kpi.IS_DELETED = false;
            }
            else
            {
                _Site_kpi = Get_Site_kpi_By_SITE_KPI_ID(new Params_Get_Site_kpi_By_SITE_KPI_ID
                {
                    SITE_KPI_ID = i_Site_kpi.SITE_KPI_ID
                });
            }
            i_Site_kpi.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Site_kpi.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Site_kpi.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Site_kpi_Execution)
            {
                _Stop_Edit_Site_kpi_Execution = false;
                return;
            }
            i_Site_kpi.SITE_KPI_ID = _AppContext.Edit_Site_kpi
            (
                i_Site_kpi.SITE_KPI_ID,
                i_Site_kpi.SITE_ID,
                i_Site_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                i_Site_kpi.ENTRY_USER_ID,
                i_Site_kpi.ENTRY_DATE,
                i_Site_kpi.LAST_UPDATE,
                i_Site_kpi.IS_DELETED,
                i_Site_kpi.OWNER_ID,
                i_Site_kpi.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Site_kpi", i_Site_kpi_json, false);
            }
        }
        #endregion
        #region Edit_Setup_category
        public void Edit_Setup_category(Setup_category i_Setup_category)
        {
            var i_Setup_category_json = JsonConvert.SerializeObject(i_Setup_category);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Setup_category.SETUP_CATEGORY_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup_category", i_Setup_category_json, false);
            }
            #region Body Section.
            if (i_Setup_category.SETUP_CATEGORY_ID == null || i_Setup_category.SETUP_CATEGORY_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Setup_category");
            }
            if (Check_Setup_category_Uniqueness_Violation(i_Setup_category))
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0000).Replace("%1", "Setup_category"));
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Setup_category.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Setup_category.IS_DELETED = false;
            }
            else
            {
                _Setup_category = Get_Setup_category_By_SETUP_CATEGORY_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_ID
                {
                    SETUP_CATEGORY_ID = i_Setup_category.SETUP_CATEGORY_ID
                });
            }
            i_Setup_category.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Setup_category.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Setup_category.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Setup_category
            if (OnPreEvent_Edit_Setup_category != null)
            {
                OnPreEvent_Edit_Setup_category(i_Setup_category, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Setup_category_Execution)
            {
                _Stop_Edit_Setup_category_Execution = false;
                return;
            }
            i_Setup_category.SETUP_CATEGORY_ID = _AppContext.Edit_Setup_category
            (
                i_Setup_category.SETUP_CATEGORY_ID,
                i_Setup_category.SETUP_CATEGORY_NAME,
                i_Setup_category.DESCRIPTION,
                i_Setup_category.ENTRY_USER_ID,
                i_Setup_category.ENTRY_DATE,
                i_Setup_category.LAST_UPDATE,
                i_Setup_category.IS_DELETED,
                i_Setup_category.OWNER_ID
            );
            #region PostEvent_Edit_Setup_category
            if (OnPostEvent_Edit_Setup_category != null)
            {
                OnPostEvent_Edit_Setup_category(i_Setup_category, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup_category", i_Setup_category_json, false);
            }
        }
        #endregion
        #region Edit_Setup
        public void Edit_Setup(Setup i_Setup)
        {
            var i_Setup_json = JsonConvert.SerializeObject(i_Setup);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Setup.SETUP_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup", i_Setup_json, false);
            }
            #region Body Section.
            if (i_Setup.SETUP_ID == null || i_Setup.SETUP_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Setup");
            }
            if (Check_Setup_Uniqueness_Violation(i_Setup))
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0000).Replace("%1", "Setup"));
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Setup.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Setup.IS_DELETED = false;
            }
            else
            {
                _Setup = Get_Setup_By_SETUP_ID(new Params_Get_Setup_By_SETUP_ID
                {
                    SETUP_ID = i_Setup.SETUP_ID
                });
            }
            i_Setup.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Setup.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Setup.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Setup_Execution)
            {
                _Stop_Edit_Setup_Execution = false;
                return;
            }
            i_Setup.SETUP_ID = _AppContext.Edit_Setup
            (
                i_Setup.SETUP_ID,
                i_Setup.SETUP_CATEGORY_ID,
                i_Setup.IS_SYSTEM,
                i_Setup.IS_DELETEABLE,
                i_Setup.IS_UPDATEABLE,
                i_Setup.IS_DELETED,
                i_Setup.IS_VISIBLE,
                i_Setup.DISPLAY_ORDER,
                i_Setup.VALUE,
                i_Setup.DESCRIPTION,
                i_Setup.ENTRY_USER_ID,
                i_Setup.ENTRY_DATE,
                i_Setup.LAST_UPDATE,
                i_Setup.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup", i_Setup_json, false);
            }
        }
        #endregion
        #region Edit_Area_kpi
        public void Edit_Area_kpi(Area_kpi i_Area_kpi)
        {
            var i_Area_kpi_json = JsonConvert.SerializeObject(i_Area_kpi);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Area_kpi.AREA_KPI_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Area_kpi", i_Area_kpi_json, false);
            }
            #region Body Section.
            if (i_Area_kpi.AREA_KPI_ID == null || i_Area_kpi.AREA_KPI_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Area_kpi");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Area_kpi.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Area_kpi.IS_DELETED = false;
            }
            else
            {
                _Area_kpi = Get_Area_kpi_By_AREA_KPI_ID(new Params_Get_Area_kpi_By_AREA_KPI_ID
                {
                    AREA_KPI_ID = i_Area_kpi.AREA_KPI_ID
                });
            }
            i_Area_kpi.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Area_kpi.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Area_kpi.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Area_kpi_Execution)
            {
                _Stop_Edit_Area_kpi_Execution = false;
                return;
            }
            i_Area_kpi.AREA_KPI_ID = _AppContext.Edit_Area_kpi
            (
                i_Area_kpi.AREA_KPI_ID,
                i_Area_kpi.AREA_ID,
                i_Area_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                i_Area_kpi.ENTRY_USER_ID,
                i_Area_kpi.ENTRY_DATE,
                i_Area_kpi.LAST_UPDATE,
                i_Area_kpi.IS_DELETED,
                i_Area_kpi.OWNER_ID,
                i_Area_kpi.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Area_kpi", i_Area_kpi_json, false);
            }
        }
        #endregion
        #region Edit_Space_asset
        public void Edit_Space_asset(Space_asset i_Space_asset)
        {
            var i_Space_asset_json = JsonConvert.SerializeObject(i_Space_asset);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Space_asset.SPACE_ASSET_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Space_asset", i_Space_asset_json, false);
            }
            #region Body Section.
            if (i_Space_asset.SPACE_ASSET_ID == null || i_Space_asset.SPACE_ASSET_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Space_asset");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Space_asset.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Space_asset.IS_DELETED = false;
            }
            else
            {
                _Space_asset = Get_Space_asset_By_SPACE_ASSET_ID(new Params_Get_Space_asset_By_SPACE_ASSET_ID
                {
                    SPACE_ASSET_ID = i_Space_asset.SPACE_ASSET_ID
                });
            }
            i_Space_asset.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Space_asset.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Space_asset.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Space_asset_Execution)
            {
                _Stop_Edit_Space_asset_Execution = false;
                return;
            }
            i_Space_asset.SPACE_ASSET_ID = _AppContext.Edit_Space_asset
            (
                i_Space_asset.SPACE_ASSET_ID,
                i_Space_asset.SPACE_ID,
                i_Space_asset.ASSET_ID,
                i_Space_asset.EXTERNAL_ID,
                i_Space_asset.IS_MERAKI_WIFI_SIGNAL,
                i_Space_asset.CUSTOM_NAME,
                i_Space_asset.POSITION_X,
                i_Space_asset.POSITION_Y,
                i_Space_asset.POSITION_Z,
                i_Space_asset.SCALE_MULTIPLIER,
                i_Space_asset.ROTATE_X,
                i_Space_asset.ROTATE_Y,
                i_Space_asset.ROTATE_Z,
                i_Space_asset.ASSET_ICON,
                i_Space_asset.ENTRY_USER_ID,
                i_Space_asset.ENTRY_DATE,
                i_Space_asset.LAST_UPDATE,
                i_Space_asset.IS_DELETED,
                i_Space_asset.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Space_asset", i_Space_asset_json, false);
            }
        }
        #endregion
        #region Edit_District
        public void Edit_District(District i_District)
        {
            var i_District_json = JsonConvert.SerializeObject(i_District);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_District.DISTRICT_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_District", i_District_json, false);
            }
            #region Body Section.
            if (i_District.DISTRICT_ID == null || i_District.DISTRICT_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_District");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_District.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_District.IS_DELETED = false;
            }
            else
            {
                _District = Get_District_By_DISTRICT_ID(new Params_Get_District_By_DISTRICT_ID
                {
                    DISTRICT_ID = i_District.DISTRICT_ID
                });
            }
            i_District.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_District.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_District.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_District
            if (OnPreEvent_Edit_District != null)
            {
                OnPreEvent_Edit_District(i_District, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_District_Execution)
            {
                _Stop_Edit_District_Execution = false;
                return;
            }
            i_District.DISTRICT_ID = _AppContext.Edit_District
            (
                i_District.DISTRICT_ID,
                i_District.REGION_ID,
                i_District.TOP_LEVEL_ID,
                i_District.NAME,
                i_District.LOCATION,
                i_District.AREA,
                i_District.UNIT,
                i_District.SCALE,
                i_District.ROTATIONX,
                i_District.ROTATIONY,
                i_District.ROTATIONZ,
                i_District.GLTF_LATITUDE,
                i_District.GLTF_LONGITUDE,
                i_District.CENTER_LATITUDE,
                i_District.CENTER_LONGITUDE,
                i_District.RADIUS_IN_METERS,
                i_District.IMAGE_URL,
                i_District.LOGO_URL,
                i_District.SOLID_GLTF_URL,
                i_District.AREA_COLOR,
                i_District.BORDER_COLOR,
                i_District.STUDY_ZONE_NAME,
                i_District.ENTRY_USER_ID,
                i_District.ENTRY_DATE,
                i_District.LAST_UPDATE,
                i_District.IS_DELETED,
                i_District.OWNER_ID
            );
            #region PostEvent_Edit_District
            if (OnPostEvent_Edit_District != null)
            {
                OnPostEvent_Edit_District(i_District, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_District", i_District_json, false);
            }
        }
        #endregion
        #region Edit_Organization_data_source_kpi
        public void Edit_Organization_data_source_kpi(Organization_data_source_kpi i_Organization_data_source_kpi)
        {
            var i_Organization_data_source_kpi_json = JsonConvert.SerializeObject(i_Organization_data_source_kpi);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_data_source_kpi", i_Organization_data_source_kpi_json, false);
            }
            #region Body Section.
            if (i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == null || i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Organization_data_source_kpi");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Organization_data_source_kpi.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Organization_data_source_kpi.IS_DELETED = false;
            }
            else
            {
                _Organization_data_source_kpi = Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(new Params_Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
                {
                    ORGANIZATION_DATA_SOURCE_KPI_ID = i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID
                });
            }
            i_Organization_data_source_kpi.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Organization_data_source_kpi.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Organization_data_source_kpi.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Organization_data_source_kpi_Execution)
            {
                _Stop_Edit_Organization_data_source_kpi_Execution = false;
                return;
            }
            i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID = _AppContext.Edit_Organization_data_source_kpi
            (
                i_Organization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID,
                i_Organization_data_source_kpi.DATA_SOURCE_ID,
                i_Organization_data_source_kpi.KPI_ID,
                i_Organization_data_source_kpi.ORGANIZATION_ID,
                i_Organization_data_source_kpi.ENTRY_USER_ID,
                i_Organization_data_source_kpi.ENTRY_DATE,
                i_Organization_data_source_kpi.LAST_UPDATE,
                i_Organization_data_source_kpi.IS_DELETED,
                i_Organization_data_source_kpi.OWNER_ID,
                i_Organization_data_source_kpi.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_data_source_kpi", i_Organization_data_source_kpi_json, false);
            }
        }
        #endregion
        #region Edit_Floor
        public void Edit_Floor(Floor i_Floor)
        {
            var i_Floor_json = JsonConvert.SerializeObject(i_Floor);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Floor.FLOOR_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Floor", i_Floor_json, false);
            }
            #region Body Section.
            if (i_Floor.FLOOR_ID == null || i_Floor.FLOOR_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Floor");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Floor.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Floor.IS_DELETED = false;
            }
            else
            {
                _Floor = Get_Floor_By_FLOOR_ID(new Params_Get_Floor_By_FLOOR_ID
                {
                    FLOOR_ID = i_Floor.FLOOR_ID
                });
            }
            i_Floor.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Floor.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Floor.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Floor_Execution)
            {
                _Stop_Edit_Floor_Execution = false;
                return;
            }
            i_Floor.FLOOR_ID = _AppContext.Edit_Floor
            (
                i_Floor.FLOOR_ID,
                i_Floor.ENTITY_ID,
                i_Floor.FLOOR_NUMBER,
                i_Floor.SHELL_GLTF_URL,
                i_Floor.CLIPPED_GLTF_URL,
                i_Floor.ADVANCED_GLTF_URL,
                i_Floor.AREA,
                i_Floor.UNIT,
                i_Floor.NAME,
                i_Floor.ENTRY_USER_ID,
                i_Floor.ENTRY_DATE,
                i_Floor.LAST_UPDATE,
                i_Floor.IS_DELETED,
                i_Floor.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Floor", i_Floor_json, false);
            }
        }
        #endregion
        #region Edit_District_kpi_user_access
        public void Edit_District_kpi_user_access(District_kpi_user_access i_District_kpi_user_access)
        {
            var i_District_kpi_user_access_json = JsonConvert.SerializeObject(i_District_kpi_user_access);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_District_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_District_kpi_user_access", i_District_kpi_user_access_json, false);
            }
            #region Body Section.
            if (i_District_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID == null || i_District_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_District_kpi_user_access");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_District_kpi_user_access.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_District_kpi_user_access.IS_DELETED = false;
            }
            else
            {
                _District_kpi_user_access = Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID(new Params_Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID
                {
                    DISTRICT_KPI_USER_ACCESS_ID = i_District_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID
                });
            }
            i_District_kpi_user_access.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_District_kpi_user_access.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_District_kpi_user_access.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_District_kpi_user_access_Execution)
            {
                _Stop_Edit_District_kpi_user_access_Execution = false;
                return;
            }
            i_District_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID = _AppContext.Edit_District_kpi_user_access
            (
                i_District_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID,
                i_District_kpi_user_access.USER_ID,
                i_District_kpi_user_access.DISTRICT_ID,
                i_District_kpi_user_access.ORGANIZATION_DATA_SOURCE_KPI_ID,
                i_District_kpi_user_access.ENTRY_USER_ID,
                i_District_kpi_user_access.ENTRY_DATE,
                i_District_kpi_user_access.LAST_UPDATE,
                i_District_kpi_user_access.IS_DELETED,
                i_District_kpi_user_access.OWNER_ID,
                i_District_kpi_user_access.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_District_kpi_user_access", i_District_kpi_user_access_json, false);
            }
        }
        #endregion
        #region Edit_User
        public void Edit_User(User i_User)
        {
            var i_User_json = JsonConvert.SerializeObject(i_User);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_User.USER_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_User", i_User_json, false);
            }
            #region Body Section.
            if (i_User.USER_ID == null || i_User.USER_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_User");
            }
            if (Check_User_Uniqueness_Violation(i_User))
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0000).Replace("%1", "User"));
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_User.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_User.IS_DELETED = false;
            }
            else
            {
                _User = Get_User_By_USER_ID(new Params_Get_User_By_USER_ID
                {
                    USER_ID = i_User.USER_ID
                });
            }
            i_User.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_User.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_User.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_User
            if (OnPreEvent_Edit_User != null)
            {
                OnPreEvent_Edit_User(i_User, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_User_Execution)
            {
                _Stop_Edit_User_Execution = false;
                return;
            }
            i_User.USER_ID = _AppContext.Edit_User
            (
                i_User.USER_ID,
                i_User.ORGANIZATION_ID,
                i_User.USER_TYPE_SETUP_ID,
                i_User.OWNER_ID,
                i_User.FIRST_NAME,
                i_User.LAST_NAME,
                i_User.USERNAME,
                i_User.PASSWORD,
                i_User.EMAIL,
                i_User.PHONE_NUMBER,
                i_User.IMAGE_URL,
                i_User.IS_ACTIVE,
                i_User.IS_DELETED,
                i_User.IS_RECEIVE_EMAIL,
                i_User.DATA_RETENTION_PERIOD,
                i_User.USER_DISTRICTNEX_WALKTHROUGH,
                i_User.USER_ADMIN_WALKTHROUGH,
                i_User.DATE_DELETED,
                i_User.ENTRY_DATE,
                i_User.ENTRY_USER_ID,
                i_User.LAST_UPDATE
            );
            #region PostEvent_Edit_User
            if (OnPostEvent_Edit_User != null)
            {
                OnPostEvent_Edit_User(ref i_User, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_User", i_User_json, false);
            }
        }
        #endregion
        #region Edit_Space
        public void Edit_Space(Space i_Space)
        {
            var i_Space_json = JsonConvert.SerializeObject(i_Space);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Space.SPACE_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Space", i_Space_json, false);
            }
            #region Body Section.
            if (i_Space.SPACE_ID == null || i_Space.SPACE_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Space");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Space.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Space.IS_DELETED = false;
            }
            else
            {
                _Space = Get_Space_By_SPACE_ID(new Params_Get_Space_By_SPACE_ID
                {
                    SPACE_ID = i_Space.SPACE_ID
                });
            }
            i_Space.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Space.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Space.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Space
            if (OnPreEvent_Edit_Space != null)
            {
                OnPreEvent_Edit_Space(i_Space, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Space_Execution)
            {
                _Stop_Edit_Space_Execution = false;
                return;
            }
            i_Space.SPACE_ID = _AppContext.Edit_Space
            (
                i_Space.SPACE_ID,
                i_Space.FLOOR_ID,
                i_Space.NAME,
                i_Space.AREA,
                i_Space.UNIT,
                i_Space.OCCUPANT_LOAD_FACTOR,
                i_Space.ENTRY_USER_ID,
                i_Space.ENTRY_DATE,
                i_Space.LAST_UPDATE,
                i_Space.IS_DELETED,
                i_Space.OWNER_ID
            );
            #region PostEvent_Edit_Space
            if (OnPostEvent_Edit_Space != null)
            {
                OnPostEvent_Edit_Space(i_Space, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Space", i_Space_json, false);
            }
        }
        #endregion
        #region Edit_Site
        public void Edit_Site(Site i_Site)
        {
            var i_Site_json = JsonConvert.SerializeObject(i_Site);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Site.SITE_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Site", i_Site_json, false);
            }
            #region Body Section.
            if (i_Site.SITE_ID == null || i_Site.SITE_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Site");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Site.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Site.IS_DELETED = false;
            }
            else
            {
                _Site = Get_Site_By_SITE_ID(new Params_Get_Site_By_SITE_ID
                {
                    SITE_ID = i_Site.SITE_ID
                });
            }
            i_Site.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Site.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Site.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Site
            if (OnPreEvent_Edit_Site != null)
            {
                OnPreEvent_Edit_Site(i_Site, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Site_Execution)
            {
                _Stop_Edit_Site_Execution = false;
                return;
            }
            i_Site.SITE_ID = _AppContext.Edit_Site
            (
                i_Site.SITE_ID,
                i_Site.AREA_ID,
                i_Site.DISTRICT_ID,
                i_Site.REGION_ID,
                i_Site.TOP_LEVEL_ID,
                i_Site.NAME,
                i_Site.LOCATION,
                i_Site.AREA,
                i_Site.UNIT,
                i_Site.SCALE,
                i_Site.ROTATIONX,
                i_Site.ROTATIONY,
                i_Site.ROTATIONZ,
                i_Site.GLTF_LATITUDE,
                i_Site.GLTF_LONGITUDE,
                i_Site.CENTER_LATITUDE,
                i_Site.CENTER_LONGITUDE,
                i_Site.RADIUS_IN_METERS,
                i_Site.IMAGE_URL,
                i_Site.LOGO_URL,
                i_Site.SOLID_GLTF_URL,
                i_Site.AREA_COLOR,
                i_Site.BORDER_COLOR,
                i_Site.STUDY_ZONE_NAME,
                i_Site.ENTRY_USER_ID,
                i_Site.ENTRY_DATE,
                i_Site.LAST_UPDATE,
                i_Site.IS_DELETED,
                i_Site.OWNER_ID
            );
            #region PostEvent_Edit_Site
            if (OnPostEvent_Edit_Site != null)
            {
                OnPostEvent_Edit_Site(i_Site, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Site", i_Site_json, false);
            }
        }
        #endregion
        #region Edit_Kpi_List
        public void Edit_Kpi_List(Params_Edit_Kpi_List i_Params_Edit_Kpi_List)
        {
            var i_Params_Edit_Kpi_List_json = JsonConvert.SerializeObject(i_Params_Edit_Kpi_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Kpi_List", i_Params_Edit_Kpi_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Kpi_List.List_To_Edit != null)
            {
                i_Params_Edit_Kpi_List.List_Failed_Edit = new List<Kpi>();
                if (i_Params_Edit_Kpi_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oKpi in i_Params_Edit_Kpi_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Kpi(oKpi);
                        }
                        catch
                        {
                            i_Params_Edit_Kpi_List.List_Failed_Edit.Add(oKpi);
                        }
                    }
                }
                i_Params_Edit_Kpi_List.List_To_Edit = i_Params_Edit_Kpi_List.List_To_Edit.Except(i_Params_Edit_Kpi_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Kpi_List.List_To_Delete != null)
            {
                i_Params_Edit_Kpi_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Kpi_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Kpi_ID in i_Params_Edit_Kpi_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Kpi(new Params_Delete_Kpi()
                            {
                                KPI_ID = Kpi_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Kpi_List.List_Failed_Delete.Add(Kpi_ID);
                        }
                    }
                }
                i_Params_Edit_Kpi_List.List_To_Delete = i_Params_Edit_Kpi_List.List_To_Delete.Except(i_Params_Edit_Kpi_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Kpi_List", i_Params_Edit_Kpi_List_json, false);
            }
        }
        #endregion
        #region Edit_Asset_List
        public void Edit_Asset_List(Params_Edit_Asset_List i_Params_Edit_Asset_List)
        {
            var i_Params_Edit_Asset_List_json = JsonConvert.SerializeObject(i_Params_Edit_Asset_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Asset_List", i_Params_Edit_Asset_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Asset_List.List_To_Edit != null)
            {
                i_Params_Edit_Asset_List.List_Failed_Edit = new List<Asset>();
                if (i_Params_Edit_Asset_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oAsset in i_Params_Edit_Asset_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Asset(oAsset);
                        }
                        catch
                        {
                            i_Params_Edit_Asset_List.List_Failed_Edit.Add(oAsset);
                        }
                    }
                }
                i_Params_Edit_Asset_List.List_To_Edit = i_Params_Edit_Asset_List.List_To_Edit.Except(i_Params_Edit_Asset_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Asset_List.List_To_Delete != null)
            {
                i_Params_Edit_Asset_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Asset_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Asset_ID in i_Params_Edit_Asset_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Asset(new Params_Delete_Asset()
                            {
                                ASSET_ID = Asset_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Asset_List.List_Failed_Delete.Add(Asset_ID);
                        }
                    }
                }
                i_Params_Edit_Asset_List.List_To_Delete = i_Params_Edit_Asset_List.List_To_Delete.Except(i_Params_Edit_Asset_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Asset_List", i_Params_Edit_Asset_List_json, false);
            }
        }
        #endregion
        #region Edit_Ext_study_zone_List
        public void Edit_Ext_study_zone_List(Params_Edit_Ext_study_zone_List i_Params_Edit_Ext_study_zone_List)
        {
            var i_Params_Edit_Ext_study_zone_List_json = JsonConvert.SerializeObject(i_Params_Edit_Ext_study_zone_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Ext_study_zone_List", i_Params_Edit_Ext_study_zone_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Ext_study_zone_List.List_To_Edit != null)
            {
                i_Params_Edit_Ext_study_zone_List.List_Failed_Edit = new List<Ext_study_zone>();
                if (i_Params_Edit_Ext_study_zone_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oExt_study_zone in i_Params_Edit_Ext_study_zone_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Ext_study_zone(oExt_study_zone);
                        }
                        catch
                        {
                            i_Params_Edit_Ext_study_zone_List.List_Failed_Edit.Add(oExt_study_zone);
                        }
                    }
                }
                i_Params_Edit_Ext_study_zone_List.List_To_Edit = i_Params_Edit_Ext_study_zone_List.List_To_Edit.Except(i_Params_Edit_Ext_study_zone_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Ext_study_zone_List.List_To_Delete != null)
            {
                i_Params_Edit_Ext_study_zone_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Ext_study_zone_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Ext_study_zone_ID in i_Params_Edit_Ext_study_zone_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Ext_study_zone(new Params_Delete_Ext_study_zone()
                            {
                                EXT_STUDY_ZONE_ID = Ext_study_zone_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Ext_study_zone_List.List_Failed_Delete.Add(Ext_study_zone_ID);
                        }
                    }
                }
                i_Params_Edit_Ext_study_zone_List.List_To_Delete = i_Params_Edit_Ext_study_zone_List.List_To_Delete.Except(i_Params_Edit_Ext_study_zone_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Ext_study_zone_List", i_Params_Edit_Ext_study_zone_List_json, false);
            }
        }
        #endregion
        #region Edit_Area_kpi_user_access_List
        public void Edit_Area_kpi_user_access_List(Params_Edit_Area_kpi_user_access_List i_Params_Edit_Area_kpi_user_access_List)
        {
            var i_Params_Edit_Area_kpi_user_access_List_json = JsonConvert.SerializeObject(i_Params_Edit_Area_kpi_user_access_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Area_kpi_user_access_List", i_Params_Edit_Area_kpi_user_access_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Area_kpi_user_access_List.List_To_Edit != null)
            {
                i_Params_Edit_Area_kpi_user_access_List.List_Failed_Edit = new List<Area_kpi_user_access>();
                if (i_Params_Edit_Area_kpi_user_access_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oArea_kpi_user_access in i_Params_Edit_Area_kpi_user_access_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Area_kpi_user_access(oArea_kpi_user_access);
                        }
                        catch
                        {
                            i_Params_Edit_Area_kpi_user_access_List.List_Failed_Edit.Add(oArea_kpi_user_access);
                        }
                    }
                }
                i_Params_Edit_Area_kpi_user_access_List.List_To_Edit = i_Params_Edit_Area_kpi_user_access_List.List_To_Edit.Except(i_Params_Edit_Area_kpi_user_access_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Area_kpi_user_access_List.List_To_Delete != null)
            {
                i_Params_Edit_Area_kpi_user_access_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Area_kpi_user_access_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Area_kpi_user_access_ID in i_Params_Edit_Area_kpi_user_access_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Area_kpi_user_access(new Params_Delete_Area_kpi_user_access()
                            {
                                AREA_KPI_USER_ACCESS_ID = Area_kpi_user_access_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Area_kpi_user_access_List.List_Failed_Delete.Add(Area_kpi_user_access_ID);
                        }
                    }
                }
                i_Params_Edit_Area_kpi_user_access_List.List_To_Delete = i_Params_Edit_Area_kpi_user_access_List.List_To_Delete.Except(i_Params_Edit_Area_kpi_user_access_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Area_kpi_user_access_List", i_Params_Edit_Area_kpi_user_access_List_json, false);
            }
        }
        #endregion
        #region Edit_Site_kpi_user_access_List
        public void Edit_Site_kpi_user_access_List(Params_Edit_Site_kpi_user_access_List i_Params_Edit_Site_kpi_user_access_List)
        {
            var i_Params_Edit_Site_kpi_user_access_List_json = JsonConvert.SerializeObject(i_Params_Edit_Site_kpi_user_access_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Site_kpi_user_access_List", i_Params_Edit_Site_kpi_user_access_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Site_kpi_user_access_List.List_To_Edit != null)
            {
                i_Params_Edit_Site_kpi_user_access_List.List_Failed_Edit = new List<Site_kpi_user_access>();
                if (i_Params_Edit_Site_kpi_user_access_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSite_kpi_user_access in i_Params_Edit_Site_kpi_user_access_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Site_kpi_user_access(oSite_kpi_user_access);
                        }
                        catch
                        {
                            i_Params_Edit_Site_kpi_user_access_List.List_Failed_Edit.Add(oSite_kpi_user_access);
                        }
                    }
                }
                i_Params_Edit_Site_kpi_user_access_List.List_To_Edit = i_Params_Edit_Site_kpi_user_access_List.List_To_Edit.Except(i_Params_Edit_Site_kpi_user_access_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Site_kpi_user_access_List.List_To_Delete != null)
            {
                i_Params_Edit_Site_kpi_user_access_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Site_kpi_user_access_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Site_kpi_user_access_ID in i_Params_Edit_Site_kpi_user_access_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Site_kpi_user_access(new Params_Delete_Site_kpi_user_access()
                            {
                                SITE_KPI_USER_ACCESS_ID = Site_kpi_user_access_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Site_kpi_user_access_List.List_Failed_Delete.Add(Site_kpi_user_access_ID);
                        }
                    }
                }
                i_Params_Edit_Site_kpi_user_access_List.List_To_Delete = i_Params_Edit_Site_kpi_user_access_List.List_To_Delete.Except(i_Params_Edit_Site_kpi_user_access_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Site_kpi_user_access_List", i_Params_Edit_Site_kpi_user_access_List_json, false);
            }
        }
        #endregion
        #region Edit_Entity_kpi_List
        public void Edit_Entity_kpi_List(Params_Edit_Entity_kpi_List i_Params_Edit_Entity_kpi_List)
        {
            var i_Params_Edit_Entity_kpi_List_json = JsonConvert.SerializeObject(i_Params_Edit_Entity_kpi_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Entity_kpi_List", i_Params_Edit_Entity_kpi_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Entity_kpi_List.List_To_Edit != null)
            {
                i_Params_Edit_Entity_kpi_List.List_Failed_Edit = new List<Entity_kpi>();
                if (i_Params_Edit_Entity_kpi_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oEntity_kpi in i_Params_Edit_Entity_kpi_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Entity_kpi(oEntity_kpi);
                        }
                        catch
                        {
                            i_Params_Edit_Entity_kpi_List.List_Failed_Edit.Add(oEntity_kpi);
                        }
                    }
                }
                i_Params_Edit_Entity_kpi_List.List_To_Edit = i_Params_Edit_Entity_kpi_List.List_To_Edit.Except(i_Params_Edit_Entity_kpi_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Entity_kpi_List.List_To_Delete != null)
            {
                i_Params_Edit_Entity_kpi_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Entity_kpi_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Entity_kpi_ID in i_Params_Edit_Entity_kpi_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Entity_kpi(new Params_Delete_Entity_kpi()
                            {
                                ENTITY_KPI_ID = Entity_kpi_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Entity_kpi_List.List_Failed_Delete.Add(Entity_kpi_ID);
                        }
                    }
                }
                i_Params_Edit_Entity_kpi_List.List_To_Delete = i_Params_Edit_Entity_kpi_List.List_To_Delete.Except(i_Params_Edit_Entity_kpi_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Entity_kpi_List", i_Params_Edit_Entity_kpi_List_json, false);
            }
        }
        #endregion
        #region Edit_Entity_List
        public void Edit_Entity_List(Params_Edit_Entity_List i_Params_Edit_Entity_List)
        {
            var i_Params_Edit_Entity_List_json = JsonConvert.SerializeObject(i_Params_Edit_Entity_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Entity_List", i_Params_Edit_Entity_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Entity_List.List_To_Edit != null)
            {
                i_Params_Edit_Entity_List.List_Failed_Edit = new List<Entity>();
                if (i_Params_Edit_Entity_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oEntity in i_Params_Edit_Entity_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Entity(oEntity);
                        }
                        catch
                        {
                            i_Params_Edit_Entity_List.List_Failed_Edit.Add(oEntity);
                        }
                    }
                }
                i_Params_Edit_Entity_List.List_To_Edit = i_Params_Edit_Entity_List.List_To_Edit.Except(i_Params_Edit_Entity_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Entity_List.List_To_Delete != null)
            {
                i_Params_Edit_Entity_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Entity_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Entity_ID in i_Params_Edit_Entity_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Entity(new Params_Delete_Entity()
                            {
                                ENTITY_ID = Entity_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Entity_List.List_Failed_Delete.Add(Entity_ID);
                        }
                    }
                }
                i_Params_Edit_Entity_List.List_To_Delete = i_Params_Edit_Entity_List.List_To_Delete.Except(i_Params_Edit_Entity_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Entity_List", i_Params_Edit_Entity_List_json, false);
            }
        }
        #endregion
        #region Edit_District_kpi_List
        public void Edit_District_kpi_List(Params_Edit_District_kpi_List i_Params_Edit_District_kpi_List)
        {
            var i_Params_Edit_District_kpi_List_json = JsonConvert.SerializeObject(i_Params_Edit_District_kpi_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_District_kpi_List", i_Params_Edit_District_kpi_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_District_kpi_List.List_To_Edit != null)
            {
                i_Params_Edit_District_kpi_List.List_Failed_Edit = new List<District_kpi>();
                if (i_Params_Edit_District_kpi_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oDistrict_kpi in i_Params_Edit_District_kpi_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_District_kpi(oDistrict_kpi);
                        }
                        catch
                        {
                            i_Params_Edit_District_kpi_List.List_Failed_Edit.Add(oDistrict_kpi);
                        }
                    }
                }
                i_Params_Edit_District_kpi_List.List_To_Edit = i_Params_Edit_District_kpi_List.List_To_Edit.Except(i_Params_Edit_District_kpi_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_District_kpi_List.List_To_Delete != null)
            {
                i_Params_Edit_District_kpi_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_District_kpi_List.List_To_Delete.Count() > 0)
                {
                    foreach (var District_kpi_ID in i_Params_Edit_District_kpi_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_District_kpi(new Params_Delete_District_kpi()
                            {
                                DISTRICT_KPI_ID = District_kpi_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_District_kpi_List.List_Failed_Delete.Add(District_kpi_ID);
                        }
                    }
                }
                i_Params_Edit_District_kpi_List.List_To_Delete = i_Params_Edit_District_kpi_List.List_To_Delete.Except(i_Params_Edit_District_kpi_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_District_kpi_List", i_Params_Edit_District_kpi_List_json, false);
            }
        }
        #endregion
        #region Edit_Entity_kpi_user_access_List
        public void Edit_Entity_kpi_user_access_List(Params_Edit_Entity_kpi_user_access_List i_Params_Edit_Entity_kpi_user_access_List)
        {
            var i_Params_Edit_Entity_kpi_user_access_List_json = JsonConvert.SerializeObject(i_Params_Edit_Entity_kpi_user_access_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Entity_kpi_user_access_List", i_Params_Edit_Entity_kpi_user_access_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Entity_kpi_user_access_List.List_To_Edit != null)
            {
                i_Params_Edit_Entity_kpi_user_access_List.List_Failed_Edit = new List<Entity_kpi_user_access>();
                if (i_Params_Edit_Entity_kpi_user_access_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oEntity_kpi_user_access in i_Params_Edit_Entity_kpi_user_access_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Entity_kpi_user_access(oEntity_kpi_user_access);
                        }
                        catch
                        {
                            i_Params_Edit_Entity_kpi_user_access_List.List_Failed_Edit.Add(oEntity_kpi_user_access);
                        }
                    }
                }
                i_Params_Edit_Entity_kpi_user_access_List.List_To_Edit = i_Params_Edit_Entity_kpi_user_access_List.List_To_Edit.Except(i_Params_Edit_Entity_kpi_user_access_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Entity_kpi_user_access_List.List_To_Delete != null)
            {
                i_Params_Edit_Entity_kpi_user_access_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Entity_kpi_user_access_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Entity_kpi_user_access_ID in i_Params_Edit_Entity_kpi_user_access_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Entity_kpi_user_access(new Params_Delete_Entity_kpi_user_access()
                            {
                                ENTITY_KPI_USER_ACCESS_ID = Entity_kpi_user_access_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Entity_kpi_user_access_List.List_Failed_Delete.Add(Entity_kpi_user_access_ID);
                        }
                    }
                }
                i_Params_Edit_Entity_kpi_user_access_List.List_To_Delete = i_Params_Edit_Entity_kpi_user_access_List.List_To_Delete.Except(i_Params_Edit_Entity_kpi_user_access_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Entity_kpi_user_access_List", i_Params_Edit_Entity_kpi_user_access_List_json, false);
            }
        }
        #endregion
        #region Edit_Area_List
        public void Edit_Area_List(Params_Edit_Area_List i_Params_Edit_Area_List)
        {
            var i_Params_Edit_Area_List_json = JsonConvert.SerializeObject(i_Params_Edit_Area_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Area_List", i_Params_Edit_Area_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Area_List.List_To_Edit != null)
            {
                i_Params_Edit_Area_List.List_Failed_Edit = new List<Area>();
                if (i_Params_Edit_Area_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oArea in i_Params_Edit_Area_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Area(oArea);
                        }
                        catch
                        {
                            i_Params_Edit_Area_List.List_Failed_Edit.Add(oArea);
                        }
                    }
                }
                i_Params_Edit_Area_List.List_To_Edit = i_Params_Edit_Area_List.List_To_Edit.Except(i_Params_Edit_Area_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Area_List.List_To_Delete != null)
            {
                i_Params_Edit_Area_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Area_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Area_ID in i_Params_Edit_Area_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Area(new Params_Delete_Area()
                            {
                                AREA_ID = Area_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Area_List.List_Failed_Delete.Add(Area_ID);
                        }
                    }
                }
                i_Params_Edit_Area_List.List_To_Delete = i_Params_Edit_Area_List.List_To_Delete.Except(i_Params_Edit_Area_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Area_List", i_Params_Edit_Area_List_json, false);
            }
        }
        #endregion
        #region Edit_Site_kpi_List
        public void Edit_Site_kpi_List(Params_Edit_Site_kpi_List i_Params_Edit_Site_kpi_List)
        {
            var i_Params_Edit_Site_kpi_List_json = JsonConvert.SerializeObject(i_Params_Edit_Site_kpi_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Site_kpi_List", i_Params_Edit_Site_kpi_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Site_kpi_List.List_To_Edit != null)
            {
                i_Params_Edit_Site_kpi_List.List_Failed_Edit = new List<Site_kpi>();
                if (i_Params_Edit_Site_kpi_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSite_kpi in i_Params_Edit_Site_kpi_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Site_kpi(oSite_kpi);
                        }
                        catch
                        {
                            i_Params_Edit_Site_kpi_List.List_Failed_Edit.Add(oSite_kpi);
                        }
                    }
                }
                i_Params_Edit_Site_kpi_List.List_To_Edit = i_Params_Edit_Site_kpi_List.List_To_Edit.Except(i_Params_Edit_Site_kpi_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Site_kpi_List.List_To_Delete != null)
            {
                i_Params_Edit_Site_kpi_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Site_kpi_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Site_kpi_ID in i_Params_Edit_Site_kpi_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Site_kpi(new Params_Delete_Site_kpi()
                            {
                                SITE_KPI_ID = Site_kpi_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Site_kpi_List.List_Failed_Delete.Add(Site_kpi_ID);
                        }
                    }
                }
                i_Params_Edit_Site_kpi_List.List_To_Delete = i_Params_Edit_Site_kpi_List.List_To_Delete.Except(i_Params_Edit_Site_kpi_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Site_kpi_List", i_Params_Edit_Site_kpi_List_json, false);
            }
        }
        #endregion
        #region Edit_Setup_category_List
        public void Edit_Setup_category_List(Params_Edit_Setup_category_List i_Params_Edit_Setup_category_List)
        {
            var i_Params_Edit_Setup_category_List_json = JsonConvert.SerializeObject(i_Params_Edit_Setup_category_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup_category_List", i_Params_Edit_Setup_category_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Setup_category_List.List_To_Edit != null)
            {
                i_Params_Edit_Setup_category_List.List_Failed_Edit = new List<Setup_category>();
                if (i_Params_Edit_Setup_category_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSetup_category in i_Params_Edit_Setup_category_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Setup_category(oSetup_category);
                        }
                        catch
                        {
                            i_Params_Edit_Setup_category_List.List_Failed_Edit.Add(oSetup_category);
                        }
                    }
                }
                i_Params_Edit_Setup_category_List.List_To_Edit = i_Params_Edit_Setup_category_List.List_To_Edit.Except(i_Params_Edit_Setup_category_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Setup_category_List.List_To_Delete != null)
            {
                i_Params_Edit_Setup_category_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Setup_category_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Setup_category_ID in i_Params_Edit_Setup_category_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Setup_category(new Params_Delete_Setup_category()
                            {
                                SETUP_CATEGORY_ID = Setup_category_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Setup_category_List.List_Failed_Delete.Add(Setup_category_ID);
                        }
                    }
                }
                i_Params_Edit_Setup_category_List.List_To_Delete = i_Params_Edit_Setup_category_List.List_To_Delete.Except(i_Params_Edit_Setup_category_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup_category_List", i_Params_Edit_Setup_category_List_json, false);
            }
        }
        #endregion
        #region Edit_Setup_List
        public void Edit_Setup_List(Params_Edit_Setup_List i_Params_Edit_Setup_List)
        {
            var i_Params_Edit_Setup_List_json = JsonConvert.SerializeObject(i_Params_Edit_Setup_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup_List", i_Params_Edit_Setup_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Setup_List.List_To_Edit != null)
            {
                i_Params_Edit_Setup_List.List_Failed_Edit = new List<Setup>();
                if (i_Params_Edit_Setup_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSetup in i_Params_Edit_Setup_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Setup(oSetup);
                        }
                        catch
                        {
                            i_Params_Edit_Setup_List.List_Failed_Edit.Add(oSetup);
                        }
                    }
                }
                i_Params_Edit_Setup_List.List_To_Edit = i_Params_Edit_Setup_List.List_To_Edit.Except(i_Params_Edit_Setup_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Setup_List.List_To_Delete != null)
            {
                i_Params_Edit_Setup_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Setup_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Setup_ID in i_Params_Edit_Setup_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Setup(new Params_Delete_Setup()
                            {
                                SETUP_ID = Setup_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Setup_List.List_Failed_Delete.Add(Setup_ID);
                        }
                    }
                }
                i_Params_Edit_Setup_List.List_To_Delete = i_Params_Edit_Setup_List.List_To_Delete.Except(i_Params_Edit_Setup_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup_List", i_Params_Edit_Setup_List_json, false);
            }
        }
        #endregion
        #region Edit_Area_kpi_List
        public void Edit_Area_kpi_List(Params_Edit_Area_kpi_List i_Params_Edit_Area_kpi_List)
        {
            var i_Params_Edit_Area_kpi_List_json = JsonConvert.SerializeObject(i_Params_Edit_Area_kpi_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Area_kpi_List", i_Params_Edit_Area_kpi_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Area_kpi_List.List_To_Edit != null)
            {
                i_Params_Edit_Area_kpi_List.List_Failed_Edit = new List<Area_kpi>();
                if (i_Params_Edit_Area_kpi_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oArea_kpi in i_Params_Edit_Area_kpi_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Area_kpi(oArea_kpi);
                        }
                        catch
                        {
                            i_Params_Edit_Area_kpi_List.List_Failed_Edit.Add(oArea_kpi);
                        }
                    }
                }
                i_Params_Edit_Area_kpi_List.List_To_Edit = i_Params_Edit_Area_kpi_List.List_To_Edit.Except(i_Params_Edit_Area_kpi_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Area_kpi_List.List_To_Delete != null)
            {
                i_Params_Edit_Area_kpi_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Area_kpi_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Area_kpi_ID in i_Params_Edit_Area_kpi_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Area_kpi(new Params_Delete_Area_kpi()
                            {
                                AREA_KPI_ID = Area_kpi_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Area_kpi_List.List_Failed_Delete.Add(Area_kpi_ID);
                        }
                    }
                }
                i_Params_Edit_Area_kpi_List.List_To_Delete = i_Params_Edit_Area_kpi_List.List_To_Delete.Except(i_Params_Edit_Area_kpi_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Area_kpi_List", i_Params_Edit_Area_kpi_List_json, false);
            }
        }
        #endregion
        #region Edit_Space_asset_List
        public void Edit_Space_asset_List(Params_Edit_Space_asset_List i_Params_Edit_Space_asset_List)
        {
            var i_Params_Edit_Space_asset_List_json = JsonConvert.SerializeObject(i_Params_Edit_Space_asset_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Space_asset_List", i_Params_Edit_Space_asset_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Space_asset_List.List_To_Edit != null)
            {
                i_Params_Edit_Space_asset_List.List_Failed_Edit = new List<Space_asset>();
                if (i_Params_Edit_Space_asset_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSpace_asset in i_Params_Edit_Space_asset_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Space_asset(oSpace_asset);
                        }
                        catch
                        {
                            i_Params_Edit_Space_asset_List.List_Failed_Edit.Add(oSpace_asset);
                        }
                    }
                }
                i_Params_Edit_Space_asset_List.List_To_Edit = i_Params_Edit_Space_asset_List.List_To_Edit.Except(i_Params_Edit_Space_asset_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Space_asset_List.List_To_Delete != null)
            {
                i_Params_Edit_Space_asset_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Space_asset_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Space_asset_ID in i_Params_Edit_Space_asset_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Space_asset(new Params_Delete_Space_asset()
                            {
                                SPACE_ASSET_ID = Space_asset_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Space_asset_List.List_Failed_Delete.Add(Space_asset_ID);
                        }
                    }
                }
                i_Params_Edit_Space_asset_List.List_To_Delete = i_Params_Edit_Space_asset_List.List_To_Delete.Except(i_Params_Edit_Space_asset_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Space_asset_List", i_Params_Edit_Space_asset_List_json, false);
            }
        }
        #endregion
        #region Edit_District_List
        public void Edit_District_List(Params_Edit_District_List i_Params_Edit_District_List)
        {
            var i_Params_Edit_District_List_json = JsonConvert.SerializeObject(i_Params_Edit_District_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_District_List", i_Params_Edit_District_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_District_List.List_To_Edit != null)
            {
                i_Params_Edit_District_List.List_Failed_Edit = new List<District>();
                if (i_Params_Edit_District_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oDistrict in i_Params_Edit_District_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_District(oDistrict);
                        }
                        catch
                        {
                            i_Params_Edit_District_List.List_Failed_Edit.Add(oDistrict);
                        }
                    }
                }
                i_Params_Edit_District_List.List_To_Edit = i_Params_Edit_District_List.List_To_Edit.Except(i_Params_Edit_District_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_District_List.List_To_Delete != null)
            {
                i_Params_Edit_District_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_District_List.List_To_Delete.Count() > 0)
                {
                    foreach (var District_ID in i_Params_Edit_District_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_District(new Params_Delete_District()
                            {
                                DISTRICT_ID = District_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_District_List.List_Failed_Delete.Add(District_ID);
                        }
                    }
                }
                i_Params_Edit_District_List.List_To_Delete = i_Params_Edit_District_List.List_To_Delete.Except(i_Params_Edit_District_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_District_List", i_Params_Edit_District_List_json, false);
            }
        }
        #endregion
        #region Edit_Organization_data_source_kpi_List
        public void Edit_Organization_data_source_kpi_List(Params_Edit_Organization_data_source_kpi_List i_Params_Edit_Organization_data_source_kpi_List)
        {
            var i_Params_Edit_Organization_data_source_kpi_List_json = JsonConvert.SerializeObject(i_Params_Edit_Organization_data_source_kpi_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Organization_data_source_kpi_List", i_Params_Edit_Organization_data_source_kpi_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Organization_data_source_kpi_List.List_To_Edit != null)
            {
                i_Params_Edit_Organization_data_source_kpi_List.List_Failed_Edit = new List<Organization_data_source_kpi>();
                if (i_Params_Edit_Organization_data_source_kpi_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oOrganization_data_source_kpi in i_Params_Edit_Organization_data_source_kpi_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Organization_data_source_kpi(oOrganization_data_source_kpi);
                        }
                        catch
                        {
                            i_Params_Edit_Organization_data_source_kpi_List.List_Failed_Edit.Add(oOrganization_data_source_kpi);
                        }
                    }
                }
                i_Params_Edit_Organization_data_source_kpi_List.List_To_Edit = i_Params_Edit_Organization_data_source_kpi_List.List_To_Edit.Except(i_Params_Edit_Organization_data_source_kpi_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Organization_data_source_kpi_List.List_To_Delete != null)
            {
                i_Params_Edit_Organization_data_source_kpi_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Organization_data_source_kpi_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Organization_data_source_kpi_ID in i_Params_Edit_Organization_data_source_kpi_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Organization_data_source_kpi(new Params_Delete_Organization_data_source_kpi()
                            {
                                ORGANIZATION_DATA_SOURCE_KPI_ID = Organization_data_source_kpi_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Organization_data_source_kpi_List.List_Failed_Delete.Add(Organization_data_source_kpi_ID);
                        }
                    }
                }
                i_Params_Edit_Organization_data_source_kpi_List.List_To_Delete = i_Params_Edit_Organization_data_source_kpi_List.List_To_Delete.Except(i_Params_Edit_Organization_data_source_kpi_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Organization_data_source_kpi_List", i_Params_Edit_Organization_data_source_kpi_List_json, false);
            }
        }
        #endregion
        #region Edit_Floor_List
        public void Edit_Floor_List(Params_Edit_Floor_List i_Params_Edit_Floor_List)
        {
            var i_Params_Edit_Floor_List_json = JsonConvert.SerializeObject(i_Params_Edit_Floor_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Floor_List", i_Params_Edit_Floor_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Floor_List.List_To_Edit != null)
            {
                i_Params_Edit_Floor_List.List_Failed_Edit = new List<Floor>();
                if (i_Params_Edit_Floor_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oFloor in i_Params_Edit_Floor_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Floor(oFloor);
                        }
                        catch
                        {
                            i_Params_Edit_Floor_List.List_Failed_Edit.Add(oFloor);
                        }
                    }
                }
                i_Params_Edit_Floor_List.List_To_Edit = i_Params_Edit_Floor_List.List_To_Edit.Except(i_Params_Edit_Floor_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Floor_List.List_To_Delete != null)
            {
                i_Params_Edit_Floor_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Floor_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Floor_ID in i_Params_Edit_Floor_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Floor(new Params_Delete_Floor()
                            {
                                FLOOR_ID = Floor_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Floor_List.List_Failed_Delete.Add(Floor_ID);
                        }
                    }
                }
                i_Params_Edit_Floor_List.List_To_Delete = i_Params_Edit_Floor_List.List_To_Delete.Except(i_Params_Edit_Floor_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Floor_List", i_Params_Edit_Floor_List_json, false);
            }
        }
        #endregion
        #region Edit_District_kpi_user_access_List
        public void Edit_District_kpi_user_access_List(Params_Edit_District_kpi_user_access_List i_Params_Edit_District_kpi_user_access_List)
        {
            var i_Params_Edit_District_kpi_user_access_List_json = JsonConvert.SerializeObject(i_Params_Edit_District_kpi_user_access_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_District_kpi_user_access_List", i_Params_Edit_District_kpi_user_access_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_District_kpi_user_access_List.List_To_Edit != null)
            {
                i_Params_Edit_District_kpi_user_access_List.List_Failed_Edit = new List<District_kpi_user_access>();
                if (i_Params_Edit_District_kpi_user_access_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oDistrict_kpi_user_access in i_Params_Edit_District_kpi_user_access_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_District_kpi_user_access(oDistrict_kpi_user_access);
                        }
                        catch
                        {
                            i_Params_Edit_District_kpi_user_access_List.List_Failed_Edit.Add(oDistrict_kpi_user_access);
                        }
                    }
                }
                i_Params_Edit_District_kpi_user_access_List.List_To_Edit = i_Params_Edit_District_kpi_user_access_List.List_To_Edit.Except(i_Params_Edit_District_kpi_user_access_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_District_kpi_user_access_List.List_To_Delete != null)
            {
                i_Params_Edit_District_kpi_user_access_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_District_kpi_user_access_List.List_To_Delete.Count() > 0)
                {
                    foreach (var District_kpi_user_access_ID in i_Params_Edit_District_kpi_user_access_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_District_kpi_user_access(new Params_Delete_District_kpi_user_access()
                            {
                                DISTRICT_KPI_USER_ACCESS_ID = District_kpi_user_access_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_District_kpi_user_access_List.List_Failed_Delete.Add(District_kpi_user_access_ID);
                        }
                    }
                }
                i_Params_Edit_District_kpi_user_access_List.List_To_Delete = i_Params_Edit_District_kpi_user_access_List.List_To_Delete.Except(i_Params_Edit_District_kpi_user_access_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_District_kpi_user_access_List", i_Params_Edit_District_kpi_user_access_List_json, false);
            }
        }
        #endregion
        #region Edit_User_List
        public void Edit_User_List(Params_Edit_User_List i_Params_Edit_User_List)
        {
            var i_Params_Edit_User_List_json = JsonConvert.SerializeObject(i_Params_Edit_User_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_User_List", i_Params_Edit_User_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_User_List.List_To_Edit != null)
            {
                i_Params_Edit_User_List.List_Failed_Edit = new List<User>();
                if (i_Params_Edit_User_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oUser in i_Params_Edit_User_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_User(oUser);
                        }
                        catch
                        {
                            i_Params_Edit_User_List.List_Failed_Edit.Add(oUser);
                        }
                    }
                }
                i_Params_Edit_User_List.List_To_Edit = i_Params_Edit_User_List.List_To_Edit.Except(i_Params_Edit_User_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_User_List.List_To_Delete != null)
            {
                i_Params_Edit_User_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_User_List.List_To_Delete.Count() > 0)
                {
                    foreach (var User_ID in i_Params_Edit_User_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_User(new Params_Delete_User()
                            {
                                USER_ID = User_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_User_List.List_Failed_Delete.Add(User_ID);
                        }
                    }
                }
                i_Params_Edit_User_List.List_To_Delete = i_Params_Edit_User_List.List_To_Delete.Except(i_Params_Edit_User_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_User_List", i_Params_Edit_User_List_json, false);
            }
        }
        #endregion
        #region Edit_Space_List
        public void Edit_Space_List(Params_Edit_Space_List i_Params_Edit_Space_List)
        {
            var i_Params_Edit_Space_List_json = JsonConvert.SerializeObject(i_Params_Edit_Space_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Space_List", i_Params_Edit_Space_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Space_List.List_To_Edit != null)
            {
                i_Params_Edit_Space_List.List_Failed_Edit = new List<Space>();
                if (i_Params_Edit_Space_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSpace in i_Params_Edit_Space_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Space(oSpace);
                        }
                        catch
                        {
                            i_Params_Edit_Space_List.List_Failed_Edit.Add(oSpace);
                        }
                    }
                }
                i_Params_Edit_Space_List.List_To_Edit = i_Params_Edit_Space_List.List_To_Edit.Except(i_Params_Edit_Space_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Space_List.List_To_Delete != null)
            {
                i_Params_Edit_Space_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Space_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Space_ID in i_Params_Edit_Space_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Space(new Params_Delete_Space()
                            {
                                SPACE_ID = Space_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Space_List.List_Failed_Delete.Add(Space_ID);
                        }
                    }
                }
                i_Params_Edit_Space_List.List_To_Delete = i_Params_Edit_Space_List.List_To_Delete.Except(i_Params_Edit_Space_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Space_List", i_Params_Edit_Space_List_json, false);
            }
        }
        #endregion
        #region Edit_Site_List
        public void Edit_Site_List(Params_Edit_Site_List i_Params_Edit_Site_List)
        {
            var i_Params_Edit_Site_List_json = JsonConvert.SerializeObject(i_Params_Edit_Site_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Site_List", i_Params_Edit_Site_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Site_List.List_To_Edit != null)
            {
                i_Params_Edit_Site_List.List_Failed_Edit = new List<Site>();
                if (i_Params_Edit_Site_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSite in i_Params_Edit_Site_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Site(oSite);
                        }
                        catch
                        {
                            i_Params_Edit_Site_List.List_Failed_Edit.Add(oSite);
                        }
                    }
                }
                i_Params_Edit_Site_List.List_To_Edit = i_Params_Edit_Site_List.List_To_Edit.Except(i_Params_Edit_Site_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Site_List.List_To_Delete != null)
            {
                i_Params_Edit_Site_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Site_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Site_ID in i_Params_Edit_Site_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Site(new Params_Delete_Site()
                            {
                                SITE_ID = Site_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Site_List.List_Failed_Delete.Add(Site_ID);
                        }
                    }
                }
                i_Params_Edit_Site_List.List_To_Delete = i_Params_Edit_Site_List.List_To_Delete.Except(i_Params_Edit_Site_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Site_List", i_Params_Edit_Site_List_json, false);
            }
        }
        #endregion
    }
}