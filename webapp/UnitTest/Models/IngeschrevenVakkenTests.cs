using Microsoft.VisualStudio.TestTools.UnitTesting;
using webapp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.Models
{
    [TestClass()]
    public class IngeschrevenVakkenTests
    {
        Vak v = new Vak(1, "x", "x", "x", "x", false);
        User u = new User("s", 1, "x", "x", "x", "x");



        [TestMethod()]
        public void IngeschrevenVakkenTest()
        {
            IngeschrevenVakken i = new IngeschrevenVakken(v, u);
            if (i.VakID != v || i.UserID != u)
            {
                Assert.Fail();
            }

            
        }

        [TestMethod()]
        public void TotaalingeschrevenVakkenTest()
        {
            IngeschrevenVakken i = new IngeschrevenVakken(v, u);
            IngeschrevenVakken i2 = new IngeschrevenVakken(v, u);
            IngeschrevenVakken i3 = new IngeschrevenVakken(v, u);

            List<IngeschrevenVakken> vakken = new List<IngeschrevenVakken>();

            vakken.Add(i);
            vakken.Add(i2);
            vakken.Add(i3);

            TotaalingeschrevenVakken tot = new TotaalingeschrevenVakken(vakken);

            if(tot.Vakken[1] != i2)
            {
                Assert.Fail();
            }

        }
    }
}