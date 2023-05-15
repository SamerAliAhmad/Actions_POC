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
        #region Get_Report_By_REPORT_ID_Adv
        public Report Get_Report_By_REPORT_ID_Adv(int? REPORT_ID)
        {
            Report oReport = null;
            dynamic _params = new ExpandoObject();
            _params.REPORT_ID = REPORT_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_REPORT_BY_REPORT_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oReport = new Report();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oReport);
                oReport.Dimension = new Dimension();
                oReport.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(_query_response, "T_DIMENSION_DIMENSION_ID");
                oReport.Dimension.NAME = Get_Data_Record_Value<string>(_query_response, "T_DIMENSION_NAME");
                oReport.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(_query_response, "T_DIMENSION_DIMENSION_ICON");
                oReport.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_DIMENSION_DIMENSION_ORDER");
                oReport.Dimension.ICON_URL = Get_Data_Record_Value<string>(_query_response, "T_DIMENSION_ICON_URL");
                oReport.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(_query_response, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                oReport.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_DIMENSION_ENTRY_USER_ID");
                oReport.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_DIMENSION_ENTRY_DATE");
                oReport.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_DIMENSION_LAST_UPDATE");
                oReport.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_DIMENSION_IS_DELETED");
                oReport.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_DIMENSION_OWNER_ID");
            }
            return oReport;
        }
        #endregion
        #region Get_Report_By_REPORT_ID_List_Adv
        public List<Report> Get_Report_By_REPORT_ID_List_Adv(IEnumerable<int?> REPORT_ID_LIST)
        {
            List<Report> oList_Report = null;
            if (REPORT_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.REPORT_ID_LIST = string.Join(",", REPORT_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_REPORT_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Report = new List<Report>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Report oReport = new Report();
                            Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                            oReport.Dimension = new Dimension();
                            oReport.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                            oReport.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                            oReport.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                            oReport.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                            oReport.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                            oReport.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                            oReport.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                            oReport.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                            oReport.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                            oReport.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                            oReport.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                            oList_Report.Add(oReport);
                        }
                    }
                }
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_OWNER_ID_Adv
        public List<Report> Get_Report_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Report> oList_Report = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Report = new List<Report>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                        oReport.Dimension = new Dimension();
                        oReport.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oReport.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oReport.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oReport.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oReport.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oReport.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oReport.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oReport.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oReport.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oReport.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oReport.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oList_Report.Add(oReport);
                    }
                }
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_DIMENSION_ID_Adv
        public List<Report> Get_Report_By_DIMENSION_ID_Adv(int? DIMENSION_ID)
        {
            List<Report> oList_Report = null;
            dynamic _params = new ExpandoObject();
            _params.DIMENSION_ID = DIMENSION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_DIMENSION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Report = new List<Report>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                        oReport.Dimension = new Dimension();
                        oReport.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oReport.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oReport.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oReport.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oReport.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oReport.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oReport.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oReport.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oReport.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oReport.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oReport.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oList_Report.Add(oReport);
                    }
                }
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_OWNER_ID_IS_DELETED_Adv
        public List<Report> Get_Report_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Report> oList_Report = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Report = new List<Report>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                        oReport.Dimension = new Dimension();
                        oReport.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oReport.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oReport.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oReport.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oReport.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oReport.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oReport.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oReport.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oReport.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oReport.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oReport.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oList_Report.Add(oReport);
                    }
                }
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_IDENTIFIER_TOKEN_Adv
        public List<Report> Get_Report_By_IDENTIFIER_TOKEN_Adv(string IDENTIFIER_TOKEN)
        {
            List<Report> oList_Report = null;
            dynamic _params = new ExpandoObject();
            _params.IDENTIFIER_TOKEN = IDENTIFIER_TOKEN;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_IDENTIFIER_TOKEN_ADV", _params);
            if (_query_response != null)
            {
                oList_Report = new List<Report>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                        oReport.Dimension = new Dimension();
                        oReport.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oReport.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oReport.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oReport.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oReport.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oReport.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oReport.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oReport.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oReport.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oReport.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oReport.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oList_Report.Add(oReport);
                    }
                }
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_DIMENSION_ID_List_Adv
        public List<Report> Get_Report_By_DIMENSION_ID_List_Adv(IEnumerable<int?> DIMENSION_ID_LIST)
        {
            List<Report> oList_Report = null;
            if (DIMENSION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DIMENSION_ID_LIST = string.Join(",", DIMENSION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_DIMENSION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Report = new List<Report>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Report oReport = new Report();
                            Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                            oReport.Dimension = new Dimension();
                            oReport.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                            oReport.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                            oReport.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                            oReport.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                            oReport.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                            oReport.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                            oReport.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                            oReport.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                            oReport.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                            oReport.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                            oReport.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                            oList_Report.Add(oReport);
                        }
                    }
                }
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_Where_Adv
        public List<Report> Get_Report_By_Where_Adv(string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Report = new List<Report>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                        oReport.Dimension = new Dimension();
                        oReport.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oReport.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oReport.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oReport.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oReport.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oReport.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oReport.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oReport.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oReport.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oReport.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oReport.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oList_Report.Add(oReport);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_Where_In_List_Adv
        public List<Report> Get_Report_By_Where_In_List_Adv(string FILE_NAME, string FILE_EXTENSION, string FILE_SIZE, string IDENTIFIER_TOKEN, IEnumerable<int?> DIMENSION_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_REPORT_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Report = new List<Report>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values_From_Data_Record(element, oReport);
                        oReport.Dimension = new Dimension();
                        oReport.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oReport.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oReport.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oReport.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oReport.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oReport.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oReport.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oReport.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oReport.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oReport.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oReport.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oList_Report.Add(oReport);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Report;
        }
        #endregion
    }
}
