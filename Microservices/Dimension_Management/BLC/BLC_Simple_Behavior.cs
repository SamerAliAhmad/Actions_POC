using System;
using System.Linq;
using SmartrTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Members
        #region Used For Delete Operations
        private Kpi _Kpi;
        private List<Kpi> _List_Kpi;
        private Dimension _Dimension;
        private List<Dimension> _List_Dimension;
        private Report _Report;
        private List<Report> _List_Report;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Kpi_Execution;
        private bool _Stop_Delete_Kpi_Execution;
        private bool _Stop_Edit_Dimension_Execution;
        private bool _Stop_Delete_Dimension_Execution;
        private bool _Stop_Edit_Report_Execution;
        private bool _Stop_Delete_Report_Execution;
        #endregion
        #endregion
        #region Get_Kpi_By_KPI_ID
        public Kpi Get_Kpi_By_KPI_ID(Params_Get_Kpi_By_KPI_ID i_Params_Get_Kpi_By_KPI_ID)
        {
            Kpi oKpi = null;
            var i_Params_Get_Kpi_By_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_KPI_ID", i_Params_Get_Kpi_By_KPI_ID_json, false);
            }
            #region Body Section.
            DALC.Kpi oDBEntry = _AppContext.Get_Kpi_By_KPI_ID(i_Params_Get_Kpi_By_KPI_ID.KPI_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Kpi").Replace("%2", i_Params_Get_Kpi_By_KPI_ID.KPI_ID.ToString()));
            }
            oKpi = new Kpi();
            Props.Copy_Prop_Values(oDBEntry, oKpi);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_KPI_ID", i_Params_Get_Kpi_By_KPI_ID_json, false);
            }
            return oKpi;
        }
        #endregion
        #region Get_Dimension_By_DIMENSION_ID
        public Dimension Get_Dimension_By_DIMENSION_ID(Params_Get_Dimension_By_DIMENSION_ID i_Params_Get_Dimension_By_DIMENSION_ID)
        {
            Dimension oDimension = null;
            var i_Params_Get_Dimension_By_DIMENSION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Dimension_By_DIMENSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Dimension_By_DIMENSION_ID", i_Params_Get_Dimension_By_DIMENSION_ID_json, false);
            }
            #region PreEvent_Get_Dimension_By_DIMENSION_ID
            if (OnPreEvent_Get_Dimension_By_DIMENSION_ID != null)
            {
                OnPreEvent_Get_Dimension_By_DIMENSION_ID(i_Params_Get_Dimension_By_DIMENSION_ID);
            }
            #endregion
            #region Body Section.
            DALC.Dimension oDBEntry = _AppContext.Get_Dimension_By_DIMENSION_ID(i_Params_Get_Dimension_By_DIMENSION_ID.DIMENSION_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Dimension").Replace("%2", i_Params_Get_Dimension_By_DIMENSION_ID.DIMENSION_ID.ToString()));
            }
            oDimension = new Dimension();
            Props.Copy_Prop_Values(oDBEntry, oDimension);
            #endregion
            #region PostEvent_Get_Dimension_By_DIMENSION_ID
            if (OnPostEvent_Get_Dimension_By_DIMENSION_ID != null)
            {
                OnPostEvent_Get_Dimension_By_DIMENSION_ID(oDimension, i_Params_Get_Dimension_By_DIMENSION_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Dimension_By_DIMENSION_ID", i_Params_Get_Dimension_By_DIMENSION_ID_json, false);
            }
            return oDimension;
        }
        #endregion
        #region Get_Report_By_REPORT_ID
        public Report Get_Report_By_REPORT_ID(Params_Get_Report_By_REPORT_ID i_Params_Get_Report_By_REPORT_ID)
        {
            Report oReport = null;
            var i_Params_Get_Report_By_REPORT_ID_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_REPORT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_REPORT_ID", i_Params_Get_Report_By_REPORT_ID_json, false);
            }
            #region Body Section.
            DALC.Report oDBEntry = _AppContext.Get_Report_By_REPORT_ID(i_Params_Get_Report_By_REPORT_ID.REPORT_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Report").Replace("%2", i_Params_Get_Report_By_REPORT_ID.REPORT_ID.ToString()));
            }
            oReport = new Report();
            Props.Copy_Prop_Values(oDBEntry, oReport);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_REPORT_ID", i_Params_Get_Report_By_REPORT_ID_json, false);
            }
            return oReport;
        }
        #endregion
        #region Get_Kpi_By_KPI_ID_List
        public List<Kpi> Get_Kpi_By_KPI_ID_List(Params_Get_Kpi_By_KPI_ID_List i_Params_Get_Kpi_By_KPI_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_KPI_ID_List", i_Params_Get_Kpi_By_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_KPI_ID_List(i_Params_Get_Kpi_By_KPI_ID_List.KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_KPI_ID_List", i_Params_Get_Kpi_By_KPI_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Dimension_By_DIMENSION_ID_List
        public List<Dimension> Get_Dimension_By_DIMENSION_ID_List(Params_Get_Dimension_By_DIMENSION_ID_List i_Params_Get_Dimension_By_DIMENSION_ID_List)
        {
            List<Dimension> oList_Dimension = null;
            var i_Params_Get_Dimension_By_DIMENSION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Dimension_By_DIMENSION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Dimension_By_DIMENSION_ID_List", i_Params_Get_Dimension_By_DIMENSION_ID_List_json, false);
            }
            #region PreEvent_Get_Dimension_By_DIMENSION_ID_List
            if (OnPreEvent_Get_Dimension_By_DIMENSION_ID_List != null)
            {
                OnPreEvent_Get_Dimension_By_DIMENSION_ID_List(i_Params_Get_Dimension_By_DIMENSION_ID_List);
            }
            #endregion
            #region Body Section.
            List<DALC.Dimension> oList_DBEntry = _AppContext.Get_Dimension_By_DIMENSION_ID_List(i_Params_Get_Dimension_By_DIMENSION_ID_List.DIMENSION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Dimension = new List<Dimension>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Dimension oDimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry, oDimension);
                        oList_Dimension.Add(oDimension);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Dimension_By_DIMENSION_ID_List
            if (OnPostEvent_Get_Dimension_By_DIMENSION_ID_List != null)
            {
                OnPostEvent_Get_Dimension_By_DIMENSION_ID_List(oList_Dimension, i_Params_Get_Dimension_By_DIMENSION_ID_List);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Dimension_By_DIMENSION_ID_List", i_Params_Get_Dimension_By_DIMENSION_ID_List_json, false);
            }
            return oList_Dimension;
        }
        #endregion
        #region Get_Report_By_REPORT_ID_List
        public List<Report> Get_Report_By_REPORT_ID_List(Params_Get_Report_By_REPORT_ID_List i_Params_Get_Report_By_REPORT_ID_List)
        {
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_REPORT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_REPORT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_REPORT_ID_List", i_Params_Get_Report_By_REPORT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_REPORT_ID_List(i_Params_Get_Report_By_REPORT_ID_List.REPORT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oList_Report.Add(oReport);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_REPORT_ID_List", i_Params_Get_Report_By_REPORT_ID_List_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Get_Kpi_By_OWNER_ID
        public List<Kpi> Get_Kpi_By_OWNER_ID(Params_Get_Kpi_By_OWNER_ID i_Params_Get_Kpi_By_OWNER_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_OWNER_ID", i_Params_Get_Kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_OWNER_ID(i_Params_Get_Kpi_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_OWNER_ID", i_Params_Get_Kpi_By_OWNER_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_DIMENSION_ID
        public List<Kpi> Get_Kpi_By_DIMENSION_ID(Params_Get_Kpi_By_DIMENSION_ID i_Params_Get_Kpi_By_DIMENSION_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_DIMENSION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_DIMENSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_DIMENSION_ID", i_Params_Get_Kpi_By_DIMENSION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_DIMENSION_ID(i_Params_Get_Kpi_By_DIMENSION_ID.DIMENSION_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_DIMENSION_ID", i_Params_Get_Kpi_By_DIMENSION_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID
        public List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID(Params_Get_Kpi_By_SETUP_CATEGORY_ID i_Params_Get_Kpi_By_SETUP_CATEGORY_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_SETUP_CATEGORY_ID", i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_SETUP_CATEGORY_ID(i_Params_Get_Kpi_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_SETUP_CATEGORY_ID", i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
        public List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID", i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID.MIN_DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID", i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
        public List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID", i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID.MAX_DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID", i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_OWNER_ID_IS_DELETED
        public List<Kpi> Get_Kpi_By_OWNER_ID_IS_DELETED(Params_Get_Kpi_By_OWNER_ID_IS_DELETED i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_OWNER_ID_IS_DELETED(i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_OWNER_ID_IS_DELETED", i_Params_Get_Kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID
        public List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID(Params_Get_Kpi_By_KPI_TYPE_SETUP_ID i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_KPI_TYPE_SETUP_ID", i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_KPI_TYPE_SETUP_ID(i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID.KPI_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_KPI_TYPE_SETUP_ID", i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Dimension_By_OWNER_ID
        public List<Dimension> Get_Dimension_By_OWNER_ID(Params_Get_Dimension_By_OWNER_ID i_Params_Get_Dimension_By_OWNER_ID)
        {
            List<Dimension> oList_Dimension = null;
            var i_Params_Get_Dimension_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Dimension_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Dimension_By_OWNER_ID", i_Params_Get_Dimension_By_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Dimension_By_OWNER_ID
            if (OnPreEvent_Get_Dimension_By_OWNER_ID != null)
            {
                OnPreEvent_Get_Dimension_By_OWNER_ID(i_Params_Get_Dimension_By_OWNER_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Dimension> oList_DBEntry = _AppContext.Get_Dimension_By_OWNER_ID(i_Params_Get_Dimension_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Dimension = new List<Dimension>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Dimension oDimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry, oDimension);
                        oList_Dimension.Add(oDimension);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Dimension_By_OWNER_ID
            if (OnPostEvent_Get_Dimension_By_OWNER_ID != null)
            {
                OnPostEvent_Get_Dimension_By_OWNER_ID(oList_Dimension, i_Params_Get_Dimension_By_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Dimension_By_OWNER_ID", i_Params_Get_Dimension_By_OWNER_ID_json, false);
            }
            return oList_Dimension;
        }
        #endregion
        #region Get_Dimension_By_OWNER_ID_IS_DELETED
        public List<Dimension> Get_Dimension_By_OWNER_ID_IS_DELETED(Params_Get_Dimension_By_OWNER_ID_IS_DELETED i_Params_Get_Dimension_By_OWNER_ID_IS_DELETED)
        {
            List<Dimension> oList_Dimension = null;
            var i_Params_Get_Dimension_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Dimension_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Dimension_By_OWNER_ID_IS_DELETED", i_Params_Get_Dimension_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Dimension> oList_DBEntry = _AppContext.Get_Dimension_By_OWNER_ID_IS_DELETED(i_Params_Get_Dimension_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Dimension_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Dimension = new List<Dimension>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Dimension oDimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry, oDimension);
                        oList_Dimension.Add(oDimension);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Dimension_By_OWNER_ID_IS_DELETED", i_Params_Get_Dimension_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Dimension;
        }
        #endregion
        #region Get_Dimension_By_DIMENSION_ORDER
        public List<Dimension> Get_Dimension_By_DIMENSION_ORDER(Params_Get_Dimension_By_DIMENSION_ORDER i_Params_Get_Dimension_By_DIMENSION_ORDER)
        {
            List<Dimension> oList_Dimension = null;
            var i_Params_Get_Dimension_By_DIMENSION_ORDER_json = JsonConvert.SerializeObject(i_Params_Get_Dimension_By_DIMENSION_ORDER);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Dimension_By_DIMENSION_ORDER", i_Params_Get_Dimension_By_DIMENSION_ORDER_json, false);
            }
            #region Body Section.
            List<DALC.Dimension> oList_DBEntry = _AppContext.Get_Dimension_By_DIMENSION_ORDER(i_Params_Get_Dimension_By_DIMENSION_ORDER.DIMENSION_ORDER);
            if (oList_DBEntry != null)
            {
                oList_Dimension = new List<Dimension>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Dimension oDimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry, oDimension);
                        oList_Dimension.Add(oDimension);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Dimension_By_DIMENSION_ORDER", i_Params_Get_Dimension_By_DIMENSION_ORDER_json, false);
            }
            return oList_Dimension;
        }
        #endregion
        #region Get_Report_By_OWNER_ID
        public List<Report> Get_Report_By_OWNER_ID(Params_Get_Report_By_OWNER_ID i_Params_Get_Report_By_OWNER_ID)
        {
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_OWNER_ID", i_Params_Get_Report_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_OWNER_ID(i_Params_Get_Report_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oList_Report.Add(oReport);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_OWNER_ID", i_Params_Get_Report_By_OWNER_ID_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_DIMENSION_ID
        public List<Report> Get_Report_By_DIMENSION_ID(Params_Get_Report_By_DIMENSION_ID i_Params_Get_Report_By_DIMENSION_ID)
        {
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_DIMENSION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_DIMENSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_DIMENSION_ID", i_Params_Get_Report_By_DIMENSION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_DIMENSION_ID(i_Params_Get_Report_By_DIMENSION_ID.DIMENSION_ID);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oList_Report.Add(oReport);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_DIMENSION_ID", i_Params_Get_Report_By_DIMENSION_ID_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_OWNER_ID_IS_DELETED
        public List<Report> Get_Report_By_OWNER_ID_IS_DELETED(Params_Get_Report_By_OWNER_ID_IS_DELETED i_Params_Get_Report_By_OWNER_ID_IS_DELETED)
        {
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_OWNER_ID_IS_DELETED", i_Params_Get_Report_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_OWNER_ID_IS_DELETED(i_Params_Get_Report_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Report_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oList_Report.Add(oReport);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_OWNER_ID_IS_DELETED", i_Params_Get_Report_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_IDENTIFIER_TOKEN
        public List<Report> Get_Report_By_IDENTIFIER_TOKEN(Params_Get_Report_By_IDENTIFIER_TOKEN i_Params_Get_Report_By_IDENTIFIER_TOKEN)
        {
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_IDENTIFIER_TOKEN_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_IDENTIFIER_TOKEN);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_IDENTIFIER_TOKEN", i_Params_Get_Report_By_IDENTIFIER_TOKEN_json, false);
            }
            #region Body Section.
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_IDENTIFIER_TOKEN(i_Params_Get_Report_By_IDENTIFIER_TOKEN.IDENTIFIER_TOKEN);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oList_Report.Add(oReport);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_IDENTIFIER_TOKEN", i_Params_Get_Report_By_IDENTIFIER_TOKEN_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Get_Kpi_By_DIMENSION_ID_List
        public List<Kpi> Get_Kpi_By_DIMENSION_ID_List(Params_Get_Kpi_By_DIMENSION_ID_List i_Params_Get_Kpi_By_DIMENSION_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_DIMENSION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_DIMENSION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_DIMENSION_ID_List", i_Params_Get_Kpi_By_DIMENSION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_DIMENSION_ID_List(i_Params_Get_Kpi_By_DIMENSION_ID_List.DIMENSION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_DIMENSION_ID_List", i_Params_Get_Kpi_By_DIMENSION_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_SETUP_CATEGORY_ID_List
        public List<Kpi> Get_Kpi_By_SETUP_CATEGORY_ID_List(Params_Get_Kpi_By_SETUP_CATEGORY_ID_List i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_SETUP_CATEGORY_ID_List", i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_SETUP_CATEGORY_ID_List(i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_SETUP_CATEGORY_ID_List", i_Params_Get_Kpi_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List
        public List<Kpi> Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List(Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List(i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List.MIN_DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List
        public List<Kpi> Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List(Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List(i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List.MAX_DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Kpi_By_KPI_TYPE_SETUP_ID_List
        public List<Kpi> Get_Kpi_By_KPI_TYPE_SETUP_ID_List(Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List)
        {
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_KPI_TYPE_SETUP_ID_List", i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_KPI_TYPE_SETUP_ID_List(i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List.KPI_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_KPI_TYPE_SETUP_ID_List", i_Params_Get_Kpi_By_KPI_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Dimension_By_DIMENSION_ORDER_List
        public List<Dimension> Get_Dimension_By_DIMENSION_ORDER_List(Params_Get_Dimension_By_DIMENSION_ORDER_List i_Params_Get_Dimension_By_DIMENSION_ORDER_List)
        {
            List<Dimension> oList_Dimension = null;
            var i_Params_Get_Dimension_By_DIMENSION_ORDER_List_json = JsonConvert.SerializeObject(i_Params_Get_Dimension_By_DIMENSION_ORDER_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Dimension_By_DIMENSION_ORDER_List", i_Params_Get_Dimension_By_DIMENSION_ORDER_List_json, false);
            }
            #region Body Section.
            List<DALC.Dimension> oList_DBEntry = _AppContext.Get_Dimension_By_DIMENSION_ORDER_List(i_Params_Get_Dimension_By_DIMENSION_ORDER_List.DIMENSION_ORDER_LIST);
            if (oList_DBEntry != null)
            {
                oList_Dimension = new List<Dimension>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Dimension oDimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry, oDimension);
                        oList_Dimension.Add(oDimension);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Dimension_By_DIMENSION_ORDER_List", i_Params_Get_Dimension_By_DIMENSION_ORDER_List_json, false);
            }
            return oList_Dimension;
        }
        #endregion
        #region Get_Report_By_DIMENSION_ID_List
        public List<Report> Get_Report_By_DIMENSION_ID_List(Params_Get_Report_By_DIMENSION_ID_List i_Params_Get_Report_By_DIMENSION_ID_List)
        {
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_DIMENSION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_DIMENSION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_DIMENSION_ID_List", i_Params_Get_Report_By_DIMENSION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_DIMENSION_ID_List(i_Params_Get_Report_By_DIMENSION_ID_List.DIMENSION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oList_Report.Add(oReport);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_DIMENSION_ID_List", i_Params_Get_Report_By_DIMENSION_ID_List_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Get_Kpi_By_Where
        public List<Kpi> Get_Kpi_By_Where(Params_Get_Kpi_By_Where i_Params_Get_Kpi_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_Where", i_Params_Get_Kpi_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Kpi_By_Where.OWNER_ID == null || i_Params_Get_Kpi_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Kpi_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Kpi_By_Where.OFFSET == null)
            {
                i_Params_Get_Kpi_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Kpi_By_Where.FETCH_NEXT == null || i_Params_Get_Kpi_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Kpi_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_Where(i_Params_Get_Kpi_By_Where.NAME, i_Params_Get_Kpi_By_Where.UNIT, i_Params_Get_Kpi_By_Where.OWNER_ID, i_Params_Get_Kpi_By_Where.OFFSET, i_Params_Get_Kpi_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            i_Params_Get_Kpi_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_Where", i_Params_Get_Kpi_By_Where_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Dimension_By_Where
        public List<Dimension> Get_Dimension_By_Where(Params_Get_Dimension_By_Where i_Params_Get_Dimension_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Dimension> oList_Dimension = null;
            var i_Params_Get_Dimension_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Dimension_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Dimension_By_Where", i_Params_Get_Dimension_By_Where_json, false);
            }
            #region PreEvent_Get_Dimension_By_Where
            if (OnPreEvent_Get_Dimension_By_Where != null)
            {
                OnPreEvent_Get_Dimension_By_Where(i_Params_Get_Dimension_By_Where);
            }
            #endregion
            #region Body Section.
            if (i_Params_Get_Dimension_By_Where.OWNER_ID == null || i_Params_Get_Dimension_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Dimension_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Dimension_By_Where.OFFSET == null)
            {
                i_Params_Get_Dimension_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Dimension_By_Where.FETCH_NEXT == null || i_Params_Get_Dimension_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Dimension_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Dimension> oList_DBEntry = _AppContext.Get_Dimension_By_Where(i_Params_Get_Dimension_By_Where.NAME, i_Params_Get_Dimension_By_Where.DIMENSION_ICON, i_Params_Get_Dimension_By_Where.ICON_URL, i_Params_Get_Dimension_By_Where.OWNER_ID, i_Params_Get_Dimension_By_Where.OFFSET, i_Params_Get_Dimension_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Dimension = new List<Dimension>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Dimension oDimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry, oDimension);
                        oList_Dimension.Add(oDimension);
                    }
                }
            }
            i_Params_Get_Dimension_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            #region PostEvent_Get_Dimension_By_Where
            if (OnPostEvent_Get_Dimension_By_Where != null)
            {
                OnPostEvent_Get_Dimension_By_Where(oList_Dimension, i_Params_Get_Dimension_By_Where);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Dimension_By_Where", i_Params_Get_Dimension_By_Where_json, false);
            }
            return oList_Dimension;
        }
        #endregion
        #region Get_Report_By_Where
        public List<Report> Get_Report_By_Where(Params_Get_Report_By_Where i_Params_Get_Report_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_Where", i_Params_Get_Report_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Report_By_Where.OWNER_ID == null || i_Params_Get_Report_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Report_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Report_By_Where.OFFSET == null)
            {
                i_Params_Get_Report_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Report_By_Where.FETCH_NEXT == null || i_Params_Get_Report_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Report_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_Where(i_Params_Get_Report_By_Where.FILE_NAME, i_Params_Get_Report_By_Where.FILE_EXTENSION, i_Params_Get_Report_By_Where.FILE_SIZE, i_Params_Get_Report_By_Where.IDENTIFIER_TOKEN, i_Params_Get_Report_By_Where.OWNER_ID, i_Params_Get_Report_By_Where.OFFSET, i_Params_Get_Report_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oList_Report.Add(oReport);
                    }
                }
            }
            i_Params_Get_Report_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_Where", i_Params_Get_Report_By_Where_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Get_Kpi_By_Where_In_List
        public List<Kpi> Get_Kpi_By_Where_In_List(Params_Get_Kpi_By_Where_In_List i_Params_Get_Kpi_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Kpi> oList_Kpi = null;
            var i_Params_Get_Kpi_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Kpi_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Kpi_By_Where_In_List", i_Params_Get_Kpi_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Kpi_By_Where_In_List.OWNER_ID == null || i_Params_Get_Kpi_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Kpi_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Kpi_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Kpi_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Kpi_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Kpi_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Kpi_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Kpi_By_Where_In_List.DIMENSION_ID_LIST == null)
            {
                i_Params_Get_Kpi_By_Where_In_List.DIMENSION_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Kpi_By_Where_In_List.SETUP_CATEGORY_ID_LIST == null)
            {
                i_Params_Get_Kpi_By_Where_In_List.SETUP_CATEGORY_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Kpi_By_Where_In_List.KPI_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Kpi_By_Where_In_List.KPI_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Kpi_By_Where_In_List.MIN_DATA_LEVEL_SETUP_ID_LIST == null)
            {
                i_Params_Get_Kpi_By_Where_In_List.MIN_DATA_LEVEL_SETUP_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Kpi_By_Where_In_List.MAX_DATA_LEVEL_SETUP_ID_LIST == null)
            {
                i_Params_Get_Kpi_By_Where_In_List.MAX_DATA_LEVEL_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Kpi> oList_DBEntry = _AppContext.Get_Kpi_By_Where_In_List(i_Params_Get_Kpi_By_Where_In_List.NAME, i_Params_Get_Kpi_By_Where_In_List.UNIT, i_Params_Get_Kpi_By_Where_In_List.DIMENSION_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.SETUP_CATEGORY_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.KPI_TYPE_SETUP_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.MIN_DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.MAX_DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Kpi_By_Where_In_List.OWNER_ID, i_Params_Get_Kpi_By_Where_In_List.OFFSET, i_Params_Get_Kpi_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Kpi = new List<Kpi>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Kpi oKpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry, oKpi);
                        oList_Kpi.Add(oKpi);
                    }
                }
            }
            i_Params_Get_Kpi_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Kpi_By_Where_In_List", i_Params_Get_Kpi_By_Where_In_List_json, false);
            }
            return oList_Kpi;
        }
        #endregion
        #region Get_Report_By_Where_In_List
        public List<Report> Get_Report_By_Where_In_List(Params_Get_Report_By_Where_In_List i_Params_Get_Report_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_Where_In_List", i_Params_Get_Report_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Report_By_Where_In_List.OWNER_ID == null || i_Params_Get_Report_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Report_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Report_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Report_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Report_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Report_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Report_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Report_By_Where_In_List.DIMENSION_ID_LIST == null)
            {
                i_Params_Get_Report_By_Where_In_List.DIMENSION_ID_LIST = new List<int?>();
            }
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_Where_In_List(i_Params_Get_Report_By_Where_In_List.FILE_NAME, i_Params_Get_Report_By_Where_In_List.FILE_EXTENSION, i_Params_Get_Report_By_Where_In_List.FILE_SIZE, i_Params_Get_Report_By_Where_In_List.IDENTIFIER_TOKEN, i_Params_Get_Report_By_Where_In_List.DIMENSION_ID_LIST, i_Params_Get_Report_By_Where_In_List.OWNER_ID, i_Params_Get_Report_By_Where_In_List.OFFSET, i_Params_Get_Report_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oList_Report.Add(oReport);
                    }
                }
            }
            i_Params_Get_Report_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_Where_In_List", i_Params_Get_Report_By_Where_In_List_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Delete_Kpi
        public void Delete_Kpi(Params_Delete_Kpi i_Params_Delete_Kpi)
        {
            var i_Params_Delete_Kpi_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi", i_Params_Delete_Kpi_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_KPI_ID oParams_Get_Kpi_By_KPI_ID = new Params_Get_Kpi_By_KPI_ID
                {
                    KPI_ID = i_Params_Delete_Kpi.KPI_ID
                };
                _Kpi = Get_Kpi_By_KPI_ID(oParams_Get_Kpi_By_KPI_ID);
                if (_Kpi != null)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi(i_Params_Delete_Kpi.KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi", i_Params_Delete_Kpi_json, false);
            }
        }
        #endregion
        #region Delete_Dimension
        public void Delete_Dimension(Params_Delete_Dimension i_Params_Delete_Dimension)
        {
            var i_Params_Delete_Dimension_json = JsonConvert.SerializeObject(i_Params_Delete_Dimension);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Dimension", i_Params_Delete_Dimension_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Dimension_By_DIMENSION_ID oParams_Get_Dimension_By_DIMENSION_ID = new Params_Get_Dimension_By_DIMENSION_ID
                {
                    DIMENSION_ID = i_Params_Delete_Dimension.DIMENSION_ID
                };
                _Dimension = Get_Dimension_By_DIMENSION_ID(oParams_Get_Dimension_By_DIMENSION_ID);
                if (_Dimension != null)
                {
                    if (_Stop_Delete_Dimension_Execution)
                    {
                        _Stop_Delete_Dimension_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Dimension(i_Params_Delete_Dimension.DIMENSION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Dimension", i_Params_Delete_Dimension_json, false);
            }
        }
        #endregion
        #region Delete_Report
        public void Delete_Report(Params_Delete_Report i_Params_Delete_Report)
        {
            var i_Params_Delete_Report_json = JsonConvert.SerializeObject(i_Params_Delete_Report);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Report", i_Params_Delete_Report_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Report_By_REPORT_ID oParams_Get_Report_By_REPORT_ID = new Params_Get_Report_By_REPORT_ID
                {
                    REPORT_ID = i_Params_Delete_Report.REPORT_ID
                };
                _Report = Get_Report_By_REPORT_ID(oParams_Get_Report_By_REPORT_ID);
                if (_Report != null)
                {
                    if (_Stop_Delete_Report_Execution)
                    {
                        _Stop_Delete_Report_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Report(i_Params_Delete_Report.REPORT_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Report", i_Params_Delete_Report_json, false);
            }
        }
        #endregion
        #region Delete_Kpi_By_OWNER_ID
        public void Delete_Kpi_By_OWNER_ID(Params_Delete_Kpi_By_OWNER_ID i_Params_Delete_Kpi_By_OWNER_ID)
        {
            var i_Params_Delete_Kpi_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi_By_OWNER_ID", i_Params_Delete_Kpi_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_OWNER_ID oParams_Get_Kpi_By_OWNER_ID = new Params_Get_Kpi_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Kpi_By_OWNER_ID.OWNER_ID
                };
                _List_Kpi = Get_Kpi_By_OWNER_ID(oParams_Get_Kpi_By_OWNER_ID);
                if (_List_Kpi != null && _List_Kpi.Count > 0)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi_By_OWNER_ID(i_Params_Delete_Kpi_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi_By_OWNER_ID", i_Params_Delete_Kpi_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Kpi_By_DIMENSION_ID
        public void Delete_Kpi_By_DIMENSION_ID(Params_Delete_Kpi_By_DIMENSION_ID i_Params_Delete_Kpi_By_DIMENSION_ID)
        {
            var i_Params_Delete_Kpi_By_DIMENSION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi_By_DIMENSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi_By_DIMENSION_ID", i_Params_Delete_Kpi_By_DIMENSION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_DIMENSION_ID oParams_Get_Kpi_By_DIMENSION_ID = new Params_Get_Kpi_By_DIMENSION_ID
                {
                    DIMENSION_ID = i_Params_Delete_Kpi_By_DIMENSION_ID.DIMENSION_ID
                };
                _List_Kpi = Get_Kpi_By_DIMENSION_ID(oParams_Get_Kpi_By_DIMENSION_ID);
                if (_List_Kpi != null && _List_Kpi.Count > 0)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi_By_DIMENSION_ID(i_Params_Delete_Kpi_By_DIMENSION_ID.DIMENSION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi_By_DIMENSION_ID", i_Params_Delete_Kpi_By_DIMENSION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Kpi_By_SETUP_CATEGORY_ID
        public void Delete_Kpi_By_SETUP_CATEGORY_ID(Params_Delete_Kpi_By_SETUP_CATEGORY_ID i_Params_Delete_Kpi_By_SETUP_CATEGORY_ID)
        {
            var i_Params_Delete_Kpi_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi_By_SETUP_CATEGORY_ID", i_Params_Delete_Kpi_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_SETUP_CATEGORY_ID oParams_Get_Kpi_By_SETUP_CATEGORY_ID = new Params_Get_Kpi_By_SETUP_CATEGORY_ID
                {
                    SETUP_CATEGORY_ID = i_Params_Delete_Kpi_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID
                };
                _List_Kpi = Get_Kpi_By_SETUP_CATEGORY_ID(oParams_Get_Kpi_By_SETUP_CATEGORY_ID);
                if (_List_Kpi != null && _List_Kpi.Count > 0)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi_By_SETUP_CATEGORY_ID(i_Params_Delete_Kpi_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi_By_SETUP_CATEGORY_ID", i_Params_Delete_Kpi_By_SETUP_CATEGORY_ID_json, false);
            }
        }
        #endregion
        #region Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
        public void Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID i_Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID)
        {
            var i_Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID", i_Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID oParams_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID = new Params_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID
                {
                    MIN_DATA_LEVEL_SETUP_ID = i_Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID.MIN_DATA_LEVEL_SETUP_ID
                };
                _List_Kpi = Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(oParams_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID);
                if (_List_Kpi != null && _List_Kpi.Count > 0)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID(i_Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID.MIN_DATA_LEVEL_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID", i_Params_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
        public void Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID i_Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID)
        {
            var i_Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID", i_Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID oParams_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID = new Params_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID
                {
                    MAX_DATA_LEVEL_SETUP_ID = i_Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID.MAX_DATA_LEVEL_SETUP_ID
                };
                _List_Kpi = Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(oParams_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID);
                if (_List_Kpi != null && _List_Kpi.Count > 0)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID(i_Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID.MAX_DATA_LEVEL_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID", i_Params_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Kpi_By_OWNER_ID_IS_DELETED
        public void Delete_Kpi_By_OWNER_ID_IS_DELETED(Params_Delete_Kpi_By_OWNER_ID_IS_DELETED i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_OWNER_ID_IS_DELETED oParams_Get_Kpi_By_OWNER_ID_IS_DELETED = new Params_Get_Kpi_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Kpi = Get_Kpi_By_OWNER_ID_IS_DELETED(oParams_Get_Kpi_By_OWNER_ID_IS_DELETED);
                if (_List_Kpi != null && _List_Kpi.Count > 0)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi_By_OWNER_ID_IS_DELETED(i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi_By_OWNER_ID_IS_DELETED", i_Params_Delete_Kpi_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Kpi_By_KPI_TYPE_SETUP_ID
        public void Delete_Kpi_By_KPI_TYPE_SETUP_ID(Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID i_Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Kpi_By_KPI_TYPE_SETUP_ID", i_Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Kpi_By_KPI_TYPE_SETUP_ID oParams_Get_Kpi_By_KPI_TYPE_SETUP_ID = new Params_Get_Kpi_By_KPI_TYPE_SETUP_ID
                {
                    KPI_TYPE_SETUP_ID = i_Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID.KPI_TYPE_SETUP_ID
                };
                _List_Kpi = Get_Kpi_By_KPI_TYPE_SETUP_ID(oParams_Get_Kpi_By_KPI_TYPE_SETUP_ID);
                if (_List_Kpi != null && _List_Kpi.Count > 0)
                {
                    if (_Stop_Delete_Kpi_Execution)
                    {
                        _Stop_Delete_Kpi_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Kpi_By_KPI_TYPE_SETUP_ID(i_Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID.KPI_TYPE_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Kpi_By_KPI_TYPE_SETUP_ID", i_Params_Delete_Kpi_By_KPI_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Dimension_By_OWNER_ID
        public void Delete_Dimension_By_OWNER_ID(Params_Delete_Dimension_By_OWNER_ID i_Params_Delete_Dimension_By_OWNER_ID)
        {
            var i_Params_Delete_Dimension_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Dimension_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Dimension_By_OWNER_ID", i_Params_Delete_Dimension_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Dimension_By_OWNER_ID oParams_Get_Dimension_By_OWNER_ID = new Params_Get_Dimension_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Dimension_By_OWNER_ID.OWNER_ID
                };
                _List_Dimension = Get_Dimension_By_OWNER_ID(oParams_Get_Dimension_By_OWNER_ID);
                if (_List_Dimension != null && _List_Dimension.Count > 0)
                {
                    if (_Stop_Delete_Dimension_Execution)
                    {
                        _Stop_Delete_Dimension_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Dimension_By_OWNER_ID(i_Params_Delete_Dimension_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Dimension_By_OWNER_ID", i_Params_Delete_Dimension_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Dimension_By_OWNER_ID_IS_DELETED
        public void Delete_Dimension_By_OWNER_ID_IS_DELETED(Params_Delete_Dimension_By_OWNER_ID_IS_DELETED i_Params_Delete_Dimension_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Dimension_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Dimension_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Dimension_By_OWNER_ID_IS_DELETED", i_Params_Delete_Dimension_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Dimension_By_OWNER_ID_IS_DELETED oParams_Get_Dimension_By_OWNER_ID_IS_DELETED = new Params_Get_Dimension_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Dimension_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Dimension_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Dimension = Get_Dimension_By_OWNER_ID_IS_DELETED(oParams_Get_Dimension_By_OWNER_ID_IS_DELETED);
                if (_List_Dimension != null && _List_Dimension.Count > 0)
                {
                    if (_Stop_Delete_Dimension_Execution)
                    {
                        _Stop_Delete_Dimension_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Dimension_By_OWNER_ID_IS_DELETED(i_Params_Delete_Dimension_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Dimension_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Dimension_By_OWNER_ID_IS_DELETED", i_Params_Delete_Dimension_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Dimension_By_DIMENSION_ORDER
        public void Delete_Dimension_By_DIMENSION_ORDER(Params_Delete_Dimension_By_DIMENSION_ORDER i_Params_Delete_Dimension_By_DIMENSION_ORDER)
        {
            var i_Params_Delete_Dimension_By_DIMENSION_ORDER_json = JsonConvert.SerializeObject(i_Params_Delete_Dimension_By_DIMENSION_ORDER);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Dimension_By_DIMENSION_ORDER", i_Params_Delete_Dimension_By_DIMENSION_ORDER_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Dimension_By_DIMENSION_ORDER oParams_Get_Dimension_By_DIMENSION_ORDER = new Params_Get_Dimension_By_DIMENSION_ORDER
                {
                    DIMENSION_ORDER = i_Params_Delete_Dimension_By_DIMENSION_ORDER.DIMENSION_ORDER
                };
                _List_Dimension = Get_Dimension_By_DIMENSION_ORDER(oParams_Get_Dimension_By_DIMENSION_ORDER);
                if (_List_Dimension != null && _List_Dimension.Count > 0)
                {
                    if (_Stop_Delete_Dimension_Execution)
                    {
                        _Stop_Delete_Dimension_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Dimension_By_DIMENSION_ORDER(i_Params_Delete_Dimension_By_DIMENSION_ORDER.DIMENSION_ORDER);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Dimension_By_DIMENSION_ORDER", i_Params_Delete_Dimension_By_DIMENSION_ORDER_json, false);
            }
        }
        #endregion
        #region Delete_Report_By_OWNER_ID
        public void Delete_Report_By_OWNER_ID(Params_Delete_Report_By_OWNER_ID i_Params_Delete_Report_By_OWNER_ID)
        {
            var i_Params_Delete_Report_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Report_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Report_By_OWNER_ID", i_Params_Delete_Report_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Report_By_OWNER_ID oParams_Get_Report_By_OWNER_ID = new Params_Get_Report_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Report_By_OWNER_ID.OWNER_ID
                };
                _List_Report = Get_Report_By_OWNER_ID(oParams_Get_Report_By_OWNER_ID);
                if (_List_Report != null && _List_Report.Count > 0)
                {
                    if (_Stop_Delete_Report_Execution)
                    {
                        _Stop_Delete_Report_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Report_By_OWNER_ID(i_Params_Delete_Report_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Report_By_OWNER_ID", i_Params_Delete_Report_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Report_By_DIMENSION_ID
        public void Delete_Report_By_DIMENSION_ID(Params_Delete_Report_By_DIMENSION_ID i_Params_Delete_Report_By_DIMENSION_ID)
        {
            var i_Params_Delete_Report_By_DIMENSION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Report_By_DIMENSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Report_By_DIMENSION_ID", i_Params_Delete_Report_By_DIMENSION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Report_By_DIMENSION_ID oParams_Get_Report_By_DIMENSION_ID = new Params_Get_Report_By_DIMENSION_ID
                {
                    DIMENSION_ID = i_Params_Delete_Report_By_DIMENSION_ID.DIMENSION_ID
                };
                _List_Report = Get_Report_By_DIMENSION_ID(oParams_Get_Report_By_DIMENSION_ID);
                if (_List_Report != null && _List_Report.Count > 0)
                {
                    if (_Stop_Delete_Report_Execution)
                    {
                        _Stop_Delete_Report_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Report_By_DIMENSION_ID(i_Params_Delete_Report_By_DIMENSION_ID.DIMENSION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Report_By_DIMENSION_ID", i_Params_Delete_Report_By_DIMENSION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Report_By_OWNER_ID_IS_DELETED
        public void Delete_Report_By_OWNER_ID_IS_DELETED(Params_Delete_Report_By_OWNER_ID_IS_DELETED i_Params_Delete_Report_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Report_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Report_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Report_By_OWNER_ID_IS_DELETED", i_Params_Delete_Report_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Report_By_OWNER_ID_IS_DELETED oParams_Get_Report_By_OWNER_ID_IS_DELETED = new Params_Get_Report_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Report_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Report_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Report = Get_Report_By_OWNER_ID_IS_DELETED(oParams_Get_Report_By_OWNER_ID_IS_DELETED);
                if (_List_Report != null && _List_Report.Count > 0)
                {
                    if (_Stop_Delete_Report_Execution)
                    {
                        _Stop_Delete_Report_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Report_By_OWNER_ID_IS_DELETED(i_Params_Delete_Report_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Report_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Report_By_OWNER_ID_IS_DELETED", i_Params_Delete_Report_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Report_By_IDENTIFIER_TOKEN
        public void Delete_Report_By_IDENTIFIER_TOKEN(Params_Delete_Report_By_IDENTIFIER_TOKEN i_Params_Delete_Report_By_IDENTIFIER_TOKEN)
        {
            var i_Params_Delete_Report_By_IDENTIFIER_TOKEN_json = JsonConvert.SerializeObject(i_Params_Delete_Report_By_IDENTIFIER_TOKEN);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Report_By_IDENTIFIER_TOKEN", i_Params_Delete_Report_By_IDENTIFIER_TOKEN_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Report_By_IDENTIFIER_TOKEN oParams_Get_Report_By_IDENTIFIER_TOKEN = new Params_Get_Report_By_IDENTIFIER_TOKEN
                {
                    IDENTIFIER_TOKEN = i_Params_Delete_Report_By_IDENTIFIER_TOKEN.IDENTIFIER_TOKEN
                };
                _List_Report = Get_Report_By_IDENTIFIER_TOKEN(oParams_Get_Report_By_IDENTIFIER_TOKEN);
                if (_List_Report != null && _List_Report.Count > 0)
                {
                    if (_Stop_Delete_Report_Execution)
                    {
                        _Stop_Delete_Report_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Report_By_IDENTIFIER_TOKEN(i_Params_Delete_Report_By_IDENTIFIER_TOKEN.IDENTIFIER_TOKEN);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Report_By_IDENTIFIER_TOKEN", i_Params_Delete_Report_By_IDENTIFIER_TOKEN_json, false);
            }
        }
        #endregion
        #region Edit_Kpi
        public void Edit_Kpi(Kpi i_Kpi)
        {
            var i_Kpi_json = JsonConvert.SerializeObject(i_Kpi);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Kpi.KPI_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Kpi", i_Kpi_json, false);
            }
            #region Body Section.
            if (i_Kpi.KPI_ID == null || i_Kpi.KPI_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Kpi");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Kpi.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Kpi.IS_DELETED = false;
            }
            else
            {
                _Kpi = Get_Kpi_By_KPI_ID(new Params_Get_Kpi_By_KPI_ID
                {
                    KPI_ID = i_Kpi.KPI_ID
                });
            }
            i_Kpi.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Kpi.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Kpi.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Kpi_Execution)
            {
                _Stop_Edit_Kpi_Execution = false;
                return;
            }
            i_Kpi.KPI_ID = _AppContext.Edit_Kpi
            (
                i_Kpi.KPI_ID,
                i_Kpi.DIMENSION_ID,
                i_Kpi.SETUP_CATEGORY_ID,
                i_Kpi.NAME,
                i_Kpi.UNIT,
                i_Kpi.KPI_TYPE_SETUP_ID,
                i_Kpi.HAS_CORRELATION,
                i_Kpi.IS_TRENDLINE,
                i_Kpi.IS_DECIMAL_VALUE,
                i_Kpi.HAS_SQM,
                i_Kpi.IS_BY_SEVERITY,
                i_Kpi.IS_ADDITIVE_DATA,
                i_Kpi.MINIMUM_VALUE,
                i_Kpi.MAXIMUM_VALUE,
                i_Kpi.LATEST_DATA_CREATION_DATE,
                i_Kpi.IS_AUTO_GENERATE,
                i_Kpi.MIN_DATA_LEVEL_SETUP_ID,
                i_Kpi.MAX_DATA_LEVEL_SETUP_ID,
                i_Kpi.IS_EXTERNAL,
                i_Kpi.HAS_ALERTS,
                i_Kpi.ENTRY_USER_ID,
                i_Kpi.ENTRY_DATE,
                i_Kpi.LAST_UPDATE,
                i_Kpi.IS_DELETED,
                i_Kpi.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Kpi", i_Kpi_json, false);
            }
        }
        #endregion
        #region Edit_Dimension
        public void Edit_Dimension(Dimension i_Dimension)
        {
            var i_Dimension_json = JsonConvert.SerializeObject(i_Dimension);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Dimension.DIMENSION_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Dimension", i_Dimension_json, false);
            }
            #region Body Section.
            if (i_Dimension.DIMENSION_ID == null || i_Dimension.DIMENSION_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Dimension");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Dimension.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Dimension.IS_DELETED = false;
            }
            else
            {
                _Dimension = Get_Dimension_By_DIMENSION_ID(new Params_Get_Dimension_By_DIMENSION_ID
                {
                    DIMENSION_ID = i_Dimension.DIMENSION_ID
                });
            }
            i_Dimension.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Dimension.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Dimension.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Dimension
            if (OnPreEvent_Edit_Dimension != null)
            {
                OnPreEvent_Edit_Dimension(i_Dimension, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Dimension_Execution)
            {
                _Stop_Edit_Dimension_Execution = false;
                return;
            }
            i_Dimension.DIMENSION_ID = _AppContext.Edit_Dimension
            (
                i_Dimension.DIMENSION_ID,
                i_Dimension.NAME,
                i_Dimension.DIMENSION_ICON,
                i_Dimension.DIMENSION_ORDER,
                i_Dimension.ICON_URL,
                i_Dimension.LATEST_DATA_CREATION_DATE,
                i_Dimension.ENTRY_USER_ID,
                i_Dimension.ENTRY_DATE,
                i_Dimension.LAST_UPDATE,
                i_Dimension.IS_DELETED,
                i_Dimension.OWNER_ID
            );
            #region PostEvent_Edit_Dimension
            if (OnPostEvent_Edit_Dimension != null)
            {
                OnPostEvent_Edit_Dimension(i_Dimension, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Dimension", i_Dimension_json, false);
            }
        }
        #endregion
        #region Edit_Report
        public void Edit_Report(Report i_Report)
        {
            var i_Report_json = JsonConvert.SerializeObject(i_Report);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Report.REPORT_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Report", i_Report_json, false);
            }
            #region Body Section.
            if (i_Report.REPORT_ID == null || i_Report.REPORT_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Report");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Report.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Report.IS_DELETED = false;
            }
            else
            {
                _Report = Get_Report_By_REPORT_ID(new Params_Get_Report_By_REPORT_ID
                {
                    REPORT_ID = i_Report.REPORT_ID
                });
            }
            i_Report.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Report.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Report.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Report_Execution)
            {
                _Stop_Edit_Report_Execution = false;
                return;
            }
            i_Report.REPORT_ID = _AppContext.Edit_Report
            (
                i_Report.REPORT_ID,
                i_Report.DIMENSION_ID,
                i_Report.FILE_NAME,
                i_Report.FILE_EXTENSION,
                i_Report.FILE_SIZE,
                i_Report.IDENTIFIER_TOKEN,
                i_Report.ENTRY_USER_ID,
                i_Report.ENTRY_DATE,
                i_Report.LAST_UPDATE,
                i_Report.IS_DELETED,
                i_Report.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Report", i_Report_json, false);
            }
        }
        #endregion
        #region Edit_Kpi_List
        public void Edit_Kpi_List(Params_Edit_Kpi_List i_Params_Edit_Kpi_List)
        {
            var i_Params_Edit_Kpi_List_json = JsonConvert.SerializeObject(i_Params_Edit_Kpi_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Kpi_List", i_Params_Edit_Kpi_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Kpi_List.List_To_Edit != null)
            {
                i_Params_Edit_Kpi_List.List_Failed_Edit = new List<Kpi>();
                if (i_Params_Edit_Kpi_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oKpi in i_Params_Edit_Kpi_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Kpi(oKpi);
                        }
                        catch
                        {
                            i_Params_Edit_Kpi_List.List_Failed_Edit.Add(oKpi);
                        }
                    }
                }
                i_Params_Edit_Kpi_List.List_To_Edit = i_Params_Edit_Kpi_List.List_To_Edit.Except(i_Params_Edit_Kpi_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Kpi_List.List_To_Delete != null)
            {
                i_Params_Edit_Kpi_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Kpi_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Kpi_ID in i_Params_Edit_Kpi_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Kpi(new Params_Delete_Kpi()
                            {
                                KPI_ID = Kpi_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Kpi_List.List_Failed_Delete.Add(Kpi_ID);
                        }
                    }
                }
                i_Params_Edit_Kpi_List.List_To_Delete = i_Params_Edit_Kpi_List.List_To_Delete.Except(i_Params_Edit_Kpi_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Kpi_List", i_Params_Edit_Kpi_List_json, false);
            }
        }
        #endregion
        #region Edit_Dimension_List
        public void Edit_Dimension_List(Params_Edit_Dimension_List i_Params_Edit_Dimension_List)
        {
            var i_Params_Edit_Dimension_List_json = JsonConvert.SerializeObject(i_Params_Edit_Dimension_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Dimension_List", i_Params_Edit_Dimension_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Dimension_List.List_To_Edit != null)
            {
                i_Params_Edit_Dimension_List.List_Failed_Edit = new List<Dimension>();
                if (i_Params_Edit_Dimension_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oDimension in i_Params_Edit_Dimension_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Dimension(oDimension);
                        }
                        catch
                        {
                            i_Params_Edit_Dimension_List.List_Failed_Edit.Add(oDimension);
                        }
                    }
                }
                i_Params_Edit_Dimension_List.List_To_Edit = i_Params_Edit_Dimension_List.List_To_Edit.Except(i_Params_Edit_Dimension_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Dimension_List.List_To_Delete != null)
            {
                i_Params_Edit_Dimension_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Dimension_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Dimension_ID in i_Params_Edit_Dimension_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Dimension(new Params_Delete_Dimension()
                            {
                                DIMENSION_ID = Dimension_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Dimension_List.List_Failed_Delete.Add(Dimension_ID);
                        }
                    }
                }
                i_Params_Edit_Dimension_List.List_To_Delete = i_Params_Edit_Dimension_List.List_To_Delete.Except(i_Params_Edit_Dimension_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Dimension_List", i_Params_Edit_Dimension_List_json, false);
            }
        }
        #endregion
        #region Edit_Report_List
        public void Edit_Report_List(Params_Edit_Report_List i_Params_Edit_Report_List)
        {
            var i_Params_Edit_Report_List_json = JsonConvert.SerializeObject(i_Params_Edit_Report_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Report_List", i_Params_Edit_Report_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Report_List.List_To_Edit != null)
            {
                i_Params_Edit_Report_List.List_Failed_Edit = new List<Report>();
                if (i_Params_Edit_Report_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oReport in i_Params_Edit_Report_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Report(oReport);
                        }
                        catch
                        {
                            i_Params_Edit_Report_List.List_Failed_Edit.Add(oReport);
                        }
                    }
                }
                i_Params_Edit_Report_List.List_To_Edit = i_Params_Edit_Report_List.List_To_Edit.Except(i_Params_Edit_Report_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Report_List.List_To_Delete != null)
            {
                i_Params_Edit_Report_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Report_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Report_ID in i_Params_Edit_Report_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Report(new Params_Delete_Report()
                            {
                                REPORT_ID = Report_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Report_List.List_Failed_Delete.Add(Report_ID);
                        }
                    }
                }
                i_Params_Edit_Report_List.List_To_Delete = i_Params_Edit_Report_List.List_To_Delete.Except(i_Params_Edit_Report_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Report_List", i_Params_Edit_Report_List_json, false);
            }
        }
        #endregion
    }
}