using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Domian.Models
{
   public  class BlogAsset : BaseEntity
    {
        public string  FileName { get; set; }

        public int Blogid { get; set; }

        public Blog Blog { get; }

    }
}
