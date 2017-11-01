using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBlog.Domain.Model
{
    public class Comment
    {
        public String Message { get; set; }
        public DateTime TimePosted { get; set; }
        public int Likes { get; set; }
        public String ByUser { get; set; }
    }
}
