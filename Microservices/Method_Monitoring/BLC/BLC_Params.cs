using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Get_Method_run_By_METHOD_RUN_ID
    public partial class Params_Get_Method_run_By_METHOD_RUN_ID
    {
        #region Properties
        public long? METHOD_RUN_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Method_run_By_METHOD_RUN_ID_List
    public partial class Params_Get_Method_run_By_METHOD_RUN_ID_List
    {
        #region Properties
        public IEnumerable<long?> METHOD_RUN_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Method_run_By_OWNER_ID
    public partial class Params_Get_Method_run_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Method_run_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Method_run_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Method_run_By_Where
    public partial class Params_Get_Method_run_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string METHOD_NAME { get; set; }
        public string METHOD_PARAMS { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Method_run
    public partial class Params_Delete_Method_run
    {
        #region Properties
        public long? METHOD_RUN_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Method_run_By_OWNER_ID
    public partial class Params_Delete_Method_run_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Method_run_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Method_run_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Method_run_List
    public partial class Params_Edit_Method_run_List
    {
        #region Properties
        public List<Method_run> List_To_Edit { get; set; }
        public List<Method_run> List_Failed_Edit { get; set; }
        public IEnumerable<long?> List_To_Delete { get; set; }
        public List<long?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
}