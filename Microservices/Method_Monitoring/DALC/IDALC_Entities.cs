using System;

namespace DALC
{
    #region Method_run
    public partial class Method_run
    {
        public long? METHOD_RUN_ID { get; set; }
        public string METHOD_NAME { get; set; }
        public string RUN_DATE { get; set; }
        public int? RUN_HOUR { get; set; }
        public int? RUN_MINUTE { get; set; }
        public int? RUN_SECOND { get; set; }
        public int? EXECUTION_TIME { get; set; }
        public bool IS_CACHED { get; set; }
        public string METHOD_PARAMS { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public int? OWNER_ID { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
    }
    #endregion
}
