using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using System.Linq;
using MongoDB.Bson.Serialization;

namespace DALC
{
    public partial class DALC_MONGODB
    {
        private IMongoDatabase db;
        private readonly string OTP_COLLECTION = "OTP";
        private readonly string JOB_COLLECTION = "JOB";
        private readonly string ALERT_COLLECTION = "COL_ALERT";
        private readonly string GEO_COLLECTION = "COL_GEODATA";
        private readonly string X_HOURLY_COLLECTION = "_HOURLY";
        private readonly string X_DAILY_COLLECTION = "_DAILY";
        private readonly string X_WEEKLY_COLLECTION = "_WEEKLY";
        private readonly string X_MONTHLY_COLLECTION = "_MONTHLY";
        private readonly string X_QUARTERLY_COLLECTION = "_QUARTERLY";
        private readonly string DISTRICT_KPI_DATA_COLLECTION = "COL_DISTRICT_KPI_DATA";
        private readonly string AREA_KPI_DATA_COLLECTION = "COL_AREA_KPI_DATA";
        private readonly string SITE_KPI_DATA_COLLECTION = "COL_SITE_KPI_DATA";
        private readonly string ENTITY_KPI_DATA_COLLECTION = "COL_ENTITY_KPI_DATA";
        private readonly string FLOOR_KPI_DATA_COLLECTION = "COL_FLOOR_KPI_DATA";
        private readonly string SPACE_KPI_DATA_COLLECTION = "COL_SPACE_KPI_DATA";
        private readonly string SITE_GEOJSON_COLLECTION = "COL_SITE_GEOJSON";
        private readonly string AREA_GEOJSON_COLLECTION = "COL_AREA_GEOJSON";
        private readonly string DISTRICT_GEOJSON_COLLECTION = "COL_DISTRICT_GEOJSON";
        private readonly string NICHE_CATEGORIES_COLLECTION = "COL_NICHE_CATEGORIES";

