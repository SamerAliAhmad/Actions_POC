using System;
using SmartrTools;
using System.Linq;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Get_Build_version_log_By_BUILD_VERSION_LOG_ID_Adv
        public Build_version_log Get_Build_version_log_By_BUILD_VERSION_LOG_ID_Adv(Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID)
        {
            Build_version_log oBuild_version_log = null;
            var i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_BUILD_VERSION_LOG_ID_Adv", i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_json, false);
            }
            #region Body Section.
            DALC.Build_version_log oDBEntry = _AppContext.Get_Build_version_log_By_BUILD_VERSION_LOG_ID_Adv(i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID.BUILD_VERSION_LOG_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Build_version_log").Replace("%2", i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID.BUILD_VERSION_LOG_ID.ToString()));
            }
            oBuild_version_log = new Build_version_log();
            Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
            oBuild_version_log.Build_version = new Build_version();
            Props.Copy_Prop_Values(oDBEntry.Build_version, oBuild_version_log.Build_version);
            oBuild_version_log.Build_log_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Build_log_type_setup, oBuild_version_log.Build_log_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_BUILD_VERSION_LOG_ID_Adv", i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_json, false);
            }
            return oBuild_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv
        public Removed_extrusion Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv(Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID)
        {
            Removed_extrusion oRemoved_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_json, false);
            }
            #region Body Section.
            DALC.Removed_extrusion oDBEntry = _AppContext.Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv(i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID.REMOVED_EXTRUSION_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Removed_extrusion").Replace("%2", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID.REMOVED_EXTRUSION_ID.ToString()));
            }
            oRemoved_extrusion = new Removed_extrusion();
            Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
            oRemoved_extrusion.Data_level_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_Adv", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_json, false);
            }
            return oRemoved_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_ALERT_SETTINGS_ID_Adv
        public Alert_settings Get_Alert_settings_By_ALERT_SETTINGS_ID_Adv(Params_Get_Alert_settings_By_ALERT_SETTINGS_ID i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID)
        {
            Alert_settings oAlert_settings = null;
            var i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_ALERT_SETTINGS_ID_Adv", i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_json, false);
            }
            #region Body Section.
            DALC.Alert_settings oDBEntry = _AppContext.Get_Alert_settings_By_ALERT_SETTINGS_ID_Adv(i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID.ALERT_SETTINGS_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Alert_settings").Replace("%2", i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID.ALERT_SETTINGS_ID.ToString()));
            }
            oAlert_settings = new Alert_settings();
            Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
            oAlert_settings.Kpi = new Kpi();
            Props.Copy_Prop_Values(oDBEntry.Kpi, oAlert_settings.Kpi);
            oAlert_settings.Operation_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Operation_setup, oAlert_settings.Operation_setup);
            oAlert_settings.Value_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Value_type_setup, oAlert_settings.Value_type_setup);
            oAlert_settings.User = new User();
            Props.Copy_Prop_Values(oDBEntry.User, oAlert_settings.User);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_ALERT_SETTINGS_ID_Adv", i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_json, false);
            }
            return oAlert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_Adv
        public Default_settings_image Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_Adv(Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID)
        {
            Default_settings_image oDefault_settings_image = null;
            var i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_Adv", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_json, false);
            }
            #region Body Section.
            DALC.Default_settings_image oDBEntry = _AppContext.Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_Adv(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID.DEFAULT_SETTINGS_IMAGE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Default_settings_image").Replace("%2", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID.DEFAULT_SETTINGS_IMAGE_ID.ToString()));
            }
            oDefault_settings_image = new Default_settings_image();
            Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
            oDefault_settings_image.Default_settings = new Default_settings();
            Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_settings_image.Default_settings);
            oDefault_settings_image.Image_type_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oDefault_settings_image.Image_type_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_Adv", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_json, false);
            }
            return oDefault_settings_image;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_Adv
        public Setup Get_Setup_By_SETUP_ID_Adv(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID_Adv", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_ID_Adv(i_Params_Get_Setup_By_SETUP_ID.SETUP_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Setup").Replace("%2", i_Params_Get_Setup_By_SETUP_ID.SETUP_ID.ToString()));
            }
            oSetup = new Setup();
            Props.Copy_Prop_Values(oDBEntry, oSetup);
            oSetup.Setup_category = new Setup_category();
            Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID_Adv", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Build_version_By_BUILD_VERSION_ID_Adv
        public Build_version Get_Build_version_By_BUILD_VERSION_ID_Adv(Params_Get_Build_version_By_BUILD_VERSION_ID i_Params_Get_Build_version_By_BUILD_VERSION_ID)
        {
            Build_version oBuild_version = null;
            var i_Params_Get_Build_version_By_BUILD_VERSION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_BUILD_VERSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_BUILD_VERSION_ID_Adv", i_Params_Get_Build_version_By_BUILD_VERSION_ID_json, false);
            }
            #region Body Section.
            DALC.Build_version oDBEntry = _AppContext.Get_Build_version_By_BUILD_VERSION_ID_Adv(i_Params_Get_Build_version_By_BUILD_VERSION_ID.BUILD_VERSION_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Build_version").Replace("%2", i_Params_Get_Build_version_By_BUILD_VERSION_ID.BUILD_VERSION_ID.ToString()));
            }
            oBuild_version = new Build_version();
            Props.Copy_Prop_Values(oDBEntry, oBuild_version);
            oBuild_version.Application_name_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Application_name_setup, oBuild_version.Application_name_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_BUILD_VERSION_ID_Adv", i_Params_Get_Build_version_By_BUILD_VERSION_ID_json, false);
            }
            return oBuild_version;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_Adv
        public Default_chart_color Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_Adv(Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID)
        {
            Default_chart_color oDefault_chart_color = null;
            var i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_Adv", i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_json, false);
            }
            #region Body Section.
            DALC.Default_chart_color oDBEntry = _AppContext.Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_Adv(i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID.DEFAULT_CHART_COLOR_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Default_chart_color").Replace("%2", i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID.DEFAULT_CHART_COLOR_ID.ToString()));
            }
            oDefault_chart_color = new Default_chart_color();
            Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
            oDefault_chart_color.Default_settings = new Default_settings();
            Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_chart_color.Default_settings);
            oDefault_chart_color.Data_level_setup = new Setup();
            Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oDefault_chart_color.Data_level_setup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_Adv", i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_json, false);
            }
            return oDefault_chart_color;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_Adv
        public List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_Adv(Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List)
        {
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_Adv", i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_Adv(i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List.BUILD_VERSION_LOG_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry.Build_version, oBuild_version_log.Build_version);
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Build_log_type_setup, oBuild_version_log.Build_log_type_setup);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_Adv", i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv(Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv(i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List.REMOVED_EXTRUSION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_Adv", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_ALERT_SETTINGS_ID_List_Adv
        public List<Alert_settings> Get_Alert_settings_By_ALERT_SETTINGS_ID_List_Adv(Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_List i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_List)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_ALERT_SETTINGS_ID_List_Adv", i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_ALERT_SETTINGS_ID_List_Adv(i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_List.ALERT_SETTINGS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oAlert_settings.Kpi);
                        oAlert_settings.Operation_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Operation_setup, oAlert_settings.Operation_setup);
                        oAlert_settings.Value_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Value_type_setup, oAlert_settings.Value_type_setup);
                        oAlert_settings.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oAlert_settings.User);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_ALERT_SETTINGS_ID_List_Adv", i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_List_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_Adv(Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_Adv", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_Adv(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List.DEFAULT_SETTINGS_IMAGE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_settings_image.Default_settings);
                        oDefault_settings_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oDefault_settings_image.Image_type_setup);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_Adv", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_ID_List_Adv(Params_Get_Setup_By_SETUP_ID_List i_Params_Get_Setup_By_SETUP_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID_List_Adv", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_ID_List_Adv(i_Params_Get_Setup_By_SETUP_ID_List.SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID_List_Adv", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_BUILD_VERSION_ID_List_Adv
        public List<Build_version> Get_Build_version_By_BUILD_VERSION_ID_List_Adv(Params_Get_Build_version_By_BUILD_VERSION_ID_List i_Params_Get_Build_version_By_BUILD_VERSION_ID_List)
        {
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_BUILD_VERSION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_BUILD_VERSION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_BUILD_VERSION_ID_List_Adv", i_Params_Get_Build_version_By_BUILD_VERSION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_BUILD_VERSION_ID_List_Adv(i_Params_Get_Build_version_By_BUILD_VERSION_ID_List.BUILD_VERSION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oBuild_version.Application_name_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Application_name_setup, oBuild_version.Application_name_setup);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_BUILD_VERSION_ID_List_Adv", i_Params_Get_Build_version_By_BUILD_VERSION_ID_List_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_Adv(Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_Adv", i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_Adv(i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List.DEFAULT_CHART_COLOR_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_chart_color.Default_settings);
                        oDefault_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oDefault_chart_color.Data_level_setup);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_Adv", i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Build_version_log_By_OWNER_ID_Adv
        public List<Build_version_log> Get_Build_version_log_By_OWNER_ID_Adv(Params_Get_Build_version_log_By_OWNER_ID i_Params_Get_Build_version_log_By_OWNER_ID)
        {
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_OWNER_ID_Adv", i_Params_Get_Build_version_log_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_OWNER_ID_Adv(i_Params_Get_Build_version_log_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry.Build_version, oBuild_version_log.Build_version);
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Build_log_type_setup, oBuild_version_log.Build_log_type_setup);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_OWNER_ID_Adv", i_Params_Get_Build_version_log_By_OWNER_ID_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_ID_Adv
        public List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_ID_Adv(Params_Get_Build_version_log_By_BUILD_VERSION_ID i_Params_Get_Build_version_log_By_BUILD_VERSION_ID)
        {
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_BUILD_VERSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_BUILD_VERSION_ID_Adv", i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_BUILD_VERSION_ID_Adv(i_Params_Get_Build_version_log_By_BUILD_VERSION_ID.BUILD_VERSION_ID);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry.Build_version, oBuild_version_log.Build_version);
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Build_log_type_setup, oBuild_version_log.Build_log_type_setup);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_BUILD_VERSION_ID_Adv", i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_Adv
        public List<Build_version_log> Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_Adv(Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID)
        {
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_Adv", i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_Adv(i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID.BUILD_LOG_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry.Build_version, oBuild_version_log.Build_version);
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Build_log_type_setup, oBuild_version_log.Build_log_type_setup);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_Adv", i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_OWNER_ID_IS_DELETED_Adv
        public List<Build_version_log> Get_Build_version_log_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED i_Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED)
        {
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry.Build_version, oBuild_version_log.Build_version);
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Build_log_type_setup, oBuild_version_log.Build_log_type_setup);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_Adv(Params_Get_Removed_extrusion_By_OWNER_ID i_Params_Get_Removed_extrusion_By_OWNER_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_OWNER_ID_Adv", i_Params_Get_Removed_extrusion_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_OWNER_ID_Adv(i_Params_Get_Removed_extrusion_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_OWNER_ID_Adv", i_Params_Get_Removed_extrusion_By_OWNER_ID_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_Adv(Params_Get_Removed_extrusion_By_LEVEL_ID i_Params_Get_Removed_extrusion_By_LEVEL_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_LEVEL_ID_Adv", i_Params_Get_Removed_extrusion_By_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_LEVEL_ID_Adv(i_Params_Get_Removed_extrusion_By_LEVEL_ID.LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_LEVEL_ID_Adv", i_Params_Get_Removed_extrusion_By_LEVEL_ID_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv(Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv(i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_OWNER_ID_Adv
        public List<Alert_settings> Get_Alert_settings_By_OWNER_ID_Adv(Params_Get_Alert_settings_By_OWNER_ID i_Params_Get_Alert_settings_By_OWNER_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_OWNER_ID_Adv", i_Params_Get_Alert_settings_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_OWNER_ID_Adv(i_Params_Get_Alert_settings_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oAlert_settings.Kpi);
                        oAlert_settings.Operation_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Operation_setup, oAlert_settings.Operation_setup);
                        oAlert_settings.Value_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Value_type_setup, oAlert_settings.Value_type_setup);
                        oAlert_settings.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oAlert_settings.User);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_OWNER_ID_Adv", i_Params_Get_Alert_settings_By_OWNER_ID_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_OPERATION_SETUP_ID_Adv
        public List<Alert_settings> Get_Alert_settings_By_OPERATION_SETUP_ID_Adv(Params_Get_Alert_settings_By_OPERATION_SETUP_ID i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_OPERATION_SETUP_ID_Adv", i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_OPERATION_SETUP_ID_Adv(i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID.OPERATION_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oAlert_settings.Kpi);
                        oAlert_settings.Operation_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Operation_setup, oAlert_settings.Operation_setup);
                        oAlert_settings.Value_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Value_type_setup, oAlert_settings.Value_type_setup);
                        oAlert_settings.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oAlert_settings.User);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_OPERATION_SETUP_ID_Adv", i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_USER_ID_Adv
        public List<Alert_settings> Get_Alert_settings_By_USER_ID_Adv(Params_Get_Alert_settings_By_USER_ID i_Params_Get_Alert_settings_By_USER_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_USER_ID_Adv", i_Params_Get_Alert_settings_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_USER_ID_Adv(i_Params_Get_Alert_settings_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oAlert_settings.Kpi);
                        oAlert_settings.Operation_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Operation_setup, oAlert_settings.Operation_setup);
                        oAlert_settings.Value_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Value_type_setup, oAlert_settings.Value_type_setup);
                        oAlert_settings.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oAlert_settings.User);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_USER_ID_Adv", i_Params_Get_Alert_settings_By_USER_ID_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_OWNER_ID_IS_DELETED_Adv
        public List<Alert_settings> Get_Alert_settings_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED i_Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oAlert_settings.Kpi);
                        oAlert_settings.Operation_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Operation_setup, oAlert_settings.Operation_setup);
                        oAlert_settings.Value_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Value_type_setup, oAlert_settings.Value_type_setup);
                        oAlert_settings.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oAlert_settings.User);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_KPI_ID_Adv
        public List<Alert_settings> Get_Alert_settings_By_KPI_ID_Adv(Params_Get_Alert_settings_By_KPI_ID i_Params_Get_Alert_settings_By_KPI_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_KPI_ID_Adv", i_Params_Get_Alert_settings_By_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_KPI_ID_Adv(i_Params_Get_Alert_settings_By_KPI_ID.KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oAlert_settings.Kpi);
                        oAlert_settings.Operation_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Operation_setup, oAlert_settings.Operation_setup);
                        oAlert_settings.Value_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Value_type_setup, oAlert_settings.Value_type_setup);
                        oAlert_settings.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oAlert_settings.User);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_KPI_ID_Adv", i_Params_Get_Alert_settings_By_KPI_ID_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_Adv
        public List<Alert_settings> Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_Adv(Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_Adv", i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_Adv(i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID.VALUE_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oAlert_settings.Kpi);
                        oAlert_settings.Operation_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Operation_setup, oAlert_settings.Operation_setup);
                        oAlert_settings.Value_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Value_type_setup, oAlert_settings.Value_type_setup);
                        oAlert_settings.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oAlert_settings.User);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_Adv", i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_OWNER_ID_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_OWNER_ID_Adv(Params_Get_Default_settings_image_By_OWNER_ID i_Params_Get_Default_settings_image_By_OWNER_ID)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_OWNER_ID_Adv", i_Params_Get_Default_settings_image_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_OWNER_ID_Adv(i_Params_Get_Default_settings_image_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_settings_image.Default_settings);
                        oDefault_settings_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oDefault_settings_image.Image_type_setup);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_OWNER_ID_Adv", i_Params_Get_Default_settings_image_By_OWNER_ID_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_Adv(Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_Adv", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_Adv(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID.DEFAULT_SETTINGS_ID);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_settings_image.Default_settings);
                        oDefault_settings_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oDefault_settings_image.Image_type_setup);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_Adv", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_Adv(Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_Adv", i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_Adv(i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID.IMAGE_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_settings_image.Default_settings);
                        oDefault_settings_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oDefault_settings_image.Image_type_setup);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_Adv", i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_OWNER_ID_IS_DELETED_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED i_Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_settings_image.Default_settings);
                        oDefault_settings_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oDefault_settings_image.Image_type_setup);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Setup_By_OWNER_ID_IS_DELETED i_Params_Get_Setup_By_OWNER_ID_IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_Adv(Params_Get_Setup_By_SETUP_CATEGORY_ID i_Params_Get_Setup_By_SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_Adv(i_Params_Get_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID, i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE);
            if (oDBEntry != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values(oDBEntry, oSetup);
                oSetup.Setup_category = new Setup_category();
                Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_Adv
        public List<Setup> Get_Setup_By_OWNER_ID_Adv(Params_Get_Setup_By_OWNER_ID i_Params_Get_Setup_By_OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID_Adv", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID_Adv(i_Params_Get_Setup_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID_Adv", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_OWNER_ID_Adv
        public List<Build_version> Get_Build_version_By_OWNER_ID_Adv(Params_Get_Build_version_By_OWNER_ID i_Params_Get_Build_version_By_OWNER_ID)
        {
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_OWNER_ID_Adv", i_Params_Get_Build_version_By_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Build_version_By_OWNER_ID_Adv
            if (OnPreEvent_Get_Build_version_By_OWNER_ID_Adv != null)
            {
                OnPreEvent_Get_Build_version_By_OWNER_ID_Adv(i_Params_Get_Build_version_By_OWNER_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_OWNER_ID_Adv(i_Params_Get_Build_version_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oBuild_version.Application_name_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Application_name_setup, oBuild_version.Application_name_setup);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Build_version_By_OWNER_ID_Adv
            if (OnPostEvent_Get_Build_version_By_OWNER_ID_Adv != null)
            {
                OnPostEvent_Get_Build_version_By_OWNER_ID_Adv(oList_Build_version, i_Params_Get_Build_version_By_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_OWNER_ID_Adv", i_Params_Get_Build_version_By_OWNER_ID_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Adv
        public List<Build_version> Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Adv(Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID)
        {
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Adv", i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Adv(i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID.APPLICATION_NAME_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oBuild_version.Application_name_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Application_name_setup, oBuild_version.Application_name_setup);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_APPLICATION_NAME_SETUP_ID_Adv", i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Build_version_By_OWNER_ID_IS_DELETED_Adv
        public List<Build_version> Get_Build_version_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Build_version_By_OWNER_ID_IS_DELETED i_Params_Get_Build_version_By_OWNER_ID_IS_DELETED)
        {
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Build_version_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Build_version_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Build_version_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oBuild_version.Application_name_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Application_name_setup, oBuild_version.Application_name_setup);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Build_version_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_Adv
        public List<Build_version> Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_Adv(Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID i_Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID)
        {
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_Adv", i_Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_Adv(i_Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID.IS_CURRENT, i_Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID.APPLICATION_NAME_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oBuild_version.Application_name_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Application_name_setup, oBuild_version.Application_name_setup);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_Adv", i_Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_chart_color_By_OWNER_ID_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_OWNER_ID_Adv(Params_Get_Default_chart_color_By_OWNER_ID i_Params_Get_Default_chart_color_By_OWNER_ID)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_OWNER_ID_Adv", i_Params_Get_Default_chart_color_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_OWNER_ID_Adv(i_Params_Get_Default_chart_color_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_chart_color.Default_settings);
                        oDefault_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oDefault_chart_color.Data_level_setup);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_OWNER_ID_Adv", i_Params_Get_Default_chart_color_By_OWNER_ID_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_Adv(Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_Adv", i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_json, false);
            }
            #region Body Section.
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_Adv(i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID.DEFAULT_SETTINGS_ID);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_chart_color.Default_settings);
                        oDefault_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oDefault_chart_color.Data_level_setup);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_Adv", i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_OWNER_ID_IS_DELETED_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_OWNER_ID_IS_DELETED_Adv(Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED i_Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_OWNER_ID_IS_DELETED_Adv(i_Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_chart_color.Default_settings);
                        oDefault_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oDefault_chart_color.Data_level_setup);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_OWNER_ID_IS_DELETED_Adv", i_Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_Adv(Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_Adv(i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_chart_color.Default_settings);
                        oDefault_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oDefault_chart_color.Data_level_setup);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_Adv", i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_ID_List_Adv
        public List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_ID_List_Adv(Params_Get_Build_version_log_By_BUILD_VERSION_ID_List i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_List)
        {
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_BUILD_VERSION_ID_List_Adv", i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_BUILD_VERSION_ID_List_Adv(i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_List.BUILD_VERSION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry.Build_version, oBuild_version_log.Build_version);
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Build_log_type_setup, oBuild_version_log.Build_log_type_setup);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_BUILD_VERSION_ID_List_Adv", i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_List_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_Adv
        public List<Build_version_log> Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_Adv(Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List)
        {
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_Adv", i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_Adv(i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List.BUILD_LOG_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry.Build_version, oBuild_version_log.Build_version);
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Build_log_type_setup, oBuild_version_log.Build_log_type_setup);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_Adv", i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_List_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_List_Adv(Params_Get_Removed_extrusion_By_LEVEL_ID_List i_Params_Get_Removed_extrusion_By_LEVEL_ID_List)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_LEVEL_ID_List_Adv", i_Params_Get_Removed_extrusion_By_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_LEVEL_ID_List_Adv(i_Params_Get_Removed_extrusion_By_LEVEL_ID_List.LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_LEVEL_ID_List_Adv", i_Params_Get_Removed_extrusion_By_LEVEL_ID_List_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv(Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv(i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List.DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_OPERATION_SETUP_ID_List_Adv
        public List<Alert_settings> Get_Alert_settings_By_OPERATION_SETUP_ID_List_Adv(Params_Get_Alert_settings_By_OPERATION_SETUP_ID_List i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_List)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_OPERATION_SETUP_ID_List_Adv", i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_OPERATION_SETUP_ID_List_Adv(i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_List.OPERATION_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oAlert_settings.Kpi);
                        oAlert_settings.Operation_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Operation_setup, oAlert_settings.Operation_setup);
                        oAlert_settings.Value_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Value_type_setup, oAlert_settings.Value_type_setup);
                        oAlert_settings.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oAlert_settings.User);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_OPERATION_SETUP_ID_List_Adv", i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_List_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_USER_ID_List_Adv
        public List<Alert_settings> Get_Alert_settings_By_USER_ID_List_Adv(Params_Get_Alert_settings_By_USER_ID_List i_Params_Get_Alert_settings_By_USER_ID_List)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_USER_ID_List_Adv", i_Params_Get_Alert_settings_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_USER_ID_List_Adv(i_Params_Get_Alert_settings_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oAlert_settings.Kpi);
                        oAlert_settings.Operation_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Operation_setup, oAlert_settings.Operation_setup);
                        oAlert_settings.Value_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Value_type_setup, oAlert_settings.Value_type_setup);
                        oAlert_settings.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oAlert_settings.User);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_USER_ID_List_Adv", i_Params_Get_Alert_settings_By_USER_ID_List_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_KPI_ID_List_Adv
        public List<Alert_settings> Get_Alert_settings_By_KPI_ID_List_Adv(Params_Get_Alert_settings_By_KPI_ID_List i_Params_Get_Alert_settings_By_KPI_ID_List)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_KPI_ID_List_Adv", i_Params_Get_Alert_settings_By_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_KPI_ID_List_Adv(i_Params_Get_Alert_settings_By_KPI_ID_List.KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oAlert_settings.Kpi);
                        oAlert_settings.Operation_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Operation_setup, oAlert_settings.Operation_setup);
                        oAlert_settings.Value_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Value_type_setup, oAlert_settings.Value_type_setup);
                        oAlert_settings.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oAlert_settings.User);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_KPI_ID_List_Adv", i_Params_Get_Alert_settings_By_KPI_ID_List_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_Adv
        public List<Alert_settings> Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_Adv(Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_Adv", i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_Adv(i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List.VALUE_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oAlert_settings.Kpi);
                        oAlert_settings.Operation_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Operation_setup, oAlert_settings.Operation_setup);
                        oAlert_settings.Value_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Value_type_setup, oAlert_settings.Value_type_setup);
                        oAlert_settings.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oAlert_settings.User);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_Adv", i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_Adv(Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_Adv", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_Adv(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List.DEFAULT_SETTINGS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_settings_image.Default_settings);
                        oDefault_settings_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oDefault_settings_image.Image_type_setup);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_Adv", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_Adv(Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_Adv", i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_Adv(i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List.IMAGE_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_settings_image.Default_settings);
                        oDefault_settings_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oDefault_settings_image.Image_type_setup);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_Adv", i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List_Adv
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(Params_Get_Setup_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_List_Adv(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List_Adv", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_Adv
        public List<Build_version> Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_Adv(Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List)
        {
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_Adv", i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_Adv(i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List.APPLICATION_NAME_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oBuild_version.Application_name_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Application_name_setup, oBuild_version.Application_name_setup);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_Adv", i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_Adv(Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_Adv", i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_Adv(i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List.DEFAULT_SETTINGS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_chart_color.Default_settings);
                        oDefault_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oDefault_chart_color.Data_level_setup);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_Adv", i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv(Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv(i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List.DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_chart_color.Default_settings);
                        oDefault_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oDefault_chart_color.Data_level_setup);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_Adv", i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Build_version_log_By_Where_Adv
        public List<Build_version_log> Get_Build_version_log_By_Where_Adv(Params_Get_Build_version_log_By_Where i_Params_Get_Build_version_log_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_Where_Adv", i_Params_Get_Build_version_log_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Build_version_log_By_Where.OWNER_ID == null || i_Params_Get_Build_version_log_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Build_version_log_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Build_version_log_By_Where.OFFSET == null)
            {
                i_Params_Get_Build_version_log_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Build_version_log_By_Where.FETCH_NEXT == null || i_Params_Get_Build_version_log_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Build_version_log_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_Where_Adv(i_Params_Get_Build_version_log_By_Where.DESCRIPTION, i_Params_Get_Build_version_log_By_Where.OWNER_ID, i_Params_Get_Build_version_log_By_Where.OFFSET, i_Params_Get_Build_version_log_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry.Build_version, oBuild_version_log.Build_version);
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Build_log_type_setup, oBuild_version_log.Build_log_type_setup);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            i_Params_Get_Build_version_log_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_Where_Adv", i_Params_Get_Build_version_log_By_Where_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_Where_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_Where_Adv(Params_Get_Removed_extrusion_By_Where i_Params_Get_Removed_extrusion_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_Where_Adv", i_Params_Get_Removed_extrusion_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Removed_extrusion_By_Where.OWNER_ID == null || i_Params_Get_Removed_extrusion_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Removed_extrusion_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Removed_extrusion_By_Where.OFFSET == null)
            {
                i_Params_Get_Removed_extrusion_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Removed_extrusion_By_Where.FETCH_NEXT == null || i_Params_Get_Removed_extrusion_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Removed_extrusion_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_Where_Adv(i_Params_Get_Removed_extrusion_By_Where.EXTRUSION_IDENTIFIER, i_Params_Get_Removed_extrusion_By_Where.OWNER_ID, i_Params_Get_Removed_extrusion_By_Where.OFFSET, i_Params_Get_Removed_extrusion_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            i_Params_Get_Removed_extrusion_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_Where_Adv", i_Params_Get_Removed_extrusion_By_Where_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_Where_Adv
        public List<Alert_settings> Get_Alert_settings_By_Where_Adv(Params_Get_Alert_settings_By_Where i_Params_Get_Alert_settings_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_Where_Adv", i_Params_Get_Alert_settings_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Alert_settings_By_Where.OWNER_ID == null || i_Params_Get_Alert_settings_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Alert_settings_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Alert_settings_By_Where.OFFSET == null)
            {
                i_Params_Get_Alert_settings_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Alert_settings_By_Where.FETCH_NEXT == null || i_Params_Get_Alert_settings_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Alert_settings_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_Where_Adv(i_Params_Get_Alert_settings_By_Where.DESCRIPTION, i_Params_Get_Alert_settings_By_Where.OWNER_ID, i_Params_Get_Alert_settings_By_Where.OFFSET, i_Params_Get_Alert_settings_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oAlert_settings.Kpi);
                        oAlert_settings.Operation_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Operation_setup, oAlert_settings.Operation_setup);
                        oAlert_settings.Value_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Value_type_setup, oAlert_settings.Value_type_setup);
                        oAlert_settings.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oAlert_settings.User);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            i_Params_Get_Alert_settings_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_Where_Adv", i_Params_Get_Alert_settings_By_Where_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_Where_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_Where_Adv(Params_Get_Default_settings_image_By_Where i_Params_Get_Default_settings_image_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_Where_Adv", i_Params_Get_Default_settings_image_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Default_settings_image_By_Where.OWNER_ID == null || i_Params_Get_Default_settings_image_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Default_settings_image_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Default_settings_image_By_Where.OFFSET == null)
            {
                i_Params_Get_Default_settings_image_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Default_settings_image_By_Where.FETCH_NEXT == null || i_Params_Get_Default_settings_image_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Default_settings_image_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_Where_Adv(i_Params_Get_Default_settings_image_By_Where.IMAGE_NAME, i_Params_Get_Default_settings_image_By_Where.IMAGE_EXTENSION, i_Params_Get_Default_settings_image_By_Where.OWNER_ID, i_Params_Get_Default_settings_image_By_Where.OFFSET, i_Params_Get_Default_settings_image_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_settings_image.Default_settings);
                        oDefault_settings_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oDefault_settings_image.Image_type_setup);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            i_Params_Get_Default_settings_image_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_Where_Adv", i_Params_Get_Default_settings_image_By_Where_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Setup_By_Where_Adv
        public List<Setup> Get_Setup_By_Where_Adv(Params_Get_Setup_By_Where i_Params_Get_Setup_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where_Adv", i_Params_Get_Setup_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Setup_By_Where.OWNER_ID == null || i_Params_Get_Setup_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Setup_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Setup_By_Where.OFFSET == null)
            {
                i_Params_Get_Setup_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Setup_By_Where.FETCH_NEXT == null || i_Params_Get_Setup_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Setup_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where_Adv(i_Params_Get_Setup_By_Where.VALUE, i_Params_Get_Setup_By_Where.DESCRIPTION, i_Params_Get_Setup_By_Where.OWNER_ID, i_Params_Get_Setup_By_Where.OFFSET, i_Params_Get_Setup_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where_Adv", i_Params_Get_Setup_By_Where_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_Where_Adv
        public List<Build_version> Get_Build_version_By_Where_Adv(Params_Get_Build_version_By_Where i_Params_Get_Build_version_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_Where_Adv", i_Params_Get_Build_version_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Build_version_By_Where.OWNER_ID == null || i_Params_Get_Build_version_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Build_version_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Build_version_By_Where.OFFSET == null)
            {
                i_Params_Get_Build_version_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Build_version_By_Where.FETCH_NEXT == null || i_Params_Get_Build_version_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Build_version_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_Where_Adv(i_Params_Get_Build_version_By_Where.BUILD_NUMBER, i_Params_Get_Build_version_By_Where.COMMENTS, i_Params_Get_Build_version_By_Where.OWNER_ID, i_Params_Get_Build_version_By_Where.OFFSET, i_Params_Get_Build_version_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oBuild_version.Application_name_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Application_name_setup, oBuild_version.Application_name_setup);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            i_Params_Get_Build_version_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_Where_Adv", i_Params_Get_Build_version_By_Where_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_chart_color_By_Where_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_Where_Adv(Params_Get_Default_chart_color_By_Where i_Params_Get_Default_chart_color_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_Where_Adv", i_Params_Get_Default_chart_color_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Default_chart_color_By_Where.OWNER_ID == null || i_Params_Get_Default_chart_color_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Default_chart_color_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Default_chart_color_By_Where.OFFSET == null)
            {
                i_Params_Get_Default_chart_color_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Default_chart_color_By_Where.FETCH_NEXT == null || i_Params_Get_Default_chart_color_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Default_chart_color_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_Where_Adv(i_Params_Get_Default_chart_color_By_Where.COLOR, i_Params_Get_Default_chart_color_By_Where.OWNER_ID, i_Params_Get_Default_chart_color_By_Where.OFFSET, i_Params_Get_Default_chart_color_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_chart_color.Default_settings);
                        oDefault_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oDefault_chart_color.Data_level_setup);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            i_Params_Get_Default_chart_color_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_Where_Adv", i_Params_Get_Default_chart_color_By_Where_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Build_version_log_By_Where_In_List_Adv
        public List<Build_version_log> Get_Build_version_log_By_Where_In_List_Adv(Params_Get_Build_version_log_By_Where_In_List i_Params_Get_Build_version_log_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_Where_In_List_Adv", i_Params_Get_Build_version_log_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Build_version_log_By_Where_In_List.OWNER_ID == null || i_Params_Get_Build_version_log_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Build_version_log_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Build_version_log_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Build_version_log_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Build_version_log_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Build_version_log_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Build_version_log_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Build_version_log_By_Where_In_List.BUILD_VERSION_ID_LIST == null)
            {
                i_Params_Get_Build_version_log_By_Where_In_List.BUILD_VERSION_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Build_version_log_By_Where_In_List.BUILD_LOG_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Build_version_log_By_Where_In_List.BUILD_LOG_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_Where_In_List_Adv(i_Params_Get_Build_version_log_By_Where_In_List.DESCRIPTION, i_Params_Get_Build_version_log_By_Where_In_List.BUILD_VERSION_ID_LIST, i_Params_Get_Build_version_log_By_Where_In_List.BUILD_LOG_TYPE_SETUP_ID_LIST, i_Params_Get_Build_version_log_By_Where_In_List.OWNER_ID, i_Params_Get_Build_version_log_By_Where_In_List.OFFSET, i_Params_Get_Build_version_log_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oBuild_version_log.Build_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry.Build_version, oBuild_version_log.Build_version);
                        oBuild_version_log.Build_log_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Build_log_type_setup, oBuild_version_log.Build_log_type_setup);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            i_Params_Get_Build_version_log_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_Where_In_List_Adv", i_Params_Get_Build_version_log_By_Where_In_List_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_Where_In_List_Adv
        public List<Removed_extrusion> Get_Removed_extrusion_By_Where_In_List_Adv(Params_Get_Removed_extrusion_By_Where_In_List i_Params_Get_Removed_extrusion_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_Where_In_List_Adv", i_Params_Get_Removed_extrusion_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Removed_extrusion_By_Where_In_List.OWNER_ID == null || i_Params_Get_Removed_extrusion_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Removed_extrusion_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Removed_extrusion_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Removed_extrusion_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Removed_extrusion_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Removed_extrusion_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Removed_extrusion_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Removed_extrusion_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST == null)
            {
                i_Params_Get_Removed_extrusion_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_Where_In_List_Adv(i_Params_Get_Removed_extrusion_By_Where_In_List.EXTRUSION_IDENTIFIER, i_Params_Get_Removed_extrusion_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Removed_extrusion_By_Where_In_List.OWNER_ID, i_Params_Get_Removed_extrusion_By_Where_In_List.OFFSET, i_Params_Get_Removed_extrusion_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oRemoved_extrusion.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oRemoved_extrusion.Data_level_setup);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            i_Params_Get_Removed_extrusion_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_Where_In_List_Adv", i_Params_Get_Removed_extrusion_By_Where_In_List_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_Where_In_List_Adv
        public List<Alert_settings> Get_Alert_settings_By_Where_In_List_Adv(Params_Get_Alert_settings_By_Where_In_List i_Params_Get_Alert_settings_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_Where_In_List_Adv", i_Params_Get_Alert_settings_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Alert_settings_By_Where_In_List.OWNER_ID == null || i_Params_Get_Alert_settings_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Alert_settings_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Alert_settings_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Alert_settings_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Alert_settings_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Alert_settings_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Alert_settings_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Alert_settings_By_Where_In_List.USER_ID_LIST == null)
            {
                i_Params_Get_Alert_settings_By_Where_In_List.USER_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Alert_settings_By_Where_In_List.KPI_ID_LIST == null)
            {
                i_Params_Get_Alert_settings_By_Where_In_List.KPI_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Alert_settings_By_Where_In_List.VALUE_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Alert_settings_By_Where_In_List.VALUE_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            if (i_Params_Get_Alert_settings_By_Where_In_List.OPERATION_SETUP_ID_LIST == null)
            {
                i_Params_Get_Alert_settings_By_Where_In_List.OPERATION_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_Where_In_List_Adv(i_Params_Get_Alert_settings_By_Where_In_List.DESCRIPTION, i_Params_Get_Alert_settings_By_Where_In_List.USER_ID_LIST, i_Params_Get_Alert_settings_By_Where_In_List.KPI_ID_LIST, i_Params_Get_Alert_settings_By_Where_In_List.VALUE_TYPE_SETUP_ID_LIST, i_Params_Get_Alert_settings_By_Where_In_List.OPERATION_SETUP_ID_LIST, i_Params_Get_Alert_settings_By_Where_In_List.OWNER_ID, i_Params_Get_Alert_settings_By_Where_In_List.OFFSET, i_Params_Get_Alert_settings_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oAlert_settings.Kpi = new Kpi();
                        Props.Copy_Prop_Values(oDBEntry.Kpi, oAlert_settings.Kpi);
                        oAlert_settings.Operation_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Operation_setup, oAlert_settings.Operation_setup);
                        oAlert_settings.Value_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Value_type_setup, oAlert_settings.Value_type_setup);
                        oAlert_settings.User = new User();
                        Props.Copy_Prop_Values(oDBEntry.User, oAlert_settings.User);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            i_Params_Get_Alert_settings_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_Where_In_List_Adv", i_Params_Get_Alert_settings_By_Where_In_List_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_Where_In_List_Adv
        public List<Default_settings_image> Get_Default_settings_image_By_Where_In_List_Adv(Params_Get_Default_settings_image_By_Where_In_List i_Params_Get_Default_settings_image_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_Where_In_List_Adv", i_Params_Get_Default_settings_image_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Default_settings_image_By_Where_In_List.OWNER_ID == null || i_Params_Get_Default_settings_image_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Default_settings_image_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Default_settings_image_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Default_settings_image_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Default_settings_image_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Default_settings_image_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Default_settings_image_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Default_settings_image_By_Where_In_List.DEFAULT_SETTINGS_ID_LIST == null)
            {
                i_Params_Get_Default_settings_image_By_Where_In_List.DEFAULT_SETTINGS_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Default_settings_image_By_Where_In_List.IMAGE_TYPE_SETUP_ID_LIST == null)
            {
                i_Params_Get_Default_settings_image_By_Where_In_List.IMAGE_TYPE_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_Where_In_List_Adv(i_Params_Get_Default_settings_image_By_Where_In_List.IMAGE_NAME, i_Params_Get_Default_settings_image_By_Where_In_List.IMAGE_EXTENSION, i_Params_Get_Default_settings_image_By_Where_In_List.DEFAULT_SETTINGS_ID_LIST, i_Params_Get_Default_settings_image_By_Where_In_List.IMAGE_TYPE_SETUP_ID_LIST, i_Params_Get_Default_settings_image_By_Where_In_List.OWNER_ID, i_Params_Get_Default_settings_image_By_Where_In_List.OFFSET, i_Params_Get_Default_settings_image_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oDefault_settings_image.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_settings_image.Default_settings);
                        oDefault_settings_image.Image_type_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Image_type_setup, oDefault_settings_image.Image_type_setup);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            i_Params_Get_Default_settings_image_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_Where_In_List_Adv", i_Params_Get_Default_settings_image_By_Where_In_List_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Setup_By_Where_In_List_Adv
        public List<Setup> Get_Setup_By_Where_In_List_Adv(Params_Get_Setup_By_Where_In_List i_Params_Get_Setup_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where_In_List_Adv", i_Params_Get_Setup_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Setup_By_Where_In_List.OWNER_ID == null || i_Params_Get_Setup_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Setup_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Setup_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Setup_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST == null)
            {
                i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST = new List<int?>();
            }
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where_In_List_Adv(i_Params_Get_Setup_By_Where_In_List.VALUE, i_Params_Get_Setup_By_Where_In_List.DESCRIPTION, i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST, i_Params_Get_Setup_By_Where_In_List.OWNER_ID, i_Params_Get_Setup_By_Where_In_List.OFFSET, i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oSetup.Setup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry.Setup_category, oSetup.Setup_category);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where_In_List_Adv", i_Params_Get_Setup_By_Where_In_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_Where_In_List_Adv
        public List<Build_version> Get_Build_version_By_Where_In_List_Adv(Params_Get_Build_version_By_Where_In_List i_Params_Get_Build_version_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_Where_In_List_Adv", i_Params_Get_Build_version_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Build_version_By_Where_In_List.OWNER_ID == null || i_Params_Get_Build_version_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Build_version_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Build_version_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Build_version_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Build_version_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Build_version_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Build_version_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Build_version_By_Where_In_List.APPLICATION_NAME_SETUP_ID_LIST == null)
            {
                i_Params_Get_Build_version_By_Where_In_List.APPLICATION_NAME_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_Where_In_List_Adv(i_Params_Get_Build_version_By_Where_In_List.BUILD_NUMBER, i_Params_Get_Build_version_By_Where_In_List.COMMENTS, i_Params_Get_Build_version_By_Where_In_List.APPLICATION_NAME_SETUP_ID_LIST, i_Params_Get_Build_version_By_Where_In_List.OWNER_ID, i_Params_Get_Build_version_By_Where_In_List.OFFSET, i_Params_Get_Build_version_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oBuild_version.Application_name_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Application_name_setup, oBuild_version.Application_name_setup);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            i_Params_Get_Build_version_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_Where_In_List_Adv", i_Params_Get_Build_version_By_Where_In_List_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_chart_color_By_Where_In_List_Adv
        public List<Default_chart_color> Get_Default_chart_color_By_Where_In_List_Adv(Params_Get_Default_chart_color_By_Where_In_List i_Params_Get_Default_chart_color_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_Where_In_List_Adv", i_Params_Get_Default_chart_color_By_Where_In_List_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Default_chart_color_By_Where_In_List.OWNER_ID == null || i_Params_Get_Default_chart_color_By_Where_In_List.OWNER_ID == 0)
            {
                i_Params_Get_Default_chart_color_By_Where_In_List.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Default_chart_color_By_Where_In_List.OFFSET == null)
            {
                i_Params_Get_Default_chart_color_By_Where_In_List.OFFSET = 0;
            }
            if (i_Params_Get_Default_chart_color_By_Where_In_List.FETCH_NEXT == null || i_Params_Get_Default_chart_color_By_Where_In_List.FETCH_NEXT == 0)
            {
                i_Params_Get_Default_chart_color_By_Where_In_List.FETCH_NEXT = 1000000;
            }
            if (i_Params_Get_Default_chart_color_By_Where_In_List.DEFAULT_SETTINGS_ID_LIST == null)
            {
                i_Params_Get_Default_chart_color_By_Where_In_List.DEFAULT_SETTINGS_ID_LIST = new List<int?>();
            }
            if (i_Params_Get_Default_chart_color_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST == null)
            {
                i_Params_Get_Default_chart_color_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST = new List<long?>();
            }
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_Where_In_List_Adv(i_Params_Get_Default_chart_color_By_Where_In_List.COLOR, i_Params_Get_Default_chart_color_By_Where_In_List.DEFAULT_SETTINGS_ID_LIST, i_Params_Get_Default_chart_color_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Default_chart_color_By_Where_In_List.OWNER_ID, i_Params_Get_Default_chart_color_By_Where_In_List.OFFSET, i_Params_Get_Default_chart_color_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oDefault_chart_color.Default_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry.Default_settings, oDefault_chart_color.Default_settings);
                        oDefault_chart_color.Data_level_setup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry.Data_level_setup, oDefault_chart_color.Data_level_setup);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            i_Params_Get_Default_chart_color_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_Where_In_List_Adv", i_Params_Get_Default_chart_color_By_Where_In_List_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
    }
}
