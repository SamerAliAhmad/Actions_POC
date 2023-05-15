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
        private readonly string COL_ENTITY_SHARE_DATA_COLLECTION = "COL_ENTITY_SHARE_DATA";
        public DALC_MONGODB(string server, string database)
        {
            var client = new MongoClient(server);
            this.db = client.GetDatabase(database);
        }
        #region Entity_share_data
        #region Delete_Entity_share_data
        public void Delete_Entity_share_data(string UNIQUE_STRING)
        {
            try
            {
                this.db.GetCollection<Entity_share_data>(COL_ENTITY_SHARE_DATA_COLLECTION).DeleteMany(oEntity_share_data => oEntity_share_data.UNIQUE_STRING == UNIQUE_STRING);
            }
            catch (Exception)
            {
                throw new Exception("Delete failed for documents");
            }
        }
        #endregion
        #region Edit_Entity_share_data
        public void Edit_Entity_share_data(Entity_share_data i_Entity_share_data)
        {
            try
            {
                var collection = this.db.GetCollection<Entity_share_data>(COL_ENTITY_SHARE_DATA_COLLECTION);
                if (i_Entity_share_data.ENTITY_SHARE_DATA_ID == null)
                {
                    collection.InsertOne(i_Entity_share_data);
                }
                else
                {
                    collection.ReplaceOne(oEntity_share_data_To_Replace => oEntity_share_data_To_Replace.ENTITY_SHARE_DATA_ID == i_Entity_share_data.ENTITY_SHARE_DATA_ID, i_Entity_share_data, new ReplaceOptions() { IsUpsert = true });
                }
            }
            catch (Exception)
            {
                throw new Exception("Edit failed for one or more document");
            }
        }
        #endregion
        #region Get_Entity_share_data_By_UNIQUE_STRING
        public Entity_share_data Get_Entity_share_data_By_UNIQUE_STRING(string UNIQUE_STRING)
        {
            try
            {
                return this.db.GetCollection<Entity_share_data>(COL_ENTITY_SHARE_DATA_COLLECTION).Find(oEntity_share_data => oEntity_share_data.UNIQUE_STRING == UNIQUE_STRING).FirstOrDefault();
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #endregion
    }
    #region Entities
    #region Entity_share_data
    public partial class Entity_share_data
    {
        [BsonId]
        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ENTITY_SHARE_DATA_ID { get; set; }
        public string SHARING_USER_NAME { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public string UNIQUE_STRING { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? FILTER_START_DATE { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? FILTER_END_DATE { get; set; }
        public Enum_Timespan ENUM_TIMESPAN { get; set; }
        public long? ENTITY_ID { get; set; }
        public long? FLOOR_ID { get; set; }
        public bool? IS_CAMERA_ONE_ON { get; set; }
        public bool? IS_CAMERA_TWO_ON { get; set; }
        public bool? IS_CAMERA_THREE_ON { get; set; }
        public List<Wifi_signal> LIST_FLOOR_ASSET_WIFI_SIGNAL { get; set; }
        public List<Wifi_signal> LIST_FLOOR_CHART_WIFI_SIGNAL { get; set; }
        public List<Wifi_signal> LIST_SUMMARY_WIFI_SIGNAL { get; set; }
        public List<long?> LIST_SUMMARY_SPACE_ASSET_ID { get; set; }
        public List<string> LIST_WIFI_SIGNAL_ALERT_ID { get; set; }
        public int? DIMENSION_ID { get; set; }
        public bool IS_ALERT { get; set; }
        public long? INCIDENT_CATEGORY_SETUP_ID { get; set; }
        public List<string> LIST_INCIDENT_ID { get; set; }
        public List<Dimension_index_By_Level> LIST_FLOOR_DIMENSION_INDEX { get; set; }
        public Dimension_index_By_Level ENTITY_DIMENSION_INDEX { get; set; }
        public List<Level_Dimension_with_Status> LIST_ENTITY_LEVEL_DIMENSION_WITH_STATUS { get; set; }
        public bool? IS_ENTITY_SUMMARY_DRAWER_VISIBLE { get; set; }
    }
    #endregion

    #region Wifi_signal
    #region Wifi_signal
    public partial class Wifi_signal
    {
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? RECORD_DATE { get; set; }
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
        public decimal? VALUE { get; set; }
        public string VALUE_NAME { get; set; }
        public Wifi_signal_Metadata WIFI_SIGNAL_METADATA { get; set; }
    }
    #endregion
    #region Wifi_signal_Metadata
    public partial class Wifi_signal_Metadata
    {
        public long? SPACE_ASSET_ID { get; set; }
        public long? SPACE_ID { get; set; }
        public long? FLOOR_ID { get; set; }
    }
    #endregion
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

    #region Dimension
    public partial class Dimension
    {
        public int? DIMENSION_ID { get; set; }
        public string NAME { get; set; }
        public string DIMENSION_ICON { get; set; }
        public int? DIMENSION_ORDER { get; set; }
        public string ICON_URL { get; set; }
        public string LATEST_DATA_CREATION_DATE { get; set; }
        public long? ENTRY_USER_ID { get; set; }
        public string ENTRY_DATE { get; set; }
        public string LAST_UPDATE { get; set; }
        public bool IS_DELETED { get; set; }
        public int? OWNER_ID { get; set; }
    }
    #endregion
    #region Dimension_index_By_Level
    public class Dimension_index_By_Level
    {
        public long? LEVEL_ID { get; set; }
        public List<Dimension_index> LIST_DIMENSION_INDEX { get; set; }
    }
    #endregion
    #region Dimension_index
    public partial class Dimension_index
    {
        public DateTime RECORD_DATE { get; set; }
        public Dimension_metadata DIMENSION_METADATA { get; set; }
        public decimal VALUE { get; set; }
    }
    #endregion
    #region Dimension_metadata
    public partial class Dimension_metadata
    {
        public int DIMENSION_ID { get; set; }
        public long LEVEL_ID { get; set; }
        public long LEVEL_SETUP_ID { get; set; }
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
    #region Enum_Dimension_Status
    public enum Enum_Dimension_Status
    {
        ENABLED = 0,
        DISABLED = 1,
        HIDDEN = 2
    }
    #endregion
    #endregion
}
