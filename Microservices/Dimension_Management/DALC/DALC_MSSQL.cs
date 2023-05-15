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
        #region Get_Kpi_By_KPI_ID
        public Kpi Get_Kpi_By_KPI_ID(int? KPI_ID)
        {
            Kpi oKpi = null;
            dynamic _params = new ExpandoObject();
            _params.KPI_ID = KPI_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_KPI_BY_KPI_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oKpi = new Kpi();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oKpi);
            }
            return oKpi;
        }
        #endregion
        #region Get_Dimension_By_DIMENSION_ID
        public Dimension Get_Dimension_By_DIMENSION_ID(int? DIMENSION_ID)
        {
            Dimension oDimension = null;
            dynamic _params = new ExpandoObject();
            _params.DIMENSION_ID = DIMENSION_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_DIMENSION_BY_DIMENSION_ID", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oDimension = new Dimension();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oDimension);
            }
            return oDimension;
        }
        #endregion
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
        #region Get_Kpi_By_KPI_ID_List
        public List<Kpi> Get_Kpi_By_KPI_ID_List(IEnumerable<int?> KPI_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.KPI_ID_LIST = string.Join(",", KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_KPI_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Dimension_By_DIMENSION_ID_List
        public List<Dimension> Get_Dimension_By_DIMENSION_ID_List(IEnumerable<int?> DIMENSION_ID_LIST)
        {
            List<Dimension> oList_Dimension = null;
            if (DIMENSION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DIMENSION_ID_LIST = string.Join(",", DIMENSION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DIMENSION_BY_DIMENSION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Dimension = new List<Dimension>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Dimension oDimension = new Dimension();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDimension);
                            oList_Dimension.Add(oDimension);
                        }
                    }
                }
            }
            return oList_Dimension;
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
        #region Get_Kpi_By_OWNER_ID
        public List<Kpi> Get_Kpi_By_OWNER_ID(int? OWNER_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_DIMENSION_ID
        public List<Kpi> Get_Kpi_By_DIMENSION_ID(int? DIMENSION_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DIMENSION_ID = DIMENSION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_DIMENSION_ID", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID
        public List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_SETUP_CATEGORY_ID", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
        public List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(long? MIN_DATA_LEVEL_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.MIN_DATA_LEVEL_SETUP_ID = MIN_DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_MIN_DATA_LEVEL_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
        public List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(long? MAX_DATA_LEVEL_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.MAX_DATA_LEVEL_SETUP_ID = MAX_DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_MAX_DATA_LEVEL_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_OWNER_ID_IS_DELETED
        public List<Kpi> Get_Kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID
        public List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID(long? KPI_TYPE_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.KPI_TYPE_SETUP_ID = KPI_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_KPI_TYPE_SETUP_ID", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Dimension_By_OWNER_ID
        public List<Dimension> Get_Dimension_By_OWNER_ID(int? OWNER_ID)
        {
            List<Dimension> oList_Dimension = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DIMENSION_BY_OWNER_ID", _params);
            if (_query_response != null)
            {
                oList_Dimension = new List<Dimension>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Dimension oDimension = new Dimension();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDimension);
                        oList_Dimension.Add(oDimension);
                    }
                }
            }
            return oList_Dimension;
        }
        #endregion
        #region Get_Dimension_By_OWNER_ID_IS_DELETED
        public List<Dimension> Get_Dimension_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            List<Dimension> oList_Dimension = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DIMENSION_BY_OWNER_ID_IS_DELETED", _params);
            if (_query_response != null)
            {
                oList_Dimension = new List<Dimension>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Dimension oDimension = new Dimension();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDimension);
                        oList_Dimension.Add(oDimension);
                    }
                }
            }
            return oList_Dimension;
        }
        #endregion
        #region Get_Dimension_By_DIMENSION_ORDER
        public List<Dimension> Get_Dimension_By_DIMENSION_ORDER(int? DIMENSION_ORDER)
        {
            List<Dimension> oList_Dimension = null;
            dynamic _params = new ExpandoObject();
            _params.DIMENSION_ORDER = DIMENSION_ORDER;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DIMENSION_BY_DIMENSION_ORDER", _params);
            if (_query_response != null)
            {
                oList_Dimension = new List<Dimension>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Dimension oDimension = new Dimension();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDimension);
                        oList_Dimension.Add(oDimension);
                    }
                }
            }
            return oList_Dimension;
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
        #region Get_Kpi_By_DIMENSION_ID_List
        public List<Kpi> Get_Kpi_By_DIMENSION_ID_List(IEnumerable<int?> DIMENSION_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (DIMENSION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DIMENSION_ID_LIST = string.Join(",", DIMENSION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_DIMENSION_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID_List
        public List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID_List(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_SETUP_CATEGORY_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List
        public List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (MIN_DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.MIN_DATA_LEVEL_SETUP_ID_LIST = string.Join(",", MIN_DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_MIN_DATA_LEVEL_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List
        public List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List(IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (MAX_DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.MAX_DATA_LEVEL_SETUP_ID_LIST = string.Join(",", MAX_DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_MAX_DATA_LEVEL_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID_List
        public List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID_List(IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (KPI_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.KPI_TYPE_SETUP_ID_LIST = string.Join(",", KPI_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_KPI_TYPE_SETUP_ID_LIST", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Dimension_By_DIMENSION_ORDER_List
        public List<Dimension> Get_Dimension_By_DIMENSION_ORDER_List(IEnumerable<int?> DIMENSION_ORDER_LIST)
        {
            List<Dimension> oList_Dimension = null;
            if (DIMENSION_ORDER_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DIMENSION_ORDER_LIST = string.Join(",", DIMENSION_ORDER_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DIMENSION_BY_DIMENSION_ORDER_LIST", _params);
                if (_query_response != null)
                {
                    oList_Dimension = new List<Dimension>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Dimension oDimension = new Dimension();
                            Props.Copy_Prop_Values_From_Data_Record(element, oDimension);
                            oList_Dimension.Add(oDimension);
                        }
                    }
                }
            }
            return oList_Dimension;
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
        #region Get_Kpi_By_Where
        public List<Kpi> Get_Kpi_By_Where(string NAME, string UNIT, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.UNIT = UNIT;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Kpi;
        }
        #endregion
        #region Get_Dimension_By_Where
        public List<Dimension> Get_Dimension_By_Where(string NAME, string DIMENSION_ICON, string ICON_URL, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Dimension> oList_Dimension = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.DIMENSION_ICON = DIMENSION_ICON;
            _params.ICON_URL = ICON_URL;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_DIMENSION_BY_WHERE", _params);
            if (_query_response != null)
            {
                oList_Dimension = new List<Dimension>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Dimension oDimension = new Dimension();
                        Props.Copy_Prop_Values_From_Data_Record(element, oDimension);
                        oList_Dimension.Add(oDimension);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Dimension;
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
        #region Get_Kpi_By_Where_In_List
        public List<Kpi> Get_Kpi_By_Where_In_List(string NAME, string UNIT, IEnumerable<int?> DIMENSION_ID_LIST, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST, IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST, IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.UNIT = UNIT;
            _params.DIMENSION_ID_LIST = DIMENSION_ID_LIST != null ? string.Join(",", DIMENSION_ID_LIST) : "";
            _params.SETUP_CATEGORY_ID_LIST = SETUP_CATEGORY_ID_LIST != null ? string.Join(",", SETUP_CATEGORY_ID_LIST) : "";
            _params.KPI_TYPE_SETUP_ID_LIST = KPI_TYPE_SETUP_ID_LIST != null ? string.Join(",", KPI_TYPE_SETUP_ID_LIST) : "";
            _params.MIN_DATA_LEVEL_SETUP_ID_LIST = MIN_DATA_LEVEL_SETUP_ID_LIST != null ? string.Join(",", MIN_DATA_LEVEL_SETUP_ID_LIST) : "";
            _params.MAX_DATA_LEVEL_SETUP_ID_LIST = MAX_DATA_LEVEL_SETUP_ID_LIST != null ? string.Join(",", MAX_DATA_LEVEL_SETUP_ID_LIST) : "";
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_WHERE_IN_LIST", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Kpi;
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
        #region Delete_Kpi
        public void Delete_Kpi(int? KPI_ID)
        {
            var _params = new
            {
                KPI_ID = KPI_ID
            };
            ExecuteDelete("UPG_DELETE_KPI", _params);
        }
        #endregion
        #region Delete_Dimension
        public void Delete_Dimension(int? DIMENSION_ID)
        {
            var _params = new
            {
                DIMENSION_ID = DIMENSION_ID
            };
            ExecuteDelete("UPG_DELETE_DIMENSION", _params);
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
        #region Delete_Kpi_By_OWNER_ID
        public void Delete_Kpi_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_KPI_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Kpi_By_DIMENSION_ID
        public void Delete_Kpi_By_DIMENSION_ID(int? DIMENSION_ID)
        {
            var _params = new
            {
                DIMENSION_ID = DIMENSION_ID
            };
            ExecuteDelete("UPG_DELETE_KPI_BY_DIMENSION_ID", _params);
        }
        #endregion
        #region Delete_Kpi_By_SETUP_CATEGORY_ID
        public void Delete_Kpi_By_SETUP_CATEGORY_ID(int? SETUP_CATEGORY_ID)
        {
            var _params = new
            {
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID
            };
            ExecuteDelete("UPG_DELETE_KPI_BY_SETUP_CATEGORY_ID", _params);
        }
        #endregion
        #region Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
        public void Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(long? MIN_DATA_LEVEL_SETUP_ID)
        {
            var _params = new
            {
                MIN_DATA_LEVEL_SETUP_ID = MIN_DATA_LEVEL_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_KPI_BY_MIN_DATA_LEVEL_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
        public void Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(long? MAX_DATA_LEVEL_SETUP_ID)
        {
            var _params = new
            {
                MAX_DATA_LEVEL_SETUP_ID = MAX_DATA_LEVEL_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_KPI_BY_MAX_DATA_LEVEL_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Kpi_By_OWNER_ID_IS_DELETED
        public void Delete_Kpi_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_KPI_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Kpi_By_KPI_TYPE_SETUP_ID
        public void Delete_Kpi_By_KPI_TYPE_SETUP_ID(long? KPI_TYPE_SETUP_ID)
        {
            var _params = new
            {
                KPI_TYPE_SETUP_ID = KPI_TYPE_SETUP_ID
            };
            ExecuteDelete("UPG_DELETE_KPI_BY_KPI_TYPE_SETUP_ID", _params);
        }
        #endregion
        #region Delete_Dimension_By_OWNER_ID
        public void Delete_Dimension_By_OWNER_ID(int? OWNER_ID)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID
            };
            ExecuteDelete("UPG_DELETE_DIMENSION_BY_OWNER_ID", _params);
        }
        #endregion
        #region Delete_Dimension_By_OWNER_ID_IS_DELETED
        public void Delete_Dimension_By_OWNER_ID_IS_DELETED(int? OWNER_ID, bool IS_DELETED)
        {
            var _params = new
            {
                OWNER_ID = OWNER_ID,
                IS_DELETED = IS_DELETED
            };
            ExecuteDelete("UPG_DELETE_DIMENSION_BY_OWNER_ID_IS_DELETED", _params);
        }
        #endregion
        #region Delete_Dimension_By_DIMENSION_ORDER
        public void Delete_Dimension_By_DIMENSION_ORDER(int? DIMENSION_ORDER)
        {
            var _params = new
            {
                DIMENSION_ORDER = DIMENSION_ORDER
            };
            ExecuteDelete("UPG_DELETE_DIMENSION_BY_DIMENSION_ORDER", _params);
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
        #region Edit_Kpi
        public int? Edit_Kpi(int? KPI_ID, int? DIMENSION_ID, int? SETUP_CATEGORY_ID, string NAME, string UNIT, long? KPI_TYPE_SETUP_ID, bool HAS_CORRELATION, bool IS_TRENDLINE, bool IS_DECIMAL_VALUE, bool HAS_SQM, bool IS_BY_SEVERITY, bool IS_ADDITIVE_DATA, decimal? MINIMUM_VALUE, decimal? MAXIMUM_VALUE, string LATEST_DATA_CREATION_DATE, bool IS_AUTO_GENERATE, long? MIN_DATA_LEVEL_SETUP_ID, long? MAX_DATA_LEVEL_SETUP_ID, bool IS_EXTERNAL, bool HAS_ALERTS, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Kpi oKpi = new Kpi()
            {
                KPI_ID = KPI_ID,
                DIMENSION_ID = DIMENSION_ID,
                SETUP_CATEGORY_ID = SETUP_CATEGORY_ID,
                NAME = NAME,
                UNIT = UNIT,
                KPI_TYPE_SETUP_ID = KPI_TYPE_SETUP_ID,
                HAS_CORRELATION = HAS_CORRELATION,
                IS_TRENDLINE = IS_TRENDLINE,
                IS_DECIMAL_VALUE = IS_DECIMAL_VALUE,
                HAS_SQM = HAS_SQM,
                IS_BY_SEVERITY = IS_BY_SEVERITY,
                IS_ADDITIVE_DATA = IS_ADDITIVE_DATA,
                MINIMUM_VALUE = MINIMUM_VALUE,
                MAXIMUM_VALUE = MAXIMUM_VALUE,
                LATEST_DATA_CREATION_DATE = LATEST_DATA_CREATION_DATE,
                IS_AUTO_GENERATE = IS_AUTO_GENERATE,
                MIN_DATA_LEVEL_SETUP_ID = MIN_DATA_LEVEL_SETUP_ID,
                MAX_DATA_LEVEL_SETUP_ID = MAX_DATA_LEVEL_SETUP_ID,
                IS_EXTERNAL = IS_EXTERNAL,
                HAS_ALERTS = HAS_ALERTS,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_KPI", oKpi, "KPI_ID");
            return oKpi.KPI_ID;
        }
        #endregion
        #region Edit_Dimension
        public int? Edit_Dimension(int? DIMENSION_ID, string NAME, string DIMENSION_ICON, int? DIMENSION_ORDER, string ICON_URL, string LATEST_DATA_CREATION_DATE, long? ENTRY_USER_ID, string ENTRY_DATE, string LAST_UPDATE, bool IS_DELETED, int? OWNER_ID)
        {
            Dimension oDimension = new Dimension()
            {
                DIMENSION_ID = DIMENSION_ID,
                NAME = NAME,
                DIMENSION_ICON = DIMENSION_ICON,
                DIMENSION_ORDER = DIMENSION_ORDER,
                ICON_URL = ICON_URL,
                LATEST_DATA_CREATION_DATE = LATEST_DATA_CREATION_DATE,
                ENTRY_USER_ID = ENTRY_USER_ID,
                ENTRY_DATE = ENTRY_DATE,
                LAST_UPDATE = LAST_UPDATE,
                IS_DELETED = IS_DELETED,
                OWNER_ID = OWNER_ID
            };
            ExecuteEdit("UPG_EDIT_DIMENSION", oDimension, "DIMENSION_ID");
            return oDimension.DIMENSION_ID;
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
