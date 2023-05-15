using System;

namespace DALC
{
    #region Correlation_method
    public partial class Correlation_method
    {
        public int? CORRELATION_METHOD_ID { get; set; }
        public string NAME { get; set; }
        public string DESCRIPTION { get; set; }
        public string EQUATION_URL { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
}
