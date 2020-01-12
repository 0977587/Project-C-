using DatabaseController;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Models
{
    public class TotaalingeschrevenVakken
    {
        public List<IngeschrevenVakken> Vakken { get; set; }
        public TotaalingeschrevenVakken(List<IngeschrevenVakken> vakken)
        {
            Vakken = vakken;
        }

    }

    public class IngeschrevenVakken
    {
        public Vak VakID { get; set; }
        public User UserID { get; set; }

        public IngeschrevenVakken(Vak vakid, User user)
        {
            VakID = vakid;
            UserID = user;
        }
    }
}