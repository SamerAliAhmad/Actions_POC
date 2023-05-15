using System;
using System.Linq;
using SmartrTools;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Xml.Linq;
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
        private readonly string SITE_GEOJSON_COLLECTION = "COL_SITE_GEOJSON";

        public DALC_MONGODB(string server, string database)
        {
            var client = new MongoClient(server);
            this.db = client.GetDatabase(database);
        }

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
    }
}
