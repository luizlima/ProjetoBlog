using ProjetoBlog.Domain.Model;
using ProjetoBlog.MongoDBAccess.Context;
using ProjetoBlog.MongoDBAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace ProjetoBlog.MongoDBAccess.Repository
{
    public class PostRepository : IRepository<Post>
    {
        private readonly BlogContext _context;
        public PostRepository()
        {
            _context = new BlogContext();
        }

        public void Add(Post entity)
        {
            _context.Posts.InsertOne(entity);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Post Get(string id)
        {
            var filter = Builders<Post>.Filter.Eq("_id", ObjectId.Parse(id));
            return _context.Posts.Find(filter).FirstOrDefault();
        }

        public IEnumerable<Post> GetAll()
        {
            return _context.Posts.Find(_ => true).ToList();
        }
        
        public ReplaceOneResult Update(string id, Post entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public long Remove(string id)
        {
            var result = _context.Posts.DeleteOne(Builders<Post>.Filter.Eq("_id",ObjectId.Parse(id)));
            return result.DeletedCount;
        }
    }
}
