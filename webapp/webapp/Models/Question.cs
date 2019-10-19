﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Models
{
    //info over vragen 
    public class Question
    {
        public string ID { get; set; }
        public string Naam { get; set; }

        public string Vraag { get; set; }
        public string Vak { get; set; }
        public string Lokaal { get; set; }

        
        public DateTime Date  { get; set; }
    }

}