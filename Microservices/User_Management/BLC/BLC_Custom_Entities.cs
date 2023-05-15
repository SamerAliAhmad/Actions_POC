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
        public static string Salt = "{0}A[z~{1}U!R@e]S{0}+oF{1}[t~S={1}!O@{1}l]u{1}T[^I~o&{1}!N@{1}s]";
        public static string Assets_Org_Image_Path = ConfigurationManager.AppSettings["ASSETS_ORG_IMAGE_PATH"];
    }
    #region Organization_data_source_kpi_ID_By_Level_ID
    public partial class Organization_data_source_kpi_ID_By_Level_ID
    {
        public long? LEVEL_ID { get; set; }
        public List<Organization_data_source_kpi_Simple> LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE { get; set; }
    }
    #endregion
    #region Level_Kpi
    public class Level_Kpi
    {
        public long? LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public List<int?> LEVEL_KPI_LIST { get; set; }
    }
    #endregion
    #region User_Accessible_Data
    public partial class User_Accessible_Data
    {
        public Organization ORGANIZATION { get; set; }
        public List<long?> LIST_ORGANIZATION_AREA_ID { get; set; }
        public List<long?> LIST_ORGANIZATION_SITE_ID { get; set; }
        public List<long?> LIST_ORGANIZATION_REGION_ID { get; set; }
        public List<long?> LIST_ORGANIZATION_ENTITY_ID { get; set; }
        public List<long?> LIST_ORGANIZATION_DISTRICT_ID { get; set; }
        public List<long?> LIST_ORGANIZATION_TOP_LEVEL_ID { get; set; }
        public List<long?> LIST_USER_AREA_ID { get; set; }
        public List<long?> LIST_USER_SITE_ID { get; set; }
        public List<long?> LIST_USER_REGION_ID { get; set; }
        public List<long?> LIST_USER_ENTITY_ID { get; set; }
        public List<long?> LIST_USER_DISTRICT_ID { get; set; }
        public List<long?> LIST_USER_TOP_LEVEL_ID { get; set; }
        public List<Removed_extrusion> LIST_REMOVED_EXTRUSIONS { get; set; }
        public List<User_districtnex_module> LIST_USER_DISTRICTNEX_MODULE { get; set; }
    }
    #endregion
    #region User_Accessible_Data_With_Level_List
    public class User_Accessible_Data_With_Level_List
    {
        public User_Accessible_Data USER_ACCESSIBLE_DATA { get; set; }
        public User_Accessible_Level_List USER_ACCESSIBLE_LEVEL_LIST { get; set; }
    }
    #endregion
    #region User_Accessible_Level_List
    public class User_Accessible_Level_List
    {
        public string GEOJSON_SRC { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public Upper_Level UPPER_LEVEL { get; set; }
        public List<Dimension_index> LIST_DIMENSION_INDEX { get; set; }
        public List<Level_Dimension_with_Status> LIST_LEVEL_DIMENSION_WITH_STATUS { get; set; }
        public Organization_data_source_kpi_List_By_Top_Level ORGANIZATION_DATA_SOURCE_KPI_LIST_BY_TOP_LEVEL { get; set; }
        public List<Organization_data_source_kpi> ORGANIZATION_DATA_SOURCE_KPI_LIST { get; set; }
        public Accessible_Level_List_By_Top_Level ACCESSIBLE_LEVEL_LIST_BY_TOP_LEVEL { get; set; }
        public List<Accessible_Level_ID_List_By_Top_Level> LIST_ACCESSIBLE_LEVEL_ID_LIST_BY_TOP_LEVEL { get; set; }
    }
    #endregion
    #region Organization_data_source_kpi_Simple
    public class Organization_data_source_kpi_Simple
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
    }
    #endregion
    #region Organization_data_source_kpi_List_By_Top_Level
    public class Organization_data_source_kpi_List_By_Top_Level
    {
        public List<Organization_data_source_kpi_ID_By_Level_ID> LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_DISTRICT { get; set; }
        public List<Organization_data_source_kpi_ID_By_Level_ID> LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_AREA { get; set; }
        public List<Organization_data_source_kpi_ID_By_Level_ID> LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_SITE { get; set; }
        public List<Organization_data_source_kpi_ID_By_Level_ID> LIST_ORGANIZATION_DATA_SOURCE_KPI_SIMPLE_ENTITY { get; set; }
    }
    #endregion
    #region Accessible_Level_List_By_Top_Level
    public class Accessible_Level_List_By_Top_Level
    {
        public Top_level TOP_LEVEL { get; set; }
        public List<District> DISTRICT_LIST { get; set; }
        public List<Area> AREA_LIST { get; set; }
        public List<Site> SITE_LIST { get; set; }
        public List<Entity> ENTITY_LIST { get; set; }
        public List<Entity> INTERSECTION_LIST { get; set; }
    }
    #endregion
    #region Accessible_Level_ID_List_By_Top_Level
    public class Accessible_Level_ID_List_By_Top_Level
    {
        public long? TOP_LEVEL_ID { get; set; }
        public List<long?> DISTRICT_ID_LIST { get; set; }
        public List<long?> AREA_ID_LIST { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public List<long?> ENTITY_ID_LIST { get; set; }
    }
    #endregion
    #region Upper_Level
    public class Upper_Level
    {
        public long? LEVEL_ID { get; set; }
        public string NAME { get; set; }
        public string LOCATION { get; set; }
        public string LOGO_URL { get; set; }
        public string IMAGE_URL { get; set; }
        public decimal? LONGITUDE { get; set; }
        public decimal? LATITUDE { get; set; }
    }
    #endregion
    #region Level_Data
    public class Level_Data
    {
        public string GEOJSON_SRC { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public Upper_Level UPPER_LEVEL { get; set; }
        public List<Dimension_index> LIST_DIMENSION_INDEX { get; set; }
    }
    #endregion
    #region Dimension_Index_With_Simple_Upper_Level
    public class Dimension_Index_With_Simple_Upper_Level
    {
        public Upper_Level FATHER_UPPER_LEVEL { get; set; }
        public Upper_Level GRANDFATHER_UPPER_LEVEL { get; set; }
        public List<Dimension_index> LIST_UPPER_LEVEL_DIMENSION_INDEX { get; set; }
        public List<Dimension_index> LIST_SELECTED_LEVEL_DIMENSION_INDEX { get; set; }
    }
    #endregion
    #region Level_Dimension_with_Status
    public class Level_Dimension_with_Status
    {
        public List<long?> LEVEL_ID_LIST { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
        public Dimension DIMENSION { get; set; }
        public Enum_Dimension_Status ENUM_DIMENSION_STATUS { get; set; }
    }
    #endregion
    #region LEVEL_ID_with_DATA_LEVEL_SETUP_ID
    public class LEVEL_ID_with_DATA_LEVEL_SETUP_ID
    {
        public long? LEVEL_ID { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
    }
    #endregion
    #region Admin_Data
    public partial class Admin_Data
    {
        public int NUMBER_OF_USERS { get; set; }
        public List<Site> List_Site { get; set; }
        public List<Entity> List_Entity { get; set; }
        public Organization Organization { get; set; }
        public List<Dimension> List_Dimension { get; set; }
        public List<Setup_category> List_Setup_category { get; set; }
        public List<Districtnex_module> List_Districtnex_module { get; set; }
    }
    #endregion
    #region Dimension_index
    public class Dimension_index
    {
        public DateTime RECORD_DATE { get; set; }
        public Dimension_metadata DIMENSION_METADATA { get; set; }
        public decimal VALUE { get; set; }
    }
    #endregion
    #region Dimension_metadata
    public class Dimension_metadata
    {
        public int DIMENSION_ID { get; set; }
        public long LEVEL_ID { get; set; }
        public long LEVEL_SETUP_ID { get; set; }
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
    #region Setting
    public partial class Setting
    {
        public string CHART_SETTINGS { get; set; }
        public string SERIES_SETTINGS { get; set; }
        public string ICON { get; set; }
    }
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
    #region Initial_Data
    public class Initial_Data
    {
        public List<Dimension_chart_configuration> LIST_DIMENSION_CHART_CONFIGURATION { get; set; }
        public List<Kpi_chart_configuration> LIST_KPI_CHART_CONFIGURATION { get; set; }
        public List<Specialized_chart_configuration> LIST_SPECIALIZED_CHART_CONFIGURATION { get; set; }
        public List<Setup_category> LIST_SETUP_CATEGORY { get; set; }
        public List<User_districtnex_module> LIST_USER_DISTRICT_NEX_MODULE { get; set; }
        public List<Organization_color_scheme> LIST_ORGANIZATION_COLOR_SCHEME { get; set; }
        public List<Niche_categories> LIST_NICHE_CATEGORIES { get; set; }
        public User_theme USER_THEME { get; set; }
        public List<Organization_Data_with_Accessible_Top_Level_Data> LIST_ORGANIZATION_DATA_WITH_ACCESSIBLE_TOP_LEVEL_DATA { get; set; }
    }
    #endregion
    #region Niche_categories
    public partial class Niche_categories
    {
        public string NICHE_CATEGORIES_ID { get; set; }
        public string BUSINESS_NICHE { get; set; }
        public List<string> CATEGORY_LIST { get; set; }
        public string NICHE_COLOR { get; set; }
    }
    #endregion
    #region Organization_image
    public partial class Organization_image
    {
        public string IMAGE_GCP_URL { get; set; }
    }
    #endregion
    #region Organization
    public partial class Organization
    {
        public string DARK_RECTANGLE_LOGO_URL { get; set; }
        public string DARK_SQUARE_LOGO_URL { get; set; }
        public string LIGHT_RECTANGLE_LOGO_URL { get; set; }
        public string LIGHT_SQUARE_LOGO_URL { get; set; }
        public string ORGANIZATION_FAVICON_URL { get; set; }
    }
    #endregion
    #region Organization_Data_with_Accessible_Top_Level_Data
    public class Organization_Data_with_Accessible_Top_Level_Data
    {
        public Organization_Data ORGANIZATION_DATA { get; set; }
        public List<Top_Level_Data> LIST_TOP_LEVEL_DATA { get; set; }
    }
    #endregion
    #region Organization_Data
    public class Organization_Data
    {
        public int? ORGANIZATION_ID { get; set; }
        public string ORGANIZATION_NAME { get; set; }
        public string DARK_RECTANGLE_LOGO_URL { get; set; }
        public string DARK_SQUARE_LOGO_URL { get; set; }
        public string LIGHT_RECTANGLE_LOGO_URL { get; set; }
        public string LIGHT_SQUARE_LOGO_URL { get; set; }
        public string ORGANIZATION_FAVICON_URL { get; set; }
        public List<Organization_color_scheme> LIST_ORGANIZATION_COLOR_SCHEME { get; set; }
        public List<Organization_theme> LIST_ORGANIZATION_THEME { get; set; }
    }
    #endregion
    #region Top_Level_Data
    public class Top_Level_Data
    {
        public long? TOP_LEVEL_ID { get; set; }
        public string TOP_LEVEL_NAME { get; set; }
        public string IMAGE_URL { get; set; }
        public string LOGO_URL { get; set; }
    }
    #endregion
    #region Enums
    public enum Enum_Language
    {
        English = 0,
        French = 1,
        Arabic = 2
    }

    public enum Enum_Dimension_Status
    {
        ENABLED = 0,
        DISABLED = 1,
        HIDDEN = 2
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
    public enum Enum_Timespan
    {
        X_HOURLY_COLLECTION,
        X_DAILY_COLLECTION,
        X_WEEKLY_COLLECTION,
        X_MONTHLY_COLLECTION,
        X_QUARTERLY_COLLECTION
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