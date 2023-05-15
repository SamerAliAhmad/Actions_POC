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
        #region Get_Method_run_By_METHOD_RUN_ID
        public Method_run Get_Method_run_By_METHOD_RUN_ID(long? METHOD_RUN_ID)
        {
            Method_run oMethod_run = null;
            dynamic _params = new ExpandoObject();
            _params.METHOD_RUN_ID = METHOD_RUN_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_METHOD_RUN_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oMethod_run = new Method_run();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oMethod_run);
            }
            return oMethod_run;
        }
        #endregion
        #region Get_Method_run_By_METHOD_RUN_ID_List
        public List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List(IEnumerable<long?> METHOD_RUN_ID_LIST)
        {
            List<Method_run> oList_Method_run = null;
            if (METHOD_RUN_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.METHOD_RUN_ID_LIST = string.Join(",", METHOD_RUN_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_METHOD_RUN_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Method_run = new List<Method_run>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Method_run oMethod_run = new Method_run();
                            Props.Copy_Prop_Values_From_Data_Record(element, oMethod_run);
                            oList_Method_run.Add(oMethod_run);
                        }
                    }
                }
            }
            return oList_Method_run;
        }
        #endregion
        #region Get_Method_run_By_OWNER_ID
        public List<Method_run> Get_Method_run_By_OWNER_ID(int? OWNER_ID)
        {
            List<Method_run> oList_Method_run = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Method_run = new List<Method_run>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Method_run oMethod_run = new Method_run();
                        Props.Copy_Prop_Values_From_Data_Record(element, oMethod_run);
                        oList_Method_run.Add(oMethod_run);
                    }
                }
            }
            return oList_Method_run;
        }
        #endregion
        #region Get_Method_run_By_OWNER_ID_IS_DELETED
        public List<Method_run> Get_Method_run_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Method_run> oList_Method_run = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Method_run = new List<Method_run>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Method_run oMethod_run = new Method_run();
                        Props.Copy_Prop_Values_From_Data_Record(element, oMethod_run);
                        oList_Method_run.Add(oMethod_run);
                    }
                }
            }
            return oList_Method_run;
        }
        #endregion
        #region Get_Method_run_By_Where
        public List<Method_run> Get_Method_run_By_Where(string METHOD_NAME, string METHOD_PARAMS, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Method_run> oList_Method_run = null;
            dynamic _params = new ExpandoObject();
            _params.METHOD_NAME = METHOD_NAME;
            _params.METHOD_PARAMS = METHOD_PARAMS;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_METHOD_RUN_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Method_run = new List<Method_run>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Method_run oMethod_run = new Method_run();
                        Props.Copy_Prop_Values_From_Data_Record(element, oMethod_run);
                        oList_Method_run.Add(oMethod_run);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Method_run;
        }
        #endregion
        #region Delete_Method_run
        public void Delete_Method_run(long? METHOD_RUN_ID)
        {
            var _params = new
            {
                METHOD_RUN_ID = METHOD_RUN_ID
            };
            ExecuteDelete("UPG_DELETE_METHOD_RUN", _params);
        }
        #endregion
        #region Delete_Method_run_By_OWNER_ID
        public void Delete_Method_run_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_METHOD_RUN_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Method_run_By_OWNER_ID_IS_DELETED
        public void Delete_Method_run_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_METHOD_RUN_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Edit_Method_run
        public long? Edit_Method_run(long? METHOD_RUN_ID, string METHOD_NAME, string RUN_DATE, int? RUN_HOUR, int? RUN_MINUTE, int? RUN_SECOND, int? EXECUTION_TIME, bool IS_CACHED, string METHOD_PARAMS, long? ENTRY_USER_ID, string ENTRY_DATE, int? OWNER_ID, string LAST_UPDATE, bool IS_DELETED)
        {
            Method_run oMethod_run = new Method_run()
            {
                METHOD_RUN_ID = METHOD_RUN_ID,
                METHOD_NAME = METHOD_NAME,
                RUN_DATE = RUN_DATE,
                RUN_HOUR = RUN_HOUR,
                RUN_MINUTE = RUN_MINUTE,
                RUN_SECOND = RUN_SECOND,
                EXECUTION_TIME = EXECUTION_TIME,
                IS_CACHED = IS_CACHED,
                METHOD_PARAMS = METHOD_PARAMS,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                OWNER_ID = OWNER_ID,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED
            };
            ExecuteEdit("UPG_EDIT_METHOD_RUN", oMethod_run, "METHOD_RUN_ID");
            return oMethod_run.METHOD_RUN_ID;
        }
        #endregion
    }
}
