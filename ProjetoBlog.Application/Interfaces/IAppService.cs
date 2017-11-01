using ProjetoBlog.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBlog.Application.Interfaces
{
    public interface IAppService
    {
        void Add(PostViewModel postViewModel);
        PostViewModel GetPost(string postId);
        IEnumerable<PostViewModel> GetAll();
        void Remove(string postId);
    }
}
