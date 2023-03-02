using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Application.DTOs.Blogs
{
   public  class CreateBlogDto
    {

        public string Title { get; set; }

        public int Topic { get; set; }

        public string Content { get; set; }

        public int Userid { get; set; }
    }
}
