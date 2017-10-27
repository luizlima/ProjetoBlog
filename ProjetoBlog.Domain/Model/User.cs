using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBlog.Domain.Model
{
    public class User
    {
        [BsonId]
        public ObjectId UserId { get; set; }
        public String Login { get; set; }
    }
}
