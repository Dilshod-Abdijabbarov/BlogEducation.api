using Blogs.Application.DTOs.Blogs;
using Blogs.Application.DTOs.Users;
using Blogs.Domian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Application.Interfaces
{
   public  interface IUserService
    {
        Task<IReadOnlyList<UserDto>> GatAllUserAsync();

        Task<UserDto> GatUseridByAsync(int id);

        Task<UserDto> CreateUserAsync(CreateUserDto user);

        Task<BlogDto> CreateBlogAsync(CreateBlogDto blogDto, int userid);
    }
}
