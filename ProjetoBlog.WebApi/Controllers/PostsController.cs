using ProjetoBlog.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjetoBlog.WebApi.Controllers
{
    public class PostsController : ApiController
    {

        PostViewModel[] posts = new PostViewModel[] {
            new PostViewModel(){ Title = "Teste título", Description = "Teste Descrição", Likes = 1, Url = "Url teste", PostBy = "Luiz", TimePosted = DateTime.Now },
            new PostViewModel(){ Title = "Teste título 1", Description = "Teste Descrição 1", Likes = 1, Url = "Url teste 1", PostBy = "Luiz 1", TimePosted = DateTime.Now }
        };

        // GET: api/Posts
        public IEnumerable<PostViewModel> GetAllPosts()
        {
            return posts;
        }

        // GET: api/Posts/5
        public IHttpActionResult GetPost(int id)
        {
            return Ok(posts[0]);
        }
    }
}
