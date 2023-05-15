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
        private readonly string AREA_GEOJSON_COLLECTION = "COL_AREA_GEOJSON";

        public DALC_MONGODB(string server, string database)
        {
            var client = new MongoClient(server);
            this.db = client.GetDatabase(database);
        }

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
    }
}
