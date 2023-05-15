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
        private string Server = "LOG";
        private readonly string LOG_COLLECTION = "LOG";
        public DALC_MONGODB(string server, string database)
        {
            this.Server = server;
            var client = new MongoClient(server);
            this.db = client.GetDatabase(database);
        }
        #region Logs
        #region Delete_Log
        public void Delete_Log()
        {
            try
            {
                var collection = this.db.GetCollection<Log>(LOG_COLLECTION);
                collection.DeleteMany(Builders<Log>.Filter.Empty);
            }
            catch (Exception)
            {
                throw new Exception("Failed to delete documents");
            }
        }
        #endregion
        #region Edit_Log_List
        public void Edit_Log_List(List<Log> i_List_Log)
        {
            try
            {
                var collection = this.db.GetCollection<Log>(LOG_COLLECTION);
                List<Log> oList_Log_To_Insert = i_List_Log.Where(log => log.LOG_ID == null).ToList();
                List<Log> oList_Log_To_Update = i_List_Log.Where(log => log.LOG_ID != null).ToList();
                if (oList_Log_To_Insert.Count() > 0)
                {
                    collection.InsertMany(oList_Log_To_Insert);
                }
                foreach (Log log in oList_Log_To_Update)
                {
                    collection.ReplaceOne(log_To_Replace => log_To_Replace.LOG_ID == log.LOG_ID, log, new ReplaceOptions() { IsUpsert = true });
                }
            }
            catch (Exception)
            {
                throw new Exception("Edit failed for one or more documents");
            }
        }
        #endregion
        #region Get_Logs_Filter
        public FilterDefinition<Log> Get_Logs_Filter(List<string> LOG_ID_LIST, List<long?> USER_ID_LIST, List<long?> LOG_TYPE_SETUP_ID_LIST, List<long?> ACCESS_TYPE_SETUP_ID_LIST, List<int?> ENTITY_ID_LIST, List<int?> SITE_ID_LIST, List<string> MESSAGE_LIST, DateTime? ENTRY_DATE_START, DateTime? ENTRY_DATE_END, List<int?> ORGANIZATION_ID_LIST, List<int?> VIDEO_AI_ASSET_ID_LIST)
        {
            var builder = Builders<Log>.Filter;
            var mainFilter = builder.Empty;
            if (LOG_ID_LIST != null && LOG_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(log => log.LOG_ID, LOG_ID_LIST);
            }
            if (USER_ID_LIST != null && USER_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(log => log.USER_ID, USER_ID_LIST);
            }
            if (LOG_TYPE_SETUP_ID_LIST != null && LOG_TYPE_SETUP_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(log => log.LOG_TYPE_SETUP_ID, LOG_TYPE_SETUP_ID_LIST);
            }
            if (ACCESS_TYPE_SETUP_ID_LIST != null && ACCESS_TYPE_SETUP_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(log => log.ACCESS_TYPE_SETUP_ID, ACCESS_TYPE_SETUP_ID_LIST);
            }
            if (ENTITY_ID_LIST != null && ENTITY_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(log => log.ENTITY_ID, ENTITY_ID_LIST);
            }
            if (SITE_ID_LIST != null && SITE_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(log => log.SITE_ID, SITE_ID_LIST);
            }
            if (MESSAGE_LIST != null && MESSAGE_LIST.Count > 0)
            {
                mainFilter &= builder.In(log => log.MESSAGE, MESSAGE_LIST);
            }
            if (ORGANIZATION_ID_LIST != null && ORGANIZATION_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(log => log.ORGANIZATION_ID, ORGANIZATION_ID_LIST);
            }
            if (ENTRY_DATE_START != null)
            {
                DateTime Entry_Date_Start = new DateTime(((DateTime)ENTRY_DATE_START).Year, ((DateTime)ENTRY_DATE_START).Month, ((DateTime)ENTRY_DATE_START).Day, ((DateTime)ENTRY_DATE_START).Hour, ((DateTime)ENTRY_DATE_START).Minute, ((DateTime)ENTRY_DATE_START).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(log => log.ENTRY_DATE, Entry_Date_Start);
            }
            if (ENTRY_DATE_END != null)
            {
                DateTime Entry_Date_End = new DateTime(((DateTime)ENTRY_DATE_END).Year, ((DateTime)ENTRY_DATE_END).Month, ((DateTime)ENTRY_DATE_END).Day, ((DateTime)ENTRY_DATE_END).Hour, ((DateTime)ENTRY_DATE_END).Minute, ((DateTime)ENTRY_DATE_END).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(log => log.ENTRY_DATE, Entry_Date_End);
            }
            if (VIDEO_AI_ASSET_ID_LIST != null && VIDEO_AI_ASSET_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(log => log.VIDEO_AI_ASSET_ID, VIDEO_AI_ASSET_ID_LIST);
            }
            return mainFilter;
        }
        #endregion
        #region Get_Logs_By_Where
        public List<Log> Get_Logs_By_Where(List<string> LOG_ID_LIST, List<long?> USER_ID_LIST, List<long?> LOG_TYPE_SETUP_ID_LIST, List<long?> ACCESS_TYPE_SETUP_ID_LIST, List<int?> ENTITY_ID_LIST, List<int?> SITE_ID_LIST, List<string> MESSAGE_LIST, DateTime? ENTRY_DATE_START, DateTime? ENTRY_DATE_END, List<int?> ORGANIZATION_ID_LIST, List<int?> VIDEO_AI_ASSET_ID_LIST)
        {
            var mainFilter = Get_Logs_Filter
            (
                LOG_ID_LIST: LOG_ID_LIST,
                USER_ID_LIST: USER_ID_LIST,
                SITE_ID_LIST: SITE_ID_LIST,
                MESSAGE_LIST: MESSAGE_LIST,
                ENTITY_ID_LIST: ENTITY_ID_LIST,
                ENTRY_DATE_END: ENTRY_DATE_END,
                ENTRY_DATE_START: ENTRY_DATE_START,
                ORGANIZATION_ID_LIST: ORGANIZATION_ID_LIST,
                VIDEO_AI_ASSET_ID_LIST: VIDEO_AI_ASSET_ID_LIST,
                LOG_TYPE_SETUP_ID_LIST: LOG_TYPE_SETUP_ID_LIST,
                ACCESS_TYPE_SETUP_ID_LIST: ACCESS_TYPE_SETUP_ID_LIST
            );
            try
            {
                return this.db.GetCollection<Log>(LOG_COLLECTION).Find(mainFilter).ToList();
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #region Get_Logs_By_Where_Sorted_With_Pagination
        public Log_With_Count Get_Logs_By_Where_Sorted_With_Pagination(List<string> LOG_ID_LIST, List<long?> USER_ID_LIST, List<long?> LOG_TYPE_SETUP_ID_LIST, List<long?> ACCESS_TYPE_SETUP_ID_LIST, List<int?> ENTITY_ID_LIST, List<int?> SITE_ID_LIST, List<string> MESSAGE_LIST, DateTime? ENTRY_DATE_START, DateTime? ENTRY_DATE_END, List<int?> ORGANIZATION_ID_LIST, List<int?> VIDEO_AI_ASSET_ID_LIST, int? START_ROW = null, int? END_ROW = null)
        {
            if (START_ROW == null)
            {
                START_ROW = 0;
            }
            if (END_ROW == null)
            {
                END_ROW = 20;
            }
            var mainFilter = Get_Logs_Filter
            (
                LOG_ID_LIST: LOG_ID_LIST,
                USER_ID_LIST: USER_ID_LIST,
                SITE_ID_LIST: SITE_ID_LIST,
                MESSAGE_LIST: MESSAGE_LIST,
                ENTITY_ID_LIST: ENTITY_ID_LIST,
                ENTRY_DATE_END: ENTRY_DATE_END,
                ENTRY_DATE_START: ENTRY_DATE_START,
                ORGANIZATION_ID_LIST: ORGANIZATION_ID_LIST,
                VIDEO_AI_ASSET_ID_LIST: VIDEO_AI_ASSET_ID_LIST,
                LOG_TYPE_SETUP_ID_LIST: LOG_TYPE_SETUP_ID_LIST,
                ACCESS_TYPE_SETUP_ID_LIST: ACCESS_TYPE_SETUP_ID_LIST
            );
            try
            {
                return new Log_With_Count()
                {
                    COUNT = this.db.GetCollection<Log>(LOG_COLLECTION).CountDocuments(mainFilter),
                    List_Log = this.db.GetCollection<Log>(LOG_COLLECTION).Find(mainFilter).SortByDescending(log => log.ENTRY_DATE).Skip(START_ROW).Limit(END_ROW - START_ROW).ToList()
                };
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #endregion
    }
    #region Log
    public partial class Log
    {
        [BsonId]
        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.ObjectId)]
        public string LOG_ID { get; set; }
        public long? USER_ID { get; set; }
        public long? LOG_TYPE_SETUP_ID { get; set; }
        public long? ACCESS_TYPE_SETUP_ID { get; set; }
        public int? ENTITY_ID { get; set; }
        public int? SITE_ID { get; set; }
        public string MESSAGE { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? ENTRY_DATE { get; set; }
        public int? ORGANIZATION_ID { get; set; }
        public int? VIDEO_AI_ASSET_ID { get; set; }
    }
    #endregion
    #region Log_With_Count
    public partial class Log_With_Count
    {
        public long COUNT { get; set; }
        public List<Log> List_Log { get; set; }
    }
    #endregion
}
