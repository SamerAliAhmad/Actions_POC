using System;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Text.Json;
using Azure.Core.GeoJson;
using MongoDB.Bson.Serialization;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace DALC
{
    public partial class DALC_MONGODB
    {
        private IMongoDatabase db;
        private readonly string DISTRICT_GEOJSON_COLLECTION = "COL_DISTRICT_GEOJSON";

        public DALC_MONGODB(string server, string database)
        {
            var client = new MongoClient(server);
            this.db = client.GetDatabase(database);
        }

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
    }
}
