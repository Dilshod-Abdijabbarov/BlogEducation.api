using Blogs.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Api.Controllers
{
    [Route("api/blogs")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogService _blog;

        public BlogController(IBlogService blog)
        {
            _blog = blog;
        }

        [HttpGet]
        public async  Task<IActionResult> GetBlogs()
        {
            return Ok(await _blog.GetAllBlogAsync());
        }

        [HttpGet]
        [Route ("id:int")]
        public async Task<IActionResult> GetBlog(int id)
        {
            return Ok(await _blog.GetBlogidAsync(id));
        }




    }
}
