using ProjetoBlog.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBlog.WebApi.Models;
using ProjetoBlog.Domain.Model;
using ProjetoBlog.MongoDBAccess.Interfaces;

namespace ProjetoBlog.Application.Services
{
    public class PostAppService : IAppService
    {
        private readonly IRepository<Post> _postRepository;

        public PostAppService(IRepository<Post> postRepository)
        {
            _postRepository = postRepository;
        }

        public void Add(PostViewModel postViewModel)
        {
            Post post = new Post();
            post.Title = postViewModel.Title;
            post.Description = postViewModel.Description;
            post.Url = postViewModel.Url;
            post.PostBy = postViewModel.PostBy;
            post.TimePosted = DateTime.Now;

            _postRepository.Add(post);
        }

        public IEnumerable<PostViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public PostViewModel GetPost(string postId)
        {
            throw new NotImplementedException();
        }

        public void Remove(string postId)
        {
            throw new NotImplementedException();
        }
    }
}
