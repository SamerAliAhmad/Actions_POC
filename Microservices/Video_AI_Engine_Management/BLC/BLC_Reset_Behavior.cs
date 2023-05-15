using System;
using SmartrTools;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region BLC_OnPostEvent_Edit_Video_ai_engine_Reset
        public void BLC_OnPostEvent_Edit_Video_ai_engine_Reset(Video_ai_engine i_Video_ai_engine, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Video_ai_engine != null)
            {
                if (i_Video_ai_engine.List_Video_ai_instance != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Video_ai_engine.List_Video_ai_instance.Count == 0)
                        {
                            Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID(new Params_Delete_Video_ai_instance_By_VIDEO_AI_ENGINE_ID()
                            {
                                VIDEO_AI_ENGINE_ID = i_Video_ai_engine.VIDEO_AI_ENGINE_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Video_ai_instance
                            // -----------------------------
                            List<Video_ai_instance> oList_Video_ai_instance = Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID(new Params_Get_Video_ai_instance_By_VIDEO_AI_ENGINE_ID()
                            {
                                VIDEO_AI_ENGINE_ID = i_Video_ai_engine.VIDEO_AI_ENGINE_ID
                            });
                            if (oList_Video_ai_instance != null && oList_Video_ai_instance.Count > 0)
                            {
                                oList_Video_ai_instance = oList_Video_ai_instance.Where(oVideo_ai_instance => !i_Video_ai_engine.List_Video_ai_instance.Any(oCurrent_Video_ai_instance => oCurrent_Video_ai_instance.VIDEO_AI_INSTANCE_ID == oVideo_ai_instance.VIDEO_AI_INSTANCE_ID)).ToList();
                                if (oList_Video_ai_instance.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    Edit_Video_ai_instance_List(new Params_Edit_Video_ai_instance_List()
                                    {
                                        List_To_Delete = oList_Video_ai_instance.Select(oVideo_ai_instance => oVideo_ai_instance.VIDEO_AI_INSTANCE_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Video_ai_instance
                    // -----------------------------
                    if (i_Video_ai_engine.List_Video_ai_instance != null && i_Video_ai_engine.List_Video_ai_instance.Count > 0)
                    {
                        foreach (var oVideo_ai_instance in i_Video_ai_engine.List_Video_ai_instance)
                        {
                            oVideo_ai_instance.VIDEO_AI_ENGINE_ID = i_Video_ai_engine.VIDEO_AI_ENGINE_ID;
                            Edit_Video_ai_instance(oVideo_ai_instance);
                        }
                    }
                }
                // -----------------------------
            }
        }
        #endregion
        #region BLC_OnPostEvent_Edit_Setup_category_Reset
        public void BLC_OnPostEvent_Edit_Setup_category_Reset(Setup_category i_Setup_category, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Setup_category != null)
            {
                if (i_Setup_category.List_Setup != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Setup_category.List_Setup.Count == 0)
                        {
                            Delete_Setup_By_SETUP_CATEGORY_ID(new Params_Delete_Setup_By_SETUP_CATEGORY_ID()
                            {
                                SETUP_CATEGORY_ID = i_Setup_category.SETUP_CATEGORY_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Setup
                            // -----------------------------
                            List<Setup> oList_Setup = Get_Setup_By_SETUP_CATEGORY_ID(new Params_Get_Setup_By_SETUP_CATEGORY_ID()
                            {
                                SETUP_CATEGORY_ID = i_Setup_category.SETUP_CATEGORY_ID
                            });
                            if (oList_Setup != null && oList_Setup.Count > 0)
                            {
                                oList_Setup = oList_Setup.Where(oSetup => !i_Setup_category.List_Setup.Any(oCurrent_Setup => oCurrent_Setup.SETUP_ID == oSetup.SETUP_ID)).ToList();
                                if (oList_Setup.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    Edit_Setup_List(new Params_Edit_Setup_List()
                                    {
                                        List_To_Delete = oList_Setup.Select(oSetup => oSetup.SETUP_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Setup
                    // -----------------------------
                    if (i_Setup_category.List_Setup != null && i_Setup_category.List_Setup.Count > 0)
                    {
                        foreach (var oSetup in i_Setup_category.List_Setup)
                        {
                            oSetup.SETUP_CATEGORY_ID = i_Setup_category.SETUP_CATEGORY_ID;
                            Edit_Setup(oSetup);
                        }
                    }
                }
                // -----------------------------
            }
        }
        #endregion
        #region BLC_OnPostEvent_Edit_Video_ai_asset_Reset
        public void BLC_OnPostEvent_Edit_Video_ai_asset_Reset(Video_ai_asset i_Video_ai_asset, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Video_ai_asset != null)
            {
                if (i_Video_ai_asset.List_Video_ai_asset_entity != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Video_ai_asset.List_Video_ai_asset_entity.Count == 0)
                        {
                            Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID(new Params_Delete_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID()
                            {
                                VIDEO_AI_ASSET_ID = i_Video_ai_asset.VIDEO_AI_ASSET_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Video_ai_asset_entity
                            // -----------------------------
                            List<Video_ai_asset_entity> oList_Video_ai_asset_entity = Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID(new Params_Get_Video_ai_asset_entity_By_VIDEO_AI_ASSET_ID()
                            {
                                VIDEO_AI_ASSET_ID = i_Video_ai_asset.VIDEO_AI_ASSET_ID
                            });
                            if (oList_Video_ai_asset_entity != null && oList_Video_ai_asset_entity.Count > 0)
                            {
                                oList_Video_ai_asset_entity = oList_Video_ai_asset_entity.Where(oVideo_ai_asset_entity => !i_Video_ai_asset.List_Video_ai_asset_entity.Any(oCurrent_Video_ai_asset_entity => oCurrent_Video_ai_asset_entity.VIDEO_AI_ASSET_ENTITY_ID == oVideo_ai_asset_entity.VIDEO_AI_ASSET_ENTITY_ID)).ToList();
                                if (oList_Video_ai_asset_entity.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    Edit_Video_ai_asset_entity_List(new Params_Edit_Video_ai_asset_entity_List()
                                    {
                                        List_To_Delete = oList_Video_ai_asset_entity.Select(oVideo_ai_asset_entity => oVideo_ai_asset_entity.VIDEO_AI_ASSET_ENTITY_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Video_ai_asset_entity
                    // -----------------------------
                    if (i_Video_ai_asset.List_Video_ai_asset_entity != null && i_Video_ai_asset.List_Video_ai_asset_entity.Count > 0)
                    {
                        foreach (var oVideo_ai_asset_entity in i_Video_ai_asset.List_Video_ai_asset_entity)
                        {
                            oVideo_ai_asset_entity.VIDEO_AI_ASSET_ID = i_Video_ai_asset.VIDEO_AI_ASSET_ID;
                            Edit_Video_ai_asset_entity(oVideo_ai_asset_entity);
                        }
                    }
                }
                // -----------------------------
            }
        }
        #endregion
        #region Initialize_Reset_Mechanism
        public void Initialize_Reset_Mechanism()
        {
            #region Body Section.
            this.OnPostEvent_Edit_Video_ai_engine += new PostEvent_Handler_Edit_Video_ai_engine(BLC_OnPostEvent_Edit_Video_ai_engine_Reset);
            this.OnPostEvent_Edit_Setup_category += new PostEvent_Handler_Edit_Setup_category(BLC_OnPostEvent_Edit_Setup_category_Reset);
            this.OnPostEvent_Edit_Video_ai_asset += new PostEvent_Handler_Edit_Video_ai_asset(BLC_OnPostEvent_Edit_Video_ai_asset_Reset);
            #endregion
        }
        #endregion
    }
}