using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Models
{
    public class Queue
    {
        public int WachtrijID { get; set; }
        public List<string> Peercoaches { get; set; }
        public List<Vraag> Vragen { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime EndDate { get; set; }
        //DateAdded wanneer aangemaatk DB>.Send("get * where db.vraag.DateAdded later dan DateAdded"
    }
}