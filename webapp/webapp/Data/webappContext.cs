using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapp.Models;

namespace webapp.Data
{
    public class webappContext : DbContext
    {
        public webappContext (DbContextOptions<webappContext> options)
            : base(options)
        {
        }

        public DbSet<webapp.Models.Question> Question { get; set; }

        public DbSet<webapp.Models.Wachtrij> Wachtrij { get; set; }
    }
}
