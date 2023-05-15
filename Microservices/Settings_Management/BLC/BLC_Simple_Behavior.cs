using System;
using System.Linq;
using SmartrTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region Members
        #region Used For Delete Operations
        private Build_version_log _Build_version_log;
        private List<Build_version_log> _List_Build_version_log;
        private Removed_extrusion _Removed_extrusion;
        private List<Removed_extrusion> _List_Removed_extrusion;
        private Alert_settings _Alert_settings;
        private List<Alert_settings> _List_Alert_settings;
        private Default_settings_image _Default_settings_image;
        private List<Default_settings_image> _List_Default_settings_image;
        private Owner _Owner;
        private List<Owner> _List_Owner;
        private Setup_category _Setup_category;
        private List<Setup_category> _List_Setup_category;
        private Setup _Setup;
        private List<Setup> _List_Setup;
        private Build_version _Build_version;
        private List<Build_version> _List_Build_version;
        private Default_settings _Default_settings;
        private List<Default_settings> _List_Default_settings;
        private Default_chart_color _Default_chart_color;
        private List<Default_chart_color> _List_Default_chart_color;
        private Districtnex_module _Districtnex_module;
        private List<Districtnex_module> _List_Districtnex_module;
        #endregion
        #region Stop Executing Flags For Edit and Delete Operations
        private bool _Stop_Edit_Build_version_log_Execution;
        private bool _Stop_Delete_Build_version_log_Execution;
        private bool _Stop_Edit_Removed_extrusion_Execution;
        private bool _Stop_Delete_Removed_extrusion_Execution;
        private bool _Stop_Edit_Alert_settings_Execution;
        private bool _Stop_Delete_Alert_settings_Execution;
        private bool _Stop_Edit_Default_settings_image_Execution;
        private bool _Stop_Delete_Default_settings_image_Execution;
        private bool _Stop_Edit_Owner_Execution;
        private bool _Stop_Delete_Owner_Execution;
        private bool _Stop_Edit_Setup_category_Execution;
        private bool _Stop_Delete_Setup_category_Execution;
        private bool _Stop_Edit_Setup_Execution;
        private bool _Stop_Delete_Setup_Execution;
        private bool _Stop_Edit_Build_version_Execution;
        private bool _Stop_Delete_Build_version_Execution;
        private bool _Stop_Edit_Default_settings_Execution;
        private bool _Stop_Delete_Default_settings_Execution;
        private bool _Stop_Edit_Default_chart_color_Execution;
        private bool _Stop_Delete_Default_chart_color_Execution;
        private bool _Stop_Edit_Districtnex_module_Execution;
        private bool _Stop_Delete_Districtnex_module_Execution;
        #endregion
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_LOG_ID
        public Build_version_log Get_Build_version_log_By_BUILD_VERSION_LOG_ID(Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID)
        {
            Build_version_log oBuild_version_log = null;
            var i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_BUILD_VERSION_LOG_ID", i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_json, false);
            }
            #region Body Section.
            DALC.Build_version_log oDBEntry = _AppContext.Get_Build_version_log_By_BUILD_VERSION_LOG_ID(i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID.BUILD_VERSION_LOG_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Build_version_log").Replace("%2", i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID.BUILD_VERSION_LOG_ID.ToString()));
            }
            oBuild_version_log = new Build_version_log();
            Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_BUILD_VERSION_LOG_ID", i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_json, false);
            }
            return oBuild_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID
        public Removed_extrusion Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID(Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID)
        {
            Removed_extrusion oRemoved_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_json, false);
            }
            #region Body Section.
            DALC.Removed_extrusion oDBEntry = _AppContext.Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID(i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID.REMOVED_EXTRUSION_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Removed_extrusion").Replace("%2", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID.REMOVED_EXTRUSION_ID.ToString()));
            }
            oRemoved_extrusion = new Removed_extrusion();
            Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_json, false);
            }
            return oRemoved_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_ALERT_SETTINGS_ID
        public Alert_settings Get_Alert_settings_By_ALERT_SETTINGS_ID(Params_Get_Alert_settings_By_ALERT_SETTINGS_ID i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID)
        {
            Alert_settings oAlert_settings = null;
            var i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_ALERT_SETTINGS_ID", i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_json, false);
            }
            #region Body Section.
            DALC.Alert_settings oDBEntry = _AppContext.Get_Alert_settings_By_ALERT_SETTINGS_ID(i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID.ALERT_SETTINGS_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Alert_settings").Replace("%2", i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID.ALERT_SETTINGS_ID.ToString()));
            }
            oAlert_settings = new Alert_settings();
            Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_ALERT_SETTINGS_ID", i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_json, false);
            }
            return oAlert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID
        public Default_settings_image Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID(Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID)
        {
            Default_settings_image oDefault_settings_image = null;
            var i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_json, false);
            }
            #region Body Section.
            DALC.Default_settings_image oDBEntry = _AppContext.Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID.DEFAULT_SETTINGS_IMAGE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Default_settings_image").Replace("%2", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID.DEFAULT_SETTINGS_IMAGE_ID.ToString()));
            }
            oDefault_settings_image = new Default_settings_image();
            Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_json, false);
            }
            return oDefault_settings_image;
        }
        #endregion
        #region Get_Owner_By_OWNER_ID
        public Owner Get_Owner_By_OWNER_ID(Params_Get_Owner_By_OWNER_ID i_Params_Get_Owner_By_OWNER_ID)
        {
            Owner oOwner = null;
            var i_Params_Get_Owner_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Owner_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Owner_By_OWNER_ID", i_Params_Get_Owner_By_OWNER_ID_json, false);
            }
            #region Body Section.
            DALC.Owner oDBEntry = _AppContext.Get_Owner_By_OWNER_ID(i_Params_Get_Owner_By_OWNER_ID.OWNER_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Owner").Replace("%2", i_Params_Get_Owner_By_OWNER_ID.OWNER_ID.ToString()));
            }
            oOwner = new Owner();
            Props.Copy_Prop_Values(oDBEntry, oOwner);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Owner_By_OWNER_ID", i_Params_Get_Owner_By_OWNER_ID_json, false);
            }
            return oOwner;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_ID(Params_Get_Setup_category_By_SETUP_CATEGORY_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID)
        {
            Setup_category oSetup_category = null;
            var i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            DALC.Setup_category oDBEntry = _AppContext.Get_Setup_category_By_SETUP_CATEGORY_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Setup_category").Replace("%2", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID.ToString()));
            }
            oSetup_category = new Setup_category();
            Props.Copy_Prop_Values(oDBEntry, oSetup_category);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_json, false);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID
        public Setup Get_Setup_By_SETUP_ID(Params_Get_Setup_By_SETUP_ID i_Params_Get_Setup_By_SETUP_ID)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_ID(i_Params_Get_Setup_By_SETUP_ID.SETUP_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Setup").Replace("%2", i_Params_Get_Setup_By_SETUP_ID.SETUP_ID.ToString()));
            }
            oSetup = new Setup();
            Props.Copy_Prop_Values(oDBEntry, oSetup);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID", i_Params_Get_Setup_By_SETUP_ID_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Build_version_By_BUILD_VERSION_ID
        public Build_version Get_Build_version_By_BUILD_VERSION_ID(Params_Get_Build_version_By_BUILD_VERSION_ID i_Params_Get_Build_version_By_BUILD_VERSION_ID)
        {
            Build_version oBuild_version = null;
            var i_Params_Get_Build_version_By_BUILD_VERSION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_BUILD_VERSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_BUILD_VERSION_ID", i_Params_Get_Build_version_By_BUILD_VERSION_ID_json, false);
            }
            #region Body Section.
            DALC.Build_version oDBEntry = _AppContext.Get_Build_version_By_BUILD_VERSION_ID(i_Params_Get_Build_version_By_BUILD_VERSION_ID.BUILD_VERSION_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Build_version").Replace("%2", i_Params_Get_Build_version_By_BUILD_VERSION_ID.BUILD_VERSION_ID.ToString()));
            }
            oBuild_version = new Build_version();
            Props.Copy_Prop_Values(oDBEntry, oBuild_version);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_BUILD_VERSION_ID", i_Params_Get_Build_version_By_BUILD_VERSION_ID_json, false);
            }
            return oBuild_version;
        }
        #endregion
        #region Get_Default_settings_By_DEFAULT_SETTINGS_ID
        public Default_settings Get_Default_settings_By_DEFAULT_SETTINGS_ID(Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID i_Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID)
        {
            Default_settings oDefault_settings = null;
            var i_Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_By_DEFAULT_SETTINGS_ID", i_Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID_json, false);
            }
            #region Body Section.
            DALC.Default_settings oDBEntry = _AppContext.Get_Default_settings_By_DEFAULT_SETTINGS_ID(i_Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID.DEFAULT_SETTINGS_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Default_settings").Replace("%2", i_Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID.DEFAULT_SETTINGS_ID.ToString()));
            }
            oDefault_settings = new Default_settings();
            Props.Copy_Prop_Values(oDBEntry, oDefault_settings);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_By_DEFAULT_SETTINGS_ID", i_Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID_json, false);
            }
            return oDefault_settings;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID
        public Default_chart_color Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID(Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID)
        {
            Default_chart_color oDefault_chart_color = null;
            var i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID", i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_json, false);
            }
            #region Body Section.
            DALC.Default_chart_color oDBEntry = _AppContext.Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID(i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID.DEFAULT_CHART_COLOR_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Default_chart_color").Replace("%2", i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID.DEFAULT_CHART_COLOR_ID.ToString()));
            }
            oDefault_chart_color = new Default_chart_color();
            Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID", i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_json, false);
            }
            return oDefault_chart_color;
        }
        #endregion
        #region Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID
        public Districtnex_module Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID(Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID)
        {
            Districtnex_module oDistrictnex_module = null;
            var i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_json = JsonConvert.SerializeObject(i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID", i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_json, false);
            }
            #region Body Section.
            DALC.Districtnex_module oDBEntry = _AppContext.Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID(i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID.DISTRICTNEX_MODULE_ID);
            if (oDBEntry == null)
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0001).Replace("%1", "Districtnex_module").Replace("%2", i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID.DISTRICTNEX_MODULE_ID.ToString()));
            }
            oDistrictnex_module = new Districtnex_module();
            Props.Copy_Prop_Values(oDBEntry, oDistrictnex_module);
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID", i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_json, false);
            }
            return oDistrictnex_module;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List
        public List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List(Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List)
        {
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List", i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List(i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List.BUILD_VERSION_LOG_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List", i_Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID_List_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List
        public List<Removed_extrusion> Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List(Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List(i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List.REMOVED_EXTRUSION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List", i_Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID_List_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_ALERT_SETTINGS_ID_List
        public List<Alert_settings> Get_Alert_settings_By_ALERT_SETTINGS_ID_List(Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_List i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_List)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_ALERT_SETTINGS_ID_List", i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_ALERT_SETTINGS_ID_List(i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_List.ALERT_SETTINGS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_ALERT_SETTINGS_ID_List", i_Params_Get_Alert_settings_By_ALERT_SETTINGS_ID_List_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List
        public List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List(Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List.DEFAULT_SETTINGS_IMAGE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID_List_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Owner_By_OWNER_ID_List
        public List<Owner> Get_Owner_By_OWNER_ID_List(Params_Get_Owner_By_OWNER_ID_List i_Params_Get_Owner_By_OWNER_ID_List)
        {
            List<Owner> oList_Owner = null;
            var i_Params_Get_Owner_By_OWNER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Owner_By_OWNER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Owner_By_OWNER_ID_List", i_Params_Get_Owner_By_OWNER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Owner> oList_DBEntry = _AppContext.Get_Owner_By_OWNER_ID_List(i_Params_Get_Owner_By_OWNER_ID_List.OWNER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Owner = new List<Owner>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Owner oOwner = new Owner();
                        Props.Copy_Prop_Values(oDBEntry, oOwner);
                        oList_Owner.Add(oOwner);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Owner_By_OWNER_ID_List", i_Params_Get_Owner_By_OWNER_ID_List_json, false);
            }
            return oList_Owner;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_ID_List
        public List<Setup_category> Get_Setup_category_By_SETUP_CATEGORY_ID_List(Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List)
        {
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_SETUP_CATEGORY_ID_List(i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_category_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_By_SETUP_ID_List
        public List<Setup> Get_Setup_By_SETUP_ID_List(Params_Get_Setup_By_SETUP_ID_List i_Params_Get_Setup_By_SETUP_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_ID_List", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_ID_List(i_Params_Get_Setup_By_SETUP_ID_List.SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_ID_List", i_Params_Get_Setup_By_SETUP_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_BUILD_VERSION_ID_List
        public List<Build_version> Get_Build_version_By_BUILD_VERSION_ID_List(Params_Get_Build_version_By_BUILD_VERSION_ID_List i_Params_Get_Build_version_By_BUILD_VERSION_ID_List)
        {
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_BUILD_VERSION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_BUILD_VERSION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_BUILD_VERSION_ID_List", i_Params_Get_Build_version_By_BUILD_VERSION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_BUILD_VERSION_ID_List(i_Params_Get_Build_version_By_BUILD_VERSION_ID_List.BUILD_VERSION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_BUILD_VERSION_ID_List", i_Params_Get_Build_version_By_BUILD_VERSION_ID_List_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_settings_By_DEFAULT_SETTINGS_ID_List
        public List<Default_settings> Get_Default_settings_By_DEFAULT_SETTINGS_ID_List(Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID_List i_Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID_List)
        {
            List<Default_settings> oList_Default_settings = null;
            var i_Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_By_DEFAULT_SETTINGS_ID_List", i_Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings> oList_DBEntry = _AppContext.Get_Default_settings_By_DEFAULT_SETTINGS_ID_List(i_Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID_List.DEFAULT_SETTINGS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Default_settings = new List<Default_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings oDefault_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings);
                        oList_Default_settings.Add(oDefault_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_By_DEFAULT_SETTINGS_ID_List", i_Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID_List_json, false);
            }
            return oList_Default_settings;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List
        public List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List(Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List", i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List(i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List.DEFAULT_CHART_COLOR_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List", i_Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID_List_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List
        public List<Districtnex_module> Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List(Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List)
        {
            List<Districtnex_module> oList_Districtnex_module = null;
            var i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List", i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Districtnex_module> oList_DBEntry = _AppContext.Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List(i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List.DISTRICTNEX_MODULE_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Districtnex_module = new List<Districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Districtnex_module oDistrictnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oDistrictnex_module);
                        oList_Districtnex_module.Add(oDistrictnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List", i_Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID_List_json, false);
            }
            return oList_Districtnex_module;
        }
        #endregion
        #region Get_Build_version_log_By_OWNER_ID
        public List<Build_version_log> Get_Build_version_log_By_OWNER_ID(Params_Get_Build_version_log_By_OWNER_ID i_Params_Get_Build_version_log_By_OWNER_ID)
        {
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_OWNER_ID", i_Params_Get_Build_version_log_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_OWNER_ID(i_Params_Get_Build_version_log_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_OWNER_ID", i_Params_Get_Build_version_log_By_OWNER_ID_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_ID
        public List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_ID(Params_Get_Build_version_log_By_BUILD_VERSION_ID i_Params_Get_Build_version_log_By_BUILD_VERSION_ID)
        {
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_BUILD_VERSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_BUILD_VERSION_ID", i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_json, false);
            }
            #region Body Section.
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_BUILD_VERSION_ID(i_Params_Get_Build_version_log_By_BUILD_VERSION_ID.BUILD_VERSION_ID);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_BUILD_VERSION_ID", i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID
        public List<Build_version_log> Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID(Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID)
        {
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID", i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID(i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID.BUILD_LOG_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID", i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_OWNER_ID_IS_DELETED
        public List<Build_version_log> Get_Build_version_log_By_OWNER_ID_IS_DELETED(Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED i_Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED)
        {
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_OWNER_ID_IS_DELETED", i_Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_OWNER_ID_IS_DELETED(i_Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_OWNER_ID_IS_DELETED", i_Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID
        public List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID(Params_Get_Removed_extrusion_By_OWNER_ID i_Params_Get_Removed_extrusion_By_OWNER_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_OWNER_ID", i_Params_Get_Removed_extrusion_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_OWNER_ID(i_Params_Get_Removed_extrusion_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_OWNER_ID", i_Params_Get_Removed_extrusion_By_OWNER_ID_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID
        public List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID(Params_Get_Removed_extrusion_By_LEVEL_ID i_Params_Get_Removed_extrusion_By_LEVEL_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_LEVEL_ID", i_Params_Get_Removed_extrusion_By_LEVEL_ID_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_LEVEL_ID(i_Params_Get_Removed_extrusion_By_LEVEL_ID.LEVEL_ID);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_LEVEL_ID", i_Params_Get_Removed_extrusion_By_LEVEL_ID_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID
        public List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID(Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID", i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID(i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID", i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_OWNER_ID_IS_DELETED
        public List<Removed_extrusion> Get_Removed_extrusion_By_OWNER_ID_IS_DELETED(Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_OWNER_ID_IS_DELETED", i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_OWNER_ID_IS_DELETED(i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_OWNER_ID_IS_DELETED", i_Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_OWNER_ID
        public List<Alert_settings> Get_Alert_settings_By_OWNER_ID(Params_Get_Alert_settings_By_OWNER_ID i_Params_Get_Alert_settings_By_OWNER_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_OWNER_ID", i_Params_Get_Alert_settings_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_OWNER_ID(i_Params_Get_Alert_settings_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_OWNER_ID", i_Params_Get_Alert_settings_By_OWNER_ID_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_OPERATION_SETUP_ID
        public List<Alert_settings> Get_Alert_settings_By_OPERATION_SETUP_ID(Params_Get_Alert_settings_By_OPERATION_SETUP_ID i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_OPERATION_SETUP_ID", i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_OPERATION_SETUP_ID(i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID.OPERATION_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_OPERATION_SETUP_ID", i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_USER_ID
        public List<Alert_settings> Get_Alert_settings_By_USER_ID(Params_Get_Alert_settings_By_USER_ID i_Params_Get_Alert_settings_By_USER_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_USER_ID", i_Params_Get_Alert_settings_By_USER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_USER_ID(i_Params_Get_Alert_settings_By_USER_ID.USER_ID);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_USER_ID", i_Params_Get_Alert_settings_By_USER_ID_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_OWNER_ID_IS_DELETED
        public List<Alert_settings> Get_Alert_settings_By_OWNER_ID_IS_DELETED(Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED i_Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_OWNER_ID_IS_DELETED", i_Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_OWNER_ID_IS_DELETED(i_Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_OWNER_ID_IS_DELETED", i_Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_KPI_ID
        public List<Alert_settings> Get_Alert_settings_By_KPI_ID(Params_Get_Alert_settings_By_KPI_ID i_Params_Get_Alert_settings_By_KPI_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_KPI_ID", i_Params_Get_Alert_settings_By_KPI_ID_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_KPI_ID(i_Params_Get_Alert_settings_By_KPI_ID.KPI_ID);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_KPI_ID", i_Params_Get_Alert_settings_By_KPI_ID_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_VALUE_TYPE_SETUP_ID
        public List<Alert_settings> Get_Alert_settings_By_VALUE_TYPE_SETUP_ID(Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_VALUE_TYPE_SETUP_ID", i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_VALUE_TYPE_SETUP_ID(i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID.VALUE_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_VALUE_TYPE_SETUP_ID", i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_OWNER_ID
        public List<Default_settings_image> Get_Default_settings_image_By_OWNER_ID(Params_Get_Default_settings_image_By_OWNER_ID i_Params_Get_Default_settings_image_By_OWNER_ID)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_OWNER_ID", i_Params_Get_Default_settings_image_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_OWNER_ID(i_Params_Get_Default_settings_image_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_OWNER_ID", i_Params_Get_Default_settings_image_By_OWNER_ID_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_ID
        public List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_ID(Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_ID", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_DEFAULT_SETTINGS_ID(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID.DEFAULT_SETTINGS_ID);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_ID", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID
        public List<Default_settings_image> Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID(Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID", i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID(i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID.IMAGE_TYPE_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID", i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_OWNER_ID_IS_DELETED
        public List<Default_settings_image> Get_Default_settings_image_By_OWNER_ID_IS_DELETED(Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED i_Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_OWNER_ID_IS_DELETED", i_Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_OWNER_ID_IS_DELETED(i_Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_OWNER_ID_IS_DELETED", i_Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Owner_By_IS_DELETED
        public List<Owner> Get_Owner_By_IS_DELETED(Params_Get_Owner_By_IS_DELETED i_Params_Get_Owner_By_IS_DELETED)
        {
            List<Owner> oList_Owner = null;
            var i_Params_Get_Owner_By_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Owner_By_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Owner_By_IS_DELETED", i_Params_Get_Owner_By_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Owner> oList_DBEntry = _AppContext.Get_Owner_By_IS_DELETED(i_Params_Get_Owner_By_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Owner = new List<Owner>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Owner oOwner = new Owner();
                        Props.Copy_Prop_Values(oDBEntry, oOwner);
                        oList_Owner.Add(oOwner);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Owner_By_IS_DELETED", i_Params_Get_Owner_By_IS_DELETED_json, false);
            }
            return oList_Owner;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID
        public List<Setup_category> Get_Setup_category_By_OWNER_ID(Params_Get_Setup_category_By_OWNER_ID i_Params_Get_Setup_category_By_OWNER_ID)
        {
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_OWNER_ID", i_Params_Get_Setup_category_By_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Setup_category_By_OWNER_ID
            if (OnPreEvent_Get_Setup_category_By_OWNER_ID != null)
            {
                OnPreEvent_Get_Setup_category_By_OWNER_ID(i_Params_Get_Setup_category_By_OWNER_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_OWNER_ID(i_Params_Get_Setup_category_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Setup_category_By_OWNER_ID
            if (OnPostEvent_Get_Setup_category_By_OWNER_ID != null)
            {
                OnPostEvent_Get_Setup_category_By_OWNER_ID(oList_Setup_category, i_Params_Get_Setup_category_By_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_OWNER_ID", i_Params_Get_Setup_category_By_OWNER_ID_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_OWNER_ID_IS_DELETED
        public List<Setup_category> Get_Setup_category_By_OWNER_ID_IS_DELETED(Params_Get_Setup_category_By_OWNER_ID_IS_DELETED i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED)
        {
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_OWNER_ID_IS_DELETED(i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public Setup_category Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID)
        {
            Setup_category oSetup_category = null;
            var i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
            if (OnPreEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID != null)
            {
                OnPreEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
            }
            #endregion
            #region Body Section.
            DALC.Setup_category oDBEntry = _AppContext.Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME, i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID);
            if (oDBEntry != null)
            {
                oSetup_category = new Setup_category();
                Props.Copy_Prop_Values(oDBEntry, oSetup_category);
            }
            #endregion
            #region PostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
            if (OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID != null)
            {
                OnPostEvent_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(oSetup_category, i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
            return oSetup_category;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID_IS_DELETED
        public List<Setup> Get_Setup_By_OWNER_ID_IS_DELETED(Params_Get_Setup_By_OWNER_ID_IS_DELETED i_Params_Get_Setup_By_OWNER_ID_IS_DELETED)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID_IS_DELETED(i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID_IS_DELETED", i_Params_Get_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID(Params_Get_Setup_By_SETUP_CATEGORY_ID i_Params_Get_Setup_By_SETUP_CATEGORY_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID(i_Params_Get_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_VALUE
        public Setup Get_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE)
        {
            Setup oSetup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            #region Body Section.
            DALC.Setup oDBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_VALUE(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID, i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE);
            if (oDBEntry != null)
            {
                oSetup = new Setup();
                Props.Copy_Prop_Values(oDBEntry, oSetup);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            return oSetup;
        }
        #endregion
        #region Get_Setup_By_OWNER_ID
        public List<Setup> Get_Setup_By_OWNER_ID(Params_Get_Setup_By_OWNER_ID i_Params_Get_Setup_By_OWNER_ID)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_OWNER_ID", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_OWNER_ID(i_Params_Get_Setup_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_OWNER_ID", i_Params_Get_Setup_By_OWNER_ID_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_OWNER_ID
        public List<Build_version> Get_Build_version_By_OWNER_ID(Params_Get_Build_version_By_OWNER_ID i_Params_Get_Build_version_By_OWNER_ID)
        {
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_OWNER_ID", i_Params_Get_Build_version_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_OWNER_ID(i_Params_Get_Build_version_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_OWNER_ID", i_Params_Get_Build_version_By_OWNER_ID_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Build_version_By_APPLICATION_NAME_SETUP_ID
        public List<Build_version> Get_Build_version_By_APPLICATION_NAME_SETUP_ID(Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID)
        {
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_APPLICATION_NAME_SETUP_ID", i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_json, false);
            }
            #region PreEvent_Get_Build_version_By_APPLICATION_NAME_SETUP_ID
            if (OnPreEvent_Get_Build_version_By_APPLICATION_NAME_SETUP_ID != null)
            {
                OnPreEvent_Get_Build_version_By_APPLICATION_NAME_SETUP_ID(i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_APPLICATION_NAME_SETUP_ID(i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID.APPLICATION_NAME_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Build_version_By_APPLICATION_NAME_SETUP_ID
            if (OnPostEvent_Get_Build_version_By_APPLICATION_NAME_SETUP_ID != null)
            {
                OnPostEvent_Get_Build_version_By_APPLICATION_NAME_SETUP_ID(oList_Build_version, i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_APPLICATION_NAME_SETUP_ID", i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Build_version_By_OWNER_ID_IS_DELETED
        public List<Build_version> Get_Build_version_By_OWNER_ID_IS_DELETED(Params_Get_Build_version_By_OWNER_ID_IS_DELETED i_Params_Get_Build_version_By_OWNER_ID_IS_DELETED)
        {
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_OWNER_ID_IS_DELETED", i_Params_Get_Build_version_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_OWNER_ID_IS_DELETED(i_Params_Get_Build_version_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Build_version_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_OWNER_ID_IS_DELETED", i_Params_Get_Build_version_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID
        public List<Build_version> Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID(Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID i_Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID)
        {
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID", i_Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID(i_Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID.IS_CURRENT, i_Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID.APPLICATION_NAME_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID", i_Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_settings_By_OWNER_ID_IS_DELETED
        public List<Default_settings> Get_Default_settings_By_OWNER_ID_IS_DELETED(Params_Get_Default_settings_By_OWNER_ID_IS_DELETED i_Params_Get_Default_settings_By_OWNER_ID_IS_DELETED)
        {
            List<Default_settings> oList_Default_settings = null;
            var i_Params_Get_Default_settings_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_By_OWNER_ID_IS_DELETED", i_Params_Get_Default_settings_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings> oList_DBEntry = _AppContext.Get_Default_settings_By_OWNER_ID_IS_DELETED(i_Params_Get_Default_settings_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Default_settings_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Default_settings = new List<Default_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings oDefault_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings);
                        oList_Default_settings.Add(oDefault_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_By_OWNER_ID_IS_DELETED", i_Params_Get_Default_settings_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Default_settings;
        }
        #endregion
        #region Get_Default_settings_By_OWNER_ID
        public List<Default_settings> Get_Default_settings_By_OWNER_ID(Params_Get_Default_settings_By_OWNER_ID i_Params_Get_Default_settings_By_OWNER_ID)
        {
            List<Default_settings> oList_Default_settings = null;
            var i_Params_Get_Default_settings_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_By_OWNER_ID", i_Params_Get_Default_settings_By_OWNER_ID_json, false);
            }
            #region PreEvent_Get_Default_settings_By_OWNER_ID
            if (OnPreEvent_Get_Default_settings_By_OWNER_ID != null)
            {
                OnPreEvent_Get_Default_settings_By_OWNER_ID(i_Params_Get_Default_settings_By_OWNER_ID);
            }
            #endregion
            #region Body Section.
            List<DALC.Default_settings> oList_DBEntry = _AppContext.Get_Default_settings_By_OWNER_ID(i_Params_Get_Default_settings_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Default_settings = new List<Default_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings oDefault_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings);
                        oList_Default_settings.Add(oDefault_settings);
                    }
                }
            }
            #endregion
            #region PostEvent_Get_Default_settings_By_OWNER_ID
            if (OnPostEvent_Get_Default_settings_By_OWNER_ID != null)
            {
                OnPostEvent_Get_Default_settings_By_OWNER_ID(ref oList_Default_settings, i_Params_Get_Default_settings_By_OWNER_ID);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_By_OWNER_ID", i_Params_Get_Default_settings_By_OWNER_ID_json, false);
            }
            return oList_Default_settings;
        }
        #endregion
        #region Get_Default_settings_By_TELUS_REQUEST_ID
        public List<Default_settings> Get_Default_settings_By_TELUS_REQUEST_ID(Params_Get_Default_settings_By_TELUS_REQUEST_ID i_Params_Get_Default_settings_By_TELUS_REQUEST_ID)
        {
            List<Default_settings> oList_Default_settings = null;
            var i_Params_Get_Default_settings_By_TELUS_REQUEST_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_By_TELUS_REQUEST_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_By_TELUS_REQUEST_ID", i_Params_Get_Default_settings_By_TELUS_REQUEST_ID_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings> oList_DBEntry = _AppContext.Get_Default_settings_By_TELUS_REQUEST_ID(i_Params_Get_Default_settings_By_TELUS_REQUEST_ID.TELUS_REQUEST_ID);
            if (oList_DBEntry != null)
            {
                oList_Default_settings = new List<Default_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings oDefault_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings);
                        oList_Default_settings.Add(oDefault_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_By_TELUS_REQUEST_ID", i_Params_Get_Default_settings_By_TELUS_REQUEST_ID_json, false);
            }
            return oList_Default_settings;
        }
        #endregion
        #region Get_Default_chart_color_By_OWNER_ID
        public List<Default_chart_color> Get_Default_chart_color_By_OWNER_ID(Params_Get_Default_chart_color_By_OWNER_ID i_Params_Get_Default_chart_color_By_OWNER_ID)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_OWNER_ID", i_Params_Get_Default_chart_color_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_OWNER_ID(i_Params_Get_Default_chart_color_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_OWNER_ID", i_Params_Get_Default_chart_color_By_OWNER_ID_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_SETTINGS_ID
        public List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_SETTINGS_ID(Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_DEFAULT_SETTINGS_ID", i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_json, false);
            }
            #region Body Section.
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_DEFAULT_SETTINGS_ID(i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID.DEFAULT_SETTINGS_ID);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_DEFAULT_SETTINGS_ID", i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_OWNER_ID_IS_DELETED
        public List<Default_chart_color> Get_Default_chart_color_By_OWNER_ID_IS_DELETED(Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED i_Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_OWNER_ID_IS_DELETED", i_Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_OWNER_ID_IS_DELETED(i_Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_OWNER_ID_IS_DELETED", i_Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID
        public List<Default_chart_color> Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID(Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID", i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID(i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID", i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Districtnex_module_By_OWNER_ID
        public List<Districtnex_module> Get_Districtnex_module_By_OWNER_ID(Params_Get_Districtnex_module_By_OWNER_ID i_Params_Get_Districtnex_module_By_OWNER_ID)
        {
            List<Districtnex_module> oList_Districtnex_module = null;
            var i_Params_Get_Districtnex_module_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Get_Districtnex_module_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Districtnex_module_By_OWNER_ID", i_Params_Get_Districtnex_module_By_OWNER_ID_json, false);
            }
            #region Body Section.
            List<DALC.Districtnex_module> oList_DBEntry = _AppContext.Get_Districtnex_module_By_OWNER_ID(i_Params_Get_Districtnex_module_By_OWNER_ID.OWNER_ID);
            if (oList_DBEntry != null)
            {
                oList_Districtnex_module = new List<Districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Districtnex_module oDistrictnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oDistrictnex_module);
                        oList_Districtnex_module.Add(oDistrictnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Districtnex_module_By_OWNER_ID", i_Params_Get_Districtnex_module_By_OWNER_ID_json, false);
            }
            return oList_Districtnex_module;
        }
        #endregion
        #region Get_Districtnex_module_By_OWNER_ID_IS_DELETED
        public List<Districtnex_module> Get_Districtnex_module_By_OWNER_ID_IS_DELETED(Params_Get_Districtnex_module_By_OWNER_ID_IS_DELETED i_Params_Get_Districtnex_module_By_OWNER_ID_IS_DELETED)
        {
            List<Districtnex_module> oList_Districtnex_module = null;
            var i_Params_Get_Districtnex_module_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Get_Districtnex_module_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Districtnex_module_By_OWNER_ID_IS_DELETED", i_Params_Get_Districtnex_module_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            List<DALC.Districtnex_module> oList_DBEntry = _AppContext.Get_Districtnex_module_By_OWNER_ID_IS_DELETED(i_Params_Get_Districtnex_module_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Get_Districtnex_module_By_OWNER_ID_IS_DELETED.IS_DELETED);
            if (oList_DBEntry != null)
            {
                oList_Districtnex_module = new List<Districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Districtnex_module oDistrictnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oDistrictnex_module);
                        oList_Districtnex_module.Add(oDistrictnex_module);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Districtnex_module_By_OWNER_ID_IS_DELETED", i_Params_Get_Districtnex_module_By_OWNER_ID_IS_DELETED_json, false);
            }
            return oList_Districtnex_module;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_VERSION_ID_List
        public List<Build_version_log> Get_Build_version_log_By_BUILD_VERSION_ID_List(Params_Get_Build_version_log_By_BUILD_VERSION_ID_List i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_List)
        {
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_BUILD_VERSION_ID_List", i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_BUILD_VERSION_ID_List(i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_List.BUILD_VERSION_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_BUILD_VERSION_ID_List", i_Params_Get_Build_version_log_By_BUILD_VERSION_ID_List_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List
        public List<Build_version_log> Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List(Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List)
        {
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List", i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List(i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List.BUILD_LOG_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List", i_Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_LEVEL_ID_List
        public List<Removed_extrusion> Get_Removed_extrusion_By_LEVEL_ID_List(Params_Get_Removed_extrusion_By_LEVEL_ID_List i_Params_Get_Removed_extrusion_By_LEVEL_ID_List)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_LEVEL_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_LEVEL_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_LEVEL_ID_List", i_Params_Get_Removed_extrusion_By_LEVEL_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_LEVEL_ID_List(i_Params_Get_Removed_extrusion_By_LEVEL_ID_List.LEVEL_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_LEVEL_ID_List", i_Params_Get_Removed_extrusion_By_LEVEL_ID_List_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List
        public List<Removed_extrusion> Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List(Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List)
        {
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List(i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List.DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_OPERATION_SETUP_ID_List
        public List<Alert_settings> Get_Alert_settings_By_OPERATION_SETUP_ID_List(Params_Get_Alert_settings_By_OPERATION_SETUP_ID_List i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_List)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_OPERATION_SETUP_ID_List", i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_OPERATION_SETUP_ID_List(i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_List.OPERATION_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_OPERATION_SETUP_ID_List", i_Params_Get_Alert_settings_By_OPERATION_SETUP_ID_List_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_USER_ID_List
        public List<Alert_settings> Get_Alert_settings_By_USER_ID_List(Params_Get_Alert_settings_By_USER_ID_List i_Params_Get_Alert_settings_By_USER_ID_List)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_USER_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_USER_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_USER_ID_List", i_Params_Get_Alert_settings_By_USER_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_USER_ID_List(i_Params_Get_Alert_settings_By_USER_ID_List.USER_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_USER_ID_List", i_Params_Get_Alert_settings_By_USER_ID_List_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_KPI_ID_List
        public List<Alert_settings> Get_Alert_settings_By_KPI_ID_List(Params_Get_Alert_settings_By_KPI_ID_List i_Params_Get_Alert_settings_By_KPI_ID_List)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_KPI_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_KPI_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_KPI_ID_List", i_Params_Get_Alert_settings_By_KPI_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_KPI_ID_List(i_Params_Get_Alert_settings_By_KPI_ID_List.KPI_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_KPI_ID_List", i_Params_Get_Alert_settings_By_KPI_ID_List_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List
        public List<Alert_settings> Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List(Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List)
        {
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List", i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List(i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List.VALUE_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List", i_Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List
        public List<Default_settings_image> Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List(Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List(i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List.DEFAULT_SETTINGS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List", i_Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID_List_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List
        public List<Default_settings_image> Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List(Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List)
        {
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List", i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List(i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List.IMAGE_TYPE_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List", i_Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_List_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Setup_By_SETUP_CATEGORY_ID_List
        public List<Setup> Get_Setup_By_SETUP_CATEGORY_ID_List(Params_Get_Setup_By_SETUP_CATEGORY_ID_List i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List)
        {
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_SETUP_CATEGORY_ID_List(i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List.SETUP_CATEGORY_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_SETUP_CATEGORY_ID_List", i_Params_Get_Setup_By_SETUP_CATEGORY_ID_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List
        public List<Build_version> Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List(Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List)
        {
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List", i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List(i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List.APPLICATION_NAME_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List", i_Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID_List_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List
        public List<Default_chart_color> Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List(Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List", i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List(i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List.DEFAULT_SETTINGS_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List", i_Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID_List_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List
        public List<Default_chart_color> Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List(Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List)
        {
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            #region Body Section.
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List(i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List.DATA_LEVEL_SETUP_ID_LIST);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List", i_Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID_List_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Build_version_log_By_Where
        public List<Build_version_log> Get_Build_version_log_By_Where(Params_Get_Build_version_log_By_Where i_Params_Get_Build_version_log_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_Where", i_Params_Get_Build_version_log_By_Where_json, false);
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
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_Where(i_Params_Get_Build_version_log_By_Where.DESCRIPTION, i_Params_Get_Build_version_log_By_Where.OWNER_ID, i_Params_Get_Build_version_log_By_Where.OFFSET, i_Params_Get_Build_version_log_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            i_Params_Get_Build_version_log_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_Where", i_Params_Get_Build_version_log_By_Where_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_Where
        public List<Removed_extrusion> Get_Removed_extrusion_By_Where(Params_Get_Removed_extrusion_By_Where i_Params_Get_Removed_extrusion_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_Where", i_Params_Get_Removed_extrusion_By_Where_json, false);
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
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_Where(i_Params_Get_Removed_extrusion_By_Where.EXTRUSION_IDENTIFIER, i_Params_Get_Removed_extrusion_By_Where.OWNER_ID, i_Params_Get_Removed_extrusion_By_Where.OFFSET, i_Params_Get_Removed_extrusion_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            i_Params_Get_Removed_extrusion_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_Where", i_Params_Get_Removed_extrusion_By_Where_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_Where
        public List<Alert_settings> Get_Alert_settings_By_Where(Params_Get_Alert_settings_By_Where i_Params_Get_Alert_settings_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_Where", i_Params_Get_Alert_settings_By_Where_json, false);
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
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_Where(i_Params_Get_Alert_settings_By_Where.DESCRIPTION, i_Params_Get_Alert_settings_By_Where.OWNER_ID, i_Params_Get_Alert_settings_By_Where.OFFSET, i_Params_Get_Alert_settings_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            i_Params_Get_Alert_settings_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_Where", i_Params_Get_Alert_settings_By_Where_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_Where
        public List<Default_settings_image> Get_Default_settings_image_By_Where(Params_Get_Default_settings_image_By_Where i_Params_Get_Default_settings_image_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_Where", i_Params_Get_Default_settings_image_By_Where_json, false);
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
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_Where(i_Params_Get_Default_settings_image_By_Where.IMAGE_NAME, i_Params_Get_Default_settings_image_By_Where.IMAGE_EXTENSION, i_Params_Get_Default_settings_image_By_Where.OWNER_ID, i_Params_Get_Default_settings_image_By_Where.OFFSET, i_Params_Get_Default_settings_image_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            i_Params_Get_Default_settings_image_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_Where", i_Params_Get_Default_settings_image_By_Where_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Owner_By_Where
        public List<Owner> Get_Owner_By_Where(Params_Get_Owner_By_Where i_Params_Get_Owner_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Owner> oList_Owner = null;
            var i_Params_Get_Owner_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Owner_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Owner_By_Where", i_Params_Get_Owner_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Owner_By_Where.OFFSET == null)
            {
                i_Params_Get_Owner_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Owner_By_Where.FETCH_NEXT == null || i_Params_Get_Owner_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Owner_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Owner> oList_DBEntry = _AppContext.Get_Owner_By_Where(i_Params_Get_Owner_By_Where.CODE, i_Params_Get_Owner_By_Where.DESCRIPTION, i_Params_Get_Owner_By_Where.OWNER_ID, i_Params_Get_Owner_By_Where.OFFSET, i_Params_Get_Owner_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Owner = new List<Owner>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Owner oOwner = new Owner();
                        Props.Copy_Prop_Values(oDBEntry, oOwner);
                        oList_Owner.Add(oOwner);
                    }
                }
            }
            i_Params_Get_Owner_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Owner_By_Where", i_Params_Get_Owner_By_Where_json, false);
            }
            return oList_Owner;
        }
        #endregion
        #region Get_Setup_category_By_Where
        public List<Setup_category> Get_Setup_category_By_Where(Params_Get_Setup_category_By_Where i_Params_Get_Setup_category_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup_category> oList_Setup_category = null;
            var i_Params_Get_Setup_category_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Setup_category_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_category_By_Where", i_Params_Get_Setup_category_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Setup_category_By_Where.OWNER_ID == null || i_Params_Get_Setup_category_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Setup_category_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Setup_category_By_Where.OFFSET == null)
            {
                i_Params_Get_Setup_category_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Setup_category_By_Where.FETCH_NEXT == null || i_Params_Get_Setup_category_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Setup_category_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Setup_category> oList_DBEntry = _AppContext.Get_Setup_category_By_Where(i_Params_Get_Setup_category_By_Where.SETUP_CATEGORY_NAME, i_Params_Get_Setup_category_By_Where.DESCRIPTION, i_Params_Get_Setup_category_By_Where.OWNER_ID, i_Params_Get_Setup_category_By_Where.OFFSET, i_Params_Get_Setup_category_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup_category = new List<Setup_category>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup_category oSetup_category = new Setup_category();
                        Props.Copy_Prop_Values(oDBEntry, oSetup_category);
                        oList_Setup_category.Add(oSetup_category);
                    }
                }
            }
            i_Params_Get_Setup_category_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_category_By_Where", i_Params_Get_Setup_category_By_Where_json, false);
            }
            return oList_Setup_category;
        }
        #endregion
        #region Get_Setup_By_Where
        public List<Setup> Get_Setup_By_Where(Params_Get_Setup_By_Where i_Params_Get_Setup_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where", i_Params_Get_Setup_By_Where_json, false);
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
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where(i_Params_Get_Setup_By_Where.VALUE, i_Params_Get_Setup_By_Where.DESCRIPTION, i_Params_Get_Setup_By_Where.OWNER_ID, i_Params_Get_Setup_By_Where.OFFSET, i_Params_Get_Setup_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where", i_Params_Get_Setup_By_Where_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_Where
        public List<Build_version> Get_Build_version_By_Where(Params_Get_Build_version_By_Where i_Params_Get_Build_version_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_Where", i_Params_Get_Build_version_By_Where_json, false);
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
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_Where(i_Params_Get_Build_version_By_Where.BUILD_NUMBER, i_Params_Get_Build_version_By_Where.COMMENTS, i_Params_Get_Build_version_By_Where.OWNER_ID, i_Params_Get_Build_version_By_Where.OFFSET, i_Params_Get_Build_version_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            i_Params_Get_Build_version_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_Where", i_Params_Get_Build_version_By_Where_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_settings_By_Where
        public List<Default_settings> Get_Default_settings_By_Where(Params_Get_Default_settings_By_Where i_Params_Get_Default_settings_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Default_settings> oList_Default_settings = null;
            var i_Params_Get_Default_settings_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_By_Where", i_Params_Get_Default_settings_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Default_settings_By_Where.OWNER_ID == null || i_Params_Get_Default_settings_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Default_settings_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Default_settings_By_Where.OFFSET == null)
            {
                i_Params_Get_Default_settings_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Default_settings_By_Where.FETCH_NEXT == null || i_Params_Get_Default_settings_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Default_settings_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Default_settings> oList_DBEntry = _AppContext.Get_Default_settings_By_Where(i_Params_Get_Default_settings_By_Where.PLATFORM_PRIMARY, i_Params_Get_Default_settings_By_Where.PLATFORM_BUTTON, i_Params_Get_Default_settings_By_Where.MAPBOX_GL_TOKEN, i_Params_Get_Default_settings_By_Where.GOOGLE_MAP_API_TOKEN, i_Params_Get_Default_settings_By_Where.TELUS_REQUEST_ID, i_Params_Get_Default_settings_By_Where.OWNER_ID, i_Params_Get_Default_settings_By_Where.OFFSET, i_Params_Get_Default_settings_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Default_settings = new List<Default_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings oDefault_settings = new Default_settings();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings);
                        oList_Default_settings.Add(oDefault_settings);
                    }
                }
            }
            i_Params_Get_Default_settings_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_By_Where", i_Params_Get_Default_settings_By_Where_json, false);
            }
            return oList_Default_settings;
        }
        #endregion
        #region Get_Default_chart_color_By_Where
        public List<Default_chart_color> Get_Default_chart_color_By_Where(Params_Get_Default_chart_color_By_Where i_Params_Get_Default_chart_color_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_Where", i_Params_Get_Default_chart_color_By_Where_json, false);
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
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_Where(i_Params_Get_Default_chart_color_By_Where.COLOR, i_Params_Get_Default_chart_color_By_Where.OWNER_ID, i_Params_Get_Default_chart_color_By_Where.OFFSET, i_Params_Get_Default_chart_color_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            i_Params_Get_Default_chart_color_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_Where", i_Params_Get_Default_chart_color_By_Where_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Get_Districtnex_module_By_Where
        public List<Districtnex_module> Get_Districtnex_module_By_Where(Params_Get_Districtnex_module_By_Where i_Params_Get_Districtnex_module_By_Where)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Districtnex_module> oList_Districtnex_module = null;
            var i_Params_Get_Districtnex_module_By_Where_json = JsonConvert.SerializeObject(i_Params_Get_Districtnex_module_By_Where);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Districtnex_module_By_Where", i_Params_Get_Districtnex_module_By_Where_json, false);
            }
            #region Body Section.
            if (i_Params_Get_Districtnex_module_By_Where.OWNER_ID == null || i_Params_Get_Districtnex_module_By_Where.OWNER_ID == 0)
            {
                i_Params_Get_Districtnex_module_By_Where.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            }
            if (i_Params_Get_Districtnex_module_By_Where.OFFSET == null)
            {
                i_Params_Get_Districtnex_module_By_Where.OFFSET = 0;
            }
            if (i_Params_Get_Districtnex_module_By_Where.FETCH_NEXT == null || i_Params_Get_Districtnex_module_By_Where.FETCH_NEXT == 0)
            {
                i_Params_Get_Districtnex_module_By_Where.FETCH_NEXT = 1000000;
            }
            List<DALC.Districtnex_module> oList_DBEntry = _AppContext.Get_Districtnex_module_By_Where(i_Params_Get_Districtnex_module_By_Where.NAME, i_Params_Get_Districtnex_module_By_Where.OWNER_ID, i_Params_Get_Districtnex_module_By_Where.OFFSET, i_Params_Get_Districtnex_module_By_Where.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Districtnex_module = new List<Districtnex_module>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Districtnex_module oDistrictnex_module = new Districtnex_module();
                        Props.Copy_Prop_Values(oDBEntry, oDistrictnex_module);
                        oList_Districtnex_module.Add(oDistrictnex_module);
                    }
                }
            }
            i_Params_Get_Districtnex_module_By_Where.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Districtnex_module_By_Where", i_Params_Get_Districtnex_module_By_Where_json, false);
            }
            return oList_Districtnex_module;
        }
        #endregion
        #region Get_Build_version_log_By_Where_In_List
        public List<Build_version_log> Get_Build_version_log_By_Where_In_List(Params_Get_Build_version_log_By_Where_In_List i_Params_Get_Build_version_log_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Build_version_log> oList_Build_version_log = null;
            var i_Params_Get_Build_version_log_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_log_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_log_By_Where_In_List", i_Params_Get_Build_version_log_By_Where_In_List_json, false);
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
            List<DALC.Build_version_log> oList_DBEntry = _AppContext.Get_Build_version_log_By_Where_In_List(i_Params_Get_Build_version_log_By_Where_In_List.DESCRIPTION, i_Params_Get_Build_version_log_By_Where_In_List.BUILD_VERSION_ID_LIST, i_Params_Get_Build_version_log_By_Where_In_List.BUILD_LOG_TYPE_SETUP_ID_LIST, i_Params_Get_Build_version_log_By_Where_In_List.OWNER_ID, i_Params_Get_Build_version_log_By_Where_In_List.OFFSET, i_Params_Get_Build_version_log_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Build_version_log = new List<Build_version_log>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version_log oBuild_version_log = new Build_version_log();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version_log);
                        oList_Build_version_log.Add(oBuild_version_log);
                    }
                }
            }
            i_Params_Get_Build_version_log_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_log_By_Where_In_List", i_Params_Get_Build_version_log_By_Where_In_List_json, false);
            }
            return oList_Build_version_log;
        }
        #endregion
        #region Get_Removed_extrusion_By_Where_In_List
        public List<Removed_extrusion> Get_Removed_extrusion_By_Where_In_List(Params_Get_Removed_extrusion_By_Where_In_List i_Params_Get_Removed_extrusion_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Removed_extrusion> oList_Removed_extrusion = null;
            var i_Params_Get_Removed_extrusion_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Removed_extrusion_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Removed_extrusion_By_Where_In_List", i_Params_Get_Removed_extrusion_By_Where_In_List_json, false);
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
            List<DALC.Removed_extrusion> oList_DBEntry = _AppContext.Get_Removed_extrusion_By_Where_In_List(i_Params_Get_Removed_extrusion_By_Where_In_List.EXTRUSION_IDENTIFIER, i_Params_Get_Removed_extrusion_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Removed_extrusion_By_Where_In_List.OWNER_ID, i_Params_Get_Removed_extrusion_By_Where_In_List.OFFSET, i_Params_Get_Removed_extrusion_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Removed_extrusion = new List<Removed_extrusion>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Removed_extrusion oRemoved_extrusion = new Removed_extrusion();
                        Props.Copy_Prop_Values(oDBEntry, oRemoved_extrusion);
                        oList_Removed_extrusion.Add(oRemoved_extrusion);
                    }
                }
            }
            i_Params_Get_Removed_extrusion_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Removed_extrusion_By_Where_In_List", i_Params_Get_Removed_extrusion_By_Where_In_List_json, false);
            }
            return oList_Removed_extrusion;
        }
        #endregion
        #region Get_Alert_settings_By_Where_In_List
        public List<Alert_settings> Get_Alert_settings_By_Where_In_List(Params_Get_Alert_settings_By_Where_In_List i_Params_Get_Alert_settings_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Alert_settings> oList_Alert_settings = null;
            var i_Params_Get_Alert_settings_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Alert_settings_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Alert_settings_By_Where_In_List", i_Params_Get_Alert_settings_By_Where_In_List_json, false);
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
            List<DALC.Alert_settings> oList_DBEntry = _AppContext.Get_Alert_settings_By_Where_In_List(i_Params_Get_Alert_settings_By_Where_In_List.DESCRIPTION, i_Params_Get_Alert_settings_By_Where_In_List.USER_ID_LIST, i_Params_Get_Alert_settings_By_Where_In_List.KPI_ID_LIST, i_Params_Get_Alert_settings_By_Where_In_List.VALUE_TYPE_SETUP_ID_LIST, i_Params_Get_Alert_settings_By_Where_In_List.OPERATION_SETUP_ID_LIST, i_Params_Get_Alert_settings_By_Where_In_List.OWNER_ID, i_Params_Get_Alert_settings_By_Where_In_List.OFFSET, i_Params_Get_Alert_settings_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Alert_settings = new List<Alert_settings>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Alert_settings oAlert_settings = new Alert_settings();
                        Props.Copy_Prop_Values(oDBEntry, oAlert_settings);
                        oList_Alert_settings.Add(oAlert_settings);
                    }
                }
            }
            i_Params_Get_Alert_settings_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Alert_settings_By_Where_In_List", i_Params_Get_Alert_settings_By_Where_In_List_json, false);
            }
            return oList_Alert_settings;
        }
        #endregion
        #region Get_Default_settings_image_By_Where_In_List
        public List<Default_settings_image> Get_Default_settings_image_By_Where_In_List(Params_Get_Default_settings_image_By_Where_In_List i_Params_Get_Default_settings_image_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Default_settings_image> oList_Default_settings_image = null;
            var i_Params_Get_Default_settings_image_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_settings_image_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_settings_image_By_Where_In_List", i_Params_Get_Default_settings_image_By_Where_In_List_json, false);
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
            List<DALC.Default_settings_image> oList_DBEntry = _AppContext.Get_Default_settings_image_By_Where_In_List(i_Params_Get_Default_settings_image_By_Where_In_List.IMAGE_NAME, i_Params_Get_Default_settings_image_By_Where_In_List.IMAGE_EXTENSION, i_Params_Get_Default_settings_image_By_Where_In_List.DEFAULT_SETTINGS_ID_LIST, i_Params_Get_Default_settings_image_By_Where_In_List.IMAGE_TYPE_SETUP_ID_LIST, i_Params_Get_Default_settings_image_By_Where_In_List.OWNER_ID, i_Params_Get_Default_settings_image_By_Where_In_List.OFFSET, i_Params_Get_Default_settings_image_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Default_settings_image = new List<Default_settings_image>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_settings_image oDefault_settings_image = new Default_settings_image();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_settings_image);
                        oList_Default_settings_image.Add(oDefault_settings_image);
                    }
                }
            }
            i_Params_Get_Default_settings_image_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_settings_image_By_Where_In_List", i_Params_Get_Default_settings_image_By_Where_In_List_json, false);
            }
            return oList_Default_settings_image;
        }
        #endregion
        #region Get_Setup_By_Where_In_List
        public List<Setup> Get_Setup_By_Where_In_List(Params_Get_Setup_By_Where_In_List i_Params_Get_Setup_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Setup> oList_Setup = null;
            var i_Params_Get_Setup_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Setup_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Setup_By_Where_In_List", i_Params_Get_Setup_By_Where_In_List_json, false);
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
            List<DALC.Setup> oList_DBEntry = _AppContext.Get_Setup_By_Where_In_List(i_Params_Get_Setup_By_Where_In_List.VALUE, i_Params_Get_Setup_By_Where_In_List.DESCRIPTION, i_Params_Get_Setup_By_Where_In_List.SETUP_CATEGORY_ID_LIST, i_Params_Get_Setup_By_Where_In_List.OWNER_ID, i_Params_Get_Setup_By_Where_In_List.OFFSET, i_Params_Get_Setup_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Setup = new List<Setup>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Setup oSetup = new Setup();
                        Props.Copy_Prop_Values(oDBEntry, oSetup);
                        oList_Setup.Add(oSetup);
                    }
                }
            }
            i_Params_Get_Setup_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Setup_By_Where_In_List", i_Params_Get_Setup_By_Where_In_List_json, false);
            }
            return oList_Setup;
        }
        #endregion
        #region Get_Build_version_By_Where_In_List
        public List<Build_version> Get_Build_version_By_Where_In_List(Params_Get_Build_version_By_Where_In_List i_Params_Get_Build_version_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Build_version> oList_Build_version = null;
            var i_Params_Get_Build_version_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Build_version_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Build_version_By_Where_In_List", i_Params_Get_Build_version_By_Where_In_List_json, false);
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
            List<DALC.Build_version> oList_DBEntry = _AppContext.Get_Build_version_By_Where_In_List(i_Params_Get_Build_version_By_Where_In_List.BUILD_NUMBER, i_Params_Get_Build_version_By_Where_In_List.COMMENTS, i_Params_Get_Build_version_By_Where_In_List.APPLICATION_NAME_SETUP_ID_LIST, i_Params_Get_Build_version_By_Where_In_List.OWNER_ID, i_Params_Get_Build_version_By_Where_In_List.OFFSET, i_Params_Get_Build_version_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Build_version = new List<Build_version>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Build_version oBuild_version = new Build_version();
                        Props.Copy_Prop_Values(oDBEntry, oBuild_version);
                        oList_Build_version.Add(oBuild_version);
                    }
                }
            }
            i_Params_Get_Build_version_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Build_version_By_Where_In_List", i_Params_Get_Build_version_By_Where_In_List_json, false);
            }
            return oList_Build_version;
        }
        #endregion
        #region Get_Default_chart_color_By_Where_In_List
        public List<Default_chart_color> Get_Default_chart_color_By_Where_In_List(Params_Get_Default_chart_color_By_Where_In_List i_Params_Get_Default_chart_color_By_Where_In_List)
        {
            long? tmp_TOTAL_COUNT = 0;
            List<Default_chart_color> oList_Default_chart_color = null;
            var i_Params_Get_Default_chart_color_By_Where_In_List_json = JsonConvert.SerializeObject(i_Params_Get_Default_chart_color_By_Where_In_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Get_Default_chart_color_By_Where_In_List", i_Params_Get_Default_chart_color_By_Where_In_List_json, false);
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
            List<DALC.Default_chart_color> oList_DBEntry = _AppContext.Get_Default_chart_color_By_Where_In_List(i_Params_Get_Default_chart_color_By_Where_In_List.COLOR, i_Params_Get_Default_chart_color_By_Where_In_List.DEFAULT_SETTINGS_ID_LIST, i_Params_Get_Default_chart_color_By_Where_In_List.DATA_LEVEL_SETUP_ID_LIST, i_Params_Get_Default_chart_color_By_Where_In_List.OWNER_ID, i_Params_Get_Default_chart_color_By_Where_In_List.OFFSET, i_Params_Get_Default_chart_color_By_Where_In_List.FETCH_NEXT, ref tmp_TOTAL_COUNT);
            if (oList_DBEntry != null)
            {
                oList_Default_chart_color = new List<Default_chart_color>();
                if (oList_DBEntry.Count > 0)
                {
                    foreach (var oDBEntry in oList_DBEntry)
                    {
                        Default_chart_color oDefault_chart_color = new Default_chart_color();
                        Props.Copy_Prop_Values(oDBEntry, oDefault_chart_color);
                        oList_Default_chart_color.Add(oDefault_chart_color);
                    }
                }
            }
            i_Params_Get_Default_chart_color_By_Where_In_List.TOTAL_COUNT = tmp_TOTAL_COUNT;
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Get_Default_chart_color_By_Where_In_List", i_Params_Get_Default_chart_color_By_Where_In_List_json, false);
            }
            return oList_Default_chart_color;
        }
        #endregion
        #region Delete_Build_version_log
        public void Delete_Build_version_log(Params_Delete_Build_version_log i_Params_Delete_Build_version_log)
        {
            var i_Params_Delete_Build_version_log_json = JsonConvert.SerializeObject(i_Params_Delete_Build_version_log);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Build_version_log", i_Params_Delete_Build_version_log_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID oParams_Get_Build_version_log_By_BUILD_VERSION_LOG_ID = new Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID
                {
                    BUILD_VERSION_LOG_ID = i_Params_Delete_Build_version_log.BUILD_VERSION_LOG_ID
                };
                _Build_version_log = Get_Build_version_log_By_BUILD_VERSION_LOG_ID(oParams_Get_Build_version_log_By_BUILD_VERSION_LOG_ID);
                if (_Build_version_log != null)
                {
                    if (_Stop_Delete_Build_version_log_Execution)
                    {
                        _Stop_Delete_Build_version_log_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Build_version_log(i_Params_Delete_Build_version_log.BUILD_VERSION_LOG_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Build_version_log", i_Params_Delete_Build_version_log_json, false);
            }
        }
        #endregion
        #region Delete_Removed_extrusion
        public void Delete_Removed_extrusion(Params_Delete_Removed_extrusion i_Params_Delete_Removed_extrusion)
        {
            var i_Params_Delete_Removed_extrusion_json = JsonConvert.SerializeObject(i_Params_Delete_Removed_extrusion);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Removed_extrusion", i_Params_Delete_Removed_extrusion_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID oParams_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID = new Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID
                {
                    REMOVED_EXTRUSION_ID = i_Params_Delete_Removed_extrusion.REMOVED_EXTRUSION_ID
                };
                _Removed_extrusion = Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID(oParams_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID);
                if (_Removed_extrusion != null)
                {
                    if (_Stop_Delete_Removed_extrusion_Execution)
                    {
                        _Stop_Delete_Removed_extrusion_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Removed_extrusion(i_Params_Delete_Removed_extrusion.REMOVED_EXTRUSION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Removed_extrusion", i_Params_Delete_Removed_extrusion_json, false);
            }
        }
        #endregion
        #region Delete_Alert_settings
        public void Delete_Alert_settings(Params_Delete_Alert_settings i_Params_Delete_Alert_settings)
        {
            var i_Params_Delete_Alert_settings_json = JsonConvert.SerializeObject(i_Params_Delete_Alert_settings);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Alert_settings", i_Params_Delete_Alert_settings_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Alert_settings_By_ALERT_SETTINGS_ID oParams_Get_Alert_settings_By_ALERT_SETTINGS_ID = new Params_Get_Alert_settings_By_ALERT_SETTINGS_ID
                {
                    ALERT_SETTINGS_ID = i_Params_Delete_Alert_settings.ALERT_SETTINGS_ID
                };
                _Alert_settings = Get_Alert_settings_By_ALERT_SETTINGS_ID(oParams_Get_Alert_settings_By_ALERT_SETTINGS_ID);
                if (_Alert_settings != null)
                {
                    if (_Stop_Delete_Alert_settings_Execution)
                    {
                        _Stop_Delete_Alert_settings_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Alert_settings(i_Params_Delete_Alert_settings.ALERT_SETTINGS_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Alert_settings", i_Params_Delete_Alert_settings_json, false);
            }
        }
        #endregion
        #region Delete_Default_settings_image
        public void Delete_Default_settings_image(Params_Delete_Default_settings_image i_Params_Delete_Default_settings_image)
        {
            var i_Params_Delete_Default_settings_image_json = JsonConvert.SerializeObject(i_Params_Delete_Default_settings_image);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Default_settings_image", i_Params_Delete_Default_settings_image_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID oParams_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID = new Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID
                {
                    DEFAULT_SETTINGS_IMAGE_ID = i_Params_Delete_Default_settings_image.DEFAULT_SETTINGS_IMAGE_ID
                };
                _Default_settings_image = Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID(oParams_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID);
                if (_Default_settings_image != null)
                {
                    if (_Stop_Delete_Default_settings_image_Execution)
                    {
                        _Stop_Delete_Default_settings_image_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Default_settings_image(i_Params_Delete_Default_settings_image.DEFAULT_SETTINGS_IMAGE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Default_settings_image", i_Params_Delete_Default_settings_image_json, false);
            }
        }
        #endregion
        #region Delete_Owner
        public void Delete_Owner(Params_Delete_Owner i_Params_Delete_Owner)
        {
            var i_Params_Delete_Owner_json = JsonConvert.SerializeObject(i_Params_Delete_Owner);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Owner", i_Params_Delete_Owner_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Owner_By_OWNER_ID oParams_Get_Owner_By_OWNER_ID = new Params_Get_Owner_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Owner.OWNER_ID
                };
                _Owner = Get_Owner_By_OWNER_ID(oParams_Get_Owner_By_OWNER_ID);
                if (_Owner != null)
                {
                    if (_Stop_Delete_Owner_Execution)
                    {
                        _Stop_Delete_Owner_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Owner(i_Params_Delete_Owner.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Owner", i_Params_Delete_Owner_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category
        public void Delete_Setup_category(Params_Delete_Setup_category i_Params_Delete_Setup_category)
        {
            var i_Params_Delete_Setup_category_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category", i_Params_Delete_Setup_category_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_SETUP_CATEGORY_ID oParams_Get_Setup_category_By_SETUP_CATEGORY_ID = new Params_Get_Setup_category_By_SETUP_CATEGORY_ID
                {
                    SETUP_CATEGORY_ID = i_Params_Delete_Setup_category.SETUP_CATEGORY_ID
                };
                _Setup_category = Get_Setup_category_By_SETUP_CATEGORY_ID(oParams_Get_Setup_category_By_SETUP_CATEGORY_ID);
                if (_Setup_category != null)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category(i_Params_Delete_Setup_category.SETUP_CATEGORY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category", i_Params_Delete_Setup_category_json, false);
            }
        }
        #endregion
        #region Delete_Setup
        public void Delete_Setup(Params_Delete_Setup i_Params_Delete_Setup)
        {
            var i_Params_Delete_Setup_json = JsonConvert.SerializeObject(i_Params_Delete_Setup);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup", i_Params_Delete_Setup_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_SETUP_ID oParams_Get_Setup_By_SETUP_ID = new Params_Get_Setup_By_SETUP_ID
                {
                    SETUP_ID = i_Params_Delete_Setup.SETUP_ID
                };
                _Setup = Get_Setup_By_SETUP_ID(oParams_Get_Setup_By_SETUP_ID);
                if (_Setup != null)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup(i_Params_Delete_Setup.SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup", i_Params_Delete_Setup_json, false);
            }
        }
        #endregion
        #region Delete_Build_version
        public void Delete_Build_version(Params_Delete_Build_version i_Params_Delete_Build_version)
        {
            var i_Params_Delete_Build_version_json = JsonConvert.SerializeObject(i_Params_Delete_Build_version);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Build_version", i_Params_Delete_Build_version_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Build_version_By_BUILD_VERSION_ID oParams_Get_Build_version_By_BUILD_VERSION_ID = new Params_Get_Build_version_By_BUILD_VERSION_ID
                {
                    BUILD_VERSION_ID = i_Params_Delete_Build_version.BUILD_VERSION_ID
                };
                _Build_version = Get_Build_version_By_BUILD_VERSION_ID(oParams_Get_Build_version_By_BUILD_VERSION_ID);
                if (_Build_version != null)
                {
                    if (_Stop_Delete_Build_version_Execution)
                    {
                        _Stop_Delete_Build_version_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Build_version(i_Params_Delete_Build_version.BUILD_VERSION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Build_version", i_Params_Delete_Build_version_json, false);
            }
        }
        #endregion
        #region Delete_Default_settings
        public void Delete_Default_settings(Params_Delete_Default_settings i_Params_Delete_Default_settings)
        {
            var i_Params_Delete_Default_settings_json = JsonConvert.SerializeObject(i_Params_Delete_Default_settings);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Default_settings", i_Params_Delete_Default_settings_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID oParams_Get_Default_settings_By_DEFAULT_SETTINGS_ID = new Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID
                {
                    DEFAULT_SETTINGS_ID = i_Params_Delete_Default_settings.DEFAULT_SETTINGS_ID
                };
                _Default_settings = Get_Default_settings_By_DEFAULT_SETTINGS_ID(oParams_Get_Default_settings_By_DEFAULT_SETTINGS_ID);
                if (_Default_settings != null)
                {
                    if (_Stop_Delete_Default_settings_Execution)
                    {
                        _Stop_Delete_Default_settings_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Default_settings(i_Params_Delete_Default_settings.DEFAULT_SETTINGS_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Default_settings", i_Params_Delete_Default_settings_json, false);
            }
        }
        #endregion
        #region Delete_Default_chart_color
        public void Delete_Default_chart_color(Params_Delete_Default_chart_color i_Params_Delete_Default_chart_color)
        {
            var i_Params_Delete_Default_chart_color_json = JsonConvert.SerializeObject(i_Params_Delete_Default_chart_color);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Default_chart_color", i_Params_Delete_Default_chart_color_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID oParams_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID = new Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID
                {
                    DEFAULT_CHART_COLOR_ID = i_Params_Delete_Default_chart_color.DEFAULT_CHART_COLOR_ID
                };
                _Default_chart_color = Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID(oParams_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID);
                if (_Default_chart_color != null)
                {
                    if (_Stop_Delete_Default_chart_color_Execution)
                    {
                        _Stop_Delete_Default_chart_color_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Default_chart_color(i_Params_Delete_Default_chart_color.DEFAULT_CHART_COLOR_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Default_chart_color", i_Params_Delete_Default_chart_color_json, false);
            }
        }
        #endregion
        #region Delete_Districtnex_module
        public void Delete_Districtnex_module(Params_Delete_Districtnex_module i_Params_Delete_Districtnex_module)
        {
            var i_Params_Delete_Districtnex_module_json = JsonConvert.SerializeObject(i_Params_Delete_Districtnex_module);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Districtnex_module", i_Params_Delete_Districtnex_module_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID oParams_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID = new Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID
                {
                    DISTRICTNEX_MODULE_ID = i_Params_Delete_Districtnex_module.DISTRICTNEX_MODULE_ID
                };
                _Districtnex_module = Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID(oParams_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID);
                if (_Districtnex_module != null)
                {
                    if (_Stop_Delete_Districtnex_module_Execution)
                    {
                        _Stop_Delete_Districtnex_module_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Districtnex_module(i_Params_Delete_Districtnex_module.DISTRICTNEX_MODULE_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Districtnex_module", i_Params_Delete_Districtnex_module_json, false);
            }
        }
        #endregion
        #region Delete_Build_version_log_By_OWNER_ID
        public void Delete_Build_version_log_By_OWNER_ID(Params_Delete_Build_version_log_By_OWNER_ID i_Params_Delete_Build_version_log_By_OWNER_ID)
        {
            var i_Params_Delete_Build_version_log_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Build_version_log_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Build_version_log_By_OWNER_ID", i_Params_Delete_Build_version_log_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Build_version_log_By_OWNER_ID oParams_Get_Build_version_log_By_OWNER_ID = new Params_Get_Build_version_log_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Build_version_log_By_OWNER_ID.OWNER_ID
                };
                _List_Build_version_log = Get_Build_version_log_By_OWNER_ID(oParams_Get_Build_version_log_By_OWNER_ID);
                if (_List_Build_version_log != null && _List_Build_version_log.Count > 0)
                {
                    if (_Stop_Delete_Build_version_log_Execution)
                    {
                        _Stop_Delete_Build_version_log_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Build_version_log_By_OWNER_ID(i_Params_Delete_Build_version_log_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Build_version_log_By_OWNER_ID", i_Params_Delete_Build_version_log_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Build_version_log_By_BUILD_VERSION_ID
        public void Delete_Build_version_log_By_BUILD_VERSION_ID(Params_Delete_Build_version_log_By_BUILD_VERSION_ID i_Params_Delete_Build_version_log_By_BUILD_VERSION_ID)
        {
            var i_Params_Delete_Build_version_log_By_BUILD_VERSION_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Build_version_log_By_BUILD_VERSION_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Build_version_log_By_BUILD_VERSION_ID", i_Params_Delete_Build_version_log_By_BUILD_VERSION_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Build_version_log_By_BUILD_VERSION_ID oParams_Get_Build_version_log_By_BUILD_VERSION_ID = new Params_Get_Build_version_log_By_BUILD_VERSION_ID
                {
                    BUILD_VERSION_ID = i_Params_Delete_Build_version_log_By_BUILD_VERSION_ID.BUILD_VERSION_ID
                };
                _List_Build_version_log = Get_Build_version_log_By_BUILD_VERSION_ID(oParams_Get_Build_version_log_By_BUILD_VERSION_ID);
                if (_List_Build_version_log != null && _List_Build_version_log.Count > 0)
                {
                    if (_Stop_Delete_Build_version_log_Execution)
                    {
                        _Stop_Delete_Build_version_log_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Build_version_log_By_BUILD_VERSION_ID(i_Params_Delete_Build_version_log_By_BUILD_VERSION_ID.BUILD_VERSION_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Build_version_log_By_BUILD_VERSION_ID", i_Params_Delete_Build_version_log_By_BUILD_VERSION_ID_json, false);
            }
        }
        #endregion
        #region Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID
        public void Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID(Params_Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID i_Params_Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID", i_Params_Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID oParams_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID = new Params_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID
                {
                    BUILD_LOG_TYPE_SETUP_ID = i_Params_Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID.BUILD_LOG_TYPE_SETUP_ID
                };
                _List_Build_version_log = Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID(oParams_Get_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID);
                if (_List_Build_version_log != null && _List_Build_version_log.Count > 0)
                {
                    if (_Stop_Delete_Build_version_log_Execution)
                    {
                        _Stop_Delete_Build_version_log_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID(i_Params_Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID.BUILD_LOG_TYPE_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID", i_Params_Delete_Build_version_log_By_BUILD_LOG_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Build_version_log_By_OWNER_ID_IS_DELETED
        public void Delete_Build_version_log_By_OWNER_ID_IS_DELETED(Params_Delete_Build_version_log_By_OWNER_ID_IS_DELETED i_Params_Delete_Build_version_log_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Build_version_log_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Build_version_log_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Build_version_log_By_OWNER_ID_IS_DELETED", i_Params_Delete_Build_version_log_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED oParams_Get_Build_version_log_By_OWNER_ID_IS_DELETED = new Params_Get_Build_version_log_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Build_version_log_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Build_version_log_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Build_version_log = Get_Build_version_log_By_OWNER_ID_IS_DELETED(oParams_Get_Build_version_log_By_OWNER_ID_IS_DELETED);
                if (_List_Build_version_log != null && _List_Build_version_log.Count > 0)
                {
                    if (_Stop_Delete_Build_version_log_Execution)
                    {
                        _Stop_Delete_Build_version_log_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Build_version_log_By_OWNER_ID_IS_DELETED(i_Params_Delete_Build_version_log_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Build_version_log_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Build_version_log_By_OWNER_ID_IS_DELETED", i_Params_Delete_Build_version_log_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Removed_extrusion_By_OWNER_ID
        public void Delete_Removed_extrusion_By_OWNER_ID(Params_Delete_Removed_extrusion_By_OWNER_ID i_Params_Delete_Removed_extrusion_By_OWNER_ID)
        {
            var i_Params_Delete_Removed_extrusion_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Removed_extrusion_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Removed_extrusion_By_OWNER_ID", i_Params_Delete_Removed_extrusion_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Removed_extrusion_By_OWNER_ID oParams_Get_Removed_extrusion_By_OWNER_ID = new Params_Get_Removed_extrusion_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Removed_extrusion_By_OWNER_ID.OWNER_ID
                };
                _List_Removed_extrusion = Get_Removed_extrusion_By_OWNER_ID(oParams_Get_Removed_extrusion_By_OWNER_ID);
                if (_List_Removed_extrusion != null && _List_Removed_extrusion.Count > 0)
                {
                    if (_Stop_Delete_Removed_extrusion_Execution)
                    {
                        _Stop_Delete_Removed_extrusion_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Removed_extrusion_By_OWNER_ID(i_Params_Delete_Removed_extrusion_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Removed_extrusion_By_OWNER_ID", i_Params_Delete_Removed_extrusion_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Removed_extrusion_By_LEVEL_ID
        public void Delete_Removed_extrusion_By_LEVEL_ID(Params_Delete_Removed_extrusion_By_LEVEL_ID i_Params_Delete_Removed_extrusion_By_LEVEL_ID)
        {
            var i_Params_Delete_Removed_extrusion_By_LEVEL_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Removed_extrusion_By_LEVEL_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Removed_extrusion_By_LEVEL_ID", i_Params_Delete_Removed_extrusion_By_LEVEL_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Removed_extrusion_By_LEVEL_ID oParams_Get_Removed_extrusion_By_LEVEL_ID = new Params_Get_Removed_extrusion_By_LEVEL_ID
                {
                    LEVEL_ID = i_Params_Delete_Removed_extrusion_By_LEVEL_ID.LEVEL_ID
                };
                _List_Removed_extrusion = Get_Removed_extrusion_By_LEVEL_ID(oParams_Get_Removed_extrusion_By_LEVEL_ID);
                if (_List_Removed_extrusion != null && _List_Removed_extrusion.Count > 0)
                {
                    if (_Stop_Delete_Removed_extrusion_Execution)
                    {
                        _Stop_Delete_Removed_extrusion_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Removed_extrusion_By_LEVEL_ID(i_Params_Delete_Removed_extrusion_By_LEVEL_ID.LEVEL_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Removed_extrusion_By_LEVEL_ID", i_Params_Delete_Removed_extrusion_By_LEVEL_ID_json, false);
            }
        }
        #endregion
        #region Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID
        public void Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID(Params_Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID i_Params_Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID)
        {
            var i_Params_Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID", i_Params_Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID oParams_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID = new Params_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID
                {
                    DATA_LEVEL_SETUP_ID = i_Params_Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID
                };
                _List_Removed_extrusion = Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID(oParams_Get_Removed_extrusion_By_DATA_LEVEL_SETUP_ID);
                if (_List_Removed_extrusion != null && _List_Removed_extrusion.Count > 0)
                {
                    if (_Stop_Delete_Removed_extrusion_Execution)
                    {
                        _Stop_Delete_Removed_extrusion_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID(i_Params_Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID", i_Params_Delete_Removed_extrusion_By_DATA_LEVEL_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED
        public void Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED(Params_Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED i_Params_Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED", i_Params_Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED oParams_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED = new Params_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Removed_extrusion = Get_Removed_extrusion_By_OWNER_ID_IS_DELETED(oParams_Get_Removed_extrusion_By_OWNER_ID_IS_DELETED);
                if (_List_Removed_extrusion != null && _List_Removed_extrusion.Count > 0)
                {
                    if (_Stop_Delete_Removed_extrusion_Execution)
                    {
                        _Stop_Delete_Removed_extrusion_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED(i_Params_Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED", i_Params_Delete_Removed_extrusion_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Alert_settings_By_OWNER_ID
        public void Delete_Alert_settings_By_OWNER_ID(Params_Delete_Alert_settings_By_OWNER_ID i_Params_Delete_Alert_settings_By_OWNER_ID)
        {
            var i_Params_Delete_Alert_settings_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Alert_settings_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Alert_settings_By_OWNER_ID", i_Params_Delete_Alert_settings_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Alert_settings_By_OWNER_ID oParams_Get_Alert_settings_By_OWNER_ID = new Params_Get_Alert_settings_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Alert_settings_By_OWNER_ID.OWNER_ID
                };
                _List_Alert_settings = Get_Alert_settings_By_OWNER_ID(oParams_Get_Alert_settings_By_OWNER_ID);
                if (_List_Alert_settings != null && _List_Alert_settings.Count > 0)
                {
                    if (_Stop_Delete_Alert_settings_Execution)
                    {
                        _Stop_Delete_Alert_settings_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Alert_settings_By_OWNER_ID(i_Params_Delete_Alert_settings_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Alert_settings_By_OWNER_ID", i_Params_Delete_Alert_settings_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Alert_settings_By_OPERATION_SETUP_ID
        public void Delete_Alert_settings_By_OPERATION_SETUP_ID(Params_Delete_Alert_settings_By_OPERATION_SETUP_ID i_Params_Delete_Alert_settings_By_OPERATION_SETUP_ID)
        {
            var i_Params_Delete_Alert_settings_By_OPERATION_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Alert_settings_By_OPERATION_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Alert_settings_By_OPERATION_SETUP_ID", i_Params_Delete_Alert_settings_By_OPERATION_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Alert_settings_By_OPERATION_SETUP_ID oParams_Get_Alert_settings_By_OPERATION_SETUP_ID = new Params_Get_Alert_settings_By_OPERATION_SETUP_ID
                {
                    OPERATION_SETUP_ID = i_Params_Delete_Alert_settings_By_OPERATION_SETUP_ID.OPERATION_SETUP_ID
                };
                _List_Alert_settings = Get_Alert_settings_By_OPERATION_SETUP_ID(oParams_Get_Alert_settings_By_OPERATION_SETUP_ID);
                if (_List_Alert_settings != null && _List_Alert_settings.Count > 0)
                {
                    if (_Stop_Delete_Alert_settings_Execution)
                    {
                        _Stop_Delete_Alert_settings_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Alert_settings_By_OPERATION_SETUP_ID(i_Params_Delete_Alert_settings_By_OPERATION_SETUP_ID.OPERATION_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Alert_settings_By_OPERATION_SETUP_ID", i_Params_Delete_Alert_settings_By_OPERATION_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Alert_settings_By_USER_ID
        public void Delete_Alert_settings_By_USER_ID(Params_Delete_Alert_settings_By_USER_ID i_Params_Delete_Alert_settings_By_USER_ID)
        {
            var i_Params_Delete_Alert_settings_By_USER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Alert_settings_By_USER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Alert_settings_By_USER_ID", i_Params_Delete_Alert_settings_By_USER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Alert_settings_By_USER_ID oParams_Get_Alert_settings_By_USER_ID = new Params_Get_Alert_settings_By_USER_ID
                {
                    USER_ID = i_Params_Delete_Alert_settings_By_USER_ID.USER_ID
                };
                _List_Alert_settings = Get_Alert_settings_By_USER_ID(oParams_Get_Alert_settings_By_USER_ID);
                if (_List_Alert_settings != null && _List_Alert_settings.Count > 0)
                {
                    if (_Stop_Delete_Alert_settings_Execution)
                    {
                        _Stop_Delete_Alert_settings_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Alert_settings_By_USER_ID(i_Params_Delete_Alert_settings_By_USER_ID.USER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Alert_settings_By_USER_ID", i_Params_Delete_Alert_settings_By_USER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Alert_settings_By_OWNER_ID_IS_DELETED
        public void Delete_Alert_settings_By_OWNER_ID_IS_DELETED(Params_Delete_Alert_settings_By_OWNER_ID_IS_DELETED i_Params_Delete_Alert_settings_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Alert_settings_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Alert_settings_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Alert_settings_By_OWNER_ID_IS_DELETED", i_Params_Delete_Alert_settings_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED oParams_Get_Alert_settings_By_OWNER_ID_IS_DELETED = new Params_Get_Alert_settings_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Alert_settings_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Alert_settings_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Alert_settings = Get_Alert_settings_By_OWNER_ID_IS_DELETED(oParams_Get_Alert_settings_By_OWNER_ID_IS_DELETED);
                if (_List_Alert_settings != null && _List_Alert_settings.Count > 0)
                {
                    if (_Stop_Delete_Alert_settings_Execution)
                    {
                        _Stop_Delete_Alert_settings_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Alert_settings_By_OWNER_ID_IS_DELETED(i_Params_Delete_Alert_settings_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Alert_settings_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Alert_settings_By_OWNER_ID_IS_DELETED", i_Params_Delete_Alert_settings_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Alert_settings_By_KPI_ID
        public void Delete_Alert_settings_By_KPI_ID(Params_Delete_Alert_settings_By_KPI_ID i_Params_Delete_Alert_settings_By_KPI_ID)
        {
            var i_Params_Delete_Alert_settings_By_KPI_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Alert_settings_By_KPI_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Alert_settings_By_KPI_ID", i_Params_Delete_Alert_settings_By_KPI_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Alert_settings_By_KPI_ID oParams_Get_Alert_settings_By_KPI_ID = new Params_Get_Alert_settings_By_KPI_ID
                {
                    KPI_ID = i_Params_Delete_Alert_settings_By_KPI_ID.KPI_ID
                };
                _List_Alert_settings = Get_Alert_settings_By_KPI_ID(oParams_Get_Alert_settings_By_KPI_ID);
                if (_List_Alert_settings != null && _List_Alert_settings.Count > 0)
                {
                    if (_Stop_Delete_Alert_settings_Execution)
                    {
                        _Stop_Delete_Alert_settings_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Alert_settings_By_KPI_ID(i_Params_Delete_Alert_settings_By_KPI_ID.KPI_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Alert_settings_By_KPI_ID", i_Params_Delete_Alert_settings_By_KPI_ID_json, false);
            }
        }
        #endregion
        #region Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID
        public void Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID(Params_Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID i_Params_Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID", i_Params_Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID oParams_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID = new Params_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID
                {
                    VALUE_TYPE_SETUP_ID = i_Params_Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID.VALUE_TYPE_SETUP_ID
                };
                _List_Alert_settings = Get_Alert_settings_By_VALUE_TYPE_SETUP_ID(oParams_Get_Alert_settings_By_VALUE_TYPE_SETUP_ID);
                if (_List_Alert_settings != null && _List_Alert_settings.Count > 0)
                {
                    if (_Stop_Delete_Alert_settings_Execution)
                    {
                        _Stop_Delete_Alert_settings_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID(i_Params_Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID.VALUE_TYPE_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID", i_Params_Delete_Alert_settings_By_VALUE_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Default_settings_image_By_OWNER_ID
        public void Delete_Default_settings_image_By_OWNER_ID(Params_Delete_Default_settings_image_By_OWNER_ID i_Params_Delete_Default_settings_image_By_OWNER_ID)
        {
            var i_Params_Delete_Default_settings_image_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Default_settings_image_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Default_settings_image_By_OWNER_ID", i_Params_Delete_Default_settings_image_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Default_settings_image_By_OWNER_ID oParams_Get_Default_settings_image_By_OWNER_ID = new Params_Get_Default_settings_image_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Default_settings_image_By_OWNER_ID.OWNER_ID
                };
                _List_Default_settings_image = Get_Default_settings_image_By_OWNER_ID(oParams_Get_Default_settings_image_By_OWNER_ID);
                if (_List_Default_settings_image != null && _List_Default_settings_image.Count > 0)
                {
                    if (_Stop_Delete_Default_settings_image_Execution)
                    {
                        _Stop_Delete_Default_settings_image_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Default_settings_image_By_OWNER_ID(i_Params_Delete_Default_settings_image_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Default_settings_image_By_OWNER_ID", i_Params_Delete_Default_settings_image_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID
        public void Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID(Params_Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID i_Params_Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID)
        {
            var i_Params_Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID", i_Params_Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID oParams_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID = new Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID
                {
                    DEFAULT_SETTINGS_ID = i_Params_Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID.DEFAULT_SETTINGS_ID
                };
                _List_Default_settings_image = Get_Default_settings_image_By_DEFAULT_SETTINGS_ID(oParams_Get_Default_settings_image_By_DEFAULT_SETTINGS_ID);
                if (_List_Default_settings_image != null && _List_Default_settings_image.Count > 0)
                {
                    if (_Stop_Delete_Default_settings_image_Execution)
                    {
                        _Stop_Delete_Default_settings_image_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID(i_Params_Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID.DEFAULT_SETTINGS_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID", i_Params_Delete_Default_settings_image_By_DEFAULT_SETTINGS_ID_json, false);
            }
        }
        #endregion
        #region Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID
        public void Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID(Params_Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID i_Params_Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID)
        {
            var i_Params_Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID", i_Params_Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID oParams_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID = new Params_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID
                {
                    IMAGE_TYPE_SETUP_ID = i_Params_Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID.IMAGE_TYPE_SETUP_ID
                };
                _List_Default_settings_image = Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID(oParams_Get_Default_settings_image_By_IMAGE_TYPE_SETUP_ID);
                if (_List_Default_settings_image != null && _List_Default_settings_image.Count > 0)
                {
                    if (_Stop_Delete_Default_settings_image_Execution)
                    {
                        _Stop_Delete_Default_settings_image_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID(i_Params_Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID.IMAGE_TYPE_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID", i_Params_Delete_Default_settings_image_By_IMAGE_TYPE_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Default_settings_image_By_OWNER_ID_IS_DELETED
        public void Delete_Default_settings_image_By_OWNER_ID_IS_DELETED(Params_Delete_Default_settings_image_By_OWNER_ID_IS_DELETED i_Params_Delete_Default_settings_image_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Default_settings_image_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Default_settings_image_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Default_settings_image_By_OWNER_ID_IS_DELETED", i_Params_Delete_Default_settings_image_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED oParams_Get_Default_settings_image_By_OWNER_ID_IS_DELETED = new Params_Get_Default_settings_image_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Default_settings_image_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Default_settings_image_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Default_settings_image = Get_Default_settings_image_By_OWNER_ID_IS_DELETED(oParams_Get_Default_settings_image_By_OWNER_ID_IS_DELETED);
                if (_List_Default_settings_image != null && _List_Default_settings_image.Count > 0)
                {
                    if (_Stop_Delete_Default_settings_image_Execution)
                    {
                        _Stop_Delete_Default_settings_image_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Default_settings_image_By_OWNER_ID_IS_DELETED(i_Params_Delete_Default_settings_image_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Default_settings_image_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Default_settings_image_By_OWNER_ID_IS_DELETED", i_Params_Delete_Default_settings_image_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Owner_By_IS_DELETED
        public void Delete_Owner_By_IS_DELETED(Params_Delete_Owner_By_IS_DELETED i_Params_Delete_Owner_By_IS_DELETED)
        {
            var i_Params_Delete_Owner_By_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Owner_By_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Owner_By_IS_DELETED", i_Params_Delete_Owner_By_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Owner_By_IS_DELETED oParams_Get_Owner_By_IS_DELETED = new Params_Get_Owner_By_IS_DELETED
                {
                    IS_DELETED = i_Params_Delete_Owner_By_IS_DELETED.IS_DELETED
                };
                _List_Owner = Get_Owner_By_IS_DELETED(oParams_Get_Owner_By_IS_DELETED);
                if (_List_Owner != null && _List_Owner.Count > 0)
                {
                    if (_Stop_Delete_Owner_Execution)
                    {
                        _Stop_Delete_Owner_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Owner_By_IS_DELETED(i_Params_Delete_Owner_By_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Owner_By_IS_DELETED", i_Params_Delete_Owner_By_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID
        public void Delete_Setup_category_By_OWNER_ID(Params_Delete_Setup_category_By_OWNER_ID i_Params_Delete_Setup_category_By_OWNER_ID)
        {
            var i_Params_Delete_Setup_category_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category_By_OWNER_ID", i_Params_Delete_Setup_category_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_OWNER_ID oParams_Get_Setup_category_By_OWNER_ID = new Params_Get_Setup_category_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Setup_category_By_OWNER_ID.OWNER_ID
                };
                _List_Setup_category = Get_Setup_category_By_OWNER_ID(oParams_Get_Setup_category_By_OWNER_ID);
                if (_List_Setup_category != null && _List_Setup_category.Count > 0)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category_By_OWNER_ID(i_Params_Delete_Setup_category_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category_By_OWNER_ID", i_Params_Delete_Setup_category_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_category_By_OWNER_ID_IS_DELETED(Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_OWNER_ID_IS_DELETED oParams_Get_Setup_category_By_OWNER_ID_IS_DELETED = new Params_Get_Setup_category_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Setup_category = Get_Setup_category_By_OWNER_ID_IS_DELETED(oParams_Get_Setup_category_By_OWNER_ID_IS_DELETED);
                if (_List_Setup_category != null && _List_Setup_category.Count > 0)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category_By_OWNER_ID_IS_DELETED(i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_category_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
        public void Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID)
        {
            var i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID oParams_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID = new Params_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID
                {
                    SETUP_CATEGORY_NAME = i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME,
                    OWNER_ID = i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID
                };
                _Setup_category = Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(oParams_Get_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID);
                if (_Setup_category != null)
                {
                    if (_Stop_Delete_Setup_category_Execution)
                    {
                        _Stop_Delete_Setup_category_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID(i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.SETUP_CATEGORY_NAME, i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID", i_Params_Delete_Setup_category_By_SETUP_CATEGORY_NAME_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID_IS_DELETED
        public void Delete_Setup_By_OWNER_ID_IS_DELETED(Params_Delete_Setup_By_OWNER_ID_IS_DELETED i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_OWNER_ID_IS_DELETED oParams_Get_Setup_By_OWNER_ID_IS_DELETED = new Params_Get_Setup_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Setup = Get_Setup_By_OWNER_ID_IS_DELETED(oParams_Get_Setup_By_OWNER_ID_IS_DELETED);
                if (_List_Setup != null && _List_Setup.Count > 0)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_OWNER_ID_IS_DELETED(i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_OWNER_ID_IS_DELETED", i_Params_Delete_Setup_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID
        public void Delete_Setup_By_SETUP_CATEGORY_ID(Params_Delete_Setup_By_SETUP_CATEGORY_ID i_Params_Delete_Setup_By_SETUP_CATEGORY_ID)
        {
            var i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_SETUP_CATEGORY_ID oParams_Get_Setup_By_SETUP_CATEGORY_ID = new Params_Get_Setup_By_SETUP_CATEGORY_ID
                {
                    SETUP_CATEGORY_ID = i_Params_Delete_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID
                };
                _List_Setup = Get_Setup_By_SETUP_CATEGORY_ID(oParams_Get_Setup_By_SETUP_CATEGORY_ID);
                if (_List_Setup != null && _List_Setup.Count > 0)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_SETUP_CATEGORY_ID(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID.SETUP_CATEGORY_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_SETUP_CATEGORY_ID_VALUE
        public void Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE)
        {
            var i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE oParams_Get_Setup_By_SETUP_CATEGORY_ID_VALUE = new Params_Get_Setup_By_SETUP_CATEGORY_ID_VALUE
                {
                    SETUP_CATEGORY_ID = i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID,
                    VALUE = i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE
                };
                _Setup = Get_Setup_By_SETUP_CATEGORY_ID_VALUE(oParams_Get_Setup_By_SETUP_CATEGORY_ID_VALUE);
                if (_Setup != null)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_SETUP_CATEGORY_ID_VALUE(i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.SETUP_CATEGORY_ID, i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE.VALUE);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_SETUP_CATEGORY_ID_VALUE", i_Params_Delete_Setup_By_SETUP_CATEGORY_ID_VALUE_json, false);
            }
        }
        #endregion
        #region Delete_Setup_By_OWNER_ID
        public void Delete_Setup_By_OWNER_ID(Params_Delete_Setup_By_OWNER_ID i_Params_Delete_Setup_By_OWNER_ID)
        {
            var i_Params_Delete_Setup_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Setup_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Setup_By_OWNER_ID", i_Params_Delete_Setup_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Setup_By_OWNER_ID oParams_Get_Setup_By_OWNER_ID = new Params_Get_Setup_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Setup_By_OWNER_ID.OWNER_ID
                };
                _List_Setup = Get_Setup_By_OWNER_ID(oParams_Get_Setup_By_OWNER_ID);
                if (_List_Setup != null && _List_Setup.Count > 0)
                {
                    if (_Stop_Delete_Setup_Execution)
                    {
                        _Stop_Delete_Setup_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Setup_By_OWNER_ID(i_Params_Delete_Setup_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Setup_By_OWNER_ID", i_Params_Delete_Setup_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Build_version_By_OWNER_ID
        public void Delete_Build_version_By_OWNER_ID(Params_Delete_Build_version_By_OWNER_ID i_Params_Delete_Build_version_By_OWNER_ID)
        {
            var i_Params_Delete_Build_version_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Build_version_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Build_version_By_OWNER_ID", i_Params_Delete_Build_version_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Build_version_By_OWNER_ID oParams_Get_Build_version_By_OWNER_ID = new Params_Get_Build_version_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Build_version_By_OWNER_ID.OWNER_ID
                };
                _List_Build_version = Get_Build_version_By_OWNER_ID(oParams_Get_Build_version_By_OWNER_ID);
                if (_List_Build_version != null && _List_Build_version.Count > 0)
                {
                    if (_Stop_Delete_Build_version_Execution)
                    {
                        _Stop_Delete_Build_version_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Build_version_By_OWNER_ID(i_Params_Delete_Build_version_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Build_version_By_OWNER_ID", i_Params_Delete_Build_version_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Build_version_By_APPLICATION_NAME_SETUP_ID
        public void Delete_Build_version_By_APPLICATION_NAME_SETUP_ID(Params_Delete_Build_version_By_APPLICATION_NAME_SETUP_ID i_Params_Delete_Build_version_By_APPLICATION_NAME_SETUP_ID)
        {
            var i_Params_Delete_Build_version_By_APPLICATION_NAME_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Build_version_By_APPLICATION_NAME_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Build_version_By_APPLICATION_NAME_SETUP_ID", i_Params_Delete_Build_version_By_APPLICATION_NAME_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID oParams_Get_Build_version_By_APPLICATION_NAME_SETUP_ID = new Params_Get_Build_version_By_APPLICATION_NAME_SETUP_ID
                {
                    APPLICATION_NAME_SETUP_ID = i_Params_Delete_Build_version_By_APPLICATION_NAME_SETUP_ID.APPLICATION_NAME_SETUP_ID
                };
                _List_Build_version = Get_Build_version_By_APPLICATION_NAME_SETUP_ID(oParams_Get_Build_version_By_APPLICATION_NAME_SETUP_ID);
                if (_List_Build_version != null && _List_Build_version.Count > 0)
                {
                    if (_Stop_Delete_Build_version_Execution)
                    {
                        _Stop_Delete_Build_version_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Build_version_By_APPLICATION_NAME_SETUP_ID(i_Params_Delete_Build_version_By_APPLICATION_NAME_SETUP_ID.APPLICATION_NAME_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Build_version_By_APPLICATION_NAME_SETUP_ID", i_Params_Delete_Build_version_By_APPLICATION_NAME_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Build_version_By_OWNER_ID_IS_DELETED
        public void Delete_Build_version_By_OWNER_ID_IS_DELETED(Params_Delete_Build_version_By_OWNER_ID_IS_DELETED i_Params_Delete_Build_version_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Build_version_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Build_version_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Build_version_By_OWNER_ID_IS_DELETED", i_Params_Delete_Build_version_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Build_version_By_OWNER_ID_IS_DELETED oParams_Get_Build_version_By_OWNER_ID_IS_DELETED = new Params_Get_Build_version_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Build_version_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Build_version_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Build_version = Get_Build_version_By_OWNER_ID_IS_DELETED(oParams_Get_Build_version_By_OWNER_ID_IS_DELETED);
                if (_List_Build_version != null && _List_Build_version.Count > 0)
                {
                    if (_Stop_Delete_Build_version_Execution)
                    {
                        _Stop_Delete_Build_version_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Build_version_By_OWNER_ID_IS_DELETED(i_Params_Delete_Build_version_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Build_version_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Build_version_By_OWNER_ID_IS_DELETED", i_Params_Delete_Build_version_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID
        public void Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID(Params_Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID i_Params_Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID)
        {
            var i_Params_Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID", i_Params_Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID oParams_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID = new Params_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID
                {
                    IS_CURRENT = i_Params_Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID.IS_CURRENT,
                    APPLICATION_NAME_SETUP_ID = i_Params_Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID.APPLICATION_NAME_SETUP_ID
                };
                _List_Build_version = Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID(oParams_Get_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID);
                if (_List_Build_version != null && _List_Build_version.Count > 0)
                {
                    if (_Stop_Delete_Build_version_Execution)
                    {
                        _Stop_Delete_Build_version_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID(i_Params_Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID.IS_CURRENT, i_Params_Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID.APPLICATION_NAME_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID", i_Params_Delete_Build_version_By_IS_CURRENT_APPLICATION_NAME_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Default_settings_By_OWNER_ID_IS_DELETED
        public void Delete_Default_settings_By_OWNER_ID_IS_DELETED(Params_Delete_Default_settings_By_OWNER_ID_IS_DELETED i_Params_Delete_Default_settings_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Default_settings_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Default_settings_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Default_settings_By_OWNER_ID_IS_DELETED", i_Params_Delete_Default_settings_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Default_settings_By_OWNER_ID_IS_DELETED oParams_Get_Default_settings_By_OWNER_ID_IS_DELETED = new Params_Get_Default_settings_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Default_settings_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Default_settings_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Default_settings = Get_Default_settings_By_OWNER_ID_IS_DELETED(oParams_Get_Default_settings_By_OWNER_ID_IS_DELETED);
                if (_List_Default_settings != null && _List_Default_settings.Count > 0)
                {
                    if (_Stop_Delete_Default_settings_Execution)
                    {
                        _Stop_Delete_Default_settings_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Default_settings_By_OWNER_ID_IS_DELETED(i_Params_Delete_Default_settings_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Default_settings_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Default_settings_By_OWNER_ID_IS_DELETED", i_Params_Delete_Default_settings_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Default_settings_By_OWNER_ID
        public void Delete_Default_settings_By_OWNER_ID(Params_Delete_Default_settings_By_OWNER_ID i_Params_Delete_Default_settings_By_OWNER_ID)
        {
            var i_Params_Delete_Default_settings_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Default_settings_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Default_settings_By_OWNER_ID", i_Params_Delete_Default_settings_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Default_settings_By_OWNER_ID oParams_Get_Default_settings_By_OWNER_ID = new Params_Get_Default_settings_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Default_settings_By_OWNER_ID.OWNER_ID
                };
                _List_Default_settings = Get_Default_settings_By_OWNER_ID(oParams_Get_Default_settings_By_OWNER_ID);
                if (_List_Default_settings != null && _List_Default_settings.Count > 0)
                {
                    if (_Stop_Delete_Default_settings_Execution)
                    {
                        _Stop_Delete_Default_settings_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Default_settings_By_OWNER_ID(i_Params_Delete_Default_settings_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Default_settings_By_OWNER_ID", i_Params_Delete_Default_settings_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Default_settings_By_TELUS_REQUEST_ID
        public void Delete_Default_settings_By_TELUS_REQUEST_ID(Params_Delete_Default_settings_By_TELUS_REQUEST_ID i_Params_Delete_Default_settings_By_TELUS_REQUEST_ID)
        {
            var i_Params_Delete_Default_settings_By_TELUS_REQUEST_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Default_settings_By_TELUS_REQUEST_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Default_settings_By_TELUS_REQUEST_ID", i_Params_Delete_Default_settings_By_TELUS_REQUEST_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Default_settings_By_TELUS_REQUEST_ID oParams_Get_Default_settings_By_TELUS_REQUEST_ID = new Params_Get_Default_settings_By_TELUS_REQUEST_ID
                {
                    TELUS_REQUEST_ID = i_Params_Delete_Default_settings_By_TELUS_REQUEST_ID.TELUS_REQUEST_ID
                };
                _List_Default_settings = Get_Default_settings_By_TELUS_REQUEST_ID(oParams_Get_Default_settings_By_TELUS_REQUEST_ID);
                if (_List_Default_settings != null && _List_Default_settings.Count > 0)
                {
                    if (_Stop_Delete_Default_settings_Execution)
                    {
                        _Stop_Delete_Default_settings_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Default_settings_By_TELUS_REQUEST_ID(i_Params_Delete_Default_settings_By_TELUS_REQUEST_ID.TELUS_REQUEST_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Default_settings_By_TELUS_REQUEST_ID", i_Params_Delete_Default_settings_By_TELUS_REQUEST_ID_json, false);
            }
        }
        #endregion
        #region Delete_Default_chart_color_By_OWNER_ID
        public void Delete_Default_chart_color_By_OWNER_ID(Params_Delete_Default_chart_color_By_OWNER_ID i_Params_Delete_Default_chart_color_By_OWNER_ID)
        {
            var i_Params_Delete_Default_chart_color_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Default_chart_color_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Default_chart_color_By_OWNER_ID", i_Params_Delete_Default_chart_color_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Default_chart_color_By_OWNER_ID oParams_Get_Default_chart_color_By_OWNER_ID = new Params_Get_Default_chart_color_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Default_chart_color_By_OWNER_ID.OWNER_ID
                };
                _List_Default_chart_color = Get_Default_chart_color_By_OWNER_ID(oParams_Get_Default_chart_color_By_OWNER_ID);
                if (_List_Default_chart_color != null && _List_Default_chart_color.Count > 0)
                {
                    if (_Stop_Delete_Default_chart_color_Execution)
                    {
                        _Stop_Delete_Default_chart_color_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Default_chart_color_By_OWNER_ID(i_Params_Delete_Default_chart_color_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Default_chart_color_By_OWNER_ID", i_Params_Delete_Default_chart_color_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID
        public void Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID(Params_Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID i_Params_Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID)
        {
            var i_Params_Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID", i_Params_Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID oParams_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID = new Params_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID
                {
                    DEFAULT_SETTINGS_ID = i_Params_Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID.DEFAULT_SETTINGS_ID
                };
                _List_Default_chart_color = Get_Default_chart_color_By_DEFAULT_SETTINGS_ID(oParams_Get_Default_chart_color_By_DEFAULT_SETTINGS_ID);
                if (_List_Default_chart_color != null && _List_Default_chart_color.Count > 0)
                {
                    if (_Stop_Delete_Default_chart_color_Execution)
                    {
                        _Stop_Delete_Default_chart_color_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID(i_Params_Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID.DEFAULT_SETTINGS_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID", i_Params_Delete_Default_chart_color_By_DEFAULT_SETTINGS_ID_json, false);
            }
        }
        #endregion
        #region Delete_Default_chart_color_By_OWNER_ID_IS_DELETED
        public void Delete_Default_chart_color_By_OWNER_ID_IS_DELETED(Params_Delete_Default_chart_color_By_OWNER_ID_IS_DELETED i_Params_Delete_Default_chart_color_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Default_chart_color_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Default_chart_color_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Default_chart_color_By_OWNER_ID_IS_DELETED", i_Params_Delete_Default_chart_color_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED oParams_Get_Default_chart_color_By_OWNER_ID_IS_DELETED = new Params_Get_Default_chart_color_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Default_chart_color_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Default_chart_color_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Default_chart_color = Get_Default_chart_color_By_OWNER_ID_IS_DELETED(oParams_Get_Default_chart_color_By_OWNER_ID_IS_DELETED);
                if (_List_Default_chart_color != null && _List_Default_chart_color.Count > 0)
                {
                    if (_Stop_Delete_Default_chart_color_Execution)
                    {
                        _Stop_Delete_Default_chart_color_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Default_chart_color_By_OWNER_ID_IS_DELETED(i_Params_Delete_Default_chart_color_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Default_chart_color_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Default_chart_color_By_OWNER_ID_IS_DELETED", i_Params_Delete_Default_chart_color_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID
        public void Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID(Params_Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID i_Params_Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID)
        {
            var i_Params_Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID", i_Params_Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID oParams_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID = new Params_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID
                {
                    DATA_LEVEL_SETUP_ID = i_Params_Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID
                };
                _List_Default_chart_color = Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID(oParams_Get_Default_chart_color_By_DATA_LEVEL_SETUP_ID);
                if (_List_Default_chart_color != null && _List_Default_chart_color.Count > 0)
                {
                    if (_Stop_Delete_Default_chart_color_Execution)
                    {
                        _Stop_Delete_Default_chart_color_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID(i_Params_Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID.DATA_LEVEL_SETUP_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID", i_Params_Delete_Default_chart_color_By_DATA_LEVEL_SETUP_ID_json, false);
            }
        }
        #endregion
        #region Delete_Districtnex_module_By_OWNER_ID
        public void Delete_Districtnex_module_By_OWNER_ID(Params_Delete_Districtnex_module_By_OWNER_ID i_Params_Delete_Districtnex_module_By_OWNER_ID)
        {
            var i_Params_Delete_Districtnex_module_By_OWNER_ID_json = JsonConvert.SerializeObject(i_Params_Delete_Districtnex_module_By_OWNER_ID);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Districtnex_module_By_OWNER_ID", i_Params_Delete_Districtnex_module_By_OWNER_ID_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Districtnex_module_By_OWNER_ID oParams_Get_Districtnex_module_By_OWNER_ID = new Params_Get_Districtnex_module_By_OWNER_ID
                {
                    OWNER_ID = i_Params_Delete_Districtnex_module_By_OWNER_ID.OWNER_ID
                };
                _List_Districtnex_module = Get_Districtnex_module_By_OWNER_ID(oParams_Get_Districtnex_module_By_OWNER_ID);
                if (_List_Districtnex_module != null && _List_Districtnex_module.Count > 0)
                {
                    if (_Stop_Delete_Districtnex_module_Execution)
                    {
                        _Stop_Delete_Districtnex_module_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Districtnex_module_By_OWNER_ID(i_Params_Delete_Districtnex_module_By_OWNER_ID.OWNER_ID);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Districtnex_module_By_OWNER_ID", i_Params_Delete_Districtnex_module_By_OWNER_ID_json, false);
            }
        }
        #endregion
        #region Delete_Districtnex_module_By_OWNER_ID_IS_DELETED
        public void Delete_Districtnex_module_By_OWNER_ID_IS_DELETED(Params_Delete_Districtnex_module_By_OWNER_ID_IS_DELETED i_Params_Delete_Districtnex_module_By_OWNER_ID_IS_DELETED)
        {
            var i_Params_Delete_Districtnex_module_By_OWNER_ID_IS_DELETED_json = JsonConvert.SerializeObject(i_Params_Delete_Districtnex_module_By_OWNER_ID_IS_DELETED);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Delete_Districtnex_module_By_OWNER_ID_IS_DELETED", i_Params_Delete_Districtnex_module_By_OWNER_ID_IS_DELETED_json, false);
            }
            #region Body Section.
            try
            {
                Params_Get_Districtnex_module_By_OWNER_ID_IS_DELETED oParams_Get_Districtnex_module_By_OWNER_ID_IS_DELETED = new Params_Get_Districtnex_module_By_OWNER_ID_IS_DELETED
                {
                    OWNER_ID = i_Params_Delete_Districtnex_module_By_OWNER_ID_IS_DELETED.OWNER_ID,
                    IS_DELETED = i_Params_Delete_Districtnex_module_By_OWNER_ID_IS_DELETED.IS_DELETED
                };
                _List_Districtnex_module = Get_Districtnex_module_By_OWNER_ID_IS_DELETED(oParams_Get_Districtnex_module_By_OWNER_ID_IS_DELETED);
                if (_List_Districtnex_module != null && _List_Districtnex_module.Count > 0)
                {
                    if (_Stop_Delete_Districtnex_module_Execution)
                    {
                        _Stop_Delete_Districtnex_module_Execution = false;
                        return;
                    }
                    _AppContext.Delete_Districtnex_module_By_OWNER_ID_IS_DELETED(i_Params_Delete_Districtnex_module_By_OWNER_ID_IS_DELETED.OWNER_ID, i_Params_Delete_Districtnex_module_By_OWNER_ID_IS_DELETED.IS_DELETED);
                }
            }
            catch (BLC_Exception BLCex)
            {
                throw new BLC_Exception(BLCex.Message);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("The DELETE statement conflicted with the REFERENCE constraint"))
                {
                    throw new BLC_Exception("Cannot be Deleted Because of Related Records in Other Tables");
                }
                else
                {
                    throw new Exception(ex.Message);
                }
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Delete_Districtnex_module_By_OWNER_ID_IS_DELETED", i_Params_Delete_Districtnex_module_By_OWNER_ID_IS_DELETED_json, false);
            }
        }
        #endregion
        #region Edit_Build_version_log
        public void Edit_Build_version_log(Build_version_log i_Build_version_log)
        {
            var i_Build_version_log_json = JsonConvert.SerializeObject(i_Build_version_log);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Build_version_log.BUILD_VERSION_LOG_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Build_version_log", i_Build_version_log_json, false);
            }
            #region Body Section.
            if (i_Build_version_log.BUILD_VERSION_LOG_ID == null || i_Build_version_log.BUILD_VERSION_LOG_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Build_version_log");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Build_version_log.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Build_version_log.IS_DELETED = false;
            }
            else
            {
                _Build_version_log = Get_Build_version_log_By_BUILD_VERSION_LOG_ID(new Params_Get_Build_version_log_By_BUILD_VERSION_LOG_ID
                {
                    BUILD_VERSION_LOG_ID = i_Build_version_log.BUILD_VERSION_LOG_ID
                });
            }
            i_Build_version_log.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Build_version_log.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Build_version_log.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Build_version_log_Execution)
            {
                _Stop_Edit_Build_version_log_Execution = false;
                return;
            }
            i_Build_version_log.BUILD_VERSION_LOG_ID = _AppContext.Edit_Build_version_log
            (
                i_Build_version_log.BUILD_VERSION_LOG_ID,
                i_Build_version_log.BUILD_VERSION_ID,
                i_Build_version_log.BUILD_LOG_TYPE_SETUP_ID,
                i_Build_version_log.DESCRIPTION,
                i_Build_version_log.ENTRY_USER_ID,
                i_Build_version_log.ENTRY_DATE,
                i_Build_version_log.LAST_UPDATE,
                i_Build_version_log.IS_DELETED,
                i_Build_version_log.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Build_version_log", i_Build_version_log_json, false);
            }
        }
        #endregion
        #region Edit_Removed_extrusion
        public void Edit_Removed_extrusion(Removed_extrusion i_Removed_extrusion)
        {
            var i_Removed_extrusion_json = JsonConvert.SerializeObject(i_Removed_extrusion);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Removed_extrusion.REMOVED_EXTRUSION_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Removed_extrusion", i_Removed_extrusion_json, false);
            }
            #region Body Section.
            if (i_Removed_extrusion.REMOVED_EXTRUSION_ID == null || i_Removed_extrusion.REMOVED_EXTRUSION_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Removed_extrusion");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Removed_extrusion.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Removed_extrusion.IS_DELETED = false;
            }
            else
            {
                _Removed_extrusion = Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID(new Params_Get_Removed_extrusion_By_REMOVED_EXTRUSION_ID
                {
                    REMOVED_EXTRUSION_ID = i_Removed_extrusion.REMOVED_EXTRUSION_ID
                });
            }
            i_Removed_extrusion.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Removed_extrusion.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Removed_extrusion.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Removed_extrusion_Execution)
            {
                _Stop_Edit_Removed_extrusion_Execution = false;
                return;
            }
            i_Removed_extrusion.REMOVED_EXTRUSION_ID = _AppContext.Edit_Removed_extrusion
            (
                i_Removed_extrusion.REMOVED_EXTRUSION_ID,
                i_Removed_extrusion.EXTRUSION_IDENTIFIER,
                i_Removed_extrusion.LEVEL_ID,
                i_Removed_extrusion.DATA_LEVEL_SETUP_ID,
                i_Removed_extrusion.ENTRY_USER_ID,
                i_Removed_extrusion.ENTRY_DATE,
                i_Removed_extrusion.LAST_UPDATE,
                i_Removed_extrusion.IS_DELETED,
                i_Removed_extrusion.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Removed_extrusion", i_Removed_extrusion_json, false);
            }
        }
        #endregion
        #region Edit_Alert_settings
        public void Edit_Alert_settings(Alert_settings i_Alert_settings)
        {
            var i_Alert_settings_json = JsonConvert.SerializeObject(i_Alert_settings);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Alert_settings.ALERT_SETTINGS_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Alert_settings", i_Alert_settings_json, false);
            }
            #region Body Section.
            if (i_Alert_settings.ALERT_SETTINGS_ID == null || i_Alert_settings.ALERT_SETTINGS_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Alert_settings");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Alert_settings.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Alert_settings.IS_DELETED = false;
            }
            else
            {
                _Alert_settings = Get_Alert_settings_By_ALERT_SETTINGS_ID(new Params_Get_Alert_settings_By_ALERT_SETTINGS_ID
                {
                    ALERT_SETTINGS_ID = i_Alert_settings.ALERT_SETTINGS_ID
                });
            }
            i_Alert_settings.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Alert_settings.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Alert_settings.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Alert_settings_Execution)
            {
                _Stop_Edit_Alert_settings_Execution = false;
                return;
            }
            i_Alert_settings.ALERT_SETTINGS_ID = _AppContext.Edit_Alert_settings
            (
                i_Alert_settings.ALERT_SETTINGS_ID,
                i_Alert_settings.USER_ID,
                i_Alert_settings.KPI_ID,
                i_Alert_settings.VALUE,
                i_Alert_settings.VALUE_TYPE_SETUP_ID,
                i_Alert_settings.OPERATION_SETUP_ID,
                i_Alert_settings.IS_ACTIVE,
                i_Alert_settings.ENTRY_USER_ID,
                i_Alert_settings.ENTRY_DATE,
                i_Alert_settings.LAST_UPDATE,
                i_Alert_settings.IS_DELETED,
                i_Alert_settings.OWNER_ID,
                i_Alert_settings.DESCRIPTION
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Alert_settings", i_Alert_settings_json, false);
            }
        }
        #endregion
        #region Edit_Default_settings_image
        public void Edit_Default_settings_image(Default_settings_image i_Default_settings_image)
        {
            var i_Default_settings_image_json = JsonConvert.SerializeObject(i_Default_settings_image);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Default_settings_image.DEFAULT_SETTINGS_IMAGE_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Default_settings_image", i_Default_settings_image_json, false);
            }
            #region Body Section.
            if (i_Default_settings_image.DEFAULT_SETTINGS_IMAGE_ID == null || i_Default_settings_image.DEFAULT_SETTINGS_IMAGE_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Default_settings_image");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Default_settings_image.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Default_settings_image.IS_DELETED = false;
            }
            else
            {
                _Default_settings_image = Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID(new Params_Get_Default_settings_image_By_DEFAULT_SETTINGS_IMAGE_ID
                {
                    DEFAULT_SETTINGS_IMAGE_ID = i_Default_settings_image.DEFAULT_SETTINGS_IMAGE_ID
                });
            }
            i_Default_settings_image.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Default_settings_image.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Default_settings_image.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Default_settings_image_Execution)
            {
                _Stop_Edit_Default_settings_image_Execution = false;
                return;
            }
            i_Default_settings_image.DEFAULT_SETTINGS_IMAGE_ID = _AppContext.Edit_Default_settings_image
            (
                i_Default_settings_image.DEFAULT_SETTINGS_IMAGE_ID,
                i_Default_settings_image.DEFAULT_SETTINGS_ID,
                i_Default_settings_image.IMAGE_NAME,
                i_Default_settings_image.IMAGE_EXTENSION,
                i_Default_settings_image.IMAGE_TYPE_SETUP_ID,
                i_Default_settings_image.ENTRY_USER_ID,
                i_Default_settings_image.ENTRY_DATE,
                i_Default_settings_image.LAST_UPDATE,
                i_Default_settings_image.IS_DELETED,
                i_Default_settings_image.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Default_settings_image", i_Default_settings_image_json, false);
            }
        }
        #endregion
        #region Edit_Owner
        public void Edit_Owner(Owner i_Owner)
        {
            var i_Owner_json = JsonConvert.SerializeObject(i_Owner);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Owner.OWNER_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Owner", i_Owner_json, false);
            }
            #region Body Section.
            if (i_Owner.OWNER_ID == null || i_Owner.OWNER_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Owner");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Owner.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Owner.IS_DELETED = false;
            }
            else
            {
                _Owner = Get_Owner_By_OWNER_ID(new Params_Get_Owner_By_OWNER_ID
                {
                    OWNER_ID = i_Owner.OWNER_ID
                });
            }
            i_Owner.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Owner.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Owner_Execution)
            {
                _Stop_Edit_Owner_Execution = false;
                return;
            }
            i_Owner.OWNER_ID = _AppContext.Edit_Owner
            (
                i_Owner.OWNER_ID,
                i_Owner.CODE,
                i_Owner.MAINTENANCE_DUE_DATE,
                i_Owner.ENTRY_DATE,
                i_Owner.DESCRIPTION,
                i_Owner.ENTRY_USER_ID,
                i_Owner.LAST_UPDATE,
                i_Owner.IS_DELETED
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Owner", i_Owner_json, false);
            }
        }
        #endregion
        #region Edit_Setup_category
        public void Edit_Setup_category(Setup_category i_Setup_category)
        {
            var i_Setup_category_json = JsonConvert.SerializeObject(i_Setup_category);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Setup_category.SETUP_CATEGORY_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup_category", i_Setup_category_json, false);
            }
            #region Body Section.
            if (i_Setup_category.SETUP_CATEGORY_ID == null || i_Setup_category.SETUP_CATEGORY_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Setup_category");
            }
            if (Check_Setup_category_Uniqueness_Violation(i_Setup_category))
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0000).Replace("%1", "Setup_category"));
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Setup_category.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Setup_category.IS_DELETED = false;
            }
            else
            {
                _Setup_category = Get_Setup_category_By_SETUP_CATEGORY_ID(new Params_Get_Setup_category_By_SETUP_CATEGORY_ID
                {
                    SETUP_CATEGORY_ID = i_Setup_category.SETUP_CATEGORY_ID
                });
            }
            i_Setup_category.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Setup_category.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Setup_category.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Setup_category
            if (OnPreEvent_Edit_Setup_category != null)
            {
                OnPreEvent_Edit_Setup_category(i_Setup_category, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Setup_category_Execution)
            {
                _Stop_Edit_Setup_category_Execution = false;
                return;
            }
            i_Setup_category.SETUP_CATEGORY_ID = _AppContext.Edit_Setup_category
            (
                i_Setup_category.SETUP_CATEGORY_ID,
                i_Setup_category.SETUP_CATEGORY_NAME,
                i_Setup_category.DESCRIPTION,
                i_Setup_category.ENTRY_USER_ID,
                i_Setup_category.ENTRY_DATE,
                i_Setup_category.LAST_UPDATE,
                i_Setup_category.IS_DELETED,
                i_Setup_category.OWNER_ID
            );
            #region PostEvent_Edit_Setup_category
            if (OnPostEvent_Edit_Setup_category != null)
            {
                OnPostEvent_Edit_Setup_category(i_Setup_category, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup_category", i_Setup_category_json, false);
            }
        }
        #endregion
        #region Edit_Setup
        public void Edit_Setup(Setup i_Setup)
        {
            var i_Setup_json = JsonConvert.SerializeObject(i_Setup);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Setup.SETUP_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup", i_Setup_json, false);
            }
            #region Body Section.
            if (i_Setup.SETUP_ID == null || i_Setup.SETUP_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Setup");
            }
            if (Check_Setup_Uniqueness_Violation(i_Setup))
            {
                throw new BLC_Exception(Get_Message_Content(Enum_BR_Codes.BR_0000).Replace("%1", "Setup"));
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Setup.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Setup.IS_DELETED = false;
            }
            else
            {
                _Setup = Get_Setup_By_SETUP_ID(new Params_Get_Setup_By_SETUP_ID
                {
                    SETUP_ID = i_Setup.SETUP_ID
                });
            }
            i_Setup.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Setup.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Setup.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Setup_Execution)
            {
                _Stop_Edit_Setup_Execution = false;
                return;
            }
            i_Setup.SETUP_ID = _AppContext.Edit_Setup
            (
                i_Setup.SETUP_ID,
                i_Setup.SETUP_CATEGORY_ID,
                i_Setup.IS_SYSTEM,
                i_Setup.IS_DELETEABLE,
                i_Setup.IS_UPDATEABLE,
                i_Setup.IS_DELETED,
                i_Setup.IS_VISIBLE,
                i_Setup.DISPLAY_ORDER,
                i_Setup.VALUE,
                i_Setup.DESCRIPTION,
                i_Setup.ENTRY_USER_ID,
                i_Setup.ENTRY_DATE,
                i_Setup.LAST_UPDATE,
                i_Setup.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup", i_Setup_json, false);
            }
        }
        #endregion
        #region Edit_Build_version
        public void Edit_Build_version(Build_version i_Build_version)
        {
            var i_Build_version_json = JsonConvert.SerializeObject(i_Build_version);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Build_version.BUILD_VERSION_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Build_version", i_Build_version_json, false);
            }
            #region Body Section.
            if (i_Build_version.BUILD_VERSION_ID == null || i_Build_version.BUILD_VERSION_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Build_version");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Build_version.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Build_version.IS_DELETED = false;
            }
            else
            {
                _Build_version = Get_Build_version_By_BUILD_VERSION_ID(new Params_Get_Build_version_By_BUILD_VERSION_ID
                {
                    BUILD_VERSION_ID = i_Build_version.BUILD_VERSION_ID
                });
            }
            i_Build_version.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Build_version.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Build_version.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Build_version
            if (OnPreEvent_Edit_Build_version != null)
            {
                OnPreEvent_Edit_Build_version(i_Build_version, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Build_version_Execution)
            {
                _Stop_Edit_Build_version_Execution = false;
                return;
            }
            i_Build_version.BUILD_VERSION_ID = _AppContext.Edit_Build_version
            (
                i_Build_version.BUILD_VERSION_ID,
                i_Build_version.BUILD_NUMBER,
                i_Build_version.APPLICATION_NAME_SETUP_ID,
                i_Build_version.IS_CURRENT,
                i_Build_version.BUILD_DATE,
                i_Build_version.COMMENTS,
                i_Build_version.ENTRY_USER_ID,
                i_Build_version.ENTRY_DATE,
                i_Build_version.LAST_UPDATE,
                i_Build_version.IS_DELETED,
                i_Build_version.OWNER_ID
            );
            #region PostEvent_Edit_Build_version
            if (OnPostEvent_Edit_Build_version != null)
            {
                OnPostEvent_Edit_Build_version(i_Build_version, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Build_version", i_Build_version_json, false);
            }
        }
        #endregion
        #region Edit_Default_settings
        public void Edit_Default_settings(Default_settings i_Default_settings)
        {
            var i_Default_settings_json = JsonConvert.SerializeObject(i_Default_settings);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Default_settings.DEFAULT_SETTINGS_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Default_settings", i_Default_settings_json, false);
            }
            #region Body Section.
            if (i_Default_settings.DEFAULT_SETTINGS_ID == null || i_Default_settings.DEFAULT_SETTINGS_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Default_settings");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Default_settings.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Default_settings.IS_DELETED = false;
            }
            else
            {
                _Default_settings = Get_Default_settings_By_DEFAULT_SETTINGS_ID(new Params_Get_Default_settings_By_DEFAULT_SETTINGS_ID
                {
                    DEFAULT_SETTINGS_ID = i_Default_settings.DEFAULT_SETTINGS_ID
                });
            }
            i_Default_settings.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Default_settings.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Default_settings.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            #region PreEvent_Edit_Default_settings
            if (OnPreEvent_Edit_Default_settings != null)
            {
                OnPreEvent_Edit_Default_settings(i_Default_settings, oEditMode_Flag);
            }
            #endregion
            if (_Stop_Edit_Default_settings_Execution)
            {
                _Stop_Edit_Default_settings_Execution = false;
                return;
            }
            i_Default_settings.DEFAULT_SETTINGS_ID = _AppContext.Edit_Default_settings
            (
                i_Default_settings.DEFAULT_SETTINGS_ID,
                i_Default_settings.PLATFORM_PRIMARY,
                i_Default_settings.PLATFORM_BUTTON,
                i_Default_settings.DATA_RETENTION_PERIOD,
                i_Default_settings.TICKET_DURATION_IN_MINUTES,
                i_Default_settings.OTP_TTL_IN_SECONDS,
                i_Default_settings.MAPBOX_GL_TOKEN,
                i_Default_settings.GOOGLE_MAP_API_TOKEN,
                i_Default_settings.TELUS_REQUEST_ID,
                i_Default_settings.ENTRY_USER_ID,
                i_Default_settings.ENTRY_DATE,
                i_Default_settings.LAST_UPDATE,
                i_Default_settings.IS_DELETED,
                i_Default_settings.OWNER_ID
            );
            #region PostEvent_Edit_Default_settings
            if (OnPostEvent_Edit_Default_settings != null)
            {
                OnPostEvent_Edit_Default_settings(i_Default_settings, oEditMode_Flag);
            }
            #endregion
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Default_settings", i_Default_settings_json, false);
            }
        }
        #endregion
        #region Edit_Default_chart_color
        public void Edit_Default_chart_color(Default_chart_color i_Default_chart_color)
        {
            var i_Default_chart_color_json = JsonConvert.SerializeObject(i_Default_chart_color);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Default_chart_color.DEFAULT_CHART_COLOR_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Default_chart_color", i_Default_chart_color_json, false);
            }
            #region Body Section.
            if (i_Default_chart_color.DEFAULT_CHART_COLOR_ID == null || i_Default_chart_color.DEFAULT_CHART_COLOR_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Default_chart_color");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Default_chart_color.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Default_chart_color.IS_DELETED = false;
            }
            else
            {
                _Default_chart_color = Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID(new Params_Get_Default_chart_color_By_DEFAULT_CHART_COLOR_ID
                {
                    DEFAULT_CHART_COLOR_ID = i_Default_chart_color.DEFAULT_CHART_COLOR_ID
                });
            }
            i_Default_chart_color.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Default_chart_color.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Default_chart_color.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Default_chart_color_Execution)
            {
                _Stop_Edit_Default_chart_color_Execution = false;
                return;
            }
            i_Default_chart_color.DEFAULT_CHART_COLOR_ID = _AppContext.Edit_Default_chart_color
            (
                i_Default_chart_color.DEFAULT_CHART_COLOR_ID,
                i_Default_chart_color.DEFAULT_SETTINGS_ID,
                i_Default_chart_color.COLOR,
                i_Default_chart_color.DATA_LEVEL_SETUP_ID,
                i_Default_chart_color.ENTRY_USER_ID,
                i_Default_chart_color.ENTRY_DATE,
                i_Default_chart_color.LAST_UPDATE,
                i_Default_chart_color.IS_DELETED,
                i_Default_chart_color.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Default_chart_color", i_Default_chart_color_json, false);
            }
        }
        #endregion
        #region Edit_Districtnex_module
        public void Edit_Districtnex_module(Districtnex_module i_Districtnex_module)
        {
            var i_Districtnex_module_json = JsonConvert.SerializeObject(i_Districtnex_module);

            Enum_Edit_Mode oEditMode_Flag = Enum_Edit_Mode.Update;
            if (i_Districtnex_module.DISTRICTNEX_MODULE_ID == -1)
            {
                oEditMode_Flag = Enum_Edit_Mode.Add;
            }
            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Districtnex_module", i_Districtnex_module_json, false);
            }
            #region Body Section.
            if (i_Districtnex_module.DISTRICTNEX_MODULE_ID == null || i_Districtnex_module.DISTRICTNEX_MODULE_ID == 0)
            {
                throw new BLC_Exception("Missing primary key while calling Edit_Districtnex_module");
            }
            if (oEditMode_Flag == Enum_Edit_Mode.Add)
            {
                i_Districtnex_module.ENTRY_DATE = Tools.GetDateTimeString(DateTime.Now);
                i_Districtnex_module.IS_DELETED = false;
            }
            else
            {
                _Districtnex_module = Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID(new Params_Get_Districtnex_module_By_DISTRICTNEX_MODULE_ID
                {
                    DISTRICTNEX_MODULE_ID = i_Districtnex_module.DISTRICTNEX_MODULE_ID
                });
            }
            i_Districtnex_module.OWNER_ID = this.oBLC_Initializer.Owner_ID;
            i_Districtnex_module.ENTRY_USER_ID = this.oBLC_Initializer.User_ID;
            i_Districtnex_module.LAST_UPDATE = Tools.GetDateTimeString(DateTime.Now);
            if (_Stop_Edit_Districtnex_module_Execution)
            {
                _Stop_Edit_Districtnex_module_Execution = false;
                return;
            }
            i_Districtnex_module.DISTRICTNEX_MODULE_ID = _AppContext.Edit_Districtnex_module
            (
                i_Districtnex_module.DISTRICTNEX_MODULE_ID,
                i_Districtnex_module.NAME,
                i_Districtnex_module.DISPLAY_ORDER,
                i_Districtnex_module.ENTRY_USER_ID,
                i_Districtnex_module.ENTRY_DATE,
                i_Districtnex_module.LAST_UPDATE,
                i_Districtnex_module.IS_DELETED,
                i_Districtnex_module.OWNER_ID
            );
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Districtnex_module", i_Districtnex_module_json, false);
            }
        }
        #endregion
        #region Edit_Build_version_log_List
        public void Edit_Build_version_log_List(Params_Edit_Build_version_log_List i_Params_Edit_Build_version_log_List)
        {
            var i_Params_Edit_Build_version_log_List_json = JsonConvert.SerializeObject(i_Params_Edit_Build_version_log_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Build_version_log_List", i_Params_Edit_Build_version_log_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Build_version_log_List.List_To_Edit != null)
            {
                i_Params_Edit_Build_version_log_List.List_Failed_Edit = new List<Build_version_log>();
                if (i_Params_Edit_Build_version_log_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oBuild_version_log in i_Params_Edit_Build_version_log_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Build_version_log(oBuild_version_log);
                        }
                        catch
                        {
                            i_Params_Edit_Build_version_log_List.List_Failed_Edit.Add(oBuild_version_log);
                        }
                    }
                }
                i_Params_Edit_Build_version_log_List.List_To_Edit = i_Params_Edit_Build_version_log_List.List_To_Edit.Except(i_Params_Edit_Build_version_log_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Build_version_log_List.List_To_Delete != null)
            {
                i_Params_Edit_Build_version_log_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Build_version_log_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Build_version_log_ID in i_Params_Edit_Build_version_log_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Build_version_log(new Params_Delete_Build_version_log()
                            {
                                BUILD_VERSION_LOG_ID = Build_version_log_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Build_version_log_List.List_Failed_Delete.Add(Build_version_log_ID);
                        }
                    }
                }
                i_Params_Edit_Build_version_log_List.List_To_Delete = i_Params_Edit_Build_version_log_List.List_To_Delete.Except(i_Params_Edit_Build_version_log_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Build_version_log_List", i_Params_Edit_Build_version_log_List_json, false);
            }
        }
        #endregion
        #region Edit_Removed_extrusion_List
        public void Edit_Removed_extrusion_List(Params_Edit_Removed_extrusion_List i_Params_Edit_Removed_extrusion_List)
        {
            var i_Params_Edit_Removed_extrusion_List_json = JsonConvert.SerializeObject(i_Params_Edit_Removed_extrusion_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Removed_extrusion_List", i_Params_Edit_Removed_extrusion_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Removed_extrusion_List.List_To_Edit != null)
            {
                i_Params_Edit_Removed_extrusion_List.List_Failed_Edit = new List<Removed_extrusion>();
                if (i_Params_Edit_Removed_extrusion_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oRemoved_extrusion in i_Params_Edit_Removed_extrusion_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Removed_extrusion(oRemoved_extrusion);
                        }
                        catch
                        {
                            i_Params_Edit_Removed_extrusion_List.List_Failed_Edit.Add(oRemoved_extrusion);
                        }
                    }
                }
                i_Params_Edit_Removed_extrusion_List.List_To_Edit = i_Params_Edit_Removed_extrusion_List.List_To_Edit.Except(i_Params_Edit_Removed_extrusion_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Removed_extrusion_List.List_To_Delete != null)
            {
                i_Params_Edit_Removed_extrusion_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Removed_extrusion_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Removed_extrusion_ID in i_Params_Edit_Removed_extrusion_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Removed_extrusion(new Params_Delete_Removed_extrusion()
                            {
                                REMOVED_EXTRUSION_ID = Removed_extrusion_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Removed_extrusion_List.List_Failed_Delete.Add(Removed_extrusion_ID);
                        }
                    }
                }
                i_Params_Edit_Removed_extrusion_List.List_To_Delete = i_Params_Edit_Removed_extrusion_List.List_To_Delete.Except(i_Params_Edit_Removed_extrusion_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Removed_extrusion_List", i_Params_Edit_Removed_extrusion_List_json, false);
            }
        }
        #endregion
        #region Edit_Alert_settings_List
        public void Edit_Alert_settings_List(Params_Edit_Alert_settings_List i_Params_Edit_Alert_settings_List)
        {
            var i_Params_Edit_Alert_settings_List_json = JsonConvert.SerializeObject(i_Params_Edit_Alert_settings_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Alert_settings_List", i_Params_Edit_Alert_settings_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Alert_settings_List.List_To_Edit != null)
            {
                i_Params_Edit_Alert_settings_List.List_Failed_Edit = new List<Alert_settings>();
                if (i_Params_Edit_Alert_settings_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oAlert_settings in i_Params_Edit_Alert_settings_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Alert_settings(oAlert_settings);
                        }
                        catch
                        {
                            i_Params_Edit_Alert_settings_List.List_Failed_Edit.Add(oAlert_settings);
                        }
                    }
                }
                i_Params_Edit_Alert_settings_List.List_To_Edit = i_Params_Edit_Alert_settings_List.List_To_Edit.Except(i_Params_Edit_Alert_settings_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Alert_settings_List.List_To_Delete != null)
            {
                i_Params_Edit_Alert_settings_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Alert_settings_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Alert_settings_ID in i_Params_Edit_Alert_settings_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Alert_settings(new Params_Delete_Alert_settings()
                            {
                                ALERT_SETTINGS_ID = Alert_settings_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Alert_settings_List.List_Failed_Delete.Add(Alert_settings_ID);
                        }
                    }
                }
                i_Params_Edit_Alert_settings_List.List_To_Delete = i_Params_Edit_Alert_settings_List.List_To_Delete.Except(i_Params_Edit_Alert_settings_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Alert_settings_List", i_Params_Edit_Alert_settings_List_json, false);
            }
        }
        #endregion
        #region Edit_Default_settings_image_List
        public void Edit_Default_settings_image_List(Params_Edit_Default_settings_image_List i_Params_Edit_Default_settings_image_List)
        {
            var i_Params_Edit_Default_settings_image_List_json = JsonConvert.SerializeObject(i_Params_Edit_Default_settings_image_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Default_settings_image_List", i_Params_Edit_Default_settings_image_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Default_settings_image_List.List_To_Edit != null)
            {
                i_Params_Edit_Default_settings_image_List.List_Failed_Edit = new List<Default_settings_image>();
                if (i_Params_Edit_Default_settings_image_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oDefault_settings_image in i_Params_Edit_Default_settings_image_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Default_settings_image(oDefault_settings_image);
                        }
                        catch
                        {
                            i_Params_Edit_Default_settings_image_List.List_Failed_Edit.Add(oDefault_settings_image);
                        }
                    }
                }
                i_Params_Edit_Default_settings_image_List.List_To_Edit = i_Params_Edit_Default_settings_image_List.List_To_Edit.Except(i_Params_Edit_Default_settings_image_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Default_settings_image_List.List_To_Delete != null)
            {
                i_Params_Edit_Default_settings_image_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Default_settings_image_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Default_settings_image_ID in i_Params_Edit_Default_settings_image_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Default_settings_image(new Params_Delete_Default_settings_image()
                            {
                                DEFAULT_SETTINGS_IMAGE_ID = Default_settings_image_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Default_settings_image_List.List_Failed_Delete.Add(Default_settings_image_ID);
                        }
                    }
                }
                i_Params_Edit_Default_settings_image_List.List_To_Delete = i_Params_Edit_Default_settings_image_List.List_To_Delete.Except(i_Params_Edit_Default_settings_image_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Default_settings_image_List", i_Params_Edit_Default_settings_image_List_json, false);
            }
        }
        #endregion
        #region Edit_Owner_List
        public void Edit_Owner_List(Params_Edit_Owner_List i_Params_Edit_Owner_List)
        {
            var i_Params_Edit_Owner_List_json = JsonConvert.SerializeObject(i_Params_Edit_Owner_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Owner_List", i_Params_Edit_Owner_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Owner_List.List_To_Edit != null)
            {
                i_Params_Edit_Owner_List.List_Failed_Edit = new List<Owner>();
                if (i_Params_Edit_Owner_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oOwner in i_Params_Edit_Owner_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Owner(oOwner);
                        }
                        catch
                        {
                            i_Params_Edit_Owner_List.List_Failed_Edit.Add(oOwner);
                        }
                    }
                }
                i_Params_Edit_Owner_List.List_To_Edit = i_Params_Edit_Owner_List.List_To_Edit.Except(i_Params_Edit_Owner_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Owner_List.List_To_Delete != null)
            {
                i_Params_Edit_Owner_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Owner_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Owner_ID in i_Params_Edit_Owner_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Owner(new Params_Delete_Owner()
                            {
                                OWNER_ID = Owner_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Owner_List.List_Failed_Delete.Add(Owner_ID);
                        }
                    }
                }
                i_Params_Edit_Owner_List.List_To_Delete = i_Params_Edit_Owner_List.List_To_Delete.Except(i_Params_Edit_Owner_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Owner_List", i_Params_Edit_Owner_List_json, false);
            }
        }
        #endregion
        #region Edit_Setup_category_List
        public void Edit_Setup_category_List(Params_Edit_Setup_category_List i_Params_Edit_Setup_category_List)
        {
            var i_Params_Edit_Setup_category_List_json = JsonConvert.SerializeObject(i_Params_Edit_Setup_category_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup_category_List", i_Params_Edit_Setup_category_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Setup_category_List.List_To_Edit != null)
            {
                i_Params_Edit_Setup_category_List.List_Failed_Edit = new List<Setup_category>();
                if (i_Params_Edit_Setup_category_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSetup_category in i_Params_Edit_Setup_category_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Setup_category(oSetup_category);
                        }
                        catch
                        {
                            i_Params_Edit_Setup_category_List.List_Failed_Edit.Add(oSetup_category);
                        }
                    }
                }
                i_Params_Edit_Setup_category_List.List_To_Edit = i_Params_Edit_Setup_category_List.List_To_Edit.Except(i_Params_Edit_Setup_category_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Setup_category_List.List_To_Delete != null)
            {
                i_Params_Edit_Setup_category_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Setup_category_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Setup_category_ID in i_Params_Edit_Setup_category_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Setup_category(new Params_Delete_Setup_category()
                            {
                                SETUP_CATEGORY_ID = Setup_category_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Setup_category_List.List_Failed_Delete.Add(Setup_category_ID);
                        }
                    }
                }
                i_Params_Edit_Setup_category_List.List_To_Delete = i_Params_Edit_Setup_category_List.List_To_Delete.Except(i_Params_Edit_Setup_category_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup_category_List", i_Params_Edit_Setup_category_List_json, false);
            }
        }
        #endregion
        #region Edit_Setup_List
        public void Edit_Setup_List(Params_Edit_Setup_List i_Params_Edit_Setup_List)
        {
            var i_Params_Edit_Setup_List_json = JsonConvert.SerializeObject(i_Params_Edit_Setup_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Setup_List", i_Params_Edit_Setup_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Setup_List.List_To_Edit != null)
            {
                i_Params_Edit_Setup_List.List_Failed_Edit = new List<Setup>();
                if (i_Params_Edit_Setup_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oSetup in i_Params_Edit_Setup_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Setup(oSetup);
                        }
                        catch
                        {
                            i_Params_Edit_Setup_List.List_Failed_Edit.Add(oSetup);
                        }
                    }
                }
                i_Params_Edit_Setup_List.List_To_Edit = i_Params_Edit_Setup_List.List_To_Edit.Except(i_Params_Edit_Setup_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Setup_List.List_To_Delete != null)
            {
                i_Params_Edit_Setup_List.List_Failed_Delete = new List<long?>();
                if (i_Params_Edit_Setup_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Setup_ID in i_Params_Edit_Setup_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Setup(new Params_Delete_Setup()
                            {
                                SETUP_ID = Setup_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Setup_List.List_Failed_Delete.Add(Setup_ID);
                        }
                    }
                }
                i_Params_Edit_Setup_List.List_To_Delete = i_Params_Edit_Setup_List.List_To_Delete.Except(i_Params_Edit_Setup_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Setup_List", i_Params_Edit_Setup_List_json, false);
            }
        }
        #endregion
        #region Edit_Build_version_List
        public void Edit_Build_version_List(Params_Edit_Build_version_List i_Params_Edit_Build_version_List)
        {
            var i_Params_Edit_Build_version_List_json = JsonConvert.SerializeObject(i_Params_Edit_Build_version_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Build_version_List", i_Params_Edit_Build_version_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Build_version_List.List_To_Edit != null)
            {
                i_Params_Edit_Build_version_List.List_Failed_Edit = new List<Build_version>();
                if (i_Params_Edit_Build_version_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oBuild_version in i_Params_Edit_Build_version_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Build_version(oBuild_version);
                        }
                        catch
                        {
                            i_Params_Edit_Build_version_List.List_Failed_Edit.Add(oBuild_version);
                        }
                    }
                }
                i_Params_Edit_Build_version_List.List_To_Edit = i_Params_Edit_Build_version_List.List_To_Edit.Except(i_Params_Edit_Build_version_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Build_version_List.List_To_Delete != null)
            {
                i_Params_Edit_Build_version_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Build_version_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Build_version_ID in i_Params_Edit_Build_version_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Build_version(new Params_Delete_Build_version()
                            {
                                BUILD_VERSION_ID = Build_version_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Build_version_List.List_Failed_Delete.Add(Build_version_ID);
                        }
                    }
                }
                i_Params_Edit_Build_version_List.List_To_Delete = i_Params_Edit_Build_version_List.List_To_Delete.Except(i_Params_Edit_Build_version_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Build_version_List", i_Params_Edit_Build_version_List_json, false);
            }
        }
        #endregion
        #region Edit_Default_settings_List
        public void Edit_Default_settings_List(Params_Edit_Default_settings_List i_Params_Edit_Default_settings_List)
        {
            var i_Params_Edit_Default_settings_List_json = JsonConvert.SerializeObject(i_Params_Edit_Default_settings_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Default_settings_List", i_Params_Edit_Default_settings_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Default_settings_List.List_To_Edit != null)
            {
                i_Params_Edit_Default_settings_List.List_Failed_Edit = new List<Default_settings>();
                if (i_Params_Edit_Default_settings_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oDefault_settings in i_Params_Edit_Default_settings_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Default_settings(oDefault_settings);
                        }
                        catch
                        {
                            i_Params_Edit_Default_settings_List.List_Failed_Edit.Add(oDefault_settings);
                        }
                    }
                }
                i_Params_Edit_Default_settings_List.List_To_Edit = i_Params_Edit_Default_settings_List.List_To_Edit.Except(i_Params_Edit_Default_settings_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Default_settings_List.List_To_Delete != null)
            {
                i_Params_Edit_Default_settings_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Default_settings_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Default_settings_ID in i_Params_Edit_Default_settings_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Default_settings(new Params_Delete_Default_settings()
                            {
                                DEFAULT_SETTINGS_ID = Default_settings_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Default_settings_List.List_Failed_Delete.Add(Default_settings_ID);
                        }
                    }
                }
                i_Params_Edit_Default_settings_List.List_To_Delete = i_Params_Edit_Default_settings_List.List_To_Delete.Except(i_Params_Edit_Default_settings_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Default_settings_List", i_Params_Edit_Default_settings_List_json, false);
            }
        }
        #endregion
        #region Edit_Default_chart_color_List
        public void Edit_Default_chart_color_List(Params_Edit_Default_chart_color_List i_Params_Edit_Default_chart_color_List)
        {
            var i_Params_Edit_Default_chart_color_List_json = JsonConvert.SerializeObject(i_Params_Edit_Default_chart_color_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Default_chart_color_List", i_Params_Edit_Default_chart_color_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Default_chart_color_List.List_To_Edit != null)
            {
                i_Params_Edit_Default_chart_color_List.List_Failed_Edit = new List<Default_chart_color>();
                if (i_Params_Edit_Default_chart_color_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oDefault_chart_color in i_Params_Edit_Default_chart_color_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Default_chart_color(oDefault_chart_color);
                        }
                        catch
                        {
                            i_Params_Edit_Default_chart_color_List.List_Failed_Edit.Add(oDefault_chart_color);
                        }
                    }
                }
                i_Params_Edit_Default_chart_color_List.List_To_Edit = i_Params_Edit_Default_chart_color_List.List_To_Edit.Except(i_Params_Edit_Default_chart_color_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Default_chart_color_List.List_To_Delete != null)
            {
                i_Params_Edit_Default_chart_color_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Default_chart_color_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Default_chart_color_ID in i_Params_Edit_Default_chart_color_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Default_chart_color(new Params_Delete_Default_chart_color()
                            {
                                DEFAULT_CHART_COLOR_ID = Default_chart_color_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Default_chart_color_List.List_Failed_Delete.Add(Default_chart_color_ID);
                        }
                    }
                }
                i_Params_Edit_Default_chart_color_List.List_To_Delete = i_Params_Edit_Default_chart_color_List.List_To_Delete.Except(i_Params_Edit_Default_chart_color_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Default_chart_color_List", i_Params_Edit_Default_chart_color_List_json, false);
            }
        }
        #endregion
        #region Edit_Districtnex_module_List
        public void Edit_Districtnex_module_List(Params_Edit_Districtnex_module_List i_Params_Edit_Districtnex_module_List)
        {
            var i_Params_Edit_Districtnex_module_List_json = JsonConvert.SerializeObject(i_Params_Edit_Districtnex_module_List);

            if (OnPreEvent_General != null)
            {
                OnPreEvent_General("Edit_Districtnex_module_List", i_Params_Edit_Districtnex_module_List_json, false);
            }
            #region Body Section.
            if (i_Params_Edit_Districtnex_module_List.List_To_Edit != null)
            {
                i_Params_Edit_Districtnex_module_List.List_Failed_Edit = new List<Districtnex_module>();
                if (i_Params_Edit_Districtnex_module_List.List_To_Edit.Count() > 0)
                {
                    foreach (var oDistrictnex_module in i_Params_Edit_Districtnex_module_List.List_To_Edit)
                    {
                        try
                        {
                            Edit_Districtnex_module(oDistrictnex_module);
                        }
                        catch
                        {
                            i_Params_Edit_Districtnex_module_List.List_Failed_Edit.Add(oDistrictnex_module);
                        }
                    }
                }
                i_Params_Edit_Districtnex_module_List.List_To_Edit = i_Params_Edit_Districtnex_module_List.List_To_Edit.Except(i_Params_Edit_Districtnex_module_List.List_Failed_Edit).ToList();
            }
            if (i_Params_Edit_Districtnex_module_List.List_To_Delete != null)
            {
                i_Params_Edit_Districtnex_module_List.List_Failed_Delete = new List<int?>();
                if (i_Params_Edit_Districtnex_module_List.List_To_Delete.Count() > 0)
                {
                    foreach (var Districtnex_module_ID in i_Params_Edit_Districtnex_module_List.List_To_Delete)
                    {
                        try
                        {
                            Delete_Districtnex_module(new Params_Delete_Districtnex_module()
                            {
                                DISTRICTNEX_MODULE_ID = Districtnex_module_ID
                            });
                        }
                        catch
                        {
                            i_Params_Edit_Districtnex_module_List.List_Failed_Delete.Add(Districtnex_module_ID);
                        }
                    }
                }
                i_Params_Edit_Districtnex_module_List.List_To_Delete = i_Params_Edit_Districtnex_module_List.List_To_Delete.Except(i_Params_Edit_Districtnex_module_List.List_Failed_Delete);
            }
            #endregion
            if (OnPostEvent_General != null)
            {
                OnPostEvent_General("Edit_Districtnex_module_List", i_Params_Edit_Districtnex_module_List_json, false);
            }
        }
        #endregion
    }
}