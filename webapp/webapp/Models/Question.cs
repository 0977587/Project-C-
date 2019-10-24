
using System;

namespace webapp.Models
{
    //info over vragen 
    public class Question
    {
        public int ID { get; set; }
        public int Naam { get; set; }

        public string Vraag { get; set; }
        public string VakID { get; set; }
        public string VraagText { get; set; }

        public string AndwoordText { get; set; }

        public bool IsFAQ { get; set; }
        public DateTime Date { get; set; }
    }

}
