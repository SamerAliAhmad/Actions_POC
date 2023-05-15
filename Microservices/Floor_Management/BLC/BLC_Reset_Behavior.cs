using System;
using SmartrTools;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region BLC_OnPostEvent_Edit_Space_Reset
        public void BLC_OnPostEvent_Edit_Space_Reset(Space i_Space, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Space != null)
            {
                if (i_Space.List_Space_asset != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Space.List_Space_asset.Count == 0)
                        {
                            Delete_Space_asset_By_SPACE_ID(new Params_Delete_Space_asset_By_SPACE_ID()
                            {
                                SPACE_ID = i_Space.SPACE_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Space_asset
                            // -----------------------------
                            List<Space_asset> oList_Space_asset = Get_Space_asset_By_SPACE_ID(new Params_Get_Space_asset_By_SPACE_ID()
                            {
                                SPACE_ID = i_Space.SPACE_ID
                            });
                            if (oList_Space_asset != null && oList_Space_asset.Count > 0)
                            {
                                oList_Space_asset = oList_Space_asset.Where(oSpace_asset => !i_Space.List_Space_asset.Any(oCurrent_Space_asset => oCurrent_Space_asset.SPACE_ASSET_ID == oSpace_asset.SPACE_ASSET_ID)).ToList();
                                if (oList_Space_asset.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    Edit_Space_asset_List(new Params_Edit_Space_asset_List()
                                    {
                                        List_To_Delete = oList_Space_asset.Select(oSpace_asset => oSpace_asset.SPACE_ASSET_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Space_asset
                    // -----------------------------
                    if (i_Space.List_Space_asset != null && i_Space.List_Space_asset.Count > 0)
                    {
                        foreach (var oSpace_asset in i_Space.List_Space_asset)
                        {
                            oSpace_asset.SPACE_ID = i_Space.SPACE_ID;
                            Edit_Space_asset(oSpace_asset);
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
        #region Initialize_Reset_Mechanism
        public void Initialize_Reset_Mechanism()
        {
            #region Body Section.
            this.OnPostEvent_Edit_Space += new PostEvent_Handler_Edit_Space(BLC_OnPostEvent_Edit_Space_Reset);
            this.OnPostEvent_Edit_Setup_category += new PostEvent_Handler_Edit_Setup_category(BLC_OnPostEvent_Edit_Setup_category_Reset);
            #endregion
        }
        #endregion
    }
}