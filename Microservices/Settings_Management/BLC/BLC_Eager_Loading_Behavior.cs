using System.Linq;
using SmartrTools;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
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
        #region BLC_OnPostEvent_Get_Default_settings_By_OWNER_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Default_settings_By_OWNER_ID_Eager_Loading(ref List<Default_settings> i_Result, Params_Get_Default_settings_By_OWNER_ID i_Params_Get_Default_settings_By_OWNER_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Default_settings_ID_List = i_Result.Select(default_settings => default_settings.DEFAULT_SETTINGS_ID).OrderBy(Default_settings_ID => Default_settings_ID);

                // ---------------------
                // Get All available Default_chart_color entries.
                // ---------------------
                List<Default_chart_color> oList_Default_chart_color = new List<Default_chart_color>();
                var Default_chart_color_handle = Task.Run(() =>
                {
                    oList_Default_chart_color = Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_Adv(new Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List()
                    {
                        DEFAULT_SETTINGS_ID_LIST = Default_settings_ID_List
                    });
                });
                // ---------------------
                // Get All available Default_settings_image entries.
                // ---------------------
                List<Default_settings_image> oList_Default_settings_image = new List<Default_settings_image>();
                var Default_settings_image_handle = Task.Run(() =>
                {
                    oList_Default_settings_image = Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List(new Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List()
                    {
                        DEFAULT_SETTINGS_ID_LIST = Default_settings_ID_List
                    });
                });
                Task.WaitAll(Default_chart_color_handle, Default_settings_image_handle);
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oDefault_settings =>
                {
                    oDefault_settings.List_Default_chart_color = oList_Default_chart_color.Where(oDefault_chart_color => oDefault_chart_color.DEFAULT_SETTINGS_ID == oDefault_settings.DEFAULT_SETTINGS_ID).ToList();
                    oDefault_settings.List_Default_settings_image = oList_Default_settings_image.Where(oDefault_settings_image => oDefault_settings_image.DEFAULT_SETTINGS_ID == oDefault_settings.DEFAULT_SETTINGS_ID).ToList();
                    return oDefault_settings;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Build_version_By_OWNER_ID_Adv_Eager_Loading
        public void BLC_OnPostEvent_Get_Build_version_By_OWNER_ID_Adv_Eager_Loading(List<Build_version> i_Result, Params_Get_Build_version_By_OWNER_ID i_Params_Get_Build_version_By_OWNER_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Build_version_ID_List = i_Result.Select(build_version => build_version.BUILD_VERSION_ID).OrderBy(Build_version_ID => Build_version_ID);

                // ---------------------
                // Get All available Build_version_log entries.
                // ---------------------
                List<Build_version_log> oList_Build_version_log = Get_Build_version_log_By_BUILD_VERSION_ID_List(new Params_Get_Build_version_log_By_BUILD_VERSION_ID_List()
                {
                    BUILD_VERSION_ID_LIST = Build_version_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oBuild_version =>
                {
                    oBuild_version.List_Build_version_log = oList_Build_version_log.Where(oBuild_version_log => oBuild_version_log.BUILD_VERSION_ID == oBuild_version.BUILD_VERSION_ID).ToList();
                    return oBuild_version;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Eager_Loading(List<Build_version> i_Result, Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Build_version_ID_List = i_Result.Select(build_version => build_version.BUILD_VERSION_ID).OrderBy(Build_version_ID => Build_version_ID);

                // ---------------------
                // Get All available Build_version_log entries.
                // ---------------------
                List<Build_version_log> oList_Build_version_log = Get_Build_version_log_By_BUILD_VERSION_ID_List(new Params_Get_Build_version_log_By_BUILD_VERSION_ID_List()
                {
                    BUILD_VERSION_ID_LIST = Build_version_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oBuild_version =>
                {
                    oBuild_version.List_Build_version_log = oList_Build_version_log.Where(oBuild_version_log => oBuild_version_log.BUILD_VERSION_ID == oBuild_version.BUILD_VERSION_ID).ToList();
                    return oBuild_version;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region Initialize_Eager_Loading_Mechanism
        public void Initialize_Eager_Loading_Mechanism()
        {
            #region Body Section.
            this.OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID += new PostEvent_Handler_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(BLC_OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_Eager_Loading);
            this.OnPostEvent_Get_Setup_category_By_OWNER_ID += new PostEvent_Handler_Get_Setup_category_By_OWNER_ID(BLC_OnPostEvent_Get_Setup_category_By_OWNER_ID_Eager_Loading);
            this.OnPostEvent_Get_Default_settings_By_OWNER_ID += new PostEvent_Handler_Get_Default_settings_By_OWNER_ID(BLC_OnPostEvent_Get_Default_settings_By_OWNER_ID_Eager_Loading);
            this.OnPostEvent_Get_Build_version_By_OWNER_ID_Adv += new PostEvent_Handler_Get_Build_version_By_OWNER_ID_Adv(BLC_OnPostEvent_Get_Build_version_By_OWNER_ID_Adv_Eager_Loading);
            this.OnPostEvent_Get_Build_version_By_APPLICATION_NAME_SETUP_ID += new PostEvent_Handler_Get_Build_version_By_APPLICATION_NAME_SETUP_ID(BLC_OnPostEvent_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Eager_Loading);
            #endregion
        }
        #endregion
    }
}