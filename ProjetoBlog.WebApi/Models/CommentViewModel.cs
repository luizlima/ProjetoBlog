using System;

namespace ProjetoBlog.WebApi.Models
{
    public class CommentViewModel
    {
        public String Message { get; set; }
        public DateTime TimePosted { get; set; }
        public int Likes { get; set; }
        public String ByUser { get; set; }
    }
}