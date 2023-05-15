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
        #region Get_Area_By_AREA_ID_Adv
        public Area Get_Area_By_AREA_ID_Adv(long? AREA_ID)
        {
            Area oArea = null;
            dynamic _params = new ExpandoObject();
            _params.AREA_ID = AREA_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_AREA_BY_AREA_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oArea = new Area();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oArea);
                oArea.District = new District();
                oArea.District.DISTRICT_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_DISTRICT_ID");
                oArea.District.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_REGION_ID");
                oArea.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_TOP_LEVEL_ID");
                oArea.District.NAME = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_NAME");
                oArea.District.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_LOCATION");
                oArea.District.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_AREA");
                oArea.District.UNIT = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_UNIT");
                oArea.District.SCALE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_SCALE");
                oArea.District.ROTATIONX = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_ROTATIONX");
                oArea.District.ROTATIONY = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_ROTATIONY");
                oArea.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_ROTATIONZ");
                oArea.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_GLTF_LATITUDE");
                oArea.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_GLTF_LONGITUDE");
                oArea.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_CENTER_LATITUDE");
                oArea.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_CENTER_LONGITUDE");
                oArea.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_RADIUS_IN_METERS");
                oArea.District.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_IMAGE_URL");
                oArea.District.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_LOGO_URL");
                oArea.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_SOLID_GLTF_URL");
                oArea.District.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_AREA_COLOR");
                oArea.District.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_BORDER_COLOR");
                oArea.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_STUDY_ZONE_NAME");
                oArea.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_ENTRY_USER_ID");
                oArea.District.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_ENTRY_DATE");
                oArea.District.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_LAST_UPDATE");
                oArea.District.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_DISTRICT_IS_DELETED");
                oArea.District.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_DISTRICT_OWNER_ID");
                oArea.Region = new Region();
                oArea.Region.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_REGION_ID");
                oArea.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_TOP_LEVEL_ID");
                oArea.Region.NAME = Get_Data_Record_Value<string>(_query_response, "T_REGION_NAME");
                oArea.Region.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_REGION_LOCATION");
                oArea.Region.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_REGION_AREA");
                oArea.Region.UNIT = Get_Data_Record_Value<string>(_query_response, "T_REGION_UNIT");
                oArea.Region.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_REGION_IMAGE_URL");
                oArea.Region.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_REGION_LOGO_URL");
                oArea.Region.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_REGION_AREA_COLOR");
                oArea.Region.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_REGION_BORDER_COLOR");
                oArea.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_REGION_STUDY_ZONE_NAME");
                oArea.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_ENTRY_USER_ID");
                oArea.Region.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_REGION_ENTRY_DATE");
                oArea.Region.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_REGION_LAST_UPDATE");
                oArea.Region.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_REGION_IS_DELETED");
                oArea.Region.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_REGION_OWNER_ID");
                oArea.Top_level = new Top_level();
                oArea.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_TOP_LEVEL_TOP_LEVEL_ID");
                oArea.Top_level.NAME = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_NAME");
                oArea.Top_level.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LOCATION");
                oArea.Top_level.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_TOP_LEVEL_AREA");
                oArea.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_IMAGE_URL");
                oArea.Top_level.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LOGO_URL");
                oArea.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_AREA_COLOR");
                oArea.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_BORDER_COLOR");
                oArea.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                oArea.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_LOW_THRESHOLD");
                oArea.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_HIGH_THRESHOLD");
                oArea.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_TOP_LEVEL_ENTRY_USER_ID");
                oArea.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_ENTRY_DATE");
                oArea.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LAST_UPDATE");
                oArea.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_TOP_LEVEL_IS_DELETED");
                oArea.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_OWNER_ID");
            }
            return oArea;
        }
        #endregion
        #region Get_Area_view_By_AREA_VIEW_ID_Adv
        public Area_view Get_Area_view_By_AREA_VIEW_ID_Adv(long? AREA_VIEW_ID)
        {
            Area_view oArea_view = null;
            dynamic _params = new ExpandoObject();
            _params.AREA_VIEW_ID = AREA_VIEW_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_AREA_VIEW_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oArea_view = new Area_view();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oArea_view);
                oArea_view.Area = new Area();
                oArea_view.Area.AREA_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_AREA_ID");
                oArea_view.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_DISTRICT_ID");
                oArea_view.Area.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_REGION_ID");
                oArea_view.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_TOP_LEVEL_ID");
                oArea_view.Area.NAME = Get_Data_Record_Value<string>(_query_response, "T_AREA_NAME");
                oArea_view.Area.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_AREA_LOCATION");
                oArea_view.Area.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_AREA");
                oArea_view.Area.UNIT = Get_Data_Record_Value<string>(_query_response, "T_AREA_UNIT");
                oArea_view.Area.SCALE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_SCALE");
                oArea_view.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_ROTATIONX");
                oArea_view.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_ROTATIONY");
                oArea_view.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_ROTATIONZ");
                oArea_view.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_GLTF_LATITUDE");
                oArea_view.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_GLTF_LONGITUDE");
                oArea_view.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_CENTER_LATITUDE");
                oArea_view.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_CENTER_LONGITUDE");
                oArea_view.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(_query_response, "T_AREA_RADIUS_IN_METERS");
                oArea_view.Area.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_AREA_IMAGE_URL");
                oArea_view.Area.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_AREA_LOGO_URL");
                oArea_view.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_AREA_SOLID_GLTF_URL");
                oArea_view.Area.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_AREA_AREA_COLOR");
                oArea_view.Area.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_AREA_BORDER_COLOR");
                oArea_view.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_AREA_STUDY_ZONE_NAME");
                oArea_view.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_AREA_ENTRY_USER_ID");
                oArea_view.Area.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_AREA_ENTRY_DATE");
                oArea_view.Area.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_AREA_LAST_UPDATE");
                oArea_view.Area.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_AREA_IS_DELETED");
                oArea_view.Area.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_AREA_OWNER_ID");
                oArea_view.View_type_setup = new Setup();
                oArea_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIEW_TYPE_SETUP_SETUP_ID");
                oArea_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                oArea_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                oArea_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                oArea_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                oArea_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_DELETED");
                oArea_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                oArea_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                oArea_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_VALUE");
                oArea_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                oArea_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                oArea_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                oArea_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                oArea_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_OWNER_ID");
            }
            return oArea_view;
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
        #region Get_Area_By_AREA_ID_List_Adv
        public List<Area> Get_Area_By_AREA_ID_List_Adv(IEnumerable<long?> AREA_ID_LIST)
        {
            List<Area> oList_Area = null;
            if (AREA_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.AREA_ID_LIST = string.Join(",", AREA_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_AREA_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Area = new List<Area>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area oArea = new Area();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                            oArea.District = new District();
                            oArea.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oArea.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oArea.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oArea.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oArea.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oArea.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oArea.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oArea.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oArea.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oArea.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oArea.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oArea.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oArea.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oArea.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oArea.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oArea.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oArea.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oArea.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oArea.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oArea.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oArea.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oArea.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oArea.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oArea.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oArea.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oArea.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oArea.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oArea.Region = new Region();
                            oArea.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oArea.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oArea.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oArea.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oArea.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oArea.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oArea.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oArea.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oArea.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oArea.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oArea.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oArea.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oArea.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oArea.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oArea.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oArea.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oArea.Top_level = new Top_level();
                            oArea.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oArea.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oArea.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oArea.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oArea.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oArea.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oArea.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oArea.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oArea.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oArea.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oArea.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oArea.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oArea.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oArea.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oArea.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oArea.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oList_Area.Add(oArea);
                        }
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_AREA_VIEW_ID_List_Adv
        public List<Area_view> Get_Area_view_By_AREA_VIEW_ID_List_Adv(IEnumerable<long?> AREA_VIEW_ID_LIST)
        {
            List<Area_view> oList_Area_view = null;
            if (AREA_VIEW_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.AREA_VIEW_ID_LIST = string.Join(",", AREA_VIEW_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_AREA_VIEW_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Area_view = new List<Area_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area_view oArea_view = new Area_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                            oArea_view.Area = new Area();
                            oArea_view.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oArea_view.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oArea_view.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oArea_view.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oArea_view.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oArea_view.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oArea_view.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oArea_view.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oArea_view.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oArea_view.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oArea_view.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oArea_view.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oArea_view.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oArea_view.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oArea_view.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oArea_view.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oArea_view.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oArea_view.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oArea_view.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oArea_view.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oArea_view.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oArea_view.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oArea_view.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oArea_view.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oArea_view.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oArea_view.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oArea_view.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oArea_view.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oArea_view.View_type_setup = new Setup();
                            oArea_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oArea_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oArea_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oArea_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oArea_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oArea_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oArea_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oArea_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oArea_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oArea_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oArea_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oArea_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oArea_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oArea_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_Area_view.Add(oArea_view);
                        }
                    }
                }
            }
            return oList_Area_view;
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
        #region Get_Area_By_OWNER_ID_IS_DELETED_Adv
        public List<Area> Get_Area_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Area> oList_Area = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Area = new List<Area>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                        oArea.District = new District();
                        oArea.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oArea.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oArea.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oArea.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oArea.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oArea.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oArea.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oArea.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oArea.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oArea.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oArea.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oArea.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oArea.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oArea.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oArea.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oArea.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oArea.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oArea.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oArea.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oArea.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oArea.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oArea.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oArea.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oArea.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oArea.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oArea.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oArea.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oArea.Region = new Region();
                        oArea.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oArea.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oArea.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oArea.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oArea.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oArea.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oArea.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oArea.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oArea.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oArea.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oArea.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oArea.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oArea.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oArea.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oArea.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oArea.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oArea.Top_level = new Top_level();
                        oArea.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oArea.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oArea.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oArea.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oArea.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oArea.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oArea.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oArea.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oArea.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oArea.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oArea.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oArea.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oArea.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oArea.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oArea.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oArea.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Area.Add(oArea);
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_OWNER_ID_Adv
        public List<Area> Get_Area_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Area> oList_Area = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Area = new List<Area>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                        oArea.District = new District();
                        oArea.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oArea.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oArea.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oArea.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oArea.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oArea.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oArea.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oArea.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oArea.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oArea.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oArea.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oArea.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oArea.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oArea.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oArea.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oArea.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oArea.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oArea.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oArea.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oArea.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oArea.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oArea.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oArea.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oArea.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oArea.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oArea.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oArea.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oArea.Region = new Region();
                        oArea.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oArea.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oArea.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oArea.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oArea.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oArea.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oArea.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oArea.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oArea.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oArea.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oArea.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oArea.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oArea.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oArea.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oArea.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oArea.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oArea.Top_level = new Top_level();
                        oArea.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oArea.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oArea.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oArea.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oArea.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oArea.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oArea.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oArea.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oArea.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oArea.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oArea.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oArea.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oArea.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oArea.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oArea.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oArea.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Area.Add(oArea);
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_DISTRICT_ID_Adv
        public List<Area> Get_Area_By_DISTRICT_ID_Adv(long? DISTRICT_ID)
        {
            List<Area> oList_Area = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_ID = DISTRICT_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_DISTRICT_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Area = new List<Area>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                        oArea.District = new District();
                        oArea.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oArea.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oArea.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oArea.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oArea.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oArea.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oArea.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oArea.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oArea.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oArea.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oArea.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oArea.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oArea.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oArea.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oArea.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oArea.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oArea.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oArea.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oArea.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oArea.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oArea.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oArea.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oArea.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oArea.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oArea.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oArea.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oArea.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oArea.Region = new Region();
                        oArea.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oArea.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oArea.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oArea.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oArea.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oArea.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oArea.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oArea.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oArea.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oArea.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oArea.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oArea.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oArea.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oArea.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oArea.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oArea.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oArea.Top_level = new Top_level();
                        oArea.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oArea.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oArea.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oArea.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oArea.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oArea.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oArea.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oArea.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oArea.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oArea.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oArea.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oArea.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oArea.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oArea.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oArea.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oArea.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Area.Add(oArea);
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_REGION_ID_Adv
        public List<Area> Get_Area_By_REGION_ID_Adv(long? REGION_ID)
        {
            List<Area> oList_Area = null;
            dynamic _params = new ExpandoObject();
            _params.REGION_ID = REGION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_REGION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Area = new List<Area>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                        oArea.District = new District();
                        oArea.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oArea.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oArea.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oArea.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oArea.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oArea.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oArea.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oArea.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oArea.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oArea.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oArea.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oArea.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oArea.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oArea.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oArea.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oArea.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oArea.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oArea.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oArea.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oArea.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oArea.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oArea.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oArea.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oArea.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oArea.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oArea.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oArea.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oArea.Region = new Region();
                        oArea.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oArea.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oArea.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oArea.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oArea.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oArea.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oArea.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oArea.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oArea.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oArea.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oArea.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oArea.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oArea.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oArea.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oArea.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oArea.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oArea.Top_level = new Top_level();
                        oArea.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oArea.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oArea.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oArea.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oArea.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oArea.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oArea.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oArea.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oArea.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oArea.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oArea.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oArea.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oArea.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oArea.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oArea.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oArea.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Area.Add(oArea);
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_TOP_LEVEL_ID_Adv
        public List<Area> Get_Area_By_TOP_LEVEL_ID_Adv(long? TOP_LEVEL_ID)
        {
            List<Area> oList_Area = null;
            dynamic _params = new ExpandoObject();
            _params.TOP_LEVEL_ID = TOP_LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_TOP_LEVEL_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Area = new List<Area>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                        oArea.District = new District();
                        oArea.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oArea.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oArea.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oArea.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oArea.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oArea.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oArea.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oArea.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oArea.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oArea.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oArea.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oArea.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oArea.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oArea.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oArea.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oArea.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oArea.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oArea.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oArea.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oArea.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oArea.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oArea.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oArea.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oArea.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oArea.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oArea.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oArea.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oArea.Region = new Region();
                        oArea.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oArea.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oArea.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oArea.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oArea.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oArea.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oArea.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oArea.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oArea.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oArea.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oArea.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oArea.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oArea.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oArea.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oArea.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oArea.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oArea.Top_level = new Top_level();
                        oArea.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oArea.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oArea.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oArea.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oArea.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oArea.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oArea.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oArea.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oArea.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oArea.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oArea.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oArea.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oArea.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oArea.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oArea.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oArea.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Area.Add(oArea);
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_OWNER_ID_Adv
        public List<Area_view> Get_Area_view_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Area_view> oList_Area_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Area_view = new List<Area_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                        oArea_view.Area = new Area();
                        oArea_view.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oArea_view.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oArea_view.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oArea_view.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oArea_view.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oArea_view.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oArea_view.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oArea_view.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oArea_view.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oArea_view.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oArea_view.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oArea_view.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oArea_view.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oArea_view.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oArea_view.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oArea_view.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oArea_view.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oArea_view.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oArea_view.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oArea_view.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oArea_view.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oArea_view.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oArea_view.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oArea_view.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oArea_view.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oArea_view.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oArea_view.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oArea_view.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oArea_view.View_type_setup = new Setup();
                        oArea_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oArea_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oArea_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oArea_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oArea_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oArea_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oArea_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oArea_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oArea_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oArea_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oArea_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oArea_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oArea_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oArea_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_AREA_ID_Adv
        public List<Area_view> Get_Area_view_By_AREA_ID_Adv(long? AREA_ID)
        {
            List<Area_view> oList_Area_view = null;
            dynamic _params = new ExpandoObject();
            _params.AREA_ID = AREA_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_AREA_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Area_view = new List<Area_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                        oArea_view.Area = new Area();
                        oArea_view.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oArea_view.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oArea_view.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oArea_view.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oArea_view.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oArea_view.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oArea_view.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oArea_view.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oArea_view.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oArea_view.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oArea_view.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oArea_view.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oArea_view.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oArea_view.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oArea_view.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oArea_view.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oArea_view.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oArea_view.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oArea_view.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oArea_view.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oArea_view.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oArea_view.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oArea_view.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oArea_view.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oArea_view.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oArea_view.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oArea_view.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oArea_view.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oArea_view.View_type_setup = new Setup();
                        oArea_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oArea_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oArea_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oArea_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oArea_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oArea_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oArea_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oArea_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oArea_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oArea_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oArea_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oArea_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oArea_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oArea_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_VIEW_TYPE_SETUP_ID_Adv
        public List<Area_view> Get_Area_view_By_VIEW_TYPE_SETUP_ID_Adv(long? VIEW_TYPE_SETUP_ID)
        {
            List<Area_view> oList_Area_view = null;
            dynamic _params = new ExpandoObject();
            _params.VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_VIEW_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Area_view = new List<Area_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                        oArea_view.Area = new Area();
                        oArea_view.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oArea_view.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oArea_view.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oArea_view.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oArea_view.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oArea_view.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oArea_view.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oArea_view.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oArea_view.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oArea_view.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oArea_view.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oArea_view.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oArea_view.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oArea_view.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oArea_view.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oArea_view.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oArea_view.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oArea_view.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oArea_view.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oArea_view.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oArea_view.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oArea_view.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oArea_view.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oArea_view.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oArea_view.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oArea_view.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oArea_view.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oArea_view.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oArea_view.View_type_setup = new Setup();
                        oArea_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oArea_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oArea_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oArea_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oArea_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oArea_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oArea_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oArea_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oArea_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oArea_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oArea_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oArea_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oArea_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oArea_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_OWNER_ID_IS_DELETED_Adv
        public List<Area_view> Get_Area_view_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Area_view> oList_Area_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Area_view = new List<Area_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                        oArea_view.Area = new Area();
                        oArea_view.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oArea_view.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oArea_view.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oArea_view.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oArea_view.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oArea_view.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oArea_view.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oArea_view.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oArea_view.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oArea_view.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oArea_view.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oArea_view.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oArea_view.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oArea_view.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oArea_view.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oArea_view.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oArea_view.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oArea_view.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oArea_view.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oArea_view.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oArea_view.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oArea_view.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oArea_view.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oArea_view.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oArea_view.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oArea_view.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oArea_view.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oArea_view.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oArea_view.View_type_setup = new Setup();
                        oArea_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oArea_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oArea_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oArea_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oArea_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oArea_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oArea_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oArea_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oArea_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oArea_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oArea_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oArea_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oArea_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oArea_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            return oList_Area_view;
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
        #region Get_Area_By_DISTRICT_ID_List_Adv
        public List<Area> Get_Area_By_DISTRICT_ID_List_Adv(IEnumerable<long?> DISTRICT_ID_LIST)
        {
            List<Area> oList_Area = null;
            if (DISTRICT_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_ID_LIST = string.Join(",", DISTRICT_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_DISTRICT_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Area = new List<Area>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area oArea = new Area();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                            oArea.District = new District();
                            oArea.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oArea.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oArea.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oArea.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oArea.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oArea.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oArea.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oArea.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oArea.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oArea.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oArea.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oArea.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oArea.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oArea.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oArea.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oArea.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oArea.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oArea.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oArea.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oArea.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oArea.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oArea.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oArea.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oArea.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oArea.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oArea.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oArea.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oArea.Region = new Region();
                            oArea.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oArea.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oArea.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oArea.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oArea.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oArea.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oArea.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oArea.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oArea.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oArea.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oArea.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oArea.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oArea.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oArea.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oArea.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oArea.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oArea.Top_level = new Top_level();
                            oArea.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oArea.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oArea.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oArea.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oArea.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oArea.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oArea.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oArea.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oArea.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oArea.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oArea.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oArea.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oArea.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oArea.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oArea.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oArea.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oList_Area.Add(oArea);
                        }
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_REGION_ID_List_Adv
        public List<Area> Get_Area_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST)
        {
            List<Area> oList_Area = null;
            if (REGION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REGION_ID_LIST = string.Join(",", REGION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_REGION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Area = new List<Area>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area oArea = new Area();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                            oArea.District = new District();
                            oArea.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oArea.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oArea.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oArea.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oArea.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oArea.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oArea.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oArea.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oArea.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oArea.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oArea.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oArea.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oArea.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oArea.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oArea.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oArea.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oArea.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oArea.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oArea.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oArea.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oArea.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oArea.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oArea.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oArea.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oArea.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oArea.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oArea.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oArea.Region = new Region();
                            oArea.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oArea.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oArea.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oArea.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oArea.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oArea.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oArea.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oArea.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oArea.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oArea.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oArea.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oArea.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oArea.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oArea.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oArea.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oArea.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oArea.Top_level = new Top_level();
                            oArea.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oArea.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oArea.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oArea.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oArea.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oArea.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oArea.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oArea.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oArea.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oArea.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oArea.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oArea.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oArea.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oArea.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oArea.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oArea.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oList_Area.Add(oArea);
                        }
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_By_TOP_LEVEL_ID_List_Adv
        public List<Area> Get_Area_By_TOP_LEVEL_ID_List_Adv(IEnumerable<long?> TOP_LEVEL_ID_LIST)
        {
            List<Area> oList_Area = null;
            if (TOP_LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.TOP_LEVEL_ID_LIST = string.Join(",", TOP_LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_TOP_LEVEL_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Area = new List<Area>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area oArea = new Area();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                            oArea.District = new District();
                            oArea.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oArea.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oArea.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oArea.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oArea.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oArea.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oArea.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oArea.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oArea.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oArea.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oArea.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oArea.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oArea.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oArea.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oArea.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oArea.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oArea.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oArea.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oArea.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oArea.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oArea.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oArea.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oArea.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oArea.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oArea.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oArea.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oArea.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oArea.Region = new Region();
                            oArea.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oArea.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oArea.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oArea.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oArea.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oArea.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oArea.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oArea.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oArea.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oArea.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oArea.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oArea.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oArea.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oArea.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oArea.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oArea.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oArea.Top_level = new Top_level();
                            oArea.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oArea.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oArea.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oArea.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oArea.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oArea.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oArea.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oArea.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oArea.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oArea.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oArea.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oArea.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oArea.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oArea.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oArea.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oArea.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oList_Area.Add(oArea);
                        }
                    }
                }
            }
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_AREA_ID_List_Adv
        public List<Area_view> Get_Area_view_By_AREA_ID_List_Adv(IEnumerable<long?> AREA_ID_LIST)
        {
            List<Area_view> oList_Area_view = null;
            if (AREA_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.AREA_ID_LIST = string.Join(",", AREA_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_AREA_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Area_view = new List<Area_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area_view oArea_view = new Area_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                            oArea_view.Area = new Area();
                            oArea_view.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oArea_view.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oArea_view.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oArea_view.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oArea_view.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oArea_view.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oArea_view.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oArea_view.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oArea_view.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oArea_view.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oArea_view.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oArea_view.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oArea_view.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oArea_view.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oArea_view.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oArea_view.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oArea_view.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oArea_view.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oArea_view.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oArea_view.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oArea_view.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oArea_view.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oArea_view.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oArea_view.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oArea_view.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oArea_view.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oArea_view.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oArea_view.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oArea_view.View_type_setup = new Setup();
                            oArea_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oArea_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oArea_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oArea_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oArea_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oArea_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oArea_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oArea_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oArea_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oArea_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oArea_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oArea_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oArea_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oArea_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_Area_view.Add(oArea_view);
                        }
                    }
                }
            }
            return oList_Area_view;
        }
        #endregion
        #region Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        public List<Area_view> Get_Area_view_By_VIEW_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST)
        {
            List<Area_view> oList_Area_view = null;
            if (VIEW_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIEW_TYPE_SETUP_ID_LIST = string.Join(",", VIEW_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_VIEW_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Area_view = new List<Area_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Area_view oArea_view = new Area_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                            oArea_view.Area = new Area();
                            oArea_view.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                            oArea_view.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                            oArea_view.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                            oArea_view.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                            oArea_view.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                            oArea_view.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                            oArea_view.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                            oArea_view.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                            oArea_view.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                            oArea_view.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                            oArea_view.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                            oArea_view.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                            oArea_view.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                            oArea_view.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                            oArea_view.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                            oArea_view.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                            oArea_view.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                            oArea_view.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                            oArea_view.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                            oArea_view.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                            oArea_view.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                            oArea_view.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                            oArea_view.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                            oArea_view.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                            oArea_view.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                            oArea_view.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                            oArea_view.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                            oArea_view.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                            oArea_view.View_type_setup = new Setup();
                            oArea_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oArea_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oArea_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oArea_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oArea_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oArea_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oArea_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oArea_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oArea_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oArea_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oArea_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oArea_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oArea_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oArea_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_Area_view.Add(oArea_view);
                        }
                    }
                }
            }
            return oList_Area_view;
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
        #region Get_Area_By_Where_Adv
        public List<Area> Get_Area_By_Where_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Area = new List<Area>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                        oArea.District = new District();
                        oArea.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oArea.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oArea.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oArea.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oArea.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oArea.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oArea.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oArea.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oArea.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oArea.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oArea.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oArea.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oArea.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oArea.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oArea.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oArea.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oArea.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oArea.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oArea.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oArea.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oArea.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oArea.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oArea.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oArea.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oArea.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oArea.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oArea.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oArea.Region = new Region();
                        oArea.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oArea.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oArea.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oArea.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oArea.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oArea.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oArea.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oArea.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oArea.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oArea.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oArea.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oArea.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oArea.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oArea.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oArea.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oArea.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oArea.Top_level = new Top_level();
                        oArea.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oArea.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oArea.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oArea.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oArea.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oArea.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oArea.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oArea.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oArea.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oArea.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oArea.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oArea.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oArea.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oArea.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oArea.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oArea.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Area.Add(oArea);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_Where_Adv
        public List<Area_view> Get_Area_view_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Area_view> oList_Area_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Area_view = new List<Area_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                        oArea_view.Area = new Area();
                        oArea_view.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oArea_view.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oArea_view.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oArea_view.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oArea_view.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oArea_view.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oArea_view.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oArea_view.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oArea_view.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oArea_view.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oArea_view.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oArea_view.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oArea_view.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oArea_view.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oArea_view.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oArea_view.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oArea_view.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oArea_view.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oArea_view.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oArea_view.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oArea_view.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oArea_view.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oArea_view.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oArea_view.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oArea_view.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oArea_view.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oArea_view.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oArea_view.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oArea_view.View_type_setup = new Setup();
                        oArea_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oArea_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oArea_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oArea_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oArea_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oArea_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oArea_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oArea_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oArea_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oArea_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oArea_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oArea_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oArea_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oArea_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Area_view;
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
        #region Get_Area_By_Where_In_List_Adv
        public List<Area> Get_Area_By_Where_In_List_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Area = new List<Area>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area oArea = new Area();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea);
                        oArea.District = new District();
                        oArea.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oArea.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oArea.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oArea.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oArea.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oArea.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oArea.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oArea.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oArea.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oArea.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oArea.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oArea.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oArea.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oArea.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oArea.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oArea.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oArea.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oArea.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oArea.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oArea.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oArea.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oArea.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oArea.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oArea.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oArea.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oArea.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oArea.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oArea.Region = new Region();
                        oArea.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oArea.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oArea.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oArea.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oArea.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oArea.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oArea.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oArea.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oArea.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oArea.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oArea.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oArea.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oArea.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oArea.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oArea.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oArea.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oArea.Top_level = new Top_level();
                        oArea.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oArea.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oArea.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oArea.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oArea.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oArea.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oArea.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oArea.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oArea.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oArea.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oArea.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oArea.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oArea.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oArea.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oArea.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oArea.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Area.Add(oArea);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Area;
        }
        #endregion
        #region Get_Area_view_By_Where_In_List_Adv
        public List<Area_view> Get_Area_view_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> AREA_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_AREA_VIEW_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Area_view = new List<Area_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Area_view oArea_view = new Area_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oArea_view);
                        oArea_view.Area = new Area();
                        oArea_view.Area.AREA_ID = Get_Data_Record_Value<long?>(element, "T_AREA_AREA_ID");
                        oArea_view.Area.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_AREA_DISTRICT_ID");
                        oArea_view.Area.REGION_ID = Get_Data_Record_Value<long?>(element, "T_AREA_REGION_ID");
                        oArea_view.Area.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_AREA_TOP_LEVEL_ID");
                        oArea_view.Area.NAME = Get_Data_Record_Value<string>(element, "T_AREA_NAME");
                        oArea_view.Area.LOCATION = Get_Data_Record_Value<string>(element, "T_AREA_LOCATION");
                        oArea_view.Area.AREA = Get_Data_Record_Value<decimal?>(element, "T_AREA_AREA");
                        oArea_view.Area.UNIT = Get_Data_Record_Value<string>(element, "T_AREA_UNIT");
                        oArea_view.Area.SCALE = Get_Data_Record_Value<decimal?>(element, "T_AREA_SCALE");
                        oArea_view.Area.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONX");
                        oArea_view.Area.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONY");
                        oArea_view.Area.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_AREA_ROTATIONZ");
                        oArea_view.Area.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LATITUDE");
                        oArea_view.Area.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_GLTF_LONGITUDE");
                        oArea_view.Area.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LATITUDE");
                        oArea_view.Area.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_AREA_CENTER_LONGITUDE");
                        oArea_view.Area.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_AREA_RADIUS_IN_METERS");
                        oArea_view.Area.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_AREA_IMAGE_URL");
                        oArea_view.Area.LOGO_URL = Get_Data_Record_Value<string>(element, "T_AREA_LOGO_URL");
                        oArea_view.Area.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_AREA_SOLID_GLTF_URL");
                        oArea_view.Area.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_AREA_COLOR");
                        oArea_view.Area.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_AREA_BORDER_COLOR");
                        oArea_view.Area.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_AREA_STUDY_ZONE_NAME");
                        oArea_view.Area.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_AREA_ENTRY_USER_ID");
                        oArea_view.Area.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_AREA_ENTRY_DATE");
                        oArea_view.Area.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_AREA_LAST_UPDATE");
                        oArea_view.Area.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_AREA_IS_DELETED");
                        oArea_view.Area.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_AREA_OWNER_ID");
                        oArea_view.View_type_setup = new Setup();
                        oArea_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oArea_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oArea_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oArea_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oArea_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oArea_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oArea_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oArea_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oArea_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oArea_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oArea_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oArea_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oArea_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oArea_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Area_view.Add(oArea_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Area_view;
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
