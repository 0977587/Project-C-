using Microsoft.VisualStudio.TestTools.UnitTesting;
using webapp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace webapp.Models.Tests
{
    [TestClass()]
    public class WachtrijTests
    {

        DateTime currentTime = DateTime.Now;
        int wachtrijid = 2;
        string name = "wachtrij";


        

        [TestMethod()]
        public void WachtrijTest()
        {
            Wachtrij w = new Wachtrij(wachtrijid, currentTime, currentTime, name);
            if(w.WachtrijID != 2 || w.DateAdded != currentTime || w.EndDate != currentTime || name != "wachtrij")
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void returnWachtrijLengthTest()
        {
            Wachtrij w = new Wachtrij(wachtrijid, currentTime, currentTime, name);
            int length = w.returnWachtrijLength();
            if (length != 4)
            {
                Assert.Fail();
            }
        }
    }
}