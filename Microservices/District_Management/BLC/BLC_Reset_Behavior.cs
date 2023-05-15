using System;
using SmartrTools;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region BLC_OnPostEvent_Edit_District_Reset
        public void BLC_OnPostEvent_Edit_District_Reset(District i_District, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_District != null)
            {
                if (i_District.List_District_view != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_District.List_District_view.Count == 0)
                        {
                            Delete_District_view_By_DISTRICT_ID(new Params_Delete_District_view_By_DISTRICT_ID()
                            {
                                DISTRICT_ID = i_District.DISTRICT_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related District_view
                            // -----------------------------
                            List<District_view> oList_District_view = Get_District_view_By_DISTRICT_ID(new Params_Get_District_view_By_DISTRICT_ID()
                            {
                                DISTRICT_ID = i_District.DISTRICT_ID
                            });
                            if (oList_District_view != null && oList_District_view.Count > 0)
                            {
                                oList_District_view = oList_District_view.Where(oDistrict_view => !i_District.List_District_view.Any(oCurrent_District_view => oCurrent_District_view.DISTRICT_VIEW_ID == oDistrict_view.DISTRICT_VIEW_ID)).ToList();
                                if (oList_District_view.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    Edit_District_view_List(new Params_Edit_District_view_List()
                                    {
                                        List_To_Delete = oList_District_view.Select(oDistrict_view => oDistrict_view.DISTRICT_VIEW_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // District_view
                    // -----------------------------
                    if (i_District.List_District_view != null && i_District.List_District_view.Count > 0)
                    {
                        foreach (var oDistrict_view in i_District.List_District_view)
                        {
                            oDistrict_view.DISTRICT_ID = i_District.DISTRICT_ID;
                            Edit_District_view(oDistrict_view);
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
            this.OnPostEvent_Edit_District += new PostEvent_Handler_Edit_District(BLC_OnPostEvent_Edit_District_Reset);
            this.OnPostEvent_Edit_Setup_category += new PostEvent_Handler_Edit_Setup_category(BLC_OnPostEvent_Edit_Setup_category_Reset);
            #endregion
        }
        #endregion
    }
}