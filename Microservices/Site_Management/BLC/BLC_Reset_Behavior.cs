using System;
using SmartrTools;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region BLC_OnPostEvent_Edit_Site_Reset
        public void BLC_OnPostEvent_Edit_Site_Reset(Site i_Site, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Site != null)
            {
                if (i_Site.List_Site_view != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Site.List_Site_view.Count == 0)
                        {
                            Delete_Site_view_By_SITE_ID(new Params_Delete_Site_view_By_SITE_ID()
                            {
                                SITE_ID = i_Site.SITE_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Site_view
                            // -----------------------------
                            List<Site_view> oList_Site_view = Get_Site_view_By_SITE_ID(new Params_Get_Site_view_By_SITE_ID()
                            {
                                SITE_ID = i_Site.SITE_ID
                            });
                            if (oList_Site_view != null && oList_Site_view.Count > 0)
                            {
                                oList_Site_view = oList_Site_view.Where(oSite_view => !i_Site.List_Site_view.Any(oCurrent_Site_view => oCurrent_Site_view.SITE_VIEW_ID == oSite_view.SITE_VIEW_ID)).ToList();
                                if (oList_Site_view.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    Edit_Site_view_List(new Params_Edit_Site_view_List()
                                    {
                                        List_To_Delete = oList_Site_view.Select(oSite_view => oSite_view.SITE_VIEW_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Site_view
                    // -----------------------------
                    if (i_Site.List_Site_view != null && i_Site.List_Site_view.Count > 0)
                    {
                        foreach (var oSite_view in i_Site.List_Site_view)
                        {
                            oSite_view.SITE_ID = i_Site.SITE_ID;
                            Edit_Site_view(oSite_view);
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
            this.OnPostEvent_Edit_Site += new PostEvent_Handler_Edit_Site(BLC_OnPostEvent_Edit_Site_Reset);
            this.OnPostEvent_Edit_Setup_category += new PostEvent_Handler_Edit_Setup_category(BLC_OnPostEvent_Edit_Setup_category_Reset);
            #endregion
        }
        #endregion
    }
}