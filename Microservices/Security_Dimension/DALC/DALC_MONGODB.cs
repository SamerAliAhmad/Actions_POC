using System;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace DALC
{
    public partial class DALC_MONGODB
    {
        private IMongoDatabase db;
        private readonly string INCIDENT_COLLECTION = "INCIDENT";
        public DALC_MONGODB(string server, string database)
        {
            var client = new MongoClient(server);
            this.db = client.GetDatabase(database);
        }
        #region Delete_Incident
        public void Delete_Incident()
        {
            try
            {
                var collection = this.db.GetCollection<Incident>(INCIDENT_COLLECTION);
                collection.DeleteMany(Builders<Incident>.Filter.Empty);
            }
            catch (Exception)
            {
                throw new Exception("Failed to delete documents");
            }
        }
        #endregion
        #region Edit_Incident_List
        public void Edit_Incident_List(List<Incident> i_List_Incident)
        {
            try
            {
                var collection = this.db.GetCollection<Incident>(INCIDENT_COLLECTION);
                List<Incident> oList_Incident_To_Insert = i_List_Incident.Where(incident => incident.INCIDENT_ID == null).ToList();
                List<Incident> oList_Incident_To_Update = i_List_Incident.Where(incident => incident.INCIDENT_ID != null).ToList();
                if (oList_Incident_To_Insert.Count() > 0)
                {
                    collection.InsertMany(oList_Incident_To_Insert);
                }
                foreach (Incident incident in oList_Incident_To_Update)
                {
                    collection.ReplaceOne(incident_To_Replace => incident_To_Replace.INCIDENT_ID == incident.INCIDENT_ID, incident, new ReplaceOptions() { IsUpsert = true });
                }
            }
            catch (Exception)
            {
                throw new Exception("Edit failed for one or more documents");
            }
        }
        #endregion
        #region Get_Incidents_Filter
        public FilterDefinition<Incident> Get_Incidents_Filter(List<string> INCIDENT_ID_LIST, List<long?> SPACE_ASSET_ID_LIST, List<long?> SPACE_ID_LIST, List<long?> FLOOR_ID_LIST, List<long?> ENTITY_ID_LIST, List<long?> SITE_ID_LIST, List<int?> DIMENSION_ORDER_LIST, DateTime? CREATED_TIME_START, DateTime? CREATED_TIME_END, DateTime? ASSIGNED_TIME_START, DateTime? ASSIGNED_TIME_END, DateTime? CLOSED_TIME_START, DateTime? CLOSED_TIME_END, List<long?> INCIDENT_CATEGORY_SETUP_ID_LIST)
        {
            var builder = Builders<Incident>.Filter;
            var mainFilter = builder.Empty;
            if (INCIDENT_ID_LIST != null && INCIDENT_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(incident => incident.INCIDENT_ID, INCIDENT_ID_LIST);
            }
            if (SPACE_ASSET_ID_LIST != null && SPACE_ASSET_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(incident => incident.SPACE_ASSET_ID, SPACE_ASSET_ID_LIST);
            }
            if (SPACE_ID_LIST != null && SPACE_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(incident => incident.SPACE_ID, SPACE_ID_LIST);
            }
            if (FLOOR_ID_LIST != null && FLOOR_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(incident => incident.FLOOR_ID, FLOOR_ID_LIST);
            }
            if (ENTITY_ID_LIST != null && ENTITY_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(incident => incident.ENTITY_ID, ENTITY_ID_LIST);
            }
            if (SITE_ID_LIST != null && SITE_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(incident => incident.SITE_ID, SITE_ID_LIST);
            }
            if (DIMENSION_ORDER_LIST != null && DIMENSION_ORDER_LIST.Count > 0)
            {
                mainFilter &= builder.In(incident => incident.DIMENSION_ORDER, DIMENSION_ORDER_LIST);
            }
            if (CREATED_TIME_START != null)
            {
                DateTime Created_Time_Start = new DateTime(((DateTime)CREATED_TIME_START).Year, ((DateTime)CREATED_TIME_START).Month, ((DateTime)CREATED_TIME_START).Day, ((DateTime)CREATED_TIME_START).Hour, ((DateTime)CREATED_TIME_START).Minute, ((DateTime)CREATED_TIME_START).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(incident => incident.CREATED_TIME, Created_Time_Start);
            }
            if (CREATED_TIME_END != null)
            {
                DateTime Created_Time_End = new DateTime(((DateTime)CREATED_TIME_END).Year, ((DateTime)CREATED_TIME_END).Month, ((DateTime)CREATED_TIME_END).Day, ((DateTime)CREATED_TIME_END).Hour, ((DateTime)CREATED_TIME_END).Minute, ((DateTime)CREATED_TIME_END).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(incident => incident.CREATED_TIME, Created_Time_End);
            }
            if (ASSIGNED_TIME_START != null)
            {
                DateTime Assigned_Time_Start = new DateTime(((DateTime)ASSIGNED_TIME_START).Year, ((DateTime)ASSIGNED_TIME_START).Month, ((DateTime)ASSIGNED_TIME_START).Day, ((DateTime)ASSIGNED_TIME_START).Hour, ((DateTime)ASSIGNED_TIME_START).Minute, ((DateTime)ASSIGNED_TIME_START).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(incident => incident.ASSIGNED_TIME, Assigned_Time_Start);
            }
            if (ASSIGNED_TIME_END != null)
            {
                DateTime Assigned_Time_End = new DateTime(((DateTime)ASSIGNED_TIME_END).Year, ((DateTime)ASSIGNED_TIME_END).Month, ((DateTime)ASSIGNED_TIME_END).Day, ((DateTime)ASSIGNED_TIME_END).Hour, ((DateTime)ASSIGNED_TIME_END).Minute, ((DateTime)ASSIGNED_TIME_END).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(incident => incident.ASSIGNED_TIME, Assigned_Time_End);
            }
            if (CLOSED_TIME_START != null)
            {
                DateTime Closed_Time_Start = new DateTime(((DateTime)CLOSED_TIME_START).Year, ((DateTime)CLOSED_TIME_START).Month, ((DateTime)CLOSED_TIME_START).Day, ((DateTime)CLOSED_TIME_START).Hour, ((DateTime)CLOSED_TIME_START).Minute, ((DateTime)CLOSED_TIME_START).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(incident => incident.CLOSED_TIME, Closed_Time_Start);
            }
            if (CLOSED_TIME_END != null)
            {
                DateTime Closed_Time_End = new DateTime(((DateTime)CLOSED_TIME_END).Year, ((DateTime)CLOSED_TIME_END).Month, ((DateTime)CLOSED_TIME_END).Day, ((DateTime)CLOSED_TIME_END).Hour, ((DateTime)CLOSED_TIME_END).Minute, ((DateTime)CLOSED_TIME_END).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(incident => incident.CLOSED_TIME, Closed_Time_End);
            }
            if (INCIDENT_CATEGORY_SETUP_ID_LIST != null && INCIDENT_CATEGORY_SETUP_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(incident => incident.Security_Incident.CATEGORY_SETUP_ID, INCIDENT_CATEGORY_SETUP_ID_LIST);
            }
            return mainFilter;
        }
        #endregion
        #region Get_Incidents_By_Where
        public List<Incident> Get_Incidents_By_Where(List<string> INCIDENT_ID_LIST, List<long?> SPACE_ASSET_ID_LIST, List<long?> SPACE_ID_LIST, List<long?> FLOOR_ID_LIST, List<long?> ENTITY_ID_LIST, List<long?> SITE_ID_LIST, List<int?> DIMENSION_ORDER_LIST, List<long?> SEVERITY_SETUP_ID_LIST, DateTime? CREATED_TIME_START, DateTime? CREATED_TIME_END, DateTime? ASSIGNED_TIME_START, DateTime? ASSIGNED_TIME_END, DateTime? CLOSED_TIME_START, DateTime? CLOSED_TIME_END, List<long?> INCIDENT_CATEGORY_SETUP_ID_LIST)
        {
            try
            {
                var mainFilter = Get_Incidents_Filter(
                    SITE_ID_LIST: SITE_ID_LIST,
                    SPACE_ID_LIST: SPACE_ID_LIST,
                    FLOOR_ID_LIST: FLOOR_ID_LIST,
                    ENTITY_ID_LIST: ENTITY_ID_LIST,
                    CLOSED_TIME_END: CLOSED_TIME_END,
                    CREATED_TIME_END: CREATED_TIME_END,
                    INCIDENT_ID_LIST: INCIDENT_ID_LIST,
                    ASSIGNED_TIME_END: ASSIGNED_TIME_END,
                    CLOSED_TIME_START: CLOSED_TIME_START,
                    CREATED_TIME_START: CREATED_TIME_START,
                    ASSIGNED_TIME_START: ASSIGNED_TIME_START,
                    SPACE_ASSET_ID_LIST: SPACE_ASSET_ID_LIST,
                    DIMENSION_ORDER_LIST: DIMENSION_ORDER_LIST,
                    INCIDENT_CATEGORY_SETUP_ID_LIST: INCIDENT_CATEGORY_SETUP_ID_LIST
                );
                return this.db.GetCollection<Incident>(INCIDENT_COLLECTION).Find(mainFilter).ToList();
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #region Get_Incidents_By_Where_Count
        public long Get_Incidents_By_Where_Count(List<string> INCIDENT_ID_LIST, List<long?> SPACE_ASSET_ID_LIST, List<long?> SPACE_ID_LIST, List<long?> FLOOR_ID_LIST, List<long?> ENTITY_ID_LIST, List<long?> SITE_ID_LIST, List<int?> DIMENSION_ORDER_LIST, List<long?> SEVERITY_SETUP_ID_LIST, DateTime? CREATED_TIME_START, DateTime? CREATED_TIME_END, DateTime? ASSIGNED_TIME_START, DateTime? ASSIGNED_TIME_END, DateTime? CLOSED_TIME_START, DateTime? CLOSED_TIME_END, List<long?> INCIDENT_CATEGORY_SETUP_ID_LIST)
        {
            try
            {
                var mainFilter = Get_Incidents_Filter(
                    SITE_ID_LIST: SITE_ID_LIST,
                    SPACE_ID_LIST: SPACE_ID_LIST,
                    FLOOR_ID_LIST: FLOOR_ID_LIST,
                    ENTITY_ID_LIST: ENTITY_ID_LIST,
                    CLOSED_TIME_END: CLOSED_TIME_END,
                    INCIDENT_ID_LIST: INCIDENT_ID_LIST,
                    CREATED_TIME_END: CREATED_TIME_END,
                    ASSIGNED_TIME_END: ASSIGNED_TIME_END,
                    CLOSED_TIME_START: CLOSED_TIME_START,
                    CREATED_TIME_START: CREATED_TIME_START,
                    ASSIGNED_TIME_START: ASSIGNED_TIME_START,
                    SPACE_ASSET_ID_LIST: SPACE_ASSET_ID_LIST,
                    DIMENSION_ORDER_LIST: DIMENSION_ORDER_LIST,
                    INCIDENT_CATEGORY_SETUP_ID_LIST: INCIDENT_CATEGORY_SETUP_ID_LIST
                );
                return this.db.GetCollection<Incident>(INCIDENT_COLLECTION).CountDocuments(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #region Get_Incidents_By_Where_Sorted_With_Pagination
        public Incident_With_Count Get_Incidents_By_Where_Sorted_With_Pagination(List<string> INCIDENT_ID_LIST, List<long?> SPACE_ASSET_ID_LIST, List<long?> SPACE_ID_LIST, List<long?> FLOOR_ID_LIST, List<long?> ENTITY_ID_LIST, List<long?> SITE_ID_LIST, List<int?> DIMENSION_ORDER_LIST, DateTime? CREATED_TIME_START, DateTime? CREATED_TIME_END, DateTime? ASSIGNED_TIME_START, DateTime? ASSIGNED_TIME_END, DateTime? CLOSED_TIME_START, DateTime? CLOSED_TIME_END, List<long?> INCIDENT_CATEGORY_SETUP_ID_LIST, int? START_ROW = null, int? END_ROW = null)
        {
            if (START_ROW == null)
            {
                START_ROW = 0;
            }
            if (END_ROW == null)
            {
                END_ROW = 20;
            }
            var mainFilter = Get_Incidents_Filter(
                SITE_ID_LIST: SITE_ID_LIST,
                SPACE_ID_LIST: SPACE_ID_LIST,
                FLOOR_ID_LIST: FLOOR_ID_LIST,
                ENTITY_ID_LIST: ENTITY_ID_LIST,
                CLOSED_TIME_END: CLOSED_TIME_END,
                INCIDENT_ID_LIST: INCIDENT_ID_LIST,
                CREATED_TIME_END: CREATED_TIME_END,
                CLOSED_TIME_START: CLOSED_TIME_START,
                ASSIGNED_TIME_END: ASSIGNED_TIME_END,
                CREATED_TIME_START: CREATED_TIME_START,
                SPACE_ASSET_ID_LIST: SPACE_ASSET_ID_LIST,
                ASSIGNED_TIME_START: ASSIGNED_TIME_START,
                DIMENSION_ORDER_LIST: DIMENSION_ORDER_LIST,
                INCIDENT_CATEGORY_SETUP_ID_LIST: INCIDENT_CATEGORY_SETUP_ID_LIST
            );
            try
            {
                return new Incident_With_Count()
                {
                    List_Incident = this.db.GetCollection<Incident>(INCIDENT_COLLECTION).Find(mainFilter).SortByDescending(incident => incident.CREATED_TIME).Skip(START_ROW).Limit(END_ROW - START_ROW).ToList(),
                    COUNT = this.db.GetCollection<Incident>(INCIDENT_COLLECTION).CountDocuments(mainFilter),
                };
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
    }
    #region Incident
    public partial class Incident
    {
        [BsonId]
        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.ObjectId)]
        public string INCIDENT_ID { get; set; }
        public long? SPACE_ASSET_ID { get; set; }
        public long? SPACE_ID { get; set; }
        public long? FLOOR_ID { get; set; }
        public long? ENTITY_ID { get; set; }
        public long? SITE_ID { get; set; }
        public long? SEVERITY_SETUP_ID { get; set; }
        public int? DIMENSION_ORDER { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? CREATED_TIME { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? ASSIGNED_TIME { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? CLOSED_TIME { get; set; }
        public Geo_Location Geo_Location { get; set; }
        public long? SCENE_ID { get; set; }
        public long? VIDEO_AI_INSTANCE_ID { get; set; }
        public Surveillance_Camera_Content CAMERA { get; set; }
        public string BLACKLISTED_PERSON_NAME { get; set; }
        public string BLACKLISTED_LICENSE_PLATE { get; set; }
        public string BLACKLISTED_LICENSE_FILE_URL { get; set; }
        public Sustainability_Incident Sustainability_Incident { get; set; }
        public Security_Incident Security_Incident { get; set; }
        public Mobility_Incident Mobility_Incident { get; set; }
        public Living_Incident Living_Incident { get; set; }
    }
    #endregion
    #region Geo_Location
    public partial class Geo_Location
    {
        public decimal? LATITUDE { get; set; }
        public decimal? LONGITUDE { get; set; }
    }
    #endregion
    #region Living_Incident
    public partial class Living_Incident
    {
        public long? CATEGORY_SETUP_ID { get; set; }
    }
    #endregion
    #region Security_Incident
    public partial class Security_Incident
    {
        public long? CATEGORY_SETUP_ID { get; set; }
    }
    #endregion
    #region Mobility_Incident
    public partial class Mobility_Incident
    {
        public long? CATEGORY_SETUP_ID { get; set; }
    }
    #endregion
    #region Incident_With_Count
    public partial class Incident_With_Count
    {
        public long COUNT { get; set; }
        public List<Incident> List_Incident { get; set; }
    }
    #endregion
    #region Sustainability_Incident
    public partial class Sustainability_Incident
    {
        public long? CATEGORY_SETUP_ID { get; set; }
    }
    #endregion
    #region Surveillance_Camera_Content
    public partial class Surveillance_Camera_Content
    {
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public long CameraId { get; set; }
        public object Nvr { get; set; }
        public object NvrChannel { get; set; }
        public string Name { get; set; }
        public object Ip { get; set; }
        public object Port { get; set; }
        public object Account { get; set; }
        public object Password { get; set; }
        public object Description { get; set; }
        public string StreamUrl { get; set; }
        public RoiContour[] RoiContour { get; set; }
        public object Manufacturer { get; set; }
        public object Model { get; set; }
        public string Resolution { get; set; }
        public long? FrameRate { get; set; }
        public object[] Plugins { get; set; }
        public long AinvrId { get; set; }
        public string Protocol { get; set; }
        public long? EngineProfileId { get; set; }
        public EngineProfile EngineProfile { get; set; }
        public string Status { get; set; }
        public object Latitude { get; set; }
        public object Longitude { get; set; }
        public object GpuId { get; set; }
        public object HwDecode { get; set; }
        public string CscState { get; set; }
        public string LocationType { get; set; }
        public object FloorPlanId { get; set; }
        public object FloorPlanX { get; set; }
        public object FloorPlanY { get; set; }
        public object FloorPlanAngle { get; set; }
        public string[] EngineModels { get; set; }
        public long? Resource { get; set; }
        public Schedule Schedule { get; set; }
        public string CameraType { get; set; }
        public string FpsType { get; set; }
        public long Loop { get; set; }
        public string ExternalMeta { get; set; }
        public string AuthenticatedUrl { get; set; }
    }
    public partial class EngineProfile
    {
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset UpdateDate { get; set; }
        public long EngineProfileId { get; set; }
        public string Name { get; set; }
        public EngineConfig EngineConfig { get; set; }
        public bool IsDefault { get; set; }
        public object Description { get; set; }
        public long[] EngineModelId { get; set; }
        public long AinvrId { get; set; }
    }
    public partial class EngineConfig
    {
        public PluginConfig PluginConfig { get; set; }
        public EngineModelConfigList[] EngineModelConfigList { get; set; }
    }
    public partial class EngineModelConfigList
    {
        public string Type { get; set; }
        public double Confidence { get; set; }
        public long MinObjSize { get; set; }
        public long MaxObjSize { get; set; }
        public bool Enabled { get; set; }
    }
    public partial class PluginConfig
    {
        public long MotionDetectSize { get; set; }
        public double MotionDetectParam { get; set; }
        public double FaceRecognitionSimilarityThreshold { get; set; }
        public long FaceRecognitionMinSize { get; set; }
        public bool EnableFrontalFaceDetection { get; set; }
        public double LicensePlateConfidenceThreshold { get; set; }
        public long LicensePlateMinSize { get; set; }
        public double MakeModelConfidenceThreshold { get; set; }
        public long MakeModelMinSize { get; set; }
        public long AgeGenderMinSize { get; set; }
        public bool EnableAgeGenderQualityDetection { get; set; }
    }
    public partial class RoiContour
    {
        public Contour[] Contour { get; set; }
    }
    public partial class Contour
    {
        public long X { get; set; }
        public long Y { get; set; }
    }
    public partial class Schedule
    {
        public object[] Weekdays { get; set; }
        public bool Forever { get; set; }
    }
    #endregion
}
