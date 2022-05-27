using System;
using System.Collections.Generic;

using System.Linq;
using System.Web;
using System.Data.Entity;
using EntityMvc;

namespace EntityMvc.Models.Class
{
    public class CONTEXT:DbContext
    {
        public DbSet<Yetenekler> YETENEKLERS { get; set; }
    }
}