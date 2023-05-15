using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Text.Json.Serialization;

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
        public static string Telus_Scope = ConfigurationManager.AppSettings["TELUS_SCOPE"];
        public static string Assets_Endpoint = ConfigurationManager.AppSettings["ASSETS_ENDPOINT"];
        public static string Telus_Client_Id = ConfigurationManager.AppSettings["TELUS_CLIENT_ID"];
        public static string Edmonton_Api_Key = ConfigurationManager.AppSettings["EDMONTON_API_KEY"];
        public static string Telus_Customer_Id = ConfigurationManager.AppSettings["TELUS_CUSTOMER_ID"];
        public static string Telus_Client_Secret = ConfigurationManager.AppSettings["TELUS_CLIENT_SECRET"];
    }
    #region Job
    public partial class Job
    {
        public string JOB_ID { get; set; }
        public string JOB_REQUEST_ID { get; set; }
        public long? REQUEST_SETUP_ID { get; set; }
        public int? DWELL_TIME_BUCKET { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public int? MIN_DWELL_TIME { get; set; }
        public int? MAX_DWELL_TIME { get; set; }
        public bool? IS_EXCLUDE_NON_WORKERS { get; set; }
        public DateTime? START_DATE { get; set; }
        public DateTime? END_DATE { get; set; }
    }
    #endregion
    #region Google_Places_Api_Response
    public partial class Google_Places_Api_Response
    {
        [JsonPropertyName("html_attributions")]
        public List<object> HTML_ATTRIBUTIONS { get; set; }

        [JsonPropertyName("next_page_token")]
        public string NEXT_PAGE_TOKEN { get; set; }

        [JsonPropertyName("results")]
        public List<Business_Api_Response> Results { get; set; }

        [JsonPropertyName("status")]
        public string STATUS { get; set; }
    }
    public partial class Business_Api_Response
    {
        [JsonPropertyName("geometry")]
        public Geometry_Api_Response Geometry { get; set; }

        [JsonPropertyName("icon")]
        public string ICON { get; set; }

        [JsonPropertyName("icon_background_color")]
        public string ICON_BACKGROUND_COLOR { get; set; }

        [JsonPropertyName("icon_mask_base_uri")]
        public string ICON_MASK_BASE_URI { get; set; }

        [JsonPropertyName("name")]
        public string NAME { get; set; }

        [JsonPropertyName("photos")]
        public List<Photo_Api_Response> Photos { get; set; }

        [JsonPropertyName("place_id")]
        public string PLACE_ID { get; set; }

        [JsonPropertyName("reference")]
        public string REFERENCE { get; set; }

        [JsonPropertyName("scope")]
        public string SCOPE { get; set; }

        [JsonPropertyName("types")]
        public List<string> Types { get; set; }

        [JsonPropertyName("vicinity")]
        public string VICINITY { get; set; }

        [JsonPropertyName("business_status")]
        public string BUSINESS_STATUS { get; set; }

        [JsonPropertyName("plus_code")]
        public Plus_Code_Api_Response Plus_Code { get; set; }

        [JsonPropertyName("rating")]
        public decimal? RATING { get; set; }

        [JsonPropertyName("user_ratings_total")]
        public long? USER_RATINGS_TOTAL { get; set; }

        [JsonPropertyName("opening_hours")]
        public Opening_Hours_Api_Response Opening_Hours { get; set; }

        [JsonPropertyName("price_level")]
        public long? PRICE_LEVEL { get; set; }
    }

    public partial class Geometry_Api_Response
    {
        [JsonPropertyName("location")]
        public Location_Api_Response Location { get; set; }

        [JsonPropertyName("viewport")]
        public Viewport_Api_Response Viewport { get; set; }
    }

    public partial class Location_Api_Response
    {
        [JsonPropertyName("lat")]
        public decimal LAT { get; set; }

        [JsonPropertyName("lng")]
        public decimal LNG { get; set; }
    }

    public partial class Viewport_Api_Response
    {
        [JsonPropertyName("northeast")]
        public Location_Api_Response Northeast_Location { get; set; }

        [JsonPropertyName("southwest")]
        public Location_Api_Response Southwest_Location { get; set; }
    }

    public partial class Opening_Hours_Api_Response
    {
        [JsonPropertyName("open_now")]
        public bool OPEN_NOW { get; set; }
    }

    public partial class Photo_Api_Response
    {
        [JsonPropertyName("height")]
        public long HEIGHT { get; set; }

        [JsonPropertyName("html_attributions")]
        public List<string> HTML_ATTRIBUTIONS { get; set; }

        [JsonPropertyName("photo_reference")]
        public string PHOTO_REFERENCE { get; set; }

        [JsonPropertyName("width")]
        public long WIDTH { get; set; }
    }

    public partial class Plus_Code_Api_Response
    {
        [JsonPropertyName("compound_code")]
        public string COMPOUND_CODE { get; set; }

        [JsonPropertyName("global_code")]
        public string GLOBAL_CODE { get; set; }
    }
    #endregion


    #region Visitor_Data_Api_Response
    public partial class Visitor_Data_Api_Response
    {
        [JsonProperty("job_id")]
        public string JobId { get; set; }

        [JsonProperty("api")]
        public string Api { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("input_params")]
        public InputParams_Api_Response InputParams { get; set; }

        [JsonProperty("created_date")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("study_zones")]
        public List<StudyZone_Api_Response> StudyZones { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }

    public partial class InputParams_Api_Response
    {
        [JsonProperty("time_bucket_size")]
        public long TimeBucketSize { get; set; }

        [JsonProperty("input_geoid")]
        public InputGeoid_Api_Response InputGeoid { get; set; }

        [JsonProperty("end_time")]
        public DateTimeOffset EndTime { get; set; }

        [JsonProperty("min_dwell_time")]
        public long MinDwellTime { get; set; }

        [JsonProperty("start_time")]
        public DateTimeOffset StartTime { get; set; }

        [JsonProperty("max_dwell_time")]
        public long MaxDwellTime { get; set; }

        [JsonProperty("estimation_only")]
        public bool EstimationOnly { get; set; }
    }

    public partial class InputGeoid_Api_Response
    {
        [JsonProperty("study_zone")]
        [Newtonsoft.Json.JsonConverter(typeof(DecodeArrayConverter))]
        public List<long> StudyZone { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }

    public partial class StudyZone_Api_Response
    {
        [JsonProperty("input_geoid")]
        public string InputGeoid { get; set; }

        [JsonProperty("buckets")]
        public List<Bucket_Api_Response> Buckets { get; set; }
    }

    public partial class Bucket_Api_Response
    {
        [JsonProperty("timeframe_bucket")]
        public DateTimeOffset TimeframeBucket { get; set; }

        [JsonProperty("count")]
        public long Count { get; set; }
    }

    public partial class Visitor_Data_Api_Response
    {
        public static Visitor_Data_Api_Response FromJson(string json) => JsonConvert.DeserializeObject<Visitor_Data_Api_Response>(json, Converter.Settings);
    }
    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
    internal class DecodeArrayConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(List<long>);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            reader.Read();
            var value = new List<long>();
            while (reader.TokenType != JsonToken.EndArray)
            {
                var converter = ParseStringConverter.Singleton;
                var arrayItem = (long)converter.ReadJson(reader, typeof(long), null, serializer);
                value.Add(arrayItem);
                reader.Read();
            }
            return value;
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (List<long>)untypedValue;
            writer.WriteStartArray();
            foreach (var arrayItem in value)
            {
                var converter = ParseStringConverter.Singleton;
                converter.WriteJson(writer, arrayItem, serializer);
            }
            writer.WriteEndArray();
            return;
        }

        public static readonly DecodeArrayConverter Singleton = new DecodeArrayConverter();
    }
    internal class ParseStringConverter : Newtonsoft.Json.JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
    #endregion
    #region Demographic_Data_Api_Response
    public partial class Demographic_Data_Api_Response
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("study_zones")]
        public List<StudyZone_Api_Response> StudyZones { get; set; }
    }

    public partial class StudyZone_Api_Response
    {
        [JsonProperty("topics")]
        public List<Topic_Api_Response> Topics { get; set; }
    }

    public partial class Topic_Api_Response
    {
        [JsonProperty("topic")]
        public string Topic { get; set; }

        [JsonProperty("characteristics")]
        public List<Characteristic_Api_Response> Characteristics { get; set; }
    }

    public partial class Characteristic_Api_Response
    {
        [JsonProperty("characteristic")]
        public string Characteristic { get; set; }

        [JsonProperty("percentage")]
        public decimal? Percentage { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }

    public partial class Demographic_Data_Api_Response
    {
        public static Demographic_Data_Api_Response FromJson(string json) => JsonConvert.DeserializeObject<Demographic_Data_Api_Response>(json, Converter.Settings);
    }
    #endregion
    #region Visitor_Activity_Api_Response
    public partial class Visitor_Activity_Api_Response
    {
        [JsonProperty("requestId")]
        public string RequestId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("study_zones")]
        public List<StudyZone_Api_Response> StudyZones { get; set; }
    }

    public partial class Bucket_Api_Response
    {
        [JsonProperty("outputs")]
        public List<Output_Api_Response> Outputs { get; set; }
    }

    public partial class Output_Api_Response
    {
        [JsonProperty("count")]
        public long Count { get; set; }

        [JsonProperty("output_geoid")]
        public string OutputGeoid { get; set; }

        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    }

    public partial class Visitor_Activity_Api_Response
    {
        public static Visitor_Activity_Api_Response FromJson(string json) => JsonConvert.DeserializeObject<Visitor_Activity_Api_Response>(json, Converter.Settings);
    }
    #endregion
    #region Visitor_Data
    public partial class Visitor_Data
    {
        public long? TIME_BUCKET_SIZE { get; set; }
        public DateTime? END_TIME { get; set; }
        public string REQUEST_ID { get; set; }
        public DateTime? START_TIME { get; set; }
        public List<Study_zone> LIST_STUDY_ZONE { get; set; }
        public string STATUS { get; set; }
    }

    public partial class Study_zone
    {
        public List<Bucket> List_Bucket { get; set; }
        public string INPUT_GEOID { get; set; }
    }

    public partial class Bucket
    {
        public DateTime? TIMEFRAME_BUCKET { get; set; }
        public long? COUNT { get; set; }
    }
    #endregion
    #region Demographic_Data
    public partial class Demographic_Data
    {
        public long? TIME_BUCKET_SIZE { get; set; }
        public DateTime? END_TIME { get; set; }
        public string REQUEST_ID { get; set; }
        public DateTime? START_TIME { get; set; }
        public List<Study_zone> LIST_STUDY_ZONE { get; set; }
        public string STATUS { get; set; }
    }
    public partial class Study_zone
    {
        public List<Topic> LIST_TOPIC { get; set; }
    }
    public partial class Topic
    {
        public string TOPIC { get; set; }
        public List<Characteristic> LIST_CHARACTERISTIC { get; set; }
    }
    public partial class Characteristic
    {
        public decimal? PERCENTAGE { get; set; }
        public string CHARACTERISTIC { get; set; }
    }
    #endregion
    #region Visitor_Activity
    public partial class Visitor_Activity
    {
        public long? TIME_BUCKET_SIZE { get; set; }
        public DateTime? END_TIME { get; set; }
        public string REQUEST_ID { get; set; }
        public DateTime? START_TIME { get; set; }
        public List<Study_zone> LIST_STUDY_ZONE { get; set; }
        public string STATUS { get; set; }
    }
    public partial class Bucket
    {
        public List<Output> LIST_OUTPUT { get; set; }
    }
    public partial class Output
    {
        public long? COUNT { get; set; }
        public string OUTPUT_GEOID { get; set; }
        public string REQUEST_ID { get; set; }
    }
    #endregion
    #region Telus_Api_Auth_Token
    public partial class Telus_Api_Auth_Token
    {
        public string ACCESS_TOKEN { get; set; }
        public string TOKEN_TYPE { get; set; }
        public int EXPIRES_IN { get; set; }
    }
    #endregion

    #region GeoData
    public partial class GeoData
    {
        public string GEODATA_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Location Location { get; set; }
        public DateTime? DATE_START { get; set; }
        public DateTime? DATE_END { get; set; }
        public List<Data> DATA_LIST { get; set; }
    }
    #endregion
    #region Data
    public partial class Data
    {
        public string NAME { get; set; }
        public string TYPE { get; set; }
        public string VALUE { get; set; }
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
        public long DISTRICT_ID { get; set; }
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
        public long AREA_ID { get; set; }
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
        public long SITE_ID { get; set; }
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
    #region Floor_kpi_data
    public partial class Floor_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Floor_metadata FLOOR_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    #endregion
    #region Floor_metadata
    public partial class Floor_metadata
    {
        public long FLOOR_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
    }
    #endregion
    #region Space_kpi_data
    public partial class Space_kpi_data
    {
        public DateTime RECORD_DATE { get; set; }
        public Space_metadata SPACE_METADATA { get; set; }
        public decimal VALUE { get; set; }
        public decimal? VALUE_PER_SQM { get; set; }
        public string VALUE_NAME { get; set; }
    }
    #endregion
    #region Space_metadata
    public partial class Space_metadata
    {
        public long SPACE_ID { get; set; }
        public long FLOOR_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public string CATEGORY { get; set; }
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

    #region District
    public partial class District
    {
        public List<Area> List_Area { get; set; }
    }
    #endregion
    #region Area
    public partial class Area
    {
        public List<Site> List_Site { get; set; }
    }
    #endregion
    #region Site
    public partial class Site
    {
        public List<Entity> List_Entity { get; set; }
    }
    #endregion
    #region Space
    public partial class Space
    {
        public bool HAS_VIDEO_AI_ASSETS { get; set; }
    }
    #endregion

    #region Alert
    public partial class Alert
    {
        public string ALERT_ID { get; set; }
        public DateTime? RECORD_DATE { get; set; }
        public decimal? ALERT_VALUE { get; set; }
        public decimal? VALUE_PASSED { get; set; }
        public long? VALUE_TYPE_SETUP_ID { get; set; }
        public long? OPERATION_TYPE_SETUP_ID { get; set; }
        public long? USER_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public bool? IS_ACKNOWLEDGED { get; set; }
        public object Object { get; set; }
    }
    #endregion
    #region Level_id_with_percent
    public partial class Level_id_with_percent
    {
        public Site Site { get; set; }
        public Area Area { get; set; }
        public District District { get; set; }
        public long? LEVEL_ID { get; set; }
        public decimal? VALUE { get; set; }
        public decimal? PERCENT_INCREASE { get; set; }
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