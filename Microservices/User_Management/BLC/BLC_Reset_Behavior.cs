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
        #region BLC_OnPostEvent_Edit_Entity_Reset
        public void BLC_OnPostEvent_Edit_Entity_Reset(Entity i_Entity, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Entity != null)
            {
                if (i_Entity.List_Entity_view != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Entity.List_Entity_view.Count == 0)
                        {
                            Delete_Entity_view_By_ENTITY_ID(new Params_Delete_Entity_view_By_ENTITY_ID()
                            {
                                ENTITY_ID = i_Entity.ENTITY_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Entity_view
                            // -----------------------------
                            List<Entity_view> oList_Entity_view = Get_Entity_view_By_ENTITY_ID(new Params_Get_Entity_view_By_ENTITY_ID()
                            {
                                ENTITY_ID = i_Entity.ENTITY_ID
                            });
                            if (oList_Entity_view != null && oList_Entity_view.Count > 0)
                            {
                                oList_Entity_view = oList_Entity_view.Where(oEntity_view => !i_Entity.List_Entity_view.Any(oCurrent_Entity_view => oCurrent_Entity_view.ENTITY_VIEW_ID == oEntity_view.ENTITY_VIEW_ID)).ToList();
                                if (oList_Entity_view.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    Edit_Entity_view_List(new Params_Edit_Entity_view_List()
                                    {
                                        List_To_Delete = oList_Entity_view.Select(oEntity_view => oEntity_view.ENTITY_VIEW_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Entity_view
                    // -----------------------------
                    if (i_Entity.List_Entity_view != null && i_Entity.List_Entity_view.Count > 0)
                    {
                        foreach (var oEntity_view in i_Entity.List_Entity_view)
                        {
                            oEntity_view.ENTITY_ID = i_Entity.ENTITY_ID;
                            Edit_Entity_view(oEntity_view);
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
            this.OnPostEvent_Edit_District += new PostEvent_Handler_Edit_District(BLC_OnPostEvent_Edit_District_Reset);
            this.OnPostEvent_Edit_Site += new PostEvent_Handler_Edit_Site(BLC_OnPostEvent_Edit_Site_Reset);
            this.OnPostEvent_Edit_Entity += new PostEvent_Handler_Edit_Entity(BLC_OnPostEvent_Edit_Entity_Reset);
            this.OnPostEvent_Edit_Setup_category += new PostEvent_Handler_Edit_Setup_category(BLC_OnPostEvent_Edit_Setup_category_Reset);
            this.OnPostEvent_Edit_Area += new PostEvent_Handler_Edit_Area(BLC_OnPostEvent_Edit_Area_Reset);
            #endregion
        }
        #endregion
    }
}