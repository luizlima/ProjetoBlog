using MongoDB.Driver;
using ProjetoBlog.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBlog.MongoDBAccess.Context
{
    public class BlogContext
    {
        protected readonly IMongoClient _client;
        protected readonly IMongoDatabase _database;
        
        //private IntPtr nativeBlogContext = Marshal.AllocHGlobal()

        public BlogContext()
        {
            _client = new MongoClient("mongodb://localhost:27017");
            if (_client != null)
            {
                _database = _client.GetDatabase("test");
            }
        }

        public IMongoCollection<Post> Posts
        {
            get
            {
                return _database.GetCollection<Post>("post");
            }
        }

        public IMongoCollection<User> Users
        {
            get
            {
                return _database.GetCollection<User>("user");
            }
        }


    }
}
