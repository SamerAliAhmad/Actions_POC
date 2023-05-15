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
        private Asset _Asset;
        private List<Asset> _List_Asset;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Asset_Execution;
        private bool _Stop_Delete_Asset_Execution;
        #endregion
        #endregion
        #region Get_Asset_By_ASSET_ID
        public Asset Get_Asset_By_ASSET_ID(Params_Get_Asset_By_ASSET_ID i_Params_Get_Asset_By_ASSET_ID)
        {
            Asset oAsset = null;
            var i_Params_Get_Asset_By_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_ID", i_Params_Get_Asset_By_ASSET_ID_json, false);
            }
            #region Body Section.
            DALC.Asset oDBEntry = _AppContext.Get_Asset_By_ASSET_ID(i_Params_Get_Asset_By_ASSET_ID.ASSET_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Asset").Replace("%2", i_Params_Get_Asset_By_ASSET_ID.ASSET_ID.ToString()));
            }
            oAsset = new Asset();
            Props.Copy_Prop_Values(oDBEntry, oAsset);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_ID", i_Params_Get_Asset_By_ASSET_ID_json, false);
            }
            return oAsset;
        }
        #endregion
        #region Get_Asset_By_ASSET_ID_List
        public List<Asset> Get_Asset_By_ASSET_ID_List(Params_Get_Asset_By_ASSET_ID_List i_Params_Get_Asset_By_ASSET_ID_List)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_ID_List", i_Params_Get_Asset_By_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_ASSET_ID_List(i_Params_Get_Asset_By_ASSET_ID_List.ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_ID_List", i_Params_Get_Asset_By_ASSET_ID_List_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_OWNER_ID
        public List<Asset> Get_Asset_By_OWNER_ID(Params_Get_Asset_By_OWNER_ID i_Params_Get_Asset_By_OWNER_ID)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_OWNER_ID", i_Params_Get_Asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_OWNER_ID(i_Params_Get_Asset_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_OWNER_ID", i_Params_Get_Asset_By_OWNER_ID_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID
        public List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID(Params_Get_Asset_By_ASSET_TYPE_SETUP_ID i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_ASSET_TYPE_SETUP_ID(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID.ASSET_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_OWNER_ID_IS_DELETED
        public List<Asset> Get_Asset_By_OWNER_ID_IS_DELETED(Params_Get_Asset_By_OWNER_ID_IS_DELETED i_Params_Get_Asset_By_OWNER_ID_IS_DELETED)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_OWNER_ID_IS_DELETED", i_Params_Get_Asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_OWNER_ID_IS_DELETED(i_Params_Get_Asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_OWNER_ID_IS_DELETED", i_Params_Get_Asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID_List
        public List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID_List(Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID_List", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_ASSET_TYPE_SETUP_ID_List(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List.ASSET_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID_List", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_Where
        public List<Asset> Get_Asset_By_Where(Params_Get_Asset_By_Where i_Params_Get_Asset_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_Where", i_Params_Get_Asset_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Asset_By_Where.OWNER_ID == null || i_Params_Get_Asset_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Asset_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Asset_By_Where.OFFSET == null)
            {
                i_Params_Get_Asset_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Asset_By_Where.FETCH_NEXT == null || i_Params_Get_Asset_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Asset_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_Where(i_Params_Get_Asset_By_Where.NAME, i_Params_Get_Asset_By_Where.GLTF_URL, i_Params_Get_Asset_By_Where.OWNER_ID, i_Params_Get_Asset_By_Where.OFFSET, i_Params_Get_Asset_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            i_Params_Get_Asset_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_Where", i_Params_Get_Asset_By_Where_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_Where_In_List
        public List<Asset> Get_Asset_By_Where_In_List(Params_Get_Asset_By_Where_In_List i_Params_Get_Asset_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_Where_In_List", i_Params_Get_Asset_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Asset_By_Where_In_List.OWNER_ID == null || i_Params_Get_Asset_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Asset_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Asset_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Asset_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Asset_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Asset_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Asset_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Asset_By_Where_In_List.ASSET_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Asset_By_Where_In_List.ASSET_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_Where_In_List(i_Params_Get_Asset_By_Where_In_List.NAME, i_Params_Get_Asset_By_Where_In_List.GLTF_URL, i_Params_Get_Asset_By_Where_In_List.ASSET_TYPE_SETUP_ID_LIST, i_Params_Get_Asset_By_Where_In_List.OWNER_ID, i_Params_Get_Asset_By_Where_In_List.OFFSET, i_Params_Get_Asset_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            i_Params_Get_Asset_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_Where_In_List", i_Params_Get_Asset_By_Where_In_List_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Delete_Asset
        public void Delete_Asset(Params_Delete_Asset i_Params_Delete_Asset)
        {
            var i_Params_Delete_Asset_json = JsonConvert.SerializeObject(i_Params_Delete_Asset);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Asset", i_Params_Delete_Asset_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Asset_By_ASSET_ID oParams_Get_Asset_By_ASSET_ID = new Params_Get_Asset_By_ASSET_ID
                {
                    ASSET_ID = i_Params_Delete_Asset.ASSET_ID
                };
                _Asset = Get_Asset_By_ASSET_ID(oParams_Get_Asset_By_ASSET_ID);
                if (_Asset != null)
                {
                    if (_Stop_Delete_Asset_Execution)
                    {
                        _Stop_Delete_Asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Asset(i_Params_Delete_Asset.ASSET_ID);
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
                OnPostEvent_General("Delete_Asset", i_Params_Delete_Asset_json, false);
            }
        }
        #endregion
        #region Delete_Asset_By_OWNER_ID
        public void Delete_Asset_By_OWNER_ID(Params_Delete_Asset_By_OWNER_ID i_Params_Delete_Asset_By_OWNER_ID)
        {
            var i_Params_Delete_Asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Asset_By_OWNER_ID", i_Params_Delete_Asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Asset_By_OWNER_ID oParams_Get_Asset_By_OWNER_ID = new Params_Get_Asset_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Asset_By_OWNER_ID.OWNER_ID
                };
                _List_Asset = Get_Asset_By_OWNER_ID(oParams_Get_Asset_By_OWNER_ID);
                if (_List_Asset != null && _List_Asset.Count > 0)
                {
                    if (_Stop_Delete_Asset_Execution)
                    {
                        _Stop_Delete_Asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Asset_By_OWNER_ID(i_Params_Delete_Asset_By_OWNER_ID.OWNER_ID);
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
                OnPostEvent_General("Delete_Asset_By_OWNER_ID", i_Params_Delete_Asset_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Asset_By_ASSET_TYPE_SETUP_ID
        public void Delete_Asset_By_ASSET_TYPE_SETUP_ID(Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Asset_By_ASSET_TYPE_SETUP_ID", i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Asset_By_ASSET_TYPE_SETUP_ID oParams_Get_Asset_By_ASSET_TYPE_SETUP_ID = new Params_Get_Asset_By_ASSET_TYPE_SETUP_ID
                {
                    ASSET_TYPE_SETUP_ID = i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID.ASSET_TYPE_SETUP_ID
                };
                _List_Asset = Get_Asset_By_ASSET_TYPE_SETUP_ID(oParams_Get_Asset_By_ASSET_TYPE_SETUP_ID);
                if (_List_Asset != null && _List_Asset.Count > 0)
                {
                    if (_Stop_Delete_Asset_Execution)
                    {
                        _Stop_Delete_Asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Asset_By_ASSET_TYPE_SETUP_ID(i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID.ASSET_TYPE_SETUP_ID);
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
                OnPostEvent_General("Delete_Asset_By_ASSET_TYPE_SETUP_ID", i_Params_Delete_Asset_By_ASSET_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Asset_By_OWNER_ID_IS_DELETED
        public void Delete_Asset_By_OWNER_ID_IS_DELETED(Params_Delete_Asset_By_OWNER_ID_IS_DELETED i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Asset_By_OWNER_ID_IS_DELETED", i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Asset_By_OWNER_ID_IS_DELETED oParams_Get_Asset_By_OWNER_ID_IS_DELETED = new Params_Get_Asset_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Asset = Get_Asset_By_OWNER_ID_IS_DELETED(oParams_Get_Asset_By_OWNER_ID_IS_DELETED);
                if (_List_Asset != null && _List_Asset.Count > 0)
                {
                    if (_Stop_Delete_Asset_Execution)
                    {
                        _Stop_Delete_Asset_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Asset_By_OWNER_ID_IS_DELETED(i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
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
                OnPostEvent_General("Delete_Asset_By_OWNER_ID_IS_DELETED", i_Params_Delete_Asset_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Edit_Asset
        public void Edit_Asset(Asset i_Asset)
        {
            var i_Asset_json = JsonConvert.SerializeObject(i_Asset);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Asset.ASSET_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Asset", i_Asset_json, false);
            }
            #region Body Section.
            if (i_Asset.ASSET_ID == null || i_Asset.ASSET_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Asset");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Asset.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Asset.IS_DELETED = false;
            }
            else
            {
                _Asset = Get_Asset_By_ASSET_ID(new Params_Get_Asset_By_ASSET_ID
                {
                    ASSET_ID = i_Asset.ASSET_ID
                });
            }
            i_Asset.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Asset.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Asset.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Asset_Execution)
            {
                _Stop_Edit_Asset_Execution = false;
                return;
            }
            i_Asset.ASSET_ID = _AppContext.Edit_Asset
            (
                i_Asset.ASSET_ID,
                i_Asset.ASSET_TYPE_SETUP_ID,
                i_Asset.NAME,
                i_Asset.GLTF_URL,
                i_Asset.ENTRY_USER_ID,
                i_Asset.ENTRY_DATE,
                i_Asset.LAST_UPDATE,
                i_Asset.IS_DELETED,
                i_Asset.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Asset", i_Asset_json, false);
            }
        }
        #endregion
        #region Edit_Asset_List
        public void Edit_Asset_List(Params_Edit_Asset_List i_Params_Edit_Asset_List)
        {
            var i_Params_Edit_Asset_List_json = JsonConvert.SerializeObject(i_Params_Edit_Asset_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Asset_List", i_Params_Edit_Asset_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Asset_List.List_To_Edit != null)
            {
                i_Params_Edit_Asset_List.List_Failed_Edit = new List<Asset>();
                if (i_Params_Edit_Asset_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oAsset in i_Params_Edit_Asset_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Asset(oAsset);
                        }
                        catch
                        {
                            i_Params_Edit_Asset_List.List_Failed_Edit.Add(oAsset);
                        }
                    }
                }
                i_Params_Edit_Asset_List.List_To_Edit = i_Params_Edit_Asset_List.List_To_Edit.Except(i_Params_Edit_Asset_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Asset_List.List_To_Delete != null)
            {
                i_Params_Edit_Asset_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Asset_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Asset_ID in i_Params_Edit_Asset_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Asset(new Params_Delete_Asset()
                            {
                                ASSET_ID = Asset_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Asset_List.List_Failed_Delete.Add(Asset_ID);
                        }
                    }
                }
                i_Params_Edit_Asset_List.List_To_Delete = i_Params_Edit_Asset_List.List_To_Delete.Except(i_Params_Edit_Asset_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Asset_List", i_Params_Edit_Asset_List_json, false);
            }
        }
        #endregion
    }
}