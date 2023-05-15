using System.Linq;
using SmartrTools;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region BLC_OnPostEvent_Get_Dimension_By_Where_Eager_Loading
        public void BLC_OnPostEvent_Get_Dimension_By_Where_Eager_Loading(List<Dimension> i_Result, Params_Get_Dimension_By_Where i_Params_Get_Dimension_By_Where)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Dimension_ID_List = i_Result.Select(dimension => dimension.DIMENSION_ID).OrderBy(Dimension_ID => Dimension_ID);

                // ---------------------
                // Get All available Kpi entries.
                // ---------------------
                List<Kpi> oList_Kpi = Get_Kpi_By_DIMENSION_ID_List_Adv(new Params_Get_Kpi_By_DIMENSION_ID_List()
                {
                    DIMENSION_ID_LIST = Dimension_ID_List
                });
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oDimension =>
                {
                    oDimension.List_Kpi = oList_Kpi.Where(oKpi => oKpi.DIMENSION_ID == oDimension.DIMENSION_ID).ToList();
                    return oDimension;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Dimension_By_OWNER_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Dimension_By_OWNER_ID_Eager_Loading(List<Dimension> i_Result, Params_Get_Dimension_By_OWNER_ID i_Params_Get_Dimension_By_OWNER_ID)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Dimension_ID_List = i_Result.Select(dimension => dimension.DIMENSION_ID).OrderBy(Dimension_ID => Dimension_ID);

                // ---------------------
                // Get All available Report entries.
                // ---------------------
                List<Report> oList_Report = new List<Report>();
                var Report_handle = Task.Run(() =>
                {
                    oList_Report = Get_Report_By_DIMENSION_ID_List(new Params_Get_Report_By_DIMENSION_ID_List()
                    {
                        DIMENSION_ID_LIST = Dimension_ID_List
                    });
                });
                // ---------------------
                // Get All available Kpi entries.
                // ---------------------
                List<Kpi> oList_Kpi = new List<Kpi>();
                var Kpi_handle = Task.Run(() =>
                {
                    oList_Kpi = Get_Kpi_By_DIMENSION_ID_List(new Params_Get_Kpi_By_DIMENSION_ID_List()
                    {
                        DIMENSION_ID_LIST = Dimension_ID_List
                    });
                });
                Task.WaitAll(Report_handle, Kpi_handle);
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oDimension =>
                {
                    oDimension.List_Report = oList_Report.Where(oReport => oReport.DIMENSION_ID == oDimension.DIMENSION_ID).ToList();
                    oDimension.List_Kpi = oList_Kpi.Where(oKpi => oKpi.DIMENSION_ID == oDimension.DIMENSION_ID).ToList();
                    return oDimension;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Dimension_By_DIMENSION_ID_List_Eager_Loading
        public void BLC_OnPostEvent_Get_Dimension_By_DIMENSION_ID_List_Eager_Loading(List<Dimension> i_Result, Params_Get_Dimension_By_DIMENSION_ID_List i_Params_Get_Dimension_By_DIMENSION_ID_List)
        {
            #region Body Section
            if (i_Result != null && i_Result.Count > 0)
            {
                var Dimension_ID_List = i_Result.Select(dimension => dimension.DIMENSION_ID).OrderBy(Dimension_ID => Dimension_ID);

                // ---------------------
                // Get All available Report entries.
                // ---------------------
                List<Report> oList_Report = new List<Report>();
                var Report_handle = Task.Run(() =>
                {
                    oList_Report = Get_Report_By_DIMENSION_ID_List(new Params_Get_Report_By_DIMENSION_ID_List()
                    {
                        DIMENSION_ID_LIST = Dimension_ID_List
                    });
                });
                // ---------------------
                // Get All available Kpi entries.
                // ---------------------
                List<Kpi> oList_Kpi = new List<Kpi>();
                var Kpi_handle = Task.Run(() =>
                {
                    oList_Kpi = Get_Kpi_By_DIMENSION_ID_List(new Params_Get_Kpi_By_DIMENSION_ID_List()
                    {
                        DIMENSION_ID_LIST = Dimension_ID_List
                    });
                });
                Task.WaitAll(Report_handle, Kpi_handle);
                // ---------------------
                // Fill Data in the Main Object
                // ---------------------
                i_Result = i_Result.Select(oDimension =>
                {
                    oDimension.List_Report = oList_Report.Where(oReport => oReport.DIMENSION_ID == oDimension.DIMENSION_ID).ToList();
                    oDimension.List_Kpi = oList_Kpi.Where(oKpi => oKpi.DIMENSION_ID == oDimension.DIMENSION_ID).ToList();
                    return oDimension;
                }).ToList();
            }
            #endregion
        }
        #endregion
        #region BLC_OnPostEvent_Get_Dimension_By_DIMENSION_ID_Eager_Loading
        public void BLC_OnPostEvent_Get_Dimension_By_DIMENSION_ID_Eager_Loading(Dimension i_Result, Params_Get_Dimension_By_DIMENSION_ID i_Params_Get_Dimension_By_DIMENSION_ID)
        {
            #region Body Section
            if (i_Result != null)
            {
                var Dimension_ID = i_Result.DIMENSION_ID;
                // ---------------------
                // Get All available Kpi entries.
                // ---------------------
                List<Kpi> _List_Kpi = new List<Kpi>();
                var Kpi_handle = Task.Run(() =>
                {
                    _List_Kpi = Get_Kpi_By_DIMENSION_ID(new Params_Get_Kpi_By_DIMENSION_ID()
                    {
                        DIMENSION_ID = Dimension_ID
                    });
                });
                // ---------------------
                // Get All available Report entries.
                // ---------------------
                List<Report> _List_Report = new List<Report>();
                var Report_handle = Task.Run(() =>
                {
                    _List_Report = Get_Report_By_DIMENSION_ID(new Params_Get_Report_By_DIMENSION_ID()
                    {
                        DIMENSION_ID = Dimension_ID
                    });
                });
                Task.WaitAll(Kpi_handle, Report_handle);
                i_Result.List_Kpi = _List_Kpi;
                i_Result.List_Report = _List_Report;
            }
            #endregion
        }
        #endregion
        #region Initialize_Eager_Loading_Mechanism
        public void Initialize_Eager_Loading_Mechanism()
        {
            #region Body Section.
            this.OnPostEvent_Get_Dimension_By_Where += new PostEvent_Handler_Get_Dimension_By_Where(BLC_OnPostEvent_Get_Dimension_By_Where_Eager_Loading);
            this.OnPostEvent_Get_Dimension_By_OWNER_ID += new PostEvent_Handler_Get_Dimension_By_OWNER_ID(BLC_OnPostEvent_Get_Dimension_By_OWNER_ID_Eager_Loading);
            this.OnPostEvent_Get_Dimension_By_DIMENSION_ID_List += new PostEvent_Handler_Get_Dimension_By_DIMENSION_ID_List(BLC_OnPostEvent_Get_Dimension_By_DIMENSION_ID_List_Eager_Loading);
            this.OnPostEvent_Get_Dimension_By_DIMENSION_ID += new PostEvent_Handler_Get_Dimension_By_DIMENSION_ID(BLC_OnPostEvent_Get_Dimension_By_DIMENSION_ID_Eager_Loading);
            #endregion
        }
        #endregion
    }
}