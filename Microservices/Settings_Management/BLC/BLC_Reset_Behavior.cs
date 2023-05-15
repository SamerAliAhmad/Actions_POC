using System;
using SmartrTools;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region BLC_OnPostEvent_Edit_Build_version_Reset
        public void BLC_OnPostEvent_Edit_Build_version_Reset(Build_version i_Build_version, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Build_version != null)
            {
                if (i_Build_version.List_Build_version_log != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Build_version.List_Build_version_log.Count == 0)
                        {
                            Delete_Build_version_log_By_BUILD_VERSION_ID(new Params_Delete_Build_version_log_By_BUILD_VERSION_ID()
                            {
                                BUILD_VERSION_ID = i_Build_version.BUILD_VERSION_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Build_version_log
                            // -----------------------------
                            List<Build_version_log> oList_Build_version_log = Get_Build_version_log_By_BUILD_VERSION_ID(new Params_Get_Build_version_log_By_BUILD_VERSION_ID()
                            {
                                BUILD_VERSION_ID = i_Build_version.BUILD_VERSION_ID
                            });
                            if (oList_Build_version_log != null && oList_Build_version_log.Count > 0)
                            {
                                oList_Build_version_log = oList_Build_version_log.Where(oBuild_version_log => !i_Build_version.List_Build_version_log.Any(oCurrent_Build_version_log => oCurrent_Build_version_log.BUILD_VERSION_LOG_ID == oBuild_version_log.BUILD_VERSION_LOG_ID)).ToList();
                                if (oList_Build_version_log.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    Edit_Build_version_log_List(new Params_Edit_Build_version_log_List()
                                    {
                                        List_To_Delete = oList_Build_version_log.Select(oBuild_version_log => oBuild_version_log.BUILD_VERSION_LOG_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Build_version_log
                    // -----------------------------
                    if (i_Build_version.List_Build_version_log != null && i_Build_version.List_Build_version_log.Count > 0)
                    {
                        foreach (var oBuild_version_log in i_Build_version.List_Build_version_log)
                        {
                            oBuild_version_log.BUILD_VERSION_ID = i_Build_version.BUILD_VERSION_ID;
                            Edit_Build_version_log(oBuild_version_log);
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
            this.OnPostEvent_Edit_Build_version += new PostEvent_Handler_Edit_Build_version(BLC_OnPostEvent_Edit_Build_version_Reset);
            this.OnPostEvent_Edit_Setup_category += new PostEvent_Handler_Edit_Setup_category(BLC_OnPostEvent_Edit_Setup_category_Reset);
            #endregion
        }
        #endregion
    }
}