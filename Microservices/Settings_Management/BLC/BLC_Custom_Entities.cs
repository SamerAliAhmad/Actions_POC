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
        public static string Assets_Default_Image_Path = ConfigurationManager.AppSettings["ASSETS_DEFAULT_IMAGE_PATH"];
    }
    #region Initial_Districtnex_UI_Settings
    public partial class Initial_Districtnex_UI_Settings
    {
        public string BUILD_NUMBER { get; set; }
        public Default_settings Default_settings { get; set; }
    }
    #endregion
    #region Initial_Districtnex_Admin_Settings
    public partial class Initial_Districtnex_Admin_Settings
    {
        public string BUILD_NUMBER { get; set; }
        public Default_settings Default_settings { get; set; }
    }
    #endregion
    #region Uploaded Images
    #region Organization_image
    public partial class Organization_image
    {
        public string IMAGE_GCP_URL { get; set; }
    }
    public partial class Organization
    {
        public string DARK_RECTANGLE_LOGO_URL { get; set; }
        public string DARK_SQUARE_LOGO_URL { get; set; }
        public string LIGHT_RECTANGLE_LOGO_URL { get; set; }
        public string LIGHT_SQUARE_LOGO_URL { get; set; }
        public string ORGANIZATION_FAVICON_URL { get; set; }
    }
    public partial class Default_settings
    {
        public string DARK_RECTANGLE_LOGO_URL { get; set; }
        public string DARK_SQUARE_LOGO_URL { get; set; }
        public string LIGHT_RECTANGLE_LOGO_URL { get; set; }
        public string LIGHT_SQUARE_LOGO_URL { get; set; }
        public string ORGANIZATION_FAVICON_URL { get; set; }
    }
    #endregion
    #region Default Settings Image Extra Entities
    public partial class Default_settings_image
    {
        public string IMAGE_GCP_URL { get; set; }
    }
    #endregion
    #endregion

    #region Kpi_chart_configuration
    public partial class Kpi_chart_configuration
    {
        public string KPI_CHART_CONFIGURATION_ID { get; set; }
        public int? KPI_ID { get; set; }
        public long? POSITION_SETUP_ID { get; set; }
        public int? CHART_ORDER { get; set; }
        public List<Setting> LIST_SETTING { get; set; }
        public List<Action_Button> LIST_ACTION_BUTTON { get; set; }
    }

    #endregion
    #region Action_Button
    public class Action_Button
    {
        public string ICON { get; set; }
        public string FUNCTIONALITY { get; set; }
        public string TOOLTIP { get; set; }
    }
    #endregion
    #region Dimension_chart_configuration
    public partial class Dimension_chart_configuration
    {
        public string DIMENSION_CHART_CONFIGURATION_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public long? POSITION_SETUP_ID { get; set; }
        public int? CHART_ORDER { get; set; }
        public List<Setting> LIST_SETTING { get; set; }
    }
    #endregion
    #region Setting
    public partial class Setting
    {
        public string CHART_SETTINGS { get; set; }
        public string SERIES_SETTINGS { get; set; }
        public string ICON { get; set; }
    }
    #endregion
    #region Specialized_chart_configuration
    public partial class Specialized_chart_configuration
    {
        public string SPECIALIZED_CHART_CONFIGURATION_ID { get; set; }
        public string MODULE { get; set; }
        public string NAME { get; set; }
        public string TYPE { get; set; }
        public string CHART_SETTINGS { get; set; }
        public string SERIES_SETTINGS { get; set; }
    }
    #endregion
    #region Build_Version_List_With_Logs
    public partial class Build_Version_List_With_Logs
    {
        public List<Build_version> LIST_BUILD_VERSION { get; set; }
        public Setup_category BUILD_LOG_TYPE_SETUP_CATEGORY { get; set; }
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
        public DALC.DALC_MONGODB _MongoDb { get; set; }
        public BLC_Initializer oBLC_Initializer { get; set; }
        #endregion
    }
    #region Message
    public class Message
    {
        #region Properties
        public string Code { get; set; }
        public string Content { get; set; }
        #endregion
    }
    #endregion
    #region BLC_Initializer
    public class BLC_Initializer
    {
        #region Properties
        public long? User_ID { get; set; }
        public int? Owner_ID { get; set; }
        public string Connection_String { get; set; }
        public string Messages_File_Path { get; set; }
        public Enum_Language Language { get; set; }
        #endregion
    }
    #endregion
}