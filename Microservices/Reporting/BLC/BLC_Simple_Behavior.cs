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
        private Report _Report;
        private List<Report> _List_Report;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Report_Execution;
        private bool _Stop_Delete_Report_Execution;
        #endregion
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