using System;
using SmartrTools;
using System.Diagnostics;
using System.Configuration;
using System.Threading.Tasks;

namespace BLC
{
    public partial class BLC
    {
        #region StopWatch properties
        public Stopwatch _Execution_Time_Get_Kpi_By_KPI_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Dimension_By_DIMENSION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_REPORT_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_KPI_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_REPORT_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_KPI_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Dimension_By_DIMENSION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_REPORT_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_KPI_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_REPORT_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_DIMENSION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_SETUP_CATEGORY_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_KPI_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Dimension_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Dimension_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Dimension_By_DIMENSION_ORDER { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_DIMENSION_ID { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_IDENTIFIER_TOKEN { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_DIMENSION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_SETUP_CATEGORY_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_KPI_TYPE_SETUP_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_OWNER_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_DIMENSION_ID_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_OWNER_ID_IS_DELETED_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_IDENTIFIER_TOKEN_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_DIMENSION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_SETUP_CATEGORY_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_KPI_TYPE_SETUP_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Dimension_By_DIMENSION_ORDER_List { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_DIMENSION_ID_List { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_DIMENSION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_SETUP_CATEGORY_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_MIN_DATA_LEVEL_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_MAX_DATA_LEVEL_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_KPI_TYPE_SETUP_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_DIMENSION_ID_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Dimension_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_Where_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_Where_In_List { get; set; }
        public Stopwatch _Execution_Time_Get_Kpi_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Get_Report_By_Where_In_List_Adv { get; set; }
        public Stopwatch _Execution_Time_Delete_Kpi { get; set; }
        public Stopwatch _Execution_Time_Delete_Dimension { get; set; }
        public Stopwatch _Execution_Time_Delete_Report { get; set; }
        public Stopwatch _Execution_Time_Delete_Kpi_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Kpi_By_DIMENSION_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Kpi_By_SETUP_CATEGORY_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Kpi_By_MIN_DATA_LEVEL_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Kpi_By_MAX_DATA_LEVEL_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Kpi_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Kpi_By_KPI_TYPE_SETUP_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Dimension_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Dimension_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Dimension_By_DIMENSION_ORDER { get; set; }
        public Stopwatch _Execution_Time_Delete_Report_By_OWNER_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Report_By_DIMENSION_ID { get; set; }
        public Stopwatch _Execution_Time_Delete_Report_By_OWNER_ID_IS_DELETED { get; set; }
        public Stopwatch _Execution_Time_Delete_Report_By_IDENTIFIER_TOKEN { get; set; }
        public Stopwatch _Execution_Time_Edit_Kpi { get; set; }
        public Stopwatch _Execution_Time_Edit_Dimension { get; set; }
        public Stopwatch _Execution_Time_Edit_Report { get; set; }
        public Stopwatch _Execution_Time_Edit_Kpi_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Dimension_List { get; set; }
        public Stopwatch _Execution_Time_Edit_Report_List { get; set; }
        public Stopwatch _Execution_Time_Get_Dimension_index_By_Where { get; set; }
        public Stopwatch _Execution_Time_Insert_Dimension_index_List { get; set; }
        public Stopwatch _Execution_Time_Delete_Dimension_index_By_Where { get; set; }
        public Stopwatch _Execution_Time_Get_Latest_Dimension_index_By_Where { get; set; }
        public Stopwatch _Execution_Time_Generate_Dimension_Index_Daily { get; set; }
        public Stopwatch _Execution_Time_Compute_Dimension_Index_Weekly { get; set; }
        public Stopwatch _Execution_Time_Compute_Dimension_Index_Monthly { get; set; }
        public Stopwatch _Execution_Time_Edit_Dimension_index_List_Unique_By_RECORD_DATE_KPI_ID_TIMESPAN { get; set; }
        #endregion
        #region BLC_OnPreEvent_General_Monitoring
        public void BLC_OnPreEvent_General_Monitoring(string i_MethodName, string i_Method_Params, bool is_Cached)
        {
            #region Body Section.
            var oStopWatch = (Stopwatch)Props.Get_Prop_Value(this, string.Format("_Execution_Time_{0}", i_MethodName));
            Props.Set_Prop_Value(this, string.Format("_Execution_Time_{0}", i_MethodName), Stopwatch.StartNew());
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_General_Monitoring
        public void BLC_OnPostEvent_General_Monitoring(string i_MethodName, string i_Method_Params, bool is_Cached)
        {
            Task.Run(() =>
            {
                if (i_MethodName != "Edit_Method_run")
                {
                    #region Declaration And Initialization Section.
                    Service_Mesh.Method_run oMethod_run = new Service_Mesh.Method_run();
                    #endregion
                    #region Body Section.
                    Props.Set_Properties_Default_Value(oMethod_run);
                    oMethod_run.METHOD_RUN_ID = -1;
                    oMethod_run.IS_CACHED = is_Cached;
                    oMethod_run.METHOD_NAME = i_MethodName;
                    oMethod_run.RUN_HOUR = DateTime.Now.Hour;
                    oMethod_run.METHOD_PARAMS = i_Method_Params;
                    oMethod_run.RUN_MINUTE = DateTime.Now.Minute;
                    oMethod_run.RUN_SECOND = DateTime.Now.Second;
                    oMethod_run.RUN_DATE = Tools.GetDateString(DateTime.Today);
                    // Calculate Execution time
                    if (Props.Get_Prop_Value(this, string.Format("_Execution_Time_{0}", i_MethodName)) != null)
                    {
                        var oStopWatch = (Stopwatch)Props.Get_Prop_Value(this, string.Format("_Execution_Time_{0}", i_MethodName));
                        oStopWatch.Stop();
                        var elapsedMs = oStopWatch.ElapsedMilliseconds;
                        oMethod_run.EXECUTION_TIME = (int)elapsedMs;
                    }
                    this._service_mesh.Edit_Method_run(oMethod_run);
                    #endregion
                }
            });
        }
        #endregion
        #region Initialize_Monitoring_Mechanism
        public void Initialize_Monitoring_Mechanism()
        {
            #region Body Section.
            if (ConfigurationManager.AppSettings["ENABLE_MONITORING"] != null && ConfigurationManager.AppSettings["ENABLE_MONITORING"] == "1")
            {
                this.OnPreEvent_General += new PreEvent_Handler_General(BLC_OnPreEvent_General_Monitoring);
                this.OnPostEvent_General += new PostEvent_Handler_General(BLC_OnPostEvent_General_Monitoring);
            }
            #endregion
        }
        #endregion
    }
}