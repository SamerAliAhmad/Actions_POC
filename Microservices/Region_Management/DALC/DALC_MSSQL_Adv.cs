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
        #region Get_Region_By_REGION_ID_Adv
        public Region Get_Region_By_REGION_ID_Adv(long? REGION_ID)
        {
            Region oRegion = null;
            dynamic _params = new ExpandoObject();
            _params.REGION_ID = REGION_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_REGION_BY_REGION_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oRegion = new Region();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oRegion);
                oRegion.Top_level = new Top_level();
                oRegion.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_TOP_LEVEL_TOP_LEVEL_ID");
                oRegion.Top_level.NAME = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_NAME");
                oRegion.Top_level.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LOCATION");
                oRegion.Top_level.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_TOP_LEVEL_AREA");
                oRegion.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_IMAGE_URL");
                oRegion.Top_level.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LOGO_URL");
                oRegion.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_AREA_COLOR");
                oRegion.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_BORDER_COLOR");
                oRegion.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                oRegion.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_LOW_THRESHOLD");
                oRegion.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_HIGH_THRESHOLD");
                oRegion.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_TOP_LEVEL_ENTRY_USER_ID");
                oRegion.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_ENTRY_DATE");
                oRegion.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_TOP_LEVEL_LAST_UPDATE");
                oRegion.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_TOP_LEVEL_IS_DELETED");
                oRegion.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_TOP_LEVEL_OWNER_ID");
            }
            return oRegion;
        }
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID_Adv
        public Region_view Get_Region_view_By_REGION_VIEW_ID_Adv(long? REGION_VIEW_ID)
        {
            Region_view oRegion_view = null;
            dynamic _params = new ExpandoObject();
            _params.REGION_VIEW_ID = REGION_VIEW_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_REGION_VIEW_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oRegion_view = new Region_view();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oRegion_view);
                oRegion_view.Region = new Region();
                oRegion_view.Region.REGION_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_REGION_ID");
                oRegion_view.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_TOP_LEVEL_ID");
                oRegion_view.Region.NAME = Get_Data_Record_Value<string>(_query_response, "T_REGION_NAME");
                oRegion_view.Region.LOCATION = Get_Data_Record_Value<string>(_query_response, "T_REGION_LOCATION");
                oRegion_view.Region.AREA = Get_Data_Record_Value<decimal?>(_query_response, "T_REGION_AREA");
                oRegion_view.Region.UNIT = Get_Data_Record_Value<string>(_query_response, "T_REGION_UNIT");
                oRegion_view.Region.IMAGE_URL = Get_Data_Record_Value<string>(_query_response, "T_REGION_IMAGE_URL");
                oRegion_view.Region.LOGO_URL = Get_Data_Record_Value<string>(_query_response, "T_REGION_LOGO_URL");
                oRegion_view.Region.AREA_COLOR = Get_Data_Record_Value<string>(_query_response, "T_REGION_AREA_COLOR");
                oRegion_view.Region.BORDER_COLOR = Get_Data_Record_Value<string>(_query_response, "T_REGION_BORDER_COLOR");
                oRegion_view.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(_query_response, "T_REGION_STUDY_ZONE_NAME");
                oRegion_view.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_REGION_ENTRY_USER_ID");
                oRegion_view.Region.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_REGION_ENTRY_DATE");
                oRegion_view.Region.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_REGION_LAST_UPDATE");
                oRegion_view.Region.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_REGION_IS_DELETED");
                oRegion_view.Region.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_REGION_OWNER_ID");
                oRegion_view.View_type_setup = new Setup();
                oRegion_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIEW_TYPE_SETUP_SETUP_ID");
                oRegion_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                oRegion_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                oRegion_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                oRegion_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                oRegion_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_DELETED");
                oRegion_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                oRegion_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                oRegion_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_VALUE");
                oRegion_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                oRegion_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                oRegion_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                oRegion_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                oRegion_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_VIEW_TYPE_SETUP_OWNER_ID");
            }
            return oRegion_view;
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
        #region Get_Region_By_REGION_ID_List_Adv
        public List<Region> Get_Region_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST)
        {
            List<Region> oList_Region = null;
            if (REGION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REGION_ID_LIST = string.Join(",", REGION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_BY_REGION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Region = new List<Region>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Region oRegion = new Region();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRegion);
                            oRegion.Top_level = new Top_level();
                            oRegion.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oRegion.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oRegion.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oRegion.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oRegion.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oRegion.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oRegion.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oRegion.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oRegion.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oRegion.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oRegion.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oRegion.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oRegion.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oRegion.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oRegion.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oRegion.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oList_Region.Add(oRegion);
                        }
                    }
                }
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_view_By_REGION_VIEW_ID_List_Adv
        public List<Region_view> Get_Region_view_By_REGION_VIEW_ID_List_Adv(IEnumerable<long?> REGION_VIEW_ID_LIST)
        {
            List<Region_view> oList_Region_view = null;
            if (REGION_VIEW_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REGION_VIEW_ID_LIST = string.Join(",", REGION_VIEW_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_REGION_VIEW_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Region_view = new List<Region_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Region_view oRegion_view = new Region_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                            oRegion_view.Region = new Region();
                            oRegion_view.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oRegion_view.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oRegion_view.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oRegion_view.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oRegion_view.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oRegion_view.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oRegion_view.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oRegion_view.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oRegion_view.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oRegion_view.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oRegion_view.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oRegion_view.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oRegion_view.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oRegion_view.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oRegion_view.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oRegion_view.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oRegion_view.View_type_setup = new Setup();
                            oRegion_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oRegion_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oRegion_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oRegion_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oRegion_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oRegion_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oRegion_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oRegion_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oRegion_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oRegion_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oRegion_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oRegion_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oRegion_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oRegion_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_Region_view.Add(oRegion_view);
                        }
                    }
                }
            }
            return oList_Region_view;
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
        #region Get_Region_By_OWNER_ID_IS_DELETED_Adv
        public List<Region> Get_Region_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Region> oList_Region = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Region = new List<Region>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion);
                        oRegion.Top_level = new Top_level();
                        oRegion.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oRegion.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oRegion.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oRegion.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oRegion.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oRegion.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oRegion.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oRegion.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oRegion.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oRegion.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oRegion.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oRegion.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oRegion.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oRegion.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oRegion.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oRegion.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Region.Add(oRegion);
                    }
                }
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_By_OWNER_ID_Adv
        public List<Region> Get_Region_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Region> oList_Region = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Region = new List<Region>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion);
                        oRegion.Top_level = new Top_level();
                        oRegion.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oRegion.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oRegion.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oRegion.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oRegion.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oRegion.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oRegion.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oRegion.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oRegion.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oRegion.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oRegion.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oRegion.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oRegion.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oRegion.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oRegion.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oRegion.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Region.Add(oRegion);
                    }
                }
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_By_TOP_LEVEL_ID_Adv
        public List<Region> Get_Region_By_TOP_LEVEL_ID_Adv(long? TOP_LEVEL_ID)
        {
            List<Region> oList_Region = null;
            dynamic _params = new ExpandoObject();
            _params.TOP_LEVEL_ID = TOP_LEVEL_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_BY_TOP_LEVEL_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Region = new List<Region>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion);
                        oRegion.Top_level = new Top_level();
                        oRegion.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oRegion.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oRegion.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oRegion.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oRegion.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oRegion.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oRegion.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oRegion.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oRegion.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oRegion.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oRegion.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oRegion.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oRegion.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oRegion.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oRegion.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oRegion.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Region.Add(oRegion);
                    }
                }
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_view_By_OWNER_ID_Adv
        public List<Region_view> Get_Region_view_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Region_view> oList_Region_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Region_view = new List<Region_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                        oRegion_view.Region = new Region();
                        oRegion_view.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oRegion_view.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oRegion_view.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oRegion_view.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oRegion_view.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oRegion_view.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oRegion_view.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oRegion_view.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oRegion_view.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oRegion_view.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oRegion_view.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oRegion_view.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oRegion_view.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oRegion_view.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oRegion_view.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oRegion_view.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oRegion_view.View_type_setup = new Setup();
                        oRegion_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oRegion_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oRegion_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oRegion_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oRegion_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oRegion_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oRegion_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oRegion_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oRegion_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oRegion_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oRegion_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oRegion_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oRegion_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oRegion_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_REGION_ID_Adv
        public List<Region_view> Get_Region_view_By_REGION_ID_Adv(long? REGION_ID)
        {
            List<Region_view> oList_Region_view = null;
            dynamic _params = new ExpandoObject();
            _params.REGION_ID = REGION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_REGION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Region_view = new List<Region_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                        oRegion_view.Region = new Region();
                        oRegion_view.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oRegion_view.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oRegion_view.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oRegion_view.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oRegion_view.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oRegion_view.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oRegion_view.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oRegion_view.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oRegion_view.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oRegion_view.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oRegion_view.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oRegion_view.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oRegion_view.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oRegion_view.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oRegion_view.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oRegion_view.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oRegion_view.View_type_setup = new Setup();
                        oRegion_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oRegion_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oRegion_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oRegion_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oRegion_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oRegion_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oRegion_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oRegion_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oRegion_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oRegion_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oRegion_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oRegion_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oRegion_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oRegion_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_VIEW_TYPE_SETUP_ID_Adv
        public List<Region_view> Get_Region_view_By_VIEW_TYPE_SETUP_ID_Adv(long? VIEW_TYPE_SETUP_ID)
        {
            List<Region_view> oList_Region_view = null;
            dynamic _params = new ExpandoObject();
            _params.VIEW_TYPE_SETUP_ID = VIEW_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_VIEW_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Region_view = new List<Region_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                        oRegion_view.Region = new Region();
                        oRegion_view.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oRegion_view.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oRegion_view.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oRegion_view.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oRegion_view.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oRegion_view.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oRegion_view.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oRegion_view.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oRegion_view.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oRegion_view.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oRegion_view.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oRegion_view.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oRegion_view.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oRegion_view.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oRegion_view.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oRegion_view.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oRegion_view.View_type_setup = new Setup();
                        oRegion_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oRegion_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oRegion_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oRegion_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oRegion_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oRegion_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oRegion_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oRegion_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oRegion_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oRegion_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oRegion_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oRegion_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oRegion_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oRegion_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_OWNER_ID_IS_DELETED_Adv
        public List<Region_view> Get_Region_view_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Region_view> oList_Region_view = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Region_view = new List<Region_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                        oRegion_view.Region = new Region();
                        oRegion_view.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oRegion_view.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oRegion_view.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oRegion_view.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oRegion_view.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oRegion_view.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oRegion_view.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oRegion_view.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oRegion_view.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oRegion_view.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oRegion_view.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oRegion_view.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oRegion_view.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oRegion_view.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oRegion_view.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oRegion_view.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oRegion_view.View_type_setup = new Setup();
                        oRegion_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oRegion_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oRegion_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oRegion_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oRegion_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oRegion_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oRegion_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oRegion_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oRegion_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oRegion_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oRegion_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oRegion_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oRegion_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oRegion_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            return oList_Region_view;
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
        #region Get_Region_By_TOP_LEVEL_ID_List_Adv
        public List<Region> Get_Region_By_TOP_LEVEL_ID_List_Adv(IEnumerable<long?> TOP_LEVEL_ID_LIST)
        {
            List<Region> oList_Region = null;
            if (TOP_LEVEL_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.TOP_LEVEL_ID_LIST = string.Join(",", TOP_LEVEL_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_BY_TOP_LEVEL_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Region = new List<Region>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Region oRegion = new Region();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRegion);
                            oRegion.Top_level = new Top_level();
                            oRegion.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                            oRegion.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                            oRegion.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                            oRegion.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                            oRegion.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                            oRegion.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                            oRegion.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                            oRegion.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                            oRegion.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                            oRegion.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                            oRegion.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                            oRegion.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                            oRegion.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                            oRegion.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                            oRegion.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                            oRegion.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                            oList_Region.Add(oRegion);
                        }
                    }
                }
            }
            return oList_Region;
        }
        #endregion
        #region Get_Region_view_By_REGION_ID_List_Adv
        public List<Region_view> Get_Region_view_By_REGION_ID_List_Adv(IEnumerable<long?> REGION_ID_LIST)
        {
            List<Region_view> oList_Region_view = null;
            if (REGION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REGION_ID_LIST = string.Join(",", REGION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_REGION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Region_view = new List<Region_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Region_view oRegion_view = new Region_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                            oRegion_view.Region = new Region();
                            oRegion_view.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oRegion_view.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oRegion_view.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oRegion_view.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oRegion_view.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oRegion_view.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oRegion_view.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oRegion_view.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oRegion_view.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oRegion_view.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oRegion_view.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oRegion_view.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oRegion_view.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oRegion_view.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oRegion_view.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oRegion_view.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oRegion_view.View_type_setup = new Setup();
                            oRegion_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oRegion_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oRegion_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oRegion_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oRegion_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oRegion_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oRegion_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oRegion_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oRegion_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oRegion_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oRegion_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oRegion_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oRegion_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oRegion_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_Region_view.Add(oRegion_view);
                        }
                    }
                }
            }
            return oList_Region_view;
        }
        #endregion
        #region Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv
        public List<Region_view> Get_Region_view_By_VIEW_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST)
        {
            List<Region_view> oList_Region_view = null;
            if (VIEW_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.VIEW_TYPE_SETUP_ID_LIST = string.Join(",", VIEW_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_VIEW_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Region_view = new List<Region_view>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Region_view oRegion_view = new Region_view();
                            Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                            oRegion_view.Region = new Region();
                            oRegion_view.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                            oRegion_view.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                            oRegion_view.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                            oRegion_view.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                            oRegion_view.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                            oRegion_view.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                            oRegion_view.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                            oRegion_view.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                            oRegion_view.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                            oRegion_view.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                            oRegion_view.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                            oRegion_view.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                            oRegion_view.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                            oRegion_view.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                            oRegion_view.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                            oRegion_view.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                            oRegion_view.View_type_setup = new Setup();
                            oRegion_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                            oRegion_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oRegion_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                            oRegion_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                            oRegion_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                            oRegion_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                            oRegion_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                            oRegion_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                            oRegion_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                            oRegion_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                            oRegion_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                            oRegion_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                            oRegion_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                            oRegion_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                            oList_Region_view.Add(oRegion_view);
                        }
                    }
                }
            }
            return oList_Region_view;
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
        #region Get_Region_By_Where_Adv
        public List<Region> Get_Region_By_Where_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Region = new List<Region>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion);
                        oRegion.Top_level = new Top_level();
                        oRegion.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oRegion.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oRegion.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oRegion.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oRegion.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oRegion.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oRegion.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oRegion.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oRegion.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oRegion.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oRegion.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oRegion.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oRegion.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oRegion.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oRegion.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oRegion.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Region.Add(oRegion);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Region;
        }
        #endregion
        #region Get_Region_view_By_Where_Adv
        public List<Region_view> Get_Region_view_By_Where_Adv(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Region_view> oList_Region_view = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Region_view = new List<Region_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                        oRegion_view.Region = new Region();
                        oRegion_view.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oRegion_view.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oRegion_view.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oRegion_view.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oRegion_view.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oRegion_view.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oRegion_view.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oRegion_view.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oRegion_view.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oRegion_view.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oRegion_view.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oRegion_view.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oRegion_view.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oRegion_view.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oRegion_view.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oRegion_view.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oRegion_view.View_type_setup = new Setup();
                        oRegion_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oRegion_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oRegion_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oRegion_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oRegion_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oRegion_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oRegion_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oRegion_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oRegion_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oRegion_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oRegion_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oRegion_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oRegion_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oRegion_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Region_view;
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
        #region Get_Region_By_Where_In_List_Adv
        public List<Region> Get_Region_By_Where_In_List_Adv(string NAME, string LOCATION, string UNIT, string IMAGE_URL, string LOGO_URL, string AREA_COLOR, string BORDER_COLOR, string STUDY_ZONE_NAME, IEnumerable<long?> TOP_LEVEL_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Region = new List<Region>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region oRegion = new Region();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion);
                        oRegion.Top_level = new Top_level();
                        oRegion.Top_level.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_TOP_LEVEL_ID");
                        oRegion.Top_level.NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_NAME");
                        oRegion.Top_level.LOCATION = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOCATION");
                        oRegion.Top_level.AREA = Get_Data_Record_Value<decimal?>(element, "T_TOP_LEVEL_AREA");
                        oRegion.Top_level.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_IMAGE_URL");
                        oRegion.Top_level.LOGO_URL = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LOGO_URL");
                        oRegion.Top_level.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_AREA_COLOR");
                        oRegion.Top_level.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_BORDER_COLOR");
                        oRegion.Top_level.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_STUDY_ZONE_NAME");
                        oRegion.Top_level.LOW_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_LOW_THRESHOLD");
                        oRegion.Top_level.HIGH_THRESHOLD = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_HIGH_THRESHOLD");
                        oRegion.Top_level.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_TOP_LEVEL_ENTRY_USER_ID");
                        oRegion.Top_level.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_ENTRY_DATE");
                        oRegion.Top_level.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_TOP_LEVEL_LAST_UPDATE");
                        oRegion.Top_level.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_TOP_LEVEL_IS_DELETED");
                        oRegion.Top_level.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_TOP_LEVEL_OWNER_ID");
                        oList_Region.Add(oRegion);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Region;
        }
        #endregion
        #region Get_Region_view_By_Where_In_List_Adv
        public List<Region_view> Get_Region_view_By_Where_In_List_Adv(string DESCRIPTION, IEnumerable<long?> REGION_ID_LIST, IEnumerable<long?> VIEW_TYPE_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REGION_VIEW_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Region_view = new List<Region_view>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Region_view oRegion_view = new Region_view();
                        Props.Copy_Prop_Values_From_Data_Record(element, oRegion_view);
                        oRegion_view.Region = new Region();
                        oRegion_view.Region.REGION_ID = Get_Data_Record_Value<long?>(element, "T_REGION_REGION_ID");
                        oRegion_view.Region.TOP_LEVEL_ID = Get_Data_Record_Value<long?>(element, "T_REGION_TOP_LEVEL_ID");
                        oRegion_view.Region.NAME = Get_Data_Record_Value<string>(element, "T_REGION_NAME");
                        oRegion_view.Region.LOCATION = Get_Data_Record_Value<string>(element, "T_REGION_LOCATION");
                        oRegion_view.Region.AREA = Get_Data_Record_Value<decimal?>(element, "T_REGION_AREA");
                        oRegion_view.Region.UNIT = Get_Data_Record_Value<string>(element, "T_REGION_UNIT");
                        oRegion_view.Region.IMAGE_URL = Get_Data_Record_Value<string>(element, "T_REGION_IMAGE_URL");
                        oRegion_view.Region.LOGO_URL = Get_Data_Record_Value<string>(element, "T_REGION_LOGO_URL");
                        oRegion_view.Region.AREA_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_AREA_COLOR");
                        oRegion_view.Region.BORDER_COLOR = Get_Data_Record_Value<string>(element, "T_REGION_BORDER_COLOR");
                        oRegion_view.Region.STUDY_ZONE_NAME = Get_Data_Record_Value<string>(element, "T_REGION_STUDY_ZONE_NAME");
                        oRegion_view.Region.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_REGION_ENTRY_USER_ID");
                        oRegion_view.Region.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_REGION_ENTRY_DATE");
                        oRegion_view.Region.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_REGION_LAST_UPDATE");
                        oRegion_view.Region.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_REGION_IS_DELETED");
                        oRegion_view.Region.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_REGION_OWNER_ID");
                        oRegion_view.View_type_setup = new Setup();
                        oRegion_view.View_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_SETUP_ID");
                        oRegion_view.View_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oRegion_view.View_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_SYSTEM");
                        oRegion_view.View_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETEABLE");
                        oRegion_view.View_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_UPDATEABLE");
                        oRegion_view.View_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_DELETED");
                        oRegion_view.View_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_VIEW_TYPE_SETUP_IS_VISIBLE");
                        oRegion_view.View_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_DISPLAY_ORDER");
                        oRegion_view.View_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_VALUE");
                        oRegion_view.View_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_DESCRIPTION");
                        oRegion_view.View_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_VIEW_TYPE_SETUP_ENTRY_USER_ID");
                        oRegion_view.View_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_ENTRY_DATE");
                        oRegion_view.View_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_VIEW_TYPE_SETUP_LAST_UPDATE");
                        oRegion_view.View_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_VIEW_TYPE_SETUP_OWNER_ID");
                        oList_Region_view.Add(oRegion_view);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Region_view;
        }
        #endregion
    }
}
