using System;
using SmartrTools;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BLC
{
    public partial class BLC
    {
        #region BLC_OnPostEvent_Edit_Dimension_Reset
        public void BLC_OnPostEvent_Edit_Dimension_Reset(Dimension i_Dimension, Enum_Edit_Mode i_Enum_Edit_Mode)
        {
            if (i_Dimension != null)
            {
                if (i_Dimension.List_Kpi != null)
                {
                    if (i_Enum_Edit_Mode == Enum_Edit_Mode.Update)
                    {
                        if (i_Dimension.List_Kpi.Count == 0)
                        {
                            Delete_Kpi_By_DIMENSION_ID(new Params_Delete_Kpi_By_DIMENSION_ID()
                            {
                                DIMENSION_ID = i_Dimension.DIMENSION_ID
                            });
                        }
                        else
                        {
                            // -----------------------------
                            // Get related Kpi
                            // -----------------------------
                            List<Kpi> oList_Kpi = Get_Kpi_By_DIMENSION_ID(new Params_Get_Kpi_By_DIMENSION_ID()
                            {
                                DIMENSION_ID = i_Dimension.DIMENSION_ID
                            });
                            if (oList_Kpi != null && oList_Kpi.Count > 0)
                            {
                                oList_Kpi = oList_Kpi.Where(oKpi => !i_Dimension.List_Kpi.Any(oCurrent_Kpi => oCurrent_Kpi.KPI_ID == oKpi.KPI_ID)).ToList();
                                if (oList_Kpi.Count > 0)
                                {
                                    // For Each Entry that Exists in the Database and not in the New Collection, Delete it.
                                    Edit_Kpi_List(new Params_Edit_Kpi_List()
                                    {
                                        List_To_Delete = oList_Kpi.Select(oKpi => oKpi.KPI_ID)
                                    });
                                }
                            }
                        }
                    }
                    // -----------------------------
                    // Kpi
                    // -----------------------------
                    if (i_Dimension.List_Kpi != null && i_Dimension.List_Kpi.Count > 0)
                    {
                        foreach (var oKpi in i_Dimension.List_Kpi)
                        {
                            oKpi.DIMENSION_ID = i_Dimension.DIMENSION_ID;
                            Edit_Kpi(oKpi);
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
            this.OnPostEvent_Edit_Dimension += new PostEvent_Handler_Edit_Dimension(BLC_OnPostEvent_Edit_Dimension_Reset);
            #endregion
        }
        #endregion
    }
}