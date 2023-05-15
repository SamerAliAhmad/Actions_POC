using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Get_Correlation_method_By_CORRELATION_METHOD_ID
    public partial class Params_Get_Correlation_method_By_CORRELATION_METHOD_ID
    {
        #region Properties
        public int? CORRELATION_METHOD_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Correlation_method_By_CORRELATION_METHOD_ID_List
    public partial class Params_Get_Correlation_method_By_CORRELATION_METHOD_ID_List
    {
        #region Properties
        public IEnumerable<int?> CORRELATION_METHOD_ID_LIST { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Correlation_method_By_OWNER_ID
    public partial class Params_Get_Correlation_method_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Correlation_method_By_OWNER_ID_IS_DELETED
    public partial class Params_Get_Correlation_method_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Get_Correlation_method_By_Where
    public partial class Params_Get_Correlation_method_By_Where
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string EQUATION_URL { get; set; }
        public long? OFFSET { get; set; }
        public long? FETCH_NEXT { get; set; }
        public long? TOTAL_COUNT { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Correlation_method
    public partial class Params_Delete_Correlation_method
    {
        #region Properties
        public int? CORRELATION_METHOD_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Correlation_method_By_OWNER_ID
    public partial class Params_Delete_Correlation_method_By_OWNER_ID
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        #endregion
    }
    #endregion
    #region Params_Delete_Correlation_method_By_OWNER_ID_IS_DELETED
    public partial class Params_Delete_Correlation_method_By_OWNER_ID_IS_DELETED
    {
        #region Properties
        public int? OWNER_ID { get; set; }
        public bool IS_DELETED { get; set; }
        #endregion
    }
    #endregion
    #region Params_Edit_Correlation_method_List
    public partial class Params_Edit_Correlation_method_List
    {
        #region Properties
        public List<Correlation_method> List_To_Edit { get; set; }
        public List<Correlation_method> List_Failed_Edit { get; set; }
        public IEnumerable<int?> List_To_Delete { get; set; }
        public List<int?> List_Failed_Delete { get; set; }
        #endregion
    }
    #endregion
}