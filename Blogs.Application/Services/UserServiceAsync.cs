using AutoMapper;
using Blogs.Application.DTOs.Blogs;
using Blogs.Application.DTOs.Users;
using Blogs.Application.Interfaces;
using Blogs.Domian.Models;
using Blogs.Instrastucture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Application.Services
{
    public class UserServiceAsync : IUserService
    {
        private readonly IUserRepositoryAsync _userRepository;
        private readonly IMapper _mapper;

        public UserServiceAsync(IUserRepositoryAsync userRepository,IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async  Task<BlogDto> CreateBlogAsync(CreateBlogDto blogDto, int userid)
        {
            return _mapper.Map<BlogDto>(await _userRepository.CreateBlogAsync(_mapper.Map<Blog>(blogDto), userid));
        }

        public async Task<UserDto> CreateUserAsync(CreateUserDto user)
        {
            return _mapper.Map<UserDto>(await _userRepository.AddAsync(_mapper.Map<User>(user)));
        }

        public async  Task<IReadOnlyList<UserDto>> GatAllUserAsync()
        {
            return _mapper.Map<IReadOnlyList<UserDto>>(await _userRepository.GatAllAsync());
        }

        public async  Task<UserDto> GatUseridByAsync(int id)
        {
            return _mapper.Map<UserDto>(await _userRepository.GatidByAsync(user=>user.id==id,new List<string> { "Blogs"}));
        }
    }
}
 