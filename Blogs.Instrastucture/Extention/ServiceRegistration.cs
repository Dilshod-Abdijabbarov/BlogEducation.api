using Blogs.Instrastucture.Context;
using Blogs.Instrastucture.Interfaces;
using Blogs.Instrastucture.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Instrastucture.Extention
{
  public static  class ServiceRegistration
    {

        public static void AddInfrastucture(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(option => option.UseSqlServer
            (
                configuration.GetConnectionString("BlogDbContextConnection")
            ));

            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            services.AddTransient<IUserRepositoryAsync, UserRepositoryAsync>();
            services.AddTransient<IBlogRepositoryAsync, BlogRepositoryAsync>();
        }

    }
}
