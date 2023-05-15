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
        #region Get_Site_field_logo_By_SITE_FIELD_LOGO_ID
        public Site_field_logo Get_Site_field_logo_By_SITE_FIELD_LOGO_ID(long? SITE_FIELD_LOGO_ID)
        {
            Site_field_logo oSite_field_logo = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_FIELD_LOGO_ID = SITE_FIELD_LOGO_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_SITE_FIELD_LOGO_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oSite_field_logo = new Site_field_logo();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oSite_field_logo);
            }
            return oSite_field_logo;
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
        #region Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List
        public List<Site_field_logo> Get_Site_field_logo_By_SITE_FIELD_LOGO_ID_List(IEnumerable<long?> SITE_FIELD_LOGO_ID_LIST)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            if (SITE_FIELD_LOGO_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_FIELD_LOGO_ID_LIST = string.Join(",", SITE_FIELD_LOGO_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_SITE_FIELD_LOGO_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site_field_logo = new List<Site_field_logo>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_field_logo oSite_field_logo = new Site_field_logo();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_field_logo);
                            oList_Site_field_logo.Add(oSite_field_logo);
                        }
                    }
                }
            }
            return oList_Site_field_logo;
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
        #region Get_Site_field_logo_By_OWNER_ID_IS_DELETED
        public List<Site_field_logo> Get_Site_field_logo_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_field_logo);
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_field_logo_By_OWNER_ID
        public List<Site_field_logo> Get_Site_field_logo_By_OWNER_ID(int? OWNER_ID)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_field_logo);
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            return oList_Site_field_logo;
        }
        #endregion
        #region Get_Site_field_logo_By_SITE_ID
        public List<Site_field_logo> Get_Site_field_logo_By_SITE_ID(long? SITE_ID)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            dynamic _params = new ExpandoObject();
            _params.SITE_ID = SITE_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_SITE_ID", _params);
            if (_query_response != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_field_logo);
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            return oList_Site_field_logo;
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
        #region Get_Site_field_logo_By_SITE_ID_List
        public List<Site_field_logo> Get_Site_field_logo_By_SITE_ID_List(IEnumerable<long?> SITE_ID_LIST)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            if (SITE_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SITE_ID_LIST = string.Join(",", SITE_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_SITE_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Site_field_logo = new List<Site_field_logo>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Site_field_logo oSite_field_logo = new Site_field_logo();
                            Props.Copy_Prop_Values_From_Data_Record(element, oSite_field_logo);
                            oList_Site_field_logo.Add(oSite_field_logo);
                        }
                    }
                }
            }
            return oList_Site_field_logo;
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
        #region Get_Site_field_logo_By_Where
        public List<Site_field_logo> Get_Site_field_logo_By_Where(string DESCRIPTION, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_field_logo);
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site_field_logo;
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
        #region Get_Site_field_logo_By_Where_In_List
        public List<Site_field_logo> Get_Site_field_logo_By_Where_In_List(string DESCRIPTION, IEnumerable<long?> SITE_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Site_field_logo> oList_Site_field_logo = null;
            dynamic _params = new ExpandoObject();
            _params.DESCRIPTION = DESCRIPTION;
            _params.SITE_ID_LIST = SITE_ID_LIST != null ? string.Join(",", SITE_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_SITE_FIELD_LOGO_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Site_field_logo = new List<Site_field_logo>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Site_field_logo oSite_field_logo = new Site_field_logo();
                        Props.Copy_Prop_Values_From_Data_Record(element, oSite_field_logo);
                        oList_Site_field_logo.Add(oSite_field_logo);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Site_field_logo;
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
        #region Delete_Site_field_logo
        public void Delete_Site_field_logo(long? SITE_FIELD_LOGO_ID)
        {
            var _params = new
            {
                SITE_FIELD_LOGO_ID = SITE_FIELD_LOGO_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_FIELD_LOGO", _params);
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
        #region Delete_Site_field_logo_By_OWNER_ID_IS_DELETED
        public void Delete_Site_field_logo_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_SITE_FIELD_LOGO_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Site_field_logo_By_OWNER_ID
        public void Delete_Site_field_logo_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_FIELD_LOGO_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Site_field_logo_By_SITE_ID
        public void Delete_Site_field_logo_By_SITE_ID(long? SITE_ID)
        {
            var _params = new
            {
                SITE_ID = SITE_ID
            };
            ExecuteDelete("UPG_DELETE_SITE_FIELD_LOGO_BY_SITE_ID", _params);
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
        #region Edit_Site_field_logo
        public long? Edit_Site_field_logo(long? SITE_FIELD_LOGO_ID, long? SITE_ID, decimal? LONGITUDE, decimal? LATITUDE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID, string DESCRIPTION)
        {
            Site_field_logo oSite_field_logo = new Site_field_logo()
            {
                SITE_FIELD_LOGO_ID = SITE_FIELD_LOGO_ID,
                SITE_ID = SITE_ID,
                LONGITUDE = LONGITUDE,
                LATITUDE = LATITUDE,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID,
                DESCRIPTION = DESCRIPTION
            };
            ExecuteEdit("UPG_EDIT_SITE_FIELD_LOGO", oSite_field_logo, "SITE_FIELD_LOGO_ID");
            return oSite_field_logo.SITE_FIELD_LOGO_ID;
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
