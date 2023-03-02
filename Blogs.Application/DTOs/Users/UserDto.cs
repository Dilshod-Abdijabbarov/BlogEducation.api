using Blogs.Application.DTOs.Blogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Application.DTOs.Users
{
  public   class UserDto : CreateUserDto
    {
        public int id { get; set; }


        public IList<BlogDto> Blogs { get; set; }
    }
}
