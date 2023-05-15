using System;
using SmartrTools;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Get_Report_By_REPORT_ID_Adv
        public Report Get_Report_By_REPORT_ID_Adv(Params_Get_Report_By_REPORT_ID i_Params_Get_Report_By_REPORT_ID)
        {
            Report oReport = null;
            var i_Params_Get_Report_By_REPORT_ID_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_REPORT_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_REPORT_ID_Adv", i_Params_Get_Report_By_REPORT_ID_json, false);
            }
            #region Body Section.
            DALC.Report oDBEntry = _AppContext.Get_Report_By_REPORT_ID_Adv(i_Params_Get_Report_By_REPORT_ID.REPORT_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Report").Replace("%2", i_Params_Get_Report_By_REPORT_ID.REPORT_ID.ToString()));
            }
            oReport = new Report();
            Props.Copy_Prop_Values(oDBEntry, oReport);
            oReport.Dimension = new Dimension();
            Props.Copy_Prop_Values(oDBEntry.Dimension, oReport.Dimension);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_REPORT_ID_Adv", i_Params_Get_Report_By_REPORT_ID_json, false);
            }
            return oReport;
        }
        #endregion
        #region Get_Report_By_REPORT_ID_List_Adv
        public List<Report> Get_Report_By_REPORT_ID_List_Adv(Params_Get_Report_By_REPORT_ID_List i_Params_Get_Report_By_REPORT_ID_List)
        {
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_REPORT_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_REPORT_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_REPORT_ID_List_Adv", i_Params_Get_Report_By_REPORT_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_REPORT_ID_List_Adv(i_Params_Get_Report_By_REPORT_ID_List.REPORT_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oReport.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oReport.Dimension);
                        oList_Report.Add(oReport);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_REPORT_ID_List_Adv", i_Params_Get_Report_By_REPORT_ID_List_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_OWNER_ID_Adv
        public List<Report> Get_Report_By_OWNER_ID_Adv(Params_Get_Report_By_OWNER_ID i_Params_Get_Report_By_OWNER_ID)
        {
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_OWNER_ID_Adv", i_Params_Get_Report_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_OWNER_ID_Adv(i_Params_Get_Report_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oReport.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oReport.Dimension);
                        oList_Report.Add(oReport);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_OWNER_ID_Adv", i_Params_Get_Report_By_OWNER_ID_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_DIMENSION_ID_Adv
        public List<Report> Get_Report_By_DIMENSION_ID_Adv(Params_Get_Report_By_DIMENSION_ID i_Params_Get_Report_By_DIMENSION_ID)
        {
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_DIMENSION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_DIMENSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_DIMENSION_ID_Adv", i_Params_Get_Report_By_DIMENSION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_DIMENSION_ID_Adv(i_Params_Get_Report_By_DIMENSION_ID.DIMENSION_ID);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oReport.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oReport.Dimension);
                        oList_Report.Add(oReport);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_DIMENSION_ID_Adv", i_Params_Get_Report_By_DIMENSION_ID_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_OWNER_ID_IS_DELETED_Adv
        public List<Report> Get_Report_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Report_By_OWNER_ID_IS_DELETED i_Params_Get_Report_By_OWNER_ID_IS_DELETED)
        {
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Report_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Report_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Report_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oReport.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oReport.Dimension);
                        oList_Report.Add(oReport);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Report_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_IDENTIFIER_TOKEN_Adv
        public List<Report> Get_Report_By_IDENTIFIER_TOKEN_Adv(Params_Get_Report_By_IDENTIFIER_TOKEN i_Params_Get_Report_By_IDENTIFIER_TOKEN)
        {
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_IDENTIFIER_TOKEN_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_IDENTIFIER_TOKEN);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_IDENTIFIER_TOKEN_Adv", i_Params_Get_Report_By_IDENTIFIER_TOKEN_json, false);
            }
            #region Body Section.
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_IDENTIFIER_TOKEN_Adv(i_Params_Get_Report_By_IDENTIFIER_TOKEN.IDENTIFIER_TOKEN);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oReport.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oReport.Dimension);
                        oList_Report.Add(oReport);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_IDENTIFIER_TOKEN_Adv", i_Params_Get_Report_By_IDENTIFIER_TOKEN_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_DIMENSION_ID_List_Adv
        public List<Report> Get_Report_By_DIMENSION_ID_List_Adv(Params_Get_Report_By_DIMENSION_ID_List i_Params_Get_Report_By_DIMENSION_ID_List)
        {
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_DIMENSION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_DIMENSION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_DIMENSION_ID_List_Adv", i_Params_Get_Report_By_DIMENSION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_DIMENSION_ID_List_Adv(i_Params_Get_Report_By_DIMENSION_ID_List.DIMENSION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oReport.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oReport.Dimension);
                        oList_Report.Add(oReport);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_DIMENSION_ID_List_Adv", i_Params_Get_Report_By_DIMENSION_ID_List_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_Where_Adv
        public List<Report> Get_Report_By_Where_Adv(Params_Get_Report_By_Where i_Params_Get_Report_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_Where_Adv", i_Params_Get_Report_By_Where_json, false);
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
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_Where_Adv(i_Params_Get_Report_By_Where.FILE_NAME, i_Params_Get_Report_By_Where.FILE_EXTENSION, i_Params_Get_Report_By_Where.FILE_SIZE, i_Params_Get_Report_By_Where.IDENTIFIER_TOKEN, i_Params_Get_Report_By_Where.OWNER_ID, i_Params_Get_Report_By_Where.OFFSET, i_Params_Get_Report_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oReport.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oReport.Dimension);
                        oList_Report.Add(oReport);
                    }
                }
            }
            i_Params_Get_Report_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_Where_Adv", i_Params_Get_Report_By_Where_json, false);
            }
            return oList_Report;
        }
        #endregion
        #region Get_Report_By_Where_In_List_Adv
        public List<Report> Get_Report_By_Where_In_List_Adv(Params_Get_Report_By_Where_In_List i_Params_Get_Report_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Report> oList_Report = null;
            var i_Params_Get_Report_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Report_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Report_By_Where_In_List_Adv", i_Params_Get_Report_By_Where_In_List_json, false);
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
            List<DALC.Report> oList_DBEntry = _AppContext.Get_Report_By_Where_In_List_Adv(i_Params_Get_Report_By_Where_In_List.FILE_NAME, i_Params_Get_Report_By_Where_In_List.FILE_EXTENSION, i_Params_Get_Report_By_Where_In_List.FILE_SIZE, i_Params_Get_Report_By_Where_In_List.IDENTIFIER_TOKEN, i_Params_Get_Report_By_Where_In_List.DIMENSION_ID_LIST, i_Params_Get_Report_By_Where_In_List.OWNER_ID, i_Params_Get_Report_By_Where_In_List.OFFSET, i_Params_Get_Report_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Report = new List<Report>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Report oReport = new Report();
                        Props.Copy_Prop_Values(oDBEntry, oReport);
                        oReport.Dimension = new Dimension();
                        Props.Copy_Prop_Values(oDBEntry.Dimension, oReport.Dimension);
                        oList_Report.Add(oReport);
                    }
                }
            }
            i_Params_Get_Report_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Report_By_Where_In_List_Adv", i_Params_Get_Report_By_Where_In_List_json, false);
            }
            return oList_Report;
        }
        #endregion
    }
}
