using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Domian.Models
{
  public   class Blog : AuditableBaseEntity
    {
        public string  Title { get; set; }

        public Subject  Topic { get; set; }

        public string  Content { get; set; }

        public int Userid { get; set; }

        public User Owner { get; set; }

        public IList<BlogAsset> Assets { get; set; }

    }
    public enum Subject
    {
        Technology=1,
        Scientefic,
        Education
    }
}
