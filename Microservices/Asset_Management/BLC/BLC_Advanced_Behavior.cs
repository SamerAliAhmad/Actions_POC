using System;
using SmartrTools;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Get_Asset_By_ASSET_ID_Adv
        public Asset Get_Asset_By_ASSET_ID_Adv(Params_Get_Asset_By_ASSET_ID i_Params_Get_Asset_By_ASSET_ID)
        {
            Asset oAsset = null;
            var i_Params_Get_Asset_By_ASSET_ID_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_ID_Adv", i_Params_Get_Asset_By_ASSET_ID_json, false);
            }
            #region PreEvent_Get_Asset_By_ASSET_ID_Adv
            if (OnPreEvent_Get_Asset_By_ASSET_ID_Adv != null)
            {
                OnPreEvent_Get_Asset_By_ASSET_ID_Adv(i_Params_Get_Asset_By_ASSET_ID);
            }
            #endregion
            #region Body Section.
            DALC.Asset oDBEntry = _AppContext.Get_Asset_By_ASSET_ID_Adv(i_Params_Get_Asset_By_ASSET_ID.ASSET_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Asset").Replace("%2", i_Params_Get_Asset_By_ASSET_ID.ASSET_ID.ToString()));
            }
            oAsset = new Asset();
            Props.Copy_Prop_Values(oDBEntry, oAsset);
            oAsset.Asset_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Asset_type_setup, oAsset.Asset_type_setup);
            #endregion
            #region PostEvent_Get_Asset_By_ASSET_ID_Adv
            if (OnPostEvent_Get_Asset_By_ASSET_ID_Adv != null)
            {
                OnPostEvent_Get_Asset_By_ASSET_ID_Adv(ref oAsset, i_Params_Get_Asset_By_ASSET_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_ID_Adv", i_Params_Get_Asset_By_ASSET_ID_json, false);
            }
            return oAsset;
        }
        #endregion
        #region Get_Asset_By_ASSET_ID_List_Adv
        public List<Asset> Get_Asset_By_ASSET_ID_List_Adv(Params_Get_Asset_By_ASSET_ID_List i_Params_Get_Asset_By_ASSET_ID_List)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_ASSET_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_ID_List_Adv", i_Params_Get_Asset_By_ASSET_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_ASSET_ID_List_Adv(i_Params_Get_Asset_By_ASSET_ID_List.ASSET_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oAsset.Asset_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Asset_type_setup, oAsset.Asset_type_setup);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_ID_List_Adv", i_Params_Get_Asset_By_ASSET_ID_List_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_OWNER_ID_Adv
        public List<Asset> Get_Asset_By_OWNER_ID_Adv(Params_Get_Asset_By_OWNER_ID i_Params_Get_Asset_By_OWNER_ID)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_OWNER_ID_Adv", i_Params_Get_Asset_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_OWNER_ID_Adv(i_Params_Get_Asset_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oAsset.Asset_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Asset_type_setup, oAsset.Asset_type_setup);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_OWNER_ID_Adv", i_Params_Get_Asset_By_OWNER_ID_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID_Adv
        public List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID_Adv(Params_Get_Asset_By_ASSET_TYPE_SETUP_ID i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID_Adv", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_ASSET_TYPE_SETUP_ID_Adv(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID.ASSET_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oAsset.Asset_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Asset_type_setup, oAsset.Asset_type_setup);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID_Adv", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_OWNER_ID_IS_DELETED_Adv
        public List<Asset> Get_Asset_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Asset_By_OWNER_ID_IS_DELETED i_Params_Get_Asset_By_OWNER_ID_IS_DELETED)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Asset_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Asset_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oAsset.Asset_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Asset_type_setup, oAsset.Asset_type_setup);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Asset_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_ASSET_TYPE_SETUP_ID_List_Adv
        public List<Asset> Get_Asset_By_ASSET_TYPE_SETUP_ID_List_Adv(Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List)
        {
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID_List_Adv", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_ASSET_TYPE_SETUP_ID_List_Adv(i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List.ASSET_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oAsset.Asset_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Asset_type_setup, oAsset.Asset_type_setup);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_ASSET_TYPE_SETUP_ID_List_Adv", i_Params_Get_Asset_By_ASSET_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_Where_Adv
        public List<Asset> Get_Asset_By_Where_Adv(Params_Get_Asset_By_Where i_Params_Get_Asset_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_Where_Adv", i_Params_Get_Asset_By_Where_json, false);
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
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_Where_Adv(i_Params_Get_Asset_By_Where.NAME, i_Params_Get_Asset_By_Where.GLTF_URL, i_Params_Get_Asset_By_Where.OWNER_ID, i_Params_Get_Asset_By_Where.OFFSET, i_Params_Get_Asset_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oAsset.Asset_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Asset_type_setup, oAsset.Asset_type_setup);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            i_Params_Get_Asset_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_Where_Adv", i_Params_Get_Asset_By_Where_json, false);
            }
            return oList_Asset;
        }
        #endregion
        #region Get_Asset_By_Where_In_List_Adv
        public List<Asset> Get_Asset_By_Where_In_List_Adv(Params_Get_Asset_By_Where_In_List i_Params_Get_Asset_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Asset> oList_Asset = null;
            var i_Params_Get_Asset_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Asset_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Asset_By_Where_In_List_Adv", i_Params_Get_Asset_By_Where_In_List_json, false);
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
            List<DALC.Asset> oList_DBEntry = _AppContext.Get_Asset_By_Where_In_List_Adv(i_Params_Get_Asset_By_Where_In_List.NAME, i_Params_Get_Asset_By_Where_In_List.GLTF_URL, i_Params_Get_Asset_By_Where_In_List.ASSET_TYPE_SETUP_ID_LIST, i_Params_Get_Asset_By_Where_In_List.OWNER_ID, i_Params_Get_Asset_By_Where_In_List.OFFSET, i_Params_Get_Asset_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Asset = new List<Asset>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Asset oAsset = new Asset();
                        Props.Copy_Prop_Values(oDBEntry, oAsset);
                        oAsset.Asset_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Asset_type_setup, oAsset.Asset_type_setup);
                        oList_Asset.Add(oAsset);
                    }
                }
            }
            i_Params_Get_Asset_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Asset_By_Where_In_List_Adv", i_Params_Get_Asset_By_Where_In_List_json, false);
            }
            return oList_Asset;
        }
        #endregion
    }
}
