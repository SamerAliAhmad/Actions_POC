using System;
using SmartrTools;
using System.Data;
using System.Linq;
using System.Dynamic;
using System.Collections.Generic;

namespace DALC
{
    public partial class MSSQL_DALC : DALC
    {
        #region Get_Site_view_By_SITE_VIEW_ID
        public Site_view Get_Site_view_By_SITE_VIEW_ID(long? SITE_VIEW_ID)
        {
            Site_view oSite_view = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_VIEW_ID = SITE_VIEW_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_SITE_VIEW_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSite_view = new Site_view();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSite_view);
            }
            return oSite_view;
        }
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID
        public Removed_extrusion Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID(int? REMOVED_EXTRUSION_ID)
        {
            Removed_extrusion oRemoved_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.REMOVED_EXTRUSION_ID = REMOVED_EXTRUSION_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_REMOVED_EXTRUSION_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oRemoved_extrusion = new Removed_extrusion();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oRemoved_extrusion);
            }
            return oRemoved_extrusion;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_VIEW_ID
        public Entity_view Get_Entity_view_By_ENTITY_VIEW_ID(long? ENTITY_VIEW_ID)
        {
            Entity_view oEntity_view = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_VIEW_ID = ENTITY_VIEW_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_ENTITY_VIEW_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oEntity_view = new Entity_view();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oEntity_view);
            }
            return oEntity_view;
        }
        #endregion
        #region Get_Top_level_By_TOP_LEVEL_ID
        public Top_level Get_Top_level_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID)
        {
            Top_level oTop_level = null;
            dynamic _params = new ExpandoObject();
            _params.TOP_LEVEL_ID = TOP_LEVEL_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_TOP_LEVEL_BY_TOP_LEVEL_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oTop_level = new Top_level();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oTop_level);
            }
            return oTop_level;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID
        public Area_kpi_user_access Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID(long? AREA_KPI_USER_ACCESS_ID)
        {
            Area_kpi_user_access oArea_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.AREA_KPI_USER_ACCESS_ID = AREA_KPI_USER_ACCESS_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_AREA_KPI_USER_ACCESS_BY_AREA_KPI_USER_ACCESS_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oArea_kpi_user_access = new Area_kpi_user_access();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oArea_kpi_user_access);
            }
            return oArea_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID
        public Site_kpi_user_access Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID(long? SITE_KPI_USER_ACCESS_ID)
        {
            Site_kpi_user_access oSite_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_KPI_USER_ACCESS_ID = SITE_KPI_USER_ACCESS_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SITE_KPI_USER_ACCESS_BY_SITE_KPI_USER_ACCESS_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSite_kpi_user_access = new Site_kpi_user_access();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSite_kpi_user_access);
            }
            return oSite_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_ENTITY_KPI_ID
        public Entity_kpi Get_Entity_kpi_By_ENTITY_KPI_ID(long? ENTITY_KPI_ID)
        {
            Entity_kpi oEntity_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_KPI_ID = ENTITY_KPI_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_BY_ENTITY_KPI_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oEntity_kpi = new Entity_kpi();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oEntity_kpi);
            }
            return oEntity_kpi;
        }
        #endregion
        #region Get_Entity_By_ENTITY_ID
        public Entity Get_Entity_By_ENTITY_ID(long? ENTITY_ID)
        {
            Entity oEntity = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_ID = ENTITY_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ENTITY_BY_ENTITY_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oEntity = new Entity();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oEntity);
            }
            return oEntity;
        }
        #endregion
        #region Get_District_kpi_By_DISTRICT_KPI_ID
        public District_kpi Get_District_kpi_By_DISTRICT_KPI_ID(long? DISTRICT_KPI_ID)
        {
            District_kpi oDistrict_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_KPI_ID = DISTRICT_KPI_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_BY_DISTRICT_KPI_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oDistrict_kpi = new District_kpi();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oDistrict_kpi);
            }
            return oDistrict_kpi;
        }
        #endregion
        #region Get_User_level_access_By_USER_LEVEL_ACCESS_ID
        public User_level_access Get_User_level_access_By_USER_LEVEL_ACCESS_ID(long? USER_LEVEL_ACCESS_ID)
        {
            User_level_access oUser_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.USER_LEVEL_ACCESS_ID = USER_LEVEL_ACCESS_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_USER_LEVEL_ACCESS_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oUser_level_access = new User_level_access();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oUser_level_access);
            }
            return oUser_level_access;
        }
        #endregion
        #region Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID
        public User_districtnex_module Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID(long? USER_DISTRICTNEX_MODULE_ID)
        {
            User_districtnex_module oUser_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.USER_DISTRICTNEX_MODULE_ID = USER_DISTRICTNEX_MODULE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_USER_DISTRICTNEX_MODULE_BY_USER_DISTRICTNEX_MODULE_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oUser_districtnex_module = new User_districtnex_module();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oUser_districtnex_module);
            }
            return oUser_districtnex_module;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID
        public Entity_kpi_user_access Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID(long? ENTITY_KPI_USER_ACCESS_ID)
        {
            Entity_kpi_user_access oEntity_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_KPI_USER_ACCESS_ID = ENTITY_KPI_USER_ACCESS_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_USER_ACCESS_BY_ENTITY_KPI_USER_ACCESS_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oEntity_kpi_user_access = new Entity_kpi_user_access();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oEntity_kpi_user_access);
            }
            return oEntity_kpi_user_access;
        }
        #endregion
        #region Get_District_view_By_DISTRICT_VIEW_ID
        public District_view Get_District_view_By_DISTRICT_VIEW_ID(long? DISTRICT_VIEW_ID)
        {
            District_view oDistrict_view = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_VIEW_ID = DISTRICT_VIEW_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_DISTRICT_VIEW_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oDistrict_view = new District_view();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oDistrict_view);
            }
            return oDistrict_view;
        }
        #endregion
        #region Get_Area_By_AREA_ID
        public Area Get_Area_By_AREA_ID(long? AREA_ID)
        {
            Area oArea = null;
            dynamic _params = new ExpandoObject();
            _params.AREA_ID = AREA_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_AREA_BY_AREA_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oArea = new Area();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oArea);
            }
            return oArea;
        }
        #endregion
        #region Get_Area_view_By_AREA_VIEW_ID
        public Area_view Get_Area_view_By_AREA_VIEW_ID(long? AREA_VIEW_ID)
        {
            Area_view oArea_view = null;
            dynamic _params = new ExpandoObject();
            _params.AREA_VIEW_ID = AREA_VIEW_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_AREA_VIEW_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oArea_view = new Area_view();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oArea_view);
            }
            return oArea_view;
        }
        #endregion
        #region Get_Site_kpi_By_SITE_KPI_ID
        public Site_kpi Get_Site_kpi_By_SITE_KPI_ID(long? SITE_KPI_ID)
        {
            Site_kpi oSite_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_KPI_ID = SITE_KPI_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SITE_KPI_BY_SITE_KPI_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSite_kpi = new Site_kpi();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSite_kpi);
            }
            return oSite_kpi;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            Setup_category oSetup_category = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup_category = new Setup_category();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup_category);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID
        public Organization_relation Get_Organization_relation_By_ORGANIZATION_RELATION_ID(int? ORGANIZATION_RELATION_ID)
        {
            Organization_relation oOrganization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_RELATION_ID = ORGANIZATION_RELATION_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_ORGANIZATION_RELATION_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_relation = new Organization_relation();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_relation);
            }
            return oOrganization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID
        public Setup Get_Setup_By_SETUP_ID(long? SETUP_ID)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_ID = SETUP_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
            }
            return oSetup;
        }
        #endregion
        #region Get_Area_kpi_By_AREA_KPI_ID
        public Area_kpi Get_Area_kpi_By_AREA_KPI_ID(long? AREA_KPI_ID)
        {
            Area_kpi oArea_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.AREA_KPI_ID = AREA_KPI_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_AREA_KPI_BY_AREA_KPI_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oArea_kpi = new Area_kpi();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oArea_kpi);
            }
            return oArea_kpi;
        }
        #endregion
        #region Get_Region_By_REGION_ID
        public Region Get_Region_By_REGION_ID(long? REGION_ID)
        {
            Region oRegion = null;
            dynamic _params = new ExpandoObject();
            _params.REGION_ID = REGION_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_REGION_BY_REGION_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oRegion = new Region();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oRegion);
            }
            return oRegion;
        }
        #endregion
        #region Get_District_By_DISTRICT_ID
        public District Get_District_By_DISTRICT_ID(long? DISTRICT_ID)
        {
            District oDistrict = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_ID = DISTRICT_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_DISTRICT_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oDistrict = new District();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oDistrict);
            }
            return oDistrict;
        }
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID
        public District_kpi_user_access Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID(long? DISTRICT_KPI_USER_ACCESS_ID)
        {
            District_kpi_user_access oDistrict_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_KPI_USER_ACCESS_ID = DISTRICT_KPI_USER_ACCESS_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_USER_ACCESS_BY_DISTRICT_KPI_USER_ACCESS_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oDistrict_kpi_user_access = new District_kpi_user_access();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oDistrict_kpi_user_access);
            }
            return oDistrict_kpi_user_access;
        }
        #endregion
        #region Get_User_By_USER_ID
        public User Get_User_By_USER_ID(long? USER_ID)
        {
            User oUser = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oUser);
            }
            return oUser;
        }
        #endregion
        #region Get_Site_By_SITE_ID
        public Site Get_Site_By_SITE_ID(long? SITE_ID)
        {
            Site oSite = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_ID = SITE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SITE_BY_SITE_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSite = new Site();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSite);
            }
            return oSite;
        }
        #endregion
        #region Get_User_theme_By_USER_THEME_ID
        public User_theme Get_User_theme_By_USER_THEME_ID(int? USER_THEME_ID)
        {
            User_theme oUser_theme = null;
            dynamic _params = new ExpandoObject();
            _params.USER_THEME_ID = USER_THEME_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_USER_THEME_BY_USER_THEME_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oUser_theme = new User_theme();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oUser_theme);
            }
            return oUser_theme;
        }
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID
        public Region_view Get_Region_view_By_REGION_VIEW_ID(long? REGION_VIEW_ID)
        {
            Region_view oRegion_view = null;
            dynamic _params = new ExpandoObject();
            _params.REGION_VIEW_ID = REGION_VIEW_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_REGION_VIEW_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oRegion_view = new Region_view();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oRegion_view);
            }
            return oRegion_view;
        }
        #endregion
        #region Get_Site_view_By_SITE_VIEW_ID_List
        public List<Site_view> Get_Site_view_By_SITE_VIEW_ID_List(IEnumerable<long?> SITE_VIEW_ID_LIST)
        {
            List<Site_view> oList_Site_view = null;
            if (SITE_VIEW_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_VIEW_ID_LIST = string.Join(",", SITE_VIEW_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_SITE_VIEW_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site_view = new List<Site_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_view oSite_view = new Site_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                            oList_Site_view.Add(oSite_view);
                        }
                    }
                }
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List
        public List<Removed_extrusion> Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List(IEnumerable<int?> REMOVED_EXTRUSION_ID_LIST)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            if (REMOVED_EXTRUSION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REMOVED_EXTRUSION_ID_LIST = string.Join(",", REMOVED_EXTRUSION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_REMOVED_EXTRUSION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Removed_extrusion = new List<Removed_extrusion>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                            oList_Removed_extrusion.Add(oRemoved_extrusion);
                        }
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_VIEW_ID_List
        public List<Entity_view> Get_Entity_view_By_ENTITY_VIEW_ID_List(IEnumerable<long?> ENTITY_VIEW_ID_LIST)
        {
            List<Entity_view> oList_Entity_view = null;
            if (ENTITY_VIEW_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_VIEW_ID_LIST = string.Join(",", ENTITY_VIEW_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_ENTITY_VIEW_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity_view = new List<Entity_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity_view oEntity_view = new Entity_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                            oList_Entity_view.Add(oEntity_view);
                        }
                    }
                }
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Top_level_By_TOP_LEVEL_ID_List
        public List<Top_level> Get_Top_level_By_TOP_LEVEL_ID_List(IEnumerable<long?> TOP_LEVEL_ID_LIST)
        {
            List<Top_level> oList_Top_level = null;
            if (TOP_LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.TOP_LEVEL_ID_LIST = string.Join(",", TOP_LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_TOP_LEVEL_BY_TOP_LEVEL_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Top_level = new List<Top_level>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Top_level oTop_level = new Top_level();
                            Props.Copy_Prop_Values_From_Data_Record(element, oTop_level);
                            oList_Top_level.Add(oTop_level);
                        }
                    }
                }
            }
            return oList_Top_level;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_KPI_USER_ACCESS_ID_List(IEnumerable<long?> AREA_KPI_USER_ACCESS_ID_LIST)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            if (AREA_KPI_USER_ACCESS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.AREA_KPI_USER_ACCESS_ID_LIST = string.Join(",", AREA_KPI_USER_ACCESS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_USER_ACCESS_BY_AREA_KPI_USER_ACCESS_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi_user_access);
                            oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                        }
                    }
                }
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_KPI_USER_ACCESS_ID_List(IEnumerable<long?> SITE_KPI_USER_ACCESS_ID_LIST)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            if (SITE_KPI_USER_ACCESS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_KPI_USER_ACCESS_ID_LIST = string.Join(",", SITE_KPI_USER_ACCESS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_USER_ACCESS_BY_SITE_KPI_USER_ACCESS_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi_user_access);
                            oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                        }
                    }
                }
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_ENTITY_KPI_ID_List
        public List<Entity_kpi> Get_Entity_kpi_By_ENTITY_KPI_ID_List(IEnumerable<long?> ENTITY_KPI_ID_LIST)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            if (ENTITY_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_KPI_ID_LIST = string.Join(",", ENTITY_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_BY_ENTITY_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity_kpi = new List<Entity_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity_kpi oEntity_kpi = new Entity_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi);
                            oList_Entity_kpi.Add(oEntity_kpi);
                        }
                    }
                }
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_ENTITY_ID_List
        public List<Entity> Get_Entity_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST)
        {
            List<Entity> oList_Entity = null;
            if (ENTITY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_ID_LIST = string.Join(",", ENTITY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_ENTITY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity = new List<Entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity oEntity = new Entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                            oList_Entity.Add(oEntity);
                        }
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_DISTRICT_KPI_ID_List
        public List<District_kpi> Get_District_kpi_By_DISTRICT_KPI_ID_List(IEnumerable<long?> DISTRICT_KPI_ID_LIST)
        {
            List<District_kpi> oList_District_kpi = null;
            if (DISTRICT_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_KPI_ID_LIST = string.Join(",", DISTRICT_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_BY_DISTRICT_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_District_kpi = new List<District_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District_kpi oDistrict_kpi = new District_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi);
                            oList_District_kpi.Add(oDistrict_kpi);
                        }
                    }
                }
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List
        public List<User_level_access> Get_User_level_access_By_USER_LEVEL_ACCESS_ID_List(IEnumerable<long?> USER_LEVEL_ACCESS_ID_LIST)
        {
            List<User_level_access> oList_User_level_access = null;
            if (USER_LEVEL_ACCESS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_LEVEL_ACCESS_ID_LIST = string.Join(",", USER_LEVEL_ACCESS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_USER_LEVEL_ACCESS_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User_level_access = new List<User_level_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User_level_access oUser_level_access = new User_level_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser_level_access);
                            oList_User_level_access.Add(oUser_level_access);
                        }
                    }
                }
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List
        public List<User_districtnex_module> Get_User_districtnex_module_By_USER_DISTRICTNEX_MODULE_ID_List(IEnumerable<long?> USER_DISTRICTNEX_MODULE_ID_LIST)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            if (USER_DISTRICTNEX_MODULE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_DISTRICTNEX_MODULE_ID_LIST = string.Join(",", USER_DISTRICTNEX_MODULE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_DISTRICTNEX_MODULE_BY_USER_DISTRICTNEX_MODULE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User_districtnex_module = new List<User_districtnex_module>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser_districtnex_module);
                            oList_User_districtnex_module.Add(oUser_districtnex_module);
                        }
                    }
                }
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_KPI_USER_ACCESS_ID_List(IEnumerable<long?> ENTITY_KPI_USER_ACCESS_ID_LIST)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            if (ENTITY_KPI_USER_ACCESS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_KPI_USER_ACCESS_ID_LIST = string.Join(",", ENTITY_KPI_USER_ACCESS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_USER_ACCESS_BY_ENTITY_KPI_USER_ACCESS_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi_user_access);
                            oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                        }
                    }
                }
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_District_view_By_DISTRICT_VIEW_ID_List
        public List<District_view> Get_District_view_By_DISTRICT_VIEW_ID_List(IEnumerable<long?> DISTRICT_VIEW_ID_LIST)
        {
            List<District_view> oList_District_view = null;
            if (DISTRICT_VIEW_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_VIEW_ID_LIST = string.Join(",", DISTRICT_VIEW_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_DISTRICT_VIEW_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_District_view = new List<District_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District_view oDistrict_view = new District_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                            oList_District_view.Add(oDistrict_view);
                        }
                    }
                }
            }
            return oList_District_view;
        }
        #endregion
        #region Get_Area_By_AREA_ID_List
        public List<Area> Get_Area_By_AREA_ID_List(IEnumerable<long?> AREA_ID_LIST)
        {
            List<Area> oList_Area = null;
            if (AREA_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.AREA_ID_LIST = string.Join(",", AREA_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_AREA_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Area = new List<Area>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area oArea = new Area();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                            oList_Area.Add(oArea);
                        }
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_AREA_VIEW_ID_List
        public List<Area_view> Get_Area_view_By_AREA_VIEW_ID_List(IEnumerable<long?> AREA_VIEW_ID_LIST)
        {
            List<Area_view> oList_Area_view = null;
            if (AREA_VIEW_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.AREA_VIEW_ID_LIST = string.Join(",", AREA_VIEW_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_AREA_VIEW_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Area_view = new List<Area_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area_view oArea_view = new Area_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                            oList_Area_view.Add(oArea_view);
                        }
                    }
                }
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Site_kpi_By_SITE_KPI_ID_List
        public List<Site_kpi> Get_Site_kpi_By_SITE_KPI_ID_List(IEnumerable<long?> SITE_KPI_ID_LIST)
        {
            List<Site_kpi> oList_Site_kpi = null;
            if (SITE_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_KPI_ID_LIST = string.Join(",", SITE_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_BY_SITE_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site_kpi = new List<Site_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_kpi oSite_kpi = new Site_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi);
                            oList_Site_kpi.Add(oSite_kpi);
                        }
                    }
                }
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        public List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Setup_category> oList_Setup_category = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Setup_category = new List<Setup_category>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup_category oSetup_category = new Setup_category();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                            oList_Setup_category.Add(oSetup_category);
                        }
                    }
                }
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List
        public List<Organization_relation> Get_Organization_relation_By_ORGANIZATION_RELATION_ID_List(IEnumerable<int?> ORGANIZATION_RELATION_ID_LIST)
        {
            List<Organization_relation> oList_Organization_relation = null;
            if (ORGANIZATION_RELATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_RELATION_ID_LIST = string.Join(",", ORGANIZATION_RELATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_ORGANIZATION_RELATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_relation = new List<Organization_relation>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_relation oOrganization_relation = new Organization_relation();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                            oList_Organization_relation.Add(oOrganization_relation);
                        }
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        public List<Setup> Get_Setup_By_SETUP_ID_List(IEnumerable<long?> SETUP_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_ID_LIST = string.Join(",", SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_AREA_KPI_ID_List
        public List<Area_kpi> Get_Area_kpi_By_AREA_KPI_ID_List(IEnumerable<long?> AREA_KPI_ID_LIST)
        {
            List<Area_kpi> oList_Area_kpi = null;
            if (AREA_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.AREA_KPI_ID_LIST = string.Join(",", AREA_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_BY_AREA_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Area_kpi = new List<Area_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area_kpi oArea_kpi = new Area_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi);
                            oList_Area_kpi.Add(oArea_kpi);
                        }
                    }
                }
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Region_By_REGION_ID_List
        public List<Region> Get_Region_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST)
        {
            List<Region> oList_Region = null;
            if (REGION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REGION_ID_LIST = string.Join(",", REGION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_BY_REGION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Region = new List<Region>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Region oRegion = new Region();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRegion);
                            oList_Region.Add(oRegion);
                        }
                    }
                }
            }
            return oList_Region;
        }
        #endregion
        #region Get_District_By_DISTRICT_ID_List
        public List<District> Get_District_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST)
        {
            List<District> oList_District = null;
            if (DISTRICT_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_ID_LIST = string.Join(",", DISTRICT_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_DISTRICT_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_District = new List<District>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District oDistrict = new District();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                            oList_District.Add(oDistrict);
                        }
                    }
                }
            }
            return oList_District;
        }
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_KPI_USER_ACCESS_ID_List(IEnumerable<long?> DISTRICT_KPI_USER_ACCESS_ID_LIST)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            if (DISTRICT_KPI_USER_ACCESS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_KPI_USER_ACCESS_ID_LIST = string.Join(",", DISTRICT_KPI_USER_ACCESS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_USER_ACCESS_BY_DISTRICT_KPI_USER_ACCESS_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_District_kpi_user_access = new List<District_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi_user_access);
                            oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                        }
                    }
                }
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_USER_ID_List
        public List<User> Get_User_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST)
        {
            List<User> oList_User = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_USER_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User = new List<User>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User oUser = new User();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                            oList_User.Add(oUser);
                        }
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_Site_By_SITE_ID_List
        public List<Site> Get_Site_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST)
        {
            List<Site> oList_Site = null;
            if (SITE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_ID_LIST = string.Join(",", SITE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_SITE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site = new List<Site>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site oSite = new Site();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                            oList_Site.Add(oSite);
                        }
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_User_theme_By_USER_THEME_ID_List
        public List<User_theme> Get_User_theme_By_USER_THEME_ID_List(IEnumerable<int?> USER_THEME_ID_LIST)
        {
            List<User_theme> oList_User_theme = null;
            if (USER_THEME_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_THEME_ID_LIST = string.Join(",", USER_THEME_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_THEME_BY_USER_THEME_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User_theme = new List<User_theme>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User_theme oUser_theme = new User_theme();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser_theme);
                            oList_User_theme.Add(oUser_theme);
                        }
                    }
                }
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID_List
        public List<Region_view> Get_Region_view_By_REGION_VIEW_ID_List(IEnumerable<long?> REGION_VIEW_ID_LIST)
        {
            List<Region_view> oList_Region_view = null;
            if (REGION_VIEW_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REGION_VIEW_ID_LIST = string.Join(",", REGION_VIEW_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_REGION_VIEW_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Region_view = new List<Region_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Region_view oRegion_view = new Region_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                            oList_Region_view.Add(oRegion_view);
                        }
                    }
                }
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Site_view_By_OWNER_ID_IS_DELETED
        public List<Site_view> Get_Site_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Site_view> oList_Site_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Site_view = new List<Site_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_VIEW_TYPE_SETUP_ID
        public List<Site_view> Get_Site_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID)
        {
            List<Site_view> oList_Site_view = null;
            dynamic _params = new ExpandoObject();
            _params.VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_VIEW_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Site_view = new List<Site_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_OWNER_ID
        public List<Site_view> Get_Site_view_By_OWNER_ID(int? OWNER_ID)
        {
            List<Site_view> oList_Site_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Site_view = new List<Site_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_SITE_ID
        public List<Site_view> Get_Site_view_By_SITE_ID(long? SITE_ID)
        {
            List<Site_view> oList_Site_view = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_ID = SITE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_SITE_ID", _params);
            if (_query_response != null)
            {
                oList_Site_view = new List<Site_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID
        public List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID(int? OWNER_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID
        public List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID(long? LEVEL_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.LEVEL_ID = LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_LEVEL_ID", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID
        public List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_DATA_LEVEL_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_IS_DELETED
        public List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Entity_view_By_OWNER_ID
        public List<Entity_view> Get_Entity_view_By_OWNER_ID(int? OWNER_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID
        public List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            dynamic _params = new ExpandoObject();
            _params.VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_VIEW_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_OWNER_ID_IS_DELETED
        public List<Entity_view> Get_Entity_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Entity_view> oList_Entity_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_ID
        public List<Entity_view> Get_Entity_view_By_ENTITY_ID(long? ENTITY_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_ID = ENTITY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_ENTITY_ID", _params);
            if (_query_response != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Top_level_By_OWNER_ID
        public List<Top_level> Get_Top_level_By_OWNER_ID(int? OWNER_ID)
        {
            List<Top_level> oList_Top_level = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_TOP_LEVEL_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Top_level = new List<Top_level>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Top_level oTop_level = new Top_level();
                        Props.Copy_Prop_Values_From_Data_Record(element, oTop_level);
                        oList_Top_level.Add(oTop_level);
                    }
                }
            }
            return oList_Top_level;
        }
        #endregion
        #region Get_Top_level_By_OWNER_ID_IS_DELETED
        public List<Top_level> Get_Top_level_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Top_level> oList_Top_level = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_TOP_LEVEL_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Top_level = new List<Top_level>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Top_level oTop_level = new Top_level();
                        Props.Copy_Prop_Values_From_Data_Record(element, oTop_level);
                        oList_Top_level.Add(oTop_level);
                    }
                }
            }
            return oList_Top_level;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_OWNER_ID
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_OWNER_ID(int? OWNER_ID)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_USER_ACCESS_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_USER_ID
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_USER_ID(long? USER_ID)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_USER_ACCESS_BY_USER_ID", _params);
            if (_query_response != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_ID
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_ID(long? AREA_ID)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.AREA_ID = AREA_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_USER_ACCESS_BY_AREA_ID", _params);
            if (_query_response != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_USER_ACCESS_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
            if (_query_response != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_USER_ACCESS_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_OWNER_ID
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_OWNER_ID(int? OWNER_ID)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_USER_ACCESS_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_USER_ID
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_USER_ID(long? USER_ID)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_USER_ACCESS_BY_USER_ID", _params);
            if (_query_response != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_ID
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_ID(long? SITE_ID)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_ID = SITE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_USER_ACCESS_BY_SITE_ID", _params);
            if (_query_response != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_USER_ACCESS_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
            if (_query_response != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_USER_ACCESS_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_OWNER_ID_IS_DELETED
        public List<Entity_kpi> Get_Entity_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_kpi_By_OWNER_ID
        public List<Entity_kpi> Get_Entity_kpi_By_OWNER_ID(int? OWNER_ID)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<Entity_kpi> Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
            if (_query_response != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_kpi_By_ENTITY_ID
        public List<Entity_kpi> Get_Entity_kpi_By_ENTITY_ID(long? ENTITY_ID)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_ID = ENTITY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_BY_ENTITY_ID", _params);
            if (_query_response != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_OWNER_ID_IS_DELETED
        public List<Entity> Get_Entity_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_OWNER_ID
        public List<Entity> Get_Entity_By_OWNER_ID(int? OWNER_ID)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_SITE_ID
        public List<Entity> Get_Entity_By_SITE_ID(long? SITE_ID)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_ID = SITE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_SITE_ID", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_AREA_ID
        public List<Entity> Get_Entity_By_AREA_ID(long? AREA_ID)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.AREA_ID = AREA_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_AREA_ID", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_DISTRICT_ID
        public List<Entity> Get_Entity_By_DISTRICT_ID(long? DISTRICT_ID)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_ID = DISTRICT_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_DISTRICT_ID", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_REGION_ID
        public List<Entity> Get_Entity_By_REGION_ID(long? REGION_ID)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.REGION_ID = REGION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_REGION_ID", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID
        public List<Entity> Get_Entity_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.TOP_LEVEL_ID = TOP_LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_TOP_LEVEL_ID", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID
        public List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID(long? ENTITY_TYPE_SETUP_ID)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_TYPE_SETUP_ID = ENTITY_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_ENTITY_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_OWNER_ID
        public List<District_kpi> Get_District_kpi_By_OWNER_ID(int? OWNER_ID)
        {
            List<District_kpi> oList_District_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<District_kpi> Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<District_kpi> oList_District_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
            if (_query_response != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_District_kpi_By_OWNER_ID_IS_DELETED
        public List<District_kpi> Get_District_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<District_kpi> oList_District_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_District_kpi_By_DISTRICT_ID
        public List<District_kpi> Get_District_kpi_By_DISTRICT_ID(long? DISTRICT_ID)
        {
            List<District_kpi> oList_District_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_ID = DISTRICT_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_BY_DISTRICT_ID", _params);
            if (_query_response != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_User_level_access_By_OWNER_ID
        public List<User_level_access> Get_User_level_access_By_OWNER_ID(int? OWNER_ID)
        {
            List<User_level_access> oList_User_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_level_access);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID
        public List<User_level_access> Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID(long? ORGANIZATION_LEVEL_ACCESS_ID)
        {
            List<User_level_access> oList_User_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_LEVEL_ACCESS_ID = ORGANIZATION_LEVEL_ACCESS_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_ORGANIZATION_LEVEL_ACCESS_ID", _params);
            if (_query_response != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_level_access);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_USER_ID
        public List<User_level_access> Get_User_level_access_By_USER_ID(long? USER_ID)
        {
            List<User_level_access> oList_User_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_USER_ID", _params);
            if (_query_response != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_level_access);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_LEVEL_ID
        public List<User_level_access> Get_User_level_access_By_LEVEL_ID(long? LEVEL_ID)
        {
            List<User_level_access> oList_User_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.LEVEL_ID = LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_LEVEL_ID", _params);
            if (_query_response != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_level_access);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_DATA_LEVEL_SETUP_ID
        public List<User_level_access> Get_User_level_access_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID)
        {
            List<User_level_access> oList_User_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_DATA_LEVEL_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_level_access);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_OWNER_ID_IS_DELETED
        public List<User_level_access> Get_User_level_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<User_level_access> oList_User_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_level_access);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID
        public List<User_level_access> Get_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID(long? USER_ID, long? DATA_LEVEL_SETUP_ID)
        {
            List<User_level_access> oList_User_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            _params.DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_USER_ID_DATA_LEVEL_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_level_access);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_districtnex_module_By_OWNER_ID
        public List<User_districtnex_module> Get_User_districtnex_module_By_OWNER_ID(int? OWNER_ID)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_DISTRICTNEX_MODULE_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_districtnex_module);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_User_districtnex_module_By_USER_ID
        public List<User_districtnex_module> Get_User_districtnex_module_By_USER_ID(long? USER_ID)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_DISTRICTNEX_MODULE_BY_USER_ID", _params);
            if (_query_response != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_districtnex_module);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID
        public List<User_districtnex_module> Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID(int? DISTRICTNEX_MODULE_ID)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICTNEX_MODULE_ID = DISTRICTNEX_MODULE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_DISTRICTNEX_MODULE_BY_DISTRICTNEX_MODULE_ID", _params);
            if (_query_response != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_districtnex_module);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_User_districtnex_module_By_OWNER_ID_IS_DELETED
        public List<User_districtnex_module> Get_User_districtnex_module_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_DISTRICTNEX_MODULE_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_districtnex_module);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_OWNER_ID
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_OWNER_ID(int? OWNER_ID)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_USER_ACCESS_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_USER_ID
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_USER_ID(long? USER_ID)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_USER_ACCESS_BY_USER_ID", _params);
            if (_query_response != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_ID
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_ID(long? ENTITY_ID)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_ID = ENTITY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_USER_ACCESS_BY_ENTITY_ID", _params);
            if (_query_response != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_USER_ACCESS_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
            if (_query_response != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_USER_ACCESS_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_District_view_By_OWNER_ID
        public List<District_view> Get_District_view_By_OWNER_ID(int? OWNER_ID)
        {
            List<District_view> oList_District_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_District_view = new List<District_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            return oList_District_view;
        }
        #endregion
        #region Get_District_view_By_DISTRICT_ID
        public List<District_view> Get_District_view_By_DISTRICT_ID(long? DISTRICT_ID)
        {
            List<District_view> oList_District_view = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_ID = DISTRICT_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_DISTRICT_ID", _params);
            if (_query_response != null)
            {
                oList_District_view = new List<District_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            return oList_District_view;
        }
        #endregion
        #region Get_District_view_By_VIEW_TYPE_SETUP_ID
        public List<District_view> Get_District_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID)
        {
            List<District_view> oList_District_view = null;
            dynamic _params = new ExpandoObject();
            _params.VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_VIEW_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_District_view = new List<District_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            return oList_District_view;
        }
        #endregion
        #region Get_District_view_By_OWNER_ID_IS_DELETED
        public List<District_view> Get_District_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<District_view> oList_District_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_District_view = new List<District_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            return oList_District_view;
        }
        #endregion
        #region Get_Area_By_OWNER_ID_IS_DELETED
        public List<Area> Get_Area_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Area> oList_Area = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Area = new List<Area>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_OWNER_ID
        public List<Area> Get_Area_By_OWNER_ID(int? OWNER_ID)
        {
            List<Area> oList_Area = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Area = new List<Area>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_DISTRICT_ID
        public List<Area> Get_Area_By_DISTRICT_ID(long? DISTRICT_ID)
        {
            List<Area> oList_Area = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_ID = DISTRICT_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_DISTRICT_ID", _params);
            if (_query_response != null)
            {
                oList_Area = new List<Area>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_REGION_ID
        public List<Area> Get_Area_By_REGION_ID(long? REGION_ID)
        {
            List<Area> oList_Area = null;
            dynamic _params = new ExpandoObject();
            _params.REGION_ID = REGION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_REGION_ID", _params);
            if (_query_response != null)
            {
                oList_Area = new List<Area>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_TOP_LEVEL_ID
        public List<Area> Get_Area_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID)
        {
            List<Area> oList_Area = null;
            dynamic _params = new ExpandoObject();
            _params.TOP_LEVEL_ID = TOP_LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_TOP_LEVEL_ID", _params);
            if (_query_response != null)
            {
                oList_Area = new List<Area>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_OWNER_ID
        public List<Area_view> Get_Area_view_By_OWNER_ID(int? OWNER_ID)
        {
            List<Area_view> oList_Area_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Area_view = new List<Area_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_AREA_ID
        public List<Area_view> Get_Area_view_By_AREA_ID(long? AREA_ID)
        {
            List<Area_view> oList_Area_view = null;
            dynamic _params = new ExpandoObject();
            _params.AREA_ID = AREA_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_AREA_ID", _params);
            if (_query_response != null)
            {
                oList_Area_view = new List<Area_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_VIEW_TYPE_SETUP_ID
        public List<Area_view> Get_Area_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID)
        {
            List<Area_view> oList_Area_view = null;
            dynamic _params = new ExpandoObject();
            _params.VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_VIEW_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Area_view = new List<Area_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_OWNER_ID_IS_DELETED
        public List<Area_view> Get_Area_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Area_view> oList_Area_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Area_view = new List<Area_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Site_kpi_By_OWNER_ID
        public List<Site_kpi> Get_Site_kpi_By_OWNER_ID(int? OWNER_ID)
        {
            List<Site_kpi> oList_Site_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<Site_kpi> Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Site_kpi> oList_Site_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
            if (_query_response != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Site_kpi_By_OWNER_ID_IS_DELETED
        public List<Site_kpi> Get_Site_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Site_kpi> oList_Site_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Site_kpi_By_SITE_ID
        public List<Site_kpi> Get_Site_kpi_By_SITE_ID(long? SITE_ID)
        {
            List<Site_kpi> oList_Site_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_ID = SITE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_BY_SITE_ID", _params);
            if (_query_response != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID
        public List<Setup_category> Get_Setup_category_By_OWNER_ID(int? OWNER_ID)
        {
            List<Setup_category> oList_Setup_category = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID_IS_DELETED
        public List<Setup_category> Get_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Setup_category> oList_Setup_category = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID)
        {
            Setup_category oSetup_category = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME;
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_SETUP_CATEGORY_NAME_OWNER_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup_category = new Setup_category();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup_category);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Organization_relation_By_OWNER_ID_IS_DELETED
        public List<Organization_relation> Get_Organization_relation_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_OWNER_ID
        public List<Organization_relation> Get_Organization_relation_By_OWNER_ID(int? OWNER_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID
        public List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID(int? PARENT_ORGANIZATION_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.PARENT_ORGANIZATION_ID = PARENT_ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_PARENT_ORGANIZATION_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID
        public List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID(int? CHILD_ORGANIZATION_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.CHILD_ORGANIZATION_ID = CHILD_ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_CHILD_ORGANIZATION_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_USER_ID
        public List<Organization_relation> Get_Organization_relation_By_USER_ID(long? USER_ID)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_USER_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            _params.VALUE = VALUE;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_VALUE", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID
        public List<Setup> Get_Setup_By_OWNER_ID(int? OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_OWNER_ID_IS_DELETED
        public List<Area_kpi> Get_Area_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Area_kpi> oList_Area_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Area_kpi_By_OWNER_ID
        public List<Area_kpi> Get_Area_kpi_By_OWNER_ID(int? OWNER_ID)
        {
            List<Area_kpi> oList_Area_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Area_kpi_By_AREA_ID
        public List<Area_kpi> Get_Area_kpi_By_AREA_ID(long? AREA_ID)
        {
            List<Area_kpi> oList_Area_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.AREA_ID = AREA_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_BY_AREA_ID", _params);
            if (_query_response != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<Area_kpi> Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<Area_kpi> oList_Area_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
            if (_query_response != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Region_By_OWNER_ID_IS_DELETED
        public List<Region> Get_Region_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Region> oList_Region = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Region = new List<Region>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_By_OWNER_ID
        public List<Region> Get_Region_By_OWNER_ID(int? OWNER_ID)
        {
            List<Region> oList_Region = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Region = new List<Region>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_By_TOP_LEVEL_ID
        public List<Region> Get_Region_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID)
        {
            List<Region> oList_Region = null;
            dynamic _params = new ExpandoObject();
            _params.TOP_LEVEL_ID = TOP_LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_BY_TOP_LEVEL_ID", _params);
            if (_query_response != null)
            {
                oList_Region = new List<Region>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            return oList_Region;
        }
        #endregion
        #region Get_District_By_OWNER_ID_IS_DELETED
        public List<District> Get_District_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<District> oList_District = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_District = new List<District>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_OWNER_ID
        public List<District> Get_District_By_OWNER_ID(int? OWNER_ID)
        {
            List<District> oList_District = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_District = new List<District>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_REGION_ID
        public List<District> Get_District_By_REGION_ID(long? REGION_ID)
        {
            List<District> oList_District = null;
            dynamic _params = new ExpandoObject();
            _params.REGION_ID = REGION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_REGION_ID", _params);
            if (_query_response != null)
            {
                oList_District = new List<District>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_TOP_LEVEL_ID
        public List<District> Get_District_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID)
        {
            List<District> oList_District = null;
            dynamic _params = new ExpandoObject();
            _params.TOP_LEVEL_ID = TOP_LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_TOP_LEVEL_ID", _params);
            if (_query_response != null)
            {
                oList_District = new List<District>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            return oList_District;
        }
        #endregion
        #region Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_USER_ACCESS_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_OWNER_ID
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_OWNER_ID(int? OWNER_ID)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_USER_ACCESS_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_USER_ID
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_USER_ID(long? USER_ID)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_USER_ACCESS_BY_USER_ID", _params);
            if (_query_response != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_ID
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_ID(long? DISTRICT_ID)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_ID = DISTRICT_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_USER_ACCESS_BY_DISTRICT_ID", _params);
            if (_query_response != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_USER_ACCESS_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
            if (_query_response != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_OWNER_ID_IS_DELETED
        public List<User> Get_User_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_USERNAME_OWNER_ID
        public User Get_User_By_USERNAME_OWNER_ID(string USERNAME, int? OWNER_ID)
        {
            User oUser = null;
            dynamic _params = new ExpandoObject();
            _params.USERNAME = USERNAME;
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_USER_BY_USERNAME_OWNER_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oUser);
            }
            return oUser;
        }
        #endregion
        #region Get_User_By_EMAIL_OWNER_ID
        public User Get_User_By_EMAIL_OWNER_ID(string EMAIL, int? OWNER_ID)
        {
            User oUser = null;
            dynamic _params = new ExpandoObject();
            _params.EMAIL = EMAIL;
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_USER_BY_EMAIL_OWNER_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oUser = new User();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oUser);
            }
            return oUser;
        }
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID
        public List<User> Get_User_By_USER_TYPE_SETUP_ID(long? USER_TYPE_SETUP_ID)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.USER_TYPE_SETUP_ID = USER_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_USER_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_ORGANIZATION_ID
        public List<User> Get_User_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_ORGANIZATION_ID", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_OWNER_ID
        public List<User> Get_User_By_OWNER_ID(int? OWNER_ID)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_IS_RECEIVE_EMAIL
        public List<User> Get_User_By_IS_RECEIVE_EMAIL(bool IS_RECEIVE_EMAIL)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.IS_RECEIVE_EMAIL = IS_RECEIVE_EMAIL;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_IS_RECEIVE_EMAIL", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_IS_DELETED
        public List<User> Get_User_By_IS_DELETED(bool IS_DELETED)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
        public List<User> Get_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(int? OWNER_ID, bool IS_ACTIVE, bool IS_DELETED)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_ACTIVE = IS_ACTIVE;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_OWNER_ID_IS_ACTIVE_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_Site_By_OWNER_ID_IS_DELETED
        public List<Site> Get_Site_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Site> oList_Site = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_OWNER_ID
        public List<Site> Get_Site_By_OWNER_ID(int? OWNER_ID)
        {
            List<Site> oList_Site = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_AREA_ID
        public List<Site> Get_Site_By_AREA_ID(long? AREA_ID)
        {
            List<Site> oList_Site = null;
            dynamic _params = new ExpandoObject();
            _params.AREA_ID = AREA_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_AREA_ID", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_DISTRICT_ID
        public List<Site> Get_Site_By_DISTRICT_ID(long? DISTRICT_ID)
        {
            List<Site> oList_Site = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_ID = DISTRICT_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_DISTRICT_ID", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_REGION_ID
        public List<Site> Get_Site_By_REGION_ID(long? REGION_ID)
        {
            List<Site> oList_Site = null;
            dynamic _params = new ExpandoObject();
            _params.REGION_ID = REGION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_REGION_ID", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_TOP_LEVEL_ID
        public List<Site> Get_Site_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID)
        {
            List<Site> oList_Site = null;
            dynamic _params = new ExpandoObject();
            _params.TOP_LEVEL_ID = TOP_LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_TOP_LEVEL_ID", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_User_theme_By_OWNER_ID
        public List<User_theme> Get_User_theme_By_OWNER_ID(int? OWNER_ID)
        {
            List<User_theme> oList_User_theme = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_THEME_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_User_theme = new List<User_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_theme);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_User_theme_By_USER_ID
        public List<User_theme> Get_User_theme_By_USER_ID(long? USER_ID)
        {
            List<User_theme> oList_User_theme = null;
            dynamic _params = new ExpandoObject();
            _params.USER_ID = USER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_THEME_BY_USER_ID", _params);
            if (_query_response != null)
            {
                oList_User_theme = new List<User_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_theme);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_User_theme_By_ORGANIZATION_THEME_ID
        public List<User_theme> Get_User_theme_By_ORGANIZATION_THEME_ID(int? ORGANIZATION_THEME_ID)
        {
            List<User_theme> oList_User_theme = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_THEME_ID = ORGANIZATION_THEME_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_THEME_BY_ORGANIZATION_THEME_ID", _params);
            if (_query_response != null)
            {
                oList_User_theme = new List<User_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_theme);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_User_theme_By_OWNER_ID_IS_DELETED
        public List<User_theme> Get_User_theme_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<User_theme> oList_User_theme = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_THEME_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_User_theme = new List<User_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_theme);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_Region_view_By_OWNER_ID
        public List<Region_view> Get_Region_view_By_OWNER_ID(int? OWNER_ID)
        {
            List<Region_view> oList_Region_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Region_view = new List<Region_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_REGION_ID
        public List<Region_view> Get_Region_view_By_REGION_ID(long? REGION_ID)
        {
            List<Region_view> oList_Region_view = null;
            dynamic _params = new ExpandoObject();
            _params.REGION_ID = REGION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_REGION_ID", _params);
            if (_query_response != null)
            {
                oList_Region_view = new List<Region_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_VIEW_TYPE_SETUP_ID
        public List<Region_view> Get_Region_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID)
        {
            List<Region_view> oList_Region_view = null;
            dynamic _params = new ExpandoObject();
            _params.VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_VIEW_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Region_view = new List<Region_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_OWNER_ID_IS_DELETED
        public List<Region_view> Get_Region_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Region_view> oList_Region_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Region_view = new List<Region_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Site_view_By_VIEW_TYPE_SETUP_ID_List
        public List<Site_view> Get_Site_view_By_VIEW_TYPE_SETUP_ID_List(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST)
        {
            List<Site_view> oList_Site_view = null;
            if (VIEW_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIEW_TYPE_SETUP_ID_LIST = string.Join(",", VIEW_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_VIEW_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site_view = new List<Site_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_view oSite_view = new Site_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                            oList_Site_view.Add(oSite_view);
                        }
                    }
                }
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_SITE_ID_List
        public List<Site_view> Get_Site_view_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST)
        {
            List<Site_view> oList_Site_view = null;
            if (SITE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_ID_LIST = string.Join(",", SITE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_SITE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site_view = new List<Site_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_view oSite_view = new Site_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                            oList_Site_view.Add(oSite_view);
                        }
                    }
                }
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_List
        public List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_List(IEnumerable<long?> LEVEL_ID_LIST)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            if (LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.LEVEL_ID_LIST = string.Join(",", LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_LEVEL_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Removed_extrusion = new List<Removed_extrusion>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                            oList_Removed_extrusion.Add(oRemoved_extrusion);
                        }
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List
        public List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            if (DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DATA_LEVEL_SETUP_ID_LIST = string.Join(",", DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_DATA_LEVEL_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Removed_extrusion = new List<Removed_extrusion>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                            oList_Removed_extrusion.Add(oRemoved_extrusion);
                        }
                    }
                }
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List
        public List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST)
        {
            List<Entity_view> oList_Entity_view = null;
            if (VIEW_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIEW_TYPE_SETUP_ID_LIST = string.Join(",", VIEW_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_VIEW_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity_view = new List<Entity_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity_view oEntity_view = new Entity_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                            oList_Entity_view.Add(oEntity_view);
                        }
                    }
                }
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_ID_List
        public List<Entity_view> Get_Entity_view_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST)
        {
            List<Entity_view> oList_Entity_view = null;
            if (ENTITY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_ID_LIST = string.Join(",", ENTITY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_ENTITY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity_view = new List<Entity_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity_view oEntity_view = new Entity_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                            oList_Entity_view.Add(oEntity_view);
                        }
                    }
                }
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_USER_ID_List
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_USER_ACCESS_BY_USER_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi_user_access);
                            oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                        }
                    }
                }
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_AREA_ID_List
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_AREA_ID_List(IEnumerable<long?> AREA_ID_LIST)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            if (AREA_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.AREA_ID_LIST = string.Join(",", AREA_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_USER_ACCESS_BY_AREA_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi_user_access);
                            oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                        }
                    }
                }
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_USER_ACCESS_BY_ORGANIZATION_DATA_SOURCE_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi_user_access);
                            oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                        }
                    }
                }
            }
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_USER_ID_List
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_USER_ACCESS_BY_USER_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi_user_access);
                            oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                        }
                    }
                }
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_SITE_ID_List
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            if (SITE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_ID_LIST = string.Join(",", SITE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_USER_ACCESS_BY_SITE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi_user_access);
                            oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                        }
                    }
                }
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_USER_ACCESS_BY_ORGANIZATION_DATA_SOURCE_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi_user_access);
                            oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                        }
                    }
                }
            }
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Entity_kpi> Get_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity_kpi = new List<Entity_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity_kpi oEntity_kpi = new Entity_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi);
                            oList_Entity_kpi.Add(oEntity_kpi);
                        }
                    }
                }
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_kpi_By_ENTITY_ID_List
        public List<Entity_kpi> Get_Entity_kpi_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            if (ENTITY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_ID_LIST = string.Join(",", ENTITY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_BY_ENTITY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity_kpi = new List<Entity_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity_kpi oEntity_kpi = new Entity_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi);
                            oList_Entity_kpi.Add(oEntity_kpi);
                        }
                    }
                }
            }
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_SITE_ID_List
        public List<Entity> Get_Entity_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST)
        {
            List<Entity> oList_Entity = null;
            if (SITE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_ID_LIST = string.Join(",", SITE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_SITE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity = new List<Entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity oEntity = new Entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                            oList_Entity.Add(oEntity);
                        }
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_AREA_ID_List
        public List<Entity> Get_Entity_By_AREA_ID_List(IEnumerable<long?> AREA_ID_LIST)
        {
            List<Entity> oList_Entity = null;
            if (AREA_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.AREA_ID_LIST = string.Join(",", AREA_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_AREA_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity = new List<Entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity oEntity = new Entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                            oList_Entity.Add(oEntity);
                        }
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_DISTRICT_ID_List
        public List<Entity> Get_Entity_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST)
        {
            List<Entity> oList_Entity = null;
            if (DISTRICT_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_ID_LIST = string.Join(",", DISTRICT_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_DISTRICT_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity = new List<Entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity oEntity = new Entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                            oList_Entity.Add(oEntity);
                        }
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_REGION_ID_List
        public List<Entity> Get_Entity_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST)
        {
            List<Entity> oList_Entity = null;
            if (REGION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REGION_ID_LIST = string.Join(",", REGION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_REGION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity = new List<Entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity oEntity = new Entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                            oList_Entity.Add(oEntity);
                        }
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID_List
        public List<Entity> Get_Entity_By_TOP_LEVEL_ID_List(IEnumerable<long?> TOP_LEVEL_ID_LIST)
        {
            List<Entity> oList_Entity = null;
            if (TOP_LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.TOP_LEVEL_ID_LIST = string.Join(",", TOP_LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_TOP_LEVEL_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity = new List<Entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity oEntity = new Entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                            oList_Entity.Add(oEntity);
                        }
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID_List
        public List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID_List(IEnumerable<long?> ENTITY_TYPE_SETUP_ID_LIST)
        {
            List<Entity> oList_Entity = null;
            if (ENTITY_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_TYPE_SETUP_ID_LIST = string.Join(",", ENTITY_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_ENTITY_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity = new List<Entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity oEntity = new Entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                            oList_Entity.Add(oEntity);
                        }
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<District_kpi> Get_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST)
        {
            List<District_kpi> oList_District_kpi = null;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_District_kpi = new List<District_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District_kpi oDistrict_kpi = new District_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi);
                            oList_District_kpi.Add(oDistrict_kpi);
                        }
                    }
                }
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_District_kpi_By_DISTRICT_ID_List
        public List<District_kpi> Get_District_kpi_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST)
        {
            List<District_kpi> oList_District_kpi = null;
            if (DISTRICT_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_ID_LIST = string.Join(",", DISTRICT_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_BY_DISTRICT_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_District_kpi = new List<District_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District_kpi oDistrict_kpi = new District_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi);
                            oList_District_kpi.Add(oDistrict_kpi);
                        }
                    }
                }
            }
            return oList_District_kpi;
        }
        #endregion
        #region Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List
        public List<User_level_access> Get_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID_List(IEnumerable<long?> ORGANIZATION_LEVEL_ACCESS_ID_LIST)
        {
            List<User_level_access> oList_User_level_access = null;
            if (ORGANIZATION_LEVEL_ACCESS_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_LEVEL_ACCESS_ID_LIST = string.Join(",", ORGANIZATION_LEVEL_ACCESS_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_ORGANIZATION_LEVEL_ACCESS_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User_level_access = new List<User_level_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User_level_access oUser_level_access = new User_level_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser_level_access);
                            oList_User_level_access.Add(oUser_level_access);
                        }
                    }
                }
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_USER_ID_List
        public List<User_level_access> Get_User_level_access_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST)
        {
            List<User_level_access> oList_User_level_access = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_USER_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User_level_access = new List<User_level_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User_level_access oUser_level_access = new User_level_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser_level_access);
                            oList_User_level_access.Add(oUser_level_access);
                        }
                    }
                }
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_LEVEL_ID_List
        public List<User_level_access> Get_User_level_access_By_LEVEL_ID_List(IEnumerable<long?> LEVEL_ID_LIST)
        {
            List<User_level_access> oList_User_level_access = null;
            if (LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.LEVEL_ID_LIST = string.Join(",", LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_LEVEL_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User_level_access = new List<User_level_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User_level_access oUser_level_access = new User_level_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser_level_access);
                            oList_User_level_access.Add(oUser_level_access);
                        }
                    }
                }
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List
        public List<User_level_access> Get_User_level_access_By_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST)
        {
            List<User_level_access> oList_User_level_access = null;
            if (DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DATA_LEVEL_SETUP_ID_LIST = string.Join(",", DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_DATA_LEVEL_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User_level_access = new List<User_level_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User_level_access oUser_level_access = new User_level_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser_level_access);
                            oList_User_level_access.Add(oUser_level_access);
                        }
                    }
                }
            }
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_districtnex_module_By_USER_ID_List
        public List<User_districtnex_module> Get_User_districtnex_module_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_DISTRICTNEX_MODULE_BY_USER_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User_districtnex_module = new List<User_districtnex_module>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser_districtnex_module);
                            oList_User_districtnex_module.Add(oUser_districtnex_module);
                        }
                    }
                }
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List
        public List<User_districtnex_module> Get_User_districtnex_module_By_DISTRICTNEX_MODULE_ID_List(IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            if (DISTRICTNEX_MODULE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICTNEX_MODULE_ID_LIST = string.Join(",", DISTRICTNEX_MODULE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_DISTRICTNEX_MODULE_BY_DISTRICTNEX_MODULE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User_districtnex_module = new List<User_districtnex_module>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser_districtnex_module);
                            oList_User_districtnex_module.Add(oUser_districtnex_module);
                        }
                    }
                }
            }
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_USER_ID_List
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_USER_ACCESS_BY_USER_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi_user_access);
                            oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                        }
                    }
                }
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ENTITY_ID_List
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            if (ENTITY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_ID_LIST = string.Join(",", ENTITY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_USER_ACCESS_BY_ENTITY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi_user_access);
                            oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                        }
                    }
                }
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_USER_ACCESS_BY_ORGANIZATION_DATA_SOURCE_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi_user_access);
                            oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                        }
                    }
                }
            }
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_District_view_By_DISTRICT_ID_List
        public List<District_view> Get_District_view_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST)
        {
            List<District_view> oList_District_view = null;
            if (DISTRICT_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_ID_LIST = string.Join(",", DISTRICT_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_DISTRICT_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_District_view = new List<District_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District_view oDistrict_view = new District_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                            oList_District_view.Add(oDistrict_view);
                        }
                    }
                }
            }
            return oList_District_view;
        }
        #endregion
        #region Get_District_view_By_VIEW_TYPE_SETUP_ID_List
        public List<District_view> Get_District_view_By_VIEW_TYPE_SETUP_ID_List(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST)
        {
            List<District_view> oList_District_view = null;
            if (VIEW_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIEW_TYPE_SETUP_ID_LIST = string.Join(",", VIEW_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_VIEW_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_District_view = new List<District_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District_view oDistrict_view = new District_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                            oList_District_view.Add(oDistrict_view);
                        }
                    }
                }
            }
            return oList_District_view;
        }
        #endregion
        #region Get_Area_By_DISTRICT_ID_List
        public List<Area> Get_Area_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST)
        {
            List<Area> oList_Area = null;
            if (DISTRICT_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_ID_LIST = string.Join(",", DISTRICT_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_DISTRICT_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Area = new List<Area>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area oArea = new Area();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                            oList_Area.Add(oArea);
                        }
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_REGION_ID_List
        public List<Area> Get_Area_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST)
        {
            List<Area> oList_Area = null;
            if (REGION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REGION_ID_LIST = string.Join(",", REGION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_REGION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Area = new List<Area>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area oArea = new Area();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                            oList_Area.Add(oArea);
                        }
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_TOP_LEVEL_ID_List
        public List<Area> Get_Area_By_TOP_LEVEL_ID_List(IEnumerable<long?> TOP_LEVEL_ID_LIST)
        {
            List<Area> oList_Area = null;
            if (TOP_LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.TOP_LEVEL_ID_LIST = string.Join(",", TOP_LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_TOP_LEVEL_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Area = new List<Area>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area oArea = new Area();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                            oList_Area.Add(oArea);
                        }
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_AREA_ID_List
        public List<Area_view> Get_Area_view_By_AREA_ID_List(IEnumerable<long?> AREA_ID_LIST)
        {
            List<Area_view> oList_Area_view = null;
            if (AREA_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.AREA_ID_LIST = string.Join(",", AREA_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_AREA_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Area_view = new List<Area_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area_view oArea_view = new Area_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                            oList_Area_view.Add(oArea_view);
                        }
                    }
                }
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_VIEW_TYPE_SETUP_ID_List
        public List<Area_view> Get_Area_view_By_VIEW_TYPE_SETUP_ID_List(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST)
        {
            List<Area_view> oList_Area_view = null;
            if (VIEW_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIEW_TYPE_SETUP_ID_LIST = string.Join(",", VIEW_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_VIEW_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Area_view = new List<Area_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area_view oArea_view = new Area_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                            oList_Area_view.Add(oArea_view);
                        }
                    }
                }
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Site_kpi> Get_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST)
        {
            List<Site_kpi> oList_Site_kpi = null;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site_kpi = new List<Site_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_kpi oSite_kpi = new Site_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi);
                            oList_Site_kpi.Add(oSite_kpi);
                        }
                    }
                }
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Site_kpi_By_SITE_ID_List
        public List<Site_kpi> Get_Site_kpi_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST)
        {
            List<Site_kpi> oList_Site_kpi = null;
            if (SITE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_ID_LIST = string.Join(",", SITE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_BY_SITE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site_kpi = new List<Site_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_kpi oSite_kpi = new Site_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi);
                            oList_Site_kpi.Add(oSite_kpi);
                        }
                    }
                }
            }
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List
        public List<Organization_relation> Get_Organization_relation_By_PARENT_ORGANIZATION_ID_List(IEnumerable<int?> PARENT_ORGANIZATION_ID_LIST)
        {
            List<Organization_relation> oList_Organization_relation = null;
            if (PARENT_ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.PARENT_ORGANIZATION_ID_LIST = string.Join(",", PARENT_ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_PARENT_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_relation = new List<Organization_relation>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_relation oOrganization_relation = new Organization_relation();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                            oList_Organization_relation.Add(oOrganization_relation);
                        }
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List
        public List<Organization_relation> Get_Organization_relation_By_CHILD_ORGANIZATION_ID_List(IEnumerable<int?> CHILD_ORGANIZATION_ID_LIST)
        {
            List<Organization_relation> oList_Organization_relation = null;
            if (CHILD_ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.CHILD_ORGANIZATION_ID_LIST = string.Join(",", CHILD_ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_CHILD_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_relation = new List<Organization_relation>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_relation oOrganization_relation = new Organization_relation();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                            oList_Organization_relation.Add(oOrganization_relation);
                        }
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Organization_relation_By_USER_ID_List
        public List<Organization_relation> Get_Organization_relation_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST)
        {
            List<Organization_relation> oList_Organization_relation = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_USER_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_relation = new List<Organization_relation>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_relation oOrganization_relation = new Organization_relation();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                            oList_Organization_relation.Add(oOrganization_relation);
                        }
                    }
                }
            }
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_AREA_ID_List
        public List<Area_kpi> Get_Area_kpi_By_AREA_ID_List(IEnumerable<long?> AREA_ID_LIST)
        {
            List<Area_kpi> oList_Area_kpi = null;
            if (AREA_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.AREA_ID_LIST = string.Join(",", AREA_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_BY_AREA_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Area_kpi = new List<Area_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area_kpi oArea_kpi = new Area_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi);
                            oList_Area_kpi.Add(oArea_kpi);
                        }
                    }
                }
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Area_kpi> Get_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST)
        {
            List<Area_kpi> oList_Area_kpi = null;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Area_kpi = new List<Area_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area_kpi oArea_kpi = new Area_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi);
                            oList_Area_kpi.Add(oArea_kpi);
                        }
                    }
                }
            }
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Region_By_TOP_LEVEL_ID_List
        public List<Region> Get_Region_By_TOP_LEVEL_ID_List(IEnumerable<long?> TOP_LEVEL_ID_LIST)
        {
            List<Region> oList_Region = null;
            if (TOP_LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.TOP_LEVEL_ID_LIST = string.Join(",", TOP_LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_BY_TOP_LEVEL_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Region = new List<Region>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Region oRegion = new Region();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRegion);
                            oList_Region.Add(oRegion);
                        }
                    }
                }
            }
            return oList_Region;
        }
        #endregion
        #region Get_District_By_REGION_ID_List
        public List<District> Get_District_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST)
        {
            List<District> oList_District = null;
            if (REGION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REGION_ID_LIST = string.Join(",", REGION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_REGION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_District = new List<District>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District oDistrict = new District();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                            oList_District.Add(oDistrict);
                        }
                    }
                }
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_TOP_LEVEL_ID_List
        public List<District> Get_District_By_TOP_LEVEL_ID_List(IEnumerable<long?> TOP_LEVEL_ID_LIST)
        {
            List<District> oList_District = null;
            if (TOP_LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.TOP_LEVEL_ID_LIST = string.Join(",", TOP_LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_TOP_LEVEL_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_District = new List<District>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District oDistrict = new District();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                            oList_District.Add(oDistrict);
                        }
                    }
                }
            }
            return oList_District;
        }
        #endregion
        #region Get_District_kpi_user_access_By_USER_ID_List
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_USER_ACCESS_BY_USER_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_District_kpi_user_access = new List<District_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi_user_access);
                            oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                        }
                    }
                }
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_DISTRICT_ID_List
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            if (DISTRICT_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_ID_LIST = string.Join(",", DISTRICT_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_USER_ACCESS_BY_DISTRICT_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_District_kpi_user_access = new List<District_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi_user_access);
                            oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                        }
                    }
                }
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_USER_ACCESS_BY_ORGANIZATION_DATA_SOURCE_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_District_kpi_user_access = new List<District_kpi_user_access>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi_user_access);
                            oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                        }
                    }
                }
            }
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_USER_TYPE_SETUP_ID_List
        public List<User> Get_User_By_USER_TYPE_SETUP_ID_List(IEnumerable<long?> USER_TYPE_SETUP_ID_LIST)
        {
            List<User> oList_User = null;
            if (USER_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_TYPE_SETUP_ID_LIST = string.Join(",", USER_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_USER_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User = new List<User>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User oUser = new User();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                            oList_User.Add(oUser);
                        }
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_User_By_ORGANIZATION_ID_List
        public List<User> Get_User_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<User> oList_User = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User = new List<User>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User oUser = new User();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                            oList_User.Add(oUser);
                        }
                    }
                }
            }
            return oList_User;
        }
        #endregion
        #region Get_Site_By_AREA_ID_List
        public List<Site> Get_Site_By_AREA_ID_List(IEnumerable<long?> AREA_ID_LIST)
        {
            List<Site> oList_Site = null;
            if (AREA_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.AREA_ID_LIST = string.Join(",", AREA_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_AREA_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site = new List<Site>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site oSite = new Site();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                            oList_Site.Add(oSite);
                        }
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_DISTRICT_ID_List
        public List<Site> Get_Site_By_DISTRICT_ID_List(IEnumerable<long?> DISTRICT_ID_LIST)
        {
            List<Site> oList_Site = null;
            if (DISTRICT_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_ID_LIST = string.Join(",", DISTRICT_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_DISTRICT_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site = new List<Site>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site oSite = new Site();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                            oList_Site.Add(oSite);
                        }
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_REGION_ID_List
        public List<Site> Get_Site_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST)
        {
            List<Site> oList_Site = null;
            if (REGION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REGION_ID_LIST = string.Join(",", REGION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_REGION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site = new List<Site>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site oSite = new Site();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                            oList_Site.Add(oSite);
                        }
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_TOP_LEVEL_ID_List
        public List<Site> Get_Site_By_TOP_LEVEL_ID_List(IEnumerable<long?> TOP_LEVEL_ID_LIST)
        {
            List<Site> oList_Site = null;
            if (TOP_LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.TOP_LEVEL_ID_LIST = string.Join(",", TOP_LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_TOP_LEVEL_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site = new List<Site>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site oSite = new Site();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                            oList_Site.Add(oSite);
                        }
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_User_theme_By_USER_ID_List
        public List<User_theme> Get_User_theme_By_USER_ID_List(IEnumerable<long?> USER_ID_LIST)
        {
            List<User_theme> oList_User_theme = null;
            if (USER_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.USER_ID_LIST = string.Join(",", USER_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_THEME_BY_USER_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User_theme = new List<User_theme>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User_theme oUser_theme = new User_theme();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser_theme);
                            oList_User_theme.Add(oUser_theme);
                        }
                    }
                }
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_User_theme_By_ORGANIZATION_THEME_ID_List
        public List<User_theme> Get_User_theme_By_ORGANIZATION_THEME_ID_List(IEnumerable<int?> ORGANIZATION_THEME_ID_LIST)
        {
            List<User_theme> oList_User_theme = null;
            if (ORGANIZATION_THEME_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_THEME_ID_LIST = string.Join(",", ORGANIZATION_THEME_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_THEME_BY_ORGANIZATION_THEME_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_User_theme = new List<User_theme>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            User_theme oUser_theme = new User_theme();
                            Props.Copy_Prop_Values_From_Data_Record(element, oUser_theme);
                            oList_User_theme.Add(oUser_theme);
                        }
                    }
                }
            }
            return oList_User_theme;
        }
        #endregion
        #region Get_Region_view_By_REGION_ID_List
        public List<Region_view> Get_Region_view_By_REGION_ID_List(IEnumerable<long?> REGION_ID_LIST)
        {
            List<Region_view> oList_Region_view = null;
            if (REGION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REGION_ID_LIST = string.Join(",", REGION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_REGION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Region_view = new List<Region_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Region_view oRegion_view = new Region_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                            oList_Region_view.Add(oRegion_view);
                        }
                    }
                }
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_VIEW_TYPE_SETUP_ID_List
        public List<Region_view> Get_Region_view_By_VIEW_TYPE_SETUP_ID_List(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST)
        {
            List<Region_view> oList_Region_view = null;
            if (VIEW_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIEW_TYPE_SETUP_ID_LIST = string.Join(",", VIEW_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_VIEW_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Region_view = new List<Region_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Region_view oRegion_view = new Region_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                            oList_Region_view.Add(oRegion_view);
                        }
                    }
                }
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Site_view_By_Where
        public List<Site_view> Get_Site_view_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Site_view> oList_Site_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Site_view = new List<Site_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site_view;
        }
        #endregion
        #region Get_Removed_extrusion_By_Where
        public List<Removed_extrusion> Get_Removed_extrusion_By_Where(string EXTRUSION_IDENTIFIER, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.EXTRUSION_IDENTIFIER = EXTRUSION_IDENTIFIER;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Entity_view_By_Where
        public List<Entity_view> Get_Entity_view_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Entity_view> oList_Entity_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Entity_view;
        }
        #endregion
        #region Get_Top_level_By_Where
        public List<Top_level> Get_Top_level_By_Where(string NAME, string LOCATION, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Top_level> oList_Top_level = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.LOCATION = LOCATION;
            _params.IMAGE_URL = IMAGE_URL;
            _params.LOGO_URL = LOGO_URL;
            _params.AREA_COLOR = AREA_COLOR;
            _params.BORDER_COLOR = BORDER_COLOR;
            _params.STUDY_ZONE_NAME = STUDY_ZONE_NAME;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_TOP_LEVEL_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Top_level = new List<Top_level>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Top_level oTop_level = new Top_level();
                        Props.Copy_Prop_Values_From_Data_Record(element, oTop_level);
                        oList_Top_level.Add(oTop_level);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Top_level;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_Where
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_USER_ACCESS_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_Where
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_USER_ACCESS_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_Where
        public List<Entity_kpi> Get_Entity_kpi_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_Where
        public List<Entity> Get_Entity_By_Where(string NAME, string GLA_UNIT, string UNIT, string IMAGE_URL, string SOLID_GLTF_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.GLA_UNIT = GLA_UNIT;
            _params.UNIT = UNIT;
            _params.IMAGE_URL = IMAGE_URL;
            _params.SOLID_GLTF_URL = SOLID_GLTF_URL;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_Where
        public List<District_kpi> Get_District_kpi_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<District_kpi> oList_District_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_District_kpi;
        }
        #endregion
        #region Get_User_level_access_By_Where
        public List<User_level_access> Get_User_level_access_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<User_level_access> oList_User_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_level_access);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_districtnex_module_By_Where
        public List<User_districtnex_module> Get_User_districtnex_module_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_DISTRICTNEX_MODULE_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_districtnex_module);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_Where
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_USER_ACCESS_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_District_view_By_Where
        public List<District_view> Get_District_view_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<District_view> oList_District_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_District_view = new List<District_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_District_view;
        }
        #endregion
        #region Get_Area_By_Where
        public List<Area> Get_Area_By_Where(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Area> oList_Area = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.LOCATION = LOCATION;
            _params.UNIT = UNIT;
            _params.IMAGE_URL = IMAGE_URL;
            _params.LOGO_URL = LOGO_URL;
            _params.SOLID_GLTF_URL = SOLID_GLTF_URL;
            _params.AREA_COLOR = AREA_COLOR;
            _params.BORDER_COLOR = BORDER_COLOR;
            _params.STUDY_ZONE_NAME = STUDY_ZONE_NAME;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Area = new List<Area>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_Where
        public List<Area_view> Get_Area_view_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Area_view> oList_Area_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Area_view = new List<Area_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Area_view;
        }
        #endregion
        #region Get_Site_kpi_By_Where
        public List<Site_kpi> Get_Site_kpi_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Site_kpi> oList_Site_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Setup_category_By_Where
        public List<Setup_category> Get_Setup_category_By_Where(string SETUP_CATEGORY_NAME, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup_category> oList_Setup_category = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME;
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_CATEGORY_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup_category;
        }
        #endregion
        #region Get_Organization_relation_By_Where
        public List<Organization_relation> Get_Organization_relation_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_Where
        public List<Setup> Get_Setup_By_Where(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.VALUE = VALUE;
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_Where
        public List<Area_kpi> Get_Area_kpi_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Area_kpi> oList_Area_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Region_By_Where
        public List<Region> Get_Region_By_Where(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Region> oList_Region = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.LOCATION = LOCATION;
            _params.UNIT = UNIT;
            _params.IMAGE_URL = IMAGE_URL;
            _params.LOGO_URL = LOGO_URL;
            _params.AREA_COLOR = AREA_COLOR;
            _params.BORDER_COLOR = BORDER_COLOR;
            _params.STUDY_ZONE_NAME = STUDY_ZONE_NAME;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Region = new List<Region>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Region;
        }
        #endregion
        #region Get_District_By_Where
        public List<District> Get_District_By_Where(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<District> oList_District = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.LOCATION = LOCATION;
            _params.UNIT = UNIT;
            _params.IMAGE_URL = IMAGE_URL;
            _params.LOGO_URL = LOGO_URL;
            _params.SOLID_GLTF_URL = SOLID_GLTF_URL;
            _params.AREA_COLOR = AREA_COLOR;
            _params.BORDER_COLOR = BORDER_COLOR;
            _params.STUDY_ZONE_NAME = STUDY_ZONE_NAME;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_District = new List<District>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_District;
        }
        #endregion
        #region Get_District_kpi_user_access_By_Where
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_USER_ACCESS_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_Where
        public List<User> Get_User_By_Where(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.FIRST_NAME = FIRST_NAME;
            _params.LAST_NAME = LAST_NAME;
            _params.USERNAME = USERNAME;
            _params.PASSWORD = PASSWORD;
            _params.EMAIL = EMAIL;
            _params.PHONE_NUMBER = PHONE_NUMBER;
            _params.IMAGE_URL = IMAGE_URL;
            _params.USER_DISTRICTNEX_WALKTHROUGH = USER_DISTRICTNEX_WALKTHROUGH;
            _params.USER_ADMIN_WALKTHROUGH = USER_ADMIN_WALKTHROUGH;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_User;
        }
        #endregion
        #region Get_Site_By_Where
        public List<Site> Get_Site_By_Where(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Site> oList_Site = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.LOCATION = LOCATION;
            _params.UNIT = UNIT;
            _params.IMAGE_URL = IMAGE_URL;
            _params.LOGO_URL = LOGO_URL;
            _params.SOLID_GLTF_URL = SOLID_GLTF_URL;
            _params.AREA_COLOR = AREA_COLOR;
            _params.BORDER_COLOR = BORDER_COLOR;
            _params.STUDY_ZONE_NAME = STUDY_ZONE_NAME;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site;
        }
        #endregion
        #region Get_User_theme_By_Where
        public List<User_theme> Get_User_theme_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<User_theme> oList_User_theme = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_THEME_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_User_theme = new List<User_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_theme);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_User_theme;
        }
        #endregion
        #region Get_Region_view_By_Where
        public List<Region_view> Get_Region_view_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Region_view> oList_Region_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Region_view = new List<Region_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Region_view;
        }
        #endregion
        #region Get_Site_view_By_Where_In_List
        public List<Site_view> Get_Site_view_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> SITE_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Site_view> oList_Site_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.SITE_ID_LIST = SITE_ID_LIST != null ? string.Join(",", SITE_ID_LIST) : "";
            _params.VIEW_TYPE_SETUP_ID_LIST = VIEW_TYPE_SETUP_ID_LIST != null ? string.Join(",", VIEW_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Site_view = new List<Site_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site_view;
        }
        #endregion
        #region Get_Removed_extrusion_By_Where_In_List
        public List<Removed_extrusion> Get_Removed_extrusion_By_Where_In_List(string EXTRUSION_IDENTIFIER, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            dynamic _params = new ExpandoObject();
            _params.EXTRUSION_IDENTIFIER = EXTRUSION_IDENTIFIER;
            _params.DATA_LEVEL_SETUP_ID_LIST = DATA_LEVEL_SETUP_ID_LIST != null ? string.Join(",", DATA_LEVEL_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REMOVED_EXTRUSION_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Entity_view_By_Where_In_List
        public List<Entity_view> Get_Entity_view_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> ENTITY_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Entity_view> oList_Entity_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.ENTITY_ID_LIST = ENTITY_ID_LIST != null ? string.Join(",", ENTITY_ID_LIST) : "";
            _params.VIEW_TYPE_SETUP_ID_LIST = VIEW_TYPE_SETUP_ID_LIST != null ? string.Join(",", VIEW_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Entity_view;
        }
        #endregion
        #region Get_Area_kpi_user_access_By_Where_In_List
        public List<Area_kpi_user_access> Get_Area_kpi_user_access_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> AREA_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Area_kpi_user_access> oList_Area_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.USER_ID_LIST = USER_ID_LIST != null ? string.Join(",", USER_ID_LIST) : "";
            _params.AREA_ID_LIST = AREA_ID_LIST != null ? string.Join(",", AREA_ID_LIST) : "";
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null ? string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_USER_ACCESS_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Area_kpi_user_access = new List<Area_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi_user_access);
                        oList_Area_kpi_user_access.Add(oArea_kpi_user_access);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Area_kpi_user_access;
        }
        #endregion
        #region Get_Site_kpi_user_access_By_Where_In_List
        public List<Site_kpi_user_access> Get_Site_kpi_user_access_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> SITE_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Site_kpi_user_access> oList_Site_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.USER_ID_LIST = USER_ID_LIST != null ? string.Join(",", USER_ID_LIST) : "";
            _params.SITE_ID_LIST = SITE_ID_LIST != null ? string.Join(",", SITE_ID_LIST) : "";
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null ? string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_USER_ACCESS_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Site_kpi_user_access = new List<Site_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi_user_access);
                        oList_Site_kpi_user_access.Add(oSite_kpi_user_access);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site_kpi_user_access;
        }
        #endregion
        #region Get_Entity_kpi_By_Where_In_List
        public List<Entity_kpi> Get_Entity_kpi_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> ENTITY_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Entity_kpi> oList_Entity_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.ENTITY_ID_LIST = ENTITY_ID_LIST != null ? string.Join(",", ENTITY_ID_LIST) : "";
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null ? string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Entity_kpi = new List<Entity_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_kpi oEntity_kpi = new Entity_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi);
                        oList_Entity_kpi.Add(oEntity_kpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Entity_kpi;
        }
        #endregion
        #region Get_Entity_By_Where_In_List
        public List<Entity> Get_Entity_By_Where_In_List(string NAME, string GLA_UNIT, string UNIT, string IMAGE_URL, string SOLID_GLTF_URL, IEnumerable<long?> SITE_ID_LIST, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, IEnumerable<long?> ENTITY_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.GLA_UNIT = GLA_UNIT;
            _params.UNIT = UNIT;
            _params.IMAGE_URL = IMAGE_URL;
            _params.SOLID_GLTF_URL = SOLID_GLTF_URL;
            _params.SITE_ID_LIST = SITE_ID_LIST != null ? string.Join(",", SITE_ID_LIST) : "";
            _params.AREA_ID_LIST = AREA_ID_LIST != null ? string.Join(",", AREA_ID_LIST) : "";
            _params.DISTRICT_ID_LIST = DISTRICT_ID_LIST != null ? string.Join(",", DISTRICT_ID_LIST) : "";
            _params.REGION_ID_LIST = REGION_ID_LIST != null ? string.Join(",", REGION_ID_LIST) : "";
            _params.TOP_LEVEL_ID_LIST = TOP_LEVEL_ID_LIST != null ? string.Join(",", TOP_LEVEL_ID_LIST) : "";
            _params.ENTITY_TYPE_SETUP_ID_LIST = ENTITY_TYPE_SETUP_ID_LIST != null ? string.Join(",", ENTITY_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Entity;
        }
        #endregion
        #region Get_District_kpi_By_Where_In_List
        public List<District_kpi> Get_District_kpi_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<District_kpi> oList_District_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.DISTRICT_ID_LIST = DISTRICT_ID_LIST != null ? string.Join(",", DISTRICT_ID_LIST) : "";
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null ? string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_District_kpi = new List<District_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_kpi oDistrict_kpi = new District_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi);
                        oList_District_kpi.Add(oDistrict_kpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_District_kpi;
        }
        #endregion
        #region Get_User_level_access_By_Where_In_List
        public List<User_level_access> Get_User_level_access_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> ORGANIZATION_LEVEL_ACCESS_ID_LIST, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<User_level_access> oList_User_level_access = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.ORGANIZATION_LEVEL_ACCESS_ID_LIST = ORGANIZATION_LEVEL_ACCESS_ID_LIST != null ? string.Join(",", ORGANIZATION_LEVEL_ACCESS_ID_LIST) : "";
            _params.USER_ID_LIST = USER_ID_LIST != null ? string.Join(",", USER_ID_LIST) : "";
            _params.DATA_LEVEL_SETUP_ID_LIST = DATA_LEVEL_SETUP_ID_LIST != null ? string.Join(",", DATA_LEVEL_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_LEVEL_ACCESS_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_User_level_access = new List<User_level_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_level_access oUser_level_access = new User_level_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_level_access);
                        oList_User_level_access.Add(oUser_level_access);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_User_level_access;
        }
        #endregion
        #region Get_User_districtnex_module_By_Where_In_List
        public List<User_districtnex_module> Get_User_districtnex_module_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<int?> DISTRICTNEX_MODULE_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<User_districtnex_module> oList_User_districtnex_module = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.USER_ID_LIST = USER_ID_LIST != null ? string.Join(",", USER_ID_LIST) : "";
            _params.DISTRICTNEX_MODULE_ID_LIST = DISTRICTNEX_MODULE_ID_LIST != null ? string.Join(",", DISTRICTNEX_MODULE_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_DISTRICTNEX_MODULE_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_User_districtnex_module = new List<User_districtnex_module>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_districtnex_module oUser_districtnex_module = new User_districtnex_module();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_districtnex_module);
                        oList_User_districtnex_module.Add(oUser_districtnex_module);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_User_districtnex_module;
        }
        #endregion
        #region Get_Entity_kpi_user_access_By_Where_In_List
        public List<Entity_kpi_user_access> Get_Entity_kpi_user_access_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> ENTITY_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Entity_kpi_user_access> oList_Entity_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.USER_ID_LIST = USER_ID_LIST != null ? string.Join(",", USER_ID_LIST) : "";
            _params.ENTITY_ID_LIST = ENTITY_ID_LIST != null ? string.Join(",", ENTITY_ID_LIST) : "";
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null ? string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_KPI_USER_ACCESS_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Entity_kpi_user_access = new List<Entity_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_kpi_user_access);
                        oList_Entity_kpi_user_access.Add(oEntity_kpi_user_access);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Entity_kpi_user_access;
        }
        #endregion
        #region Get_District_view_By_Where_In_List
        public List<District_view> Get_District_view_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<District_view> oList_District_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.DISTRICT_ID_LIST = DISTRICT_ID_LIST != null ? string.Join(",", DISTRICT_ID_LIST) : "";
            _params.VIEW_TYPE_SETUP_ID_LIST = VIEW_TYPE_SETUP_ID_LIST != null ? string.Join(",", VIEW_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_District_view = new List<District_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_District_view;
        }
        #endregion
        #region Get_Area_By_Where_In_List
        public List<Area> Get_Area_By_Where_In_List(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Area> oList_Area = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.LOCATION = LOCATION;
            _params.UNIT = UNIT;
            _params.IMAGE_URL = IMAGE_URL;
            _params.LOGO_URL = LOGO_URL;
            _params.SOLID_GLTF_URL = SOLID_GLTF_URL;
            _params.AREA_COLOR = AREA_COLOR;
            _params.BORDER_COLOR = BORDER_COLOR;
            _params.STUDY_ZONE_NAME = STUDY_ZONE_NAME;
            _params.DISTRICT_ID_LIST = DISTRICT_ID_LIST != null ? string.Join(",", DISTRICT_ID_LIST) : "";
            _params.REGION_ID_LIST = REGION_ID_LIST != null ? string.Join(",", REGION_ID_LIST) : "";
            _params.TOP_LEVEL_ID_LIST = TOP_LEVEL_ID_LIST != null ? string.Join(",", TOP_LEVEL_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Area = new List<Area>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                        oList_Area.Add(oArea);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_Where_In_List
        public List<Area_view> Get_Area_view_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Area_view> oList_Area_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.AREA_ID_LIST = AREA_ID_LIST != null ? string.Join(",", AREA_ID_LIST) : "";
            _params.VIEW_TYPE_SETUP_ID_LIST = VIEW_TYPE_SETUP_ID_LIST != null ? string.Join(",", VIEW_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Area_view = new List<Area_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Area_view;
        }
        #endregion
        #region Get_Site_kpi_By_Where_In_List
        public List<Site_kpi> Get_Site_kpi_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> SITE_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Site_kpi> oList_Site_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.SITE_ID_LIST = SITE_ID_LIST != null ? string.Join(",", SITE_ID_LIST) : "";
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null ? string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_KPI_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Site_kpi = new List<Site_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_kpi oSite_kpi = new Site_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_kpi);
                        oList_Site_kpi.Add(oSite_kpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site_kpi;
        }
        #endregion
        #region Get_Organization_relation_By_Where_In_List
        public List<Organization_relation> Get_Organization_relation_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_relation> oList_Organization_relation = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.USER_ID_LIST = USER_ID_LIST != null ? string.Join(",", USER_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_RELATION_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Organization_relation = new List<Organization_relation>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_relation oOrganization_relation = new Organization_relation();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_relation);
                        oList_Organization_relation.Add(oOrganization_relation);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_relation;
        }
        #endregion
        #region Get_Setup_By_Where_In_List
        public List<Setup> Get_Setup_By_Where_In_List(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.VALUE = VALUE;
            _params.DESCRIPTION = DESCRIPTION;
            _params.SETUP_CATEGORY_ID_LIST = SETUP_CATEGORY_ID_LIST != null ? string.Join(",", SETUP_CATEGORY_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_Area_kpi_By_Where_In_List
        public List<Area_kpi> Get_Area_kpi_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> AREA_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Area_kpi> oList_Area_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.AREA_ID_LIST = AREA_ID_LIST != null ? string.Join(",", AREA_ID_LIST) : "";
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null ? string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_KPI_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Area_kpi = new List<Area_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_kpi oArea_kpi = new Area_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_kpi);
                        oList_Area_kpi.Add(oArea_kpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Area_kpi;
        }
        #endregion
        #region Get_Region_By_Where_In_List
        public List<Region> Get_Region_By_Where_In_List(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Region> oList_Region = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.LOCATION = LOCATION;
            _params.UNIT = UNIT;
            _params.IMAGE_URL = IMAGE_URL;
            _params.LOGO_URL = LOGO_URL;
            _params.AREA_COLOR = AREA_COLOR;
            _params.BORDER_COLOR = BORDER_COLOR;
            _params.STUDY_ZONE_NAME = STUDY_ZONE_NAME;
            _params.TOP_LEVEL_ID_LIST = TOP_LEVEL_ID_LIST != null ? string.Join(",", TOP_LEVEL_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Region = new List<Region>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion);
                        oList_Region.Add(oRegion);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Region;
        }
        #endregion
        #region Get_District_By_Where_In_List
        public List<District> Get_District_By_Where_In_List(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<District> oList_District = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.LOCATION = LOCATION;
            _params.UNIT = UNIT;
            _params.IMAGE_URL = IMAGE_URL;
            _params.LOGO_URL = LOGO_URL;
            _params.SOLID_GLTF_URL = SOLID_GLTF_URL;
            _params.AREA_COLOR = AREA_COLOR;
            _params.BORDER_COLOR = BORDER_COLOR;
            _params.STUDY_ZONE_NAME = STUDY_ZONE_NAME;
            _params.REGION_ID_LIST = REGION_ID_LIST != null ? string.Join(",", REGION_ID_LIST) : "";
            _params.TOP_LEVEL_ID_LIST = TOP_LEVEL_ID_LIST != null ? string.Join(",", TOP_LEVEL_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_District = new List<District>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                        oList_District.Add(oDistrict);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_District;
        }
        #endregion
        #region Get_District_kpi_user_access_By_Where_In_List
        public List<District_kpi_user_access> Get_District_kpi_user_access_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<District_kpi_user_access> oList_District_kpi_user_access = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.USER_ID_LIST = USER_ID_LIST != null ? string.Join(",", USER_ID_LIST) : "";
            _params.DISTRICT_ID_LIST = DISTRICT_ID_LIST != null ? string.Join(",", DISTRICT_ID_LIST) : "";
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null ? string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_KPI_USER_ACCESS_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_District_kpi_user_access = new List<District_kpi_user_access>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_kpi_user_access);
                        oList_District_kpi_user_access.Add(oDistrict_kpi_user_access);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_District_kpi_user_access;
        }
        #endregion
        #region Get_User_By_Where_In_List
        public List<User> Get_User_By_Where_In_List(string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, IEnumerable<int?> ORGANIZATION_ID_LIST, IEnumerable<long?> USER_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<User> oList_User = null;
            dynamic _params = new ExpandoObject();
            _params.FIRST_NAME = FIRST_NAME;
            _params.LAST_NAME = LAST_NAME;
            _params.USERNAME = USERNAME;
            _params.PASSWORD = PASSWORD;
            _params.EMAIL = EMAIL;
            _params.PHONE_NUMBER = PHONE_NUMBER;
            _params.IMAGE_URL = IMAGE_URL;
            _params.USER_DISTRICTNEX_WALKTHROUGH = USER_DISTRICTNEX_WALKTHROUGH;
            _params.USER_ADMIN_WALKTHROUGH = USER_ADMIN_WALKTHROUGH;
            _params.ORGANIZATION_ID_LIST = ORGANIZATION_ID_LIST != null ? string.Join(",", ORGANIZATION_ID_LIST) : "";
            _params.USER_TYPE_SETUP_ID_LIST = USER_TYPE_SETUP_ID_LIST != null ? string.Join(",", USER_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_User = new List<User>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User oUser = new User();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser);
                        oList_User.Add(oUser);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_User;
        }
        #endregion
        #region Get_Site_By_Where_In_List
        public List<Site> Get_Site_By_Where_In_List(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Site> oList_Site = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.LOCATION = LOCATION;
            _params.UNIT = UNIT;
            _params.IMAGE_URL = IMAGE_URL;
            _params.LOGO_URL = LOGO_URL;
            _params.SOLID_GLTF_URL = SOLID_GLTF_URL;
            _params.AREA_COLOR = AREA_COLOR;
            _params.BORDER_COLOR = BORDER_COLOR;
            _params.STUDY_ZONE_NAME = STUDY_ZONE_NAME;
            _params.AREA_ID_LIST = AREA_ID_LIST != null ? string.Join(",", AREA_ID_LIST) : "";
            _params.DISTRICT_ID_LIST = DISTRICT_ID_LIST != null ? string.Join(",", DISTRICT_ID_LIST) : "";
            _params.REGION_ID_LIST = REGION_ID_LIST != null ? string.Join(",", REGION_ID_LIST) : "";
            _params.TOP_LEVEL_ID_LIST = TOP_LEVEL_ID_LIST != null ? string.Join(",", TOP_LEVEL_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oList_Site.Add(oSite);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site;
        }
        #endregion
        #region Get_User_theme_By_Where_In_List
        public List<User_theme> Get_User_theme_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> USER_ID_LIST, IEnumerable<int?> ORGANIZATION_THEME_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<User_theme> oList_User_theme = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.USER_ID_LIST = USER_ID_LIST != null ? string.Join(",", USER_ID_LIST) : "";
            _params.ORGANIZATION_THEME_ID_LIST = ORGANIZATION_THEME_ID_LIST != null ? string.Join(",", ORGANIZATION_THEME_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_USER_THEME_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_User_theme = new List<User_theme>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        User_theme oUser_theme = new User_theme();
                        Props.Copy_Prop_Values_From_Data_Record(element, oUser_theme);
                        oList_User_theme.Add(oUser_theme);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_User_theme;
        }
        #endregion
        #region Get_Region_view_By_Where_In_List
        public List<Region_view> Get_Region_view_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Region_view> oList_Region_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.REGION_ID_LIST = REGION_ID_LIST != null ? string.Join(",", REGION_ID_LIST) : "";
            _params.VIEW_TYPE_SETUP_ID_LIST = VIEW_TYPE_SETUP_ID_LIST != null ? string.Join(",", VIEW_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Region_view = new List<Region_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Region_view;
        }
        #endregion
        #region Delete_Site_view
        public void Delete_Site_view(long? SITE_VIEW_ID)
        {
            var _params = new
            {
                SITE_VIEW_ID = SITE_VIEW_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_VIEW", _params);
        }
        #endregion
        #region Delete_Removed_extrusion
        public void Delete_Removed_extrusion(int? REMOVED_EXTRUSION_ID)
        {
            var _params = new
            {
                REMOVED_EXTRUSION_ID = REMOVED_EXTRUSION_ID
            };
            ExecuteDelete("UPG_DELETE_REMOVED_EXTRUSION", _params);
        }
        #endregion
        #region Delete_Entity_view
        public void Delete_Entity_view(long? ENTITY_VIEW_ID)
        {
            var _params = new
            {
                ENTITY_VIEW_ID = ENTITY_VIEW_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_VIEW", _params);
        }
        #endregion
        #region Delete_Top_level
        public void Delete_Top_level(long? TOP_LEVEL_ID)
        {
            var _params = new
            {
                TOP_LEVEL_ID = TOP_LEVEL_ID
            };
            ExecuteDelete("UPG_DELETE_TOP_LEVEL", _params);
        }
        #endregion
        #region Delete_Area_kpi_user_access
        public void Delete_Area_kpi_user_access(long? AREA_KPI_USER_ACCESS_ID)
        {
            var _params = new
            {
                AREA_KPI_USER_ACCESS_ID = AREA_KPI_USER_ACCESS_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_KPI_USER_ACCESS", _params);
        }
        #endregion
        #region Delete_Site_kpi_user_access
        public void Delete_Site_kpi_user_access(long? SITE_KPI_USER_ACCESS_ID)
        {
            var _params = new
            {
                SITE_KPI_USER_ACCESS_ID = SITE_KPI_USER_ACCESS_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_KPI_USER_ACCESS", _params);
        }
        #endregion
        #region Delete_Entity_kpi
        public void Delete_Entity_kpi(long? ENTITY_KPI_ID)
        {
            var _params = new
            {
                ENTITY_KPI_ID = ENTITY_KPI_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_KPI", _params);
        }
        #endregion
        #region Delete_Entity
        public void Delete_Entity(long? ENTITY_ID)
        {
            var _params = new
            {
                ENTITY_ID = ENTITY_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY", _params);
        }
        #endregion
        #region Delete_District_kpi
        public void Delete_District_kpi(long? DISTRICT_KPI_ID)
        {
            var _params = new
            {
                DISTRICT_KPI_ID = DISTRICT_KPI_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_KPI", _params);
        }
        #endregion
        #region Delete_User_level_access
        public void Delete_User_level_access(long? USER_LEVEL_ACCESS_ID)
        {
            var _params = new
            {
                USER_LEVEL_ACCESS_ID = USER_LEVEL_ACCESS_ID
            };
            ExecuteDelete("UPG_DELETE_USER_LEVEL_ACCESS", _params);
        }
        #endregion
        #region Delete_User_districtnex_module
        public void Delete_User_districtnex_module(long? USER_DISTRICTNEX_MODULE_ID)
        {
            var _params = new
            {
                USER_DISTRICTNEX_MODULE_ID = USER_DISTRICTNEX_MODULE_ID
            };
            ExecuteDelete("UPG_DELETE_USER_DISTRICTNEX_MODULE", _params);
        }
        #endregion
        #region Delete_Entity_kpi_user_access
        public void Delete_Entity_kpi_user_access(long? ENTITY_KPI_USER_ACCESS_ID)
        {
            var _params = new
            {
                ENTITY_KPI_USER_ACCESS_ID = ENTITY_KPI_USER_ACCESS_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_KPI_USER_ACCESS", _params);
        }
        #endregion
        #region Delete_District_view
        public void Delete_District_view(long? DISTRICT_VIEW_ID)
        {
            var _params = new
            {
                DISTRICT_VIEW_ID = DISTRICT_VIEW_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_VIEW", _params);
        }
        #endregion
        #region Delete_Area
        public void Delete_Area(long? AREA_ID)
        {
            var _params = new
            {
                AREA_ID = AREA_ID
            };
            ExecuteDelete("UPG_DELETE_AREA", _params);
        }
        #endregion
        #region Delete_Area_view
        public void Delete_Area_view(long? AREA_VIEW_ID)
        {
            var _params = new
            {
                AREA_VIEW_ID = AREA_VIEW_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_VIEW", _params);
        }
        #endregion
        #region Delete_Site_kpi
        public void Delete_Site_kpi(long? SITE_KPI_ID)
        {
            var _params = new
            {
                SITE_KPI_ID = SITE_KPI_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_KPI", _params);
        }
        #endregion
        #region Delete_Setup_category
        public void Delete_Setup_category(int? SETUP_CATEGORY_ID)
        {
            var _params = new
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY", _params);
        }
        #endregion
        #region Delete_Organization_relation
        public void Delete_Organization_relation(int? ORGANIZATION_RELATION_ID)
        {
            var _params = new
            {
                ORGANIZATION_RELATION_ID = ORGANIZATION_RELATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_RELATION", _params);
        }
        #endregion
        #region Delete_Setup
        public void Delete_Setup(long? SETUP_ID)
        {
            var _params = new
            {
                SETUP_ID = SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP", _params);
        }
        #endregion
        #region Delete_Area_kpi
        public void Delete_Area_kpi(long? AREA_KPI_ID)
        {
            var _params = new
            {
                AREA_KPI_ID = AREA_KPI_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_KPI", _params);
        }
        #endregion
        #region Delete_Region
        public void Delete_Region(long? REGION_ID)
        {
            var _params = new
            {
                REGION_ID = REGION_ID
            };
            ExecuteDelete("UPG_DELETE_REGION", _params);
        }
        #endregion
        #region Delete_District
        public void Delete_District(long? DISTRICT_ID)
        {
            var _params = new
            {
                DISTRICT_ID = DISTRICT_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT", _params);
        }
        #endregion
        #region Delete_District_kpi_user_access
        public void Delete_District_kpi_user_access(long? DISTRICT_KPI_USER_ACCESS_ID)
        {
            var _params = new
            {
                DISTRICT_KPI_USER_ACCESS_ID = DISTRICT_KPI_USER_ACCESS_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_KPI_USER_ACCESS", _params);
        }
        #endregion
        #region Delete_User
        public void Delete_User(long? USER_ID)
        {
            var _params = new
            {
                USER_ID = USER_ID
            };
            ExecuteDelete("UPG_DELETE_USER", _params);
        }
        #endregion
        #region Delete_Site
        public void Delete_Site(long? SITE_ID)
        {
            var _params = new
            {
                SITE_ID = SITE_ID
            };
            ExecuteDelete("UPG_DELETE_SITE", _params);
        }
        #endregion
        #region Delete_User_theme
        public void Delete_User_theme(int? USER_THEME_ID)
        {
            var _params = new
            {
                USER_THEME_ID = USER_THEME_ID
            };
            ExecuteDelete("UPG_DELETE_USER_THEME", _params);
        }
        #endregion
        #region Delete_Region_view
        public void Delete_Region_view(long? REGION_VIEW_ID)
        {
            var _params = new
            {
                REGION_VIEW_ID = REGION_VIEW_ID
            };
            ExecuteDelete("UPG_DELETE_REGION_VIEW", _params);
        }
        #endregion
        #region Delete_Site_view_By_OWNER_ID_IS_DELETED
        public void Delete_Site_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SITE_VIEW_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Site_view_By_VIEW_TYPE_SETUP_ID
        public void Delete_Site_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID)
        {
            var _params = new
            {
                VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_VIEW_BY_VIEW_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Site_view_By_OWNER_ID
        public void Delete_Site_view_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_VIEW_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Site_view_By_SITE_ID
        public void Delete_Site_view_By_SITE_ID(long? SITE_ID)
        {
            var _params = new
            {
                SITE_ID = SITE_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_VIEW_BY_SITE_ID", _params);
        }
        #endregion
        #region Delete_Removed_extrusion_By_OWNER_ID
        public void Delete_Removed_extrusion_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_REMOVED_EXTRUSION_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Removed_extrusion_By_LEVEL_ID
        public void Delete_Removed_extrusion_By_LEVEL_ID(long? LEVEL_ID)
        {
            var _params = new
            {
                LEVEL_ID = LEVEL_ID
            };
            ExecuteDelete("UPG_DELETE_REMOVED_EXTRUSION_BY_LEVEL_ID", _params);
        }
        #endregion
        #region Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID
        public void Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID)
        {
            var _params = new
            {
                DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_REMOVED_EXTRUSION_BY_DATA_LEVEL_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED
        public void Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_REMOVED_EXTRUSION_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Entity_view_By_OWNER_ID
        public void Delete_Entity_view_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_VIEW_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Entity_view_By_VIEW_TYPE_SETUP_ID
        public void Delete_Entity_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID)
        {
            var _params = new
            {
                VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_VIEW_BY_VIEW_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Entity_view_By_OWNER_ID_IS_DELETED
        public void Delete_Entity_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ENTITY_VIEW_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Entity_view_By_ENTITY_ID
        public void Delete_Entity_view_By_ENTITY_ID(long? ENTITY_ID)
        {
            var _params = new
            {
                ENTITY_ID = ENTITY_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_VIEW_BY_ENTITY_ID", _params);
        }
        #endregion
        #region Delete_Top_level_By_OWNER_ID
        public void Delete_Top_level_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_TOP_LEVEL_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Top_level_By_OWNER_ID_IS_DELETED
        public void Delete_Top_level_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_TOP_LEVEL_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Area_kpi_user_access_By_OWNER_ID
        public void Delete_Area_kpi_user_access_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_KPI_USER_ACCESS_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Area_kpi_user_access_By_USER_ID
        public void Delete_Area_kpi_user_access_By_USER_ID(long? USER_ID)
        {
            var _params = new
            {
                USER_ID = USER_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_KPI_USER_ACCESS_BY_USER_ID", _params);
        }
        #endregion
        #region Delete_Area_kpi_user_access_By_AREA_ID
        public void Delete_Area_kpi_user_access_By_AREA_ID(long? AREA_ID)
        {
            var _params = new
            {
                AREA_ID = AREA_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_KPI_USER_ACCESS_BY_AREA_ID", _params);
        }
        #endregion
        #region Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_Area_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var _params = new
            {
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_KPI_USER_ACCESS_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
        }
        #endregion
        #region Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED
        public void Delete_Area_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_AREA_KPI_USER_ACCESS_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Site_kpi_user_access_By_OWNER_ID
        public void Delete_Site_kpi_user_access_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_KPI_USER_ACCESS_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Site_kpi_user_access_By_USER_ID
        public void Delete_Site_kpi_user_access_By_USER_ID(long? USER_ID)
        {
            var _params = new
            {
                USER_ID = USER_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_KPI_USER_ACCESS_BY_USER_ID", _params);
        }
        #endregion
        #region Delete_Site_kpi_user_access_By_SITE_ID
        public void Delete_Site_kpi_user_access_By_SITE_ID(long? SITE_ID)
        {
            var _params = new
            {
                SITE_ID = SITE_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_KPI_USER_ACCESS_BY_SITE_ID", _params);
        }
        #endregion
        #region Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_Site_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var _params = new
            {
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_KPI_USER_ACCESS_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
        }
        #endregion
        #region Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED
        public void Delete_Site_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SITE_KPI_USER_ACCESS_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Entity_kpi_By_OWNER_ID_IS_DELETED
        public void Delete_Entity_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ENTITY_KPI_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Entity_kpi_By_OWNER_ID
        public void Delete_Entity_kpi_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_KPI_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_Entity_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var _params = new
            {
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
        }
        #endregion
        #region Delete_Entity_kpi_By_ENTITY_ID
        public void Delete_Entity_kpi_By_ENTITY_ID(long? ENTITY_ID)
        {
            var _params = new
            {
                ENTITY_ID = ENTITY_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_KPI_BY_ENTITY_ID", _params);
        }
        #endregion
        #region Delete_Entity_By_OWNER_ID_IS_DELETED
        public void Delete_Entity_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ENTITY_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Entity_By_OWNER_ID
        public void Delete_Entity_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Entity_By_SITE_ID
        public void Delete_Entity_By_SITE_ID(long? SITE_ID)
        {
            var _params = new
            {
                SITE_ID = SITE_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_BY_SITE_ID", _params);
        }
        #endregion
        #region Delete_Entity_By_AREA_ID
        public void Delete_Entity_By_AREA_ID(long? AREA_ID)
        {
            var _params = new
            {
                AREA_ID = AREA_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_BY_AREA_ID", _params);
        }
        #endregion
        #region Delete_Entity_By_DISTRICT_ID
        public void Delete_Entity_By_DISTRICT_ID(long? DISTRICT_ID)
        {
            var _params = new
            {
                DISTRICT_ID = DISTRICT_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_BY_DISTRICT_ID", _params);
        }
        #endregion
        #region Delete_Entity_By_REGION_ID
        public void Delete_Entity_By_REGION_ID(long? REGION_ID)
        {
            var _params = new
            {
                REGION_ID = REGION_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_BY_REGION_ID", _params);
        }
        #endregion
        #region Delete_Entity_By_TOP_LEVEL_ID
        public void Delete_Entity_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID)
        {
            var _params = new
            {
                TOP_LEVEL_ID = TOP_LEVEL_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_BY_TOP_LEVEL_ID", _params);
        }
        #endregion
        #region Delete_Entity_By_ENTITY_TYPE_SETUP_ID
        public void Delete_Entity_By_ENTITY_TYPE_SETUP_ID(long? ENTITY_TYPE_SETUP_ID)
        {
            var _params = new
            {
                ENTITY_TYPE_SETUP_ID = ENTITY_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_BY_ENTITY_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_District_kpi_By_OWNER_ID
        public void Delete_District_kpi_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_KPI_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_District_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var _params = new
            {
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
        }
        #endregion
        #region Delete_District_kpi_By_OWNER_ID_IS_DELETED
        public void Delete_District_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_KPI_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_District_kpi_By_DISTRICT_ID
        public void Delete_District_kpi_By_DISTRICT_ID(long? DISTRICT_ID)
        {
            var _params = new
            {
                DISTRICT_ID = DISTRICT_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_KPI_BY_DISTRICT_ID", _params);
        }
        #endregion
        #region Delete_User_level_access_By_OWNER_ID
        public void Delete_User_level_access_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_USER_LEVEL_ACCESS_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID
        public void Delete_User_level_access_By_ORGANIZATION_LEVEL_ACCESS_ID(long? ORGANIZATION_LEVEL_ACCESS_ID)
        {
            var _params = new
            {
                ORGANIZATION_LEVEL_ACCESS_ID = ORGANIZATION_LEVEL_ACCESS_ID
            };
            ExecuteDelete("UPG_DELETE_USER_LEVEL_ACCESS_BY_ORGANIZATION_LEVEL_ACCESS_ID", _params);
        }
        #endregion
        #region Delete_User_level_access_By_USER_ID
        public void Delete_User_level_access_By_USER_ID(long? USER_ID)
        {
            var _params = new
            {
                USER_ID = USER_ID
            };
            ExecuteDelete("UPG_DELETE_USER_LEVEL_ACCESS_BY_USER_ID", _params);
        }
        #endregion
        #region Delete_User_level_access_By_LEVEL_ID
        public void Delete_User_level_access_By_LEVEL_ID(long? LEVEL_ID)
        {
            var _params = new
            {
                LEVEL_ID = LEVEL_ID
            };
            ExecuteDelete("UPG_DELETE_USER_LEVEL_ACCESS_BY_LEVEL_ID", _params);
        }
        #endregion
        #region Delete_User_level_access_By_DATA_LEVEL_SETUP_ID
        public void Delete_User_level_access_By_DATA_LEVEL_SETUP_ID(long? DATA_LEVEL_SETUP_ID)
        {
            var _params = new
            {
                DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_USER_LEVEL_ACCESS_BY_DATA_LEVEL_SETUP_ID", _params);
        }
        #endregion
        #region Delete_User_level_access_By_OWNER_ID_IS_DELETED
        public void Delete_User_level_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_USER_LEVEL_ACCESS_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID
        public void Delete_User_level_access_By_USER_ID_DATA_LEVEL_SETUP_ID(long? USER_ID, long? DATA_LEVEL_SETUP_ID)
        {
            var _params = new
            {
                USER_ID = USER_ID,
                DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_USER_LEVEL_ACCESS_BY_USER_ID_DATA_LEVEL_SETUP_ID", _params);
        }
        #endregion
        #region Delete_User_districtnex_module_By_OWNER_ID
        public void Delete_User_districtnex_module_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_USER_DISTRICTNEX_MODULE_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_User_districtnex_module_By_USER_ID
        public void Delete_User_districtnex_module_By_USER_ID(long? USER_ID)
        {
            var _params = new
            {
                USER_ID = USER_ID
            };
            ExecuteDelete("UPG_DELETE_USER_DISTRICTNEX_MODULE_BY_USER_ID", _params);
        }
        #endregion
        #region Delete_User_districtnex_module_By_DISTRICTNEX_MODULE_ID
        public void Delete_User_districtnex_module_By_DISTRICTNEX_MODULE_ID(int? DISTRICTNEX_MODULE_ID)
        {
            var _params = new
            {
                DISTRICTNEX_MODULE_ID = DISTRICTNEX_MODULE_ID
            };
            ExecuteDelete("UPG_DELETE_USER_DISTRICTNEX_MODULE_BY_DISTRICTNEX_MODULE_ID", _params);
        }
        #endregion
        #region Delete_User_districtnex_module_By_OWNER_ID_IS_DELETED
        public void Delete_User_districtnex_module_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_USER_DISTRICTNEX_MODULE_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Entity_kpi_user_access_By_OWNER_ID
        public void Delete_Entity_kpi_user_access_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_KPI_USER_ACCESS_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Entity_kpi_user_access_By_USER_ID
        public void Delete_Entity_kpi_user_access_By_USER_ID(long? USER_ID)
        {
            var _params = new
            {
                USER_ID = USER_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_KPI_USER_ACCESS_BY_USER_ID", _params);
        }
        #endregion
        #region Delete_Entity_kpi_user_access_By_ENTITY_ID
        public void Delete_Entity_kpi_user_access_By_ENTITY_ID(long? ENTITY_ID)
        {
            var _params = new
            {
                ENTITY_ID = ENTITY_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_KPI_USER_ACCESS_BY_ENTITY_ID", _params);
        }
        #endregion
        #region Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_Entity_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var _params = new
            {
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID
            };
            ExecuteDelete("UPG_DELETE_ENTITY_KPI_USER_ACCESS_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
        }
        #endregion
        #region Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED
        public void Delete_Entity_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ENTITY_KPI_USER_ACCESS_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_District_view_By_OWNER_ID
        public void Delete_District_view_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_VIEW_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_District_view_By_DISTRICT_ID
        public void Delete_District_view_By_DISTRICT_ID(long? DISTRICT_ID)
        {
            var _params = new
            {
                DISTRICT_ID = DISTRICT_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_VIEW_BY_DISTRICT_ID", _params);
        }
        #endregion
        #region Delete_District_view_By_VIEW_TYPE_SETUP_ID
        public void Delete_District_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID)
        {
            var _params = new
            {
                VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_VIEW_BY_VIEW_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_District_view_By_OWNER_ID_IS_DELETED
        public void Delete_District_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_VIEW_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Area_By_OWNER_ID_IS_DELETED
        public void Delete_Area_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_AREA_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Area_By_OWNER_ID
        public void Delete_Area_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Area_By_DISTRICT_ID
        public void Delete_Area_By_DISTRICT_ID(long? DISTRICT_ID)
        {
            var _params = new
            {
                DISTRICT_ID = DISTRICT_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_BY_DISTRICT_ID", _params);
        }
        #endregion
        #region Delete_Area_By_REGION_ID
        public void Delete_Area_By_REGION_ID(long? REGION_ID)
        {
            var _params = new
            {
                REGION_ID = REGION_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_BY_REGION_ID", _params);
        }
        #endregion
        #region Delete_Area_By_TOP_LEVEL_ID
        public void Delete_Area_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID)
        {
            var _params = new
            {
                TOP_LEVEL_ID = TOP_LEVEL_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_BY_TOP_LEVEL_ID", _params);
        }
        #endregion
        #region Delete_Area_view_By_OWNER_ID
        public void Delete_Area_view_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_VIEW_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Area_view_By_AREA_ID
        public void Delete_Area_view_By_AREA_ID(long? AREA_ID)
        {
            var _params = new
            {
                AREA_ID = AREA_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_VIEW_BY_AREA_ID", _params);
        }
        #endregion
        #region Delete_Area_view_By_VIEW_TYPE_SETUP_ID
        public void Delete_Area_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID)
        {
            var _params = new
            {
                VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_VIEW_BY_VIEW_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Area_view_By_OWNER_ID_IS_DELETED
        public void Delete_Area_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_AREA_VIEW_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Site_kpi_By_OWNER_ID
        public void Delete_Site_kpi_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_KPI_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_Site_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var _params = new
            {
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
        }
        #endregion
        #region Delete_Site_kpi_By_OWNER_ID_IS_DELETED
        public void Delete_Site_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SITE_KPI_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Site_kpi_By_SITE_ID
        public void Delete_Site_kpi_By_SITE_ID(long? SITE_ID)
        {
            var _params = new
            {
                SITE_ID = SITE_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_KPI_BY_SITE_ID", _params);
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID
        public void Delete_Setup_category_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_category_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public void Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(string SETUP_CATEGORY_NAME, int? OWNER_ID)
        {
            var _params = new
            {
                SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME,
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_CATEGORY_BY_SETUP_CATEGORY_NAME_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_relation_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_relation_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_RELATION_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Organization_relation_By_OWNER_ID
        public void Delete_Organization_relation_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_RELATION_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_relation_By_PARENT_ORGANIZATION_ID
        public void Delete_Organization_relation_By_PARENT_ORGANIZATION_ID(int? PARENT_ORGANIZATION_ID)
        {
            var _params = new
            {
                PARENT_ORGANIZATION_ID = PARENT_ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_RELATION_BY_PARENT_ORGANIZATION_ID", _params);
        }
        #endregion
        #region Delete_Organization_relation_By_CHILD_ORGANIZATION_ID
        public void Delete_Organization_relation_By_CHILD_ORGANIZATION_ID(int? CHILD_ORGANIZATION_ID)
        {
            var _params = new
            {
                CHILD_ORGANIZATION_ID = CHILD_ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_RELATION_BY_CHILD_ORGANIZATION_ID", _params);
        }
        #endregion
        #region Delete_Organization_relation_By_USER_ID
        public void Delete_Organization_relation_By_USER_ID(long? USER_ID)
        {
            var _params = new
            {
                USER_ID = USER_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_RELATION_BY_USER_ID", _params);
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID
        public void Delete_Setup_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            var _params = new
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_SETUP_CATEGORY_ID", _params);
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
        public void Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(int? SETUP_CATEGORY_ID, string VALUE)
        {
            var _params = new
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID,
                VALUE = VALUE
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_SETUP_CATEGORY_ID_VALUE", _params);
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID
        public void Delete_Setup_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SETUP_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Area_kpi_By_OWNER_ID_IS_DELETED
        public void Delete_Area_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_AREA_KPI_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Area_kpi_By_OWNER_ID
        public void Delete_Area_kpi_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_KPI_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Area_kpi_By_AREA_ID
        public void Delete_Area_kpi_By_AREA_ID(long? AREA_ID)
        {
            var _params = new
            {
                AREA_ID = AREA_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_KPI_BY_AREA_ID", _params);
        }
        #endregion
        #region Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_Area_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var _params = new
            {
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID
            };
            ExecuteDelete("UPG_DELETE_AREA_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
        }
        #endregion
        #region Delete_Region_By_OWNER_ID_IS_DELETED
        public void Delete_Region_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_REGION_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Region_By_OWNER_ID
        public void Delete_Region_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_REGION_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Region_By_TOP_LEVEL_ID
        public void Delete_Region_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID)
        {
            var _params = new
            {
                TOP_LEVEL_ID = TOP_LEVEL_ID
            };
            ExecuteDelete("UPG_DELETE_REGION_BY_TOP_LEVEL_ID", _params);
        }
        #endregion
        #region Delete_District_By_OWNER_ID_IS_DELETED
        public void Delete_District_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_District_By_OWNER_ID
        public void Delete_District_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_District_By_REGION_ID
        public void Delete_District_By_REGION_ID(long? REGION_ID)
        {
            var _params = new
            {
                REGION_ID = REGION_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_BY_REGION_ID", _params);
        }
        #endregion
        #region Delete_District_By_TOP_LEVEL_ID
        public void Delete_District_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID)
        {
            var _params = new
            {
                TOP_LEVEL_ID = TOP_LEVEL_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_BY_TOP_LEVEL_ID", _params);
        }
        #endregion
        #region Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED
        public void Delete_District_kpi_user_access_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_KPI_USER_ACCESS_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_District_kpi_user_access_By_OWNER_ID
        public void Delete_District_kpi_user_access_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_KPI_USER_ACCESS_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_District_kpi_user_access_By_USER_ID
        public void Delete_District_kpi_user_access_By_USER_ID(long? USER_ID)
        {
            var _params = new
            {
                USER_ID = USER_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_KPI_USER_ACCESS_BY_USER_ID", _params);
        }
        #endregion
        #region Delete_District_kpi_user_access_By_DISTRICT_ID
        public void Delete_District_kpi_user_access_By_DISTRICT_ID(long? DISTRICT_ID)
        {
            var _params = new
            {
                DISTRICT_ID = DISTRICT_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_KPI_USER_ACCESS_BY_DISTRICT_ID", _params);
        }
        #endregion
        #region Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public void Delete_District_kpi_user_access_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var _params = new
            {
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID
            };
            ExecuteDelete("UPG_DELETE_DISTRICT_KPI_USER_ACCESS_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
        }
        #endregion
        #region Delete_User_By_OWNER_ID_IS_DELETED
        public void Delete_User_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_User_By_USERNAME_OWNER_ID
        public void Delete_User_By_USERNAME_OWNER_ID(string USERNAME, int? OWNER_ID)
        {
            var _params = new
            {
                USERNAME = USERNAME,
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_USER_BY_USERNAME_OWNER_ID", _params);
        }
        #endregion
        #region Delete_User_By_EMAIL_OWNER_ID
        public void Delete_User_By_EMAIL_OWNER_ID(string EMAIL, int? OWNER_ID)
        {
            var _params = new
            {
                EMAIL = EMAIL,
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_USER_BY_EMAIL_OWNER_ID", _params);
        }
        #endregion
        #region Delete_User_By_USER_TYPE_SETUP_ID
        public void Delete_User_By_USER_TYPE_SETUP_ID(long? USER_TYPE_SETUP_ID)
        {
            var _params = new
            {
                USER_TYPE_SETUP_ID = USER_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_USER_BY_USER_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_User_By_ORGANIZATION_ID
        public void Delete_User_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            var _params = new
            {
                ORGANIZATION_ID = ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_USER_BY_ORGANIZATION_ID", _params);
        }
        #endregion
        #region Delete_User_By_OWNER_ID
        public void Delete_User_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_User_By_IS_RECEIVE_EMAIL
        public void Delete_User_By_IS_RECEIVE_EMAIL(bool IS_RECEIVE_EMAIL)
        {
            var _params = new
            {
                IS_RECEIVE_EMAIL = IS_RECEIVE_EMAIL
            };
            ExecuteDelete("UPG_DELETE_USER_BY_IS_RECEIVE_EMAIL", _params);
        }
        #endregion
        #region Delete_User_By_IS_DELETED
        public void Delete_User_By_IS_DELETED(bool IS_DELETED)
        {
            var _params = new
            {
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_USER_BY_IS_DELETED", _params);
        }
        #endregion
        #region Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED
        public void Delete_User_By_OWNER_ID_IS_ACTIVE_IS_DELETED(int? OWNER_ID, bool IS_ACTIVE, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_ACTIVE = IS_ACTIVE,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_USER_BY_OWNER_ID_IS_ACTIVE_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Site_By_OWNER_ID_IS_DELETED
        public void Delete_Site_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SITE_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Site_By_OWNER_ID
        public void Delete_Site_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Site_By_AREA_ID
        public void Delete_Site_By_AREA_ID(long? AREA_ID)
        {
            var _params = new
            {
                AREA_ID = AREA_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_BY_AREA_ID", _params);
        }
        #endregion
        #region Delete_Site_By_DISTRICT_ID
        public void Delete_Site_By_DISTRICT_ID(long? DISTRICT_ID)
        {
            var _params = new
            {
                DISTRICT_ID = DISTRICT_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_BY_DISTRICT_ID", _params);
        }
        #endregion
        #region Delete_Site_By_REGION_ID
        public void Delete_Site_By_REGION_ID(long? REGION_ID)
        {
            var _params = new
            {
                REGION_ID = REGION_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_BY_REGION_ID", _params);
        }
        #endregion
        #region Delete_Site_By_TOP_LEVEL_ID
        public void Delete_Site_By_TOP_LEVEL_ID(long? TOP_LEVEL_ID)
        {
            var _params = new
            {
                TOP_LEVEL_ID = TOP_LEVEL_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_BY_TOP_LEVEL_ID", _params);
        }
        #endregion
        #region Delete_User_theme_By_OWNER_ID
        public void Delete_User_theme_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_USER_THEME_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_User_theme_By_USER_ID
        public void Delete_User_theme_By_USER_ID(long? USER_ID)
        {
            var _params = new
            {
                USER_ID = USER_ID
            };
            ExecuteDelete("UPG_DELETE_USER_THEME_BY_USER_ID", _params);
        }
        #endregion
        #region Delete_User_theme_By_ORGANIZATION_THEME_ID
        public void Delete_User_theme_By_ORGANIZATION_THEME_ID(int? ORGANIZATION_THEME_ID)
        {
            var _params = new
            {
                ORGANIZATION_THEME_ID = ORGANIZATION_THEME_ID
            };
            ExecuteDelete("UPG_DELETE_USER_THEME_BY_ORGANIZATION_THEME_ID", _params);
        }
        #endregion
        #region Delete_User_theme_By_OWNER_ID_IS_DELETED
        public void Delete_User_theme_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_USER_THEME_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Region_view_By_OWNER_ID
        public void Delete_Region_view_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_REGION_VIEW_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Region_view_By_REGION_ID
        public void Delete_Region_view_By_REGION_ID(long? REGION_ID)
        {
            var _params = new
            {
                REGION_ID = REGION_ID
            };
            ExecuteDelete("UPG_DELETE_REGION_VIEW_BY_REGION_ID", _params);
        }
        #endregion
        #region Delete_Region_view_By_VIEW_TYPE_SETUP_ID
        public void Delete_Region_view_By_VIEW_TYPE_SETUP_ID(long? VIEW_TYPE_SETUP_ID)
        {
            var _params = new
            {
                VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_REGION_VIEW_BY_VIEW_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Region_view_By_OWNER_ID_IS_DELETED
        public void Delete_Region_view_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_REGION_VIEW_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Edit_Site_view
        public long? Edit_Site_view(long? SITE_VIEW_ID, long? SITE_ID, long? VIEW_TYPE_SETUP_ID, decimal? PITCH, decimal? BEARING, decimal? ZOOM, decimal? LATITUDE, decimal? LONGITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Site_view oSite_view = new Site_view()
            {
                SITE_VIEW_ID = SITE_VIEW_ID,
                SITE_ID = SITE_ID,
                VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID,
                PITCH = PITCH,
                BEARING = BEARING,
                ZOOM = ZOOM,
                LATITUDE = LATITUDE,
                LONGITUDE = LONGITUDE,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_SITE_VIEW", oSite_view, "SITE_VIEW_ID");
            return oSite_view.SITE_VIEW_ID;
        }
        #endregion
        #region Edit_Removed_extrusion
        public int? Edit_Removed_extrusion(int? REMOVED_EXTRUSION_ID, string EXTRUSION_IDENTIFIER, long? LEVEL_ID, long? DATA_LEVEL_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Removed_extrusion oRemoved_extrusion = new Removed_extrusion()
            {
                REMOVED_EXTRUSION_ID = REMOVED_EXTRUSION_ID,
                EXTRUSION_IDENTIFIER = EXTRUSION_IDENTIFIER,
                LEVEL_ID = LEVEL_ID,
                DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_REMOVED_EXTRUSION", oRemoved_extrusion, "REMOVED_EXTRUSION_ID");
            return oRemoved_extrusion.REMOVED_EXTRUSION_ID;
        }
        #endregion
        #region Edit_Entity_view
        public long? Edit_Entity_view(long? ENTITY_VIEW_ID, long? ENTITY_ID, long? VIEW_TYPE_SETUP_ID, decimal? PITCH, decimal? BEARING, decimal? ZOOM, decimal? LATITUDE, decimal? LONGITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Entity_view oEntity_view = new Entity_view()
            {
                ENTITY_VIEW_ID = ENTITY_VIEW_ID,
                ENTITY_ID = ENTITY_ID,
                VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID,
                PITCH = PITCH,
                BEARING = BEARING,
                ZOOM = ZOOM,
                LATITUDE = LATITUDE,
                LONGITUDE = LONGITUDE,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_ENTITY_VIEW", oEntity_view, "ENTITY_VIEW_ID");
            return oEntity_view.ENTITY_VIEW_ID;
        }
        #endregion
        #region Edit_Top_level
        public long? Edit_Top_level(long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? LOW_THRESHOLD, int? HIGH_THRESHOLD, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Top_level oTop_level = new Top_level()
            {
                TOP_LEVEL_ID = TOP_LEVEL_ID,
                NAME = NAME,
                LOCATION = LOCATION,
                AREA = AREA,
                IMAGE_URL = IMAGE_URL,
                LOGO_URL = LOGO_URL,
                AREA_COLOR = AREA_COLOR,
                BORDER_COLOR = BORDER_COLOR,
                STUDY_ZONE_NAME = STUDY_ZONE_NAME,
                LOW_THRESHOLD = LOW_THRESHOLD,
                HIGH_THRESHOLD = HIGH_THRESHOLD,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_TOP_LEVEL", oTop_level, "TOP_LEVEL_ID");
            return oTop_level.TOP_LEVEL_ID;
        }
        #endregion
        #region Edit_Area_kpi_user_access
        public long? Edit_Area_kpi_user_access(long? AREA_KPI_USER_ACCESS_ID, long? USER_ID, long? AREA_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Area_kpi_user_access oArea_kpi_user_access = new Area_kpi_user_access()
            {
                AREA_KPI_USER_ACCESS_ID = AREA_KPI_USER_ACCESS_ID,
                USER_ID = USER_ID,
                AREA_ID = AREA_ID,
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_AREA_KPI_USER_ACCESS", oArea_kpi_user_access, "AREA_KPI_USER_ACCESS_ID");
            return oArea_kpi_user_access.AREA_KPI_USER_ACCESS_ID;
        }
        #endregion
        #region Edit_Site_kpi_user_access
        public long? Edit_Site_kpi_user_access(long? SITE_KPI_USER_ACCESS_ID, long? USER_ID, long? SITE_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Site_kpi_user_access oSite_kpi_user_access = new Site_kpi_user_access()
            {
                SITE_KPI_USER_ACCESS_ID = SITE_KPI_USER_ACCESS_ID,
                USER_ID = USER_ID,
                SITE_ID = SITE_ID,
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_SITE_KPI_USER_ACCESS", oSite_kpi_user_access, "SITE_KPI_USER_ACCESS_ID");
            return oSite_kpi_user_access.SITE_KPI_USER_ACCESS_ID;
        }
        #endregion
        #region Edit_Entity_kpi
        public long? Edit_Entity_kpi(long? ENTITY_KPI_ID, long? ENTITY_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Entity_kpi oEntity_kpi = new Entity_kpi()
            {
                ENTITY_KPI_ID = ENTITY_KPI_ID,
                ENTITY_ID = ENTITY_ID,
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_ENTITY_KPI", oEntity_kpi, "ENTITY_KPI_ID");
            return oEntity_kpi.ENTITY_KPI_ID;
        }
        #endregion
        #region Edit_Entity
        public long? Edit_Entity(long? ENTITY_ID, long? SITE_ID, long? AREA_ID, long? DISTRICT_ID, long? REGION_ID, long? TOP_LEVEL_ID, long? ENTITY_TYPE_SETUP_ID, string NAME, int? NUMBER_OF_FLOORS, decimal? GLA, string GLA_UNIT, decimal? AREA, string UNIT, decimal? SCALE, decimal? ROTATIONX, decimal? ROTATIONY, decimal? ROTATIONZ, decimal? GLTF_LATITUDE, decimal? GLTF_LONGITUDE, decimal? CENTER_LATITUDE, decimal? CENTER_LONGITUDE, decimal? RADIUS_IN_METERS, string IMAGE_URL, string SOLID_GLTF_URL, decimal? POPUL_ALT_X, decimal? POPUP_ALT_Y, decimal? POPUP_ALT_Z, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Entity oEntity = new Entity()
            {
                ENTITY_ID = ENTITY_ID,
                SITE_ID = SITE_ID,
                AREA_ID = AREA_ID,
                DISTRICT_ID = DISTRICT_ID,
                REGION_ID = REGION_ID,
                TOP_LEVEL_ID = TOP_LEVEL_ID,
                ENTITY_TYPE_SETUP_ID = ENTITY_TYPE_SETUP_ID,
                NAME = NAME,
                NUMBER_OF_FLOORS = NUMBER_OF_FLOORS,
                GLA = GLA,
                GLA_UNIT = GLA_UNIT,
                AREA = AREA,
                UNIT = UNIT,
                SCALE = SCALE,
                ROTATIONX = ROTATIONX,
                ROTATIONY = ROTATIONY,
                ROTATIONZ = ROTATIONZ,
                GLTF_LATITUDE = GLTF_LATITUDE,
                GLTF_LONGITUDE = GLTF_LONGITUDE,
                CENTER_LATITUDE = CENTER_LATITUDE,
                CENTER_LONGITUDE = CENTER_LONGITUDE,
                RADIUS_IN_METERS = RADIUS_IN_METERS,
                IMAGE_URL = IMAGE_URL,
                SOLID_GLTF_URL = SOLID_GLTF_URL,
                POPUL_ALT_X = POPUL_ALT_X,
                POPUP_ALT_Y = POPUP_ALT_Y,
                POPUP_ALT_Z = POPUP_ALT_Z,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_ENTITY", oEntity, "ENTITY_ID");
            return oEntity.ENTITY_ID;
        }
        #endregion
        #region Edit_District_kpi
        public long? Edit_District_kpi(long? DISTRICT_KPI_ID, long? DISTRICT_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            District_kpi oDistrict_kpi = new District_kpi()
            {
                DISTRICT_KPI_ID = DISTRICT_KPI_ID,
                DISTRICT_ID = DISTRICT_ID,
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_DISTRICT_KPI", oDistrict_kpi, "DISTRICT_KPI_ID");
            return oDistrict_kpi.DISTRICT_KPI_ID;
        }
        #endregion
        #region Edit_User_level_access
        public long? Edit_User_level_access(long? USER_LEVEL_ACCESS_ID, long? ORGANIZATION_LEVEL_ACCESS_ID, long? USER_ID, long? LEVEL_ID, long? DATA_LEVEL_SETUP_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            User_level_access oUser_level_access = new User_level_access()
            {
                USER_LEVEL_ACCESS_ID = USER_LEVEL_ACCESS_ID,
                ORGANIZATION_LEVEL_ACCESS_ID = ORGANIZATION_LEVEL_ACCESS_ID,
                USER_ID = USER_ID,
                LEVEL_ID = LEVEL_ID,
                DATA_LEVEL_SETUP_ID = DATA_LEVEL_SETUP_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_USER_LEVEL_ACCESS", oUser_level_access, "USER_LEVEL_ACCESS_ID");
            return oUser_level_access.USER_LEVEL_ACCESS_ID;
        }
        #endregion
        #region Edit_User_districtnex_module
        public long? Edit_User_districtnex_module(long? USER_DISTRICTNEX_MODULE_ID, long? USER_ID, int? DISTRICTNEX_MODULE_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            User_districtnex_module oUser_districtnex_module = new User_districtnex_module()
            {
                USER_DISTRICTNEX_MODULE_ID = USER_DISTRICTNEX_MODULE_ID,
                USER_ID = USER_ID,
                DISTRICTNEX_MODULE_ID = DISTRICTNEX_MODULE_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_USER_DISTRICTNEX_MODULE", oUser_districtnex_module, "USER_DISTRICTNEX_MODULE_ID");
            return oUser_districtnex_module.USER_DISTRICTNEX_MODULE_ID;
        }
        #endregion
        #region Edit_Entity_kpi_user_access
        public long? Edit_Entity_kpi_user_access(long? ENTITY_KPI_USER_ACCESS_ID, long? USER_ID, long? ENTITY_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Entity_kpi_user_access oEntity_kpi_user_access = new Entity_kpi_user_access()
            {
                ENTITY_KPI_USER_ACCESS_ID = ENTITY_KPI_USER_ACCESS_ID,
                USER_ID = USER_ID,
                ENTITY_ID = ENTITY_ID,
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_ENTITY_KPI_USER_ACCESS", oEntity_kpi_user_access, "ENTITY_KPI_USER_ACCESS_ID");
            return oEntity_kpi_user_access.ENTITY_KPI_USER_ACCESS_ID;
        }
        #endregion
        #region Edit_District_view
        public long? Edit_District_view(long? DISTRICT_VIEW_ID, long? DISTRICT_ID, long? VIEW_TYPE_SETUP_ID, decimal? PITCH, decimal? BEARING, decimal? ZOOM, decimal? LATITUDE, decimal? LONGITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            District_view oDistrict_view = new District_view()
            {
                DISTRICT_VIEW_ID = DISTRICT_VIEW_ID,
                DISTRICT_ID = DISTRICT_ID,
                VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID,
                PITCH = PITCH,
                BEARING = BEARING,
                ZOOM = ZOOM,
                LATITUDE = LATITUDE,
                LONGITUDE = LONGITUDE,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_DISTRICT_VIEW", oDistrict_view, "DISTRICT_VIEW_ID");
            return oDistrict_view.DISTRICT_VIEW_ID;
        }
        #endregion
        #region Edit_Area
        public long? Edit_Area(long? AREA_ID, long? DISTRICT_ID, long? REGION_ID, long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string UNIT, decimal? SCALE, decimal? ROTATIONX, decimal? ROTATIONY, decimal? ROTATIONZ, decimal? GLTF_LATITUDE, decimal? GLTF_LONGITUDE, decimal? CENTER_LATITUDE, decimal? CENTER_LONGITUDE, decimal? RADIUS_IN_METERS, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Area oArea = new Area()
            {
                AREA_ID = AREA_ID,
                DISTRICT_ID = DISTRICT_ID,
                REGION_ID = REGION_ID,
                TOP_LEVEL_ID = TOP_LEVEL_ID,
                NAME = NAME,
                LOCATION = LOCATION,
                AREA = AREA,
                UNIT = UNIT,
                SCALE = SCALE,
                ROTATIONX = ROTATIONX,
                ROTATIONY = ROTATIONY,
                ROTATIONZ = ROTATIONZ,
                GLTF_LATITUDE = GLTF_LATITUDE,
                GLTF_LONGITUDE = GLTF_LONGITUDE,
                CENTER_LATITUDE = CENTER_LATITUDE,
                CENTER_LONGITUDE = CENTER_LONGITUDE,
                RADIUS_IN_METERS = RADIUS_IN_METERS,
                IMAGE_URL = IMAGE_URL,
                LOGO_URL = LOGO_URL,
                SOLID_GLTF_URL = SOLID_GLTF_URL,
                AREA_COLOR = AREA_COLOR,
                BORDER_COLOR = BORDER_COLOR,
                STUDY_ZONE_NAME = STUDY_ZONE_NAME,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_AREA", oArea, "AREA_ID");
            return oArea.AREA_ID;
        }
        #endregion
        #region Edit_Area_view
        public long? Edit_Area_view(long? AREA_VIEW_ID, long? AREA_ID, long? VIEW_TYPE_SETUP_ID, decimal? PITCH, decimal? BEARING, decimal? ZOOM, decimal? LATITUDE, decimal? LONGITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Area_view oArea_view = new Area_view()
            {
                AREA_VIEW_ID = AREA_VIEW_ID,
                AREA_ID = AREA_ID,
                VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID,
                PITCH = PITCH,
                BEARING = BEARING,
                ZOOM = ZOOM,
                LATITUDE = LATITUDE,
                LONGITUDE = LONGITUDE,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_AREA_VIEW", oArea_view, "AREA_VIEW_ID");
            return oArea_view.AREA_VIEW_ID;
        }
        #endregion
        #region Edit_Site_kpi
        public long? Edit_Site_kpi(long? SITE_KPI_ID, long? SITE_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Site_kpi oSite_kpi = new Site_kpi()
            {
                SITE_KPI_ID = SITE_KPI_ID,
                SITE_ID = SITE_ID,
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_SITE_KPI", oSite_kpi, "SITE_KPI_ID");
            return oSite_kpi.SITE_KPI_ID;
        }
        #endregion
        #region Edit_Setup_category
        public int? Edit_Setup_category(int? SETUP_CATEGORY_ID, string SETUP_CATEGORY_NAME, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Setup_category oSetup_category = new Setup_category()
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID,
                SETUP_CATEGORY_NAME = SETUP_CATEGORY_NAME,
                DESCRIPTION = DESCRIPTION,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_SETUP_CATEGORY", oSetup_category, "SETUP_CATEGORY_ID");
            return oSetup_category.SETUP_CATEGORY_ID;
        }
        #endregion
        #region Edit_Organization_relation
        public int? Edit_Organization_relation(int? ORGANIZATION_RELATION_ID, int? PARENT_ORGANIZATION_ID, int? CHILD_ORGANIZATION_ID, long? USER_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Organization_relation oOrganization_relation = new Organization_relation()
            {
                ORGANIZATION_RELATION_ID = ORGANIZATION_RELATION_ID,
                PARENT_ORGANIZATION_ID = PARENT_ORGANIZATION_ID,
                CHILD_ORGANIZATION_ID = CHILD_ORGANIZATION_ID,
                USER_ID = USER_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_ORGANIZATION_RELATION", oOrganization_relation, "ORGANIZATION_RELATION_ID");
            return oOrganization_relation.ORGANIZATION_RELATION_ID;
        }
        #endregion
        #region Edit_Setup
        public long? Edit_Setup(long? SETUP_ID, int? SETUP_CATEGORY_ID, bool IS_SYSTEM, bool IS_DELETEABLE, bool IS_UPDATEABLE, bool IS_DELETED, bool IS_VISIBLE, int? DISPLAY_ORDER, string VALUE, string DESCRIPTION, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, int? OWNER_ID)
        {
            Setup oSetup = new Setup()
            {
                SETUP_ID = SETUP_ID,
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID,
                IS_SYSTEM = IS_SYSTEM,
                IS_DELETEABLE = IS_DELETEABLE,
                IS_UPDATEABLE = IS_UPDATEABLE,
                IS_DELETED = IS_DELETED,
                IS_VISIBLE = IS_VISIBLE,
                DISPLAY_ORDER = DISPLAY_ORDER,
                VALUE = VALUE,
                DESCRIPTION = DESCRIPTION,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_SETUP", oSetup, "SETUP_ID");
            return oSetup.SETUP_ID;
        }
        #endregion
        #region Edit_Area_kpi
        public long? Edit_Area_kpi(long? AREA_KPI_ID, long? AREA_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Area_kpi oArea_kpi = new Area_kpi()
            {
                AREA_KPI_ID = AREA_KPI_ID,
                AREA_ID = AREA_ID,
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_AREA_KPI", oArea_kpi, "AREA_KPI_ID");
            return oArea_kpi.AREA_KPI_ID;
        }
        #endregion
        #region Edit_Region
        public long? Edit_Region(long? REGION_ID, long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Region oRegion = new Region()
            {
                REGION_ID = REGION_ID,
                TOP_LEVEL_ID = TOP_LEVEL_ID,
                NAME = NAME,
                LOCATION = LOCATION,
                AREA = AREA,
                UNIT = UNIT,
                IMAGE_URL = IMAGE_URL,
                LOGO_URL = LOGO_URL,
                AREA_COLOR = AREA_COLOR,
                BORDER_COLOR = BORDER_COLOR,
                STUDY_ZONE_NAME = STUDY_ZONE_NAME,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_REGION", oRegion, "REGION_ID");
            return oRegion.REGION_ID;
        }
        #endregion
        #region Edit_District
        public long? Edit_District(long? DISTRICT_ID, long? REGION_ID, long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string UNIT, decimal? SCALE, decimal? ROTATIONX, decimal? ROTATIONY, decimal? ROTATIONZ, decimal? GLTF_LATITUDE, decimal? GLTF_LONGITUDE, decimal? CENTER_LATITUDE, decimal? CENTER_LONGITUDE, decimal? RADIUS_IN_METERS, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            District oDistrict = new District()
            {
                DISTRICT_ID = DISTRICT_ID,
                REGION_ID = REGION_ID,
                TOP_LEVEL_ID = TOP_LEVEL_ID,
                NAME = NAME,
                LOCATION = LOCATION,
                AREA = AREA,
                UNIT = UNIT,
                SCALE = SCALE,
                ROTATIONX = ROTATIONX,
                ROTATIONY = ROTATIONY,
                ROTATIONZ = ROTATIONZ,
                GLTF_LATITUDE = GLTF_LATITUDE,
                GLTF_LONGITUDE = GLTF_LONGITUDE,
                CENTER_LATITUDE = CENTER_LATITUDE,
                CENTER_LONGITUDE = CENTER_LONGITUDE,
                RADIUS_IN_METERS = RADIUS_IN_METERS,
                IMAGE_URL = IMAGE_URL,
                LOGO_URL = LOGO_URL,
                SOLID_GLTF_URL = SOLID_GLTF_URL,
                AREA_COLOR = AREA_COLOR,
                BORDER_COLOR = BORDER_COLOR,
                STUDY_ZONE_NAME = STUDY_ZONE_NAME,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_DISTRICT", oDistrict, "DISTRICT_ID");
            return oDistrict.DISTRICT_ID;
        }
        #endregion
        #region Edit_District_kpi_user_access
        public long? Edit_District_kpi_user_access(long? DISTRICT_KPI_USER_ACCESS_ID, long? USER_ID, long? DISTRICT_ID, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            District_kpi_user_access oDistrict_kpi_user_access = new District_kpi_user_access()
            {
                DISTRICT_KPI_USER_ACCESS_ID = DISTRICT_KPI_USER_ACCESS_ID,
                USER_ID = USER_ID,
                DISTRICT_ID = DISTRICT_ID,
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_DISTRICT_KPI_USER_ACCESS", oDistrict_kpi_user_access, "DISTRICT_KPI_USER_ACCESS_ID");
            return oDistrict_kpi_user_access.DISTRICT_KPI_USER_ACCESS_ID;
        }
        #endregion
        #region Edit_User
        public long? Edit_User(long? USER_ID, int? ORGANIZATION_ID, long? USER_TYPE_SETUP_ID, int? OWNER_ID, string FIRST_NAME, string LAST_NAME, string USERNAME, string PASSWORD, string EMAIL, string PHONE_NUMBER, string IMAGE_URL, bool IS_ACTIVE, bool IS_DELETED, bool IS_RECEIVE_EMAIL, int? DATA_RETENTION_PERIOD, string USER_DISTRICTNEX_WALKTHROUGH, string USER_ADMIN_WALKTHROUGH, string DATE_DELETED, string ENTRY_DATE, long? ENTRY_USER_ID, string LAST_UPDATE)
        {
            User oUser = new User()
            {
                USER_ID = USER_ID,
                ORGANIZATION_ID = ORGANIZATION_ID,
                USER_TYPE_SETUP_ID = USER_TYPE_SETUP_ID,
                OWNER_ID = OWNER_ID,
                FIRST_NAME = FIRST_NAME,
                LAST_NAME = LAST_NAME,
                USERNAME = USERNAME,
                PASSWORD = PASSWORD,
                EMAIL = EMAIL,
                PHONE_NUMBER = PHONE_NUMBER,
                IMAGE_URL = IMAGE_URL,
                IS_ACTIVE = IS_ACTIVE,
                IS_DELETED = IS_DELETED,
                IS_RECEIVE_EMAIL = IS_RECEIVE_EMAIL,
                DATA_RETENTION_PERIOD = DATA_RETENTION_PERIOD,
                USER_DISTRICTNEX_WALKTHROUGH = USER_DISTRICTNEX_WALKTHROUGH,
                USER_ADMIN_WALKTHROUGH = USER_ADMIN_WALKTHROUGH,
                DATE_DELETED = DATE_DELETED,
                ENTRY_DATE = ENTRY_DATE,
                ENTRY_USER_ID = ENTRY_USER_ID,
                LAST_UPDATE = LAST_UPDATE
            };
            ExecuteEdit("UPG_EDIT_USER", oUser, "USER_ID");
            return oUser.USER_ID;
        }
        #endregion
        #region Edit_Site
        public long? Edit_Site(long? SITE_ID, long? AREA_ID, long? DISTRICT_ID, long? REGION_ID, long? TOP_LEVEL_ID, string NAME, string LOCATION, decimal? AREA, string UNIT, decimal? SCALE, decimal? ROTATIONX, decimal? ROTATIONY, decimal? ROTATIONZ, decimal? GLTF_LATITUDE, decimal? GLTF_LONGITUDE, decimal? CENTER_LATITUDE, decimal? CENTER_LONGITUDE, decimal? RADIUS_IN_METERS, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Site oSite = new Site()
            {
                SITE_ID = SITE_ID,
                AREA_ID = AREA_ID,
                DISTRICT_ID = DISTRICT_ID,
                REGION_ID = REGION_ID,
                TOP_LEVEL_ID = TOP_LEVEL_ID,
                NAME = NAME,
                LOCATION = LOCATION,
                AREA = AREA,
                UNIT = UNIT,
                SCALE = SCALE,
                ROTATIONX = ROTATIONX,
                ROTATIONY = ROTATIONY,
                ROTATIONZ = ROTATIONZ,
                GLTF_LATITUDE = GLTF_LATITUDE,
                GLTF_LONGITUDE = GLTF_LONGITUDE,
                CENTER_LATITUDE = CENTER_LATITUDE,
                CENTER_LONGITUDE = CENTER_LONGITUDE,
                RADIUS_IN_METERS = RADIUS_IN_METERS,
                IMAGE_URL = IMAGE_URL,
                LOGO_URL = LOGO_URL,
                SOLID_GLTF_URL = SOLID_GLTF_URL,
                AREA_COLOR = AREA_COLOR,
                BORDER_COLOR = BORDER_COLOR,
                STUDY_ZONE_NAME = STUDY_ZONE_NAME,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_SITE", oSite, "SITE_ID");
            return oSite.SITE_ID;
        }
        #endregion
        #region Edit_User_theme
        public int? Edit_User_theme(int? USER_THEME_ID, long? USER_ID, int? ORGANIZATION_THEME_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            User_theme oUser_theme = new User_theme()
            {
                USER_THEME_ID = USER_THEME_ID,
                USER_ID = USER_ID,
                ORGANIZATION_THEME_ID = ORGANIZATION_THEME_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_USER_THEME", oUser_theme, "USER_THEME_ID");
            return oUser_theme.USER_THEME_ID;
        }
        #endregion
        #region Edit_Region_view
        public long? Edit_Region_view(long? REGION_VIEW_ID, long? REGION_ID, long? VIEW_TYPE_SETUP_ID, decimal? PITCH, decimal? BEARING, decimal? ZOOM, decimal? LATITUDE, decimal? LONGITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Region_view oRegion_view = new Region_view()
            {
                REGION_VIEW_ID = REGION_VIEW_ID,
                REGION_ID = REGION_ID,
                VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID,
                PITCH = PITCH,
                BEARING = BEARING,
                ZOOM = ZOOM,
                LATITUDE = LATITUDE,
                LONGITUDE = LONGITUDE,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_REGION_VIEW", oRegion_view, "REGION_VIEW_ID");
            return oRegion_view.REGION_VIEW_ID;
        }
        #endregion
    }
}
