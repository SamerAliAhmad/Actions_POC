using System;
using SmartrTools;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
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
        #region BLC_OnPostEvent_Edit_Area_Reset
        public void BLC_OnPostEvent_Edit_Area_Reset(Area i_Area, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Area != null)
            {
                if (i_Area.List_Area_view != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Area.List_Area_view.Count == 0)
                        {
                            Delete_Area_view_By_AREA_ID(new Params_Delete_Area_view_By_AREA_ID()
                            {
                                AREA_ID = i_Area.AREA_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Area_view
                            // -----------------------------
                            List<Area_view> oList_Area_view = Get_Area_view_By_AREA_ID(new Params_Get_Area_view_By_AREA_ID()
                            {
                                AREA_ID = i_Area.AREA_ID
                            });
                            if (oList_Area_view != null && oList_Area_view.Count > 0)
                            {
                                oList_Area_view = oList_Area_view.Where(oArea_view => !i_Area.List_Area_view.Any(oCurrent_Area_view => oCurrent_Area_view.AREA_VIEW_ID == oArea_view.AREA_VIEW_ID)).ToList();
                                if (oList_Area_view.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    Edit_Area_view_List(new Params_Edit_Area_view_List()
                                    {
                                        List_To_Delete = oList_Area_view.Select(oArea_view => oArea_view.AREA_VIEW_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Area_view
                    // -----------------------------
                    if (i_Area.List_Area_view != null && i_Area.List_Area_view.Count > 0)
                    {
                        foreach (var oArea_view in i_Area.List_Area_view)
                        {
                            oArea_view.AREA_ID = i_Area.AREA_ID;
                            Edit_Area_view(oArea_view);
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
            this.OnPostEvent_Edit_Setup_category += new PostEvent_Handler_Edit_Setup_category(BLC_OnPostEvent_Edit_Setup_category_Reset);
            this.OnPostEvent_Edit_Area += new PostEvent_Handler_Edit_Area(BLC_OnPostEvent_Edit_Area_Reset);
            #endregion
        }
        #endregion
    }
}