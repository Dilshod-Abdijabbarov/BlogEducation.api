
using Blogs.Application.DTOs.Blogs;
using Blogs.Application.DTOs.Users;
using Blogs.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.Api.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _user;
        public UserController(IUserService user)
        {
            _user = user;
        }

        [HttpGet]
        public async Task<ActionResult> GetUsers()
        {
            return Ok(await _user.GatAllUserAsync());
        }

        [HttpGet("id:int")]
        public async Task<ActionResult> GetUser(int id)
        {
            return Ok(await _user.GatUseridByAsync(id));
        }

        [HttpPost]
        public async Task<ActionResult> PostUser([FromBody] CreateUserDto user)
        {
            return Created("", await _user.CreateUserAsync(user));
        }

        [HttpPost("id:int/blog")]
        public async Task<ActionResult> PostBlog([FromBody] CreateBlogDto blogDto,int id)
        {
            return Created("", await _user.CreateBlogAsync(blogDto , id));
        }
    }
}

