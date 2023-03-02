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
     public class UserRepositoryAsync : GenericRepositoryAsync<User>,IUserRepositoryAsync
    {
        private readonly DbSet<User> _userDbContext;
        public UserRepositoryAsync(ApplicationDbContext dbContext) : base(dbContext)
        {
            _userDbContext = dbContext.Set<User>();
        }

        public async  Task<Blog> CreateBlogAsync(Blog blog, int id)
        {
            var user = await _userDbContext.Include(user=>user.Blogs).FirstOrDefaultAsync(user => user.id == id);

            if (user is null)
                return null;

            user.Blogs.Add(blog);

           await SaveChangesAsync();

            return blog;
        }
    }
}
