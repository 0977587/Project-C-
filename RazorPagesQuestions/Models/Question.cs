using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesQuestions.Models
{
    public class Question
    {
        public int ID { get; set; }
        public string Naam { get; set; }

        public string Vraag { get; set; }
        public string Vak { get; set; }
        public string Lokaal { get; set; }
    }
}
