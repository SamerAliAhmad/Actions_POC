using System.Linq;
using SmartrTools;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region BLC_OnPostEvent_Get_Space_asset_By_SPACE_ID_List_Adv_Eager_Loading
        public void BLC_OnPostEvent_Get_Space_asset_By_SPACE_ID_List_Adv_Eager_Loading(List<Space_asset> i_Result, Params_Get_Space_asset_By_SPACE_ID_List i_Params_Get_Space_asset_By_SPACE_ID_List)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Space_asset_ID_List = i_Result.Select(space_asset => space_asset.SPACE_ASSET_ID).OrderBy(Space_asset_ID => Space_asset_ID);

                // ---------------------
                // Get All available Video_ai_asset entries.
                // ---------------------

                List<Service_Mesh.Video_ai_asset> oList_Video_ai_asset_Ext = this._service_mesh.Get_Video_ai_asset_By_SPACE_ASSET_ID_List(new Service_Mesh.Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List()
                {
                    SPACE_ASSET_ID_LIST = Space_asset_ID_List
                }).i_Result;
                List<Video_ai_asset> oList_Video_ai_asset = Props.Copy_Prop_Values_From_Api_Response<List<Video_ai_asset>>(oList_Video_ai_asset_Ext);
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oSpace_asset =>
                {
                    oSpace_asset.List_Video_ai_asset = oList_Video_ai_asset.Where(oVideo_ai_asset => oVideo_ai_asset.SPACE_ASSET_ID == oSpace_asset.SPACE_ASSET_ID).ToList();
                    return oSpace_asset;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Space_asset_By_SPACE_ID_Adv_Eager_Loading
        public void BLC_OnPostEvent_Get_Space_asset_By_SPACE_ID_Adv_Eager_Loading(List<Space_asset> i_Result, Params_Get_Space_asset_By_SPACE_ID i_Params_Get_Space_asset_By_SPACE_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Space_asset_ID_List = i_Result.Select(space_asset => space_asset.SPACE_ASSET_ID).OrderBy(Space_asset_ID => Space_asset_ID);

                // ---------------------
                // Get All available Video_ai_asset entries.
                // ---------------------

                List<Service_Mesh.Video_ai_asset> oList_Video_ai_asset_Ext = this._service_mesh.Get_Video_ai_asset_By_SPACE_ASSET_ID_List(new Service_Mesh.Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List()
                {
                    SPACE_ASSET_ID_LIST = Space_asset_ID_List
                }).i_Result;
                List<Video_ai_asset> oList_Video_ai_asset = Props.Copy_Prop_Values_From_Api_Response<List<Video_ai_asset>>(oList_Video_ai_asset_Ext);
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oSpace_asset =>
                {
                    oSpace_asset.List_Video_ai_asset = oList_Video_ai_asset.Where(oVideo_ai_asset => oVideo_ai_asset.SPACE_ASSET_ID == oSpace_asset.SPACE_ASSET_ID).ToList();
                    return oSpace_asset;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Space_asset_By_SPACE_ID_List_Eager_Loading
        public void BLC_OnPostEvent_Get_Space_asset_By_SPACE_ID_List_Eager_Loading(List<Space_asset> i_Result, Params_Get_Space_asset_By_SPACE_ID_List i_Params_Get_Space_asset_By_SPACE_ID_List)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Space_asset_ID_List = i_Result.Select(space_asset => space_asset.SPACE_ASSET_ID).OrderBy(Space_asset_ID => Space_asset_ID);

                // ---------------------
                // Get All available Video_ai_asset entries.
                // ---------------------

                List<Service_Mesh.Video_ai_asset> oList_Video_ai_asset_Ext = this._service_mesh.Get_Video_ai_asset_By_SPACE_ASSET_ID_List(new Service_Mesh.Params_Get_Video_ai_asset_By_SPACE_ASSET_ID_List()
                {
                    SPACE_ASSET_ID_LIST = Space_asset_ID_List
                }).i_Result;
                List<Video_ai_asset> oList_Video_ai_asset = Props.Copy_Prop_Values_From_Api_Response<List<Video_ai_asset>>(oList_Video_ai_asset_Ext);
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oSpace_asset =>
                {
                    oSpace_asset.List_Video_ai_asset = oList_Video_ai_asset.Where(oVideo_ai_asset => oVideo_ai_asset.SPACE_ASSET_ID == oSpace_asset.SPACE_ASSET_ID).ToList();
                    return oSpace_asset;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_Eager_Loading(Setup_category i_Result, Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID)
        {
            #region Body Section
            if (i_Result != null)
            {
                // ---------------------
                // Get All available Setup entries.
                // ---------------------
                i_Result.List_Setup = Get_Setup_By_SETUP_CATEGORY_ID(new Params_Get_Setup_By_SETUP_CATEGORY_ID()
                {
                    SETUP_CATEGORY_ID = i_Result.SETUP_CATEGORY_ID
                });
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Setup_category_By_OWNER_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Setup_category_By_OWNER_ID_Eager_Loading(List<Setup_category> i_Result, Params_Get_Setup_category_By_OWNER_ID i_Params_Get_Setup_category_By_OWNER_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Setup_category_ID_List = i_Result.Select(setup_category => setup_category.SETUP_CATEGORY_ID).OrderBy(Setup_category_ID => Setup_category_ID);

                // ---------------------
                // Get All available Setup entries.
                // ---------------------
                List<Setup> oList_Setup = Get_Setup_By_SETUP_CATEGORY_ID_List(new Params_Get_Setup_By_SETUP_CATEGORY_ID_List()
                {
                    SETUP_CATEGORY_ID_LIST = Setup_category_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oSetup_category =>
                {
                    oSetup_category.List_Setup = oList_Setup.Where(oSetup => oSetup.SETUP_CATEGORY_ID == oSetup_category.SETUP_CATEGORY_ID).ToList();
                    return oSetup_category;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Floor_By_ENTITY_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Floor_By_ENTITY_ID_Eager_Loading(List<Floor> i_Result, Params_Get_Floor_By_ENTITY_ID i_Params_Get_Floor_By_ENTITY_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Floor_ID_List = i_Result.Select(floor => floor.FLOOR_ID).OrderBy(Floor_ID => Floor_ID);

                // ---------------------
                // Get All available Space entries.
                // ---------------------
                List<Space> oList_Space = Get_Space_By_FLOOR_ID_List(new Params_Get_Space_By_FLOOR_ID_List()
                {
                    FLOOR_ID_LIST = Floor_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oFloor =>
                {
                    oFloor.List_Space = oList_Space.Where(oSpace => oSpace.FLOOR_ID == oFloor.FLOOR_ID).ToList();
                    return oFloor;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region Initialize_Eager_Loading_Mechanism
        public void Initialize_Eager_Loading_Mechanism()
        {
            #region Body Section.
            this.OnPostEvent_Get_Space_asset_By_SPACE_ID_List_Adv += new PostEvent_Handler_Get_Space_asset_By_SPACE_ID_List_Adv(BLC_OnPostEvent_Get_Space_asset_By_SPACE_ID_List_Adv_Eager_Loading);
            this.OnPostEvent_Get_Space_asset_By_SPACE_ID_Adv += new PostEvent_Handler_Get_Space_asset_By_SPACE_ID_Adv(BLC_OnPostEvent_Get_Space_asset_By_SPACE_ID_Adv_Eager_Loading);
            this.OnPostEvent_Get_Space_asset_By_SPACE_ID_List += new PostEvent_Handler_Get_Space_asset_By_SPACE_ID_List(BLC_OnPostEvent_Get_Space_asset_By_SPACE_ID_List_Eager_Loading);
            this.OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID += new PostEvent_Handler_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(BLC_OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_Eager_Loading);
            this.OnPostEvent_Get_Setup_category_By_OWNER_ID += new PostEvent_Handler_Get_Setup_category_By_OWNER_ID(BLC_OnPostEvent_Get_Setup_category_By_OWNER_ID_Eager_Loading);
            this.OnPostEvent_Get_Floor_By_ENTITY_ID += new PostEvent_Handler_Get_Floor_By_ENTITY_ID(BLC_OnPostEvent_Get_Floor_By_ENTITY_ID_Eager_Loading);
            #endregion
        }
        #endregion
    }
}