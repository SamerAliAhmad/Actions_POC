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
        #region Get_Site_view_By_SITE_VIEW_ID_Adv
        public Site_view Get_Site_view_By_SITE_VIEW_ID_Adv(long? SITE_VIEW_ID)
        {
            Site_view oSite_view = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_VIEW_ID = SITE_VIEW_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_SITE_VIEW_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSite_view = new Site_view();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSite_view);
                oSite_view.Site = new Site();
                oSite_view.Site.SITE_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_SITE_ID");
                oSite_view.Site.AREA_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_AREA_ID");
                oSite_view.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_DISTRICT_ID");
                oSite_view.Site.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_REGION_ID");
                oSite_view.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_TOP_LEVEL_ID");
                oSite_view.Site.NAME = Get_Data_Record_Value<string>(_query_response, "T_SITE_NAME");
                oSite_view.Site.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_SITE_LOCATION");
                oSite_view.Site.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_AREA");
                oSite_view.Site.UNIT = Get_Data_Record_Value<string>(_query_response, "T_SITE_UNIT");
                oSite_view.Site.SCALE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_SCALE");
                oSite_view.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_ROTATIONX");
                oSite_view.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_ROTATIONY");
                oSite_view.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_ROTATIONZ");
                oSite_view.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_GLTF_LATITUDE");
                oSite_view.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_GLTF_LONGITUDE");
                oSite_view.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_CENTER_LATITUDE");
                oSite_view.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_CENTER_LONGITUDE");
                oSite_view.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_RADIUS_IN_METERS");
                oSite_view.Site.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_SITE_IMAGE_URL");
                oSite_view.Site.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_SITE_LOGO_URL");
                oSite_view.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_SITE_SOLID_GLTF_URL");
                oSite_view.Site.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_SITE_AREA_COLOR");
                oSite_view.Site.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_SITE_BORDER_COLOR");
                oSite_view.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_SITE_STUDY_ZONE_NAME");
                oSite_view.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_ENTRY_USER_ID");
                oSite_view.Site.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_SITE_ENTRY_DATE");
                oSite_view.Site.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_SITE_LAST_UPDATE");
                oSite_view.Site.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_SITE_IS_DELETED");
                oSite_view.Site.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_SITE_OWNER_ID");
                oSite_view.View_type_setup = new Setup();
                oSite_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIEW_TYPE_SETUP_SETUP_ID");
                oSite_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                oSite_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                oSite_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                oSite_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                oSite_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_DELETED");
                oSite_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                oSite_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                oSite_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_VALUE");
                oSite_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                oSite_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                oSite_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                oSite_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                oSite_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_OWNER_ID");
            }
            return oSite_view;
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
        #region Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_Adv
        public Site_field_logo Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_Adv(long? SITE_FIELD_LOGO_ID)
        {
            Site_field_logo oSite_field_logo = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_FIELD_LOGO_ID = SITE_FIELD_LOGO_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_SITE_FIELD_LOGO_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSite_field_logo = new Site_field_logo();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSite_field_logo);
                oSite_field_logo.Site = new Site();
                oSite_field_logo.Site.SITE_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_SITE_ID");
                oSite_field_logo.Site.AREA_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_AREA_ID");
                oSite_field_logo.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_DISTRICT_ID");
                oSite_field_logo.Site.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_REGION_ID");
                oSite_field_logo.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_TOP_LEVEL_ID");
                oSite_field_logo.Site.NAME = Get_Data_Record_Value<string>(_query_response, "T_SITE_NAME");
                oSite_field_logo.Site.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_SITE_LOCATION");
                oSite_field_logo.Site.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_AREA");
                oSite_field_logo.Site.UNIT = Get_Data_Record_Value<string>(_query_response, "T_SITE_UNIT");
                oSite_field_logo.Site.SCALE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_SCALE");
                oSite_field_logo.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_ROTATIONX");
                oSite_field_logo.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_ROTATIONY");
                oSite_field_logo.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_ROTATIONZ");
                oSite_field_logo.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_GLTF_LATITUDE");
                oSite_field_logo.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_GLTF_LONGITUDE");
                oSite_field_logo.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_CENTER_LATITUDE");
                oSite_field_logo.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_CENTER_LONGITUDE");
                oSite_field_logo.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(_query_response, "T_SITE_RADIUS_IN_METERS");
                oSite_field_logo.Site.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_SITE_IMAGE_URL");
                oSite_field_logo.Site.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_SITE_LOGO_URL");
                oSite_field_logo.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_SITE_SOLID_GLTF_URL");
                oSite_field_logo.Site.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_SITE_AREA_COLOR");
                oSite_field_logo.Site.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_SITE_BORDER_COLOR");
                oSite_field_logo.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_SITE_STUDY_ZONE_NAME");
                oSite_field_logo.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_SITE_ENTRY_USER_ID");
                oSite_field_logo.Site.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_SITE_ENTRY_DATE");
                oSite_field_logo.Site.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_SITE_LAST_UPDATE");
                oSite_field_logo.Site.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_SITE_IS_DELETED");
                oSite_field_logo.Site.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_SITE_OWNER_ID");
            }
            return oSite_field_logo;
        }
        #endregion
        #region Get_Site_By_SITE_ID_Adv
        public Site Get_Site_By_SITE_ID_Adv(long? SITE_ID)
        {
            Site oSite = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_ID = SITE_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SITE_BY_SITE_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSite = new Site();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSite);
                oSite.Area = new Area();
                oSite.Area.AREA_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_AREA_ID");
                oSite.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_DISTRICT_ID");
                oSite.Area.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_REGION_ID");
                oSite.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_TOP_LEVEL_ID");
                oSite.Area.NAME = Get_Data_Record_Value<string>(_query_response, "T_AREA_NAME");
                oSite.Area.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_AREA_LOCATION");
                oSite.Area.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_AREA");
                oSite.Area.UNIT = Get_Data_Record_Value<string>(_query_response, "T_AREA_UNIT");
                oSite.Area.SCALE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_SCALE");
                oSite.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_ROTATIONX");
                oSite.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_ROTATIONY");
                oSite.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_ROTATIONZ");
                oSite.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_GLTF_LATITUDE");
                oSite.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_GLTF_LONGITUDE");
                oSite.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_CENTER_LATITUDE");
                oSite.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_CENTER_LONGITUDE");
                oSite.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_RADIUS_IN_METERS");
                oSite.Area.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_AREA_IMAGE_URL");
                oSite.Area.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_AREA_LOGO_URL");
                oSite.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_AREA_SOLID_GLTF_URL");
                oSite.Area.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_AREA_AREA_COLOR");
                oSite.Area.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_AREA_BORDER_COLOR");
                oSite.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_AREA_STUDY_ZONE_NAME");
                oSite.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_ENTRY_USER_ID");
                oSite.Area.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_AREA_ENTRY_DATE");
                oSite.Area.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_AREA_LAST_UPDATE");
                oSite.Area.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_AREA_IS_DELETED");
                oSite.Area.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_AREA_OWNER_ID");
                oSite.District = new District();
                oSite.District.DISTRICT_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_DISTRICT_ID");
                oSite.District.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_REGION_ID");
                oSite.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_TOP_LEVEL_ID");
                oSite.District.NAME = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_NAME");
                oSite.District.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_LOCATION");
                oSite.District.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_AREA");
                oSite.District.UNIT = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_UNIT");
                oSite.District.SCALE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_SCALE");
                oSite.District.ROTATIONX = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_ROTATIONX");
                oSite.District.ROTATIONY = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_ROTATIONY");
                oSite.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_ROTATIONZ");
                oSite.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_GLTF_LATITUDE");
                oSite.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_GLTF_LONGITUDE");
                oSite.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_CENTER_LATITUDE");
                oSite.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_CENTER_LONGITUDE");
                oSite.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_RADIUS_IN_METERS");
                oSite.District.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_IMAGE_URL");
                oSite.District.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_LOGO_URL");
                oSite.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_SOLID_GLTF_URL");
                oSite.District.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_AREA_COLOR");
                oSite.District.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_BORDER_COLOR");
                oSite.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_STUDY_ZONE_NAME");
                oSite.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_ENTRY_USER_ID");
                oSite.District.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_ENTRY_DATE");
                oSite.District.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_LAST_UPDATE");
                oSite.District.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_DISTRICT_IS_DELETED");
                oSite.District.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_DISTRICT_OWNER_ID");
                oSite.Region = new Region();
                oSite.Region.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_REGION_ID");
                oSite.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_TOP_LEVEL_ID");
                oSite.Region.NAME = Get_Data_Record_Value<string>(_query_response, "T_REGION_NAME");
                oSite.Region.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_REGION_LOCATION");
                oSite.Region.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_REGION_AREA");
                oSite.Region.UNIT = Get_Data_Record_Value<string>(_query_response, "T_REGION_UNIT");
                oSite.Region.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_REGION_IMAGE_URL");
                oSite.Region.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_REGION_LOGO_URL");
                oSite.Region.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_REGION_AREA_COLOR");
                oSite.Region.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_REGION_BORDER_COLOR");
                oSite.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_REGION_STUDY_ZONE_NAME");
                oSite.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_ENTRY_USER_ID");
                oSite.Region.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_REGION_ENTRY_DATE");
                oSite.Region.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_REGION_LAST_UPDATE");
                oSite.Region.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_REGION_IS_DELETED");
                oSite.Region.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_REGION_OWNER_ID");
                oSite.Top_level = new Top_level();
                oSite.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_TOP_LEVEL_TOP_LEVEL_ID");
                oSite.Top_level.NAME = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_NAME");
                oSite.Top_level.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LOCATION");
                oSite.Top_level.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_TOP_LEVEL_AREA");
                oSite.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_IMAGE_URL");
                oSite.Top_level.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LOGO_URL");
                oSite.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_AREA_COLOR");
                oSite.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_BORDER_COLOR");
                oSite.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                oSite.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_LOW_THRESHOLD");
                oSite.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_HIGH_THRESHOLD");
                oSite.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_TOP_LEVEL_ENTRY_USER_ID");
                oSite.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_ENTRY_DATE");
                oSite.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LAST_UPDATE");
                oSite.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_TOP_LEVEL_IS_DELETED");
                oSite.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_OWNER_ID");
            }
            return oSite;
        }
        #endregion
        #region Get_Site_view_By_SITE_VIEW_ID_List_Adv
        public List<Site_view> Get_Site_view_By_SITE_VIEW_ID_List_Adv(IEnumerable<long?> SITE_VIEW_ID_LIST)
        {
            List<Site_view> oList_Site_view = null;
            if (SITE_VIEW_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_VIEW_ID_LIST = string.Join(",", SITE_VIEW_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_SITE_VIEW_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Site_view = new List<Site_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_view oSite_view = new Site_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                            oSite_view.Site = new Site();
                            oSite_view.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                            oSite_view.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                            oSite_view.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                            oSite_view.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                            oSite_view.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                            oSite_view.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                            oSite_view.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                            oSite_view.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                            oSite_view.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                            oSite_view.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                            oSite_view.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                            oSite_view.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                            oSite_view.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                            oSite_view.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                            oSite_view.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                            oSite_view.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                            oSite_view.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                            oSite_view.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                            oSite_view.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                            oSite_view.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                            oSite_view.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                            oSite_view.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                            oSite_view.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                            oSite_view.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                            oSite_view.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                            oSite_view.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                            oSite_view.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                            oSite_view.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                            oSite_view.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                            oSite_view.View_type_setup = new Setup();
                            oSite_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oSite_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oSite_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oSite_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oSite_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oSite_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oSite_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oSite_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oSite_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oSite_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oSite_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oSite_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oSite_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oSite_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_Site_view.Add(oSite_view);
                        }
                    }
                }
            }
            return oList_Site_view;
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
        #region Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List_Adv
        public List<Site_field_logo> Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List_Adv(IEnumerable<long?> SITE_FIELD_LOGO_ID_LIST)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            if (SITE_FIELD_LOGO_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_FIELD_LOGO_ID_LIST = string.Join(",", SITE_FIELD_LOGO_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_SITE_FIELD_LOGO_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Site_field_logo = new List<Site_field_logo>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_field_logo oSite_field_logo = new Site_field_logo();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_field_logo);
                            oSite_field_logo.Site = new Site();
                            oSite_field_logo.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                            oSite_field_logo.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                            oSite_field_logo.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                            oSite_field_logo.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                            oSite_field_logo.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                            oSite_field_logo.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                            oSite_field_logo.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                            oSite_field_logo.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                            oSite_field_logo.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                            oSite_field_logo.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                            oSite_field_logo.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                            oSite_field_logo.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                            oSite_field_logo.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                            oSite_field_logo.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                            oSite_field_logo.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                            oSite_field_logo.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                            oSite_field_logo.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                            oSite_field_logo.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                            oSite_field_logo.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                            oSite_field_logo.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                            oSite_field_logo.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                            oSite_field_logo.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                            oSite_field_logo.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                            oSite_field_logo.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                            oSite_field_logo.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                            oSite_field_logo.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                            oSite_field_logo.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                            oSite_field_logo.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                            oSite_field_logo.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                            oList_Site_field_logo.Add(oSite_field_logo);
                        }
                    }
                }
            }
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_By_SITE_ID_List_Adv
        public List<Site> Get_Site_By_SITE_ID_List_Adv(IEnumerable<long?> SITE_ID_LIST)
        {
            List<Site> oList_Site = null;
            if (SITE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_ID_LIST = string.Join(",", SITE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_SITE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Site = new List<Site>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site oSite = new Site();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                            oSite.Area = new Area();
                            oSite.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oSite.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oSite.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oSite.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oSite.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oSite.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oSite.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oSite.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oSite.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oSite.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oSite.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oSite.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oSite.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oSite.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oSite.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oSite.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oSite.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oSite.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oSite.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oSite.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oSite.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oSite.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oSite.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oSite.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oSite.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oSite.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oSite.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oSite.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oSite.District = new District();
                            oSite.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oSite.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oSite.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oSite.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oSite.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oSite.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oSite.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oSite.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oSite.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oSite.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oSite.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oSite.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oSite.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oSite.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oSite.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oSite.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oSite.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oSite.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oSite.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oSite.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oSite.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oSite.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oSite.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oSite.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oSite.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oSite.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oSite.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oSite.Region = new Region();
                            oSite.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oSite.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oSite.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oSite.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oSite.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oSite.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oSite.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oSite.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oSite.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oSite.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oSite.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oSite.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oSite.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oSite.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oSite.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oSite.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oSite.Top_level = new Top_level();
                            oSite.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oSite.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oSite.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oSite.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oSite.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oSite.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oSite.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oSite.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oSite.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oSite.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oSite.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oSite.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oSite.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oSite.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oSite.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oSite.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oList_Site.Add(oSite);
                        }
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_view_By_OWNER_ID_IS_DELETED_Adv
        public List<Site_view> Get_Site_view_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Site_view> oList_Site_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Site_view = new List<Site_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                        oSite_view.Site = new Site();
                        oSite_view.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oSite_view.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oSite_view.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oSite_view.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oSite_view.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oSite_view.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oSite_view.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oSite_view.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oSite_view.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oSite_view.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oSite_view.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oSite_view.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oSite_view.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oSite_view.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oSite_view.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oSite_view.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oSite_view.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oSite_view.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oSite_view.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oSite_view.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oSite_view.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oSite_view.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oSite_view.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oSite_view.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oSite_view.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oSite_view.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oSite_view.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oSite_view.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oSite_view.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oSite_view.View_type_setup = new Setup();
                        oSite_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oSite_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oSite_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oSite_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oSite_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oSite_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oSite_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oSite_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oSite_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oSite_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oSite_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oSite_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oSite_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oSite_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_VIEW_TYPE_SETUP_ID_Adv
        public List<Site_view> Get_Site_view_By_VIEW_TYPE_SETUP_ID_Adv(long? VIEW_TYPE_SETUP_ID)
        {
            List<Site_view> oList_Site_view = null;
            dynamic _params = new ExpandoObject();
            _params.VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_VIEW_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Site_view = new List<Site_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                        oSite_view.Site = new Site();
                        oSite_view.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oSite_view.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oSite_view.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oSite_view.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oSite_view.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oSite_view.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oSite_view.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oSite_view.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oSite_view.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oSite_view.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oSite_view.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oSite_view.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oSite_view.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oSite_view.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oSite_view.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oSite_view.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oSite_view.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oSite_view.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oSite_view.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oSite_view.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oSite_view.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oSite_view.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oSite_view.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oSite_view.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oSite_view.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oSite_view.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oSite_view.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oSite_view.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oSite_view.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oSite_view.View_type_setup = new Setup();
                        oSite_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oSite_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oSite_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oSite_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oSite_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oSite_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oSite_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oSite_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oSite_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oSite_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oSite_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oSite_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oSite_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oSite_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_OWNER_ID_Adv
        public List<Site_view> Get_Site_view_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Site_view> oList_Site_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Site_view = new List<Site_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                        oSite_view.Site = new Site();
                        oSite_view.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oSite_view.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oSite_view.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oSite_view.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oSite_view.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oSite_view.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oSite_view.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oSite_view.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oSite_view.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oSite_view.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oSite_view.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oSite_view.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oSite_view.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oSite_view.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oSite_view.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oSite_view.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oSite_view.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oSite_view.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oSite_view.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oSite_view.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oSite_view.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oSite_view.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oSite_view.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oSite_view.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oSite_view.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oSite_view.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oSite_view.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oSite_view.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oSite_view.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oSite_view.View_type_setup = new Setup();
                        oSite_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oSite_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oSite_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oSite_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oSite_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oSite_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oSite_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oSite_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oSite_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oSite_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oSite_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oSite_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oSite_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oSite_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_SITE_ID_Adv
        public List<Site_view> Get_Site_view_By_SITE_ID_Adv(long? SITE_ID)
        {
            List<Site_view> oList_Site_view = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_ID = SITE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_SITE_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Site_view = new List<Site_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                        oSite_view.Site = new Site();
                        oSite_view.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oSite_view.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oSite_view.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oSite_view.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oSite_view.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oSite_view.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oSite_view.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oSite_view.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oSite_view.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oSite_view.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oSite_view.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oSite_view.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oSite_view.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oSite_view.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oSite_view.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oSite_view.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oSite_view.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oSite_view.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oSite_view.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oSite_view.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oSite_view.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oSite_view.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oSite_view.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oSite_view.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oSite_view.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oSite_view.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oSite_view.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oSite_view.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oSite_view.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oSite_view.View_type_setup = new Setup();
                        oSite_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oSite_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oSite_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oSite_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oSite_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oSite_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oSite_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oSite_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oSite_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oSite_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oSite_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oSite_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oSite_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oSite_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            return oList_Site_view;
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
        #region Get_Site_field_logo_By_OWNER_ID_IS_DELETED_Adv
        public List<Site_field_logo> Get_Site_field_logo_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_field_logo);
                        oSite_field_logo.Site = new Site();
                        oSite_field_logo.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oSite_field_logo.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oSite_field_logo.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oSite_field_logo.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oSite_field_logo.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oSite_field_logo.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oSite_field_logo.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oSite_field_logo.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oSite_field_logo.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oSite_field_logo.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oSite_field_logo.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oSite_field_logo.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oSite_field_logo.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oSite_field_logo.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oSite_field_logo.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oSite_field_logo.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oSite_field_logo.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oSite_field_logo.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oSite_field_logo.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oSite_field_logo.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oSite_field_logo.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oSite_field_logo.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oSite_field_logo.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oSite_field_logo.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oSite_field_logo.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oSite_field_logo.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oSite_field_logo.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oSite_field_logo.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oSite_field_logo.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_field_logo_By_OWNER_ID_Adv
        public List<Site_field_logo> Get_Site_field_logo_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_field_logo);
                        oSite_field_logo.Site = new Site();
                        oSite_field_logo.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oSite_field_logo.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oSite_field_logo.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oSite_field_logo.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oSite_field_logo.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oSite_field_logo.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oSite_field_logo.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oSite_field_logo.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oSite_field_logo.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oSite_field_logo.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oSite_field_logo.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oSite_field_logo.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oSite_field_logo.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oSite_field_logo.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oSite_field_logo.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oSite_field_logo.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oSite_field_logo.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oSite_field_logo.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oSite_field_logo.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oSite_field_logo.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oSite_field_logo.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oSite_field_logo.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oSite_field_logo.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oSite_field_logo.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oSite_field_logo.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oSite_field_logo.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oSite_field_logo.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oSite_field_logo.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oSite_field_logo.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_field_logo_By_SITE_ID_Adv
        public List<Site_field_logo> Get_Site_field_logo_By_SITE_ID_Adv(long? SITE_ID)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_ID = SITE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_SITE_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_field_logo);
                        oSite_field_logo.Site = new Site();
                        oSite_field_logo.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oSite_field_logo.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oSite_field_logo.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oSite_field_logo.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oSite_field_logo.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oSite_field_logo.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oSite_field_logo.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oSite_field_logo.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oSite_field_logo.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oSite_field_logo.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oSite_field_logo.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oSite_field_logo.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oSite_field_logo.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oSite_field_logo.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oSite_field_logo.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oSite_field_logo.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oSite_field_logo.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oSite_field_logo.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oSite_field_logo.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oSite_field_logo.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oSite_field_logo.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oSite_field_logo.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oSite_field_logo.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oSite_field_logo.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oSite_field_logo.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oSite_field_logo.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oSite_field_logo.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oSite_field_logo.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oSite_field_logo.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_By_OWNER_ID_IS_DELETED_Adv
        public List<Site> Get_Site_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Site> oList_Site = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oSite.Area = new Area();
                        oSite.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oSite.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oSite.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oSite.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oSite.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oSite.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oSite.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oSite.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oSite.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oSite.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oSite.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oSite.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oSite.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oSite.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oSite.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oSite.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oSite.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oSite.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oSite.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oSite.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oSite.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oSite.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oSite.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oSite.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oSite.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oSite.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oSite.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oSite.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oSite.District = new District();
                        oSite.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oSite.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oSite.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oSite.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oSite.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oSite.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oSite.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oSite.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oSite.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oSite.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oSite.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oSite.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oSite.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oSite.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oSite.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oSite.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oSite.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oSite.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oSite.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oSite.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oSite.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oSite.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oSite.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oSite.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oSite.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oSite.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oSite.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oSite.Region = new Region();
                        oSite.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oSite.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oSite.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oSite.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oSite.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oSite.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oSite.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oSite.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oSite.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oSite.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oSite.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oSite.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oSite.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oSite.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oSite.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oSite.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oSite.Top_level = new Top_level();
                        oSite.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oSite.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oSite.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oSite.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oSite.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oSite.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oSite.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oSite.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oSite.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oSite.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oSite.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oSite.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oSite.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oSite.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oSite.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oSite.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Site.Add(oSite);
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_OWNER_ID_Adv
        public List<Site> Get_Site_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Site> oList_Site = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oSite.Area = new Area();
                        oSite.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oSite.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oSite.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oSite.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oSite.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oSite.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oSite.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oSite.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oSite.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oSite.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oSite.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oSite.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oSite.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oSite.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oSite.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oSite.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oSite.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oSite.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oSite.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oSite.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oSite.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oSite.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oSite.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oSite.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oSite.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oSite.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oSite.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oSite.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oSite.District = new District();
                        oSite.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oSite.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oSite.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oSite.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oSite.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oSite.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oSite.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oSite.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oSite.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oSite.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oSite.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oSite.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oSite.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oSite.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oSite.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oSite.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oSite.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oSite.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oSite.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oSite.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oSite.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oSite.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oSite.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oSite.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oSite.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oSite.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oSite.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oSite.Region = new Region();
                        oSite.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oSite.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oSite.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oSite.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oSite.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oSite.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oSite.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oSite.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oSite.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oSite.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oSite.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oSite.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oSite.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oSite.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oSite.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oSite.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oSite.Top_level = new Top_level();
                        oSite.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oSite.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oSite.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oSite.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oSite.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oSite.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oSite.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oSite.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oSite.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oSite.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oSite.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oSite.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oSite.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oSite.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oSite.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oSite.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Site.Add(oSite);
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_AREA_ID_Adv
        public List<Site> Get_Site_By_AREA_ID_Adv(long? AREA_ID)
        {
            List<Site> oList_Site = null;
            dynamic _params = new ExpandoObject();
            _params.AREA_ID = AREA_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_AREA_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oSite.Area = new Area();
                        oSite.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oSite.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oSite.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oSite.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oSite.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oSite.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oSite.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oSite.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oSite.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oSite.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oSite.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oSite.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oSite.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oSite.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oSite.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oSite.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oSite.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oSite.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oSite.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oSite.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oSite.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oSite.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oSite.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oSite.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oSite.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oSite.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oSite.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oSite.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oSite.District = new District();
                        oSite.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oSite.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oSite.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oSite.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oSite.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oSite.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oSite.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oSite.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oSite.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oSite.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oSite.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oSite.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oSite.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oSite.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oSite.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oSite.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oSite.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oSite.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oSite.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oSite.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oSite.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oSite.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oSite.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oSite.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oSite.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oSite.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oSite.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oSite.Region = new Region();
                        oSite.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oSite.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oSite.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oSite.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oSite.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oSite.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oSite.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oSite.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oSite.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oSite.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oSite.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oSite.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oSite.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oSite.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oSite.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oSite.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oSite.Top_level = new Top_level();
                        oSite.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oSite.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oSite.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oSite.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oSite.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oSite.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oSite.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oSite.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oSite.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oSite.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oSite.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oSite.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oSite.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oSite.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oSite.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oSite.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Site.Add(oSite);
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_DISTRICT_ID_Adv
        public List<Site> Get_Site_By_DISTRICT_ID_Adv(long? DISTRICT_ID)
        {
            List<Site> oList_Site = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_ID = DISTRICT_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_DISTRICT_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oSite.Area = new Area();
                        oSite.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oSite.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oSite.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oSite.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oSite.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oSite.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oSite.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oSite.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oSite.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oSite.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oSite.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oSite.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oSite.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oSite.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oSite.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oSite.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oSite.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oSite.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oSite.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oSite.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oSite.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oSite.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oSite.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oSite.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oSite.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oSite.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oSite.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oSite.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oSite.District = new District();
                        oSite.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oSite.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oSite.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oSite.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oSite.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oSite.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oSite.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oSite.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oSite.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oSite.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oSite.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oSite.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oSite.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oSite.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oSite.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oSite.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oSite.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oSite.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oSite.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oSite.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oSite.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oSite.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oSite.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oSite.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oSite.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oSite.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oSite.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oSite.Region = new Region();
                        oSite.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oSite.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oSite.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oSite.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oSite.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oSite.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oSite.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oSite.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oSite.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oSite.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oSite.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oSite.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oSite.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oSite.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oSite.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oSite.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oSite.Top_level = new Top_level();
                        oSite.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oSite.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oSite.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oSite.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oSite.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oSite.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oSite.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oSite.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oSite.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oSite.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oSite.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oSite.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oSite.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oSite.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oSite.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oSite.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Site.Add(oSite);
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_REGION_ID_Adv
        public List<Site> Get_Site_By_REGION_ID_Adv(long? REGION_ID)
        {
            List<Site> oList_Site = null;
            dynamic _params = new ExpandoObject();
            _params.REGION_ID = REGION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_REGION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oSite.Area = new Area();
                        oSite.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oSite.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oSite.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oSite.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oSite.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oSite.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oSite.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oSite.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oSite.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oSite.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oSite.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oSite.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oSite.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oSite.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oSite.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oSite.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oSite.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oSite.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oSite.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oSite.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oSite.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oSite.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oSite.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oSite.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oSite.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oSite.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oSite.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oSite.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oSite.District = new District();
                        oSite.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oSite.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oSite.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oSite.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oSite.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oSite.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oSite.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oSite.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oSite.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oSite.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oSite.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oSite.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oSite.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oSite.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oSite.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oSite.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oSite.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oSite.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oSite.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oSite.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oSite.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oSite.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oSite.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oSite.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oSite.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oSite.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oSite.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oSite.Region = new Region();
                        oSite.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oSite.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oSite.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oSite.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oSite.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oSite.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oSite.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oSite.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oSite.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oSite.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oSite.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oSite.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oSite.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oSite.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oSite.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oSite.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oSite.Top_level = new Top_level();
                        oSite.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oSite.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oSite.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oSite.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oSite.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oSite.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oSite.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oSite.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oSite.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oSite.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oSite.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oSite.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oSite.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oSite.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oSite.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oSite.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Site.Add(oSite);
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_TOP_LEVEL_ID_Adv
        public List<Site> Get_Site_By_TOP_LEVEL_ID_Adv(long? TOP_LEVEL_ID)
        {
            List<Site> oList_Site = null;
            dynamic _params = new ExpandoObject();
            _params.TOP_LEVEL_ID = TOP_LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_TOP_LEVEL_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oSite.Area = new Area();
                        oSite.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oSite.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oSite.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oSite.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oSite.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oSite.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oSite.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oSite.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oSite.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oSite.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oSite.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oSite.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oSite.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oSite.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oSite.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oSite.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oSite.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oSite.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oSite.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oSite.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oSite.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oSite.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oSite.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oSite.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oSite.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oSite.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oSite.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oSite.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oSite.District = new District();
                        oSite.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oSite.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oSite.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oSite.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oSite.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oSite.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oSite.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oSite.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oSite.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oSite.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oSite.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oSite.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oSite.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oSite.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oSite.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oSite.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oSite.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oSite.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oSite.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oSite.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oSite.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oSite.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oSite.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oSite.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oSite.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oSite.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oSite.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oSite.Region = new Region();
                        oSite.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oSite.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oSite.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oSite.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oSite.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oSite.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oSite.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oSite.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oSite.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oSite.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oSite.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oSite.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oSite.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oSite.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oSite.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oSite.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oSite.Top_level = new Top_level();
                        oSite.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oSite.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oSite.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oSite.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oSite.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oSite.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oSite.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oSite.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oSite.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oSite.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oSite.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oSite.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oSite.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oSite.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oSite.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oSite.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Site.Add(oSite);
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        public List<Site_view> Get_Site_view_By_VIEW_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST)
        {
            List<Site_view> oList_Site_view = null;
            if (VIEW_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIEW_TYPE_SETUP_ID_LIST = string.Join(",", VIEW_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_VIEW_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Site_view = new List<Site_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_view oSite_view = new Site_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                            oSite_view.Site = new Site();
                            oSite_view.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                            oSite_view.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                            oSite_view.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                            oSite_view.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                            oSite_view.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                            oSite_view.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                            oSite_view.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                            oSite_view.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                            oSite_view.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                            oSite_view.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                            oSite_view.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                            oSite_view.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                            oSite_view.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                            oSite_view.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                            oSite_view.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                            oSite_view.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                            oSite_view.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                            oSite_view.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                            oSite_view.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                            oSite_view.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                            oSite_view.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                            oSite_view.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                            oSite_view.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                            oSite_view.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                            oSite_view.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                            oSite_view.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                            oSite_view.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                            oSite_view.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                            oSite_view.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                            oSite_view.View_type_setup = new Setup();
                            oSite_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oSite_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oSite_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oSite_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oSite_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oSite_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oSite_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oSite_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oSite_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oSite_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oSite_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oSite_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oSite_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oSite_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_Site_view.Add(oSite_view);
                        }
                    }
                }
            }
            return oList_Site_view;
        }
        #endregion
        #region Get_Site_view_By_SITE_ID_List_Adv
        public List<Site_view> Get_Site_view_By_SITE_ID_List_Adv(IEnumerable<long?> SITE_ID_LIST)
        {
            List<Site_view> oList_Site_view = null;
            if (SITE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_ID_LIST = string.Join(",", SITE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_SITE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Site_view = new List<Site_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_view oSite_view = new Site_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                            oSite_view.Site = new Site();
                            oSite_view.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                            oSite_view.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                            oSite_view.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                            oSite_view.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                            oSite_view.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                            oSite_view.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                            oSite_view.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                            oSite_view.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                            oSite_view.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                            oSite_view.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                            oSite_view.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                            oSite_view.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                            oSite_view.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                            oSite_view.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                            oSite_view.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                            oSite_view.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                            oSite_view.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                            oSite_view.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                            oSite_view.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                            oSite_view.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                            oSite_view.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                            oSite_view.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                            oSite_view.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                            oSite_view.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                            oSite_view.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                            oSite_view.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                            oSite_view.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                            oSite_view.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                            oSite_view.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                            oSite_view.View_type_setup = new Setup();
                            oSite_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oSite_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oSite_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oSite_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oSite_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oSite_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oSite_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oSite_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oSite_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oSite_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oSite_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oSite_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oSite_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oSite_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_Site_view.Add(oSite_view);
                        }
                    }
                }
            }
            return oList_Site_view;
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
        #region Get_Site_field_logo_By_SITE_ID_List_Adv
        public List<Site_field_logo> Get_Site_field_logo_By_SITE_ID_List_Adv(IEnumerable<long?> SITE_ID_LIST)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            if (SITE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_ID_LIST = string.Join(",", SITE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_SITE_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Site_field_logo = new List<Site_field_logo>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_field_logo oSite_field_logo = new Site_field_logo();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_field_logo);
                            oSite_field_logo.Site = new Site();
                            oSite_field_logo.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                            oSite_field_logo.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                            oSite_field_logo.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                            oSite_field_logo.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                            oSite_field_logo.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                            oSite_field_logo.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                            oSite_field_logo.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                            oSite_field_logo.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                            oSite_field_logo.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                            oSite_field_logo.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                            oSite_field_logo.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                            oSite_field_logo.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                            oSite_field_logo.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                            oSite_field_logo.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                            oSite_field_logo.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                            oSite_field_logo.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                            oSite_field_logo.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                            oSite_field_logo.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                            oSite_field_logo.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                            oSite_field_logo.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                            oSite_field_logo.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                            oSite_field_logo.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                            oSite_field_logo.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                            oSite_field_logo.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                            oSite_field_logo.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                            oSite_field_logo.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                            oSite_field_logo.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                            oSite_field_logo.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                            oSite_field_logo.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                            oList_Site_field_logo.Add(oSite_field_logo);
                        }
                    }
                }
            }
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_By_AREA_ID_List_Adv
        public List<Site> Get_Site_By_AREA_ID_List_Adv(IEnumerable<long?> AREA_ID_LIST)
        {
            List<Site> oList_Site = null;
            if (AREA_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.AREA_ID_LIST = string.Join(",", AREA_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_AREA_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Site = new List<Site>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site oSite = new Site();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                            oSite.Area = new Area();
                            oSite.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oSite.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oSite.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oSite.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oSite.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oSite.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oSite.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oSite.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oSite.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oSite.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oSite.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oSite.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oSite.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oSite.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oSite.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oSite.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oSite.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oSite.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oSite.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oSite.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oSite.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oSite.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oSite.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oSite.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oSite.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oSite.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oSite.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oSite.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oSite.District = new District();
                            oSite.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oSite.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oSite.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oSite.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oSite.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oSite.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oSite.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oSite.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oSite.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oSite.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oSite.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oSite.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oSite.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oSite.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oSite.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oSite.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oSite.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oSite.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oSite.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oSite.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oSite.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oSite.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oSite.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oSite.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oSite.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oSite.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oSite.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oSite.Region = new Region();
                            oSite.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oSite.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oSite.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oSite.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oSite.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oSite.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oSite.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oSite.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oSite.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oSite.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oSite.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oSite.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oSite.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oSite.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oSite.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oSite.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oSite.Top_level = new Top_level();
                            oSite.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oSite.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oSite.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oSite.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oSite.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oSite.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oSite.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oSite.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oSite.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oSite.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oSite.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oSite.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oSite.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oSite.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oSite.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oSite.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oList_Site.Add(oSite);
                        }
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_DISTRICT_ID_List_Adv
        public List<Site> Get_Site_By_DISTRICT_ID_List_Adv(IEnumerable<long?> DISTRICT_ID_LIST)
        {
            List<Site> oList_Site = null;
            if (DISTRICT_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_ID_LIST = string.Join(",", DISTRICT_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_DISTRICT_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Site = new List<Site>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site oSite = new Site();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                            oSite.Area = new Area();
                            oSite.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oSite.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oSite.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oSite.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oSite.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oSite.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oSite.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oSite.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oSite.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oSite.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oSite.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oSite.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oSite.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oSite.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oSite.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oSite.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oSite.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oSite.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oSite.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oSite.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oSite.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oSite.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oSite.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oSite.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oSite.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oSite.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oSite.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oSite.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oSite.District = new District();
                            oSite.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oSite.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oSite.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oSite.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oSite.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oSite.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oSite.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oSite.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oSite.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oSite.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oSite.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oSite.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oSite.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oSite.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oSite.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oSite.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oSite.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oSite.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oSite.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oSite.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oSite.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oSite.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oSite.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oSite.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oSite.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oSite.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oSite.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oSite.Region = new Region();
                            oSite.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oSite.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oSite.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oSite.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oSite.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oSite.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oSite.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oSite.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oSite.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oSite.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oSite.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oSite.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oSite.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oSite.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oSite.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oSite.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oSite.Top_level = new Top_level();
                            oSite.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oSite.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oSite.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oSite.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oSite.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oSite.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oSite.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oSite.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oSite.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oSite.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oSite.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oSite.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oSite.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oSite.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oSite.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oSite.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oList_Site.Add(oSite);
                        }
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_REGION_ID_List_Adv
        public List<Site> Get_Site_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST)
        {
            List<Site> oList_Site = null;
            if (REGION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REGION_ID_LIST = string.Join(",", REGION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_REGION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Site = new List<Site>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site oSite = new Site();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                            oSite.Area = new Area();
                            oSite.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oSite.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oSite.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oSite.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oSite.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oSite.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oSite.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oSite.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oSite.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oSite.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oSite.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oSite.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oSite.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oSite.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oSite.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oSite.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oSite.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oSite.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oSite.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oSite.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oSite.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oSite.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oSite.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oSite.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oSite.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oSite.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oSite.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oSite.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oSite.District = new District();
                            oSite.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oSite.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oSite.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oSite.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oSite.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oSite.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oSite.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oSite.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oSite.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oSite.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oSite.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oSite.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oSite.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oSite.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oSite.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oSite.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oSite.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oSite.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oSite.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oSite.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oSite.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oSite.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oSite.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oSite.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oSite.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oSite.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oSite.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oSite.Region = new Region();
                            oSite.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oSite.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oSite.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oSite.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oSite.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oSite.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oSite.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oSite.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oSite.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oSite.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oSite.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oSite.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oSite.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oSite.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oSite.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oSite.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oSite.Top_level = new Top_level();
                            oSite.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oSite.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oSite.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oSite.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oSite.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oSite.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oSite.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oSite.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oSite.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oSite.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oSite.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oSite.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oSite.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oSite.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oSite.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oSite.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oList_Site.Add(oSite);
                        }
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_By_TOP_LEVEL_ID_List_Adv
        public List<Site> Get_Site_By_TOP_LEVEL_ID_List_Adv(IEnumerable<long?> TOP_LEVEL_ID_LIST)
        {
            List<Site> oList_Site = null;
            if (TOP_LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.TOP_LEVEL_ID_LIST = string.Join(",", TOP_LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_TOP_LEVEL_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Site = new List<Site>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site oSite = new Site();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                            oSite.Area = new Area();
                            oSite.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oSite.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oSite.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oSite.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oSite.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oSite.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oSite.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oSite.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oSite.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oSite.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oSite.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oSite.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oSite.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oSite.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oSite.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oSite.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oSite.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oSite.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oSite.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oSite.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oSite.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oSite.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oSite.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oSite.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oSite.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oSite.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oSite.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oSite.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oSite.District = new District();
                            oSite.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oSite.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oSite.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oSite.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oSite.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oSite.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oSite.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oSite.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oSite.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oSite.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oSite.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oSite.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oSite.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oSite.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oSite.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oSite.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oSite.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oSite.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oSite.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oSite.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oSite.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oSite.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oSite.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oSite.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oSite.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oSite.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oSite.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oSite.Region = new Region();
                            oSite.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oSite.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oSite.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oSite.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oSite.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oSite.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oSite.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oSite.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oSite.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oSite.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oSite.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oSite.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oSite.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oSite.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oSite.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oSite.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oSite.Top_level = new Top_level();
                            oSite.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oSite.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oSite.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oSite.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oSite.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oSite.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oSite.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oSite.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oSite.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oSite.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oSite.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oSite.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oSite.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oSite.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oSite.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oSite.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oList_Site.Add(oSite);
                        }
                    }
                }
            }
            return oList_Site;
        }
        #endregion
        #region Get_Site_view_By_Where_Adv
        public List<Site_view> Get_Site_view_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Site_view> oList_Site_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Site_view = new List<Site_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                        oSite_view.Site = new Site();
                        oSite_view.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oSite_view.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oSite_view.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oSite_view.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oSite_view.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oSite_view.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oSite_view.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oSite_view.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oSite_view.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oSite_view.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oSite_view.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oSite_view.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oSite_view.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oSite_view.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oSite_view.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oSite_view.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oSite_view.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oSite_view.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oSite_view.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oSite_view.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oSite_view.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oSite_view.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oSite_view.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oSite_view.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oSite_view.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oSite_view.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oSite_view.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oSite_view.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oSite_view.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oSite_view.View_type_setup = new Setup();
                        oSite_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oSite_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oSite_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oSite_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oSite_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oSite_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oSite_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oSite_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oSite_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oSite_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oSite_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oSite_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oSite_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oSite_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site_view;
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
        #region Get_Site_field_logo_By_Where_Adv
        public List<Site_field_logo> Get_Site_field_logo_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_field_logo);
                        oSite_field_logo.Site = new Site();
                        oSite_field_logo.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oSite_field_logo.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oSite_field_logo.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oSite_field_logo.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oSite_field_logo.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oSite_field_logo.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oSite_field_logo.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oSite_field_logo.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oSite_field_logo.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oSite_field_logo.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oSite_field_logo.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oSite_field_logo.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oSite_field_logo.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oSite_field_logo.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oSite_field_logo.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oSite_field_logo.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oSite_field_logo.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oSite_field_logo.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oSite_field_logo.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oSite_field_logo.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oSite_field_logo.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oSite_field_logo.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oSite_field_logo.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oSite_field_logo.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oSite_field_logo.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oSite_field_logo.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oSite_field_logo.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oSite_field_logo.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oSite_field_logo.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_By_Where_Adv
        public List<Site> Get_Site_By_Where_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oSite.Area = new Area();
                        oSite.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oSite.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oSite.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oSite.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oSite.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oSite.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oSite.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oSite.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oSite.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oSite.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oSite.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oSite.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oSite.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oSite.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oSite.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oSite.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oSite.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oSite.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oSite.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oSite.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oSite.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oSite.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oSite.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oSite.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oSite.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oSite.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oSite.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oSite.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oSite.District = new District();
                        oSite.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oSite.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oSite.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oSite.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oSite.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oSite.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oSite.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oSite.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oSite.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oSite.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oSite.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oSite.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oSite.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oSite.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oSite.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oSite.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oSite.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oSite.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oSite.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oSite.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oSite.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oSite.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oSite.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oSite.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oSite.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oSite.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oSite.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oSite.Region = new Region();
                        oSite.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oSite.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oSite.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oSite.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oSite.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oSite.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oSite.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oSite.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oSite.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oSite.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oSite.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oSite.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oSite.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oSite.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oSite.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oSite.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oSite.Top_level = new Top_level();
                        oSite.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oSite.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oSite.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oSite.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oSite.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oSite.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oSite.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oSite.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oSite.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oSite.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oSite.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oSite.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oSite.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oSite.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oSite.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oSite.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Site.Add(oSite);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site;
        }
        #endregion
        #region Get_Site_view_By_Where_In_List_Adv
        public List<Site_view> Get_Site_view_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> SITE_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_VIEW_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Site_view = new List<Site_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_view oSite_view = new Site_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_view);
                        oSite_view.Site = new Site();
                        oSite_view.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oSite_view.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oSite_view.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oSite_view.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oSite_view.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oSite_view.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oSite_view.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oSite_view.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oSite_view.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oSite_view.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oSite_view.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oSite_view.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oSite_view.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oSite_view.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oSite_view.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oSite_view.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oSite_view.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oSite_view.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oSite_view.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oSite_view.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oSite_view.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oSite_view.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oSite_view.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oSite_view.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oSite_view.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oSite_view.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oSite_view.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oSite_view.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oSite_view.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oSite_view.View_type_setup = new Setup();
                        oSite_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oSite_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oSite_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oSite_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oSite_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oSite_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oSite_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oSite_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oSite_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oSite_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oSite_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oSite_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oSite_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oSite_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Site_view.Add(oSite_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site_view;
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
        #region Get_Site_field_logo_By_Where_In_List_Adv
        public List<Site_field_logo> Get_Site_field_logo_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> SITE_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.SITE_ID_LIST = SITE_ID_LIST != null ? string.Join(",", SITE_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_field_logo);
                        oSite_field_logo.Site = new Site();
                        oSite_field_logo.Site.SITE_ID = Get_Data_Record_Value<long?>(element, "T_SITE_SITE_ID");
                        oSite_field_logo.Site.AREA_ID = Get_Data_Record_Value<long?>(element, "T_SITE_AREA_ID");
                        oSite_field_logo.Site.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_SITE_DISTRICT_ID");
                        oSite_field_logo.Site.REGION_ID = Get_Data_Record_Value<long?>(element, "T_SITE_REGION_ID");
                        oSite_field_logo.Site.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_SITE_TOP_LEVEL_ID");
                        oSite_field_logo.Site.NAME = Get_Data_Record_Value<string>(element, "T_SITE_NAME");
                        oSite_field_logo.Site.LOCATION = Get_Data_Record_Value<string>(element, "T_SITE_LOCATION");
                        oSite_field_logo.Site.AREA = Get_Data_Record_Value<decimal?>(element, "T_SITE_AREA");
                        oSite_field_logo.Site.UNIT = Get_Data_Record_Value<string>(element, "T_SITE_UNIT");
                        oSite_field_logo.Site.SCALE = Get_Data_Record_Value<decimal?>(element, "T_SITE_SCALE");
                        oSite_field_logo.Site.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONX");
                        oSite_field_logo.Site.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONY");
                        oSite_field_logo.Site.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_SITE_ROTATIONZ");
                        oSite_field_logo.Site.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LATITUDE");
                        oSite_field_logo.Site.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_GLTF_LONGITUDE");
                        oSite_field_logo.Site.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LATITUDE");
                        oSite_field_logo.Site.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_SITE_CENTER_LONGITUDE");
                        oSite_field_logo.Site.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_SITE_RADIUS_IN_METERS");
                        oSite_field_logo.Site.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_SITE_IMAGE_URL");
                        oSite_field_logo.Site.LOGO_URL = Get_Data_Record_Value<string>(element, "T_SITE_LOGO_URL");
                        oSite_field_logo.Site.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_SITE_SOLID_GLTF_URL");
                        oSite_field_logo.Site.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_AREA_COLOR");
                        oSite_field_logo.Site.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_SITE_BORDER_COLOR");
                        oSite_field_logo.Site.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_SITE_STUDY_ZONE_NAME");
                        oSite_field_logo.Site.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SITE_ENTRY_USER_ID");
                        oSite_field_logo.Site.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SITE_ENTRY_DATE");
                        oSite_field_logo.Site.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SITE_LAST_UPDATE");
                        oSite_field_logo.Site.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SITE_IS_DELETED");
                        oSite_field_logo.Site.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SITE_OWNER_ID");
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_By_Where_In_List_Adv
        public List<Site> Get_Site_By_Where_In_List_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Site = new List<Site>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site oSite = new Site();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite);
                        oSite.Area = new Area();
                        oSite.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oSite.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oSite.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oSite.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oSite.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oSite.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oSite.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oSite.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oSite.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oSite.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oSite.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oSite.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oSite.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oSite.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oSite.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oSite.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oSite.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oSite.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oSite.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oSite.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oSite.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oSite.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oSite.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oSite.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oSite.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oSite.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oSite.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oSite.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oSite.District = new District();
                        oSite.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oSite.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oSite.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oSite.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oSite.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oSite.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oSite.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oSite.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oSite.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oSite.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oSite.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oSite.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oSite.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oSite.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oSite.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oSite.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oSite.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oSite.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oSite.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oSite.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oSite.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oSite.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oSite.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oSite.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oSite.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oSite.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oSite.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oSite.Region = new Region();
                        oSite.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oSite.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oSite.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oSite.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oSite.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oSite.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oSite.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oSite.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oSite.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oSite.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oSite.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oSite.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oSite.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oSite.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oSite.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oSite.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oSite.Top_level = new Top_level();
                        oSite.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oSite.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oSite.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oSite.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oSite.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oSite.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oSite.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oSite.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oSite.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oSite.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oSite.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oSite.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oSite.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oSite.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oSite.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oSite.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Site.Add(oSite);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site;
        }
        #endregion
    }
}
