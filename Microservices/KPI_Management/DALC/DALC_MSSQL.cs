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
        #region Get_Kpi_By_KPI_ID
        public Kpi Get_Kpi_By_KPI_ID(int? KPI_ID)
        {
            Kpi oKpi = null;
            dynamic _params = new ExpandoObject();
            _params.KPI_ID = KPI_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_KPI_BY_KPI_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oKpi = new Kpi();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oKpi);
            }
            return oKpi;
        }
        #endregion
        #region Get_Asset_By_ASSET_ID
        public Asset Get_Asset_By_ASSET_ID(long? ASSET_ID)
        {
            Asset oAsset = null;
            dynamic _params = new ExpandoObject();
            _params.ASSET_ID = ASSET_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ASSET_BY_ASSET_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oAsset = new Asset();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oAsset);
            }
            return oAsset;
        }
        #endregion
        #region Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID
        public Ext_study_zone Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID(int? EXT_STUDY_ZONE_ID)
        {
            Ext_study_zone oExt_study_zone = null;
            dynamic _params = new ExpandoObject();
            _params.EXT_STUDY_ZONE_ID = EXT_STUDY_ZONE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_EXT_STUDY_ZONE_BY_EXT_STUDY_ZONE_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oExt_study_zone = new Ext_study_zone();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oExt_study_zone);
            }
            return oExt_study_zone;
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
        #region Get_Space_asset_By_SPACE_ASSET_ID
        public Space_asset Get_Space_asset_By_SPACE_ASSET_ID(long? SPACE_ASSET_ID)
        {
            Space_asset oSpace_asset = null;
            dynamic _params = new ExpandoObject();
            _params.SPACE_ASSET_ID = SPACE_ASSET_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_SPACE_ASSET_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSpace_asset = new Space_asset();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSpace_asset);
            }
            return oSpace_asset;
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
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public Organization_data_source_kpi Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            Organization_data_source_kpi oOrganization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oOrganization_data_source_kpi = new Organization_data_source_kpi();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oOrganization_data_source_kpi);
            }
            return oOrganization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_FLOOR_ID
        public Floor Get_Floor_By_FLOOR_ID(long? FLOOR_ID)
        {
            Floor oFloor = null;
            dynamic _params = new ExpandoObject();
            _params.FLOOR_ID = FLOOR_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_FLOOR_BY_FLOOR_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oFloor = new Floor();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oFloor);
            }
            return oFloor;
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
        #region Get_Space_By_SPACE_ID
        public Space Get_Space_By_SPACE_ID(long? SPACE_ID)
        {
            Space oSpace = null;
            dynamic _params = new ExpandoObject();
            _params.SPACE_ID = SPACE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SPACE_BY_SPACE_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSpace = new Space();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSpace);
            }
            return oSpace;
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
        #region Get_Kpi_By_KPI_ID_List
        public List<Kpi> Get_Kpi_By_KPI_ID_List(IEnumerable<int?> KPI_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.KPI_ID_LIST = string.Join(",", KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Asset_By_ASSET_ID_List
        public List<Asset> Get_Asset_By_ASSET_ID_List(IEnumerable<long?> ASSET_ID_LIST)
        {
            List<Asset> oList_Asset = null;
            if (ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ASSET_ID_LIST = string.Join(",", ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_ASSET_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Asset = new List<Asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Asset oAsset = new Asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                            oList_Asset.Add(oAsset);
                        }
                    }
                }
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List
        public List<Ext_study_zone> Get_Ext_study_zone_By_EXT_STUDY_ZONE_ID_List(IEnumerable<int?> EXT_STUDY_ZONE_ID_LIST)
        {
            List<Ext_study_zone> oList_Ext_study_zone = null;
            if (EXT_STUDY_ZONE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.EXT_STUDY_ZONE_ID_LIST = string.Join(",", EXT_STUDY_ZONE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_EXT_STUDY_ZONE_BY_EXT_STUDY_ZONE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Ext_study_zone = new List<Ext_study_zone>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Ext_study_zone oExt_study_zone = new Ext_study_zone();
                            Props.Copy_Prop_Values_From_Data_Record(element, oExt_study_zone);
                            oList_Ext_study_zone.Add(oExt_study_zone);
                        }
                    }
                }
            }
            return oList_Ext_study_zone;
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
        #region Get_Space_asset_By_SPACE_ASSET_ID_List
        public List<Space_asset> Get_Space_asset_By_SPACE_ASSET_ID_List(IEnumerable<long?> SPACE_ASSET_ID_LIST)
        {
            List<Space_asset> oList_Space_asset = null;
            if (SPACE_ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SPACE_ASSET_ID_LIST = string.Join(",", SPACE_ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_SPACE_ASSET_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Space_asset = new List<Space_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space_asset oSpace_asset = new Space_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                            oList_Space_asset.Add(oSpace_asset);
                        }
                    }
                }
            }
            return oList_Space_asset;
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
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(IEnumerable<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_DATA_SOURCE_KPI_ID_LIST = string.Join(",", ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_ORGANIZATION_DATA_SOURCE_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                            oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                        }
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_FLOOR_ID_List
        public List<Floor> Get_Floor_By_FLOOR_ID_List(IEnumerable<long?> FLOOR_ID_LIST)
        {
            List<Floor> oList_Floor = null;
            if (FLOOR_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.FLOOR_ID_LIST = string.Join(",", FLOOR_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_FLOOR_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Floor = new List<Floor>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Floor oFloor = new Floor();
                            Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                            oList_Floor.Add(oFloor);
                        }
                    }
                }
            }
            return oList_Floor;
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
        #region Get_Space_By_SPACE_ID_List
        public List<Space> Get_Space_By_SPACE_ID_List(IEnumerable<long?> SPACE_ID_LIST)
        {
            List<Space> oList_Space = null;
            if (SPACE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SPACE_ID_LIST = string.Join(",", SPACE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_SPACE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Space = new List<Space>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space oSpace = new Space();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                            oList_Space.Add(oSpace);
                        }
                    }
                }
            }
            return oList_Space;
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
        #region Get_Kpi_By_OWNER_ID
        public List<Kpi> Get_Kpi_By_OWNER_ID(int? OWNER_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_DIMENSION_ID
        public List<Kpi> Get_Kpi_By_DIMENSION_ID(int? DIMENSION_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DIMENSION_ID = DIMENSION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_DIMENSION_ID", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID
        public List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_SETUP_CATEGORY_ID", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
        public List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(long? MIN_DATA_LEVEL_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.MIN_DATA_LEVEL_SETUP_ID = MIN_DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_MIN_DATA_LEVEL_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
        public List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(long? MAX_DATA_LEVEL_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.MAX_DATA_LEVEL_SETUP_ID = MAX_DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_MAX_DATA_LEVEL_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_OWNER_ID_IS_DELETED
        public List<Kpi> Get_Kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID
        public List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID(long? KPI_TYPE_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.KPI_TYPE_SETUP_ID = KPI_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_KPI_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Asset_By_OWNER_ID
        public List<Asset> Get_Asset_By_OWNER_ID(int? OWNER_ID)
        {
            List<Asset> oList_Asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID
        public List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID(long? ASSET_TYPE_SETUP_ID)
        {
            List<Asset> oList_Asset = null;
            dynamic _params = new ExpandoObject();
            _params.ASSET_TYPE_SETUP_ID = ASSET_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_ASSET_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_OWNER_ID_IS_DELETED
        public List<Asset> Get_Asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Asset> oList_Asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Ext_study_zone_By_OWNER_ID
        public List<Ext_study_zone> Get_Ext_study_zone_By_OWNER_ID(int? OWNER_ID)
        {
            List<Ext_study_zone> oList_Ext_study_zone = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_EXT_STUDY_ZONE_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Ext_study_zone = new List<Ext_study_zone>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Ext_study_zone oExt_study_zone = new Ext_study_zone();
                        Props.Copy_Prop_Values_From_Data_Record(element, oExt_study_zone);
                        oList_Ext_study_zone.Add(oExt_study_zone);
                    }
                }
            }
            return oList_Ext_study_zone;
        }
        #endregion
        #region Get_Ext_study_zone_By_OWNER_ID_IS_DELETED
        public List<Ext_study_zone> Get_Ext_study_zone_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Ext_study_zone> oList_Ext_study_zone = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_EXT_STUDY_ZONE_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Ext_study_zone = new List<Ext_study_zone>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Ext_study_zone oExt_study_zone = new Ext_study_zone();
                        Props.Copy_Prop_Values_From_Data_Record(element, oExt_study_zone);
                        oList_Ext_study_zone.Add(oExt_study_zone);
                    }
                }
            }
            return oList_Ext_study_zone;
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
        #region Get_Space_asset_By_OWNER_ID
        public List<Space_asset> Get_Space_asset_By_OWNER_ID(int? OWNER_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_SPACE_ID
        public List<Space_asset> Get_Space_asset_By_SPACE_ID(long? SPACE_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.SPACE_ID = SPACE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_SPACE_ID", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_ASSET_ID
        public List<Space_asset> Get_Space_asset_By_ASSET_ID(long? ASSET_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.ASSET_ID = ASSET_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_ASSET_ID", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_OWNER_ID_IS_DELETED
        public List<Space_asset> Get_Space_asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_EXTERNAL_ID
        public List<Space_asset> Get_Space_asset_By_EXTERNAL_ID(string EXTERNAL_ID)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.EXTERNAL_ID = EXTERNAL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_EXTERNAL_ID", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
        public List<Space_asset> Get_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(bool IS_MERAKI_WIFI_SIGNAL)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.IS_MERAKI_WIFI_SIGNAL = IS_MERAKI_WIFI_SIGNAL;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_IS_MERAKI_WIFI_SIGNAL", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            return oList_Space_asset;
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
        #region Get_Organization_data_source_kpi_By_OWNER_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID(int? OWNER_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID(int? DATA_SOURCE_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DATA_SOURCE_ID = DATA_SOURCE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_DATA_SOURCE_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID(int? KPI_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.KPI_ID = KPI_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_KPI_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.ORGANIZATION_ID = ORGANIZATION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_ORGANIZATION_ID", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_OWNER_ID_IS_DELETED
        public List<Floor> Get_Floor_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Floor> oList_Floor = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Floor_By_OWNER_ID
        public List<Floor> Get_Floor_By_OWNER_ID(int? OWNER_ID)
        {
            List<Floor> oList_Floor = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            return oList_Floor;
        }
        #endregion
        #region Get_Floor_By_ENTITY_ID
        public List<Floor> Get_Floor_By_ENTITY_ID(long? ENTITY_ID)
        {
            List<Floor> oList_Floor = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_ID = ENTITY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_ENTITY_ID", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            return oList_Floor;
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
        #region Get_Space_By_OWNER_ID
        public List<Space> Get_Space_By_OWNER_ID(int? OWNER_ID)
        {
            List<Space> oList_Space = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            return oList_Space;
        }
        #endregion
        #region Get_Space_By_FLOOR_ID
        public List<Space> Get_Space_By_FLOOR_ID(long? FLOOR_ID)
        {
            List<Space> oList_Space = null;
            dynamic _params = new ExpandoObject();
            _params.FLOOR_ID = FLOOR_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_FLOOR_ID", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            return oList_Space;
        }
        #endregion
        #region Get_Space_By_OWNER_ID_IS_DELETED
        public List<Space> Get_Space_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Space> oList_Space = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            return oList_Space;
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
        #region Get_Kpi_By_DIMENSION_ID_List
        public List<Kpi> Get_Kpi_By_DIMENSION_ID_List(IEnumerable<int?> DIMENSION_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (DIMENSION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DIMENSION_ID_LIST = string.Join(",", DIMENSION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_DIMENSION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID_List
        public List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_SETUP_CATEGORY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List
        public List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (MIN_DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.MIN_DATA_LEVEL_SETUP_ID_LIST = string.Join(",", MIN_DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_MIN_DATA_LEVEL_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List
        public List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (MAX_DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.MAX_DATA_LEVEL_SETUP_ID_LIST = string.Join(",", MAX_DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_MAX_DATA_LEVEL_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID_List
        public List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID_List(IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (KPI_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.KPI_TYPE_SETUP_ID_LIST = string.Join(",", KPI_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_KPI_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID_List
        public List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID_List(IEnumerable<long?> ASSET_TYPE_SETUP_ID_LIST)
        {
            List<Asset> oList_Asset = null;
            if (ASSET_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ASSET_TYPE_SETUP_ID_LIST = string.Join(",", ASSET_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_ASSET_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Asset = new List<Asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Asset oAsset = new Asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                            oList_Asset.Add(oAsset);
                        }
                    }
                }
            }
            return oList_Asset;
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
        #region Get_Space_asset_By_SPACE_ID_List
        public List<Space_asset> Get_Space_asset_By_SPACE_ID_List(IEnumerable<long?> SPACE_ID_LIST)
        {
            List<Space_asset> oList_Space_asset = null;
            if (SPACE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SPACE_ID_LIST = string.Join(",", SPACE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_SPACE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Space_asset = new List<Space_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space_asset oSpace_asset = new Space_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                            oList_Space_asset.Add(oSpace_asset);
                        }
                    }
                }
            }
            return oList_Space_asset;
        }
        #endregion
        #region Get_Space_asset_By_ASSET_ID_List
        public List<Space_asset> Get_Space_asset_By_ASSET_ID_List(IEnumerable<long?> ASSET_ID_LIST)
        {
            List<Space_asset> oList_Space_asset = null;
            if (ASSET_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ASSET_ID_LIST = string.Join(",", ASSET_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_ASSET_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Space_asset = new List<Space_asset>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space_asset oSpace_asset = new Space_asset();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                            oList_Space_asset.Add(oSpace_asset);
                        }
                    }
                }
            }
            return oList_Space_asset;
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
        #region Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_DATA_SOURCE_ID_List(IEnumerable<int?> DATA_SOURCE_ID_LIST)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            if (DATA_SOURCE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DATA_SOURCE_ID_LIST = string.Join(",", DATA_SOURCE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_DATA_SOURCE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                            oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                        }
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_KPI_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_KPI_ID_List(IEnumerable<int?> KPI_ID_LIST)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            if (KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.KPI_ID_LIST = string.Join(",", KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                            oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                        }
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_ORGANIZATION_ID_List(IEnumerable<int?> ORGANIZATION_ID_LIST)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            if (ORGANIZATION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ORGANIZATION_ID_LIST = string.Join(",", ORGANIZATION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_ORGANIZATION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                            oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                        }
                    }
                }
            }
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_ENTITY_ID_List
        public List<Floor> Get_Floor_By_ENTITY_ID_List(IEnumerable<long?> ENTITY_ID_LIST)
        {
            List<Floor> oList_Floor = null;
            if (ENTITY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_ID_LIST = string.Join(",", ENTITY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_ENTITY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Floor = new List<Floor>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Floor oFloor = new Floor();
                            Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                            oList_Floor.Add(oFloor);
                        }
                    }
                }
            }
            return oList_Floor;
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
        #region Get_Space_By_FLOOR_ID_List
        public List<Space> Get_Space_By_FLOOR_ID_List(IEnumerable<long?> FLOOR_ID_LIST)
        {
            List<Space> oList_Space = null;
            if (FLOOR_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.FLOOR_ID_LIST = string.Join(",", FLOOR_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_FLOOR_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Space = new List<Space>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Space oSpace = new Space();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                            oList_Space.Add(oSpace);
                        }
                    }
                }
            }
            return oList_Space;
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
        #region Get_Kpi_By_Where
        public List<Kpi> Get_Kpi_By_Where(string NAME, string UNIT, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.UNIT = UNIT;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Kpi;
        }
        #endregion
        #region Get_Asset_By_Where
        public List<Asset> Get_Asset_By_Where(string NAME, string GLTF_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Asset> oList_Asset = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.GLTF_URL = GLTF_URL;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Asset;
        }
        #endregion
        #region Get_Ext_study_zone_By_Where
        public List<Ext_study_zone> Get_Ext_study_zone_By_Where(string NAME, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Ext_study_zone> oList_Ext_study_zone = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.AREA_COLOR = AREA_COLOR;
            _params.BORDER_COLOR = BORDER_COLOR;
            _params.STUDY_ZONE_NAME = STUDY_ZONE_NAME;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_EXT_STUDY_ZONE_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Ext_study_zone = new List<Ext_study_zone>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Ext_study_zone oExt_study_zone = new Ext_study_zone();
                        Props.Copy_Prop_Values_From_Data_Record(element, oExt_study_zone);
                        oList_Ext_study_zone.Add(oExt_study_zone);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Ext_study_zone;
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
        #region Get_Space_asset_By_Where
        public List<Space_asset> Get_Space_asset_By_Where(string CUSTOM_NAME, string ASSET_ICON, string EXTERNAL_ID, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.CUSTOM_NAME = CUSTOM_NAME;
            _params.ASSET_ICON = ASSET_ICON;
            _params.EXTERNAL_ID = EXTERNAL_ID;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Space_asset;
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
        #region Get_Organization_data_source_kpi_By_Where
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_Where
        public List<Floor> Get_Floor_By_Where(string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, string UNIT, string NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Floor> oList_Floor = null;
            dynamic _params = new ExpandoObject();
            _params.SHELL_GLTF_URL = SHELL_GLTF_URL;
            _params.CLIPPED_GLTF_URL = CLIPPED_GLTF_URL;
            _params.ADVANCED_GLTF_URL = ADVANCED_GLTF_URL;
            _params.UNIT = UNIT;
            _params.NAME = NAME;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Floor;
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
        #region Get_Space_By_Where
        public List<Space> Get_Space_By_Where(string NAME, string UNIT, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Space> oList_Space = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.UNIT = UNIT;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Space;
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
        #region Get_Kpi_By_Where_In_List
        public List<Kpi> Get_Kpi_By_Where_In_List(string NAME, string UNIT, IEnumerable<int?> DIMENSION_ID_LIST, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST, IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST, IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.UNIT = UNIT;
            _params.DIMENSION_ID_LIST = DIMENSION_ID_LIST != null ? string.Join(",", DIMENSION_ID_LIST) : "";
            _params.SETUP_CATEGORY_ID_LIST = SETUP_CATEGORY_ID_LIST != null ? string.Join(",", SETUP_CATEGORY_ID_LIST) : "";
            _params.KPI_TYPE_SETUP_ID_LIST = KPI_TYPE_SETUP_ID_LIST != null ? string.Join(",", KPI_TYPE_SETUP_ID_LIST) : "";
            _params.MIN_DATA_LEVEL_SETUP_ID_LIST = MIN_DATA_LEVEL_SETUP_ID_LIST != null ? string.Join(",", MIN_DATA_LEVEL_SETUP_ID_LIST) : "";
            _params.MAX_DATA_LEVEL_SETUP_ID_LIST = MAX_DATA_LEVEL_SETUP_ID_LIST != null ? string.Join(",", MAX_DATA_LEVEL_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Kpi;
        }
        #endregion
        #region Get_Asset_By_Where_In_List
        public List<Asset> Get_Asset_By_Where_In_List(string NAME, string GLTF_URL, IEnumerable<long?> ASSET_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Asset> oList_Asset = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.GLTF_URL = GLTF_URL;
            _params.ASSET_TYPE_SETUP_ID_LIST = ASSET_TYPE_SETUP_ID_LIST != null ? string.Join(",", ASSET_TYPE_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ASSET_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Asset = new List<Asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Asset;
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
        #region Get_Space_asset_By_Where_In_List
        public List<Space_asset> Get_Space_asset_By_Where_In_List(string CUSTOM_NAME, string ASSET_ICON, IEnumerable<long?> SPACE_ID_LIST, IEnumerable<long?> ASSET_ID_LIST, IEnumerable<string> EXTERNAL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Space_asset> oList_Space_asset = null;
            dynamic _params = new ExpandoObject();
            _params.CUSTOM_NAME = CUSTOM_NAME;
            _params.ASSET_ICON = ASSET_ICON;
            _params.SPACE_ID_LIST = SPACE_ID_LIST != null ? string.Join(",", SPACE_ID_LIST) : "";
            _params.ASSET_ID_LIST = ASSET_ID_LIST != null ? string.Join(",", ASSET_ID_LIST) : "";
            _params.EXTERNAL_ID_LIST = EXTERNAL_ID_LIST != null ? string.Join(",", EXTERNAL_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_ASSET_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Space_asset = new List<Space_asset>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space_asset oSpace_asset = new Space_asset();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace_asset);
                        oList_Space_asset.Add(oSpace_asset);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Space_asset;
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
        #region Get_Organization_data_source_kpi_By_Where_In_List
        public List<Organization_data_source_kpi> Get_Organization_data_source_kpi_By_Where_In_List(string DESCRIPTION, IEnumerable<int?> DATA_SOURCE_ID_LIST, IEnumerable<int?> KPI_ID_LIST, IEnumerable<int?> ORGANIZATION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Organization_data_source_kpi> oList_Organization_data_source_kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.DATA_SOURCE_ID_LIST = DATA_SOURCE_ID_LIST != null ? string.Join(",", DATA_SOURCE_ID_LIST) : "";
            _params.KPI_ID_LIST = KPI_ID_LIST != null ? string.Join(",", KPI_ID_LIST) : "";
            _params.ORGANIZATION_ID_LIST = ORGANIZATION_ID_LIST != null ? string.Join(",", ORGANIZATION_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ORGANIZATION_DATA_SOURCE_KPI_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Organization_data_source_kpi = new List<Organization_data_source_kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oOrganization_data_source_kpi);
                        oList_Organization_data_source_kpi.Add(oOrganization_data_source_kpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Organization_data_source_kpi;
        }
        #endregion
        #region Get_Floor_By_Where_In_List
        public List<Floor> Get_Floor_By_Where_In_List(string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, string UNIT, string NAME, IEnumerable<long?> ENTITY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Floor> oList_Floor = null;
            dynamic _params = new ExpandoObject();
            _params.SHELL_GLTF_URL = SHELL_GLTF_URL;
            _params.CLIPPED_GLTF_URL = CLIPPED_GLTF_URL;
            _params.ADVANCED_GLTF_URL = ADVANCED_GLTF_URL;
            _params.UNIT = UNIT;
            _params.NAME = NAME;
            _params.ENTITY_ID_LIST = ENTITY_ID_LIST != null ? string.Join(",", ENTITY_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_FLOOR_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Floor = new List<Floor>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Floor oFloor = new Floor();
                        Props.Copy_Prop_Values_From_Data_Record(element, oFloor);
                        oList_Floor.Add(oFloor);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Floor;
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
        #region Get_Space_By_Where_In_List
        public List<Space> Get_Space_By_Where_In_List(string NAME, string UNIT, IEnumerable<long?> FLOOR_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Space> oList_Space = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.UNIT = UNIT;
            _params.FLOOR_ID_LIST = FLOOR_ID_LIST != null ? string.Join(",", FLOOR_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SPACE_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Space = new List<Space>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Space oSpace = new Space();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSpace);
                        oList_Space.Add(oSpace);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Space;
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
        #region Delete_Kpi
        public void Delete_Kpi(int? KPI_ID)
        {
            var _params = new
            {
                KPI_ID = KPI_ID
            };
            ExecuteDelete("UPG_DELETE_KPI", _params);
        }
        #endregion
        #region Delete_Asset
        public void Delete_Asset(long? ASSET_ID)
        {
            var _params = new
            {
                ASSET_ID = ASSET_ID
            };
            ExecuteDelete("UPG_DELETE_ASSET", _params);
        }
        #endregion
        #region Delete_Ext_study_zone
        public void Delete_Ext_study_zone(int? EXT_STUDY_ZONE_ID)
        {
            var _params = new
            {
                EXT_STUDY_ZONE_ID = EXT_STUDY_ZONE_ID
            };
            ExecuteDelete("UPG_DELETE_EXT_STUDY_ZONE", _params);
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
        #region Delete_Space_asset
        public void Delete_Space_asset(long? SPACE_ASSET_ID)
        {
            var _params = new
            {
                SPACE_ASSET_ID = SPACE_ASSET_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE_ASSET", _params);
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
        #region Delete_Organization_data_source_kpi
        public void Delete_Organization_data_source_kpi(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            var _params = new
            {
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DATA_SOURCE_KPI", _params);
        }
        #endregion
        #region Delete_Floor
        public void Delete_Floor(long? FLOOR_ID)
        {
            var _params = new
            {
                FLOOR_ID = FLOOR_ID
            };
            ExecuteDelete("UPG_DELETE_FLOOR", _params);
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
        #region Delete_Space
        public void Delete_Space(long? SPACE_ID)
        {
            var _params = new
            {
                SPACE_ID = SPACE_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE", _params);
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
        #region Delete_Kpi_By_OWNER_ID
        public void Delete_Kpi_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_KPI_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Kpi_By_DIMENSION_ID
        public void Delete_Kpi_By_DIMENSION_ID(int? DIMENSION_ID)
        {
            var _params = new
            {
                DIMENSION_ID = DIMENSION_ID
            };
            ExecuteDelete("UPG_DELETE_KPI_BY_DIMENSION_ID", _params);
        }
        #endregion
        #region Delete_Kpi_By_SETUP_CATEGORY_ID
        public void Delete_Kpi_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            var _params = new
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID
            };
            ExecuteDelete("UPG_DELETE_KPI_BY_SETUP_CATEGORY_ID", _params);
        }
        #endregion
        #region Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
        public void Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(long? MIN_DATA_LEVEL_SETUP_ID)
        {
            var _params = new
            {
                MIN_DATA_LEVEL_SETUP_ID = MIN_DATA_LEVEL_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_KPI_BY_MIN_DATA_LEVEL_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
        public void Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(long? MAX_DATA_LEVEL_SETUP_ID)
        {
            var _params = new
            {
                MAX_DATA_LEVEL_SETUP_ID = MAX_DATA_LEVEL_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_KPI_BY_MAX_DATA_LEVEL_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Kpi_By_OWNER_ID_IS_DELETED
        public void Delete_Kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_KPI_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Kpi_By_KPI_TYPE_SETUP_ID
        public void Delete_Kpi_By_KPI_TYPE_SETUP_ID(long? KPI_TYPE_SETUP_ID)
        {
            var _params = new
            {
                KPI_TYPE_SETUP_ID = KPI_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_KPI_BY_KPI_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Asset_By_OWNER_ID
        public void Delete_Asset_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ASSET_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Asset_By_ASSET_TYPE_SETUP_ID
        public void Delete_Asset_By_ASSET_TYPE_SETUP_ID(long? ASSET_TYPE_SETUP_ID)
        {
            var _params = new
            {
                ASSET_TYPE_SETUP_ID = ASSET_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_ASSET_BY_ASSET_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Asset_By_OWNER_ID_IS_DELETED
        public void Delete_Asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ASSET_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Ext_study_zone_By_OWNER_ID
        public void Delete_Ext_study_zone_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_EXT_STUDY_ZONE_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED
        public void Delete_Ext_study_zone_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_EXT_STUDY_ZONE_BY_OWNER_ID_IS_DELETED", _params);
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
        #region Delete_Space_asset_By_OWNER_ID
        public void Delete_Space_asset_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE_ASSET_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Space_asset_By_SPACE_ID
        public void Delete_Space_asset_By_SPACE_ID(long? SPACE_ID)
        {
            var _params = new
            {
                SPACE_ID = SPACE_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE_ASSET_BY_SPACE_ID", _params);
        }
        #endregion
        #region Delete_Space_asset_By_ASSET_ID
        public void Delete_Space_asset_By_ASSET_ID(long? ASSET_ID)
        {
            var _params = new
            {
                ASSET_ID = ASSET_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE_ASSET_BY_ASSET_ID", _params);
        }
        #endregion
        #region Delete_Space_asset_By_OWNER_ID_IS_DELETED
        public void Delete_Space_asset_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SPACE_ASSET_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Space_asset_By_EXTERNAL_ID
        public void Delete_Space_asset_By_EXTERNAL_ID(string EXTERNAL_ID)
        {
            var _params = new
            {
                EXTERNAL_ID = EXTERNAL_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE_ASSET_BY_EXTERNAL_ID", _params);
        }
        #endregion
        #region Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL
        public void Delete_Space_asset_By_IS_MERAKI_WIFI_SIGNAL(bool IS_MERAKI_WIFI_SIGNAL)
        {
            var _params = new
            {
                IS_MERAKI_WIFI_SIGNAL = IS_MERAKI_WIFI_SIGNAL
            };
            ExecuteDelete("UPG_DELETE_SPACE_ASSET_BY_IS_MERAKI_WIFI_SIGNAL", _params);
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
        #region Delete_Organization_data_source_kpi_By_OWNER_ID
        public void Delete_Organization_data_source_kpi_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DATA_SOURCE_KPI_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID
        public void Delete_Organization_data_source_kpi_By_DATA_SOURCE_ID(int? DATA_SOURCE_ID)
        {
            var _params = new
            {
                DATA_SOURCE_ID = DATA_SOURCE_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DATA_SOURCE_KPI_BY_DATA_SOURCE_ID", _params);
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_KPI_ID
        public void Delete_Organization_data_source_kpi_By_KPI_ID(int? KPI_ID)
        {
            var _params = new
            {
                KPI_ID = KPI_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DATA_SOURCE_KPI_BY_KPI_ID", _params);
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_ORGANIZATION_ID
        public void Delete_Organization_data_source_kpi_By_ORGANIZATION_ID(int? ORGANIZATION_ID)
        {
            var _params = new
            {
                ORGANIZATION_ID = ORGANIZATION_ID
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DATA_SOURCE_KPI_BY_ORGANIZATION_ID", _params);
        }
        #endregion
        #region Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED
        public void Delete_Organization_data_source_kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_ORGANIZATION_DATA_SOURCE_KPI_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Floor_By_OWNER_ID_IS_DELETED
        public void Delete_Floor_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_FLOOR_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Floor_By_OWNER_ID
        public void Delete_Floor_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_FLOOR_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Floor_By_ENTITY_ID
        public void Delete_Floor_By_ENTITY_ID(long? ENTITY_ID)
        {
            var _params = new
            {
                ENTITY_ID = ENTITY_ID
            };
            ExecuteDelete("UPG_DELETE_FLOOR_BY_ENTITY_ID", _params);
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
        #region Delete_Space_By_OWNER_ID
        public void Delete_Space_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Space_By_FLOOR_ID
        public void Delete_Space_By_FLOOR_ID(long? FLOOR_ID)
        {
            var _params = new
            {
                FLOOR_ID = FLOOR_ID
            };
            ExecuteDelete("UPG_DELETE_SPACE_BY_FLOOR_ID", _params);
        }
        #endregion
        #region Delete_Space_By_OWNER_ID_IS_DELETED
        public void Delete_Space_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SPACE_BY_OWNER_ID_IS_DELETED", _params);
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
        #region Edit_Kpi
        public int? Edit_Kpi(int? KPI_ID, int? DIMENSION_ID, int? SETUP_CATEGORY_ID, string NAME, string UNIT, long? KPI_TYPE_SETUP_ID, bool HAS_CORRELATION, bool IS_TRENDLINE, bool IS_DECIMAL_VALUE, bool HAS_SQM, bool IS_BY_SEVERITY, bool IS_ADDITIVE_DATA, decimal? MINIMUM_VALUE, decimal? MAXIMUM_VALUE, string LATEST_DATA_CREATION_DATE, bool IS_AUTO_GENERATE, long? MIN_DATA_LEVEL_SETUP_ID, long? MAX_DATA_LEVEL_SETUP_ID, bool IS_EXTERNAL, bool HAS_ALERTS, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Kpi oKpi = new Kpi()
            {
                KPI_ID = KPI_ID,
                DIMENSION_ID = DIMENSION_ID,
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID,
                NAME = NAME,
                UNIT = UNIT,
                KPI_TYPE_SETUP_ID = KPI_TYPE_SETUP_ID,
                HAS_CORRELATION = HAS_CORRELATION,
                IS_TRENDLINE = IS_TRENDLINE,
                IS_DECIMAL_VALUE = IS_DECIMAL_VALUE,
                HAS_SQM = HAS_SQM,
                IS_BY_SEVERITY = IS_BY_SEVERITY,
                IS_ADDITIVE_DATA = IS_ADDITIVE_DATA,
                MINIMUM_VALUE = MINIMUM_VALUE,
                MAXIMUM_VALUE = MAXIMUM_VALUE,
                LATEST_DATA_CREATION_DATE = LATEST_DATA_CREATION_DATE,
                IS_AUTO_GENERATE = IS_AUTO_GENERATE,
                MIN_DATA_LEVEL_SETUP_ID = MIN_DATA_LEVEL_SETUP_ID,
                MAX_DATA_LEVEL_SETUP_ID = MAX_DATA_LEVEL_SETUP_ID,
                IS_EXTERNAL = IS_EXTERNAL,
                HAS_ALERTS = HAS_ALERTS,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_KPI", oKpi, "KPI_ID");
            return oKpi.KPI_ID;
        }
        #endregion
        #region Edit_Asset
        public long? Edit_Asset(long? ASSET_ID, long? ASSET_TYPE_SETUP_ID, string NAME, string GLTF_URL, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Asset oAsset = new Asset()
            {
                ASSET_ID = ASSET_ID,
                ASSET_TYPE_SETUP_ID = ASSET_TYPE_SETUP_ID,
                NAME = NAME,
                GLTF_URL = GLTF_URL,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_ASSET", oAsset, "ASSET_ID");
            return oAsset.ASSET_ID;
        }
        #endregion
        #region Edit_Ext_study_zone
        public int? Edit_Ext_study_zone(int? EXT_STUDY_ZONE_ID, string NAME, decimal? LATITUDE, decimal? LONGITUDE, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Ext_study_zone oExt_study_zone = new Ext_study_zone()
            {
                EXT_STUDY_ZONE_ID = EXT_STUDY_ZONE_ID,
                NAME = NAME,
                LATITUDE = LATITUDE,
                LONGITUDE = LONGITUDE,
                AREA_COLOR = AREA_COLOR,
                BORDER_COLOR = BORDER_COLOR,
                STUDY_ZONE_NAME = STUDY_ZONE_NAME,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_EXT_STUDY_ZONE", oExt_study_zone, "EXT_STUDY_ZONE_ID");
            return oExt_study_zone.EXT_STUDY_ZONE_ID;
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
        #region Edit_Space_asset
        public long? Edit_Space_asset(long? SPACE_ASSET_ID, long? SPACE_ID, long? ASSET_ID, string EXTERNAL_ID, bool IS_MERAKI_WIFI_SIGNAL, string CUSTOM_NAME, decimal? POSITION_X, decimal? POSITION_Y, decimal? POSITION_Z, decimal? SCALE_MULTIPLIER, decimal? ROTATE_X, decimal? ROTATE_Y, decimal? ROTATE_Z, string ASSET_ICON, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Space_asset oSpace_asset = new Space_asset()
            {
                SPACE_ASSET_ID = SPACE_ASSET_ID,
                SPACE_ID = SPACE_ID,
                ASSET_ID = ASSET_ID,
                EXTERNAL_ID = EXTERNAL_ID,
                IS_MERAKI_WIFI_SIGNAL = IS_MERAKI_WIFI_SIGNAL,
                CUSTOM_NAME = CUSTOM_NAME,
                POSITION_X = POSITION_X,
                POSITION_Y = POSITION_Y,
                POSITION_Z = POSITION_Z,
                SCALE_MULTIPLIER = SCALE_MULTIPLIER,
                ROTATE_X = ROTATE_X,
                ROTATE_Y = ROTATE_Y,
                ROTATE_Z = ROTATE_Z,
                ASSET_ICON = ASSET_ICON,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_SPACE_ASSET", oSpace_asset, "SPACE_ASSET_ID");
            return oSpace_asset.SPACE_ASSET_ID;
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
        #region Edit_Organization_data_source_kpi
        public int? Edit_Organization_data_source_kpi(int? ORGANIZATION_DATA_SOURCE_KPI_ID, int? DATA_SOURCE_ID, int? KPI_ID, int? ORGANIZATION_ID, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Organization_data_source_kpi oOrganization_data_source_kpi = new Organization_data_source_kpi()
            {
                ORGANIZATION_DATA_SOURCE_KPI_ID = ORGANIZATION_DATA_SOURCE_KPI_ID,
                DATA_SOURCE_ID = DATA_SOURCE_ID,
                KPI_ID = KPI_ID,
                ORGANIZATION_ID = ORGANIZATION_ID,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_ORGANIZATION_DATA_SOURCE_KPI", oOrganization_data_source_kpi, "ORGANIZATION_DATA_SOURCE_KPI_ID");
            return oOrganization_data_source_kpi.ORGANIZATION_DATA_SOURCE_KPI_ID;
        }
        #endregion
        #region Edit_Floor
        public long? Edit_Floor(long? FLOOR_ID, long? ENTITY_ID, int? FLOOR_NUMBER, string SHELL_GLTF_URL, string CLIPPED_GLTF_URL, string ADVANCED_GLTF_URL, decimal? AREA, string UNIT, string NAME, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Floor oFloor = new Floor()
            {
                FLOOR_ID = FLOOR_ID,
                ENTITY_ID = ENTITY_ID,
                FLOOR_NUMBER = FLOOR_NUMBER,
                SHELL_GLTF_URL = SHELL_GLTF_URL,
                CLIPPED_GLTF_URL = CLIPPED_GLTF_URL,
                ADVANCED_GLTF_URL = ADVANCED_GLTF_URL,
                AREA = AREA,
                UNIT = UNIT,
                NAME = NAME,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_FLOOR", oFloor, "FLOOR_ID");
            return oFloor.FLOOR_ID;
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
        #region Edit_Space
        public long? Edit_Space(long? SPACE_ID, long? FLOOR_ID, string NAME, decimal? AREA, string UNIT, int? OCCUPANT_LOAD_FACTOR, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Space oSpace = new Space()
            {
                SPACE_ID = SPACE_ID,
                FLOOR_ID = FLOOR_ID,
                NAME = NAME,
                AREA = AREA,
                UNIT = UNIT,
                OCCUPANT_LOAD_FACTOR = OCCUPANT_LOAD_FACTOR,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_SPACE", oSpace, "SPACE_ID");
            return oSpace.SPACE_ID;
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
    }
}
