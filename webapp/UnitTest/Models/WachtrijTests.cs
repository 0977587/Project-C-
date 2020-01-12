using Microsoft.VisualStudio.TestTools.UnitTesting;
using webapp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using System.Configuration;

namespace UnitTest.Models
{
    [TestClass()]
    public class WachtrijTests
    {

        //creating variables, similating database
        DateTime currentTime = DateTime.Now;
        int wachtrijid = 2;
        string name = "wachtrij";

        private Vraag emptyVraag;
        private Vraag fullVraag;
        private Vraag vraag1;
        private Vraag vraag2;
        private Vraag vraag3;



        //initiator test
        [TestMethod()]
        public void WachtrijTest()
        {
            Wachtrij w = new Wachtrij(wachtrijid, currentTime, currentTime, name);
            if (w.WachtrijID != 2 || w.DateAdded != currentTime || w.EndDate != currentTime || w.Name != "wachtrij")
            {
                Assert.Fail();
            }
        }

        //setters test
        [TestMethod()]
        public void testSetters()
        {
            Wachtrij w = new Wachtrij(wachtrijid, currentTime, currentTime, name);
            DateTime n = DateTime.Now;


            w.WachtrijID = 20;
            w.DateAdded = n;
            w.EndDate = n;
            w.Name = "w";

            if (w.WachtrijID != 20 || w.DateAdded != n || w.EndDate != n || w.Name != "w")
            {
                Assert.Fail();
            }


        }

        [TestMethod]
        public void testreturnWachtrijLength()
        {
            //assigning variables to simulate database
            Wachtrij w1 = new Wachtrij(wachtrijid, currentTime, currentTime, name);
            Wachtrij w2 = new Wachtrij(wachtrijid + 1, currentTime, currentTime, name + "2");
            Wachtrij w3 = new Wachtrij(wachtrijid + 2, currentTime, currentTime, name + "3");
            Wachtrij w4 = new Wachtrij(wachtrijid + 3, currentTime, currentTime, name + "4");

            List<Wachtrij> wachtrijLijst = new List<Wachtrij>();
            wachtrijLijst.Add(w1);
            wachtrijLijst.Add(w2);
            wachtrijLijst.Add(w3);
            Assert.AreEqual(returnWachtrijLength(wachtrijLijst), 4);
            wachtrijLijst.Add(w4);
            Assert.AreEqual(returnWachtrijLength(wachtrijLijst), 5);

        }
        // start of functions to reproduce

        public int returnWachtrijLength(List<Wachtrij> wachtrijLijst)
        {
            if (wachtrijLijst.Count == 0)
            {
                return 0;
            }
            else
            {
                return wachtrijLijst.Count + 1;
            }
        }

        [TestMethod]
        public void testreturnWachtrijLength2()
        {
            //assigning variables to simulate database
            Wachtrij w1 = new Wachtrij(wachtrijid, currentTime, currentTime, name);
            Wachtrij w2 = new Wachtrij(wachtrijid + 1, currentTime, currentTime, name + "2");
            Wachtrij w3 = new Wachtrij(wachtrijid + 2, currentTime, currentTime, name + "3");
            Wachtrij w4 = new Wachtrij(wachtrijid + 3, currentTime, currentTime, name + "4");

            List<Wachtrij> wachtrijLijst = new List<Wachtrij>();
            wachtrijLijst.Add(w1);
            wachtrijLijst.Add(w2);
            wachtrijLijst.Add(w3);
            Assert.AreEqual(returnWachtrijLength2(wachtrijLijst), 4);
            wachtrijLijst.Add(w4);
            Assert.AreEqual(returnWachtrijLength2(wachtrijLijst), 5);

        }
        // start of functions to reproduce

        public int returnWachtrijLength2(List<Wachtrij> wachtrijLijst)
        {
            if (wachtrijLijst.Count == 0)
            {
                return 0;
            }
            else
            {
                return wachtrijLijst.Count + 1;
            }
        }

        [TestMethod()]
        public void getVragenTest()
        {
            List<Vraag> vragen = getVragen(2);

            //assigning variables to simulate database
            vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 2, false);
            vraag2 = new Vraag(2, 1, 21, "this is vraag2", "", false, DateTime.Today, DateTime.Today, "wd.1.2", 2, false);

            Assert.IsFalse(Assert.ReferenceEquals(vragen[2], vraag2));
            Assert.ReferenceEquals(vragen[2], vraag1);

        }
        // start of functions to reproduce

