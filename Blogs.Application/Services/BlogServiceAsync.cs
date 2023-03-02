using AutoMapper;
using Blogs.Application.DTOs.Blogs;
using Blogs.Application.Interfaces;
using Blogs.Instrastucture.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blogs.Application.Services
{
    public class BlogServiceAsync : IBlogService
    {
        private readonly IBlogRepositoryAsync _blogRepository;
        private readonly IMapper _mapper;

        public BlogServiceAsync(IBlogRepositoryAsync blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }
        public async  Task<IList<BlogDto>> GetAllBlogAsync()
        {
            return _mapper.Map<IList<BlogDto>>(await _blogRepository.GatAllAsync());
        }

        public async  Task<BlogDto> GetBlogidAsync(int id)
        { 
            return _mapper.Map<BlogDto>(await _blogRepository.GatidByAsync(blog=>blog.id==id,new List<string> { "Owner"}));
        }
    }
}