        public DALC_MONGODB(string server, string database)
        {
            var client = new MongoClient(server);
            this.db = client.GetDatabase(database);
        }
        #region GEOJSON
        #region Get_Site_geojson_By_SITE_ID_List
        public List<BsonDocument> Get_Site_geojson_By_SITE_ID_List(List<long?> SITE_ID_List)
        {
            List<BsonDocument> oList_Site_geojson = null;
            if (SITE_ID_List != null || SITE_ID_List.Count > 0)
            {
                var mainFilter = Builders<BsonDocument>.Filter.In("id", SITE_ID_List);
                var mainProject = Builders<BsonDocument>.Projection.Exclude(x => x["_id"]);
                try
                {
                    var collection = this.db.GetCollection<BsonDocument>(SITE_GEOJSON_COLLECTION);
                    var _query_response = collection.Find(mainFilter).Project<BsonDocument>(mainProject).ToEnumerable();
                    oList_Site_geojson = new List<BsonDocument>();
                    if (_query_response != null)
                    {
                        oList_Site_geojson = _query_response.ToList();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Failed to fetch documents");
                }
            }
            return oList_Site_geojson;
        }
        #endregion
        #region Get_Area_geojson_By_AREA_ID_List
        public List<BsonDocument> Get_Area_geojson_By_AREA_ID_List(List<long?> AREA_ID_List)
        {
            List<BsonDocument> oList_Area_geojson = null;
            if (AREA_ID_List != null || AREA_ID_List.Count > 0)
            {
                var mainFilter = Builders<BsonDocument>.Filter.In("id", AREA_ID_List);
                var mainProject = Builders<BsonDocument>.Projection.Exclude(x => x["_id"]);
                try
                {
                    var collection = this.db.GetCollection<BsonDocument>(AREA_GEOJSON_COLLECTION);
                    var _query_response = collection.Find(mainFilter).Project<BsonDocument>(mainProject);
                    oList_Area_geojson = new List<BsonDocument>();
                    if (_query_response != null)
                    {
                        oList_Area_geojson = _query_response.ToList();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Failed to fetch documents");
                }
            }
            return oList_Area_geojson;
        }
        #endregion
        #region Get_District_geojson_By_DISTRICT_ID_List
        public List<BsonDocument> Get_District_geojson_By_DISTRICT_ID_List(List<long?> DISTRICT_ID_List)
        {
            List<BsonDocument> oList_District_geojson = null;
            if (DISTRICT_ID_List != null || DISTRICT_ID_List.Count > 0)
            {
                var mainFilter = Builders<BsonDocument>.Filter.In("id", DISTRICT_ID_List);
                var mainProject = Builders<BsonDocument>.Projection.Exclude(x => x["_id"]);
                try
                {
                    var collection = this.db.GetCollection<BsonDocument>(DISTRICT_GEOJSON_COLLECTION);
                    var _query_response = collection.Find(mainFilter).Project<BsonDocument>(mainProject);
                    oList_District_geojson = new List<BsonDocument>();
                    if (_query_response != null)
                    {
                        oList_District_geojson = _query_response.ToList();
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Failed to fetch documents");
                }
            }
            return oList_District_geojson;
        }
        #endregion
        #region Get_District_geojson
        public List<BsonDocument> Get_District_geojson()
        {
            List<BsonDocument> oList_District_geojson = null;
            var mainFilter = Builders<BsonDocument>.Filter.Empty;
            try
            {
                var collection = this.db.GetCollection<BsonDocument>(DISTRICT_GEOJSON_COLLECTION);
                var _query_response = collection.Find(mainFilter);
                oList_District_geojson = new List<BsonDocument>();
                if (_query_response != null)
                {
                    oList_District_geojson = _query_response.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_District_geojson;
        }
        #endregion
        #region Get_Area_geojson
        public List<BsonDocument> Get_Area_geojson()
        {
            List<BsonDocument> oList_Area_geojson = null;
            var mainFilter = Builders<BsonDocument>.Filter.Empty;
            try
            {
                var collection = this.db.GetCollection<BsonDocument>(AREA_GEOJSON_COLLECTION);
                var _query_response = collection.Find(mainFilter);
                oList_Area_geojson = new List<BsonDocument>();
                if (_query_response != null)
                {
                    oList_Area_geojson = _query_response.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Area_geojson;
        }
        #endregion
        #endregion

        #region Otp
        #region Update_Otp_Index
        public void Update_Otp_Index(int? OTP_TTL_IN_SECONDS)
        {
            string Entry_Date_TTL_Index_Name = "Entry Date TTL";
            var collection = this.db.GetCollection<Otp>(OTP_COLLECTION);
            var indexKeysDefinition = Builders<Otp>.IndexKeys.Ascending(otp => otp.ENTRY_DATE);
            var indexOptions = new CreateIndexOptions<Otp>()
            {
                Name = Entry_Date_TTL_Index_Name,
                ExpireAfter = new TimeSpan(0, 0, OTP_TTL_IN_SECONDS.Value)
            };
            try
            {
                collection.Indexes.CreateOne(new CreateIndexModel<Otp>(indexKeysDefinition, indexOptions));
            }
            catch
            {
                collection.Indexes.DropOne(Entry_Date_TTL_Index_Name);
                collection.Indexes.CreateOne(new CreateIndexModel<Otp>(indexKeysDefinition, indexOptions));
            }
        }
        #endregion
        #endregion

        #region Job
        #region Delete_Job
        public void Delete_Job(List<string> JOB_ID_LIST, List<long?> REQUEST_SETUP_ID_LIST, List<int?> DWELL_TIME_BUCKET_LIST, List<long?> SITE_ID_LIST, List<int?> MIN_DWELL_TIME_LIST, List<int?> MAX_DWELL_TIME_LIST, DateTime? START_DATE, DateTime? END_DATE, bool? IS_EXCLUDE_NON_WORKERS, string JOB_REQUEST_ID)
        {
            var mainFilter = Get_Jobs_Filter(
                END_DATE: END_DATE,
                START_DATE: START_DATE,
                JOB_ID_LIST: JOB_ID_LIST,
                SITE_ID_LIST: SITE_ID_LIST,
                JOB_REQUEST_ID: JOB_REQUEST_ID,
                MIN_DWELL_TIME_LIST: MIN_DWELL_TIME_LIST,
                MAX_DWELL_TIME_LIST: MAX_DWELL_TIME_LIST,
                IS_EXCLUDE_NON_WORKERS: IS_EXCLUDE_NON_WORKERS,
                DWELL_TIME_BUCKET_LIST: DWELL_TIME_BUCKET_LIST,
                REQUEST_SETUP_ID_LIST: REQUEST_SETUP_ID_LIST
            );
            try
            {
                this.db.GetCollection<Job>(JOB_COLLECTION).DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Failed to delete documents");
            }
        }
        #endregion
        #region Edit_Job_List
        public void Edit_Job_List(List<Job> i_List_Job)
        {
            try
            {
                var collection = this.db.GetCollection<Job>(JOB_COLLECTION);
                List<Job> oList_Job_To_Insert = i_List_Job.Where(job => job.JOB_ID == null).ToList();
                List<Job> oList_Job_To_Update = i_List_Job.Where(job => job.JOB_ID != null).ToList();
                if (oList_Job_To_Insert.Count > 0)
                {
                    collection.InsertMany(oList_Job_To_Insert);
                }
                foreach (Job job in oList_Job_To_Update)
                {
                    collection.ReplaceOne(job_To_Replace => job_To_Replace.JOB_ID == job.JOB_ID, job, new ReplaceOptions() { IsUpsert = true });
                }
            }
            catch (Exception)
            {
                throw new Exception("Edit failed for one or more documents");
            }
        }
        #endregion
        #region Get_Jobs_Filter
        public FilterDefinition<Job> Get_Jobs_Filter(List<string> JOB_ID_LIST, List<long?> REQUEST_SETUP_ID_LIST, List<int?> DWELL_TIME_BUCKET_LIST, List<long?> SITE_ID_LIST, List<int?> MIN_DWELL_TIME_LIST, List<int?> MAX_DWELL_TIME_LIST, DateTime? START_DATE, DateTime? END_DATE, bool? IS_EXCLUDE_NON_WORKERS, string JOB_REQUEST_ID)
        {
            var builder = Builders<Job>.Filter;
            var mainFilter = builder.Empty;
            if (JOB_ID_LIST != null && JOB_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(job => job.JOB_ID, JOB_ID_LIST);
            }
            if (JOB_REQUEST_ID != null)
            {
                mainFilter &= builder.Eq(job => job.JOB_REQUEST_ID, JOB_REQUEST_ID);
            }
            if (REQUEST_SETUP_ID_LIST != null && REQUEST_SETUP_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(job => job.REQUEST_SETUP_ID, REQUEST_SETUP_ID_LIST);
            }
            if (DWELL_TIME_BUCKET_LIST != null && DWELL_TIME_BUCKET_LIST.Count > 0)
            {
                mainFilter &= builder.In(job => job.DWELL_TIME_BUCKET, DWELL_TIME_BUCKET_LIST);
            }
            if (SITE_ID_LIST != null && SITE_ID_LIST.Count > 0)
            {
                mainFilter &= builder.All(job => job.SITE_ID_LIST, SITE_ID_LIST);
            }
            if (MIN_DWELL_TIME_LIST != null && MIN_DWELL_TIME_LIST.Count > 0)
            {
                mainFilter &= builder.In(job => job.MIN_DWELL_TIME, MIN_DWELL_TIME_LIST);
            }
            if (MAX_DWELL_TIME_LIST != null && MAX_DWELL_TIME_LIST.Count > 0)
            {
                mainFilter &= builder.In(job => job.MAX_DWELL_TIME, MAX_DWELL_TIME_LIST);
            }
            if (IS_EXCLUDE_NON_WORKERS != null)
            {
                mainFilter &= builder.Eq(job => job.IS_EXCLUDE_NON_WORKERS, IS_EXCLUDE_NON_WORKERS);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Eq(job => job.START_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Eq(job => job.END_DATE, End_Date);
            }
            return mainFilter;
        }
        #endregion
        #region Get_Jobs_By_Where
        public List<Job> Get_Jobs_By_Where(List<string> JOB_ID_LIST, List<long?> REQUEST_SETUP_ID_LIST, List<int?> DWELL_TIME_BUCKET_LIST, List<long?> SITE_ID_LIST, List<int?> MIN_DWELL_TIME_LIST, List<int?> MAX_DWELL_TIME_LIST, DateTime? START_DATE, DateTime? END_DATE, bool? IS_EXCLUDE_NON_WORKERS, string JOB_REQUEST_ID)
        {
            var mainFilter = Get_Jobs_Filter(
                END_DATE: END_DATE,
                START_DATE: START_DATE,
                JOB_ID_LIST: JOB_ID_LIST,
                SITE_ID_LIST: SITE_ID_LIST,
                JOB_REQUEST_ID: JOB_REQUEST_ID,
                MIN_DWELL_TIME_LIST: MIN_DWELL_TIME_LIST,
                MAX_DWELL_TIME_LIST: MAX_DWELL_TIME_LIST,
                IS_EXCLUDE_NON_WORKERS: IS_EXCLUDE_NON_WORKERS,
                DWELL_TIME_BUCKET_LIST: DWELL_TIME_BUCKET_LIST,
                REQUEST_SETUP_ID_LIST: REQUEST_SETUP_ID_LIST
            );
            try
            {
                return this.db.GetCollection<Job>(JOB_COLLECTION).Find(mainFilter).ToList();
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #endregion

        #region Niche_categories
        #region Delete_Niche_categories
        public void Delete_Niche_categories(List<string> NICHE_CATEGORIES_ID_LIST, List<string> BUSINESS_NICHE_LIST)
        {
            var mainFilter = Get_Niche_categories_Filter(
                BUSINESS_NICHE_LIST: BUSINESS_NICHE_LIST,
                NICHE_CATEGORIES_ID_LIST: NICHE_CATEGORIES_ID_LIST
            );
            try
            {
                this.db.GetCollection<Niche_categories>(NICHE_CATEGORIES_COLLECTION).DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Failed to delete documents");
            }
        }
        #endregion
        #region Edit_Niche_categories_List
        public void Edit_Niche_categories_List(List<Niche_categories> i_List_Niche_categories)
        {
            try
            {
                var collection = this.db.GetCollection<Niche_categories>(NICHE_CATEGORIES_COLLECTION);
                List<Niche_categories> oList_Niche_categories_To_Insert = i_List_Niche_categories.Where(niche_categories => niche_categories.NICHE_CATEGORIES_ID == null).ToList();
                List<Niche_categories> oList_Niche_categories_To_Update = i_List_Niche_categories.Where(niche_categories => niche_categories.NICHE_CATEGORIES_ID != null).ToList();
                if (oList_Niche_categories_To_Insert.Count > 0)
                {
                    collection.InsertMany(oList_Niche_categories_To_Insert);
                }
                foreach (Niche_categories niche_categories in oList_Niche_categories_To_Update)
                {
                    collection.ReplaceOne(niche_categories_To_Replace => niche_categories_To_Replace.NICHE_CATEGORIES_ID == niche_categories.NICHE_CATEGORIES_ID, niche_categories, new ReplaceOptions() { IsUpsert = true });
                }
            }
            catch (Exception)
            {
                throw new Exception("Edit failed for one or more documents");
            }
        }
        #endregion
        #region Get_Niche_categories_Filter
        public FilterDefinition<Niche_categories> Get_Niche_categories_Filter(List<string> NICHE_CATEGORIES_ID_LIST, List<string> BUSINESS_NICHE_LIST)
        {
            var builder = Builders<Niche_categories>.Filter;
            var mainFilter = builder.Empty;
            if (NICHE_CATEGORIES_ID_LIST != null && NICHE_CATEGORIES_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(niche_categories => niche_categories.NICHE_CATEGORIES_ID, NICHE_CATEGORIES_ID_LIST);
            }
            if (BUSINESS_NICHE_LIST != null)
            {
                mainFilter &= builder.In(niche_categories => niche_categories.BUSINESS_NICHE, BUSINESS_NICHE_LIST);
            }
            return mainFilter;
        }
        #endregion
        #region Get_Niche_categories_By_Where
        public List<Niche_categories> Get_Niche_categories_By_Where(List<string> NICHE_CATEGORIES_ID_LIST, List<string> BUSINESS_NICHE_LIST)
        {
            var mainFilter = Get_Niche_categories_Filter(
                BUSINESS_NICHE_LIST: BUSINESS_NICHE_LIST,
                NICHE_CATEGORIES_ID_LIST: NICHE_CATEGORIES_ID_LIST
            );
            try
            {
                return this.db.GetCollection<Niche_categories>(NICHE_CATEGORIES_COLLECTION).Find(mainFilter).ToList();
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #endregion

        #region GeoData
        #region Delete_GeoData_By_GEODATA_ID
        public void Delete_GeoData_By_GEODATA_ID(string GEODATA_ID)
        {
            #region filter
            var builder = Builders<GeoData>.Filter;
            var mainFilter = builder.Empty;
            if (GEODATA_ID != null)
            {
                mainFilter &= builder.Eq(geodata => geodata.GEODATA_ID, GEODATA_ID);
            }
            #endregion
            try
            {
                var collection = this.db.GetCollection<GeoData>(GEO_COLLECTION);
                collection.DeleteOne(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Delete failed for document");
            }
        }
        #endregion
        #region Delete_GeoData_By_GEODATA_ID_List
        public void Delete_GeoData_By_GEODATA_ID_List(List<string> GEODATA_ID_LIST)
        {
            #region filter
            var builder = Builders<GeoData>.Filter;
            var mainFilter = builder.Empty;
            if (GEODATA_ID_LIST != null)
            {
                mainFilter &= builder.In(geodata => geodata.GEODATA_ID, GEODATA_ID_LIST);
            }
            #endregion
            try
            {
                var collection = this.db.GetCollection<GeoData>(GEO_COLLECTION);
                collection.DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Delete failed for one or more documents");
            }
        }
        #endregion
        #region Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List
        public void Delete_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_List(List<int?> LIST_ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            #region filter
            var builder = Builders<GeoData>.Filter;
            var mainFilter = builder.Empty;
            if (LIST_ORGANIZATION_DATA_SOURCE_KPI_ID != null)
            {
                mainFilter &= builder.In(geodata => geodata.ORGANIZATION_DATA_SOURCE_KPI_ID, LIST_ORGANIZATION_DATA_SOURCE_KPI_ID);
            }
            #endregion
            try
            {
                var collection = this.db.GetCollection<GeoData>(GEO_COLLECTION);
                collection.DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Delete failed for one or more documents");
            }
        }
        #endregion
        #region Edit_GeoData
        public void Edit_GeoData(GeoData i_GeoData)
        {
            if (i_GeoData != null)
            {
                #region filter
                var builder = Builders<GeoData>.Filter;
                var mainFilter = builder.Empty;
                mainFilter &= builder.Eq(geodata => geodata.GEODATA_ID, i_GeoData.GEODATA_ID);
                #endregion
                try
                {
                    var collection = this.db.GetCollection<GeoData>(GEO_COLLECTION);
                    collection.ReplaceOneAsync(mainFilter, i_GeoData, new ReplaceOptions { IsUpsert = true });
                }
                catch (Exception)
                {
                    throw new Exception("Edit failed for one document");
                }
            }
        }
        #endregion
        #region Edit_GeoData_List
        public void Edit_GeoData_List(List<GeoData> i_List_GeoData)
        {
            if (i_List_GeoData != null || i_List_GeoData.Count > 0)
            {
                #region filter
                List<string> GEODATA_ID_List = i_List_GeoData.Where(geodata => geodata.GEODATA_ID != null).Select(geodata => geodata.GEODATA_ID).ToList();
                var builder = Builders<GeoData>.Filter;
                var mainFilter = builder.Empty;
                mainFilter &= builder.In(geodata => geodata.GEODATA_ID, GEODATA_ID_List);
                #endregion
                try
                {
                    var collection = this.db.GetCollection<GeoData>(GEO_COLLECTION);
                    collection.DeleteMany(mainFilter);
                    collection.InsertMany(i_List_GeoData);
                }
                catch (Exception)
                {
                    throw new Exception("Edit failed for one document");
                }
            }
        }
        #endregion
        #region Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID
        public List<GeoData> Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<GeoData> oList_GeoData = null;
            #region filter
            var builder = Builders<GeoData>.Filter;
            var mainFilter = builder.Empty;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID != null)
            {
                mainFilter &= builder.Eq(geodata => geodata.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID);
            }
            #endregion
            try
            {
                var collection = this.db.GetCollection<GeoData>(GEO_COLLECTION);
                var _query_response = collection.Find(mainFilter);
                oList_GeoData = new List<GeoData>();
                if (_query_response != null)
                {
                    oList_GeoData = _query_response.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_GeoData;
        }
        #endregion
        #region Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID
        public IEnumerable<GeoData> Get_GeoData_By_ORGANIZATION_DATA_SOURCE_KPI_ID_LEVEL_ID_LEVEL_SETUP_ID(int? ORGANIZATION_DATA_SOURCE_KPI_ID, List<long?> LIST_LEVEL_ID, long? LEVEL_SETUP_ID)
        {
            IEnumerable<GeoData> oList_GeoData = null;
            #region filter
            var builder = Builders<GeoData>.Filter;
            var mainFilter = builder.Empty;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID != null)
            {
                mainFilter &= builder.Eq(geodata => geodata.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID);
            }
            if (LIST_LEVEL_ID != null && LIST_LEVEL_ID.Count > 0)
            {
                mainFilter &= builder.In(geodata => geodata.LEVEL_ID, LIST_LEVEL_ID);
            }
            if (LEVEL_SETUP_ID != null)
            {
                mainFilter &= builder.Eq(geodata => geodata.LEVEL_SETUP_ID, LEVEL_SETUP_ID);
            }
            #endregion
            try
            {
                var collection = this.db.GetCollection<GeoData>(GEO_COLLECTION);
                var _query_response = collection.Find(mainFilter);
                oList_GeoData = new List<GeoData>();
                if (_query_response != null)
                {
                    oList_GeoData = _query_response.ToEnumerable();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_GeoData;
        }
        #endregion
        #region Get_GeoData_By_Where
        public IEnumerable<GeoData> Get_GeoData_By_Where(DateTime? START_DATE, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, List<long?> LIST_LEVEL_ID, long? LEVEL_SETUP_ID)
        {
            IEnumerable<GeoData> oList_GeoData = null;
            #region filter
            var builder = Builders<GeoData>.Filter;
            var mainFilter = builder.Empty;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(geodata => geodata.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (LIST_LEVEL_ID != null && LIST_LEVEL_ID.Count > 0)
            {
                mainFilter &= builder.In(geodata => geodata.LEVEL_ID, LIST_LEVEL_ID);
            }
            if (LEVEL_SETUP_ID != null)
            {
                mainFilter &= builder.Eq(geodata => geodata.LEVEL_SETUP_ID, LEVEL_SETUP_ID);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(geodata => geodata.DATE_START, Start_Date);
            }
            #endregion
            try
            {
                var collection = this.db.GetCollection<GeoData>(GEO_COLLECTION);
                var _query_response = collection.Find(mainFilter);
                if (_query_response != null)
                {
                    oList_GeoData = _query_response.ToEnumerable();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_GeoData;
        }
        #endregion
        #region Get_GeoData_By_GEODATA_ID
        public GeoData Get_GeoData_By_GEODATA_ID(string GEODATA_ID)
        {
            GeoData oGeoData = null;
            #region filter
            var builder = Builders<GeoData>.Filter;
            var mainFilter = builder.Empty;
            if (GEODATA_ID != null)
            {
                mainFilter &= builder.Eq(geodata => geodata.GEODATA_ID, GEODATA_ID);
            }
            #endregion
            try
            {
                var collection = this.db.GetCollection<GeoData>(GEO_COLLECTION);
                var _query_response = collection.Find(mainFilter);
                oGeoData = new GeoData();
                if (_query_response != null)
                {
                    oGeoData = _query_response.FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oGeoData;
        }
        #endregion
        #region Get_GeoData_By_GEODATA_ID_List
        public List<GeoData> Get_GeoData_By_GEODATA_ID_List(List<string> GEODATA_ID_LIST)
        {
            List<GeoData> oList_GeoData = null;
            #region filter
            var builder = Builders<GeoData>.Filter;
            var mainFilter = builder.Empty;
            if (GEODATA_ID_LIST != null && GEODATA_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(geodata => geodata.GEODATA_ID, GEODATA_ID_LIST);
            }
            #endregion
            try
            {
                var collection = this.db.GetCollection<GeoData>(GEO_COLLECTION);
                var _query_response = collection.Find(mainFilter);
                oList_GeoData = new List<GeoData>();
                if (_query_response != null)
                {
                    oList_GeoData = _query_response.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_GeoData;
        }
        #endregion
        #region Get_Latest_GeoData_Aggregate_By_KPI
        public List<GeoData> Get_Latest_GeoData_Aggregate_By_KPI(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            List<GeoData> oList_GeoData = null;
            #region filter
            var builder = Builders<GeoData>.Filter;
            var mainFilter = builder.Empty;
            if (ORGANIZATION_DATA_SOURCE_KPI_ID != null)
            {
                mainFilter &= builder.Eq(geodata => geodata.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID);
            }
            #endregion
            try
            {
                var collection = this.db.GetCollection<GeoData>(GEO_COLLECTION);
                var _query_response = collection.Aggregate()
                    .Match(mainFilter)
                    .SortByDescending(x => x.DATE_START)
                    .Group(new BsonDocument
                    {
                    { "_id", "ORGANIZATION_DATA_SOURCE_KPI_ID" },
                    { "doc", new BsonDocument("$first", "$$ROOT") }
                    })
                    .Unwind("doc")
                    .Project(new BsonDocument("_id", 0)
                        .Add("GEODATA_ID", "$doc.GEODATA_ID")
                        .Add("ORGANIZATION_DATA_SOURCE_KPI_ID", "$doc.ORGANIZATION_DATA_SOURCE_KPI_ID")
                        .Add("SITE_ID", "$doc.SITE_ID")
                        .Add("AREA_ID", "$doc.AREA_ID")
                        .Add("DISTRICT_ID", "$doc.DISTRICT_ID")
                        .Add("DATE_START", "$doc.DATE_START")
                        .Add("DATE_END", "$doc.DATE_END")
                        .Add("DATA_LIST", "$doc.DATA_LIST"))
                    .ToList();
                oList_GeoData = new List<GeoData>();
                if (_query_response != null)
                {
                    foreach (var x in _query_response)
                    {
                        oList_GeoData.Add(BsonSerializer.Deserialize<GeoData>(x));
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_GeoData;
        }
        #endregion
        #endregion
        #region District
        #region Delete_District_Kpi_Data_By_Where
        public void Delete_District_Kpi_Data_By_Where(List<long?> DISTRICT_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            #region filter
            var builder = Builders<District_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (DISTRICT_ID_LIST != null)
            {
                mainFilter &= builder.In(district_kpi_data => district_kpi_data.DISTRICT_METADATA.DISTRICT_ID, DISTRICT_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(district_kpi_data => district_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            #endregion
            try
            {
                var collection = Set_District_Db_Collection(ENUM_TIMESPAN);
                collection.DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Delete failed for one or more documents");
            }
        }
        #endregion
        #region Insert_District_Kpi_Data
        public void Insert_District_Kpi_Data(District_kpi_data i_District_kpi_data, Enum_Timespan i_Enum_Timespan)
        {
            if (i_District_kpi_data != null)
            {
                try
                {
                    var collection = Set_District_Db_Collection(i_Enum_Timespan);
                    collection.InsertOneAsync(i_District_kpi_data);
                }
                catch (Exception)
                {
                    throw new Exception("Insert failed for one document");
                }
            }
        }
        #endregion
        #region Insert_District_Kpi_Data_List
        public void Insert_District_Kpi_Data_List(List<District_kpi_data> i_List_District_kpi_data, Enum_Timespan i_Enum_Timespan)
        {
            if (i_List_District_kpi_data != null || i_List_District_kpi_data.Count() > 0)
            {
                try
                {
                    var collection = Set_District_Db_Collection(i_Enum_Timespan);
                    collection.InsertMany(i_List_District_kpi_data);
                }
                catch (Exception)
                {
                    throw new Exception("Insert failed for one or more document");
                }
            }
        }
        #endregion
        #region Get_District_Kpi_Data_By_Where
        public List<District_kpi_data> Get_District_Kpi_Data_By_Where(DateTime? START_DATE, DateTime? END_DATE, List<long?> DISTRICT_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<District_kpi_data> oList_District_kpi_data = null;
            #region filter
            var builder = Builders<District_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (DISTRICT_ID_LIST != null)
            {
                mainFilter &= builder.In(district_kpi_data => district_kpi_data.DISTRICT_METADATA.DISTRICT_ID, DISTRICT_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(district_kpi_data => district_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(district_kpi_data => district_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(district_kpi_data => district_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_District_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Find(mainFilter);
                oList_District_kpi_data = new List<District_kpi_data>();
                if (_query_response != null)
                {
                    oList_District_kpi_data = _query_response.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_District_kpi_data;
        }
        #endregion
        #region Get_District_Kpi_Data_Aggregate_Sum
        public List<District_kpi_data> Get_District_Kpi_Data_Aggregate_Sum(DateTime? START_DATE, DateTime? END_DATE, List<long?> DISTRICT_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<District_kpi_data> oList_District_kpi_data = null;
            #region filter
            var builder = Builders<District_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (DISTRICT_ID_LIST != null)
            {
                mainFilter &= builder.In(district_kpi_data => district_kpi_data.DISTRICT_METADATA.DISTRICT_ID, DISTRICT_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(district_kpi_data => district_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(district_kpi_data => district_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(district_kpi_data => district_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_District_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                .Match(mainFilter)
                .Group(
                    groupBy => new { groupBy.DISTRICT_METADATA.DISTRICT_ID, groupBy.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, groupBy.DISTRICT_METADATA.CATEGORY, groupBy.VALUE_NAME },
                    result => new
                    {
                        RECORD_DATE = result.Max(x => x.RECORD_DATE),
                        DISTRICT_METADATA = result.First().DISTRICT_METADATA,
                        VALUE = result.Sum(x => x.VALUE),
                        VALUE_PER_SQM = result.Sum(x => x.VALUE_PER_SQM),
                        VALUE_NAME = result.First().VALUE_NAME,
                    }
                ).ToList();
                oList_District_kpi_data = new List<District_kpi_data>();
                if (_query_response != null)
                {
                    District_kpi_data oDistrict_kpi_data = new District_kpi_data();
                    foreach (var item in _query_response)
                    {
                        oDistrict_kpi_data = new District_kpi_data();
                        oDistrict_kpi_data.RECORD_DATE = item.RECORD_DATE;
                        oDistrict_kpi_data.DISTRICT_METADATA = item.DISTRICT_METADATA;
                        oDistrict_kpi_data.VALUE = item.VALUE;
                        oDistrict_kpi_data.VALUE_NAME = item.VALUE_NAME;
                        oDistrict_kpi_data.VALUE_PER_SQM = item.VALUE_PER_SQM;
                        oList_District_kpi_data.Add(oDistrict_kpi_data);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_District_kpi_data;
        }
        #endregion
        #region Get_District_Kpi_Data_Aggregate_Avg
        public List<District_kpi_data> Get_District_Kpi_Data_Aggregate_Avg(DateTime? START_DATE, DateTime? END_DATE, List<long?> DISTRICT_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<District_kpi_data> oList_District_kpi_data = null;
            #region filter
            var builder = Builders<District_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (DISTRICT_ID_LIST != null)
            {
                mainFilter &= builder.In(district_kpi_data => district_kpi_data.DISTRICT_METADATA.DISTRICT_ID, DISTRICT_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(district_kpi_data => district_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(district_kpi_data => district_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(district_kpi_data => district_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_District_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                .Match(mainFilter)
                .Group(
                    groupBy => new { groupBy.DISTRICT_METADATA.DISTRICT_ID, groupBy.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, groupBy.DISTRICT_METADATA.CATEGORY, groupBy.VALUE_NAME },
                    result => new
                    {
                        RECORD_DATE = result.Max(x => x.RECORD_DATE),
                        DISTRICT_METADATA = result.First().DISTRICT_METADATA,
                        VALUE = result.Average(x => x.VALUE),
                        VALUE_NAME = result.First().VALUE_NAME,
                    }
                ).ToList();
                oList_District_kpi_data = new List<District_kpi_data>();
                if (_query_response != null)
                {
                    District_kpi_data oDistrict_kpi_data = new District_kpi_data();
                    oDistrict_kpi_data.VALUE_PER_SQM = null;
                    foreach (var item in _query_response)
                    {
                        oDistrict_kpi_data = new District_kpi_data();
                        oDistrict_kpi_data.RECORD_DATE = item.RECORD_DATE;
                        oDistrict_kpi_data.DISTRICT_METADATA = item.DISTRICT_METADATA;
                        oDistrict_kpi_data.VALUE = item.VALUE;
                        oDistrict_kpi_data.VALUE_NAME = item.VALUE_NAME;
                        oList_District_kpi_data.Add(oDistrict_kpi_data);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_District_kpi_data;
        }
        #endregion
        #region Get_Latest_District_Kpi_Data_Aggregate_By_KPI
        public List<District_kpi_data> Get_Latest_District_Kpi_Data_Aggregate_By_KPI(List<long?> DISTRICT_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<District_kpi_data> oList_District_kpi_data = null;
            #region filter
            var builder = Builders<District_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (DISTRICT_ID_LIST != null)
            {
                mainFilter &= builder.In(district_kpi_data => district_kpi_data.DISTRICT_METADATA.DISTRICT_ID, DISTRICT_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(district_kpi_data => district_kpi_data.DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            #endregion
            try
            {
                var collection = Set_District_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                    .Match(mainFilter)
                    .SortByDescending(x => x.RECORD_DATE)
                    .Group(new BsonDocument
                    {
                    { "_id", "$DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID" },
                    { "doc", new BsonDocument("$first", "$$ROOT") }
                    })
                    .Unwind("doc")
                    .Project(new BsonDocument("_id", 0)
                        .Add("RECORD_DATE", "$doc.RECORD_DATE")
                        .Add("DISTRICT_METADATA", "$doc.DISTRICT_METADATA")
                        .Add("VALUE", "$doc.VALUE")
                        .Add("VALUE_PER_SQM", "$doc.VALUE_PER_SQM")
                        .Add("VALUE_NAME", "$doc.VALUE_NAME"))
                    .ToList();
                oList_District_kpi_data = new List<District_kpi_data>();
                if (_query_response != null)
                {
                    foreach (var x in _query_response)
                    {
                        oList_District_kpi_data.Add(BsonSerializer.Deserialize<District_kpi_data>(x));
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_District_kpi_data;
        }
        #endregion
        #endregion
        #region Area
        #region Delete_Area_Kpi_Data_By_Where
        public void Delete_Area_Kpi_Data_By_Where(List<long?> AREA_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            #region filter
            var builder = Builders<Area_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (AREA_ID_LIST != null)
            {
                mainFilter &= builder.In(area_kpi_data => area_kpi_data.AREA_METADATA.AREA_ID, AREA_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(area_kpi_data => area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            #endregion
            try
            {
                var collection = Set_Area_Db_Collection(ENUM_TIMESPAN);
                collection.DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Delete failed for one or more documents");
            }
        }
        #endregion
        #region Insert_Area_Kpi_Data
        public void Insert_Area_Kpi_Data(Area_kpi_data i_Area_kpi_data, Enum_Timespan i_Enum_Timespan)
        {
            if (i_Area_kpi_data != null)
            {
                try
                {
                    var collection = Set_Area_Db_Collection(i_Enum_Timespan);
                    collection.InsertOneAsync(i_Area_kpi_data);
                }
                catch (Exception)
                {
                    throw new Exception("Insert failed for one document");
                }
            }
        }
        #endregion
        #region Insert_Area_Kpi_Data_List
        public void Insert_Area_Kpi_Data_List(List<Area_kpi_data> i_List_Area_kpi_data, Enum_Timespan i_Enum_Timespan)
        {
            if (i_List_Area_kpi_data != null || i_List_Area_kpi_data.Count > 0)
            {
                try
                {
                    var collection = Set_Area_Db_Collection(i_Enum_Timespan);
                    collection.InsertMany(i_List_Area_kpi_data);
                }
                catch (Exception)
                {
                    throw new Exception("Insert failed for one or more document");
                }
            }
        }
        #endregion
        #region Get_Area_Kpi_Data_By_Where
        public List<Area_kpi_data> Get_Area_Kpi_Data_By_Where(DateTime? START_DATE, DateTime? END_DATE, List<long?> AREA_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Area_kpi_data> oList_Area_kpi_data = null;
            #region filter
            var builder = Builders<Area_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (AREA_ID_LIST != null)
            {
                mainFilter &= builder.In(area_kpi_data => area_kpi_data.AREA_METADATA.AREA_ID, AREA_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(area_kpi_data => area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(area_kpi_data => area_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(area_kpi_data => area_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Area_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Find(mainFilter);
                oList_Area_kpi_data = new List<Area_kpi_data>();
                if (_query_response != null)
                {
                    oList_Area_kpi_data = _query_response.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Area_kpi_data;
        }
        #endregion
        #region Get_Area_Kpi_Data_Aggregate_Sum
        public List<Area_kpi_data> Get_Area_Kpi_Data_Aggregate_Sum(DateTime? START_DATE, DateTime? END_DATE, List<long?> AREA_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Area_kpi_data> oList_Area_kpi_data = null;
            #region filter
            var builder = Builders<Area_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (AREA_ID_LIST != null)
            {
                mainFilter &= builder.In(area_kpi_data => area_kpi_data.AREA_METADATA.AREA_ID, AREA_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(area_kpi_data => area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(area_kpi_data => area_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(area_kpi_data => area_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Area_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                .Match(mainFilter)
                .Group(
                    groupBy => new { groupBy.AREA_METADATA.AREA_ID, groupBy.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, groupBy.AREA_METADATA.CATEGORY, groupBy.VALUE_NAME },
                    result => new
                    {
                        RECORD_DATE = result.Max(x => x.RECORD_DATE),
                        AREA_METADATA = result.First().AREA_METADATA,
                        VALUE = result.Sum(x => (int)x.VALUE),
                        VALUE_PER_SQM = result.Sum(x => x.VALUE_PER_SQM),
                        VALUE_NAME = result.First().VALUE_NAME,
                    }
                ).ToList();
                oList_Area_kpi_data = new List<Area_kpi_data>();
                if (_query_response != null)
                {
                    Area_kpi_data oArea_kpi_data = new Area_kpi_data();
                    foreach (var item in _query_response)
                    {
                        oArea_kpi_data = new Area_kpi_data();
                        oArea_kpi_data.RECORD_DATE = item.RECORD_DATE;
                        oArea_kpi_data.AREA_METADATA = item.AREA_METADATA;
                        oArea_kpi_data.VALUE = item.VALUE;
                        oArea_kpi_data.VALUE_NAME = item.VALUE_NAME;
                        oArea_kpi_data.VALUE_PER_SQM = item.VALUE_PER_SQM;
                        oList_Area_kpi_data.Add(oArea_kpi_data);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Area_kpi_data;
        }
        #endregion
        #region Get_Area_Kpi_Data_Aggregate_Avg
        public List<Area_kpi_data> Get_Area_Kpi_Data_Aggregate_Avg(DateTime? START_DATE, DateTime? END_DATE, List<long?> AREA_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Area_kpi_data> oList_Area_kpi_data = null;
            #region filter
            var builder = Builders<Area_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (AREA_ID_LIST != null)
            {
                mainFilter &= builder.In(area_kpi_data => area_kpi_data.AREA_METADATA.AREA_ID, AREA_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(area_kpi_data => area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(area_kpi_data => area_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(area_kpi_data => area_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Area_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                .Match(mainFilter)
                .Group(
                    groupBy => new { groupBy.AREA_METADATA.AREA_ID, groupBy.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, groupBy.AREA_METADATA.CATEGORY, groupBy.VALUE_NAME },
                    result => new
                    {
                        RECORD_DATE = result.Max(x => x.RECORD_DATE),
                        AREA_METADATA = result.First().AREA_METADATA,
                        VALUE = result.Average(x => x.VALUE),
                        VALUE_NAME = result.First().VALUE_NAME,
                    }
                ).ToList();
                oList_Area_kpi_data = new List<Area_kpi_data>();
                if (_query_response != null)
                {
                    Area_kpi_data oArea_kpi_data = new Area_kpi_data();
                    oArea_kpi_data.VALUE_PER_SQM = null;
                    foreach (var item in _query_response)
                    {
                        oArea_kpi_data = new Area_kpi_data();
                        oArea_kpi_data.RECORD_DATE = item.RECORD_DATE;
                        oArea_kpi_data.AREA_METADATA = item.AREA_METADATA;
                        oArea_kpi_data.VALUE = item.VALUE;
                        oArea_kpi_data.VALUE_NAME = item.VALUE_NAME;
                        oList_Area_kpi_data.Add(oArea_kpi_data);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Area_kpi_data;
        }
        #endregion
        #region Get_Latest_Area_Kpi_Data_Aggregate_By_KPI
        public List<Area_kpi_data> Get_Latest_Area_Kpi_Data_Aggregate_By_KPI(List<long?> AREA_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Area_kpi_data> oList_Area_kpi_data = null;
            #region filter
            var builder = Builders<Area_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (AREA_ID_LIST != null)
            {
                mainFilter &= builder.In(area_kpi_data => area_kpi_data.AREA_METADATA.AREA_ID, AREA_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(area_kpi_data => area_kpi_data.AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            #endregion
            try
            {
                var collection = Set_Area_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                    .Match(mainFilter)
                    .SortByDescending(x => x.RECORD_DATE)
                    .Group(new BsonDocument
                    {
                    { "_id", "$AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID" },
                    { "doc", new BsonDocument("$first", "$$ROOT") }
                    })
                    .Unwind("doc")
                    .Project(new BsonDocument("_id", 0)
                        .Add("RECORD_DATE", "$doc.RECORD_DATE")
                        .Add("AREA_METADATA", "$doc.AREA_METADATA")
                        .Add("VALUE", "$doc.VALUE")
                        .Add("VALUE_PER_SQM", "$doc.VALUE_PER_SQM")
                        .Add("VALUE_NAME", "$doc.VALUE_NAME"))
                    .ToList();
                oList_Area_kpi_data = new List<Area_kpi_data>();
                if (_query_response != null)
                {
                    foreach (var x in _query_response)
                    {
                        oList_Area_kpi_data.Add(BsonSerializer.Deserialize<Area_kpi_data>(x));
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Area_kpi_data;
        }
        #endregion
        #endregion
        #region Site
        #region Delete_Site_Kpi_Data_By_Where
        public void Delete_Site_Kpi_Data_By_Where(List<long?> SITE_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            #region filter
            var builder = Builders<Site_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (SITE_ID_LIST != null)
            {
                mainFilter &= builder.In(site_kpi_data => site_kpi_data.SITE_METADATA.SITE_ID, SITE_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(site_kpi_data => site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            #endregion
            try
            {
                var collection = Set_Site_Db_Collection(ENUM_TIMESPAN);
                collection.DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Delete failed for one or more documents");
            }
        }
        #endregion
        #region Insert_Site_Kpi_Data
        public void Insert_Site_Kpi_Data(Site_kpi_data i_Site_kpi_data, Enum_Timespan i_Enum_Timespan)
        {
            if (i_Site_kpi_data != null)
            {
                try
                {
                    var collection = Set_Site_Db_Collection(i_Enum_Timespan);
                    collection.InsertOneAsync(i_Site_kpi_data);
                }
                catch (Exception)
                {
                    throw new Exception("Insert failed for one document");
                }
            }
        }
        #endregion
        #region Insert_Site_Kpi_Data_List
        public void Insert_Site_Kpi_Data_List(List<Site_kpi_data> i_List_Site_kpi_data, Enum_Timespan i_Enum_Timespan)
        {
            if (i_List_Site_kpi_data != null || i_List_Site_kpi_data.Count > 0)
            {
                try
                {
                    var collection = Set_Site_Db_Collection(i_Enum_Timespan);
                    collection.InsertMany(i_List_Site_kpi_data);
                }
                catch (Exception)
                {
                    throw new Exception("Insert failed for one or more document");
                }
            }
        }
        #endregion
        #region Get_Site_Kpi_Data_By_Where
        public List<Site_kpi_data> Get_Site_Kpi_Data_By_Where(DateTime? START_DATE, DateTime? END_DATE, List<long?> SITE_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Site_kpi_data> oList_Site_kpi_data = null;
            #region filter
            var builder = Builders<Site_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (SITE_ID_LIST != null)
            {
                mainFilter &= builder.In(site_kpi_data => site_kpi_data.SITE_METADATA.SITE_ID, SITE_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(site_kpi_data => site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(site_kpi_data => site_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(site_kpi_data => site_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Site_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Find(mainFilter);
                oList_Site_kpi_data = new List<Site_kpi_data>();
                if (_query_response != null)
                {
                    oList_Site_kpi_data = _query_response.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Site_kpi_data;
        }
        #endregion
        #region Get_Site_Kpi_Data_Aggregate_Sum
        public List<Site_kpi_data> Get_Site_Kpi_Data_Aggregate_Sum(DateTime? START_DATE, DateTime? END_DATE, List<long?> SITE_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Site_kpi_data> oList_Site_kpi_data = null;
            #region filter
            var builder = Builders<Site_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (SITE_ID_LIST != null)
            {
                mainFilter &= builder.In(site_kpi_data => site_kpi_data.SITE_METADATA.SITE_ID, SITE_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(site_kpi_data => site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(site_kpi_data => site_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(site_kpi_data => site_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Site_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                .Match(mainFilter)
                .Group(
                    groupBy => new { groupBy.SITE_METADATA.SITE_ID, groupBy.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, groupBy.SITE_METADATA.CATEGORY, groupBy.VALUE_NAME },
                    result => new
                    {
                        RECORD_DATE = result.Max(x => x.RECORD_DATE),
                        SITE_METADATA = result.First().SITE_METADATA,
                        VALUE = result.Sum(x => x.VALUE),
                        VALUE_PER_SQM = result.Sum(x => x.VALUE_PER_SQM),
                        VALUE_NAME = result.First().VALUE_NAME,
                    }
                ).ToList();
                oList_Site_kpi_data = new List<Site_kpi_data>();
                if (_query_response != null)
                {
                    Site_kpi_data oSite_kpi_data = new Site_kpi_data();
                    foreach (var item in _query_response)
                    {
                        oSite_kpi_data = new Site_kpi_data();
                        oSite_kpi_data.RECORD_DATE = item.RECORD_DATE;
                        oSite_kpi_data.SITE_METADATA = item.SITE_METADATA;
                        oSite_kpi_data.VALUE = item.VALUE;
                        oSite_kpi_data.VALUE_NAME = item.VALUE_NAME;
                        oSite_kpi_data.VALUE_PER_SQM = item.VALUE_PER_SQM;
                        oList_Site_kpi_data.Add(oSite_kpi_data);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Site_kpi_data;
        }
        #endregion
        #region Get_Site_Kpi_Data_Aggregate_Avg
        public List<Site_kpi_data> Get_Site_Kpi_Data_Aggregate_Avg(DateTime? START_DATE, DateTime? END_DATE, List<long?> SITE_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Site_kpi_data> oList_Site_kpi_data = null;
            #region filter
            var builder = Builders<Site_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (SITE_ID_LIST != null)
            {
                mainFilter &= builder.In(site_kpi_data => site_kpi_data.SITE_METADATA.SITE_ID, SITE_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(site_kpi_data => site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(site_kpi_data => site_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(site_kpi_data => site_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Site_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                .Match(mainFilter)
                .Group(
                    groupBy => new { groupBy.SITE_METADATA.SITE_ID, groupBy.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, groupBy.SITE_METADATA.CATEGORY, groupBy.VALUE_NAME },
                    result => new
                    {
                        RECORD_DATE = result.Max(x => x.RECORD_DATE),
                        SITE_METADATA = result.First().SITE_METADATA,
                        VALUE = result.Average(x => x.VALUE),
                        VALUE_NAME = result.First().VALUE_NAME,
                    }
                ).ToList();
                oList_Site_kpi_data = new List<Site_kpi_data>();
                if (_query_response != null)
                {
                    Site_kpi_data oSite_kpi_data = new Site_kpi_data();
                    oSite_kpi_data.VALUE_PER_SQM = null;
                    foreach (var item in _query_response)
                    {
                        oSite_kpi_data = new Site_kpi_data();
                        oSite_kpi_data.RECORD_DATE = item.RECORD_DATE;
                        oSite_kpi_data.SITE_METADATA = item.SITE_METADATA;
                        oSite_kpi_data.VALUE = item.VALUE;
                        oSite_kpi_data.VALUE_NAME = item.VALUE_NAME;
                        oList_Site_kpi_data.Add(oSite_kpi_data);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Site_kpi_data;
        }
        #endregion
        #region Get_Latest_Site_Kpi_Data_Aggregate_By_KPI
        public List<Site_kpi_data> Get_Latest_Site_Kpi_Data_Aggregate_By_KPI(List<long?> SITE_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Site_kpi_data> oList_Site_kpi_data = null;
            #region filter
            var builder = Builders<Site_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (SITE_ID_LIST != null)
            {
                mainFilter &= builder.In(site_kpi_data => site_kpi_data.SITE_METADATA.SITE_ID, SITE_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(site_kpi_data => site_kpi_data.SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            #endregion
            try
            {
                var collection = Set_Site_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                    .Match(mainFilter)
                    .SortByDescending(x => x.RECORD_DATE)
                    .Group(new BsonDocument
                    {
                    { "_id", "$SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID" },
                    { "doc", new BsonDocument("$first", "$$ROOT") }
                    })
                    .Unwind("doc")
                    .Project(new BsonDocument("_id", 0)
                        .Add("RECORD_DATE", "$doc.RECORD_DATE")
                        .Add("SITE_METADATA", "$doc.SITE_METADATA")
                        .Add("VALUE", "$doc.VALUE")
                        .Add("VALUE_PER_SQM", "$doc.VALUE_PER_SQM")
                        .Add("VALUE_NAME", "$doc.VALUE_NAME"))
                    .ToList();
                oList_Site_kpi_data = new List<Site_kpi_data>();
                if (_query_response != null)
                {
                    foreach (var x in _query_response)
                    {
                        oList_Site_kpi_data.Add(BsonSerializer.Deserialize<Site_kpi_data>(x));
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Site_kpi_data;
        }
        #endregion
        #endregion
        #region Entity
        #region Delete_Entity_Kpi_Data_By_Where
        public void Delete_Entity_Kpi_Data_By_Where(List<long?> ENTITY_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            #region filter
            var builder = Builders<Entity_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (ENTITY_ID_LIST != null)
            {
                mainFilter &= builder.In(entity_kpi_data => entity_kpi_data.ENTITY_METADATA.ENTITY_ID, ENTITY_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(entity_kpi_data => entity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            #endregion
            try
            {
                var collection = Set_Entity_Db_Collection(ENUM_TIMESPAN);
                collection.DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Delete failed for one or more documents");
            }
        }
        #endregion
        #region Insert_Entity_Kpi_Data
        public void Insert_Entity_Kpi_Data(Entity_kpi_data i_Entity_kpi_data, Enum_Timespan i_Enum_Timespan)
        {
            if (i_Entity_kpi_data != null)
            {
                try
                {
                    var collection = Set_Entity_Db_Collection(i_Enum_Timespan);
                    collection.InsertOneAsync(i_Entity_kpi_data);
                }
                catch (Exception)
                {
                    throw new Exception("Insert failed for one document");
                }
            }
        }
        #endregion
        #region Insert_Entity_Kpi_Data_List
        public void Insert_Entity_Kpi_Data_List(List<Entity_kpi_data> i_List_Entity_kpi_data, Enum_Timespan i_Enum_Timespan)
        {
            if (i_List_Entity_kpi_data != null || i_List_Entity_kpi_data.Count > 0)
            {
                try
                {
                    var collection = Set_Entity_Db_Collection(i_Enum_Timespan);
                    collection.InsertMany(i_List_Entity_kpi_data);
                }
                catch (Exception)
                {
                    throw new Exception("Insert failed for one or more document");
                }
            }
        }
        #endregion
        #region Get_Entity_Kpi_Data_By_Where
        public List<Entity_kpi_data> Get_Entity_Kpi_Data_By_Where(DateTime? START_DATE, DateTime? END_DATE, List<long?> ENTITY_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Entity_kpi_data> oList_Entity_kpi_data = null;
            #region filter
            var builder = Builders<Entity_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (ENTITY_ID_LIST != null)
            {
                mainFilter &= builder.In(entity_kpi_data => entity_kpi_data.ENTITY_METADATA.ENTITY_ID, ENTITY_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(entity_kpi_data => entity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(entity_kpi_data => entity_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(entity_kpi_data => entity_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Entity_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Find(mainFilter);
                oList_Entity_kpi_data = new List<Entity_kpi_data>();
                if (_query_response != null)
                {
                    oList_Entity_kpi_data = _query_response.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Entity_kpi_data;
        }
        #endregion
        #region Get_Entity_Kpi_Data_Aggregate_Sum
        public List<Entity_kpi_data> Get_Entity_Kpi_Data_Aggregate_Sum(DateTime? START_DATE, DateTime? END_DATE, List<long?> ENTITY_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Entity_kpi_data> oList_Entity_kpi_data = null;
            #region filter
            var builder = Builders<Entity_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (ENTITY_ID_LIST != null)
            {
                mainFilter &= builder.In(entity_kpi_data => entity_kpi_data.ENTITY_METADATA.ENTITY_ID, ENTITY_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(entity_kpi_data => entity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(entity_kpi_data => entity_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(entity_kpi_data => entity_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Entity_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                .Match(mainFilter)
                .Group(
                    groupBy => new { groupBy.ENTITY_METADATA.ENTITY_ID, groupBy.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, groupBy.ENTITY_METADATA.CATEGORY, groupBy.VALUE_NAME },
                    result => new
                    {
                        RECORD_DATE = result.Max(x => x.RECORD_DATE),
                        ENTITY_METADATA = result.First().ENTITY_METADATA,
                        VALUE = result.Sum(x => x.VALUE),
                        VALUE_PER_SQM = result.Sum(x => x.VALUE_PER_SQM),
                        VALUE_NAME = result.First().VALUE_NAME,
                    }
                ).ToList();
                oList_Entity_kpi_data = new List<Entity_kpi_data>();
                if (_query_response != null)
                {
                    Entity_kpi_data oEntity_kpi_data = new Entity_kpi_data();
                    foreach (var item in _query_response)
                    {
                        oEntity_kpi_data = new Entity_kpi_data();
                        oEntity_kpi_data.RECORD_DATE = item.RECORD_DATE;
                        oEntity_kpi_data.ENTITY_METADATA = item.ENTITY_METADATA;
                        oEntity_kpi_data.VALUE = item.VALUE;
                        oEntity_kpi_data.VALUE_NAME = item.VALUE_NAME;
                        oEntity_kpi_data.VALUE_PER_SQM = item.VALUE_PER_SQM;
                        oList_Entity_kpi_data.Add(oEntity_kpi_data);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Entity_kpi_data;
        }
        #endregion
        #region Get_Entity_Kpi_Data_Aggregate_Avg
        public List<Entity_kpi_data> Get_Entity_Kpi_Data_Aggregate_Avg(DateTime? START_DATE, DateTime? END_DATE, List<long?> ENTITY_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Entity_kpi_data> oList_Entity_kpi_data = null;
            #region filter
            var builder = Builders<Entity_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (ENTITY_ID_LIST != null)
            {
                mainFilter &= builder.In(entity_kpi_data => entity_kpi_data.ENTITY_METADATA.ENTITY_ID, ENTITY_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(entity_kpi_data => entity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(entity_kpi_data => entity_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(entity_kpi_data => entity_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Entity_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                .Match(mainFilter)
                .Group(
                    groupBy => new { groupBy.ENTITY_METADATA.ENTITY_ID, groupBy.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, groupBy.ENTITY_METADATA.CATEGORY, groupBy.VALUE_NAME },
                    result => new
                    {
                        RECORD_DATE = result.Max(x => x.RECORD_DATE),
                        ENTITY_METADATA = result.First().ENTITY_METADATA,
                        VALUE = result.Average(x => x.VALUE),
                        VALUE_NAME = result.First().VALUE_NAME,
                    }
                ).ToList();
                oList_Entity_kpi_data = new List<Entity_kpi_data>();
                if (_query_response != null)
                {
                    Entity_kpi_data oEntity_kpi_data = new Entity_kpi_data();
                    oEntity_kpi_data.VALUE_PER_SQM = null;
                    foreach (var item in _query_response)
                    {
                        oEntity_kpi_data = new Entity_kpi_data();
                        oEntity_kpi_data.RECORD_DATE = item.RECORD_DATE;
                        oEntity_kpi_data.ENTITY_METADATA = item.ENTITY_METADATA;
                        oEntity_kpi_data.VALUE = item.VALUE;
                        oEntity_kpi_data.VALUE_NAME = item.VALUE_NAME;
                        oList_Entity_kpi_data.Add(oEntity_kpi_data);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Entity_kpi_data;
        }
        #endregion
        #region Get_Latest_Entity_Kpi_Data_Aggregate_By_KPI
        public List<Entity_kpi_data> Get_Latest_Entity_Kpi_Data_Aggregate_By_KPI(List<long?> ENTITY_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Entity_kpi_data> oList_Entity_kpi_data = null;
            #region filter
            var builder = Builders<Entity_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (ENTITY_ID_LIST != null)
            {
                mainFilter &= builder.In(entity_kpi_data => entity_kpi_data.ENTITY_METADATA.ENTITY_ID, ENTITY_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(entity_kpi_data => entity_kpi_data.ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            #endregion
            try
            {
                var collection = Set_Entity_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                    .Match(mainFilter)
                    .SortByDescending(x => x.RECORD_DATE)
                    .Group(new BsonDocument
                    {
                    { "_id", "$ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID" },
                    { "doc", new BsonDocument("$first", "$$ROOT") }
                    })
                    .Unwind("doc")
                    .Project(new BsonDocument("_id", 0)
                        .Add("RECORD_DATE", "$doc.RECORD_DATE")
                        .Add("ENTITY_METADATA", "$doc.ENTITY_METADATA")
                        .Add("VALUE", "$doc.VALUE")
                        .Add("VALUE_PER_SQM", "$doc.VALUE_PER_SQM")
                        .Add("VALUE_NAME", "$doc.VALUE_NAME"))
                    .ToList();
                oList_Entity_kpi_data = new List<Entity_kpi_data>();
                if (_query_response != null)
                {
                    foreach (var x in _query_response)
                    {
                        oList_Entity_kpi_data.Add(BsonSerializer.Deserialize<Entity_kpi_data>(x));
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Entity_kpi_data;
        }
        #endregion
        #endregion
        #region Floor
        #region Delete_Floor_Kpi_Data_By_Where
        public void Delete_Floor_Kpi_Data_By_Where(List<long?> FLOOR_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            #region filter
            var builder = Builders<Floor_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (FLOOR_ID_LIST != null)
            {
                mainFilter &= builder.In(floor_kpi_data => floor_kpi_data.FLOOR_METADATA.FLOOR_ID, FLOOR_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(floor_kpi_data => floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            #endregion
            try
            {
                var collection = Set_Floor_Db_Collection(ENUM_TIMESPAN);
                collection.DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Delete failed for one or more documents");
            }
        }
        #endregion
        #region Insert_Floor_Kpi_Data
        public void Insert_Floor_Kpi_Data(Floor_kpi_data i_Floor_kpi_data, Enum_Timespan i_Enum_Timespan)
        {
            if (i_Floor_kpi_data != null)
            {
                try
                {
                    var collection = Set_Floor_Db_Collection(i_Enum_Timespan);
                    collection.InsertOneAsync(i_Floor_kpi_data);
                }
                catch (Exception)
                {
                    throw new Exception("Insert failed for one document");
                }
            }
        }
        #endregion
        #region Insert_Floor_Kpi_Data_List
        public void Insert_Floor_Kpi_Data_List(List<Floor_kpi_data> i_List_Floor_kpi_data, Enum_Timespan i_Enum_Timespan)
        {
            if (i_List_Floor_kpi_data != null || i_List_Floor_kpi_data.Count() > 0)
            {
                try
                {
                    var collection = Set_Floor_Db_Collection(i_Enum_Timespan);
                    collection.InsertMany(i_List_Floor_kpi_data);
                }
                catch (Exception)
                {
                    throw new Exception("Insert failed for one or more document");
                }
            }
        }
        #endregion
        #region Get_Floor_Kpi_Data_By_Where
        public List<Floor_kpi_data> Get_Floor_Kpi_Data_By_Where(DateTime? START_DATE, DateTime? END_DATE, List<long?> FLOOR_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Floor_kpi_data> oList_Floor_kpi_data = null;
            #region filter
            var builder = Builders<Floor_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (FLOOR_ID_LIST != null)
            {
                mainFilter &= builder.In(floor_kpi_data => floor_kpi_data.FLOOR_METADATA.FLOOR_ID, FLOOR_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(floor_kpi_data => floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(floor_kpi_data => floor_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(floor_kpi_data => floor_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Floor_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Find(mainFilter);
                oList_Floor_kpi_data = new List<Floor_kpi_data>();
                if (_query_response != null)
                {
                    oList_Floor_kpi_data = _query_response.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Floor_kpi_data;
        }
        #endregion
        #region Get_Floor_Kpi_Data_Aggregate_Sum
        public List<Floor_kpi_data> Get_Floor_Kpi_Data_Aggregate_Sum(DateTime? START_DATE, DateTime? END_DATE, List<long?> FLOOR_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Floor_kpi_data> oList_Floor_kpi_data = null;
            #region filter
            var builder = Builders<Floor_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (FLOOR_ID_LIST != null)
            {
                mainFilter &= builder.In(floor_kpi_data => floor_kpi_data.FLOOR_METADATA.FLOOR_ID, FLOOR_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(floor_kpi_data => floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(floor_kpi_data => floor_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(floor_kpi_data => floor_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Floor_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                .Match(mainFilter)
                .Group(
                    groupBy => new { groupBy.FLOOR_METADATA.FLOOR_ID, groupBy.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, groupBy.FLOOR_METADATA.CATEGORY, groupBy.VALUE_NAME },
                    result => new
                    {
                        RECORD_DATE = result.Max(x => x.RECORD_DATE),
                        FLOOR_METADATA = result.First().FLOOR_METADATA,
                        VALUE = result.Sum(x => x.VALUE),
                        VALUE_PER_SQM = result.Sum(x => x.VALUE_PER_SQM),
                        VALUE_NAME = result.First().VALUE_NAME,
                    }
                ).ToList();
                oList_Floor_kpi_data = new List<Floor_kpi_data>();
                if (_query_response != null)
                {
                    Floor_kpi_data oFloor_kpi_data = new Floor_kpi_data();
                    foreach (var item in _query_response)
                    {
                        oFloor_kpi_data = new Floor_kpi_data();
                        oFloor_kpi_data.RECORD_DATE = item.RECORD_DATE;
                        oFloor_kpi_data.FLOOR_METADATA = item.FLOOR_METADATA;
                        oFloor_kpi_data.VALUE = item.VALUE;
                        oFloor_kpi_data.VALUE_NAME = item.VALUE_NAME;
                        oFloor_kpi_data.VALUE_PER_SQM = item.VALUE_PER_SQM;
                        oList_Floor_kpi_data.Add(oFloor_kpi_data);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Floor_kpi_data;
        }
        #endregion
        #region Get_Floor_Kpi_Data_Aggregate_Avg
        public List<Floor_kpi_data> Get_Floor_Kpi_Data_Aggregate_Avg(DateTime? START_DATE, DateTime? END_DATE, List<long?> FLOOR_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Floor_kpi_data> oList_Floor_kpi_data = null;
            #region filter
            var builder = Builders<Floor_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (FLOOR_ID_LIST != null)
            {
                mainFilter &= builder.In(floor_kpi_data => floor_kpi_data.FLOOR_METADATA.FLOOR_ID, FLOOR_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(floor_kpi_data => floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(floor_kpi_data => floor_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(floor_kpi_data => floor_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Floor_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                .Match(mainFilter)
                .Group(
                    groupBy => new { groupBy.FLOOR_METADATA.FLOOR_ID, groupBy.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, groupBy.FLOOR_METADATA.CATEGORY, groupBy.VALUE_NAME },
                    result => new
                    {
                        RECORD_DATE = result.Max(x => x.RECORD_DATE),
                        FLOOR_METADATA = result.First().FLOOR_METADATA,
                        VALUE = result.Average(x => x.VALUE),
                        VALUE_NAME = result.First().VALUE_NAME,
                    }
                ).ToList();
                oList_Floor_kpi_data = new List<Floor_kpi_data>();
                if (_query_response != null)
                {
                    Floor_kpi_data oFloor_kpi_data = new Floor_kpi_data();
                    oFloor_kpi_data.VALUE_PER_SQM = null;
                    foreach (var item in _query_response)
                    {
                        oFloor_kpi_data = new Floor_kpi_data();
                        oFloor_kpi_data.RECORD_DATE = item.RECORD_DATE;
                        oFloor_kpi_data.FLOOR_METADATA = item.FLOOR_METADATA;
                        oFloor_kpi_data.VALUE = item.VALUE;
                        oFloor_kpi_data.VALUE_NAME = item.VALUE_NAME;
                        oList_Floor_kpi_data.Add(oFloor_kpi_data);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Floor_kpi_data;
        }
        #endregion
        #region Get_Latest_Floor_Kpi_Data_Aggregate_By_KPI
        public List<Floor_kpi_data> Get_Latest_Floor_Kpi_Data_Aggregate_By_KPI(List<long?> FLOOR_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Floor_kpi_data> oList_Floor_kpi_data = null;
            #region filter
            var builder = Builders<Floor_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (FLOOR_ID_LIST != null)
            {
                mainFilter &= builder.In(floor_kpi_data => floor_kpi_data.FLOOR_METADATA.FLOOR_ID, FLOOR_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(floor_kpi_data => floor_kpi_data.FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            #endregion
            try
            {
                var collection = Set_Floor_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                    .Match(mainFilter)
                    .SortByDescending(x => x.RECORD_DATE)
                    .Group(new BsonDocument
                    {
                    { "_id", "$FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID" },
                    { "doc", new BsonDocument("$first", "$$ROOT") }
                    })
                    .Unwind("doc")
                    .Project(new BsonDocument("_id", 0)
                        .Add("RECORD_DATE", "$doc.RECORD_DATE")
                        .Add("FLOOR_METADATA", "$doc.FLOOR_METADATA")
                        .Add("VALUE", "$doc.VALUE")
                        .Add("VALUE_PER_SQM", "$doc.VALUE_PER_SQM")
                        .Add("VALUE_NAME", "$doc.VALUE_NAME"))
                    .ToList();
                oList_Floor_kpi_data = new List<Floor_kpi_data>();
                if (_query_response != null)
                {
                    foreach (var x in _query_response)
                    {
                        oList_Floor_kpi_data.Add(BsonSerializer.Deserialize<Floor_kpi_data>(x));
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Floor_kpi_data;
        }
        #endregion
        #endregion
        #region Space
        #region Delete_Space_Kpi_Data_By_Where
        public void Delete_Space_Kpi_Data_By_Where(List<long?> SPACE_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            #region filter
            var builder = Builders<Space_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (SPACE_ID_LIST != null)
            {
                mainFilter &= builder.In(space_kpi_data => space_kpi_data.SPACE_METADATA.SPACE_ID, SPACE_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(space_kpi_data => space_kpi_data.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            #endregion
            try
            {
                var collection = Set_Space_Db_Collection(ENUM_TIMESPAN);
                collection.DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Delete failed for one or more documents");
            }
        }
        #endregion
        #region Insert_Space_Kpi_Data
        public void Insert_Space_Kpi_Data(Space_kpi_data i_Space_kpi_data, Enum_Timespan i_Enum_Timespan)
        {
            if (i_Space_kpi_data != null)
            {
                try
                {
                    var collection = Set_Space_Db_Collection(i_Enum_Timespan);
                    collection.InsertOneAsync(i_Space_kpi_data);
                }
                catch (Exception)
                {
                    throw new Exception("Insert failed for one document");
                }
            }
        }
        #endregion
        #region Insert_Space_Kpi_Data_List
        public void Insert_Space_Kpi_Data_List(List<Space_kpi_data> i_List_Space_kpi_data, Enum_Timespan i_Enum_Timespan)
        {
            if (i_List_Space_kpi_data != null || i_List_Space_kpi_data.Count() > 0)
            {
                try
                {
                    var collection = Set_Space_Db_Collection(i_Enum_Timespan);
                    collection.InsertMany(i_List_Space_kpi_data);
                }
                catch (Exception)
                {
                    throw new Exception("Insert failed for one or more document");
                }
            }
        }
        #endregion
        #region Get_Space_Kpi_Data_By_Where
        public List<Space_kpi_data> Get_Space_Kpi_Data_By_Where(DateTime? START_DATE, DateTime? END_DATE, List<long?> SPACE_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Space_kpi_data> oList_Space_kpi_data = null;
            #region filter
            var builder = Builders<Space_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (SPACE_ID_LIST != null)
            {
                mainFilter &= builder.In(space_kpi_data => space_kpi_data.SPACE_METADATA.SPACE_ID, SPACE_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(space_kpi_data => space_kpi_data.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(space_kpi_data => space_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(space_kpi_data => space_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Space_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Find(mainFilter);
                oList_Space_kpi_data = new List<Space_kpi_data>();
                if (_query_response != null)
                {
                    oList_Space_kpi_data = _query_response.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Space_kpi_data;
        }
        #endregion
        #region Get_Space_Kpi_Data_Aggregate_Sum
        public List<Space_kpi_data> Get_Space_Kpi_Data_Aggregate_Sum(DateTime? START_DATE, DateTime? END_DATE, List<long?> SPACE_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Space_kpi_data> oList_Space_kpi_data = null;
            #region filter
            var builder = Builders<Space_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (SPACE_ID_LIST != null)
            {
                mainFilter &= builder.In(space_kpi_data => space_kpi_data.SPACE_METADATA.SPACE_ID, SPACE_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(space_kpi_data => space_kpi_data.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(space_kpi_data => space_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(space_kpi_data => space_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Space_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                .Match(mainFilter)
                .Group(
                    groupBy => new { groupBy.SPACE_METADATA.SPACE_ID, groupBy.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, groupBy.SPACE_METADATA.CATEGORY, groupBy.VALUE_NAME },
                    result => new
                    {
                        RECORD_DATE = result.Max(x => x.RECORD_DATE),
                        SPACE_METADATA = result.First().SPACE_METADATA,
                        VALUE = result.Sum(x => x.VALUE),
                        VALUE_PER_SQM = result.Sum(x => x.VALUE_PER_SQM),
                        VALUE_NAME = result.First().VALUE_NAME,
                    }
                ).ToList();
                oList_Space_kpi_data = new List<Space_kpi_data>();
                if (_query_response != null)
                {
                    Space_kpi_data oSpace_kpi_data = new Space_kpi_data();
                    foreach (var item in _query_response)
                    {
                        oSpace_kpi_data = new Space_kpi_data();
                        oSpace_kpi_data.RECORD_DATE = item.RECORD_DATE;
                        oSpace_kpi_data.SPACE_METADATA = item.SPACE_METADATA;
                        oSpace_kpi_data.VALUE = item.VALUE;
                        oSpace_kpi_data.VALUE_NAME = item.VALUE_NAME;
                        oSpace_kpi_data.VALUE_PER_SQM = item.VALUE_PER_SQM;
                        oList_Space_kpi_data.Add(oSpace_kpi_data);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Space_kpi_data;
        }
        #endregion
        #region Get_Space_Kpi_Data_Aggregate_Avg
        public List<Space_kpi_data> Get_Space_Kpi_Data_Aggregate_Avg(DateTime? START_DATE, DateTime? END_DATE, List<long?> SPACE_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Space_kpi_data> oList_Space_kpi_data = null;
            #region filter
            var builder = Builders<Space_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (SPACE_ID_LIST != null)
            {
                mainFilter &= builder.In(space_kpi_data => space_kpi_data.SPACE_METADATA.SPACE_ID, SPACE_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(space_kpi_data => space_kpi_data.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(space_kpi_data => space_kpi_data.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(space_kpi_data => space_kpi_data.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Space_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                .Match(mainFilter)
                .Group(
                    groupBy => new { groupBy.SPACE_METADATA.SPACE_ID, groupBy.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, groupBy.SPACE_METADATA.CATEGORY, groupBy.VALUE_NAME },
                    result => new
                    {
                        RECORD_DATE = result.Max(x => x.RECORD_DATE),
                        SPACE_METADATA = result.First().SPACE_METADATA,
                        VALUE = result.Average(x => x.VALUE),
                        VALUE_NAME = result.First().VALUE_NAME,
                    }
                ).ToList();
                oList_Space_kpi_data = new List<Space_kpi_data>();
                if (_query_response != null)
                {
                    Space_kpi_data oSpace_kpi_data = new Space_kpi_data();
                    foreach (var item in _query_response)
                    {
                        oSpace_kpi_data = new Space_kpi_data();
                        oSpace_kpi_data.VALUE_PER_SQM = null;
                        oSpace_kpi_data.RECORD_DATE = item.RECORD_DATE;
                        oSpace_kpi_data.SPACE_METADATA = item.SPACE_METADATA;
                        oSpace_kpi_data.VALUE = item.VALUE;
                        oSpace_kpi_data.VALUE_NAME = item.VALUE_NAME;
                        oList_Space_kpi_data.Add(oSpace_kpi_data);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Space_kpi_data;
        }
        #endregion
        #region Get_Latest_Space_Kpi_Data_Aggregate_By_KPI
        public List<Space_kpi_data> Get_Latest_Space_Kpi_Data_Aggregate_By_KPI(List<long?> SPACE_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Space_kpi_data> oList_Space_kpi_data = null;
            #region filter
            var builder = Builders<Space_kpi_data>.Filter;
            var mainFilter = builder.Empty;
            if (SPACE_ID_LIST != null)
            {
                mainFilter &= builder.In(space_kpi_data => space_kpi_data.SPACE_METADATA.SPACE_ID, SPACE_ID_LIST);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null && ORGANIZATION_DATA_SOURCE_KPI_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(space_kpi_data => space_kpi_data.SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
            }
            #endregion
            try
            {
                var collection = Set_Space_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                    .Match(mainFilter)
                    .SortByDescending(x => x.RECORD_DATE)
                    .Group(new BsonDocument
                    {
                    { "_id", "$SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID" },
                    { "doc", new BsonDocument("$first", "$$ROOT") }
                    })
                    .Unwind("doc")
                    .Project(new BsonDocument("_id", 0)
                        .Add("RECORD_DATE", "$doc.RECORD_DATE")
                        .Add("SPACE_METADATA", "$doc.SPACE_METADATA")
                        .Add("VALUE", "$doc.VALUE")
                        .Add("VALUE_PER_SQM", "$doc.VALUE_PER_SQM")
                        .Add("VALUE_NAME", "$doc.VALUE_NAME"))
                    .ToList();
                oList_Space_kpi_data = new List<Space_kpi_data>();
                if (_query_response != null)
                {
                    foreach (var x in _query_response)
                    {
                        oList_Space_kpi_data.Add(BsonSerializer.Deserialize<Space_kpi_data>(x));
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Space_kpi_data;
        }
        #endregion
        #endregion

        #region Set_X_Db_Collection
        #region Set_District_Db_Collection
        private IMongoCollection<District_kpi_data> Set_District_Db_Collection(Enum_Timespan i_Enum_Timespan)
        {
            IMongoCollection<District_kpi_data> result = null;
            switch (i_Enum_Timespan)
            {
                case Enum_Timespan.X_HOURLY_COLLECTION:
                    result = this.db.GetCollection<District_kpi_data>(DISTRICT_KPI_DATA_COLLECTION + X_HOURLY_COLLECTION);
                    break;
                case Enum_Timespan.X_DAILY_COLLECTION:
                    result = this.db.GetCollection<District_kpi_data>(DISTRICT_KPI_DATA_COLLECTION + X_DAILY_COLLECTION);
                    break;
                case Enum_Timespan.X_WEEKLY_COLLECTION:
                    result = this.db.GetCollection<District_kpi_data>(DISTRICT_KPI_DATA_COLLECTION + X_WEEKLY_COLLECTION);
                    break;
                case Enum_Timespan.X_MONTHLY_COLLECTION:
                    result = this.db.GetCollection<District_kpi_data>(DISTRICT_KPI_DATA_COLLECTION + X_MONTHLY_COLLECTION);
                    break;
                case Enum_Timespan.X_QUARTERLY_COLLECTION:
                    result = this.db.GetCollection<District_kpi_data>(DISTRICT_KPI_DATA_COLLECTION + X_QUARTERLY_COLLECTION);
                    break;
            }
            return result;
        }
        #endregion
        #region Set_District_Db_Collection
        private IMongoCollection<Area_kpi_data> Set_Area_Db_Collection(Enum_Timespan i_Enum_Timespan)
        {
            IMongoCollection<Area_kpi_data> result = null;
            switch (i_Enum_Timespan)
            {
                case Enum_Timespan.X_HOURLY_COLLECTION:
                    result = this.db.GetCollection<Area_kpi_data>(AREA_KPI_DATA_COLLECTION + X_HOURLY_COLLECTION);
                    break;
                case Enum_Timespan.X_DAILY_COLLECTION:
                    result = this.db.GetCollection<Area_kpi_data>(AREA_KPI_DATA_COLLECTION + X_DAILY_COLLECTION);
                    break;
                case Enum_Timespan.X_WEEKLY_COLLECTION:
                    result = this.db.GetCollection<Area_kpi_data>(AREA_KPI_DATA_COLLECTION + X_WEEKLY_COLLECTION);
                    break;
                case Enum_Timespan.X_MONTHLY_COLLECTION:
                    result = this.db.GetCollection<Area_kpi_data>(AREA_KPI_DATA_COLLECTION + X_MONTHLY_COLLECTION);
                    break;
                case Enum_Timespan.X_QUARTERLY_COLLECTION:
                    result = this.db.GetCollection<Area_kpi_data>(AREA_KPI_DATA_COLLECTION + X_QUARTERLY_COLLECTION);
                    break;
            }
            return result;
        }
        #endregion
        #region Set_Site_Db_Collection
        private IMongoCollection<Site_kpi_data> Set_Site_Db_Collection(Enum_Timespan i_Enum_Timespan)
        {
            IMongoCollection<Site_kpi_data> result = null;
            switch (i_Enum_Timespan)
            {
                case Enum_Timespan.X_HOURLY_COLLECTION:
                    result = this.db.GetCollection<Site_kpi_data>(SITE_KPI_DATA_COLLECTION + X_HOURLY_COLLECTION);
                    break;
                case Enum_Timespan.X_DAILY_COLLECTION:
                    result = this.db.GetCollection<Site_kpi_data>(SITE_KPI_DATA_COLLECTION + X_DAILY_COLLECTION);
                    break;
                case Enum_Timespan.X_WEEKLY_COLLECTION:
                    result = this.db.GetCollection<Site_kpi_data>(SITE_KPI_DATA_COLLECTION + X_WEEKLY_COLLECTION);
                    break;
                case Enum_Timespan.X_MONTHLY_COLLECTION:
                    result = this.db.GetCollection<Site_kpi_data>(SITE_KPI_DATA_COLLECTION + X_MONTHLY_COLLECTION);
                    break;
                case Enum_Timespan.X_QUARTERLY_COLLECTION:
                    result = this.db.GetCollection<Site_kpi_data>(SITE_KPI_DATA_COLLECTION + X_QUARTERLY_COLLECTION);
                    break;
            }
            return result;
        }
        #endregion
        #region Set_Entity_Db_Collection
        private IMongoCollection<Entity_kpi_data> Set_Entity_Db_Collection(Enum_Timespan i_Enum_Timespan)
        {
            IMongoCollection<Entity_kpi_data> result = null;
            switch (i_Enum_Timespan)
            {
                case Enum_Timespan.X_HOURLY_COLLECTION:
                    result = this.db.GetCollection<Entity_kpi_data>(ENTITY_KPI_DATA_COLLECTION + X_HOURLY_COLLECTION);
                    break;
                case Enum_Timespan.X_DAILY_COLLECTION:
                    result = this.db.GetCollection<Entity_kpi_data>(ENTITY_KPI_DATA_COLLECTION + X_DAILY_COLLECTION);
                    break;
                case Enum_Timespan.X_WEEKLY_COLLECTION:
                    result = this.db.GetCollection<Entity_kpi_data>(ENTITY_KPI_DATA_COLLECTION + X_WEEKLY_COLLECTION);
                    break;
                case Enum_Timespan.X_MONTHLY_COLLECTION:
                    result = this.db.GetCollection<Entity_kpi_data>(ENTITY_KPI_DATA_COLLECTION + X_MONTHLY_COLLECTION);
                    break;
                case Enum_Timespan.X_QUARTERLY_COLLECTION:
                    result = this.db.GetCollection<Entity_kpi_data>(ENTITY_KPI_DATA_COLLECTION + X_QUARTERLY_COLLECTION);
                    break;
            }
            return result;
        }
        #endregion
        #region Set_Floor_Db_Collection
        private IMongoCollection<Floor_kpi_data> Set_Floor_Db_Collection(Enum_Timespan i_Enum_Timespan)
        {
            IMongoCollection<Floor_kpi_data> result = null;
            switch (i_Enum_Timespan)
            {
                case Enum_Timespan.X_HOURLY_COLLECTION:
                    result = this.db.GetCollection<Floor_kpi_data>(FLOOR_KPI_DATA_COLLECTION + X_HOURLY_COLLECTION);
                    break;
                case Enum_Timespan.X_DAILY_COLLECTION:
                    result = this.db.GetCollection<Floor_kpi_data>(FLOOR_KPI_DATA_COLLECTION + X_DAILY_COLLECTION);
                    break;
                case Enum_Timespan.X_WEEKLY_COLLECTION:
                    result = this.db.GetCollection<Floor_kpi_data>(FLOOR_KPI_DATA_COLLECTION + X_WEEKLY_COLLECTION);
                    break;
                case Enum_Timespan.X_MONTHLY_COLLECTION:
                    result = this.db.GetCollection<Floor_kpi_data>(FLOOR_KPI_DATA_COLLECTION + X_MONTHLY_COLLECTION);
                    break;
                case Enum_Timespan.X_QUARTERLY_COLLECTION:
                    result = this.db.GetCollection<Floor_kpi_data>(FLOOR_KPI_DATA_COLLECTION + X_QUARTERLY_COLLECTION);
                    break;
            }
            return result;
        }
        #endregion
        #region Set_Space_Db_Collection
        private IMongoCollection<Space_kpi_data> Set_Space_Db_Collection(Enum_Timespan i_Enum_Timespan)
        {
            IMongoCollection<Space_kpi_data> result = null;
            switch (i_Enum_Timespan)
            {
                case Enum_Timespan.X_HOURLY_COLLECTION:
                    result = this.db.GetCollection<Space_kpi_data>(SPACE_KPI_DATA_COLLECTION + X_HOURLY_COLLECTION);
                    break;
                case Enum_Timespan.X_DAILY_COLLECTION:
                    result = this.db.GetCollection<Space_kpi_data>(SPACE_KPI_DATA_COLLECTION + X_DAILY_COLLECTION);
                    break;
                case Enum_Timespan.X_WEEKLY_COLLECTION:
                    result = this.db.GetCollection<Space_kpi_data>(SPACE_KPI_DATA_COLLECTION + X_WEEKLY_COLLECTION);
                    break;
                case Enum_Timespan.X_MONTHLY_COLLECTION:
                    result = this.db.GetCollection<Space_kpi_data>(SPACE_KPI_DATA_COLLECTION + X_MONTHLY_COLLECTION);
                    break;
                case Enum_Timespan.X_QUARTERLY_COLLECTION:
                    result = this.db.GetCollection<Space_kpi_data>(SPACE_KPI_DATA_COLLECTION + X_QUARTERLY_COLLECTION);
                    break;
            }
            return result;
        }
        #endregion
        #endregion

        #region General
        #region Drop_Collection
        public void Drop_Collection(string COLLECTION_NAME)
        {
            try
            {
                db.DropCollection(COLLECTION_NAME);
            }
            catch { }
        }
        #endregion
        #region Create_Time_series_Collection
        public void Create_Time_series_Collection(string TIME_SERIES_COLLECTION_NAME)
        {
            try
            {
                db.DropCollection(TIME_SERIES_COLLECTION_NAME);
            }
            catch { }
            db.CreateCollection(TIME_SERIES_COLLECTION_NAME, new CreateCollectionOptions
            {
                TimeSeriesOptions = new TimeSeriesOptions("RECORD_DATE", "METADATA", TimeSeriesGranularity.Hours),
            });
        }
        #endregion
        #endregion

        #region Alert
        #region Delete_Alert
        public void Delete_Alert(List<string> ALERT_ID_LIST, List<long?> USER_ID_LIST, DateTime? START_DATE, DateTime? END_DATE, bool? IS_ACKNOWLEDGED, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? LEVEL_SETUP_ID)
        {
            var mainFilter = Get_Alerts_Filter(
                END_DATE: END_DATE,
                START_DATE: START_DATE,
                ALERT_ID_LIST: ALERT_ID_LIST,
                USER_ID_LIST: USER_ID_LIST,
                IS_ACKNOWLEDGED: IS_ACKNOWLEDGED,
                LEVEL_SETUP_ID: LEVEL_SETUP_ID,
                ORGANIZATION_DATA_SOURCE_KPI_ID: ORGANIZATION_DATA_SOURCE_KPI_ID
            );
            try
            {
                this.db.GetCollection<Alert>(ALERT_COLLECTION).DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Failed to delete documents");
            }
        }
        #endregion
        #region Edit_Alert_List
        public void Edit_Alert_List(List<Alert> i_List_Alert)
        {
            try
            {
                var collection = this.db.GetCollection<Alert>(ALERT_COLLECTION);
                List<Alert> oList_Alert_To_Insert = i_List_Alert.Where(alert => alert.ALERT_ID == null).ToList();
                List<Alert> oList_Alert_To_Update = i_List_Alert.Where(alert => alert.ALERT_ID != null).ToList();
                if (oList_Alert_To_Insert.Count() > 0)
                {
                    collection.InsertMany(oList_Alert_To_Insert);
                }
                foreach (Alert alert in oList_Alert_To_Update)
                {
                    collection.ReplaceOne(alert_To_Replace => alert_To_Replace.ALERT_ID == alert.ALERT_ID, alert, new ReplaceOptions() { IsUpsert = true });
                }
            }
            catch (Exception)
            {
                throw new Exception("Edit failed for one or more documents");
            }
        }
        #endregion
        #region Get_Alerts_Filter
        public FilterDefinition<Alert> Get_Alerts_Filter(List<string> ALERT_ID_LIST, List<long?> USER_ID_LIST, DateTime? START_DATE, DateTime? END_DATE, bool? IS_ACKNOWLEDGED, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? LEVEL_SETUP_ID)
        {
            var builder = Builders<Alert>.Filter;
            var mainFilter = builder.Empty;
            if (ALERT_ID_LIST != null && ALERT_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(alert => alert.ALERT_ID, ALERT_ID_LIST);
            }
            if (USER_ID_LIST != null && USER_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(alert => alert.USER_ID, USER_ID_LIST);
            }
            if (IS_ACKNOWLEDGED != null)
            {
                mainFilter &= builder.Eq(alert => alert.IS_ACKNOWLEDGED, IS_ACKNOWLEDGED);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(alert => alert.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(alert => alert.RECORD_DATE, End_Date);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID != null)
            {
                mainFilter &= builder.Eq(alert => alert.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID);
            }
            if (LEVEL_SETUP_ID != null)
            {
                mainFilter &= builder.Eq(alert => alert.LEVEL_SETUP_ID, LEVEL_SETUP_ID);
            }
            return mainFilter;
        }
        #endregion
        #region Get_Alerts_By_Where
        public List<Alert> Get_Alerts_By_Where(List<string> ALERT_ID_LIST, List<long?> USER_ID_LIST, DateTime? START_DATE, DateTime? END_DATE, bool? IS_ACKNOWLEDGED, int? ORGANIZATION_DATA_SOURCE_KPI_ID, long? LEVEL_SETUP_ID, List<long?> LEVEL_ID_LIST)
        {
            #region Filter

            var builder = Builders<Alert>.Filter;
            var mainFilter = builder.Empty;
            if (ALERT_ID_LIST != null && ALERT_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(alert => alert.ALERT_ID, ALERT_ID_LIST);
            }
            if (USER_ID_LIST != null && USER_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(alert => alert.USER_ID, USER_ID_LIST);
            }
            if (IS_ACKNOWLEDGED != null)
            {
                mainFilter &= builder.Eq(alert => alert.IS_ACKNOWLEDGED, IS_ACKNOWLEDGED);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(alert => alert.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(alert => alert.RECORD_DATE, End_Date);
            }
            if (ORGANIZATION_DATA_SOURCE_KPI_ID != null)
            {
                mainFilter &= builder.Eq(alert => alert.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID);
            }
            if (LEVEL_SETUP_ID != null)
            {
                mainFilter &= builder.Eq(alert => alert.LEVEL_SETUP_ID, LEVEL_SETUP_ID);
            }
            if (LEVEL_ID_LIST != null && LEVEL_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(alert => alert.LEVEL_ID, LEVEL_ID_LIST);
            }

            #endregion
            try
            {
                return this.db.GetCollection<Alert>(ALERT_COLLECTION).Find(mainFilter).ToList();
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #region Get_Alerts_By_Where_Count
        public long Get_Alerts_By_Where_Count(List<string> ALERT_ID_LIST, List<long?> USER_ID_LIST, DateTime? START_DATE, DateTime? END_DATE, bool? IS_ACKNOWLEDGED)
        {
            var mainFilter = Get_Alerts_Filter(
                END_DATE: END_DATE,
                START_DATE: START_DATE,
                ALERT_ID_LIST: ALERT_ID_LIST,
                USER_ID_LIST: USER_ID_LIST,
                IS_ACKNOWLEDGED: IS_ACKNOWLEDGED,
                ORGANIZATION_DATA_SOURCE_KPI_ID: null,
                LEVEL_SETUP_ID: null
            );
            try
            {
                return this.db.GetCollection<Alert>(ALERT_COLLECTION).CountDocuments(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #endregion
    }

    #region Otp
    public partial class Otp
    {
        [BsonId]
        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.ObjectId)]
        public string OTP_ID { get; set; }
        public long? USER_ID { get; set; }
        public string OTP { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? ENTRY_DATE { get; set; }
    }
    #endregion
    #region Job
    public partial class Job
    {
        [BsonId]
        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.ObjectId)]
        public string JOB_ID { get; set; }
        public string JOB_REQUEST_ID { get; set; }
        public long? REQUEST_SETUP_ID { get; set; }
        public int? DWELL_TIME_BUCKET { get; set; }
        public List<long?> SITE_ID_LIST { get; set; }
        public int? MIN_DWELL_TIME { get; set; }
        public int? MAX_DWELL_TIME { get; set; }
        public bool? IS_EXCLUDE_NON_WORKERS { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? START_DATE { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? END_DATE { get; set; }
    }
    #endregion
    #region Job_With_Count
    public partial class Job_With_Count
    {
        public long COUNT { get; set; }
        public List<Job> List_Job { get; set; }
    }
    #endregion

    #region GeoData
    public partial class GeoData
    {
        [BsonId]
        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.ObjectId)]
        public string GEODATA_ID { get; set; }
        public int ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public Location Location { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? DATE_START { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
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
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime RECORD_DATE { get; set; }
        public District_metadata DISTRICT_METADATA { get; set; }
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
        public decimal VALUE { get; set; }
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
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
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime RECORD_DATE { get; set; }
        public Area_metadata AREA_METADATA { get; set; }
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
        public decimal VALUE { get; set; }
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
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
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime RECORD_DATE { get; set; }
        public Site_metadata SITE_METADATA { get; set; }
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
        public decimal VALUE { get; set; }
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
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
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime RECORD_DATE { get; set; }
        public Entity_metadata ENTITY_METADATA { get; set; }
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
        public decimal VALUE { get; set; }
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
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
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime RECORD_DATE { get; set; }
        public Floor_metadata FLOOR_METADATA { get; set; }
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
        public decimal VALUE { get; set; }
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
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
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime RECORD_DATE { get; set; }
        public Space_metadata SPACE_METADATA { get; set; }
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
        public decimal VALUE { get; set; }
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
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

    #region Alert
    public partial class Alert
    {
        [BsonId]
        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ALERT_ID { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? RECORD_DATE { get; set; }
        public long? USER_ID { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal? ALERT_VALUE { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal? VALUE_PASSED { get; set; }
        public long? VALUE_TYPE_SETUP_ID { get; set; }
        public long? OPERATION_TYPE_SETUP_ID { get; set; }
        public int? ORGANIZATION_DATA_SOURCE_KPI_ID { get; set; }
        public long? LEVEL_SETUP_ID { get; set; }
        public long? LEVEL_ID { get; set; }
        public bool? IS_ACKNOWLEDGED { get; set; }
    }
    #endregion

    #region Niche_categories
    public partial class Niche_categories
    {
        [BsonId]
        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.ObjectId)]
        public string NICHE_CATEGORIES_ID { get; set; }
        public string BUSINESS_NICHE { get; set; }
        public List<string> CATEGORY_LIST { get; set; }
        public string NICHE_COLOR { get; set; }
    }
    #endregion
}
