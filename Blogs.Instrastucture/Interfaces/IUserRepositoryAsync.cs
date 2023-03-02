using Blogs.Domian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Instrastucture.Interfaces
{
   public  interface IUserRepositoryAsync : IGenericRepositoryAsync<User>
    {

        Task<Blog> CreateBlogAsync(Blog blog, int id);

    }
}
