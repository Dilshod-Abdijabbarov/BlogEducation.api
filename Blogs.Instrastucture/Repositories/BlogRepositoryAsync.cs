using Blogs.Domian.Models;
using Blogs.Instrastucture.Context;
using Blogs.Instrastucture.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Instrastucture.Repositories
{
   public  class BlogRepositoryAsync : GenericRepositoryAsync<Blog>, IBlogRepositoryAsync
    {
        private readonly DbSet<Blog> _blogDbContext;
        public BlogRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _blogDbContext = dbContext.Set<Blog>();
        }

       
    }
}
