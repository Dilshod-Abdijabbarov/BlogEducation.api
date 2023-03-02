using Blogs.Application.DTOs.Blogs;
using Blogs.Domian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Application.Interfaces
{
   public  interface IBlogService
    {
        Task<IList<BlogDto>> GetAllBlogAsync();

        Task<BlogDto> GetBlogidAsync(int id);

    }
}
