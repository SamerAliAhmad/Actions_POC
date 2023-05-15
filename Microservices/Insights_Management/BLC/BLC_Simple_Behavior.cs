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
        private Correlation_method _Correlation_method;
        private List<Correlation_method> _List_Correlation_method;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Correlation_method_Execution;
        private bool _Stop_Delete_Correlation_method_Execution;
        #endregion
        #endregion
        #region Get_Correlation_method_By_CORRELATION_METHOD_ID
        public Correlation_method Get_Correlation_method_By_CORRELATION_METHOD_ID(Params_Get_Correlation_method_By_CORRELATION_METHOD_ID i_Params_Get_Correlation_method_By_CORRELATION_METHOD_ID)
        {
            Correlation_method oCorrelation_method = null;
            var i_Params_Get_Correlation_method_By_CORRELATION_METHOD_ID_json = JsonConvert.SerializeObject(i_Params_Get_Correlation_method_By_CORRELATION_METHOD_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Correlation_method_By_CORRELATION_METHOD_ID", i_Params_Get_Correlation_method_By_CORRELATION_METHOD_ID_json, false);
            }
            #region Body Section.
            DALC.Correlation_method oDBEntry = _AppContext.Get_Correlation_method_By_CORRELATION_METHOD_ID(i_Params_Get_Correlation_method_By_CORRELATION_METHOD_ID.CORRELATION_METHOD_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Correlation_method").Replace("%2", i_Params_Get_Correlation_method_By_CORRELATION_METHOD_ID.CORRELATION_METHOD_ID.ToString()));
            }
            oCorrelation_method = new Correlation_method();
            Props.Copy_Prop_Values(oDBEntry, oCorrelation_method);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Correlation_method_By_CORRELATION_METHOD_ID", i_Params_Get_Correlation_method_By_CORRELATION_METHOD_ID_json, false);
            }
            return oCorrelation_method;
        }
        #endregion
        #region Get_Correlation_method_By_CORRELATION_METHOD_ID_List
        public List<Correlation_method> Get_Correlation_method_By_CORRELATION_METHOD_ID_List(Params_Get_Correlation_method_By_CORRELATION_METHOD_ID_List i_Params_Get_Correlation_method_By_CORRELATION_METHOD_ID_List)
        {
            List<Correlation_method> oList_Correlation_method = null;
            var i_Params_Get_Correlation_method_By_CORRELATION_METHOD_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Correlation_method_By_CORRELATION_METHOD_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Correlation_method_By_CORRELATION_METHOD_ID_List", i_Params_Get_Correlation_method_By_CORRELATION_METHOD_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Correlation_method> oList_DBEntry = _AppContext.Get_Correlation_method_By_CORRELATION_METHOD_ID_List(i_Params_Get_Correlation_method_By_CORRELATION_METHOD_ID_List.CORRELATION_METHOD_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Correlation_method = new List<Correlation_method>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Correlation_method oCorrelation_method = new Correlation_method();
                        Props.Copy_Prop_Values(oDBEntry, oCorrelation_method);
                        oList_Correlation_method.Add(oCorrelation_method);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Correlation_method_By_CORRELATION_METHOD_ID_List", i_Params_Get_Correlation_method_By_CORRELATION_METHOD_ID_List_json, false);
            }
            return oList_Correlation_method;
        }
        #endregion
        #region Get_Correlation_method_By_OWNER_ID
        public List<Correlation_method> Get_Correlation_method_By_OWNER_ID(Params_Get_Correlation_method_By_OWNER_ID i_Params_Get_Correlation_method_By_OWNER_ID)
        {
            List<Correlation_method> oList_Correlation_method = null;
            var i_Params_Get_Correlation_method_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Correlation_method_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Correlation_method_By_OWNER_ID", i_Params_Get_Correlation_method_By_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Correlation_method_By_OWNER_ID
            if (OnPreEvent_Get_Correlation_method_By_OWNER_ID != null)
            {
                OnPreEvent_Get_Correlation_method_By_OWNER_ID(i_Params_Get_Correlation_method_By_OWNER_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Correlation_method> oList_DBEntry = _AppContext.Get_Correlation_method_By_OWNER_ID(i_Params_Get_Correlation_method_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Correlation_method = new List<Correlation_method>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Correlation_method oCorrelation_method = new Correlation_method();
                        Props.Copy_Prop_Values(oDBEntry, oCorrelation_method);
                        oList_Correlation_method.Add(oCorrelation_method);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Correlation_method_By_OWNER_ID
            if (OnPostEvent_Get_Correlation_method_By_OWNER_ID != null)
            {
                OnPostEvent_Get_Correlation_method_By_OWNER_ID(oList_Correlation_method, i_Params_Get_Correlation_method_By_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Correlation_method_By_OWNER_ID", i_Params_Get_Correlation_method_By_OWNER_ID_json, false);
            }
            return oList_Correlation_method;
        }
        #endregion
        #region Get_Correlation_method_By_OWNER_ID_IS_DELETED
        public List<Correlation_method> Get_Correlation_method_By_OWNER_ID_IS_DELETED(Params_Get_Correlation_method_By_OWNER_ID_IS_DELETED i_Params_Get_Correlation_method_By_OWNER_ID_IS_DELETED)
        {
            List<Correlation_method> oList_Correlation_method = null;
            var i_Params_Get_Correlation_method_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Correlation_method_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Correlation_method_By_OWNER_ID_IS_DELETED", i_Params_Get_Correlation_method_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Correlation_method> oList_DBEntry = _AppContext.Get_Correlation_method_By_OWNER_ID_IS_DELETED(i_Params_Get_Correlation_method_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Correlation_method_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Correlation_method = new List<Correlation_method>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Correlation_method oCorrelation_method = new Correlation_method();
                        Props.Copy_Prop_Values(oDBEntry, oCorrelation_method);
                        oList_Correlation_method.Add(oCorrelation_method);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Correlation_method_By_OWNER_ID_IS_DELETED", i_Params_Get_Correlation_method_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Correlation_method;
        }
        #endregion
        #region Get_Correlation_method_By_Where
        public List<Correlation_method> Get_Correlation_method_By_Where(Params_Get_Correlation_method_By_Where i_Params_Get_Correlation_method_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Correlation_method> oList_Correlation_method = null;
            var i_Params_Get_Correlation_method_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Correlation_method_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Correlation_method_By_Where", i_Params_Get_Correlation_method_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Correlation_method_By_Where.OWNER_ID == null || i_Params_Get_Correlation_method_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Correlation_method_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Correlation_method_By_Where.OFFSET == null)
            {
                i_Params_Get_Correlation_method_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Correlation_method_By_Where.FETCH_NEXT == null || i_Params_Get_Correlation_method_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Correlation_method_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Correlation_method> oList_DBEntry = _AppContext.Get_Correlation_method_By_Where(i_Params_Get_Correlation_method_By_Where.NAME, i_Params_Get_Correlation_method_By_Where.DESCRIPTION, i_Params_Get_Correlation_method_By_Where.EQUATION_URL, i_Params_Get_Correlation_method_By_Where.OWNER_ID, i_Params_Get_Correlation_method_By_Where.OFFSET, i_Params_Get_Correlation_method_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Correlation_method = new List<Correlation_method>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Correlation_method oCorrelation_method = new Correlation_method();
                        Props.Copy_Prop_Values(oDBEntry, oCorrelation_method);
                        oList_Correlation_method.Add(oCorrelation_method);
                    }
                }
            }
            i_Params_Get_Correlation_method_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Correlation_method_By_Where", i_Params_Get_Correlation_method_By_Where_json, false);
            }
            return oList_Correlation_method;
        }
        #endregion
        #region Delete_Correlation_method
        public void Delete_Correlation_method(Params_Delete_Correlation_method i_Params_Delete_Correlation_method)
        {
            var i_Params_Delete_Correlation_method_json = JsonConvert.SerializeObject(i_Params_Delete_Correlation_method);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Correlation_method", i_Params_Delete_Correlation_method_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Correlation_method_By_CORRELATION_METHOD_ID oParams_Get_Correlation_method_By_CORRELATION_METHOD_ID = new Params_Get_Correlation_method_By_CORRELATION_METHOD_ID
                {
                    CORRELATION_METHOD_ID = i_Params_Delete_Correlation_method.CORRELATION_METHOD_ID
                };
                _Correlation_method = Get_Correlation_method_By_CORRELATION_METHOD_ID(oParams_Get_Correlation_method_By_CORRELATION_METHOD_ID);
                if (_Correlation_method != null)
                {
                    if (_Stop_Delete_Correlation_method_Execution)
                    {
                        _Stop_Delete_Correlation_method_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Correlation_method(i_Params_Delete_Correlation_method.CORRELATION_METHOD_ID);
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
                OnPostEvent_General("Delete_Correlation_method", i_Params_Delete_Correlation_method_json, false);
            }
        }
        #endregion
        #region Delete_Correlation_method_By_OWNER_ID
        public void Delete_Correlation_method_By_OWNER_ID(Params_Delete_Correlation_method_By_OWNER_ID i_Params_Delete_Correlation_method_By_OWNER_ID)
        {
            var i_Params_Delete_Correlation_method_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Correlation_method_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Correlation_method_By_OWNER_ID", i_Params_Delete_Correlation_method_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Correlation_method_By_OWNER_ID oParams_Get_Correlation_method_By_OWNER_ID = new Params_Get_Correlation_method_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Correlation_method_By_OWNER_ID.OWNER_ID
                };
                _List_Correlation_method = Get_Correlation_method_By_OWNER_ID(oParams_Get_Correlation_method_By_OWNER_ID);
                if (_List_Correlation_method != null && _List_Correlation_method.Count > 0)
                {
                    if (_Stop_Delete_Correlation_method_Execution)
                    {
                        _Stop_Delete_Correlation_method_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Correlation_method_By_OWNER_ID(i_Params_Delete_Correlation_method_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Correlation_method_By_OWNER_ID", i_Params_Delete_Correlation_method_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Correlation_method_By_OWNER_ID_IS_DELETED
        public void Delete_Correlation_method_By_OWNER_ID_IS_DELETED(Params_Delete_Correlation_method_By_OWNER_ID_IS_DELETED i_Params_Delete_Correlation_method_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Correlation_method_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Correlation_method_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Correlation_method_By_OWNER_ID_IS_DELETED", i_Params_Delete_Correlation_method_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Correlation_method_By_OWNER_ID_IS_DELETED oParams_Get_Correlation_method_By_OWNER_ID_IS_DELETED = new Params_Get_Correlation_method_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Correlation_method_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Correlation_method_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Correlation_method = Get_Correlation_method_By_OWNER_ID_IS_DELETED(oParams_Get_Correlation_method_By_OWNER_ID_IS_DELETED);
                if (_List_Correlation_method != null && _List_Correlation_method.Count > 0)
                {
                    if (_Stop_Delete_Correlation_method_Execution)
                    {
                        _Stop_Delete_Correlation_method_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Correlation_method_By_OWNER_ID_IS_DELETED(i_Params_Delete_Correlation_method_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Correlation_method_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Correlation_method_By_OWNER_ID_IS_DELETED", i_Params_Delete_Correlation_method_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Edit_Correlation_method
        public void Edit_Correlation_method(Correlation_method i_Correlation_method)
        {
            var i_Correlation_method_json = JsonConvert.SerializeObject(i_Correlation_method);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Correlation_method.CORRELATION_METHOD_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Correlation_method", i_Correlation_method_json, false);
            }
            #region Body Section.
            if (i_Correlation_method.CORRELATION_METHOD_ID == null || i_Correlation_method.CORRELATION_METHOD_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Correlation_method");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Correlation_method.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Correlation_method.IS_DELETED = false;
            }
            else
            {
                _Correlation_method = Get_Correlation_method_By_CORRELATION_METHOD_ID(new Params_Get_Correlation_method_By_CORRELATION_METHOD_ID
                {
                    CORRELATION_METHOD_ID = i_Correlation_method.CORRELATION_METHOD_ID
                });
            }
            i_Correlation_method.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Correlation_method.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Correlation_method.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Correlation_method_Execution)
            {
                _Stop_Edit_Correlation_method_Execution = false;
                return;
            }
            i_Correlation_method.CORRELATION_METHOD_ID = _AppContext.Edit_Correlation_method
            (
                i_Correlation_method.CORRELATION_METHOD_ID,
                i_Correlation_method.NAME,
                i_Correlation_method.DESCRIPTION,
                i_Correlation_method.EQUATION_URL,
                i_Correlation_method.ENTRY_USER_ID,
                i_Correlation_method.ENTRY_DATE,
                i_Correlation_method.LAST_UPDATE,
                i_Correlation_method.IS_DELETED,
                i_Correlation_method.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Correlation_method", i_Correlation_method_json, false);
            }
        }
        #endregion
        #region Edit_Correlation_method_List
        public void Edit_Correlation_method_List(Params_Edit_Correlation_method_List i_Params_Edit_Correlation_method_List)
        {
            var i_Params_Edit_Correlation_method_List_json = JsonConvert.SerializeObject(i_Params_Edit_Correlation_method_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Correlation_method_List", i_Params_Edit_Correlation_method_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Correlation_method_List.List_To_Edit != null)
            {
                i_Params_Edit_Correlation_method_List.List_Failed_Edit = new List<Correlation_method>();
                if (i_Params_Edit_Correlation_method_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oCorrelation_method in i_Params_Edit_Correlation_method_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Correlation_method(oCorrelation_method);
                        }
                        catch
                        {
                            i_Params_Edit_Correlation_method_List.List_Failed_Edit.Add(oCorrelation_method);
                        }
                    }
                }
                i_Params_Edit_Correlation_method_List.List_To_Edit = i_Params_Edit_Correlation_method_List.List_To_Edit.Except(i_Params_Edit_Correlation_method_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Correlation_method_List.List_To_Delete != null)
            {
                i_Params_Edit_Correlation_method_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Correlation_method_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Correlation_method_ID in i_Params_Edit_Correlation_method_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Correlation_method(new Params_Delete_Correlation_method()
                            {
                                CORRELATION_METHOD_ID = Correlation_method_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Correlation_method_List.List_Failed_Delete.Add(Correlation_method_ID);
                        }
                    }
                }
                i_Params_Edit_Correlation_method_List.List_To_Delete = i_Params_Edit_Correlation_method_List.List_To_Delete.Except(i_Params_Edit_Correlation_method_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Correlation_method_List", i_Params_Edit_Correlation_method_List_json, false);
            }
        }
        #endregion
    }
}