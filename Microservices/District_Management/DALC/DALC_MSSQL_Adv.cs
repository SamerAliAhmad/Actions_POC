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
        #region Get_District_view_By_DISTRICT_VIEW_ID_Adv
        public District_view Get_District_view_By_DISTRICT_VIEW_ID_Adv(long? DISTRICT_VIEW_ID)
        {
            District_view oDistrict_view = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_VIEW_ID = DISTRICT_VIEW_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_DISTRICT_VIEW_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oDistrict_view = new District_view();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oDistrict_view);
                oDistrict_view.District = new District();
                oDistrict_view.District.DISTRICT_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_DISTRICT_ID");
                oDistrict_view.District.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_REGION_ID");
                oDistrict_view.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_TOP_LEVEL_ID");
                oDistrict_view.District.NAME = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_NAME");
                oDistrict_view.District.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_LOCATION");
                oDistrict_view.District.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_AREA");
                oDistrict_view.District.UNIT = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_UNIT");
                oDistrict_view.District.SCALE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_SCALE");
                oDistrict_view.District.ROTATIONX = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_ROTATIONX");
                oDistrict_view.District.ROTATIONY = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_ROTATIONY");
                oDistrict_view.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_ROTATIONZ");
                oDistrict_view.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_GLTF_LATITUDE");
                oDistrict_view.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_GLTF_LONGITUDE");
                oDistrict_view.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_CENTER_LATITUDE");
                oDistrict_view.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_CENTER_LONGITUDE");
                oDistrict_view.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(_query_response, "T_DISTRICT_RADIUS_IN_METERS");
                oDistrict_view.District.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_IMAGE_URL");
                oDistrict_view.District.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_LOGO_URL");
                oDistrict_view.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_SOLID_GLTF_URL");
                oDistrict_view.District.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_AREA_COLOR");
                oDistrict_view.District.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_BORDER_COLOR");
                oDistrict_view.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_STUDY_ZONE_NAME");
                oDistrict_view.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_DISTRICT_ENTRY_USER_ID");
                oDistrict_view.District.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_ENTRY_DATE");
                oDistrict_view.District.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_DISTRICT_LAST_UPDATE");
                oDistrict_view.District.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_DISTRICT_IS_DELETED");
                oDistrict_view.District.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_DISTRICT_OWNER_ID");
                oDistrict_view.View_type_setup = new Setup();
                oDistrict_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIEW_TYPE_SETUP_SETUP_ID");
                oDistrict_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                oDistrict_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                oDistrict_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                oDistrict_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                oDistrict_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_DELETED");
                oDistrict_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                oDistrict_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                oDistrict_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_VALUE");
                oDistrict_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                oDistrict_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                oDistrict_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                oDistrict_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                oDistrict_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_OWNER_ID");
            }
            return oDistrict_view;
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
        #region Get_District_By_DISTRICT_ID_Adv
        public District Get_District_By_DISTRICT_ID_Adv(long? DISTRICT_ID)
        {
            District oDistrict = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_ID = DISTRICT_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_DISTRICT_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oDistrict = new District();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oDistrict);
                oDistrict.Region = new Region();
                oDistrict.Region.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_REGION_ID");
                oDistrict.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_TOP_LEVEL_ID");
                oDistrict.Region.NAME = Get_Data_Record_Value<string>(_query_response, "T_REGION_NAME");
                oDistrict.Region.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_REGION_LOCATION");
                oDistrict.Region.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_REGION_AREA");
                oDistrict.Region.UNIT = Get_Data_Record_Value<string>(_query_response, "T_REGION_UNIT");
                oDistrict.Region.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_REGION_IMAGE_URL");
                oDistrict.Region.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_REGION_LOGO_URL");
                oDistrict.Region.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_REGION_AREA_COLOR");
                oDistrict.Region.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_REGION_BORDER_COLOR");
                oDistrict.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_REGION_STUDY_ZONE_NAME");
                oDistrict.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_ENTRY_USER_ID");
                oDistrict.Region.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_REGION_ENTRY_DATE");
                oDistrict.Region.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_REGION_LAST_UPDATE");
                oDistrict.Region.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_REGION_IS_DELETED");
                oDistrict.Region.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_REGION_OWNER_ID");
                oDistrict.Top_level = new Top_level();
                oDistrict.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_TOP_LEVEL_TOP_LEVEL_ID");
                oDistrict.Top_level.NAME = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_NAME");
                oDistrict.Top_level.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LOCATION");
                oDistrict.Top_level.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_TOP_LEVEL_AREA");
                oDistrict.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_IMAGE_URL");
                oDistrict.Top_level.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LOGO_URL");
                oDistrict.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_AREA_COLOR");
                oDistrict.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_BORDER_COLOR");
                oDistrict.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                oDistrict.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_LOW_THRESHOLD");
                oDistrict.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_HIGH_THRESHOLD");
                oDistrict.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_TOP_LEVEL_ENTRY_USER_ID");
                oDistrict.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_ENTRY_DATE");
                oDistrict.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LAST_UPDATE");
                oDistrict.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_TOP_LEVEL_IS_DELETED");
                oDistrict.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_OWNER_ID");
            }
            return oDistrict;
        }
        #endregion
        #region Get_District_view_By_DISTRICT_VIEW_ID_List_Adv
        public List<District_view> Get_District_view_By_DISTRICT_VIEW_ID_List_Adv(IEnumerable<long?> DISTRICT_VIEW_ID_LIST)
        {
            List<District_view> oList_District_view = null;
            if (DISTRICT_VIEW_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_VIEW_ID_LIST = string.Join(",", DISTRICT_VIEW_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_DISTRICT_VIEW_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_District_view = new List<District_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District_view oDistrict_view = new District_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                            oDistrict_view.District = new District();
                            oDistrict_view.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oDistrict_view.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oDistrict_view.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oDistrict_view.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oDistrict_view.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oDistrict_view.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oDistrict_view.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oDistrict_view.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oDistrict_view.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oDistrict_view.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oDistrict_view.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oDistrict_view.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oDistrict_view.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oDistrict_view.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oDistrict_view.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oDistrict_view.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oDistrict_view.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oDistrict_view.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oDistrict_view.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oDistrict_view.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oDistrict_view.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oDistrict_view.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oDistrict_view.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oDistrict_view.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oDistrict_view.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oDistrict_view.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oDistrict_view.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oDistrict_view.View_type_setup = new Setup();
                            oDistrict_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oDistrict_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oDistrict_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oDistrict_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oDistrict_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oDistrict_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oDistrict_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oDistrict_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oDistrict_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oDistrict_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oDistrict_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oDistrict_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oDistrict_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oDistrict_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_District_view.Add(oDistrict_view);
                        }
                    }
                }
            }
            return oList_District_view;
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
        #region Get_District_By_DISTRICT_ID_List_Adv
        public List<District> Get_District_By_DISTRICT_ID_List_Adv(IEnumerable<long?> DISTRICT_ID_LIST)
        {
            List<District> oList_District = null;
            if (DISTRICT_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_ID_LIST = string.Join(",", DISTRICT_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_DISTRICT_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_District = new List<District>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District oDistrict = new District();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                            oDistrict.Region = new Region();
                            oDistrict.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oDistrict.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oDistrict.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oDistrict.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oDistrict.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oDistrict.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oDistrict.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oDistrict.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oDistrict.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oDistrict.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oDistrict.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oDistrict.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oDistrict.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oDistrict.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oDistrict.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oDistrict.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oDistrict.Top_level = new Top_level();
                            oDistrict.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oDistrict.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oDistrict.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oDistrict.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oDistrict.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oDistrict.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oDistrict.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oDistrict.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oDistrict.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oDistrict.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oDistrict.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oDistrict.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oDistrict.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oDistrict.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oDistrict.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oDistrict.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oList_District.Add(oDistrict);
                        }
                    }
                }
            }
            return oList_District;
        }
        #endregion
        #region Get_District_view_By_OWNER_ID_Adv
        public List<District_view> Get_District_view_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<District_view> oList_District_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_District_view = new List<District_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                        oDistrict_view.District = new District();
                        oDistrict_view.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oDistrict_view.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oDistrict_view.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oDistrict_view.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oDistrict_view.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oDistrict_view.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oDistrict_view.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oDistrict_view.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oDistrict_view.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oDistrict_view.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oDistrict_view.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oDistrict_view.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oDistrict_view.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oDistrict_view.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oDistrict_view.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oDistrict_view.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oDistrict_view.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oDistrict_view.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oDistrict_view.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oDistrict_view.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oDistrict_view.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oDistrict_view.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oDistrict_view.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oDistrict_view.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oDistrict_view.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oDistrict_view.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oDistrict_view.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oDistrict_view.View_type_setup = new Setup();
                        oDistrict_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oDistrict_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oDistrict_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oDistrict_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oDistrict_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oDistrict_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oDistrict_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oDistrict_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oDistrict_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oDistrict_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oDistrict_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oDistrict_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oDistrict_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oDistrict_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            return oList_District_view;
        }
        #endregion
        #region Get_District_view_By_DISTRICT_ID_Adv
        public List<District_view> Get_District_view_By_DISTRICT_ID_Adv(long? DISTRICT_ID)
        {
            List<District_view> oList_District_view = null;
            dynamic _params = new ExpandoObject();
            _params.DISTRICT_ID = DISTRICT_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_DISTRICT_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_District_view = new List<District_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                        oDistrict_view.District = new District();
                        oDistrict_view.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oDistrict_view.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oDistrict_view.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oDistrict_view.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oDistrict_view.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oDistrict_view.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oDistrict_view.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oDistrict_view.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oDistrict_view.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oDistrict_view.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oDistrict_view.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oDistrict_view.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oDistrict_view.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oDistrict_view.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oDistrict_view.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oDistrict_view.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oDistrict_view.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oDistrict_view.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oDistrict_view.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oDistrict_view.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oDistrict_view.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oDistrict_view.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oDistrict_view.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oDistrict_view.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oDistrict_view.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oDistrict_view.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oDistrict_view.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oDistrict_view.View_type_setup = new Setup();
                        oDistrict_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oDistrict_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oDistrict_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oDistrict_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oDistrict_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oDistrict_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oDistrict_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oDistrict_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oDistrict_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oDistrict_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oDistrict_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oDistrict_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oDistrict_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oDistrict_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            return oList_District_view;
        }
        #endregion
        #region Get_District_view_By_VIEW_TYPE_SETUP_ID_Adv
        public List<District_view> Get_District_view_By_VIEW_TYPE_SETUP_ID_Adv(long? VIEW_TYPE_SETUP_ID)
        {
            List<District_view> oList_District_view = null;
            dynamic _params = new ExpandoObject();
            _params.VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_VIEW_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_District_view = new List<District_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                        oDistrict_view.District = new District();
                        oDistrict_view.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oDistrict_view.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oDistrict_view.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oDistrict_view.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oDistrict_view.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oDistrict_view.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oDistrict_view.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oDistrict_view.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oDistrict_view.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oDistrict_view.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oDistrict_view.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oDistrict_view.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oDistrict_view.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oDistrict_view.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oDistrict_view.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oDistrict_view.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oDistrict_view.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oDistrict_view.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oDistrict_view.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oDistrict_view.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oDistrict_view.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oDistrict_view.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oDistrict_view.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oDistrict_view.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oDistrict_view.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oDistrict_view.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oDistrict_view.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oDistrict_view.View_type_setup = new Setup();
                        oDistrict_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oDistrict_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oDistrict_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oDistrict_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oDistrict_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oDistrict_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oDistrict_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oDistrict_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oDistrict_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oDistrict_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oDistrict_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oDistrict_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oDistrict_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oDistrict_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            return oList_District_view;
        }
        #endregion
        #region Get_District_view_By_OWNER_ID_IS_DELETED_Adv
        public List<District_view> Get_District_view_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<District_view> oList_District_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_District_view = new List<District_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                        oDistrict_view.District = new District();
                        oDistrict_view.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oDistrict_view.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oDistrict_view.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oDistrict_view.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oDistrict_view.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oDistrict_view.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oDistrict_view.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oDistrict_view.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oDistrict_view.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oDistrict_view.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oDistrict_view.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oDistrict_view.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oDistrict_view.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oDistrict_view.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oDistrict_view.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oDistrict_view.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oDistrict_view.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oDistrict_view.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oDistrict_view.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oDistrict_view.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oDistrict_view.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oDistrict_view.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oDistrict_view.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oDistrict_view.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oDistrict_view.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oDistrict_view.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oDistrict_view.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oDistrict_view.View_type_setup = new Setup();
                        oDistrict_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oDistrict_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oDistrict_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oDistrict_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oDistrict_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oDistrict_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oDistrict_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oDistrict_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oDistrict_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oDistrict_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oDistrict_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oDistrict_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oDistrict_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oDistrict_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            return oList_District_view;
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
        #region Get_District_By_OWNER_ID_IS_DELETED_Adv
        public List<District> Get_District_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<District> oList_District = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_District = new List<District>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                        oDistrict.Region = new Region();
                        oDistrict.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oDistrict.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oDistrict.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oDistrict.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oDistrict.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oDistrict.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oDistrict.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oDistrict.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oDistrict.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oDistrict.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oDistrict.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oDistrict.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oDistrict.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oDistrict.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oDistrict.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oDistrict.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oDistrict.Top_level = new Top_level();
                        oDistrict.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oDistrict.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oDistrict.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oDistrict.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oDistrict.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oDistrict.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oDistrict.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oDistrict.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oDistrict.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oDistrict.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oDistrict.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oDistrict.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oDistrict.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oDistrict.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oDistrict.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oDistrict.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_District.Add(oDistrict);
                    }
                }
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_OWNER_ID_Adv
        public List<District> Get_District_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<District> oList_District = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_District = new List<District>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                        oDistrict.Region = new Region();
                        oDistrict.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oDistrict.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oDistrict.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oDistrict.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oDistrict.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oDistrict.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oDistrict.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oDistrict.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oDistrict.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oDistrict.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oDistrict.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oDistrict.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oDistrict.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oDistrict.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oDistrict.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oDistrict.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oDistrict.Top_level = new Top_level();
                        oDistrict.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oDistrict.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oDistrict.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oDistrict.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oDistrict.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oDistrict.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oDistrict.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oDistrict.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oDistrict.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oDistrict.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oDistrict.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oDistrict.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oDistrict.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oDistrict.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oDistrict.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oDistrict.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_District.Add(oDistrict);
                    }
                }
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_REGION_ID_Adv
        public List<District> Get_District_By_REGION_ID_Adv(long? REGION_ID)
        {
            List<District> oList_District = null;
            dynamic _params = new ExpandoObject();
            _params.REGION_ID = REGION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_REGION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_District = new List<District>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                        oDistrict.Region = new Region();
                        oDistrict.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oDistrict.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oDistrict.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oDistrict.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oDistrict.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oDistrict.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oDistrict.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oDistrict.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oDistrict.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oDistrict.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oDistrict.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oDistrict.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oDistrict.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oDistrict.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oDistrict.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oDistrict.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oDistrict.Top_level = new Top_level();
                        oDistrict.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oDistrict.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oDistrict.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oDistrict.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oDistrict.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oDistrict.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oDistrict.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oDistrict.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oDistrict.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oDistrict.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oDistrict.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oDistrict.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oDistrict.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oDistrict.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oDistrict.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oDistrict.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_District.Add(oDistrict);
                    }
                }
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_TOP_LEVEL_ID_Adv
        public List<District> Get_District_By_TOP_LEVEL_ID_Adv(long? TOP_LEVEL_ID)
        {
            List<District> oList_District = null;
            dynamic _params = new ExpandoObject();
            _params.TOP_LEVEL_ID = TOP_LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_TOP_LEVEL_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_District = new List<District>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                        oDistrict.Region = new Region();
                        oDistrict.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oDistrict.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oDistrict.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oDistrict.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oDistrict.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oDistrict.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oDistrict.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oDistrict.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oDistrict.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oDistrict.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oDistrict.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oDistrict.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oDistrict.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oDistrict.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oDistrict.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oDistrict.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oDistrict.Top_level = new Top_level();
                        oDistrict.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oDistrict.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oDistrict.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oDistrict.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oDistrict.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oDistrict.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oDistrict.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oDistrict.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oDistrict.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oDistrict.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oDistrict.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oDistrict.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oDistrict.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oDistrict.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oDistrict.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oDistrict.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_District.Add(oDistrict);
                    }
                }
            }
            return oList_District;
        }
        #endregion
        #region Get_District_view_By_DISTRICT_ID_List_Adv
        public List<District_view> Get_District_view_By_DISTRICT_ID_List_Adv(IEnumerable<long?> DISTRICT_ID_LIST)
        {
            List<District_view> oList_District_view = null;
            if (DISTRICT_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DISTRICT_ID_LIST = string.Join(",", DISTRICT_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_DISTRICT_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_District_view = new List<District_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District_view oDistrict_view = new District_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                            oDistrict_view.District = new District();
                            oDistrict_view.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oDistrict_view.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oDistrict_view.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oDistrict_view.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oDistrict_view.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oDistrict_view.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oDistrict_view.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oDistrict_view.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oDistrict_view.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oDistrict_view.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oDistrict_view.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oDistrict_view.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oDistrict_view.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oDistrict_view.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oDistrict_view.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oDistrict_view.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oDistrict_view.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oDistrict_view.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oDistrict_view.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oDistrict_view.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oDistrict_view.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oDistrict_view.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oDistrict_view.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oDistrict_view.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oDistrict_view.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oDistrict_view.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oDistrict_view.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oDistrict_view.View_type_setup = new Setup();
                            oDistrict_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oDistrict_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oDistrict_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oDistrict_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oDistrict_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oDistrict_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oDistrict_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oDistrict_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oDistrict_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oDistrict_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oDistrict_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oDistrict_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oDistrict_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oDistrict_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_District_view.Add(oDistrict_view);
                        }
                    }
                }
            }
            return oList_District_view;
        }
        #endregion
        #region Get_District_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        public List<District_view> Get_District_view_By_VIEW_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST)
        {
            List<District_view> oList_District_view = null;
            if (VIEW_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIEW_TYPE_SETUP_ID_LIST = string.Join(",", VIEW_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_VIEW_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_District_view = new List<District_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District_view oDistrict_view = new District_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                            oDistrict_view.District = new District();
                            oDistrict_view.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                            oDistrict_view.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                            oDistrict_view.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                            oDistrict_view.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                            oDistrict_view.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                            oDistrict_view.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                            oDistrict_view.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                            oDistrict_view.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                            oDistrict_view.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                            oDistrict_view.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                            oDistrict_view.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                            oDistrict_view.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                            oDistrict_view.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                            oDistrict_view.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                            oDistrict_view.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                            oDistrict_view.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                            oDistrict_view.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                            oDistrict_view.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                            oDistrict_view.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                            oDistrict_view.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                            oDistrict_view.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                            oDistrict_view.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                            oDistrict_view.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                            oDistrict_view.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                            oDistrict_view.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                            oDistrict_view.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                            oDistrict_view.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                            oDistrict_view.View_type_setup = new Setup();
                            oDistrict_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oDistrict_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oDistrict_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oDistrict_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oDistrict_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oDistrict_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oDistrict_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oDistrict_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oDistrict_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oDistrict_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oDistrict_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oDistrict_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oDistrict_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oDistrict_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_District_view.Add(oDistrict_view);
                        }
                    }
                }
            }
            return oList_District_view;
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
        #region Get_District_By_REGION_ID_List_Adv
        public List<District> Get_District_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST)
        {
            List<District> oList_District = null;
            if (REGION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REGION_ID_LIST = string.Join(",", REGION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_REGION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_District = new List<District>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District oDistrict = new District();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                            oDistrict.Region = new Region();
                            oDistrict.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oDistrict.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oDistrict.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oDistrict.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oDistrict.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oDistrict.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oDistrict.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oDistrict.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oDistrict.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oDistrict.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oDistrict.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oDistrict.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oDistrict.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oDistrict.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oDistrict.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oDistrict.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oDistrict.Top_level = new Top_level();
                            oDistrict.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oDistrict.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oDistrict.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oDistrict.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oDistrict.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oDistrict.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oDistrict.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oDistrict.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oDistrict.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oDistrict.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oDistrict.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oDistrict.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oDistrict.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oDistrict.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oDistrict.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oDistrict.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oList_District.Add(oDistrict);
                        }
                    }
                }
            }
            return oList_District;
        }
        #endregion
        #region Get_District_By_TOP_LEVEL_ID_List_Adv
        public List<District> Get_District_By_TOP_LEVEL_ID_List_Adv(IEnumerable<long?> TOP_LEVEL_ID_LIST)
        {
            List<District> oList_District = null;
            if (TOP_LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.TOP_LEVEL_ID_LIST = string.Join(",", TOP_LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_TOP_LEVEL_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_District = new List<District>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            District oDistrict = new District();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                            oDistrict.Region = new Region();
                            oDistrict.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oDistrict.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oDistrict.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oDistrict.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oDistrict.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oDistrict.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oDistrict.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oDistrict.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oDistrict.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oDistrict.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oDistrict.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oDistrict.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oDistrict.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oDistrict.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oDistrict.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oDistrict.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oDistrict.Top_level = new Top_level();
                            oDistrict.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oDistrict.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oDistrict.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oDistrict.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oDistrict.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oDistrict.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oDistrict.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oDistrict.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oDistrict.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oDistrict.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oDistrict.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oDistrict.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oDistrict.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oDistrict.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oDistrict.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oDistrict.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oList_District.Add(oDistrict);
                        }
                    }
                }
            }
            return oList_District;
        }
        #endregion
        #region Get_District_view_By_Where_Adv
        public List<District_view> Get_District_view_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<District_view> oList_District_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_District_view = new List<District_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                        oDistrict_view.District = new District();
                        oDistrict_view.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oDistrict_view.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oDistrict_view.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oDistrict_view.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oDistrict_view.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oDistrict_view.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oDistrict_view.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oDistrict_view.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oDistrict_view.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oDistrict_view.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oDistrict_view.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oDistrict_view.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oDistrict_view.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oDistrict_view.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oDistrict_view.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oDistrict_view.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oDistrict_view.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oDistrict_view.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oDistrict_view.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oDistrict_view.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oDistrict_view.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oDistrict_view.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oDistrict_view.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oDistrict_view.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oDistrict_view.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oDistrict_view.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oDistrict_view.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oDistrict_view.View_type_setup = new Setup();
                        oDistrict_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oDistrict_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oDistrict_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oDistrict_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oDistrict_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oDistrict_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oDistrict_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oDistrict_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oDistrict_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oDistrict_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oDistrict_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oDistrict_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oDistrict_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oDistrict_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_District_view;
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
        #region Get_District_By_Where_Adv
        public List<District> Get_District_By_Where_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_District = new List<District>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                        oDistrict.Region = new Region();
                        oDistrict.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oDistrict.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oDistrict.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oDistrict.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oDistrict.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oDistrict.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oDistrict.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oDistrict.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oDistrict.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oDistrict.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oDistrict.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oDistrict.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oDistrict.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oDistrict.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oDistrict.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oDistrict.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oDistrict.Top_level = new Top_level();
                        oDistrict.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oDistrict.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oDistrict.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oDistrict.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oDistrict.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oDistrict.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oDistrict.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oDistrict.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oDistrict.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oDistrict.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oDistrict.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oDistrict.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oDistrict.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oDistrict.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oDistrict.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oDistrict.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_District.Add(oDistrict);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_District;
        }
        #endregion
        #region Get_District_view_By_Where_In_List_Adv
        public List<District_view> Get_District_view_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> DISTRICT_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_VIEW_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_District_view = new List<District_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District_view oDistrict_view = new District_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict_view);
                        oDistrict_view.District = new District();
                        oDistrict_view.District.DISTRICT_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_DISTRICT_ID");
                        oDistrict_view.District.REGION_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_REGION_ID");
                        oDistrict_view.District.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_TOP_LEVEL_ID");
                        oDistrict_view.District.NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_NAME");
                        oDistrict_view.District.LOCATION = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOCATION");
                        oDistrict_view.District.AREA = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_AREA");
                        oDistrict_view.District.UNIT = Get_Data_Record_Value<string>(element, "T_DISTRICT_UNIT");
                        oDistrict_view.District.SCALE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_SCALE");
                        oDistrict_view.District.ROTATIONX = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONX");
                        oDistrict_view.District.ROTATIONY = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONY");
                        oDistrict_view.District.ROTATIONZ = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_ROTATIONZ");
                        oDistrict_view.District.GLTF_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LATITUDE");
                        oDistrict_view.District.GLTF_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_GLTF_LONGITUDE");
                        oDistrict_view.District.CENTER_LATITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LATITUDE");
                        oDistrict_view.District.CENTER_LONGITUDE = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_CENTER_LONGITUDE");
                        oDistrict_view.District.RADIUS_IN_METERS = Get_Data_Record_Value<decimal?>(element, "T_DISTRICT_RADIUS_IN_METERS");
                        oDistrict_view.District.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_IMAGE_URL");
                        oDistrict_view.District.LOGO_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_LOGO_URL");
                        oDistrict_view.District.SOLID_GLTF_URL = Get_Data_Record_Value<string>(element, "T_DISTRICT_SOLID_GLTF_URL");
                        oDistrict_view.District.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_AREA_COLOR");
                        oDistrict_view.District.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_DISTRICT_BORDER_COLOR");
                        oDistrict_view.District.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_DISTRICT_STUDY_ZONE_NAME");
                        oDistrict_view.District.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DISTRICT_ENTRY_USER_ID");
                        oDistrict_view.District.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_ENTRY_DATE");
                        oDistrict_view.District.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DISTRICT_LAST_UPDATE");
                        oDistrict_view.District.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DISTRICT_IS_DELETED");
                        oDistrict_view.District.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DISTRICT_OWNER_ID");
                        oDistrict_view.View_type_setup = new Setup();
                        oDistrict_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oDistrict_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oDistrict_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oDistrict_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oDistrict_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oDistrict_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oDistrict_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oDistrict_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oDistrict_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oDistrict_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oDistrict_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oDistrict_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oDistrict_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oDistrict_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_District_view.Add(oDistrict_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_District_view;
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
        #region Get_District_By_Where_In_List_Adv
        public List<District> Get_District_By_Where_In_List_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string SOLID_GLTF_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DISTRICT_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_District = new List<District>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        District oDistrict = new District();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDistrict);
                        oDistrict.Region = new Region();
                        oDistrict.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oDistrict.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oDistrict.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oDistrict.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oDistrict.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oDistrict.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oDistrict.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oDistrict.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oDistrict.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oDistrict.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oDistrict.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oDistrict.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oDistrict.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oDistrict.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oDistrict.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oDistrict.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oDistrict.Top_level = new Top_level();
                        oDistrict.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oDistrict.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oDistrict.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oDistrict.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oDistrict.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oDistrict.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oDistrict.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oDistrict.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oDistrict.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oDistrict.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oDistrict.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oDistrict.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oDistrict.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oDistrict.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oDistrict.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oDistrict.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_District.Add(oDistrict);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_District;
        }
        #endregion
    }
}
