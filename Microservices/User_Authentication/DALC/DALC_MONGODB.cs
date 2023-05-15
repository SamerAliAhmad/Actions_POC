using System;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using Azure.Core.GeoJson;

namespace DALC
{
    public partial class DALC_MONGODB
    {
        private IMongoDatabase db;
        private readonly string OTP_COLLECTION = "OTP";
        public DALC_MONGODB(string server, string database)
        {
            var client = new MongoClient(server);
            this.db = client.GetDatabase(database);
        }
        #region Delete_Otp_By_USER_ID
        public void Delete_Otp_By_USER_ID(long? USER_ID)
        {
            var builder = Builders<Otp>.Filter;
            var mainFilter = builder.Empty;
            if (USER_ID != null)
            {
                mainFilter &= builder.Eq(otp => otp.USER_ID, USER_ID);
                try
                {
                    var collection = this.db.GetCollection<Otp>(OTP_COLLECTION);
                    collection.DeleteOne(mainFilter);
                }
                catch (Exception)
                {
                    throw new Exception("Delete failed for document");
                }
            }
        }
        #endregion
        #region Delete_Otp_By_OTP_ID
        public void Delete_Otp_By_OTP_ID(string OTP_ID)
        {
            var builder = Builders<Otp>.Filter;
            var mainFilter = builder.Empty;
            if (OTP_ID != null)
            {
                mainFilter &= builder.Eq(otp => otp.OTP_ID, OTP_ID);
                try
                {
                    var collection = this.db.GetCollection<Otp>(OTP_COLLECTION);
                    collection.DeleteOne(mainFilter);
                }
                catch (Exception)
                {
                    throw new Exception("Delete failed for document");
                }
            }
        }
        #endregion
        #region Edit_Otp_List
        public void Edit_Otp_List(List<Otp> i_List_Otp)
        {
            try
            {
                var collection = this.db.GetCollection<Otp>(OTP_COLLECTION);
                List<Otp> oList_Otp_To_Insert = i_List_Otp.Where(otp => otp.OTP_ID == null).ToList();
                List<Otp> oList_Otp_To_Update = i_List_Otp.Where(otp => otp.OTP_ID != null).ToList();
                if (oList_Otp_To_Insert.Count() > 0)
                {
                    collection.InsertMany(oList_Otp_To_Insert);
                }
                foreach (Otp otp in oList_Otp_To_Update)
                {
                    collection.ReplaceOne(otp_To_Replace => otp_To_Replace.OTP_ID == otp.OTP_ID, otp, new ReplaceOptions() { IsUpsert = true });
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to edit documents");
            }
        }
        #endregion
        #region Get_Otp_By_USER_ID
        public Otp Get_Otp_By_USER_ID(long? USER_ID)
        {
            Otp oOtp = null;
            #region filter
            var builder = Builders<Otp>.Filter;
            var mainFilter = builder.Empty;
            if (USER_ID != null)
            {
                mainFilter &= builder.Eq(otp => otp.USER_ID, USER_ID);
            }
            #endregion
            try
            {
                var collection = this.db.GetCollection<Otp>(OTP_COLLECTION);
                var _query_response = collection.Find(mainFilter);
                oOtp = new Otp();
                if (_query_response != null)
                {
                    oOtp = _query_response.FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw new Exception("Failed to fetch documents");
            }
            return oOtp;
        }
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
}
