using System;
using System.Collections.Generic;
using System.Configuration;

namespace BLC
{
    public static partial class Global
    {
        public static string User_ID = "USER_ID";
        public static string Owner_ID = "OWNER_ID";
        public static string Start_Date = "START_DATE";
        public static string Ticket_Separator = "[~!@]";
        public static string Start_Minute = "START_MINUTE";
        public static string Session_Period = "SESSION_PERIOD";
        public static string Assets_Endpoint = ConfigurationManager.AppSettings["ASSETS_ENDPOINT"];
    }
    #region Business
    public partial class Business
    {
        public string BUSINESS_ID { get; set; }
        public string ICON { get; set; }
        public string ICON_BACKGROUND_COLOR { get; set; }
        public string ICON_MASK_BASE_URI { get; set; }
        public string NAME { get; set; }
        public string PLACE_ID { get; set; }
        public string REFERENCE { get; set; }
        public string SCOPE { get; set; }
        public List<string> LIST_BUSINESS_CATEGORY { get; set; }
        public string BUSINESS_NICHE { get; set; }
        public string VICINITY { get; set; }
        public string BUSINESS_STATUS { get; set; }
        public decimal? RATING { get; set; }
        public long? USER_RATINGS_TOTAL { get; set; }
        public bool? OPEN_NOW { get; set; }
        public long? PRICE_LEVEL { get; set; }
        public string COMPOUND_CODE { get; set; }
        public string GLOBAL_CODE { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Location Location { get; set; }
    }
    #endregion
    #region Location
    public partial class Location
    {
        public string type { get; set; }
        public List<decimal?> coordinates { get; set; }
    }
    #endregion
    #region District_kpi_data
    public partial class District_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public District_metadata DISTRICT_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    #endregion
    #region District_metadata
    public partial class District_metadata
    {
        public int DISTRICT_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    #endregion
    #region Area_kpi_data
    public partial class Area_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Area_metadata AREA_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    #endregion
    #region Area_metadata
    public partial class Area_metadata
    {
        public int AREA_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    #endregion
    #region Site_kpi_data
    public partial class Site_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Site_metadata SITE_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    #endregion
    #region Site_metadata
    public partial class Site_metadata
    {
        public int SITE_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    #endregion
    #region Entity_kpi_data
    public partial class Entity_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Entity_metadata ENTITY_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    #endregion
    #region Entity_metadata
    public partial class Entity_metadata
    {
        public long ENTITY_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    #endregion
    #region Insights
    #endregion
    #region Dataset
    public class Dataset
    {
        public string LABEL { get; set; }
        public List<decimal?> LIST_POINT { get; set; }
    }
    #endregion
    #region Comparison_Data
    public partial class Comparison_Data
    {
        public List<District_kpi_data> LIST_DISTRICT_KPI_DATA_DWELL_TIME { get; set; }
        public List<District_kpi_data> LIST_DISTRICT_KPI_DATA_NUMBER_OF_VISITORS { get; set; }
        public List<Business> LIST_DISTRICT_BUSINESS_COUNT { get; set; }
        public List<Area_kpi_data> LIST_AREA_KPI_DATA_DWELL_TIME { get; set; }
        public List<Area_kpi_data> LIST_AREA_KPI_DATA_NUMBER_OF_VISITORS { get; set; }
        public List<Business> LIST_AREA_BUSINESS_COUNT { get; set; }
        public List<Site_kpi_data> LIST_SITE_KPI_DATA_DWELL_TIME { get; set; }
        public List<Site_kpi_data> LIST_SITE_KPI_DATA_NUMBER_OF_VISITORS { get; set; }
        public List<Business> LIST_SITE_BUSINESS_COUNT { get; set; }
    }
    #endregion
    #region Kpi_Value_By_Date
    public partial class Kpi_Value_By_Date
    {
        public DateTime? RECORD_DATE { get; set; }
        public decimal? VALUE { get; set; }
    }
    #endregion
    #region Kpi_Value_By_Direction
    public class Kpi_Value_By_Direction
    {
        public string DIRECTION { get; set; }
        public string LABEL { get; set; }
        public List<Kpi_Value_By_Date> LIST_KPI_VALUE_BY_DATE { get; set; }
    }
    #endregion
    #region Organization_data_source_kpi_By_Level
    public class Organization_data_source_kpi_By_Level
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
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

