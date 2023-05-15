﻿using System;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace DALC
{
    public partial class DALC_MONGODB
    {
        private IMongoDatabase db;
        private readonly string X_DAILY_COLLECTION = "_DAILY";
        private readonly string X_WEEKLY_COLLECTION = "_WEEKLY";
        private readonly string X_MONTHLY_COLLECTION = "_MONTHLY";
        private readonly string X_QUARTERLY_COLLECTION = "_QUARTERLY";
        private readonly string DIMENSION_INDEX_DAILY_COLLECTION = "COL_DIMENSION_INDEX";
        private readonly string DIMENSION_INDEX_WEEKLY_COLLECTION = "COL_DIMENSION_INDEX";
        private readonly string DIMENSION_INDEX_MONTHLY_COLLECTION = "COL_DIMENSION_INDEX";
        private readonly string DIMENSION_INDEX_QUARTERLY_COLLECTION = "COL_DIMENSION_INDEX";

        public DALC_MONGODB(string server, string database)
        {
            var client = new MongoClient(server);
            this.db = client.GetDatabase(database);
        }

        #region Dimension_index
        #region Delete_Dimension_index_By_Where
        public void Delete_Dimension_index_By_Where(List<int?> LIST_DIMENSION_ID, List<long?> LIST_LEVEL_ID, long? LEVEL_SETUP_ID, Enum_Timespan ENUM_TIMESPAN)
        {
            #region filter
            var builder = Builders<Dimension_index>.Filter;
            var mainFilter = builder.Empty;
            if (LIST_DIMENSION_ID != null)
            {
                mainFilter &= builder.In(dimension_index => dimension_index.DIMENSION_METADATA.DIMENSION_ID, LIST_DIMENSION_ID);
            }
            if (LIST_LEVEL_ID != null && LIST_LEVEL_ID.Count > 0 && LEVEL_SETUP_ID != null)
            {
                mainFilter &= builder.In(dimension_index => dimension_index.DIMENSION_METADATA.LEVEL_ID, LIST_LEVEL_ID);
                mainFilter &= builder.Eq(dimension_index => dimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID, LEVEL_SETUP_ID);
            }
            #endregion
            try
            {
                var collection = Set_Dimension_Db_Collection(ENUM_TIMESPAN);
                collection.DeleteMany(mainFilter);
            }
            catch (Exception)
            {
                throw new Exception("Delete failed for one or more documents");
            }
        }
        #endregion
        #region Insert_Dimension_index_List
        public void Insert_Dimension_index_List(List<Dimension_index> LIST_DIMENSION_INDEX, Enum_Timespan ENUM_TIMESPAN)
        {
            if (LIST_DIMENSION_INDEX != null || LIST_DIMENSION_INDEX.Count() > 0)
            {
                try
                {
                    var collection = Set_Dimension_Db_Collection(ENUM_TIMESPAN);
                    collection.InsertMany(LIST_DIMENSION_INDEX);
                }
                catch (Exception)
                {
                    throw new Exception("Insert failed for one or more document");
                }
            }
        }
        #endregion
        #region Get_Dimension_index_By_Where
        public List<Dimension_index> Get_Dimension_index_By_Where(DateTime? START_DATE, DateTime? END_DATE, List<int?> LIST_DIMENSION_ID, List<long?> LIST_LEVEL_ID, long? LEVEL_SETUP_ID, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Dimension_index> oList_Dimension_index = null;
            #region filter
            var builder = Builders<Dimension_index>.Filter;
            var mainFilter = builder.Empty;
            if (LIST_DIMENSION_ID != null)
            {
                mainFilter &= builder.In(dimension_index => dimension_index.DIMENSION_METADATA.DIMENSION_ID, LIST_DIMENSION_ID);
            }
            if (LIST_LEVEL_ID != null && LIST_LEVEL_ID.Count > 0 && LEVEL_SETUP_ID != null)
            {
                mainFilter &= builder.In(dimension_index => dimension_index.DIMENSION_METADATA.LEVEL_ID, LIST_LEVEL_ID);
                mainFilter &= builder.Eq(dimension_index => dimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID, LEVEL_SETUP_ID);
            }
            if (START_DATE != null)
            {
                DateTime Start_Date = new DateTime(((DateTime)START_DATE).Year, ((DateTime)START_DATE).Month, ((DateTime)START_DATE).Day, ((DateTime)START_DATE).Hour, ((DateTime)START_DATE).Minute, ((DateTime)START_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Gte(dimension_index => dimension_index.RECORD_DATE, Start_Date);
            }
            if (END_DATE != null)
            {
                DateTime End_Date = new DateTime(((DateTime)END_DATE).Year, ((DateTime)END_DATE).Month, ((DateTime)END_DATE).Day, ((DateTime)END_DATE).Hour, ((DateTime)END_DATE).Minute, ((DateTime)END_DATE).Second, DateTimeKind.Utc);
                mainFilter &= builder.Lt(dimension_index => dimension_index.RECORD_DATE, End_Date);
            }
            #endregion
            try
            {
                var collection = Set_Dimension_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Find(mainFilter);
                oList_Dimension_index = new List<Dimension_index>();
                if (_query_response != null)
                {
                    oList_Dimension_index = _query_response.ToList();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Dimension_index;
        }
        #endregion
        #region Get_Latest_Dimension_index_By_Where
        public List<Dimension_index> Get_Latest_Dimension_index_By_Where(DateTime? START_DATE, DateTime? END_DATE, List<int?> LIST_DIMENSION_ID, List<long?> LIST_LEVEL_ID, long? LEVEL_SETUP_ID, Enum_Timespan ENUM_TIMESPAN)
        {
            List<Dimension_index> oList_Dimension_index = null;
            #region filter
            var builder = Builders<Dimension_index>.Filter;
            var mainFilter = builder.Empty;
            if (LIST_DIMENSION_ID != null)
            {
                mainFilter &= builder.In(dimension_index => dimension_index.DIMENSION_METADATA.DIMENSION_ID, LIST_DIMENSION_ID);
            }
            if (LIST_LEVEL_ID != null && LIST_LEVEL_ID.Count > 0 && LEVEL_SETUP_ID != null)
            {
                mainFilter &= builder.In(dimension_index => dimension_index.DIMENSION_METADATA.LEVEL_ID, LIST_LEVEL_ID);
                mainFilter &= builder.Eq(dimension_index => dimension_index.DIMENSION_METADATA.LEVEL_SETUP_ID, LEVEL_SETUP_ID);
            }
            if (START_DATE != null)
            {
                mainFilter &= builder.Gte(dimension_index => dimension_index.RECORD_DATE, START_DATE);
            }
            if (END_DATE != null)
            {
                mainFilter &= builder.Lt(dimension_index => dimension_index.RECORD_DATE, END_DATE);
            }
            #endregion
            try
            {
                var collection = Set_Dimension_Db_Collection(ENUM_TIMESPAN);
                var _query_response = collection.Aggregate()
                    .Match(mainFilter)
                    .SortByDescending(x => x.RECORD_DATE)
                    .Group(new BsonDocument
                    {
                    { "_id", new BsonDocument
                        {
                            { "DIMENSION_ID", "$DIMENSION_METADATA.DIMENSION_ID" },
                            { "LEVEL_ID", "$DIMENSION_METADATA.LEVEL_ID" }
                        }
                    },
                    { "doc", new BsonDocument("$first", "$$ROOT") }
                    })
                    .Unwind("doc")
                    .Project(new BsonDocument("_id", 0)
                        .Add("RECORD_DATE", "$doc.RECORD_DATE")
                        .Add("DIMENSION_METADATA", "$doc.DIMENSION_METADATA")
                        .Add("VALUE", "$doc.VALUE"))
                    .ToList();
                oList_Dimension_index = new List<Dimension_index>();
                if (_query_response != null)
                {
                    foreach (var item in _query_response)
                    {
                        oList_Dimension_index.Add(BsonSerializer.Deserialize<Dimension_index>(item));
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oList_Dimension_index;
        }
        #endregion
        #endregion

        #region Set_Dimension_Db_Collection
        private IMongoCollection<Dimension_index> Set_Dimension_Db_Collection(Enum_Timespan i_Enum_Timespan)
        {
            IMongoCollection<Dimension_index> result = null;
            switch (i_Enum_Timespan)
            {
                case Enum_Timespan.X_DAILY_COLLECTION:
                    result = this.db.GetCollection<Dimension_index>(DIMENSION_INDEX_DAILY_COLLECTION + X_DAILY_COLLECTION);
                    break;
                case Enum_Timespan.X_WEEKLY_COLLECTION:
                    result = this.db.GetCollection<Dimension_index>(DIMENSION_INDEX_WEEKLY_COLLECTION + X_WEEKLY_COLLECTION);
                    break;
                case Enum_Timespan.X_MONTHLY_COLLECTION:
                    result = this.db.GetCollection<Dimension_index>(DIMENSION_INDEX_MONTHLY_COLLECTION + X_MONTHLY_COLLECTION);
                    break;
                case Enum_Timespan.X_QUARTERLY_COLLECTION:
                    result = this.db.GetCollection<Dimension_index>(DIMENSION_INDEX_QUARTERLY_COLLECTION + X_QUARTERLY_COLLECTION);
                    break;
                default:
                    break;
            }
            return result;
        }
        #endregion
    }
    #region Dimension_index
    public partial class Dimension_index
    {
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime RECORD_DATE { get; set; }
        public Dimension_metadata DIMENSION_METADATA { get; set; }
        [BsonRepresentation(BsonType.Decimal128, AllowTruncation = true)]
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
}
