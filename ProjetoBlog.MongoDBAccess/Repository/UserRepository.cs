using MongoDB.Bson;
using MongoDB.Driver;
using ProjetoBlog.Domain.Model;
using ProjetoBlog.MongoDBAccess.Context;
using ProjetoBlog.MongoDBAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBlog.MongoDBAccess.Repository
{
    public class UserRepository : IRepository<User>
    {
        private readonly BlogContext _context;
        public UserRepository()
        {
            _context = new BlogContext();
        }

        public void Add(User entity)
        {
            _context.Users.InsertOne(entity);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public User Get(string id)
        {
            var filter = Builders<User>.Filter.Eq("_id", id);
            return _context.Users.Find(filter).FirstOrDefault();
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.Find(_ => true).ToList();
        }


        public long Remove(string id)
        {
            var result = _context.Users.DeleteOne(Builders<User>.Filter.Eq("_id", ObjectId.Parse(id)));
            return result.DeletedCount;
        }

        ReplaceOneResult IRepository<User>.Update(string id, User entityToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