    #region Enums
    public enum Enum_Language
    {
        English = 0,
        French = 1,
        Arabic = 2
    }
    public enum Enum_BR_Codes
    {
        ER_0001, // ACCESS_DENIED
        ER_0002, // SESSION_INVALID
        ER_0003, // SESSION_EXPIRED
        BR_0000, // %1 already exists!
        BR_0001, // %1 With ID %2 Does not Exist!
        BR_0002, // Invalid Ticket!
        BR_0003, // Invalid Email
        BR_0004, // Report Not Found
        BR_0005, // User Not Found
        BR_0006, // Invalid Password! Re-enter and Try Again
        BR_0007, // User Inactive. Please contact support.
        BR_0008, // Email Sending Failed! Check your Email and Try Again.
        BR_0009, // Report Not Found!
        BR_0010, // The chosen organization does not exist.
        BR_0011, // One of the sites chosen does not exist.
        BR_0012, // One of the dimensions chosen does not exist.
        BR_0013, // One of the entities chosen does not exist.
        BR_0014, // The organization does not have access to this site.
        BR_0015, // Invalid Input
        BR_0016, // User does not belong to an organization
        BR_0017, // Organization does not have access to this site.
        BR_0018, // Organization does not have access to this dimension in the site.
        BR_0019, // The organization does not have access to this entity.
        BR_0020, // The user does not have access to this entity.
        BR_0021, // Organization not found.
        BR_0022, // You do not have access to this content.
        BR_0023, // You do not belong to an active organization. Please contact support..
        BR_0024, // Site already belongs to an organization.
        BR_0025, // Super Admins can't be deleted.
        BR_0026, // Upload Failed.
        BR_0027, // Delete Failed.
        BR_0028, // Invalid Credentials
        BR_0029, // User ID Cannot be Null!
        BR_0030, // An Error has Occured! Contact Support.
        BR_0031, // No OTP exists for this username. Try again.
        BR_0032, // Codes do not match! Try Again.
        BR_0033, // Only Admins Can Log In.
        BR_0034, // This feature is currently unavailable
        BR_0035, // Max user quota reached
        BR_0036, // Max admin quota reached
        BR_0037, // No LPR Engine Active
        BR_0038, // Invalid Credentials or Connection Url
        BR_0039, // Cannot Access Video AI
        BR_0040, // Video ai asset with Space asset ID %2 not found
        BR_0041, // Your account is deactivated. Please contact support.
        BR_0042, // No FR Engine Active
        BR_0043, // Request is being processed, try again later
        BR_0044, // Data for %1 on date %2 already exists
        BR_0045, // %1 Setup Not Found.
        BR_0046, // %1 Does Not Exist!
        BR_0047, // The user does not have access to any level.
        BR_0048, // Request resulting in error, jobId has been deleted, try again
        BR_0049, // Invalid Cloud Provider
        BR_0050, // Couldn't Retrieve Secret
        BR_0051, // Google API Token not found
        BR_0052, // An error has occured, please try again later
        BR_0053, // Failed to Assign Dates: %1
        BR_0054, // Delete failed for Kpi_chart_configuration: %1
        BR_0055, // Delete failed for Dimension_chart_configuration: %1
        BR_0056, // Delete failed for Specialized_chart_configuration: %1
        BR_0057, // Unable to send OTP. Please contact support.
        BR_0058, // Error in parsing the CSV file.
    }
    public enum Enum_Edit_Mode
    {
        Add,
        Update
    }
    #endregion
    public partial class BLC
    {
        #region Members
        public DALC.IDALC _AppContext { get; set; }
        public List<Message> oList_Message { get; set; }
        public BLC_Initializer oBLC_Initializer { get; set; }
        #endregion

    }
    #region Message
    public partial class Message
    {
        #region Properties
        public string Code { get; set; }
        public string Content { get; set; }
        #endregion
    }
    #endregion
    #region BLC_Initializer
    public partial class BLC_Initializer
    {
        #region Properties
        public long? User_ID { get; set; }
        public int? Owner_ID { get; set; }
        public Enum_Language Language { get; set; }
        public string Connection_String { get; set; }
        public string Messages_File_Path { get; set; }
        #endregion
    }
    #endregion
}