using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webapp.Models;
using DatabaseController;

namespace webapp.Data
{
    public class WebappContext : DbContext
    {
        public WebappContext (DbContextOptions<WebappContext> options)
            : base(options)
        {
        }
        public DbSet<webapp.Models.Vraag> Vraag { get; set; }



        
       
       //List<List<string>> a = new DBConnection().Send("");
       //new User b = new User()
        

    }
}
