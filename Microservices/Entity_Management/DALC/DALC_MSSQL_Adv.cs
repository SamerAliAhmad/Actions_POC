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
        #region Get_Entity_view_By_ENTITY_VIEW_ID_Adv
        public Entity_view Get_Entity_view_By_ENTITY_VIEW_ID_Adv(long? ENTITY_VIEW_ID)
        {
            Entity_view oEntity_view = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_VIEW_ID = ENTITY_VIEW_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_ENTITY_VIEW_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oEntity_view = new Entity_view();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oEntity_view);
                oEntity_view.Entity = new Entity();
                oEntity_view.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_ENTITY_ID");
                oEntity_view.Entity.SITE_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_SITE_ID");
                oEntity_view.Entity.AREA_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_AREA_ID");
                oEntity_view.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_DISTRICT_ID");
                oEntity_view.Entity.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_REGION_ID");
                oEntity_view.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_TOP_LEVEL_ID");
                oEntity_view.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                oEntity_view.Entity.NAME = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_NAME");
                oEntity_view.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(_query_response, "T_ENTITY_NUMBER_OF_FLOORS");
                oEntity_view.Entity.GLA = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_GLA");
                oEntity_view.Entity.GLA_UNIT = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_GLA_UNIT");
                oEntity_view.Entity.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_AREA");
                oEntity_view.Entity.UNIT = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_UNIT");
                oEntity_view.Entity.SCALE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_SCALE");
                oEntity_view.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_ROTATIONX");
                oEntity_view.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_ROTATIONY");
                oEntity_view.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_ROTATIONZ");
                oEntity_view.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_GLTF_LATITUDE");
                oEntity_view.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_GLTF_LONGITUDE");
                oEntity_view.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_CENTER_LATITUDE");
                oEntity_view.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_CENTER_LONGITUDE");
                oEntity_view.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_RADIUS_IN_METERS");
                oEntity_view.Entity.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_IMAGE_URL");
                oEntity_view.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_SOLID_GLTF_URL");
                oEntity_view.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_POPUL_ALT_X");
                oEntity_view.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_POPUP_ALT_Y");
                oEntity_view.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(_query_response, "T_ENTITY_POPUP_ALT_Z");
                oEntity_view.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_ENTRY_USER_ID");
                oEntity_view.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_ENTRY_DATE");
                oEntity_view.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_LAST_UPDATE");
                oEntity_view.Entity.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ENTITY_IS_DELETED");
                oEntity_view.Entity.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ENTITY_OWNER_ID");
                oEntity_view.View_type_setup = new Setup();
                oEntity_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIEW_TYPE_SETUP_SETUP_ID");
                oEntity_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                oEntity_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                oEntity_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                oEntity_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                oEntity_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_DELETED");
                oEntity_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                oEntity_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                oEntity_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_VALUE");
                oEntity_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                oEntity_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                oEntity_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                oEntity_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                oEntity_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_OWNER_ID");
            }
            return oEntity_view;
        }
        #endregion
        #region Get_Entity_By_ENTITY_ID_Adv
        public Entity Get_Entity_By_ENTITY_ID_Adv(long? ENTITY_ID)
        {
            Entity oEntity = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_ID = ENTITY_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_ENTITY_BY_ENTITY_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oEntity = new Entity();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oEntity);
                oEntity.Area = new Area();
                oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_AREA_ID");
                oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_DISTRICT_ID");
                oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_REGION_ID");
                oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_TOP_LEVEL_ID");
                oEntity.Area.NAME = Get_Data_Record_Value<string>(_query_response, "T_AREA_NAME");
                oEntity.Area.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_AREA_LOCATION");
                oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_AREA");
                oEntity.Area.UNIT = Get_Data_Record_Value<string>(_query_response, "T_AREA_UNIT");
                oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_SCALE");
                oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_ROTATIONX");
                oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_ROTATIONY");
                oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_ROTATIONZ");
                oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_GLTF_LATITUDE");
                oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_GLTF_LONGITUDE");
                oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_CENTER_LATITUDE");
                oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_CENTER_LONGITUDE");
                oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_RADIUS_IN_METERS");
                oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_AREA_IMAGE_URL");
                oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_AREA_LOGO_URL");
                oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_AREA_SOLID_GLTF_URL");
                oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_AREA_AREA_COLOR");
                oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_AREA_BORDER_COLOR");
                oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_AREA_STUDY_ZONE_NAME");
                oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_ENTRY_USER_ID");
                oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_AREA_ENTRY_DATE");
                oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_AREA_LAST_UPDATE");
                oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_AREA_IS_DELETED");
                oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_AREA_OWNER_ID");
                oEntity.District = new District();
                oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_DISTRICT_ID");
                oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_REGION_ID");
                oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_TOP_LEVEL_ID");
                oEntity.District.NAME = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_NAME");
                oEntity.District.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_LOCATION");
                oEntity.District.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_AREA");
                oEntity.District.UNIT = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_UNIT");
                oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_SCALE");
                oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_ROTATIONX");
                oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_ROTATIONY");
                oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_ROTATIONZ");
                oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_GLTF_LATITUDE");
                oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_GLTF_LONGITUDE");
                oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_CENTER_LATITUDE");
                oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_CENTER_LONGITUDE");
                oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_RADIUS_IN_METERS");
                oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_IMAGE_URL");
                oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_LOGO_URL");
                oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_SOLID_GLTF_URL");
                oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_AREA_COLOR");
                oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_BORDER_COLOR");
                oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_STUDY_ZONE_NAME");
                oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_ENTRY_USER_ID");
                oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_ENTRY_DATE");
                oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_LAST_UPDATE");
                oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_DISTRICT_IS_DELETED");
                oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_DISTRICT_OWNER_ID");
                oEntity.Region = new Region();
                oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_REGION_ID");
                oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_TOP_LEVEL_ID");
                oEntity.Region.NAME = Get_Data_Record_Value<string>(_query_response, "T_REGION_NAME");
                oEntity.Region.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_REGION_LOCATION");
                oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_REGION_AREA");
                oEntity.Region.UNIT = Get_Data_Record_Value<string>(_query_response, "T_REGION_UNIT");
                oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_REGION_IMAGE_URL");
                oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_REGION_LOGO_URL");
                oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_REGION_AREA_COLOR");
                oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_REGION_BORDER_COLOR");
                oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_REGION_STUDY_ZONE_NAME");
                oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_ENTRY_USER_ID");
                oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_REGION_ENTRY_DATE");
                oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_REGION_LAST_UPDATE");
                oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_REGION_IS_DELETED");
                oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_REGION_OWNER_ID");
                oEntity.Site = new Site();
                oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_SITE_ID");
                oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_AREA_ID");
                oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_DISTRICT_ID");
                oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_REGION_ID");
                oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_TOP_LEVEL_ID");
                oEntity.Site.NAME = Get_Data_Record_Value<string>(_query_response, "T_SITE_NAME");
                oEntity.Site.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_SITE_LOCATION");
                oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_AREA");
                oEntity.Site.UNIT = Get_Data_Record_Value<string>(_query_response, "T_SITE_UNIT");
                oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_SCALE");
                oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_ROTATIONX");
                oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_ROTATIONY");
                oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_ROTATIONZ");
                oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_GLTF_LATITUDE");
                oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_GLTF_LONGITUDE");
                oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_CENTER_LATITUDE");
                oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_CENTER_LONGITUDE");
                oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_RADIUS_IN_METERS");
                oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_SITE_IMAGE_URL");
                oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_SITE_LOGO_URL");
                oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_SITE_SOLID_GLTF_URL");
                oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_SITE_AREA_COLOR");
                oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_SITE_BORDER_COLOR");
                oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_SITE_STUDY_ZONE_NAME");
                oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_ENTRY_USER_ID");
                oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_SITE_ENTRY_DATE");
                oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_SITE_LAST_UPDATE");
                oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_SITE_IS_DELETED");
                oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_SITE_OWNER_ID");
                oEntity.Top_level = new Top_level();
                oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_TOP_LEVEL_TOP_LEVEL_ID");
                oEntity.Top_level.NAME = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_NAME");
                oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LOCATION");
                oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_TOP_LEVEL_AREA");
                oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_IMAGE_URL");
                oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LOGO_URL");
                oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_AREA_COLOR");
                oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_BORDER_COLOR");
                oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_LOW_THRESHOLD");
                oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_HIGH_THRESHOLD");
                oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_TOP_LEVEL_ENTRY_USER_ID");
                oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_ENTRY_DATE");
                oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LAST_UPDATE");
                oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_TOP_LEVEL_IS_DELETED");
                oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_OWNER_ID");
                oEntity.Entity_type_setup = new Setup();
                oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_TYPE_SETUP_VALUE");
                oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_ENTITY_TYPE_SETUP_OWNER_ID");
            }
            return oEntity;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_Adv
        public Setup Get_Setup_By_SETUP_ID_Adv(long? SETUP_ID)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_ID = SETUP_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
                oSetup.Setup_category = new Setup_category();
                oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_DESCRIPTION");
                oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_ENTRY_DATE");
                oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_LAST_UPDATE");
                oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_SETUP_CATEGORY_IS_DELETED");
                oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_OWNER_ID");
            }
            return oSetup;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_VIEW_ID_List_Adv
        public List<Entity_view> Get_Entity_view_By_ENTITY_VIEW_ID_List_Adv(IEnumerable<long?> ENTITY_VIEW_ID_LIST)
        {
            List<Entity_view> oList_Entity_view = null;
            if (ENTITY_VIEW_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_VIEW_ID_LIST = string.Join(",", ENTITY_VIEW_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_ENTITY_VIEW_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Entity_view = new List<Entity_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity_view oEntity_view = new Entity_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                            oEntity_view.Entity = new Entity();
                            oEntity_view.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                            oEntity_view.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                            oEntity_view.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                            oEntity_view.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                            oEntity_view.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                            oEntity_view.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                            oEntity_view.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                            oEntity_view.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                            oEntity_view.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                            oEntity_view.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                            oEntity_view.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                            oEntity_view.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                            oEntity_view.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                            oEntity_view.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                            oEntity_view.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                            oEntity_view.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                            oEntity_view.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                            oEntity_view.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                            oEntity_view.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                            oEntity_view.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                            oEntity_view.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                            oEntity_view.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                            oEntity_view.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                            oEntity_view.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                            oEntity_view.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                            oEntity_view.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                            oEntity_view.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                            oEntity_view.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                            oEntity_view.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                            oEntity_view.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                            oEntity_view.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                            oEntity_view.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                            oEntity_view.View_type_setup = new Setup();
                            oEntity_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oEntity_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oEntity_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oEntity_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oEntity_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oEntity_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oEntity_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oEntity_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oEntity_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oEntity_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oEntity_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oEntity_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oEntity_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oEntity_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_Entity_view.Add(oEntity_view);
                        }
                    }
                }
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_ENTITY_ID_List_Adv
        public List<Entity> Get_Entity_By_ENTITY_ID_List_Adv(IEnumerable<long?> ENTITY_ID_LIST)
        {
            List<Entity> oList_Entity = null;
            if (ENTITY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_ID_LIST = string.Join(",", ENTITY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_ENTITY_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Entity = new List<Entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity oEntity = new Entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                            oEntity.Area = new Area();
                            oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oEntity.District = new District();
                            oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oEntity.Region = new Region();
                            oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oEntity.Site = new Site();
                            oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                            oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                            oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                            oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                            oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                            oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                            oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                            oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                            oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                            oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                            oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                            oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                            oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                            oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                            oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                            oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                            oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                            oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                            oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                            oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                            oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                            oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                            oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                            oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                            oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                            oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                            oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                            oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                            oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                            oEntity.Top_level = new Top_level();
                            oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oEntity.Entity_type_setup = new Setup();
                            oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                            oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                            oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                            oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                            oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                            oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                            oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                            oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                            oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                            oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                            oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                            oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                            oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                            oList_Entity.Add(oEntity);
                        }
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_ID_List_Adv(IEnumerable<long?> SETUP_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_ID_LIST = string.Join(",", SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oSetup.Setup_category = new Setup_category();
                            oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                            oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                            oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                            oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                            oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                            oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                            oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                            oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Entity_view_By_OWNER_ID_Adv
        public List<Entity_view> Get_Entity_view_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        oEntity_view.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oEntity_view.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oEntity_view.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oEntity_view.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oEntity_view.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oEntity_view.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oEntity_view.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oEntity_view.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oEntity_view.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oEntity_view.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oEntity_view.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oEntity_view.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oEntity_view.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oEntity_view.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oEntity_view.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oEntity_view.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oEntity_view.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oEntity_view.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oEntity_view.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oEntity_view.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oEntity_view.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oEntity_view.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oEntity_view.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oEntity_view.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oEntity_view.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oEntity_view.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oEntity_view.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oEntity_view.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oEntity_view.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oEntity_view.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oEntity_view.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oEntity_view.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oEntity_view.View_type_setup = new Setup();
                        oEntity_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oEntity_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oEntity_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oEntity_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oEntity_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oEntity_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oEntity_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oEntity_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oEntity_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oEntity_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID_Adv
        public List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID_Adv(long? VIEW_TYPE_SETUP_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            dynamic _params = new ExpandoObject();
            _params.VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_VIEW_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        oEntity_view.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oEntity_view.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oEntity_view.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oEntity_view.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oEntity_view.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oEntity_view.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oEntity_view.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oEntity_view.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oEntity_view.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oEntity_view.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oEntity_view.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oEntity_view.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oEntity_view.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oEntity_view.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oEntity_view.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oEntity_view.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oEntity_view.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oEntity_view.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oEntity_view.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oEntity_view.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oEntity_view.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oEntity_view.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oEntity_view.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oEntity_view.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oEntity_view.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oEntity_view.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oEntity_view.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oEntity_view.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oEntity_view.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oEntity_view.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oEntity_view.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oEntity_view.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oEntity_view.View_type_setup = new Setup();
                        oEntity_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oEntity_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oEntity_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oEntity_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oEntity_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oEntity_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oEntity_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oEntity_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oEntity_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oEntity_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_OWNER_ID_IS_DELETED_Adv
        public List<Entity_view> Get_Entity_view_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Entity_view> oList_Entity_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        oEntity_view.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oEntity_view.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oEntity_view.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oEntity_view.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oEntity_view.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oEntity_view.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oEntity_view.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oEntity_view.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oEntity_view.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oEntity_view.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oEntity_view.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oEntity_view.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oEntity_view.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oEntity_view.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oEntity_view.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oEntity_view.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oEntity_view.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oEntity_view.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oEntity_view.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oEntity_view.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oEntity_view.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oEntity_view.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oEntity_view.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oEntity_view.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oEntity_view.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oEntity_view.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oEntity_view.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oEntity_view.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oEntity_view.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oEntity_view.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oEntity_view.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oEntity_view.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oEntity_view.View_type_setup = new Setup();
                        oEntity_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oEntity_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oEntity_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oEntity_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oEntity_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oEntity_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oEntity_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oEntity_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oEntity_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oEntity_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_ID_Adv
        public List<Entity_view> Get_Entity_view_By_ENTITY_ID_Adv(long? ENTITY_ID)
        {
            List<Entity_view> oList_Entity_view = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_ID = ENTITY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_ENTITY_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        oEntity_view.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oEntity_view.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oEntity_view.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oEntity_view.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oEntity_view.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oEntity_view.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oEntity_view.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oEntity_view.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oEntity_view.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oEntity_view.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oEntity_view.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oEntity_view.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oEntity_view.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oEntity_view.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oEntity_view.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oEntity_view.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oEntity_view.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oEntity_view.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oEntity_view.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oEntity_view.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oEntity_view.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oEntity_view.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oEntity_view.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oEntity_view.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oEntity_view.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oEntity_view.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oEntity_view.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oEntity_view.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oEntity_view.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oEntity_view.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oEntity_view.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oEntity_view.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oEntity_view.View_type_setup = new Setup();
                        oEntity_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oEntity_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oEntity_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oEntity_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oEntity_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oEntity_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oEntity_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oEntity_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oEntity_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oEntity_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_OWNER_ID_IS_DELETED_Adv
        public List<Entity> Get_Entity_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oEntity.Area = new Area();
                        oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oEntity.District = new District();
                        oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oEntity.Region = new Region();
                        oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oEntity.Site = new Site();
                        oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oEntity.Top_level = new Top_level();
                        oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oEntity.Entity_type_setup = new Setup();
                        oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                        oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                        oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                        oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                        oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                        oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                        oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                        oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                        oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                        oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_OWNER_ID_Adv
        public List<Entity> Get_Entity_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oEntity.Area = new Area();
                        oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oEntity.District = new District();
                        oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oEntity.Region = new Region();
                        oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oEntity.Site = new Site();
                        oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oEntity.Top_level = new Top_level();
                        oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oEntity.Entity_type_setup = new Setup();
                        oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                        oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                        oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                        oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                        oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                        oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                        oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                        oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                        oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                        oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_SITE_ID_Adv
        public List<Entity> Get_Entity_By_SITE_ID_Adv(long? SITE_ID)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_ID = SITE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_SITE_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oEntity.Area = new Area();
                        oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oEntity.District = new District();
                        oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oEntity.Region = new Region();
                        oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oEntity.Site = new Site();
                        oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oEntity.Top_level = new Top_level();
                        oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oEntity.Entity_type_setup = new Setup();
                        oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                        oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                        oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                        oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                        oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                        oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                        oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                        oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                        oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                        oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_AREA_ID_Adv
        public List<Entity> Get_Entity_By_AREA_ID_Adv(long? AREA_ID)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.AREA_ID = AREA_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_AREA_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oEntity.Area = new Area();
                        oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oEntity.District = new District();
                        oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oEntity.Region = new Region();
                        oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oEntity.Site = new Site();
                        oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oEntity.Top_level = new Top_level();
                        oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oEntity.Entity_type_setup = new Setup();
                        oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                        oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                        oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                        oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                        oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                        oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                        oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                        oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                        oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                        oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_DISTRICT_ID_Adv
        public List<Entity> Get_Entity_By_DISTRICT_ID_Adv(long? DISTRICT_ID)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_ID = DISTRICT_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_DISTRICT_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oEntity.Area = new Area();
                        oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oEntity.District = new District();
                        oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oEntity.Region = new Region();
                        oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oEntity.Site = new Site();
                        oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oEntity.Top_level = new Top_level();
                        oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oEntity.Entity_type_setup = new Setup();
                        oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                        oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                        oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                        oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                        oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                        oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                        oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                        oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                        oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                        oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_REGION_ID_Adv
        public List<Entity> Get_Entity_By_REGION_ID_Adv(long? REGION_ID)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.REGION_ID = REGION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_REGION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oEntity.Area = new Area();
                        oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oEntity.District = new District();
                        oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oEntity.Region = new Region();
                        oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oEntity.Site = new Site();
                        oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oEntity.Top_level = new Top_level();
                        oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oEntity.Entity_type_setup = new Setup();
                        oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                        oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                        oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                        oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                        oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                        oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                        oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                        oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                        oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                        oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID_Adv
        public List<Entity> Get_Entity_By_TOP_LEVEL_ID_Adv(long? TOP_LEVEL_ID)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.TOP_LEVEL_ID = TOP_LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_TOP_LEVEL_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oEntity.Area = new Area();
                        oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oEntity.District = new District();
                        oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oEntity.Region = new Region();
                        oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oEntity.Site = new Site();
                        oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oEntity.Top_level = new Top_level();
                        oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oEntity.Entity_type_setup = new Setup();
                        oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                        oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                        oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                        oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                        oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                        oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                        oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                        oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                        oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                        oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID_Adv
        public List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID_Adv(long? ENTITY_TYPE_SETUP_ID)
        {
            List<Entity> oList_Entity = null;
            dynamic _params = new ExpandoObject();
            _params.ENTITY_TYPE_SETUP_ID = ENTITY_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_ENTITY_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oEntity.Area = new Area();
                        oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oEntity.District = new District();
                        oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oEntity.Region = new Region();
                        oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oEntity.Site = new Site();
                        oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oEntity.Top_level = new Top_level();
                        oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oEntity.Entity_type_setup = new Setup();
                        oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                        oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                        oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                        oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                        oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                        oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                        oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                        oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                        oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                        oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_Adv(int? SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(int? SETUP_CATEGORY_ID, string VALUE)
        {
            Setup oSetup = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            _params.VALUE = VALUE;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_VALUE_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSetup);
                oSetup.Setup_category = new Setup_category();
                oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_DESCRIPTION");
                oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_ENTRY_DATE");
                oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_LAST_UPDATE");
                oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_SETUP_CATEGORY_IS_DELETED");
                oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_OWNER_ID");
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        public List<Entity_view> Get_Entity_view_By_VIEW_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST)
        {
            List<Entity_view> oList_Entity_view = null;
            if (VIEW_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIEW_TYPE_SETUP_ID_LIST = string.Join(",", VIEW_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_VIEW_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Entity_view = new List<Entity_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity_view oEntity_view = new Entity_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                            oEntity_view.Entity = new Entity();
                            oEntity_view.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                            oEntity_view.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                            oEntity_view.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                            oEntity_view.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                            oEntity_view.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                            oEntity_view.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                            oEntity_view.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                            oEntity_view.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                            oEntity_view.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                            oEntity_view.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                            oEntity_view.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                            oEntity_view.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                            oEntity_view.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                            oEntity_view.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                            oEntity_view.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                            oEntity_view.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                            oEntity_view.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                            oEntity_view.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                            oEntity_view.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                            oEntity_view.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                            oEntity_view.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                            oEntity_view.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                            oEntity_view.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                            oEntity_view.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                            oEntity_view.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                            oEntity_view.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                            oEntity_view.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                            oEntity_view.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                            oEntity_view.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                            oEntity_view.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                            oEntity_view.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                            oEntity_view.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                            oEntity_view.View_type_setup = new Setup();
                            oEntity_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oEntity_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oEntity_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oEntity_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oEntity_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oEntity_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oEntity_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oEntity_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oEntity_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oEntity_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oEntity_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oEntity_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oEntity_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oEntity_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_Entity_view.Add(oEntity_view);
                        }
                    }
                }
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_view_By_ENTITY_ID_List_Adv
        public List<Entity_view> Get_Entity_view_By_ENTITY_ID_List_Adv(IEnumerable<long?> ENTITY_ID_LIST)
        {
            List<Entity_view> oList_Entity_view = null;
            if (ENTITY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_ID_LIST = string.Join(",", ENTITY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_ENTITY_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Entity_view = new List<Entity_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity_view oEntity_view = new Entity_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                            oEntity_view.Entity = new Entity();
                            oEntity_view.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                            oEntity_view.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                            oEntity_view.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                            oEntity_view.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                            oEntity_view.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                            oEntity_view.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                            oEntity_view.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                            oEntity_view.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                            oEntity_view.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                            oEntity_view.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                            oEntity_view.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                            oEntity_view.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                            oEntity_view.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                            oEntity_view.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                            oEntity_view.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                            oEntity_view.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                            oEntity_view.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                            oEntity_view.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                            oEntity_view.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                            oEntity_view.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                            oEntity_view.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                            oEntity_view.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                            oEntity_view.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                            oEntity_view.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                            oEntity_view.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                            oEntity_view.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                            oEntity_view.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                            oEntity_view.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                            oEntity_view.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                            oEntity_view.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                            oEntity_view.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                            oEntity_view.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                            oEntity_view.View_type_setup = new Setup();
                            oEntity_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oEntity_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oEntity_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oEntity_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oEntity_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oEntity_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oEntity_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oEntity_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oEntity_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oEntity_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oEntity_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oEntity_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oEntity_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oEntity_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_Entity_view.Add(oEntity_view);
                        }
                    }
                }
            }
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_SITE_ID_List_Adv
        public List<Entity> Get_Entity_By_SITE_ID_List_Adv(IEnumerable<long?> SITE_ID_LIST)
        {
            List<Entity> oList_Entity = null;
            if (SITE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_ID_LIST = string.Join(",", SITE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_SITE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Entity = new List<Entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity oEntity = new Entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                            oEntity.Area = new Area();
                            oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oEntity.District = new District();
                            oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oEntity.Region = new Region();
                            oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oEntity.Site = new Site();
                            oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                            oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                            oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                            oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                            oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                            oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                            oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                            oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                            oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                            oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                            oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                            oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                            oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                            oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                            oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                            oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                            oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                            oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                            oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                            oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                            oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                            oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                            oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                            oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                            oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                            oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                            oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                            oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                            oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                            oEntity.Top_level = new Top_level();
                            oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oEntity.Entity_type_setup = new Setup();
                            oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                            oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                            oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                            oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                            oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                            oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                            oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                            oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                            oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                            oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                            oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                            oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                            oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                            oList_Entity.Add(oEntity);
                        }
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_AREA_ID_List_Adv
        public List<Entity> Get_Entity_By_AREA_ID_List_Adv(IEnumerable<long?> AREA_ID_LIST)
        {
            List<Entity> oList_Entity = null;
            if (AREA_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.AREA_ID_LIST = string.Join(",", AREA_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_AREA_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Entity = new List<Entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity oEntity = new Entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                            oEntity.Area = new Area();
                            oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oEntity.District = new District();
                            oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oEntity.Region = new Region();
                            oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oEntity.Site = new Site();
                            oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                            oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                            oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                            oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                            oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                            oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                            oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                            oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                            oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                            oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                            oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                            oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                            oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                            oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                            oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                            oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                            oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                            oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                            oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                            oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                            oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                            oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                            oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                            oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                            oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                            oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                            oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                            oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                            oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                            oEntity.Top_level = new Top_level();
                            oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oEntity.Entity_type_setup = new Setup();
                            oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                            oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                            oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                            oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                            oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                            oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                            oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                            oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                            oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                            oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                            oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                            oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                            oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                            oList_Entity.Add(oEntity);
                        }
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_DISTRICT_ID_List_Adv
        public List<Entity> Get_Entity_By_DISTRICT_ID_List_Adv(IEnumerable<long?> DISTRICT_ID_LIST)
        {
            List<Entity> oList_Entity = null;
            if (DISTRICT_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_ID_LIST = string.Join(",", DISTRICT_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_DISTRICT_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Entity = new List<Entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity oEntity = new Entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                            oEntity.Area = new Area();
                            oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oEntity.District = new District();
                            oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oEntity.Region = new Region();
                            oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oEntity.Site = new Site();
                            oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                            oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                            oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                            oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                            oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                            oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                            oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                            oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                            oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                            oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                            oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                            oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                            oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                            oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                            oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                            oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                            oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                            oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                            oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                            oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                            oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                            oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                            oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                            oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                            oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                            oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                            oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                            oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                            oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                            oEntity.Top_level = new Top_level();
                            oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oEntity.Entity_type_setup = new Setup();
                            oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                            oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                            oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                            oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                            oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                            oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                            oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                            oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                            oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                            oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                            oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                            oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                            oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                            oList_Entity.Add(oEntity);
                        }
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_REGION_ID_List_Adv
        public List<Entity> Get_Entity_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST)
        {
            List<Entity> oList_Entity = null;
            if (REGION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REGION_ID_LIST = string.Join(",", REGION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_REGION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Entity = new List<Entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity oEntity = new Entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                            oEntity.Area = new Area();
                            oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oEntity.District = new District();
                            oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oEntity.Region = new Region();
                            oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oEntity.Site = new Site();
                            oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                            oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                            oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                            oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                            oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                            oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                            oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                            oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                            oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                            oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                            oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                            oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                            oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                            oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                            oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                            oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                            oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                            oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                            oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                            oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                            oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                            oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                            oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                            oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                            oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                            oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                            oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                            oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                            oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                            oEntity.Top_level = new Top_level();
                            oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oEntity.Entity_type_setup = new Setup();
                            oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                            oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                            oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                            oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                            oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                            oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                            oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                            oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                            oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                            oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                            oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                            oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                            oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                            oList_Entity.Add(oEntity);
                        }
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_TOP_LEVEL_ID_List_Adv
        public List<Entity> Get_Entity_By_TOP_LEVEL_ID_List_Adv(IEnumerable<long?> TOP_LEVEL_ID_LIST)
        {
            List<Entity> oList_Entity = null;
            if (TOP_LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.TOP_LEVEL_ID_LIST = string.Join(",", TOP_LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_TOP_LEVEL_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Entity = new List<Entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity oEntity = new Entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                            oEntity.Area = new Area();
                            oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oEntity.District = new District();
                            oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oEntity.Region = new Region();
                            oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oEntity.Site = new Site();
                            oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                            oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                            oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                            oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                            oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                            oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                            oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                            oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                            oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                            oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                            oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                            oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                            oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                            oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                            oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                            oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                            oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                            oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                            oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                            oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                            oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                            oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                            oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                            oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                            oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                            oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                            oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                            oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                            oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                            oEntity.Top_level = new Top_level();
                            oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oEntity.Entity_type_setup = new Setup();
                            oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                            oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                            oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                            oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                            oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                            oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                            oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                            oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                            oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                            oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                            oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                            oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                            oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                            oList_Entity.Add(oEntity);
                        }
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_Adv
        public List<Entity> Get_Entity_By_ENTITY_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> ENTITY_TYPE_SETUP_ID_LIST)
        {
            List<Entity> oList_Entity = null;
            if (ENTITY_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.ENTITY_TYPE_SETUP_ID_LIST = string.Join(",", ENTITY_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_ENTITY_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Entity = new List<Entity>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Entity oEntity = new Entity();
                            Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                            oEntity.Area = new Area();
                            oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oEntity.District = new District();
                            oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oEntity.Region = new Region();
                            oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oEntity.Site = new Site();
                            oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                            oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                            oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                            oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                            oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                            oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                            oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                            oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                            oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                            oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                            oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                            oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                            oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                            oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                            oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                            oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                            oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                            oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                            oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                            oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                            oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                            oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                            oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                            oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                            oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                            oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                            oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                            oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                            oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                            oEntity.Top_level = new Top_level();
                            oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oEntity.Entity_type_setup = new Setup();
                            oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                            oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                            oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                            oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                            oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                            oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                            oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                            oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                            oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                            oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                            oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                            oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                            oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                            oList_Entity.Add(oEntity);
                        }
                    }
                }
            }
            return oList_Entity;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Setup> oList_Setup = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_SETUP_CATEGORY_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Setup = new List<Setup>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Setup oSetup = new Setup();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                            oSetup.Setup_category = new Setup_category();
                            oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                            oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                            oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                            oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                            oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                            oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                            oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                            oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                            oList_Setup.Add(oSetup);
                        }
                    }
                }
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Entity_view_By_Where_Adv
        public List<Entity_view> Get_Entity_view_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Entity_view> oList_Entity_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        oEntity_view.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oEntity_view.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oEntity_view.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oEntity_view.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oEntity_view.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oEntity_view.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oEntity_view.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oEntity_view.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oEntity_view.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oEntity_view.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oEntity_view.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oEntity_view.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oEntity_view.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oEntity_view.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oEntity_view.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oEntity_view.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oEntity_view.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oEntity_view.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oEntity_view.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oEntity_view.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oEntity_view.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oEntity_view.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oEntity_view.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oEntity_view.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oEntity_view.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oEntity_view.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oEntity_view.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oEntity_view.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oEntity_view.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oEntity_view.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oEntity_view.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oEntity_view.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oEntity_view.View_type_setup = new Setup();
                        oEntity_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oEntity_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oEntity_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oEntity_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oEntity_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oEntity_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oEntity_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oEntity_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oEntity_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oEntity_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_Where_Adv
        public List<Entity> Get_Entity_By_Where_Adv(string NAME, string GLA_UNIT, string UNIT, string IMAGE_URL, string SOLID_GLTF_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oEntity.Area = new Area();
                        oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oEntity.District = new District();
                        oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oEntity.Region = new Region();
                        oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oEntity.Site = new Site();
                        oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oEntity.Top_level = new Top_level();
                        oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oEntity.Entity_type_setup = new Setup();
                        oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                        oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                        oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                        oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                        oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                        oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                        oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                        oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                        oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                        oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Entity;
        }
        #endregion
        #region Get_Setup_By_Where_Adv
        public List<Setup> Get_Setup_By_Where_Adv(string VALUE, string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Setup> oList_Setup = null;
            dynamic _params = new ExpandoObject();
            _params.VALUE = VALUE;
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
        #region Get_Entity_view_By_Where_In_List_Adv
        public List<Entity_view> Get_Entity_view_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> ENTITY_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_VIEW_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity_view = new List<Entity_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity_view oEntity_view = new Entity_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity_view);
                        oEntity_view.Entity = new Entity();
                        oEntity_view.Entity.ENTITY_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_ID");
                        oEntity_view.Entity.SITE_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_SITE_ID");
                        oEntity_view.Entity.AREA_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_AREA_ID");
                        oEntity_view.Entity.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_DISTRICT_ID");
                        oEntity_view.Entity.REGION_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_REGION_ID");
                        oEntity_view.Entity.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TOP_LEVEL_ID");
                        oEntity_view.Entity.ENTITY_TYPE_SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTITY_TYPE_SETUP_ID");
                        oEntity_view.Entity.NAME = Get_Data_Record_Value<string>(element, "T_ENTITY_NAME");
                        oEntity_view.Entity.NUMBER_OF_FLOORS = Get_Data_Record_Value<int?>(element, "T_ENTITY_NUMBER_OF_FLOORS");
                        oEntity_view.Entity.GLA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLA");
                        oEntity_view.Entity.GLA_UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_GLA_UNIT");
                        oEntity_view.Entity.AREA = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_AREA");
                        oEntity_view.Entity.UNIT = Get_Data_Record_Value<string>(element, "T_ENTITY_UNIT");
                        oEntity_view.Entity.SCALE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_SCALE");
                        oEntity_view.Entity.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONX");
                        oEntity_view.Entity.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONY");
                        oEntity_view.Entity.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_ROTATIONZ");
                        oEntity_view.Entity.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LATITUDE");
                        oEntity_view.Entity.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_GLTF_LONGITUDE");
                        oEntity_view.Entity.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LATITUDE");
                        oEntity_view.Entity.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_CENTER_LONGITUDE");
                        oEntity_view.Entity.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_RADIUS_IN_METERS");
                        oEntity_view.Entity.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_IMAGE_URL");
                        oEntity_view.Entity.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_ENTITY_SOLID_GLTF_URL");
                        oEntity_view.Entity.POPUL_ALT_X = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUL_ALT_X");
                        oEntity_view.Entity.POPUP_ALT_Y = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Y");
                        oEntity_view.Entity.POPUP_ALT_Z = Get_Data_Record_Value<decimal?>(element, "T_ENTITY_POPUP_ALT_Z");
                        oEntity_view.Entity.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_ENTRY_USER_ID");
                        oEntity_view.Entity.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_ENTRY_DATE");
                        oEntity_view.Entity.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_LAST_UPDATE");
                        oEntity_view.Entity.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_IS_DELETED");
                        oEntity_view.Entity.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_OWNER_ID");
                        oEntity_view.View_type_setup = new Setup();
                        oEntity_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oEntity_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oEntity_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oEntity_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oEntity_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oEntity_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oEntity_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oEntity_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oEntity_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oEntity_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Entity_view.Add(oEntity_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Entity_view;
        }
        #endregion
        #region Get_Entity_By_Where_In_List_Adv
        public List<Entity> Get_Entity_By_Where_In_List_Adv(string NAME, string GLA_UNIT, string UNIT, string IMAGE_URL, string SOLID_GLTF_URL, IEnumerable<long?> SITE_ID_LIST, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, IEnumerable<long?> ENTITY_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_ENTITY_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Entity = new List<Entity>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Entity oEntity = new Entity();
                        Props.Copy_Prop_Values_From_Data_Record(element, oEntity);
                        oEntity.Area = new Area();
                        oEntity.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oEntity.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oEntity.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oEntity.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oEntity.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oEntity.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oEntity.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oEntity.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oEntity.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oEntity.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oEntity.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oEntity.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oEntity.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oEntity.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oEntity.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oEntity.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oEntity.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oEntity.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oEntity.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oEntity.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oEntity.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oEntity.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oEntity.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oEntity.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oEntity.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oEntity.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oEntity.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oEntity.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oEntity.District = new District();
                        oEntity.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oEntity.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oEntity.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oEntity.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oEntity.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oEntity.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oEntity.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oEntity.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oEntity.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oEntity.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oEntity.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oEntity.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oEntity.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oEntity.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oEntity.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oEntity.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oEntity.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oEntity.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oEntity.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oEntity.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oEntity.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oEntity.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oEntity.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oEntity.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oEntity.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oEntity.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oEntity.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oEntity.Region = new Region();
                        oEntity.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oEntity.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oEntity.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oEntity.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oEntity.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oEntity.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oEntity.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oEntity.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oEntity.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oEntity.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oEntity.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oEntity.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oEntity.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oEntity.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oEntity.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oEntity.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oEntity.Site = new Site();
                        oEntity.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oEntity.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oEntity.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oEntity.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oEntity.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oEntity.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oEntity.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oEntity.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oEntity.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oEntity.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oEntity.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oEntity.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oEntity.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oEntity.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oEntity.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oEntity.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oEntity.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oEntity.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oEntity.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oEntity.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oEntity.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oEntity.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oEntity.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oEntity.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oEntity.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oEntity.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oEntity.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oEntity.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oEntity.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oEntity.Top_level = new Top_level();
                        oEntity.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oEntity.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oEntity.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oEntity.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oEntity.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oEntity.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oEntity.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oEntity.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oEntity.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oEntity.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oEntity.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oEntity.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oEntity.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oEntity.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oEntity.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oEntity.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oEntity.Entity_type_setup = new Setup();
                        oEntity.Entity_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_SETUP_ID");
                        oEntity.Entity_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oEntity.Entity_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_SYSTEM");
                        oEntity.Entity_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETEABLE");
                        oEntity.Entity_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_UPDATEABLE");
                        oEntity.Entity_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_DELETED");
                        oEntity.Entity_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_ENTITY_TYPE_SETUP_IS_VISIBLE");
                        oEntity.Entity_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_DISPLAY_ORDER");
                        oEntity.Entity_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_VALUE");
                        oEntity.Entity_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_DESCRIPTION");
                        oEntity.Entity_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_ENTITY_TYPE_SETUP_ENTRY_USER_ID");
                        oEntity.Entity_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_ENTRY_DATE");
                        oEntity.Entity_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_ENTITY_TYPE_SETUP_LAST_UPDATE");
                        oEntity.Entity_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_ENTITY_TYPE_SETUP_OWNER_ID");
                        oList_Entity.Add(oEntity);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Entity;
        }
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        public List<Setup> Get_Setup_By_Where_In_List_Adv(string VALUE, string DESCRIPTION, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SETUP_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Setup = new List<Setup>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        oSetup.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oSetup.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oSetup.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oSetup.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oSetup.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oSetup.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oSetup.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oSetup.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Setup;
        }
        #endregion
    }
}
