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
        #region Get_Report_By_REPORT_ID
        public Report Get_Report_By_REPORT_ID(int? REPORT_ID)
        {
            Report oReport = null;
            dynamic _params = new ExpandoObject();
            _params.REPORT_ID = REPORT_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_REPORT_BY_REPORT_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oReport = new Report();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oReport);
            }
            return oReport;
        }
        #endregion
        #region Get_Report_By_REPORT_ID_List
        public List<Report> Get_Report_By_REPORT_ID_List(IEnumerable<int?> REPORT_ID_LIST)
        {
            List<Report> oList_Report = null;
            if (REPORT_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REPORT_ID_LIST = string.Join(",", REPORT_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_REPORT_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Report = new List<Report>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Report oReport = new Report();
                            Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                            oList_Report.Add(oReport);
                        }
                    }
                }
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_OWNER_ID
        public List<Report> Get_Report_By_OWNER_ID(int? OWNER_ID)
        {
            List<Report> oList_Report = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Report = new List<Report>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                        oList_Report.Add(oReport);
                    }
                }
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_DIMENSION_ID
        public List<Report> Get_Report_By_DIMENSION_ID(int? DIMENSION_ID)
        {
            List<Report> oList_Report = null;
            dynamic _params = new ExpandoObject();
            _params.DIMENSION_ID = DIMENSION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_DIMENSION_ID", _params);
            if (_query_response != null)
            {
                oList_Report = new List<Report>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                        oList_Report.Add(oReport);
                    }
                }
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_OWNER_ID_IS_DELETED
        public List<Report> Get_Report_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Report> oList_Report = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Report = new List<Report>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                        oList_Report.Add(oReport);
                    }
                }
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_IDENTIFIER_TOKEN
        public List<Report> Get_Report_By_IDENTIFIER_TOKEN(string IDENTIFIER_TOKEN)
        {
            List<Report> oList_Report = null;
            dynamic _params = new ExpandoObject();
            _params.IDENTIFIER_TOKEN = IDENTIFIER_TOKEN;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_IDENTIFIER_TOKEN", _params);
            if (_query_response != null)
            {
                oList_Report = new List<Report>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                        oList_Report.Add(oReport);
                    }
                }
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_DIMENSION_ID_List
        public List<Report> Get_Report_By_DIMENSION_ID_List(IEnumerable<int?> DIMENSION_ID_LIST)
        {
            List<Report> oList_Report = null;
            if (DIMENSION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DIMENSION_ID_LIST = string.Join(",", DIMENSION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_DIMENSION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Report = new List<Report>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Report oReport = new Report();
                            Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                            oList_Report.Add(oReport);
                        }
                    }
                }
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_Where
        public List<Report> Get_Report_By_Where(string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Report> oList_Report = null;
            dynamic _params = new ExpandoObject();
            _params.FILE_NAME = FILE_NAME;
            _params.FILE_EXTENSION = FILE_EXTENSION;
            _params.FILE_SIZE = FILE_SIZE;
            _params.IDENTIFIER_TOKEN = IDENTIFIER_TOKEN;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Report = new List<Report>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                        oList_Report.Add(oReport);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_Where_In_List
        public List<Report> Get_Report_By_Where_In_List(string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, IEnumerable<int?> DIMENSION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Report> oList_Report = null;
            dynamic _params = new ExpandoObject();
            _params.FILE_NAME = FILE_NAME;
            _params.FILE_EXTENSION = FILE_EXTENSION;
            _params.FILE_SIZE = FILE_SIZE;
            _params.IDENTIFIER_TOKEN = IDENTIFIER_TOKEN;
            _params.DIMENSION_ID_LIST = DIMENSION_ID_LIST != null ? string.Join(",", DIMENSION_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Report = new List<Report>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                        oList_Report.Add(oReport);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Report;
        }
        #endregion
        #region Delete_Report
        public void Delete_Report(int? REPORT_ID)
        {
            var _params = new
            {
                REPORT_ID = REPORT_ID
            };
            ExecuteDelete("UPG_DELETE_REPORT", _params);
        }
        #endregion
        #region Delete_Report_By_OWNER_ID
        public void Delete_Report_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_REPORT_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Report_By_DIMENSION_ID
        public void Delete_Report_By_DIMENSION_ID(int? DIMENSION_ID)
        {
            var _params = new
            {
                DIMENSION_ID = DIMENSION_ID
            };
            ExecuteDelete("UPG_DELETE_REPORT_BY_DIMENSION_ID", _params);
        }
        #endregion
        #region Delete_Report_By_OWNER_ID_IS_DELETED
        public void Delete_Report_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_REPORT_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Report_By_IDENTIFIER_TOKEN
        public void Delete_Report_By_IDENTIFIER_TOKEN(string IDENTIFIER_TOKEN)
        {
            var _params = new
            {
                IDENTIFIER_TOKEN = IDENTIFIER_TOKEN
            };
            ExecuteDelete("UPG_DELETE_REPORT_BY_IDENTIFIER_TOKEN", _params);
        }
        #endregion
        #region Edit_Report
        public int? Edit_Report(int? REPORT_ID, int? DIMENSION_ID, string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Report oReport = new Report()
            {
                REPORT_ID = REPORT_ID,
                DIMENSION_ID = DIMENSION_ID,
                FILE_NAME = FILE_NAME,
                FILE_EXTENSION = FILE_EXTENSION,
                FILE_SIZE = FILE_SIZE,
                IDENTIFIER_TOKEN = IDENTIFIER_TOKEN,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_REPORT", oReport, "REPORT_ID");
            return oReport.REPORT_ID;
        }
        #endregion
    }
}
