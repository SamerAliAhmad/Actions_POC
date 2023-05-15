using System;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using System.Linq;
using System.Text.Json;

namespace DALC
{
    public partial class DALC_MONGODB
    {
        private IMongoDatabase db;
        private readonly string OTP_COLLECTION = "OTP";
        private readonly string JOB_COLLECTION = "JOB";
        private readonly string KPI_CHART_CONFIGURATION_COLLECTION = "COL_KPI_CHART_CONFIGURATION";
        private readonly string DIMENSION_CHART_CONFIGURATION_COLLECTION = "COL_DIMENSION_CHART_CONFIGURATION";
        private readonly string SPECIALIZED_CHART_CONFIGURATION_COLLECTION = "COL_SPECIALIZED_CHART_CONFIGURATION";
        private readonly string DISTRICT_GEOJSON_COLLECTION = "COL_DISTRICT_GEOJSON";
        private readonly string AREA_GEOJSON_COLLECTION = "COL_AREA_GEOJSON";
        private readonly string SITE_GEOJSON_COLLECTION = "COL_SITE_GEOJSON";
        private readonly string EXT_STUDY_ZONE_GEOJSON_COLLECTION = "COL_EXT_STUDY_ZONE_GEOJSON";

        public DALC_MONGODB(string server, string database)
        {
            var client = new MongoClient(server);
            this.db = client.GetDatabase(database);
        }
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
        public void Delete_Job(List<string> JOB_ID_LIST, List<long?> REQUEST_SETUP_ID_LIST, List<int?> DWELL_TIME_BUCKET_LIST, List<int?> SITE_ID_LIST, List<int?> MIN_DWELL_TIME_LIST, List<int?> MAX_DWELL_TIME_LIST, DateTime? START_DATE, DateTime? END_DATE, bool? IS_EXCLUDE_NON_WORKERS, string JOB_REQUEST_ID)
        {
            try
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
                this.db.GetCollection<Job>(JOB_COLLECTION).DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Delete failed for documents");
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
                throw new Exception("Edit failed for one or more document");
            }
        }
        #endregion
        #region Get_Jobs_Filter
        public FilterDefinition<Job> Get_Jobs_Filter(List<string> JOB_ID_LIST, List<long?> REQUEST_SETUP_ID_LIST, List<int?> DWELL_TIME_BUCKET_LIST, List<int?> SITE_ID_LIST, List<int?> MIN_DWELL_TIME_LIST, List<int?> MAX_DWELL_TIME_LIST, DateTime? START_DATE, DateTime? END_DATE, bool? IS_EXCLUDE_NON_WORKERS, string JOB_REQUEST_ID)
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
                mainFilter &= builder.Eq(job => job.START_DATE, START_DATE);
            }
            if (END_DATE != null)
            {
                mainFilter &= builder.Eq(job => job.END_DATE, END_DATE);
            }
            return mainFilter;
        }
        #endregion
        #region Get_Jobs_By_Where
        public List<Job> Get_Jobs_By_Where(List<string> JOB_ID_LIST, List<long?> REQUEST_SETUP_ID_LIST, List<int?> DWELL_TIME_BUCKET_LIST, List<int?> SITE_ID_LIST, List<int?> MIN_DWELL_TIME_LIST, List<int?> MAX_DWELL_TIME_LIST, DateTime? START_DATE, DateTime? END_DATE, bool? IS_EXCLUDE_NON_WORKERS, string JOB_REQUEST_ID)
        {
            List<Job> oList_Job = new List<Job>();

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
                oList_Job = this.db.GetCollection<Job>(JOB_COLLECTION).Find(mainFilter).ToList();
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Job;
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

        #region Chart_configuration

        #region Delete_Dimension_chart_configuration_By_DIMENSION_CHART_CONFIGURATION_ID
        public void Delete_Dimension_chart_configuration_By_DIMENSION_CHART_CONFIGURATION_ID(string DIMENSION_CHART_CONFIGURATION_ID)
        {
            if (DIMENSION_CHART_CONFIGURATION_ID != null)
            {
                var builder = Builders<Dimension_chart_configuration>.Filter;
                var mainFilter = builder.Empty;
                mainFilter &= builder.Eq(oDimension_chart_configuration => oDimension_chart_configuration.DIMENSION_CHART_CONFIGURATION_ID, DIMENSION_CHART_CONFIGURATION_ID);
                try
                {
                    var collection = this.db.GetCollection<Dimension_chart_configuration>(DIMENSION_CHART_CONFIGURATION_COLLECTION);
                    collection.DeleteOne(mainFilter);
                }
                catch (Exception)
                {
                    throw new Exception("Delete failed for document");
                }
            }
        }
        #endregion
        #region Delete_Kpi_chart_configuration_By_KPI_CHART_CONFIGURATION_ID
        public void Delete_Kpi_chart_configuration_By_KPI_CHART_CONFIGURATION_ID(string KPI_CHART_CONFIGURATION_ID)
        {
            if (KPI_CHART_CONFIGURATION_ID != null)
            {
                var builder = Builders<Kpi_chart_configuration>.Filter;
                var mainFilter = builder.Empty;
                mainFilter &= builder.Eq(oKpi_chart_configuration => oKpi_chart_configuration.KPI_CHART_CONFIGURATION_ID, KPI_CHART_CONFIGURATION_ID);
                try
                {
                    var collection = this.db.GetCollection<Kpi_chart_configuration>(KPI_CHART_CONFIGURATION_COLLECTION);
                    collection.DeleteOne(mainFilter);
                }
                catch (Exception)
                {
                    throw new Exception("Delete failed for document");
                }
            }
        }
        #endregion
        #region Delete_Specialized_chart_configuration_By_SPECIALIZED_CHART_CONFIGURATION_ID
        public void Delete_Specialized_chart_configuration_By_SPECIALIZED_CHART_CONFIGURATION_ID(string SPECIALIZED_CHART_CONFIGURATION_ID)
        {
            if (SPECIALIZED_CHART_CONFIGURATION_ID != null)
            {
                var builder = Builders<Specialized_chart_configuration>.Filter;
                var mainFilter = builder.Empty;
                mainFilter &= builder.Eq(oSpecialized_chart_configuration => oSpecialized_chart_configuration.SPECIALIZED_CHART_CONFIGURATION_ID, SPECIALIZED_CHART_CONFIGURATION_ID);
                try
                {
                    var collection = this.db.GetCollection<Specialized_chart_configuration>(SPECIALIZED_CHART_CONFIGURATION_COLLECTION);
                    collection.DeleteOne(mainFilter);
                }
                catch (Exception)
                {
                    throw new Exception("Delete failed for document");
                }
            }
        }
        #endregion

        #region Edit_Dimension_chart_configuration
        public string Edit_Dimension_chart_configuration(Dimension_chart_configuration i_Dimension_chart_configuration)
        {
            if (i_Dimension_chart_configuration != null)
            {
                var builder = Builders<Dimension_chart_configuration>.Filter;
                var mainFilter = builder.Empty;
                mainFilter &= builder.Eq(oDimension_chart_configuration => oDimension_chart_configuration.DIMENSION_CHART_CONFIGURATION_ID, i_Dimension_chart_configuration.DIMENSION_CHART_CONFIGURATION_ID);
                try
                {
                    var collection = this.db.GetCollection<Dimension_chart_configuration>(DIMENSION_CHART_CONFIGURATION_COLLECTION);
                    if (i_Dimension_chart_configuration.DIMENSION_CHART_CONFIGURATION_ID != null)
                    {
                        collection.ReplaceOne(mainFilter, i_Dimension_chart_configuration, new ReplaceOptions { IsUpsert = true });
                    }
                    else
                    {
                        collection.InsertOne(i_Dimension_chart_configuration);
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Edit failed for one document");
                }
            }
            return i_Dimension_chart_configuration.DIMENSION_CHART_CONFIGURATION_ID;
        }
        #endregion
        #region Edit_Kpi_chart_configuration
        public string Edit_Kpi_chart_configuration(Kpi_chart_configuration i_Kpi_chart_configuration)
        {
            if (i_Kpi_chart_configuration != null)
            {
                var builder = Builders<Kpi_chart_configuration>.Filter;
                var mainFilter = builder.Empty;
                mainFilter &= builder.Eq(oKpi_chart_configuration => oKpi_chart_configuration.KPI_CHART_CONFIGURATION_ID, i_Kpi_chart_configuration.KPI_CHART_CONFIGURATION_ID);
                try
                {
                    var collection = this.db.GetCollection<Kpi_chart_configuration>(KPI_CHART_CONFIGURATION_COLLECTION);
                    if (i_Kpi_chart_configuration.KPI_CHART_CONFIGURATION_ID != null)
                    {
                        collection.ReplaceOne(mainFilter, i_Kpi_chart_configuration, new ReplaceOptions { IsUpsert = true });
                    }
                    else
                    {
                        collection.InsertOne(i_Kpi_chart_configuration);
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Edit failed for one document");
                }
            }
            return i_Kpi_chart_configuration.KPI_CHART_CONFIGURATION_ID;
        }
        #endregion
        #region Edit_Specialized_chart_configuration
        public string Edit_Specialized_chart_configuration(Specialized_chart_configuration i_Specialized_chart_configuration)
        {
            if (i_Specialized_chart_configuration != null)
            {
                var builder = Builders<Specialized_chart_configuration>.Filter;
                var mainFilter = builder.Empty;
                mainFilter &= builder.Eq(oSpecialized_chart_configuration => oSpecialized_chart_configuration.SPECIALIZED_CHART_CONFIGURATION_ID, i_Specialized_chart_configuration.SPECIALIZED_CHART_CONFIGURATION_ID);
                try
                {
                    var collection = this.db.GetCollection<Specialized_chart_configuration>(SPECIALIZED_CHART_CONFIGURATION_COLLECTION);
                    if (i_Specialized_chart_configuration.SPECIALIZED_CHART_CONFIGURATION_ID != null)
                    {
                        collection.ReplaceOne(mainFilter, i_Specialized_chart_configuration, new ReplaceOptions { IsUpsert = true });
                    }
                    else
                    {
                        collection.InsertOne(i_Specialized_chart_configuration);
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Edit failed for one document");
                }
            }
            return i_Specialized_chart_configuration.SPECIALIZED_CHART_CONFIGURATION_ID;
        }
        #endregion

        #region Get_Dimension_chart_configuration
        public IEnumerable<Dimension_chart_configuration> Get_Dimension_chart_configuration()
        {
            IEnumerable<Dimension_chart_configuration> oList_Dimension_chart_configuration = null;
            var mainFilter = Builders<Dimension_chart_configuration>.Filter.Empty;
            try
            {
                var collection = this.db.GetCollection<Dimension_chart_configuration>(DIMENSION_CHART_CONFIGURATION_COLLECTION);
                var _query_response = collection.Find(mainFilter);
                if (_query_response != null)
                {
                    oList_Dimension_chart_configuration = _query_response.ToEnumerable();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Dimension_chart_configuration;
        }
        #endregion
        #region Get_Kpi_chart_configuration
        public IEnumerable<Kpi_chart_configuration> Get_Kpi_chart_configuration()
        {
            IEnumerable<Kpi_chart_configuration> oList_Kpi_chart_configuration = null;
            var mainFilter = Builders<Kpi_chart_configuration>.Filter.Empty;
            try
            {
                var collection = this.db.GetCollection<Kpi_chart_configuration>(KPI_CHART_CONFIGURATION_COLLECTION);
                var _query_response = collection.Find(mainFilter);
                if (_query_response != null)
                {
                    oList_Kpi_chart_configuration = _query_response.ToEnumerable();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Kpi_chart_configuration;
        }
        #endregion
        #region Get_Specialized_chart_configuration
        public IEnumerable<Specialized_chart_configuration> Get_Specialized_chart_configuration()
        {
            IEnumerable<Specialized_chart_configuration> oList_Specialized_chart_configuration = null;
            var mainFilter = Builders<Specialized_chart_configuration>.Filter.Empty;
            try
            {
                var collection = this.db.GetCollection<Specialized_chart_configuration>(SPECIALIZED_CHART_CONFIGURATION_COLLECTION);
                var _query_response = collection.Find(mainFilter);
                if (_query_response != null)
                {
                    oList_Specialized_chart_configuration = _query_response.ToEnumerable();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Specialized_chart_configuration;
        }
        #endregion
        #region Get_Specialized_chart_configuration_By_MODULE
        public IEnumerable<Specialized_chart_configuration> Get_Specialized_chart_configuration_By_MODULE(string MODULE)
        {
            IEnumerable<Specialized_chart_configuration> oList_Specialized_chart_configuration = null;
            var builder = Builders<Specialized_chart_configuration>.Filter;
            var mainFilter = builder.Empty;
            mainFilter &= builder.Eq(oSpecialized_chart_configuration => oSpecialized_chart_configuration.MODULE, MODULE);
            try
            {
                var collection = this.db.GetCollection<Specialized_chart_configuration>(SPECIALIZED_CHART_CONFIGURATION_COLLECTION);
                var _query_response = collection.Find(mainFilter);
                if (_query_response != null)
                {
                    oList_Specialized_chart_configuration = _query_response.ToEnumerable();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Specialized_chart_configuration;
        }
        #endregion

        #endregion

        #region Geojson

        #region Delete_District_geojson_By_DISTRICT_ID
        public void Delete_District_geojson_By_DISTRICT_ID(long? DISTRICT_ID)
        {
            if (DISTRICT_ID != null)
            {
                var builder = Builders<BsonDocument>.Filter;
                var mainFilter = builder.Empty;
                mainFilter &= builder.Eq("id", DISTRICT_ID);
                try
                {
                    var collection = this.db.GetCollection<BsonDocument>(DISTRICT_GEOJSON_COLLECTION);
                    collection.DeleteOne(mainFilter);
                }
                catch (Exception)
                {
                    throw new Exception("Delete failed for document");
                }
            }
        }
        #endregion
        #region Delete_Area_geojson_By_AREA_ID
        public void Delete_Area_geojson_By_AREA_ID(long? AREA_ID)
        {
            if (AREA_ID != null)
            {
                var builder = Builders<BsonDocument>.Filter;
                var mainFilter = builder.Empty;
                mainFilter &= builder.Eq("id", AREA_ID);
                try
                {
                    var collection = this.db.GetCollection<BsonDocument>(AREA_GEOJSON_COLLECTION);
                    collection.DeleteOne(mainFilter);
                }
                catch (Exception)
                {
                    throw new Exception("Delete failed for document");
                }
            }
        }
        #endregion
        #region Delete_Site_geojson_By_SITE_ID
        public void Delete_Site_geojson_By_SITE_ID(long? SITE_ID)
        {
            if (SITE_ID != null)
            {
                var builder = Builders<BsonDocument>.Filter;
                var mainFilter = builder.Empty;
                mainFilter &= builder.Eq("id", SITE_ID);
                try
                {
                    var collection = this.db.GetCollection<BsonDocument>(SITE_GEOJSON_COLLECTION);
                    collection.DeleteOne(mainFilter);
                }
                catch (Exception)
                {
                    throw new Exception("Delete failed for document");
                }
            }
        }
        #endregion
        #region Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID
        public void Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID(int? EXT_STUDY_ZONE_ID)
        {
            if (EXT_STUDY_ZONE_ID != null)
            {
                var builder = Builders<BsonDocument>.Filter;
                var mainFilter = builder.Empty;
                mainFilter &= builder.Eq("id", EXT_STUDY_ZONE_ID);
                try
                {
                    var collection = this.db.GetCollection<BsonDocument>(EXT_STUDY_ZONE_GEOJSON_COLLECTION);
                    collection.DeleteOne(mainFilter);
                }
                catch (Exception)
                {
                    throw new Exception("Delete failed for document");
                }
            }
        }
        #endregion

        #region Edit_District_geojson
        public BsonDocument Edit_District_geojson(BsonDocument i_District_geojson)
        {
            if (i_District_geojson != null)
            {
                try
                {
                    var collection = this.db.GetCollection<BsonDocument>(DISTRICT_GEOJSON_COLLECTION);

                    if (i_District_geojson.TryGetValue("_id", out BsonValue oBsonValue))
                    {
                        var builder = Builders<BsonDocument>.Filter;
                        var mainFilter = builder.Empty;
                        ObjectId _id = new ObjectId(oBsonValue.ToString());
                        mainFilter &= builder.Eq("_id", _id);
                        collection.ReplaceOne(mainFilter, i_District_geojson, new ReplaceOptions { IsUpsert = true });
                    }
                    else
                    {
                        collection.InsertOne(i_District_geojson);
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Edit failed for one document");
                }
            }

            return i_District_geojson;
        }
        #endregion
        #region Edit_Area_geojson
        public BsonDocument Edit_Area_geojson(BsonDocument i_Area_geojson)
        {
            if (i_Area_geojson != null)
            {
                try
                {
                    var collection = this.db.GetCollection<BsonDocument>(AREA_GEOJSON_COLLECTION);

                    if (i_Area_geojson.TryGetValue("_id", out BsonValue oBsonValue))
                    {
                        var builder = Builders<BsonDocument>.Filter;
                        var mainFilter = builder.Empty;
                        ObjectId _id = new ObjectId(oBsonValue.ToString());
                        mainFilter &= builder.Eq("_id", _id);
                        collection.ReplaceOne(mainFilter, i_Area_geojson, new ReplaceOptions { IsUpsert = true });
                    }
                    else
                    {
                        collection.InsertOne(i_Area_geojson);
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Edit failed for one document");
                }
            }

            return i_Area_geojson;
        }
        #endregion
        #region Edit_Site_geojson
        public BsonDocument Edit_Site_geojson(BsonDocument i_Site_geojson)
        {
            if (i_Site_geojson != null)
            {
                try
                {
                    var collection = this.db.GetCollection<BsonDocument>(SITE_GEOJSON_COLLECTION);

                    if (i_Site_geojson.TryGetValue("_id", out BsonValue oBsonValue))
                    {
                        var builder = Builders<BsonDocument>.Filter;
                        var mainFilter = builder.Empty;
                        ObjectId _id = new ObjectId(oBsonValue.ToString());
                        mainFilter &= builder.Eq("_id", _id);
                        collection.ReplaceOne(mainFilter, i_Site_geojson, new ReplaceOptions { IsUpsert = true });
                    }
                    else
                    {
                        collection.InsertOne(i_Site_geojson);
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Edit failed for one document");
                }
            }

            return i_Site_geojson;
        }
        #endregion
        #region Edit_Ext_study_zone_geojson
        public BsonDocument Edit_Ext_study_zone_geojson(BsonDocument i_Ext_study_zone_geojson)
        {
            if (i_Ext_study_zone_geojson != null)
            {
                try
                {
                    var collection = this.db.GetCollection<BsonDocument>(EXT_STUDY_ZONE_GEOJSON_COLLECTION);

                    if (i_Ext_study_zone_geojson.TryGetValue("_id", out BsonValue oBsonValue))
                    {
                        var builder = Builders<BsonDocument>.Filter;
                        var mainFilter = builder.Empty;
                        ObjectId _id = new ObjectId(oBsonValue.ToString());
                        mainFilter &= builder.Eq("_id", _id);
                        collection.ReplaceOne(mainFilter, i_Ext_study_zone_geojson, new ReplaceOptions { IsUpsert = true });
                    }
                    else
                    {
                        collection.InsertOne(i_Ext_study_zone_geojson);
                    }
                }
                catch (Exception)
                {
                    throw new Exception("Edit failed for one document");
                }
            }

            return i_Ext_study_zone_geojson;
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
        #region Get_Site_geojson
        public List<BsonDocument> Get_Site_geojson()
        {
            List<BsonDocument> oList_Site_geojson = null;
            var mainFilter = Builders<BsonDocument>.Filter.Empty;
            try
            {
                var collection = this.db.GetCollection<BsonDocument>(SITE_GEOJSON_COLLECTION);
                var _query_response = collection.Find(mainFilter);
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
            return oList_Site_geojson;
        }
        #endregion
        #region Get_Ext_study_zone_geojson
        public List<BsonDocument> Get_Ext_study_zone_geojson()
        {
            List<BsonDocument> oList_Ext_study_zone_geojson = null;
            var mainFilter = Builders<BsonDocument>.Filter.Empty;
            try
            {
                var collection = this.db.GetCollection<BsonDocument>(EXT_STUDY_ZONE_GEOJSON_COLLECTION);
                var _query_response = collection.Find(mainFilter);
                oList_Ext_study_zone_geojson = new List<BsonDocument>();
                if (_query_response != null)
                {
                    oList_Ext_study_zone_geojson = _query_response.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Ext_study_zone_geojson;
        }
        #endregion

        #endregion
    }
    #region Entities
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
        public List<int?> SITE_ID_LIST { get; set; }
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
    #region Incident
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
    #endregion

    #region Kpi_chart_configuration
    public partial class Kpi_chart_configuration
    {
        [BsonId]
        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.ObjectId)]
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
        [BsonId]
        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.ObjectId)]
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
        [BsonId]
        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SPECIALIZED_CHART_CONFIGURATION_ID { get; set; }
        public string MODULE { get; set; }
        public string NAME { get; set; }
        public string TYPE { get; set; }
        public string CHART_SETTINGS { get; set; }
        public string SERIES_SETTINGS { get; set; }
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
    #endregion
}
