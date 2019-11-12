using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Models
{
    public class Wachtrij
    {
        public int WachtrijID { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime EndDate { get; set; }
        public String Name { get; set; }
        //DateAdded wanneer aangemaatk DB>.Send("get * where db.vraag.DateAdded later dan DateAdded"
    }
}