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
        private Method_run _Method_run;
        private List<Method_run> _List_Method_run;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Method_run_Execution;
        private bool _Stop_Delete_Method_run_Execution;
        #endregion
        #endregion
        #region Get_Method_run_By_METHOD_RUN_ID
        public Method_run Get_Method_run_By_METHOD_RUN_ID(Params_Get_Method_run_By_METHOD_RUN_ID i_Params_Get_Method_run_By_METHOD_RUN_ID)
        {
            Method_run oMethod_run = null;
            var i_Params_Get_Method_run_By_METHOD_RUN_ID_json = JsonConvert.SerializeObject(i_Params_Get_Method_run_By_METHOD_RUN_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Method_run_By_METHOD_RUN_ID", i_Params_Get_Method_run_By_METHOD_RUN_ID_json, false);
            }
            #region Body Section.
            DALC.Method_run oDBEntry = _AppContext.Get_Method_run_By_METHOD_RUN_ID(i_Params_Get_Method_run_By_METHOD_RUN_ID.METHOD_RUN_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Method_run").Replace("%2", i_Params_Get_Method_run_By_METHOD_RUN_ID.METHOD_RUN_ID.ToString()));
            }
            oMethod_run = new Method_run();
            Props.Copy_Prop_Values(oDBEntry, oMethod_run);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Method_run_By_METHOD_RUN_ID", i_Params_Get_Method_run_By_METHOD_RUN_ID_json, false);
            }
            return oMethod_run;
        }
        #endregion
        #region Get_Method_run_By_METHOD_RUN_ID_List
        public List<Method_run> Get_Method_run_By_METHOD_RUN_ID_List(Params_Get_Method_run_By_METHOD_RUN_ID_List i_Params_Get_Method_run_By_METHOD_RUN_ID_List)
        {
            List<Method_run> oList_Method_run = null;
            var i_Params_Get_Method_run_By_METHOD_RUN_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Method_run_By_METHOD_RUN_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Method_run_By_METHOD_RUN_ID_List", i_Params_Get_Method_run_By_METHOD_RUN_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Method_run> oList_DBEntry = _AppContext.Get_Method_run_By_METHOD_RUN_ID_List(i_Params_Get_Method_run_By_METHOD_RUN_ID_List.METHOD_RUN_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Method_run = new List<Method_run>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Method_run oMethod_run = new Method_run();
                        Props.Copy_Prop_Values(oDBEntry, oMethod_run);
                        oList_Method_run.Add(oMethod_run);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Method_run_By_METHOD_RUN_ID_List", i_Params_Get_Method_run_By_METHOD_RUN_ID_List_json, false);
            }
            return oList_Method_run;
        }
        #endregion
        #region Get_Method_run_By_OWNER_ID
        public List<Method_run> Get_Method_run_By_OWNER_ID(Params_Get_Method_run_By_OWNER_ID i_Params_Get_Method_run_By_OWNER_ID)
        {
            List<Method_run> oList_Method_run = null;
            var i_Params_Get_Method_run_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Method_run_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Method_run_By_OWNER_ID", i_Params_Get_Method_run_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Method_run> oList_DBEntry = _AppContext.Get_Method_run_By_OWNER_ID(i_Params_Get_Method_run_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Method_run = new List<Method_run>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Method_run oMethod_run = new Method_run();
                        Props.Copy_Prop_Values(oDBEntry, oMethod_run);
                        oList_Method_run.Add(oMethod_run);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Method_run_By_OWNER_ID", i_Params_Get_Method_run_By_OWNER_ID_json, false);
            }
            return oList_Method_run;
        }
        #endregion
        #region Get_Method_run_By_OWNER_ID_IS_DELETED
        public List<Method_run> Get_Method_run_By_OWNER_ID_IS_DELETED(Params_Get_Method_run_By_OWNER_ID_IS_DELETED i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED)
        {
            List<Method_run> oList_Method_run = null;
            var i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Method_run_By_OWNER_ID_IS_DELETED", i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Method_run> oList_DBEntry = _AppContext.Get_Method_run_By_OWNER_ID_IS_DELETED(i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Method_run = new List<Method_run>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Method_run oMethod_run = new Method_run();
                        Props.Copy_Prop_Values(oDBEntry, oMethod_run);
                        oList_Method_run.Add(oMethod_run);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Method_run_By_OWNER_ID_IS_DELETED", i_Params_Get_Method_run_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Method_run;
        }
        #endregion
        #region Get_Method_run_By_Where
        public List<Method_run> Get_Method_run_By_Where(Params_Get_Method_run_By_Where i_Params_Get_Method_run_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Method_run> oList_Method_run = null;
            var i_Params_Get_Method_run_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Method_run_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Method_run_By_Where", i_Params_Get_Method_run_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Method_run_By_Where.OWNER_ID == null || i_Params_Get_Method_run_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Method_run_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Method_run_By_Where.OFFSET == null)
            {
                i_Params_Get_Method_run_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Method_run_By_Where.FETCH_NEXT == null || i_Params_Get_Method_run_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Method_run_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Method_run> oList_DBEntry = _AppContext.Get_Method_run_By_Where(i_Params_Get_Method_run_By_Where.METHOD_NAME, i_Params_Get_Method_run_By_Where.METHOD_PARAMS, i_Params_Get_Method_run_By_Where.OWNER_ID, i_Params_Get_Method_run_By_Where.OFFSET, i_Params_Get_Method_run_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Method_run = new List<Method_run>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Method_run oMethod_run = new Method_run();
                        Props.Copy_Prop_Values(oDBEntry, oMethod_run);
                        oList_Method_run.Add(oMethod_run);
                    }
                }
            }
            i_Params_Get_Method_run_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Method_run_By_Where", i_Params_Get_Method_run_By_Where_json, false);
            }
            return oList_Method_run;
        }
        #endregion
        #region Delete_Method_run
        public void Delete_Method_run(Params_Delete_Method_run i_Params_Delete_Method_run)
        {
            var i_Params_Delete_Method_run_json = JsonConvert.SerializeObject(i_Params_Delete_Method_run);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Method_run", i_Params_Delete_Method_run_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Method_run_By_METHOD_RUN_ID oParams_Get_Method_run_By_METHOD_RUN_ID = new Params_Get_Method_run_By_METHOD_RUN_ID
                {
                    METHOD_RUN_ID = i_Params_Delete_Method_run.METHOD_RUN_ID
                };
                _Method_run = Get_Method_run_By_METHOD_RUN_ID(oParams_Get_Method_run_By_METHOD_RUN_ID);
                if (_Method_run != null)
                {
                    if (_Stop_Delete_Method_run_Execution)
                    {
                        _Stop_Delete_Method_run_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Method_run(i_Params_Delete_Method_run.METHOD_RUN_ID);
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
                OnPostEvent_General("Delete_Method_run", i_Params_Delete_Method_run_json, false);
            }
        }
        #endregion
        #region Delete_Method_run_By_OWNER_ID
        public void Delete_Method_run_By_OWNER_ID(Params_Delete_Method_run_By_OWNER_ID i_Params_Delete_Method_run_By_OWNER_ID)
        {
            var i_Params_Delete_Method_run_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Method_run_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Method_run_By_OWNER_ID", i_Params_Delete_Method_run_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Method_run_By_OWNER_ID oParams_Get_Method_run_By_OWNER_ID = new Params_Get_Method_run_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Method_run_By_OWNER_ID.OWNER_ID
                };
                _List_Method_run = Get_Method_run_By_OWNER_ID(oParams_Get_Method_run_By_OWNER_ID);
                if (_List_Method_run != null && _List_Method_run.Count > 0)
                {
                    if (_Stop_Delete_Method_run_Execution)
                    {
                        _Stop_Delete_Method_run_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Method_run_By_OWNER_ID(i_Params_Delete_Method_run_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Method_run_By_OWNER_ID", i_Params_Delete_Method_run_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Method_run_By_OWNER_ID_IS_DELETED
        public void Delete_Method_run_By_OWNER_ID_IS_DELETED(Params_Delete_Method_run_By_OWNER_ID_IS_DELETED i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Method_run_By_OWNER_ID_IS_DELETED", i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Method_run_By_OWNER_ID_IS_DELETED oParams_Get_Method_run_By_OWNER_ID_IS_DELETED = new Params_Get_Method_run_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Method_run = Get_Method_run_By_OWNER_ID_IS_DELETED(oParams_Get_Method_run_By_OWNER_ID_IS_DELETED);
                if (_List_Method_run != null && _List_Method_run.Count > 0)
                {
                    if (_Stop_Delete_Method_run_Execution)
                    {
                        _Stop_Delete_Method_run_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Method_run_By_OWNER_ID_IS_DELETED(i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Method_run_By_OWNER_ID_IS_DELETED", i_Params_Delete_Method_run_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Edit_Method_run
        public void Edit_Method_run(Method_run i_Method_run)
        {
            var i_Method_run_json = JsonConvert.SerializeObject(i_Method_run);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Method_run.METHOD_RUN_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Method_run", i_Method_run_json, false);
            }
            #region Body Section.
            if (i_Method_run.METHOD_RUN_ID == null || i_Method_run.METHOD_RUN_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Method_run");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Method_run.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Method_run.IS_DELETED = false;
            }
            else
            {
                _Method_run = Get_Method_run_By_METHOD_RUN_ID(new Params_Get_Method_run_By_METHOD_RUN_ID
                {
                    METHOD_RUN_ID = i_Method_run.METHOD_RUN_ID
                });
            }
            i_Method_run.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Method_run.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Method_run.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Method_run
            if (OnPreEvent_Edit_Method_run != null)
            {
                OnPreEvent_Edit_Method_run(i_Method_run, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Method_run_Execution)
            {
                _Stop_Edit_Method_run_Execution = false;
                return;
            }
            i_Method_run.METHOD_RUN_ID = _AppContext.Edit_Method_run
            (
                i_Method_run.METHOD_RUN_ID,
                i_Method_run.METHOD_NAME,
                i_Method_run.RUN_DATE,
                i_Method_run.RUN_HOUR,
                i_Method_run.RUN_MINUTE,
                i_Method_run.RUN_SECOND,
                i_Method_run.EXECUTION_TIME,
                i_Method_run.IS_CACHED,
                i_Method_run.METHOD_PARAMS,
                i_Method_run.ENTRY_USER_ID,
                i_Method_run.ENTRY_DATE,
                i_Method_run.OWNER_ID,
                i_Method_run.LAST_UPDATE,
                i_Method_run.IS_DELETED
            );
            #region PostEvent_Edit_Method_run
            if (OnPostEvent_Edit_Method_run != null)
            {
                OnPostEvent_Edit_Method_run(i_Method_run, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Method_run", i_Method_run_json, false);
            }
        }
        #endregion
        #region Edit_Method_run_List
        public void Edit_Method_run_List(Params_Edit_Method_run_List i_Params_Edit_Method_run_List)
        {
            var i_Params_Edit_Method_run_List_json = JsonConvert.SerializeObject(i_Params_Edit_Method_run_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Method_run_List", i_Params_Edit_Method_run_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Method_run_List.List_To_Edit != null)
            {
                i_Params_Edit_Method_run_List.List_Failed_Edit = new List<Method_run>();
                if (i_Params_Edit_Method_run_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oMethod_run in i_Params_Edit_Method_run_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Method_run(oMethod_run);
                        }
                        catch
                        {
                            i_Params_Edit_Method_run_List.List_Failed_Edit.Add(oMethod_run);
                        }
                    }
                }
                i_Params_Edit_Method_run_List.List_To_Edit = i_Params_Edit_Method_run_List.List_To_Edit.Except(i_Params_Edit_Method_run_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Method_run_List.List_To_Delete != null)
            {
                i_Params_Edit_Method_run_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Method_run_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Method_run_ID in i_Params_Edit_Method_run_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Method_run(new Params_Delete_Method_run()
                            {
                                METHOD_RUN_ID = Method_run_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Method_run_List.List_Failed_Delete.Add(Method_run_ID);
                        }
                    }
                }
                i_Params_Edit_Method_run_List.List_To_Delete = i_Params_Edit_Method_run_List.List_To_Delete.Except(i_Params_Edit_Method_run_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Method_run_List", i_Params_Edit_Method_run_List_json, false);
            }
        }
        #endregion
    }
}