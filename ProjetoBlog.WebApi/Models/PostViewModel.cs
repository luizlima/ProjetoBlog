using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjetoBlog.WebApi.Models
{
    public class PostViewModel
    {
        public String PostId { get; set; }
        [Required(ErrorMessage = "The Title is required")]
        [DisplayName("Título")]
        public String Title { get; set; }
        [Required]
        [DisplayName("Descrição")]
        public String Description { get; set; }
        public String Url { get; set; }
        public int Likes { get; set; }
        [Required]
        public String PostBy { get; set; }
        public IList<CommentViewModel> Comments { get; set; }
        public IList<TagViewModel> Tags { get; set; }
        public DateTime TimePosted { get; set; }
    }
}