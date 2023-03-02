﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogs.Domian.Models
{
    public class AuditableBaseEntity
    {
        public virtual  int id { get; set; }

        public string  CreateBy { get; set; }

        public DateTime Created { get; set; }

        public string LastModifiedBy  { get; set; }

        public DateTime? LastModified { get; set; }

    }
}
