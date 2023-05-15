using System;
using System.Collections.Generic;

namespace BLC
{
    #region Params_Download_Report
    public class Params_Get_Report_Url_From_Token
    {
        public string IDENTIFIER_TOKEN { get; set; }
    }
    #endregion
    #region Params_Send_Report_Email
    public class Params_Send_Report_Email
    {
        public int REPORT_ID { get; set; }
        public string TO_EMAIL { get; set; }
    }
    #endregion
    #region Params_Get_Report_Details
    public class Params_Get_Report_Details
    {
        public DateTime? END_DATE { get; set; }
        public DateTime? START_DATE { get; set; }
        public Enum_Timespan? ENUM_TIMESPAN { get; set; }
        public List<Asset_definition> LIST_DISTRICT_ASSET_DEFINITION { get; set; }
        public List<Asset_definition> LIST_AREA_ASSET_DEFINITION { get; set; }
        public List<Asset_definition> LIST_SITE_ASSET_DEFINITION { get; set; }
        public List<Asset_definition> LIST_ENTITY_ASSET_DEFINITION { get; set; }
    }
    #endregion
    #region Enum_Timespan
    public enum Enum_Timespan
    {
        X_HOURLY_COLLECTION,
        X_DAILY_COLLECTION,
        X_WEEKLY_COLLECTION,
        X_MONTHLY_COLLECTION,
        X_QUARTERLY_COLLECTION
    }
    #endregion
}