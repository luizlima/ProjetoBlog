using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBlog.Domain.Model
{
    public class Comment
    {
        public int CommentId { get; set; }
        public String Message { get; set; }
        public DateTime DateTimeMessage { get; set; }
        public int Likes { get; set; }
        public Post Post { get; set; }
        public User ByUser { get; set; }
    }
}
