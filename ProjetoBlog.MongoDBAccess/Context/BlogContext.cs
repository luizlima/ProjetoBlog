using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBlog.MongoDBAccess.Context
{
    public class BlogContext
    {
        protected readonly IMongoClient _client;
        protected readonly IMongoDatabase _database;
        public BlogContext()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            _database = _client.GetDatabase("test");
            var collections = _database.ListCollections();
        }
    }
}
