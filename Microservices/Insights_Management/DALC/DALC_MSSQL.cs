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
        #region Get_Correlation_method_By_CORRELATION_METHOD_ID
        public Correlation_method Get_Correlation_method_By_CORRELATION_METHOD_ID(int? CORRELATION_METHOD_ID)
        {
            Correlation_method oCorrelation_method = null;
            dynamic _params = new ExpandoObject();
            _params.CORRELATION_METHOD_ID = CORRELATION_METHOD_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_CORRELATION_METHOD_BY_CORRELATION_METHOD_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oCorrelation_method = new Correlation_method();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oCorrelation_method);
            }
            return oCorrelation_method;
        }
        #endregion
        #region Get_Correlation_method_By_CORRELATION_METHOD_ID_List
        public List<Correlation_method> Get_Correlation_method_By_CORRELATION_METHOD_ID_List(IEnumerable<int?> CORRELATION_METHOD_ID_LIST)
        {
            List<Correlation_method> oList_Correlation_method = null;
            if (CORRELATION_METHOD_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.CORRELATION_METHOD_ID_LIST = string.Join(",", CORRELATION_METHOD_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_CORRELATION_METHOD_BY_CORRELATION_METHOD_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Correlation_method = new List<Correlation_method>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Correlation_method oCorrelation_method = new Correlation_method();
                            Props.Copy_Prop_Values_From_Data_Record(element, oCorrelation_method);
                            oList_Correlation_method.Add(oCorrelation_method);
                        }
                    }
                }
            }
            return oList_Correlation_method;
        }
        #endregion
        #region Get_Correlation_method_By_OWNER_ID
        public List<Correlation_method> Get_Correlation_method_By_OWNER_ID(int? OWNER_ID)
        {
            List<Correlation_method> oList_Correlation_method = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_CORRELATION_METHOD_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Correlation_method = new List<Correlation_method>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Correlation_method oCorrelation_method = new Correlation_method();
                        Props.Copy_Prop_Values_From_Data_Record(element, oCorrelation_method);
                        oList_Correlation_method.Add(oCorrelation_method);
                    }
                }
            }
            return oList_Correlation_method;
        }
        #endregion
        #region Get_Correlation_method_By_OWNER_ID_IS_DELETED
        public List<Correlation_method> Get_Correlation_method_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Correlation_method> oList_Correlation_method = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_CORRELATION_METHOD_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Correlation_method = new List<Correlation_method>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Correlation_method oCorrelation_method = new Correlation_method();
                        Props.Copy_Prop_Values_From_Data_Record(element, oCorrelation_method);
                        oList_Correlation_method.Add(oCorrelation_method);
                    }
                }
            }
            return oList_Correlation_method;
        }
        #endregion
        #region Get_Correlation_method_By_Where
        public List<Correlation_method> Get_Correlation_method_By_Where(string NAME, string DESCRIPTION, string EQUATION_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Correlation_method> oList_Correlation_method = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.DESCRIPTION = DESCRIPTION;
            _params.EQUATION_URL = EQUATION_URL;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_CORRELATION_METHOD_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Correlation_method = new List<Correlation_method>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Correlation_method oCorrelation_method = new Correlation_method();
                        Props.Copy_Prop_Values_From_Data_Record(element, oCorrelation_method);
                        oList_Correlation_method.Add(oCorrelation_method);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Correlation_method;
        }
        #endregion
        #region Delete_Correlation_method
        public void Delete_Correlation_method(int? CORRELATION_METHOD_ID)
        {
            var _params = new
            {
                CORRELATION_METHOD_ID = CORRELATION_METHOD_ID
            };
            ExecuteDelete("UPG_DELETE_CORRELATION_METHOD", _params);
        }
        #endregion
        #region Delete_Correlation_method_By_OWNER_ID
        public void Delete_Correlation_method_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_CORRELATION_METHOD_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Correlation_method_By_OWNER_ID_IS_DELETED
        public void Delete_Correlation_method_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_CORRELATION_METHOD_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Edit_Correlation_method
        public int? Edit_Correlation_method(int? CORRELATION_METHOD_ID, string NAME, string DESCRIPTION, string EQUATION_URL, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Correlation_method oCorrelation_method = new Correlation_method()
            {
                CORRELATION_METHOD_ID = CORRELATION_METHOD_ID,
                NAME = NAME,
                DESCRIPTION = DESCRIPTION,
                EQUATION_URL = EQUATION_URL,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_CORRELATION_METHOD", oCorrelation_method, "CORRELATION_METHOD_ID");
            return oCorrelation_method.CORRELATION_METHOD_ID;
        }
        #endregion
    }
}
