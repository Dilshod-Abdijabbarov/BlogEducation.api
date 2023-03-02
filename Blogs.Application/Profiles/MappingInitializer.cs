using AutoMapper;
using Blogs.Application.DTOs.Blogs;
using Blogs.Application.DTOs.Users;
using Blogs.Domian.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Application.Profiles
{
   public  class MappingInitializer : Profile
    {
        public MappingInitializer()
        {
            CreateMap<UserDto, User>().ReverseMap();
            CreateMap<CreateUserDto, User>().ReverseMap(); 
            
            CreateMap<BlogDto, Blog>().ReverseMap();
            CreateMap<CreateBlogDto, Blog>().ReverseMap();
        }
    }
}
