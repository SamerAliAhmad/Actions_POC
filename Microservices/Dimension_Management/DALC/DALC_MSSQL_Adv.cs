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
        #region Get_Kpi_By_KPI_ID_Adv
        public Kpi Get_Kpi_By_KPI_ID_Adv(int? KPI_ID)
        {
            Kpi oKpi = null;
            dynamic _params = new ExpandoObject();
            _params.KPI_ID = KPI_ID;
            IEnumerable<IDataRecord> query = ExecuteSelectQuery("UPG_GET_KPI_BY_KPI_ID_ADV", _params);
            var _query_response = query.FirstOrDefault();
            if (_query_response != null)
            {
                oKpi = new Kpi();
                Props.Copy_Prop_Values_From_Data_Record(_query_response, oKpi);
                oKpi.Dimension = new Dimension();
                oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(_query_response, "T_DIMENSION_DIMENSION_ID");
                oKpi.Dimension.NAME = Get_Data_Record_Value<string>(_query_response, "T_DIMENSION_NAME");
                oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(_query_response, "T_DIMENSION_DIMENSION_ICON");
                oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_DIMENSION_DIMENSION_ORDER");
                oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(_query_response, "T_DIMENSION_ICON_URL");
                oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(_query_response, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_DIMENSION_ENTRY_USER_ID");
                oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_DIMENSION_ENTRY_DATE");
                oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_DIMENSION_LAST_UPDATE");
                oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_DIMENSION_IS_DELETED");
                oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_DIMENSION_OWNER_ID");
                oKpi.Kpi_type_setup = new Setup();
                oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_KPI_TYPE_SETUP_SETUP_ID");
                oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_KPI_TYPE_SETUP_IS_DELETED");
                oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_KPI_TYPE_SETUP_VALUE");
                oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_KPI_TYPE_SETUP_DESCRIPTION");
                oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_KPI_TYPE_SETUP_OWNER_ID");
                oKpi.Max_data_level_setup = new Setup();
                oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                oKpi.Min_data_level_setup = new Setup();
                oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(_query_response, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(_query_response, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(_query_response, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(_query_response, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(_query_response, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(_query_response, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(_query_response, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                oKpi.Setup_category = new Setup_category();
                oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_DESCRIPTION");
                oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(_query_response, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_ENTRY_DATE");
                oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(_query_response, "T_SETUP_CATEGORY_LAST_UPDATE");
                oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(_query_response, "T_SETUP_CATEGORY_IS_DELETED");
                oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(_query_response, "T_SETUP_CATEGORY_OWNER_ID");
            }
            return oKpi;
        }
        #endregion
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
        #region Get_Kpi_By_KPI_ID_List_Adv
        public List<Kpi> Get_Kpi_By_KPI_ID_List_Adv(IEnumerable<int?> KPI_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (KPI_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.KPI_ID_LIST = string.Join(",", KPI_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_KPI_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oKpi.Dimension = new Dimension();
                            oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                            oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                            oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                            oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                            oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                            oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                            oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                            oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                            oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                            oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                            oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                            oKpi.Kpi_type_setup = new Setup();
                            oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                            oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                            oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                            oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                            oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                            oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                            oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                            oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                            oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                            oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                            oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                            oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                            oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                            oKpi.Max_data_level_setup = new Setup();
                            oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                            oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                            oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                            oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                            oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                            oKpi.Min_data_level_setup = new Setup();
                            oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                            oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                            oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                            oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                            oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                            oKpi.Setup_category = new Setup_category();
                            oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                            oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                            oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                            oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                            oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                            oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                            oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                            oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
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
        #region Get_Kpi_By_OWNER_ID_Adv
        public List<Kpi> Get_Kpi_By_OWNER_ID_Adv(int? OWNER_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_OWNER_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oKpi.Dimension = new Dimension();
                        oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oKpi.Kpi_type_setup = new Setup();
                        oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                        oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                        oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                        oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                        oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                        oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                        oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                        oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                        oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                        oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                        oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                        oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                        oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                        oKpi.Max_data_level_setup = new Setup();
                        oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Min_data_level_setup = new Setup();
                        oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Setup_category = new Setup_category();
                        oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_DIMENSION_ID_Adv
        public List<Kpi> Get_Kpi_By_DIMENSION_ID_Adv(int? DIMENSION_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.DIMENSION_ID = DIMENSION_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_DIMENSION_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oKpi.Dimension = new Dimension();
                        oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oKpi.Kpi_type_setup = new Setup();
                        oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                        oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                        oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                        oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                        oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                        oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                        oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                        oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                        oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                        oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                        oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                        oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                        oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                        oKpi.Max_data_level_setup = new Setup();
                        oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Min_data_level_setup = new Setup();
                        oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Setup_category = new Setup_category();
                        oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID_Adv
        public List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID_Adv(int? SETUP_CATEGORY_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.SETUP_CATEGORY_ID = SETUP_CATEGORY_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_SETUP_CATEGORY_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oKpi.Dimension = new Dimension();
                        oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oKpi.Kpi_type_setup = new Setup();
                        oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                        oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                        oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                        oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                        oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                        oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                        oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                        oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                        oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                        oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                        oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                        oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                        oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                        oKpi.Max_data_level_setup = new Setup();
                        oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Min_data_level_setup = new Setup();
                        oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Setup_category = new Setup_category();
                        oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_Adv
        public List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_Adv(long? MIN_DATA_LEVEL_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.MIN_DATA_LEVEL_SETUP_ID = MIN_DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_MIN_DATA_LEVEL_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oKpi.Dimension = new Dimension();
                        oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oKpi.Kpi_type_setup = new Setup();
                        oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                        oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                        oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                        oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                        oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                        oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                        oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                        oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                        oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                        oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                        oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                        oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                        oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                        oKpi.Max_data_level_setup = new Setup();
                        oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Min_data_level_setup = new Setup();
                        oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Setup_category = new Setup_category();
                        oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_Adv
        public List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_Adv(long? MAX_DATA_LEVEL_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.MAX_DATA_LEVEL_SETUP_ID = MAX_DATA_LEVEL_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_MAX_DATA_LEVEL_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oKpi.Dimension = new Dimension();
                        oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oKpi.Kpi_type_setup = new Setup();
                        oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                        oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                        oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                        oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                        oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                        oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                        oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                        oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                        oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                        oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                        oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                        oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                        oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                        oKpi.Max_data_level_setup = new Setup();
                        oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Min_data_level_setup = new Setup();
                        oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Setup_category = new Setup_category();
                        oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_OWNER_ID_IS_DELETED_Adv
        public List<Kpi> Get_Kpi_By_OWNER_ID_IS_DELETED_Adv(int? OWNER_ID, bool IS_DELETED)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.OWNER_ID = OWNER_ID;
            _params.IS_DELETED = IS_DELETED;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_OWNER_ID_IS_DELETED_ADV", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oKpi.Dimension = new Dimension();
                        oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oKpi.Kpi_type_setup = new Setup();
                        oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                        oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                        oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                        oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                        oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                        oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                        oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                        oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                        oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                        oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                        oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                        oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                        oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                        oKpi.Max_data_level_setup = new Setup();
                        oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Min_data_level_setup = new Setup();
                        oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Setup_category = new Setup_category();
                        oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID_Adv
        public List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID_Adv(long? KPI_TYPE_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.KPI_TYPE_SETUP_ID = KPI_TYPE_SETUP_ID;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_KPI_TYPE_SETUP_ID_ADV", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oKpi.Dimension = new Dimension();
                        oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oKpi.Kpi_type_setup = new Setup();
                        oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                        oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                        oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                        oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                        oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                        oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                        oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                        oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                        oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                        oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                        oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                        oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                        oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                        oKpi.Max_data_level_setup = new Setup();
                        oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Min_data_level_setup = new Setup();
                        oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Setup_category = new Setup_category();
                        oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            return oList_Kpi;
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
        #region Get_Kpi_By_DIMENSION_ID_List_Adv
        public List<Kpi> Get_Kpi_By_DIMENSION_ID_List_Adv(IEnumerable<int?> DIMENSION_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (DIMENSION_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.DIMENSION_ID_LIST = string.Join(",", DIMENSION_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_DIMENSION_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oKpi.Dimension = new Dimension();
                            oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                            oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                            oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                            oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                            oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                            oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                            oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                            oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                            oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                            oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                            oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                            oKpi.Kpi_type_setup = new Setup();
                            oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                            oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                            oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                            oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                            oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                            oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                            oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                            oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                            oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                            oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                            oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                            oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                            oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                            oKpi.Max_data_level_setup = new Setup();
                            oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                            oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                            oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                            oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                            oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                            oKpi.Min_data_level_setup = new Setup();
                            oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                            oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                            oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                            oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                            oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                            oKpi.Setup_category = new Setup_category();
                            oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                            oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                            oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                            oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                            oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                            oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                            oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                            oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID_List_Adv
        public List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID_List_Adv(IEnumerable<int?> SETUP_CATEGORY_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (SETUP_CATEGORY_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.SETUP_CATEGORY_ID_LIST = string.Join(",", SETUP_CATEGORY_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_SETUP_CATEGORY_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oKpi.Dimension = new Dimension();
                            oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                            oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                            oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                            oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                            oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                            oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                            oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                            oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                            oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                            oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                            oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                            oKpi.Kpi_type_setup = new Setup();
                            oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                            oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                            oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                            oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                            oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                            oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                            oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                            oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                            oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                            oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                            oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                            oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                            oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                            oKpi.Max_data_level_setup = new Setup();
                            oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                            oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                            oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                            oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                            oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                            oKpi.Min_data_level_setup = new Setup();
                            oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                            oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                            oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                            oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                            oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                            oKpi.Setup_category = new Setup_category();
                            oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                            oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                            oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                            oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                            oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                            oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                            oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                            oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_Adv
        public List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (MIN_DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.MIN_DATA_LEVEL_SETUP_ID_LIST = string.Join(",", MIN_DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_MIN_DATA_LEVEL_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oKpi.Dimension = new Dimension();
                            oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                            oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                            oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                            oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                            oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                            oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                            oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                            oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                            oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                            oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                            oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                            oKpi.Kpi_type_setup = new Setup();
                            oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                            oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                            oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                            oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                            oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                            oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                            oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                            oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                            oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                            oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                            oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                            oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                            oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                            oKpi.Max_data_level_setup = new Setup();
                            oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                            oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                            oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                            oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                            oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                            oKpi.Min_data_level_setup = new Setup();
                            oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                            oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                            oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                            oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                            oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                            oKpi.Setup_category = new Setup_category();
                            oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                            oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                            oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                            oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                            oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                            oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                            oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                            oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_Adv
        public List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_Adv(IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (MAX_DATA_LEVEL_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.MAX_DATA_LEVEL_SETUP_ID_LIST = string.Join(",", MAX_DATA_LEVEL_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_MAX_DATA_LEVEL_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oKpi.Dimension = new Dimension();
                            oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                            oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                            oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                            oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                            oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                            oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                            oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                            oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                            oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                            oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                            oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                            oKpi.Kpi_type_setup = new Setup();
                            oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                            oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                            oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                            oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                            oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                            oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                            oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                            oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                            oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                            oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                            oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                            oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                            oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                            oKpi.Max_data_level_setup = new Setup();
                            oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                            oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                            oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                            oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                            oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                            oKpi.Min_data_level_setup = new Setup();
                            oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                            oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                            oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                            oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                            oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                            oKpi.Setup_category = new Setup_category();
                            oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                            oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                            oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                            oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                            oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                            oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                            oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                            oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID_List_Adv
        public List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID_List_Adv(IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST)
        {
            List<Kpi> oList_Kpi = null;
            if (KPI_TYPE_SETUP_ID_LIST != null)
            {
                dynamic _params = new ExpandoObject();
                _params.KPI_TYPE_SETUP_ID_LIST = string.Join(",", KPI_TYPE_SETUP_ID_LIST);
                IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_KPI_TYPE_SETUP_ID_LIST_ADV", _params);
                if (_query_response != null)
                {
                    oList_Kpi = new List<Kpi>();
                    if (_query_response.Count() > 0)
                    {
                        foreach (var element in _query_response)
                        {
                            Kpi oKpi = new Kpi();
                            Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                            oKpi.Dimension = new Dimension();
                            oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                            oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                            oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                            oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                            oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                            oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                            oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                            oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                            oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                            oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                            oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                            oKpi.Kpi_type_setup = new Setup();
                            oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                            oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                            oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                            oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                            oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                            oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                            oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                            oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                            oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                            oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                            oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                            oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                            oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                            oKpi.Max_data_level_setup = new Setup();
                            oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                            oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                            oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                            oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                            oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                            oKpi.Min_data_level_setup = new Setup();
                            oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                            oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                            oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                            oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                            oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                            oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                            oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                            oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                            oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                            oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                            oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                            oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                            oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                            oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                            oKpi.Setup_category = new Setup_category();
                            oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                            oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                            oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                            oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                            oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                            oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                            oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                            oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                            oList_Kpi.Add(oKpi);
                        }
                    }
                }
            }
            return oList_Kpi;
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
        #region Get_Kpi_By_Where_Adv
        public List<Kpi> Get_Kpi_By_Where_Adv(string NAME, string UNIT, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
        {
            List<Kpi> oList_Kpi = null;
            dynamic _params = new ExpandoObject();
            _params.NAME = NAME;
            _params.UNIT = UNIT;
            _params.OWNER_ID = OWNER_ID;
            _params.OFFSET = OFFSET;
            _params.FETCH_NEXT = FETCH_NEXT;
            _params.TOTAL_COUNT = TOTAL_COUNT;
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_WHERE_ADV", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oKpi.Dimension = new Dimension();
                        oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oKpi.Kpi_type_setup = new Setup();
                        oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                        oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                        oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                        oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                        oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                        oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                        oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                        oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                        oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                        oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                        oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                        oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                        oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                        oKpi.Max_data_level_setup = new Setup();
                        oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Min_data_level_setup = new Setup();
                        oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Setup_category = new Setup_category();
                        oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Kpi;
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
        #region Get_Kpi_By_Where_In_List_Adv
        public List<Kpi> Get_Kpi_By_Where_In_List_Adv(string NAME, string UNIT, IEnumerable<int?> DIMENSION_ID_LIST, IEnumerable<int?> SETUP_CATEGORY_ID_LIST, IEnumerable<long?> KPI_TYPE_SETUP_ID_LIST, IEnumerable<long?> MIN_DATA_LEVEL_SETUP_ID_LIST, IEnumerable<long?> MAX_DATA_LEVEL_SETUP_ID_LIST, int? OWNER_ID, long? OFFSET, long? FETCH_NEXT, ref long? TOTAL_COUNT)
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
            IEnumerable<IDataRecord> _query_response = ExecuteSelectQuery("UPG_GET_KPI_BY_WHERE_IN_LIST_ADV", _params);
            if (_query_response != null)
            {
                oList_Kpi = new List<Kpi>();
                if (_query_response.Count() > 0)
                {
                    foreach (var element in _query_response)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values_From_Data_Record(element, oKpi);
                        oKpi.Dimension = new Dimension();
                        oKpi.Dimension.DIMENSION_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ID");
                        oKpi.Dimension.NAME = Get_Data_Record_Value<string>(element, "T_DIMENSION_NAME");
                        oKpi.Dimension.DIMENSION_ICON = Get_Data_Record_Value<string>(element, "T_DIMENSION_DIMENSION_ICON");
                        oKpi.Dimension.DIMENSION_ORDER = Get_Data_Record_Value<int?>(element, "T_DIMENSION_DIMENSION_ORDER");
                        oKpi.Dimension.ICON_URL = Get_Data_Record_Value<string>(element, "T_DIMENSION_ICON_URL");
                        oKpi.Dimension.LATEST_DATA_CREATION_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LATEST_DATA_CREATION_DATE");
                        oKpi.Dimension.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_DIMENSION_ENTRY_USER_ID");
                        oKpi.Dimension.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_ENTRY_DATE");
                        oKpi.Dimension.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_DIMENSION_LAST_UPDATE");
                        oKpi.Dimension.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_DIMENSION_IS_DELETED");
                        oKpi.Dimension.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_DIMENSION_OWNER_ID");
                        oKpi.Kpi_type_setup = new Setup();
                        oKpi.Kpi_type_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_SETUP_ID");
                        oKpi.Kpi_type_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Kpi_type_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_SYSTEM");
                        oKpi.Kpi_type_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETEABLE");
                        oKpi.Kpi_type_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_UPDATEABLE");
                        oKpi.Kpi_type_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_DELETED");
                        oKpi.Kpi_type_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_KPI_TYPE_SETUP_IS_VISIBLE");
                        oKpi.Kpi_type_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_DISPLAY_ORDER");
                        oKpi.Kpi_type_setup.VALUE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_VALUE");
                        oKpi.Kpi_type_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_DESCRIPTION");
                        oKpi.Kpi_type_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_KPI_TYPE_SETUP_ENTRY_USER_ID");
                        oKpi.Kpi_type_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_ENTRY_DATE");
                        oKpi.Kpi_type_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_KPI_TYPE_SETUP_LAST_UPDATE");
                        oKpi.Kpi_type_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_KPI_TYPE_SETUP_OWNER_ID");
                        oKpi.Max_data_level_setup = new Setup();
                        oKpi.Max_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Max_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Max_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Max_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Max_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Max_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Max_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MAX_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Max_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Max_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Max_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Max_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Max_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Max_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MAX_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Max_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MAX_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Min_data_level_setup = new Setup();
                        oKpi.Min_data_level_setup.SETUP_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_ID");
                        oKpi.Min_data_level_setup.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_SETUP_CATEGORY_ID");
                        oKpi.Min_data_level_setup.IS_SYSTEM = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_SYSTEM");
                        oKpi.Min_data_level_setup.IS_DELETEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETEABLE");
                        oKpi.Min_data_level_setup.IS_UPDATEABLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_UPDATEABLE");
                        oKpi.Min_data_level_setup.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_DELETED");
                        oKpi.Min_data_level_setup.IS_VISIBLE = Get_Data_Record_Value<bool>(element, "T_MIN_DATA_LEVEL_SETUP_IS_VISIBLE");
                        oKpi.Min_data_level_setup.DISPLAY_ORDER = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_DISPLAY_ORDER");
                        oKpi.Min_data_level_setup.VALUE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_VALUE");
                        oKpi.Min_data_level_setup.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_DESCRIPTION");
                        oKpi.Min_data_level_setup.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_USER_ID");
                        oKpi.Min_data_level_setup.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_ENTRY_DATE");
                        oKpi.Min_data_level_setup.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_MIN_DATA_LEVEL_SETUP_LAST_UPDATE");
                        oKpi.Min_data_level_setup.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_MIN_DATA_LEVEL_SETUP_OWNER_ID");
                        oKpi.Setup_category = new Setup_category();
                        oKpi.Setup_category.SETUP_CATEGORY_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_ID");
                        oKpi.Setup_category.SETUP_CATEGORY_NAME = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_SETUP_CATEGORY_NAME");
                        oKpi.Setup_category.DESCRIPTION = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_DESCRIPTION");
                        oKpi.Setup_category.ENTRY_USER_ID = Get_Data_Record_Value<long?>(element, "T_SETUP_CATEGORY_ENTRY_USER_ID");
                        oKpi.Setup_category.ENTRY_DATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_ENTRY_DATE");
                        oKpi.Setup_category.LAST_UPDATE = Get_Data_Record_Value<string>(element, "T_SETUP_CATEGORY_LAST_UPDATE");
                        oKpi.Setup_category.IS_DELETED = Get_Data_Record_Value<bool>(element, "T_SETUP_CATEGORY_IS_DELETED");
                        oKpi.Setup_category.OWNER_ID = Get_Data_Record_Value<int?>(element, "T_SETUP_CATEGORY_OWNER_ID");
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            TOTAL_COUNT = _params.TOTAL_COUNT;
            return oList_Kpi;
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
