using System;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.Json;
using System.Collections.Generic;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Attributes;

namespace DALC
{
    public partial class DALC_MONGODB
    {
        private IMongoDatabase db;
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
        private readonly string EXT_STUDY_ZONE_GEOJSON_COLLECTION = "COL_EXT_STUDY_ZONE_GEOJSON";
        private readonly string KPI_CHART_CONFIGURATION_COLLECTION = "COL_KPI_CHART_CONFIGURATION";
        private readonly string WIFI_SIGNAL_COLLECTION = "WIFI_SIGNAL";
        private readonly string WIFI_SIGNAL_ALERT_COLLECTION = "WIFI_SIGNAL_ALERT";

        public DALC_MONGODB(string server, string database)
        {
            var client = new MongoClient(server);
            this.db = client.GetDatabase(database);
        }

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
        public IEnumerable<GeoData> Get_GeoData_By_Where(DateTime? START_DATE, DateTime? END_DATE, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, List<long?> LIST_LEVEL_ID, long? LEVEL_SETUP_ID)
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
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(geodata => geodata.DATE_START, End_Date);
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
        public GeoData Get_Latest_GeoData_Aggregate_By_KPI(int? ORGANIZATION_DATA_SOURCE_KPI_ID)
        {
            GeoData oGeoData = null;
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
                    .FirstOrDefault();
                oGeoData = new GeoData();
                if (_query_response != null)
                {

                    oGeoData = BsonSerializer.Deserialize<GeoData>(_query_response);
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oGeoData;
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
        #region Get_Latest_District_Kpi_Data_By_Where
        public List<District_kpi_data> Get_Latest_District_Kpi_Data_By_Where(List<long?> DISTRICT_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
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
                     { "_id", new BsonDocument
                        {
                            { "ORGANIZATION_DATA_SOURCE_KPI_ID", "$DISTRICT_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID" },
                            { "DISTRICT_ID", "$DISTRICT_METADATA.DISTRICT_ID" }
                        }
                    },
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
        #region Get_Latest_Area_Kpi_Data_By_Where
        public List<Area_kpi_data> Get_Latest_Area_Kpi_Data_By_Where(List<long?> AREA_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
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
                     { "_id", new BsonDocument
                        {
                            { "ORGANIZATION_DATA_SOURCE_KPI_ID", "$AREA_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID" },
                            { "AREA_ID", "$AREA_METADATA.AREA_ID" }
                        }
                    },
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
        #region Get_Latest_Site_Kpi_Data_By_Where
        public List<Site_kpi_data> Get_Latest_Site_Kpi_Data_By_Where(List<long?> SITE_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
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
                    { "_id", new BsonDocument
                        {
                            { "ORGANIZATION_DATA_SOURCE_KPI_ID", "$SITE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID" },
                            { "SITE_ID", "$SITE_METADATA.SITE_ID" }
                        }
                    },
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
        #region Get_Latest_Entity_Kpi_Data_By_Where
        public List<Entity_kpi_data> Get_Latest_Entity_Kpi_Data_By_Where(List<long?> ENTITY_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
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
                    { "_id", new BsonDocument
                        {
                            { "ORGANIZATION_DATA_SOURCE_KPI_ID", "$ENTITY_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID" },
                            { "ENTITY_ID", "$ENTITY_METADATA.$ENTITY_ID" }
                        }
                    },
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
        #region Get_Latest_Floor_Kpi_Data_By_Where
        public List<Floor_kpi_data> Get_Latest_Floor_Kpi_Data_By_Where(List<long?> FLOOR_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
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
                    { "_id", new BsonDocument
                        {
                            { "ORGANIZATION_DATA_SOURCE_KPI_ID", "$FLOOR_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID" },
                            { "FLOOR_ID", "$FLOOR_METADATA.FLOOR_ID" }
                        }
                    },
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
        #region Compute_Averaged_Floor_Indexes
        public void Compute_Averaged_Floor_Indexes(DateTime? START_DATE, DateTime? END_DATE, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
            DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
            var pipeline = new List<BsonDocument>
            {
                new BsonDocument("$match", new BsonDocument
                {
                    {
                        "$and", new BsonArray
                        {
                            new BsonDocument("RECORD_DATE", new BsonDocument("$gte", Start_Date)),
                            new BsonDocument("RECORD_DATE", new BsonDocument("$lt", End_Date)),
                            new BsonDocument("SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID", new BsonDocument("$in", new BsonArray(ORGANIZATION_DATA_SOURCE_KPI_ID_LIST))),
                        }
                    }
                }),
                new BsonDocument("$group", new BsonDocument
                {
                    { "_id", new BsonDocument
                        {
                            { "kpi_id", "$SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID" },
                            { "floor_id", "$SPACE_METADATA.FLOOR_ID" },
                            { "category", "$SPACE_METADATA.CATEGORY" },
                        }
                    },
                    { "object", new BsonDocument("$first", "$$ROOT") },
                    { "avg_value", new BsonDocument("$avg", "$VALUE") },
                    { "avg_value_sqm", new BsonDocument("$avg", "$VALUE_PER_SQM") },
                }),
                new BsonDocument("$project", new BsonDocument
                {
                    { "_id", 0 },
                    { "RECORD_DATE", "$object.RECORD_DATE"},
                    { "VALUE", "$avg_value" },
                    { "VALUE_PER_SQM", "$avg_value_sqm" },
                    { "VALUE_NAME", "$object.VALUE_NAME" },
                    { "FLOOR_METADATA", new BsonDocument
                        {
                            { "ORGANIZATION_DATA_SOURCE_KPI_ID", "$_id.kpi_id" },
                            { "FLOOR_ID", "$_id.floor_id" },
                            { "CATEGORY", "$_id.category" },
                        }
                    }
                }),
            };
            try
            {
                var collection_Space = this.Set_Space_Db_Collection(ENUM_TIMESPAN);

                var oList_Floor_kpi_data_BsonDocument = collection_Space.Aggregate<BsonDocument>(pipeline).ToList();

                if (oList_Floor_kpi_data_BsonDocument != null && oList_Floor_kpi_data_BsonDocument.Count > 0)
                {
                    List<Floor_kpi_data> oList_Floor_kpi_data = new List<Floor_kpi_data>();

                    oList_Floor_kpi_data_BsonDocument.ForEach(oFloor_kpi_data_BsonDocument =>
                    {
                        oList_Floor_kpi_data.Add(new Floor_kpi_data()
                        {
                            RECORD_DATE = oFloor_kpi_data_BsonDocument["RECORD_DATE"].ToLocalTime(),
                            VALUE = oFloor_kpi_data_BsonDocument["VALUE"].ToDecimal(),
                            VALUE_PER_SQM = oFloor_kpi_data_BsonDocument["VALUE_PER_SQM"].ToDecimal(),
                            VALUE_NAME = oFloor_kpi_data_BsonDocument["VALUE_NAME"].ToString(),
                            FLOOR_METADATA = new Floor_metadata()
                            {
                                ORGANIZATION_DATA_SOURCE_KPI_ID = (int)oFloor_kpi_data_BsonDocument.GetElement("FLOOR_METADATA").Value.AsBsonDocument["ORGANIZATION_DATA_SOURCE_KPI_ID"].ToInt64(),
                                FLOOR_ID = oFloor_kpi_data_BsonDocument.GetElement("FLOOR_METADATA").Value.AsBsonDocument["FLOOR_ID"].ToInt32(),
                                CATEGORY = (oFloor_kpi_data_BsonDocument.GetElement("FLOOR_METADATA").Value.AsBsonDocument["CATEGORY"] == null) ? null : oFloor_kpi_data_BsonDocument.GetElement("FLOOR_METADATA").Value.AsBsonDocument["CATEGORY"].ToString(),
                            }
                        });
                    });

                    var collection_Floor = this.Set_Floor_Db_Collection(ENUM_TIMESPAN);

                    if (oList_Floor_kpi_data != null && oList_Floor_kpi_data.Count > 0)
                    {
                        collection_Floor.InsertMany(oList_Floor_kpi_data);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to insert documents");
            }
        }
        #endregion
        #region Compute_Additive_Floor_Indexes
        public void Compute_Additive_Floor_Indexes(DateTime? START_DATE, DateTime? END_DATE, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
        {
            DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
            DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
            var pipeline = new List<BsonDocument>
            {
                new BsonDocument("$match", new BsonDocument
                {
                    {
                        "$and", new BsonArray
                        {
                            new BsonDocument("RECORD_DATE", new BsonDocument("$gte", Start_Date)),
                            new BsonDocument("RECORD_DATE", new BsonDocument("$lt", End_Date)),
                            new BsonDocument("SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID", new BsonDocument("$in", new BsonArray(ORGANIZATION_DATA_SOURCE_KPI_ID_LIST))),
                        }
                    }
                }),
                new BsonDocument("$group", new BsonDocument
                {
                    { "_id", new BsonDocument
                        {
                            { "kpi_id", "$SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID" },
                            { "floor_id", "$SPACE_METADATA.FLOOR_ID" },
                            { "category", "$SPACE_METADATA.CATEGORY" },
                        }
                    },
                    { "object", new BsonDocument("$first", "$$ROOT") },
                    { "sum_value", new BsonDocument("$sum", "$VALUE") },
                    { "avg_value_sqm", new BsonDocument("$avg", "$VALUE_PER_SQM") },
                }),
                new BsonDocument("$project", new BsonDocument
                {
                    { "_id", 0 },
                    { "RECORD_DATE", "$object.RECORD_DATE"},
                    { "VALUE", "$sum_value" },
                    { "VALUE_PER_SQM", "$avg_value_sqm" },
                    { "VALUE_NAME", "$object.VALUE_NAME" },
                    { "FLOOR_METADATA", new BsonDocument
                        {
                            { "ORGANIZATION_DATA_SOURCE_KPI_ID", "$_id.kpi_id" },
                            { "FLOOR_ID", "$_id.floor_id" },
                            { "CATEGORY", "$_id.category" },
                        }
                    }
                }),
            };
            try
            {
                var collection_Space = this.Set_Space_Db_Collection(ENUM_TIMESPAN);

                var oList_Floor_kpi_data_BsonDocument = collection_Space.Aggregate<BsonDocument>(pipeline).ToList();

                if (oList_Floor_kpi_data_BsonDocument != null && oList_Floor_kpi_data_BsonDocument.Count > 0)
                {
                    List<Floor_kpi_data> oList_Floor_kpi_data = new List<Floor_kpi_data>();

                    oList_Floor_kpi_data_BsonDocument.ForEach(oFloor_kpi_data_BsonDocument =>
                    {
                        oList_Floor_kpi_data.Add(new Floor_kpi_data()
                        {
                            RECORD_DATE = oFloor_kpi_data_BsonDocument["RECORD_DATE"].ToLocalTime(),
                            VALUE = oFloor_kpi_data_BsonDocument["VALUE"].ToDecimal(),
                            VALUE_PER_SQM = oFloor_kpi_data_BsonDocument["VALUE_PER_SQM"].ToDecimal(),
                            VALUE_NAME = oFloor_kpi_data_BsonDocument["VALUE_NAME"].ToString(),
                            FLOOR_METADATA = new Floor_metadata()
                            {
                                ORGANIZATION_DATA_SOURCE_KPI_ID = oFloor_kpi_data_BsonDocument.GetElement("FLOOR_METADATA").Value.AsBsonDocument["ORGANIZATION_DATA_SOURCE_KPI_ID"].ToInt32(),
                                FLOOR_ID = oFloor_kpi_data_BsonDocument.GetElement("FLOOR_METADATA").Value.AsBsonDocument["FLOOR_ID"].ToInt32(),
                                CATEGORY = (oFloor_kpi_data_BsonDocument.GetElement("FLOOR_METADATA").Value.AsBsonDocument["CATEGORY"] == null) ? null : oFloor_kpi_data_BsonDocument.GetElement("FLOOR_METADATA").Value.AsBsonDocument["CATEGORY"].ToString(),
                            }
                        });
                    });

                    var collection_Floor = this.Set_Floor_Db_Collection(ENUM_TIMESPAN);

                    if (oList_Floor_kpi_data != null && oList_Floor_kpi_data.Count > 0)
                    {
                        collection_Floor.InsertMany(oList_Floor_kpi_data);
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to insert documents");
            }
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
        #region Get_Latest_Space_Kpi_Data_By_Where
        public List<Space_kpi_data> Get_Latest_Space_Kpi_Data_By_Where(List<long?> SPACE_ID_LIST, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, Enum_Timespan ENUM_TIMESPAN)
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
                    { "_id", new BsonDocument
                        {
                            { "ORGANIZATION_DATA_SOURCE_KPI_ID", "$SPACE_METADATA.ORGANIZATION_DATA_SOURCE_KPI_ID" },
                            { "SPACE_ID", "$SPACE_METADATA.SPACE_ID" }
                        }
                    },
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
        #region Set_Area_Db_Collection
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

        #region Ext_study_zone_geojson
        #region Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID
        public void Delete_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID(string EXT_STUDY_ZONE_ID)
        {
            if (EXT_STUDY_ZONE_ID != null)
            {
                var builder = Builders<BsonDocument>.Filter;
                var mainFilter = builder.Empty;
                mainFilter &= builder.Eq("properties.id", EXT_STUDY_ZONE_ID);
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
        #region Edit_Ext_study_zone_geojson
        public void Edit_Ext_study_zone_geojson(JsonDocument i_Ext_study_zone_geojson)
        {
            if (i_Ext_study_zone_geojson != null)
            {
                var builder = Builders<BsonDocument>.Filter;
                var mainFilter = builder.Empty;
                mainFilter &= builder.Eq("properties.id", i_Ext_study_zone_geojson);
                try
                {
                    var collection = this.db.GetCollection<BsonDocument>(EXT_STUDY_ZONE_GEOJSON_COLLECTION);
                    collection.ReplaceOneAsync(mainFilter, i_Ext_study_zone_geojson.ToBsonDocument(), new ReplaceOptions { IsUpsert = true });
                }
                catch (Exception)
                {
                    throw new Exception("Edit failed for one document");
                }
            }
        }
        #endregion
        #region Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List
        public List<BsonDocument> Get_Ext_study_zone_geojson_By_EXT_STUDY_ZONE_ID_List(List<int?> EXT_STUDY_ZONE_ID_List)
        {
            List<BsonDocument> oList_Ext_study_zone_geojson = null;
            if (EXT_STUDY_ZONE_ID_List != null || EXT_STUDY_ZONE_ID_List.Count > 0)
            {
                var mainFilter = Builders<BsonDocument>.Filter.In("id", EXT_STUDY_ZONE_ID_List);
                var mainProject = Builders<BsonDocument>.Projection.Exclude(x => x["_id"]);
                try
                {
                    var collection = this.db.GetCollection<BsonDocument>(EXT_STUDY_ZONE_GEOJSON_COLLECTION);
                    var _query_response = collection.Find(mainFilter).Project<BsonDocument>(mainProject);
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
            }
            return oList_Ext_study_zone_geojson;
        }
        #endregion
        #endregion

        #region Kpi_chart_configuration
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
                        collection.ReplaceOne(mainFilter, i_Kpi_chart_configuration);
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
        public List<Alert> Get_Alerts_By_Where(List<string> ALERT_ID_LIST, List<long?> USER_ID_LIST, DateTime? START_DATE, DateTime? END_DATE, bool? IS_ACKNOWLEDGED, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, long? LEVEL_SETUP_ID, List<long?> LEVEL_ID_LIST)
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
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null)
            {
                mainFilter &= builder.In(alert => alert.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
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
        public long Get_Alerts_By_Where_Count(List<string> ALERT_ID_LIST, List<long?> USER_ID_LIST, DateTime? START_DATE, DateTime? END_DATE, bool? IS_ACKNOWLEDGED, List<int?> ORGANIZATION_DATA_SOURCE_KPI_ID_LIST, long? LEVEL_SETUP_ID, List<long?> LEVEL_ID_LIST)
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
            if (ORGANIZATION_DATA_SOURCE_KPI_ID_LIST != null)
            {
                mainFilter &= builder.In(alert => alert.ORGANIZATION_DATA_SOURCE_KPI_ID, ORGANIZATION_DATA_SOURCE_KPI_ID_LIST);
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
                return this.db.GetCollection<Alert>(ALERT_COLLECTION).CountDocuments(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #endregion

        #region Wifi_signal
        #region Delete_Wifi_signal
        public void Delete_Wifi_signal(List<long?> SPACE_ASSET_ID_LIST, List<long?> SPACE_ID_LIST, long? FLOOR_ID)
        {
            var mainFilter = Get_Wifi_signal_Filter(
                END_DATE: null,
                START_DATE: null,
                FLOOR_ID: FLOOR_ID,
                SPACE_ID_LIST: SPACE_ID_LIST,
                SPACE_ASSET_ID_LIST: SPACE_ASSET_ID_LIST
            );
            try
            {
                this.db.GetCollection<Wifi_signal>(WIFI_SIGNAL_COLLECTION).DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Failed to delete documents");
            }
        }
        #endregion
        #region Edit_Wifi_signal_List
        public void Edit_Wifi_signal_List(List<Wifi_signal> i_List_Wifi_signal)
        {
            if (i_List_Wifi_signal != null && i_List_Wifi_signal.Count > 0)
            {
                try
                {
                    var collection = this.db.GetCollection<Wifi_signal>(WIFI_SIGNAL_COLLECTION);
                    collection.InsertMany(i_List_Wifi_signal);
                }
                catch (Exception)
                {
                    throw new Exception("Failed to insert documents");
                }
            }
        }
        #endregion
        #region Get_Latest_Wifi_signal
        public List<Wifi_signal> Get_Latest_Wifi_signal(List<long?> SPACE_ASSET_ID_LIST, List<long?> SPACE_ID_LIST, long? FLOOR_ID, int? NUMBER_OF_POINTS)
        {
            #region Match
            var pipeline = new List<BsonDocument>();
            if (FLOOR_ID != null)
            {
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "WIFI_SIGNAL_METADATA.FLOOR_ID",  new BsonDocument("$eq", FLOOR_ID) }
                    }));
            }
            if (SPACE_ID_LIST != null)
            {
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "WIFI_SIGNAL_METADATA.SPACE_ID", new BsonDocument("$in", new BsonArray(SPACE_ID_LIST)) }
                    }));
            }
            if (SPACE_ASSET_ID_LIST != null)
            {
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "WIFI_SIGNAL_METADATA.SPACE_ASSET_ID", new BsonDocument("$in", new BsonArray(SPACE_ASSET_ID_LIST)) }
                    }));
            }
            pipeline.Add(new BsonDocument("$group", new BsonDocument
                {
                    { "_id", new BsonDocument
                        {
                            { "space_asset_id", "$WIFI_SIGNAL_METADATA.SPACE_ASSET_ID" }
                        }
                    },
                    { "last_wifi_signals", new BsonDocument
                        {
                            { "$topN", new BsonDocument
                                {
                                    { "output", "$$ROOT" },
                                    { "sortBy", new BsonDocument("RECORD_DATE", -1)},
                                    { "n", NUMBER_OF_POINTS }
                                }
                            }
                        }
                    }
                })
            );
            #endregion
            try
            {
                var wifiSignalDocuments = this.db.GetCollection<BsonDocument>(WIFI_SIGNAL_COLLECTION).Aggregate<BsonDocument>(pipeline).ToList();

                List<Wifi_signal> oList_Wifi_signal = new List<Wifi_signal>();
                foreach (BsonDocument wifiSignalDocument in wifiSignalDocuments)
                {
                    var lastWifiSignals = wifiSignalDocument["last_wifi_signals"].AsBsonArray;
                    foreach (BsonDocument wifiSignalDoc in lastWifiSignals)
                    {
                        var oWifi_signal = BsonSerializer.Deserialize<Wifi_signal>(wifiSignalDoc);
                        oList_Wifi_signal.Add(oWifi_signal);
                    }
                }

                return oList_Wifi_signal;
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #region Get_Wifi_signal_Filter
        public FilterDefinition<Wifi_signal> Get_Wifi_signal_Filter(DateTime? START_DATE, DateTime? END_DATE, List<long?> SPACE_ASSET_ID_LIST, List<long?> SPACE_ID_LIST, long? FLOOR_ID)
        {
            var builder = Builders<Wifi_signal>.Filter;
            var mainFilter = builder.Empty;
            if (SPACE_ASSET_ID_LIST != null && SPACE_ASSET_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ASSET_ID, SPACE_ASSET_ID_LIST);
            }
            if (SPACE_ID_LIST != null && SPACE_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.SPACE_ID, SPACE_ID_LIST);
            }
            if (FLOOR_ID != null)
            {
                mainFilter &= builder.Eq(wifi_signal => wifi_signal.WIFI_SIGNAL_METADATA.FLOOR_ID, FLOOR_ID);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(wifi_signal => wifi_signal.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(wifi_signal => wifi_signal.RECORD_DATE, End_Date);
            }
            return mainFilter;
        }
        #endregion
        #region Get_Wifi_signal_By_Where
        public List<Wifi_signal> Get_Wifi_signal_By_Where(DateTime? START_DATE, DateTime? END_DATE, List<long?> SPACE_ASSET_ID_LIST, List<long?> SPACE_ID_LIST, long? FLOOR_ID)
        {
            var mainFilter = Get_Wifi_signal_Filter(
                FLOOR_ID: FLOOR_ID,
                END_DATE: END_DATE,
                START_DATE: START_DATE,
                SPACE_ID_LIST: SPACE_ID_LIST,
                SPACE_ASSET_ID_LIST: SPACE_ASSET_ID_LIST
            );
            try
            {
                return this.db.GetCollection<Wifi_signal>(WIFI_SIGNAL_COLLECTION).Find(mainFilter).ToList();
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #region Get_Strongest_Wifi_signal
        public List<Wifi_signal> Get_Strongest_Wifi_signal(DateTime? START_DATE, DateTime? END_DATE, List<long?> SPACE_ASSET_ID_LIST, List<long?> SPACE_ID_LIST, List<long?> FLOOR_ID_LIST)
        {
            #region Match 
            var pipeline = new List<BsonDocument>();
            if (FLOOR_ID_LIST != null)
            {
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "WIFI_SIGNAL_METADATA.FLOOR_ID",  new BsonDocument("$in", new BsonArray(FLOOR_ID_LIST)) }
                    }));
            }
            if (SPACE_ID_LIST != null)
            {
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "WIFI_SIGNAL_METADATA.SPACE_ID", new BsonDocument("$in", new BsonArray(SPACE_ID_LIST)) }
                    }));
            }
            if (SPACE_ASSET_ID_LIST != null)
            {
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "WIFI_SIGNAL_METADATA.SPACE_ASSET_ID", new BsonDocument("$in", new BsonArray(SPACE_ASSET_ID_LIST)) }
                    }));
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "RECORD_DATE", new BsonDocument("$gte", Start_Date)}
                    }));
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "RECORD_DATE", new BsonDocument("$lt", End_Date)}
                    }));
            }
            pipeline.Add(new BsonDocument("$group", new BsonDocument
                {
                    { "_id",  "$WIFI_SIGNAL_METADATA.SPACE_ASSET_ID" },
                    { "object", new BsonDocument("$first", "$$ROOT") },
                    { "average_wifi_signal", new BsonDocument("$avg", "$VALUE") }
                })
            );
            #endregion
            try
            {
                var wifiSignalDocuments = this.db.GetCollection<BsonDocument>(WIFI_SIGNAL_COLLECTION).Aggregate<BsonDocument>(pipeline).ToList();

                List<Wifi_signal> oList_Wifi_signal = new List<Wifi_signal>();
                foreach (BsonDocument wifiSignalDocument in wifiSignalDocuments)
                {
                    Wifi_signal oWifi_signal = BsonSerializer.Deserialize<Wifi_signal>(wifiSignalDocument["object"].AsBsonDocument);
                    oWifi_signal.VALUE = wifiSignalDocument["average_wifi_signal"].AsDecimal;
                    oList_Wifi_signal.Add(oWifi_signal);
                }

                return oList_Wifi_signal;
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #endregion

        #region Wifi_signal_alert
        #region Delete_Wifi_signal_alert
        public void Delete_Wifi_signal_alert(List<string> WIFI_SIGNAL_ALERT_ID_LIST, List<long?> SPACE_ASSET_ID_LIST, List<long?> SPACE_ID_LIST, long? FLOOR_ID, bool? IS_RESOLVED)
        {
            var mainFilter = Get_Wifi_signal_alert_Filter(
                END_DATE: null,
                START_DATE: null,
                FLOOR_ID: FLOOR_ID,
                IS_RESOLVED: IS_RESOLVED,
                SPACE_ID_LIST: SPACE_ID_LIST,
                SPACE_ASSET_ID_LIST: SPACE_ASSET_ID_LIST,
                WIFI_SIGNAL_ALERT_ID_LIST: WIFI_SIGNAL_ALERT_ID_LIST
            );
            try
            {
                this.db.GetCollection<Wifi_signal_alert>(WIFI_SIGNAL_ALERT_COLLECTION).DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Failed to delete documents");
            }
        }
        #endregion
        #region Edit_Wifi_signal_alert_List
        public void Edit_Wifi_signal_alert_List(List<Wifi_signal_alert> i_List_Wifi_signal_alert)
        {
            try
            {
                var collection = this.db.GetCollection<Wifi_signal_alert>(WIFI_SIGNAL_ALERT_COLLECTION);
                List<Wifi_signal_alert> oList_Wifi_signal_alert_To_Insert = i_List_Wifi_signal_alert.Where(wifi_signal_alert => wifi_signal_alert.WIFI_SIGNAL_ALERT_ID == null).ToList();
                List<Wifi_signal_alert> oList_Wifi_signal_alert_To_Update = i_List_Wifi_signal_alert.Where(wifi_signal_alert => wifi_signal_alert.WIFI_SIGNAL_ALERT_ID != null).ToList();
                if (oList_Wifi_signal_alert_To_Insert.Count() > 0)
                {
                    collection.InsertMany(oList_Wifi_signal_alert_To_Insert);
                }
                foreach (Wifi_signal_alert wifi_signal_alert in oList_Wifi_signal_alert_To_Update)
                {
                    collection.ReplaceOne(wifi_signal_alert_To_Replace => wifi_signal_alert_To_Replace.WIFI_SIGNAL_ALERT_ID == wifi_signal_alert.WIFI_SIGNAL_ALERT_ID, wifi_signal_alert, new ReplaceOptions() { IsUpsert = true });
                }
            }
            catch (Exception)
            {
                throw new Exception("Edit failed for one or more documents");
            }
        }
        #endregion
        #region Get_Wifi_signal_alert_Filter
        public FilterDefinition<Wifi_signal_alert> Get_Wifi_signal_alert_Filter(DateTime? START_DATE, DateTime? END_DATE, List<string> WIFI_SIGNAL_ALERT_ID_LIST, List<long?> SPACE_ASSET_ID_LIST, List<long?> SPACE_ID_LIST, long? FLOOR_ID, bool? IS_RESOLVED)
        {
            var builder = Builders<Wifi_signal_alert>.Filter;
            var mainFilter = builder.Empty;
            if (WIFI_SIGNAL_ALERT_ID_LIST != null && WIFI_SIGNAL_ALERT_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(wifi_signal_alert => wifi_signal_alert.WIFI_SIGNAL_ALERT_ID, WIFI_SIGNAL_ALERT_ID_LIST);
            }
            if (SPACE_ASSET_ID_LIST != null && SPACE_ASSET_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(wifi_signal_alert => wifi_signal_alert.SPACE_ASSET_ID, SPACE_ASSET_ID_LIST);
            }
            if (SPACE_ID_LIST != null && SPACE_ID_LIST.Count > 0)
            {
                mainFilter &= builder.In(wifi_signal_alert => wifi_signal_alert.SPACE_ID, SPACE_ID_LIST);
            }
            if (FLOOR_ID != null)
            {
                mainFilter &= builder.Eq(wifi_signal_alert => wifi_signal_alert.FLOOR_ID, FLOOR_ID);
            }
            if (IS_RESOLVED != null)
            {
                mainFilter &= builder.Eq(wifi_signal_alert => wifi_signal_alert.IS_RESOLVED, IS_RESOLVED);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(wifi_signal_alert => wifi_signal_alert.START_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(wifi_signal_alert => wifi_signal_alert.START_DATE, End_Date);
            }
            return mainFilter;
        }
        #endregion
        #region Get_Wifi_signal_alert_By_Where
        public List<Wifi_signal_alert> Get_Wifi_signal_alert_By_Where(DateTime? START_DATE, DateTime? END_DATE, List<string> WIFI_SIGNAL_ALERT_ID_LIST, List<long?> SPACE_ASSET_ID_LIST, List<long?> SPACE_ID_LIST, long? FLOOR_ID, bool? IS_RESOLVED)
        {
            var mainFilter = Get_Wifi_signal_alert_Filter(
                FLOOR_ID: FLOOR_ID,
                END_DATE: END_DATE,
                START_DATE: START_DATE,
                IS_RESOLVED: IS_RESOLVED,
                SPACE_ID_LIST: SPACE_ID_LIST,
                SPACE_ASSET_ID_LIST: SPACE_ASSET_ID_LIST,
                WIFI_SIGNAL_ALERT_ID_LIST: WIFI_SIGNAL_ALERT_ID_LIST
            );
            try
            {
                return this.db.GetCollection<Wifi_signal_alert>(WIFI_SIGNAL_ALERT_COLLECTION).Find(mainFilter).ToList();
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #region Get_Latest_Wifi_signal_alert
        public List<Wifi_signal_alert> Get_Latest_Wifi_signal_alert(List<long?> SPACE_ASSET_ID_LIST, List<long?> SPACE_ID_LIST, long? FLOOR_ID, int? NUMBER_OF_POINTS)
        {
            #region Match
            var pipeline = new List<BsonDocument>();
            if (FLOOR_ID != null)
            {
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "FLOOR_ID",  new BsonDocument("$eq", FLOOR_ID) }
                    }));
            }
            if (SPACE_ID_LIST != null)
            {
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "SPACE_ID", new BsonDocument("$in", new BsonArray(SPACE_ID_LIST)) }
                    }));
            }
            if (SPACE_ASSET_ID_LIST != null)
            {
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "SPACE_ASSET_ID", new BsonDocument("$in", new BsonArray(SPACE_ASSET_ID_LIST)) }
                    }));
            }
            pipeline.Add(new BsonDocument("$group", new BsonDocument
                {
                    { "_id", new BsonDocument
                        {
                            { "space_asset_id", "$SPACE_ASSET_ID" }
                        }
                    },
                    { "last_wifi_signal_alerts", new BsonDocument
                        {
                            { "$topN", new BsonDocument
                                {
                                    { "output", "$$ROOT" },
                                    { "sortBy", new BsonDocument("START_DATE", -1)},
                                    { "n", NUMBER_OF_POINTS }
                                }
                            }
                        }
                    }
                })
            );
            #endregion
            try
            {
                var wifiSignalDocuments = this.db.GetCollection<BsonDocument>(WIFI_SIGNAL_ALERT_COLLECTION).Aggregate<BsonDocument>(pipeline).ToList();

                List<Wifi_signal_alert> oList_Wifi_signal_alert = new List<Wifi_signal_alert>();
                foreach (BsonDocument wifiSignalDocument in wifiSignalDocuments)
                {
                    var lastWifiSignals = wifiSignalDocument["last_wifi_signal_alerts"].AsBsonArray;
                    foreach (BsonDocument wifiSignalDoc in lastWifiSignals)
                    {
                        var oWifi_signal_alert = BsonSerializer.Deserialize<Wifi_signal_alert>(wifiSignalDoc);
                        oList_Wifi_signal_alert.Add(oWifi_signal_alert);
                    }
                }

                return oList_Wifi_signal_alert;
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
        }
        #endregion
        #region Get_Wifi_signal_Count_Per_Space_asset
        public List<Space_asset_id_With_Count> Get_Wifi_signal_Count_Per_Space_asset(DateTime? START_DATE, DateTime? END_DATE, List<long?> SPACE_ASSET_ID_LIST, List<long?> SPACE_ID_LIST, List<long?> FLOOR_ID_LIST)
        {
            #region Match
            var pipeline = new List<BsonDocument>();
            if (FLOOR_ID_LIST != null)
            {
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "FLOOR_ID",  new BsonDocument("$in", new BsonArray(FLOOR_ID_LIST)) }
                    }));
            }
            if (SPACE_ID_LIST != null)
            {
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "SPACE_ID", new BsonDocument("$in", new BsonArray(SPACE_ID_LIST)) }
                    }));
            }
            if (SPACE_ASSET_ID_LIST != null)
            {
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "SPACE_ASSET_ID", new BsonDocument("$in", new BsonArray(SPACE_ASSET_ID_LIST)) }
                    }));
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "START_DATE", new BsonDocument("$gte", Start_Date)}
                    }));
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                pipeline.Add(new BsonDocument("$match", new BsonDocument
                    {
                        { "START_DATE", new BsonDocument("$lt", End_Date)}
                    }));
            }
            pipeline.Add(new BsonDocument("$group", new BsonDocument
                {
                    { "_id",  "$SPACE_ASSET_ID" },
                    { "count", new BsonDocument("$sum", 1) }
                })
            );
            #endregion
            try
            {
                var wifiSignalAlertDocuments = this.db.GetCollection<BsonDocument>(WIFI_SIGNAL_ALERT_COLLECTION).Aggregate<BsonDocument>(pipeline).ToList();

                List<Space_asset_id_With_Count> oList_Space_asset_id_With_Count = new List<Space_asset_id_With_Count>();
                foreach (BsonDocument wifiSignalAlertDocument in wifiSignalAlertDocuments)
                {
                    oList_Space_asset_id_With_Count.Add(new Space_asset_id_With_Count()
                    {
                        SPACE_ASSET_ID = wifiSignalAlertDocument["_id"].ToInt64(),
                        COUNT = wifiSignalAlertDocument["count"].ToInt64(),
                    });
                }
                return oList_Space_asset_id_With_Count;
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }

        }
        #endregion
        #endregion
    }
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
    #region Setting
    public partial class Setting
    {
        public string CHART_SETTINGS { get; set; }
        public string SERIES_SETTINGS { get; set; }
        public string ICON { get; set; }
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

    #region Wifi_signal_alert
    public partial class Wifi_signal_alert
    {
        [BsonId]
        [BsonIgnoreIfNull]
        [BsonRepresentation(BsonType.ObjectId)]
        public string WIFI_SIGNAL_ALERT_ID { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal? ALERT_VALUE { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal? RESOLVE_VALUE { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? START_DATE { get; set; }
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? END_DATE { get; set; }
        public bool? IS_RESOLVED { get; set; }
        public long? SPACE_ASSET_ID { get; set; }
        public long? SPACE_ID { get; set; }
        public long? FLOOR_ID { get; set; }
    }
    #endregion
    #region Space_asset_id_With_Count
    public partial class Space_asset_id_With_Count
    {
        public long? SPACE_ASSET_ID { get; set; }
        public long? COUNT { get; set; }
    }
    #endregion
}
