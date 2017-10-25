using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBlog.Domain.Model
{
    public class Post
    {
        public int PostId { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Url { get; set; }
        public int Likes { get; set; }
        public Login PostBy { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
