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
    }
}
