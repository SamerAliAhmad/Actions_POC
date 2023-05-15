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
    }
}
