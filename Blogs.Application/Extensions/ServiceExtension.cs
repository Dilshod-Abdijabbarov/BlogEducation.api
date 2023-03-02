using Blogs.Application.Interfaces;
using Blogs.Application.Profiles;
using Blogs.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Blogs.Application.Extensions
{
    public static   class ServiceExtension
    {
        public static void AddExtension(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MappingInitializer));

            services.AddTransient<IUserService, UserServiceAsync>();
            services.AddTransient<IBlogService, BlogServiceAsync>();

        }
    }
}
