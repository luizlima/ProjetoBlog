using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBlog.Domain.Model
{
    public class Post
    {
        [BsonId]
        public ObjectId PostId { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Url { get; set; }
        public int Likes { get; set; }
        public String PostBy { get; set; }
        public IList<Comment> Comments { get; set; }
        public IList<Tag> Tags { get; set; }
    }
}