        public List<Vraag> getVragen(int wachtrijID)
        {
            List<Vraag> vragen = new List<Vraag>();

            Wachtrij w1 = new Wachtrij(wachtrijid, currentTime, currentTime, name);

            //assigning variables to simulate database
            fullVraag = new Vraag(1, 2, 20, "this is a question", "", false, DateTime.Today, DateTime.Today, "wd.1.2.3", 2, false);
            emptyVraag = new Vraag();
            vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 2, false);
            vraag2 = new Vraag(2, 1, 21, "this is vraag2", "", false, DateTime.Today, DateTime.Today, "wd.1.2", 2, false);
            vraag3 = new Vraag(2, 1, 22, "this is vraag3", "", false, DateTime.Today, DateTime.Today, "wd.3.4", 2, false);

            vragen.Add(vraag1);
            vragen.Add(vraag2);
            vragen.Add(vraag3);

            return vragen;
        }



        [TestMethod()]
        public void SelectOneTest()
        {
            //assigning variables to simulate database
            Wachtrij w1 = new Wachtrij(wachtrijid, currentTime, currentTime, name);
            Wachtrij w2 = new Wachtrij(wachtrijid + 1, currentTime, currentTime, name + "2");
            Wachtrij w3 = new Wachtrij(wachtrijid + 2, currentTime, currentTime, name + "3");
            Wachtrij w4 = new Wachtrij(wachtrijid + 3, currentTime, currentTime, name + "4");

            List<Wachtrij> wachtrijLijst = new List<Wachtrij>();
            wachtrijLijst.Add(w1);
            wachtrijLijst.Add(w2);
            wachtrijLijst.Add(w3);
            wachtrijLijst.Add(w4);

            Assert.AreEqual((SelectOne(2, wachtrijLijst)).WachtrijID, 2);
        }
        // start of functions to reproduce

        public Wachtrij SelectOne(int input, List<Wachtrij> wachtrijLijst)
        {
            foreach (var x in wachtrijLijst)
            {
                if(x.WachtrijID == input)
                {
                    return x;
                }
            }
            return new Wachtrij();
        }

        [TestMethod()]
        public void getVragenAmountTest()
        {
            Assert.AreEqual(getVragenAmount(1), 1);
            Assert.AreEqual(getVragenAmount(2), 3);
        }

        // start of functions to reproduce
        public int getVragenAmount(int input)
        {
            List<Vraag> vragen = new List<Vraag>();
            int amount = 0;

            //assigning variables to simulate database
            fullVraag = new Vraag(1, 2, 20, "this is a question", "", false, DateTime.Today, DateTime.Today, "wd.1.2.3", 1, false);
            emptyVraag = new Vraag();
            vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 2, false);
            vraag2 = new Vraag(2, 1, 21, "this is vraag2", "", false, DateTime.Today, DateTime.Today, "wd.1.2", 2, false);
            vraag3 = new Vraag(2, 1, 22, "this is vraag3", "", false, DateTime.Today, DateTime.Today, "wd.3.4", 2, false);

            vragen.Add(vraag1);
            vragen.Add(vraag2);
            vragen.Add(vraag3);
            vragen.Add(emptyVraag);
            vragen.Add(fullVraag);

            foreach (var x in vragen)
            {
                if (x.WachtrijID == input)
                {
                    amount++;
                }
            }

            return amount;
        }

        //insert method test
        [TestMethod()]
        public void InsertTest()
        {
            //assigning variables to simulate database
            fullVraag = new Vraag(1, 2, 20, "this is a question", "", false, DateTime.Today, DateTime.Today, "wd.1.2.3", 1, false);
            emptyVraag = new Vraag();
            vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 2, false);
            vraag2 = new Vraag(2, 1, 21, "this is vraag2", "", false, DateTime.Today, DateTime.Today, "wd.1.2", 2, false);
            vraag3 = new Vraag(2, 1, 22, "this is vraag3", "", false, DateTime.Today, DateTime.Today, "wd.3.4", 2, false);

            List<string> strings = new List<string>();
            List<Vraag> vragen = new List<Vraag>();

            strings.Add("test");
            strings.Add("test2");
            strings.Add("test3");
            vragen.Add(vraag1);
            vragen.Add(vraag2);
            vragen.Add(vraag3);
            vragen.Add(emptyVraag);
            vragen.Add(fullVraag);

            Assert.AreEqual(strings[1], "test2");
            Assert.ReferenceEquals(vragen[2], vraag3);
        }

        //delete method test
        [TestMethod()]
        public void DeleteTest()
        {
            //assigning variables to simulate database
            fullVraag = new Vraag(1, 2, 20, "this is a question", "", false, DateTime.Today, DateTime.Today, "wd.1.2.3", 1, false);
            emptyVraag = new Vraag();
            vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 2, false);
            vraag2 = new Vraag(2, 1, 21, "this is vraag2", "", false, DateTime.Today, DateTime.Today, "wd.1.2", 2, false);
            vraag3 = new Vraag(2, 1, 22, "this is vraag3", "", false, DateTime.Today, DateTime.Today, "wd.3.4", 2, false);

            List<string> strings = new List<string>();
            List<Vraag> vragen = new List<Vraag>();

            strings.Add("test");
            strings.Add("test2");
            strings.Add("test3");
            vragen.Add(vraag1);
            vragen.Add(vraag2);
            vragen.Add(vraag3);
            vragen.Add(emptyVraag);
            vragen.Add(fullVraag);

            Assert.AreEqual(strings[1], "test2");
            Assert.ReferenceEquals(vragen[2], vraag3);

            vragen.Remove(vraag3);
            strings.Remove("test2");

            Assert.AreNotEqual(strings[1], "test2");
            Assert.IsFalse(Assert.ReferenceEquals(vragen[2], vraag3));
        }

        //deleting fake test
        [TestMethod()]
        public void DeleteFakeTest()
        {
            //assigning variables to simulate database
            fullVraag = new Vraag(1, 2, 20, "this is a question", "", false, DateTime.Today, DateTime.Today, "wd.1.2.3", 1, false);
            emptyVraag = new Vraag();
            vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 2, false);
            vraag2 = new Vraag(2, 1, 21, "this is vraag2", "", false, DateTime.Today, DateTime.Today, "wd.1.2", 2, false);
            vraag3 = new Vraag(2, 1, 22, "this is vraag3", "", false, DateTime.Today, DateTime.Today, "wd.3.4", 2, false);
            Vraag vraag5 = null;

            List<string> strings = new List<string>();
            List<Vraag> vragen = new List<Vraag>();

            strings.Add("test");
            strings.Add("test2");
            strings.Add("test3");
            vragen.Add(vraag1);
            vragen.Add(vraag2);
            vragen.Add(vraag3);
            vragen.Add(emptyVraag);
            vragen.Add(fullVraag);

            Assert.AreEqual(strings[1], "test2");
            Assert.ReferenceEquals(vragen[2], vraag3);

            try
            {
                vragen.Remove(vraag5);

            }
            catch (InvalidCastException e)
            {
                throw new Exception("wrong type!", e);
            }

            vragen.Remove(vraag3);
            strings.Remove("test2");

            Assert.AreNotEqual(strings[1], "test2");
            Assert.IsFalse(Assert.ReferenceEquals(vragen[2], vraag3));
        }

        //update test
        [TestMethod()]
        public void UpdateTest()
        {
            //assigning variables to simulate database
            fullVraag = new Vraag(1, 2, 20, "this is a question", "", false, DateTime.Today, DateTime.Today, "wd.1.2.3", 1, false);
            emptyVraag = new Vraag();
            vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 2, false);
            vraag2 = new Vraag(2, 1, 21, "this is vraag2", "", false, DateTime.Today, DateTime.Today, "wd.1.2", 2, false);
            vraag3 = new Vraag(2, 1, 22, "this is vraag3", "", false, DateTime.Today, DateTime.Today, "wd.3.4", 2, false);

            List<string> strings = new List<string>();
            List<Vraag> vragen = new List<Vraag>();

            strings.Add("test");
            strings.Add("test2");
            strings.Add("test3");
            vragen.Add(vraag1);
            vragen.Add(vraag2);
            vragen.Add(vraag3);
            vragen.Add(emptyVraag);
            vragen.Add(fullVraag);

            Assert.AreEqual(strings[1], "test2");
            Assert.ReferenceEquals(vragen[2], vraag3);

            vragen.Clear();
            vragen.Add(vraag1);
            vragen.Add(vraag2);
            vragen.Add(vraag2);
            vragen.Add(emptyVraag);
            vragen.Add(fullVraag);

            Assert.ReferenceEquals(vragen[2], vraag2);

        }
    }
}