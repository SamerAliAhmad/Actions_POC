using System.Configuration;
using System.Collections.Generic;

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
        public static string Assets_Reports_Path = ConfigurationManager.AppSettings["ASSETS_REPORTS_PATH"];
    }
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
    #region Report_Management
    #region Report_Details
    public class Report_Details
    {
        public List<Kpi_Dialog_Data_By_District> LIST_KPI_DIALOG_DATA_BY_DISTRICT { get; set; }
        public List<Kpi_Dialog_Data_By_Area> LIST_KPI_DIALOG_DATA_BY_AREA { get; set; }
        public List<Kpi_Dialog_Data_By_Site> LIST_KPI_DIALOG_DATA_BY_SITE { get; set; }
        public List<Kpi_Dialog_Data_By_Entity> LIST_KPI_DIALOG_DATA_BY_ENTITY { get; set; }

    }
    #endregion
    #endregion
    #region Asset_definition
    public partial class Asset_definition
    {
        public long? LEVEL_ID { get; set; }
        public List<int?> LIST_ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
    }
    #endregion

    #region Kpi_Dialog_Data_By_District
    public class Kpi_Dialog_Data_By_District
    {
        public long? DISTRICT_ID { get; set; }
        public List<District_Kpi_Dialog_Data> LIST_DISTRICT_KPI_DIALOG_DATA { get; set; }
    }
    #endregion
    #region Kpi_Dialog_Data_By_Area
    public class Kpi_Dialog_Data_By_Area
    {
        public long? AREA_ID { get; set; }
        public List<Area_Kpi_Dialog_Data> LIST_AREA_KPI_DIALOG_DATA { get; set; }
    }
    #endregion
    #region Kpi_Dialog_Data_By_Site
    public class Kpi_Dialog_Data_By_Site
    {
        public long? SITE_ID { get; set; }
        public List<Site_Kpi_Dialog_Data> LIST_SITE_KPI_DIALOG_DATA { get; set; }
    }
    #endregion
    #region Kpi_Dialog_Data_By_Entity
    public class Kpi_Dialog_Data_By_Entity
    {
        public long? ENTITY_ID { get; set; }
        public List<Entity_Kpi_Dialog_Data> LIST_ENTITY_KPI_DIALOG_DATA { get; set; }
    }
    #endregion

    #region Site_Kpi_Dialog_Data
    public class Site_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public Data_point KPI_DATA { get; set; }
    }
    #endregion
    #region Area_Kpi_Dialog_Data
    public class Area_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public Data_point KPI_DATA { get; set; }
    }
    #endregion
    #region District_Kpi_Dialog_Data
    public class District_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public Data_point KPI_DATA { get; set; }
    }
    #endregion
    #region Entity_Kpi_Dialog_Data
    public class Entity_Kpi_Dialog_Data
    {
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public int? KPI_ID { get; set; }
        public string TITLE { get; set; }
        public List<Entity_Data_point> LIST_KPI_DATA { get; set; }
    }
    #endregion

    #region Entity_Data_point
    public class Entity_Data_point
    {
        public long? SEVERITY_TYPE_SETUP_ID { get; set; }
        public long? INCIDENT_CATEGORY_SETUP_ID { get; set; }
        public List<string> LIST_LABEL { get; set; }
        public List<Dataset> LIST_DATASET { get; set; }
    }
    #endregion
    #region Data_point
    public class Data_point
    {
        public List<string> LIST_LABEL { get; set; }
        public List<Dataset> LIST_DATASET { get; set; }
    }
    #endregion
    #region Dataset
    public class Dataset
    {
        public string LABEL { get; set; }
        public List<decimal?> LIST_POINT { get; set; }
        public long? DATA_LEVEL_SETUP_ID { get; set; }
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