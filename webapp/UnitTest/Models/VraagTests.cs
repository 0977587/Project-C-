using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using webapp.Models;

namespace UnitTest.Models
{
    [TestClass]
    public class VraagTests
    {
        private Vraag emptyVraag;
        private Vraag fullVraag;
        private Vraag vraag1;
        private Vraag vraag2;
        private Vraag vraag3;

        [TestInitialize]
        public void dothisbeforeEach()
        {
            //create an empty vraag statement
            fullVraag = new Vraag(1, 2, 20, "this is an question", "", false, DateTime.Today, DateTime.Today, "wd.1.2.3", 1, false);
            emptyVraag = new Vraag();
            vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 1, false);
            vraag2 = new Vraag(2, 1, 21, "this is vraag2", "", false, DateTime.Today, DateTime.Today, "wd.1.2", 1, false);
            vraag3 = new Vraag(2, 1, 22, "this is vraag3", "", false, DateTime.Today, DateTime.Today, "wd.3.4", 1, false);
        }

        //begin OF GETTERS AND SETTERS

        /*
        * this method is used to test all the getters that vraag contains
        */
        [TestMethod]
        public void testGetters()
        {
            Assert.AreEqual(fullVraag, fullVraag);
            Assert.AreEqual(1, fullVraag.VraagID);
            Assert.AreEqual(2, fullVraag.UserID);
            Assert.AreEqual(20, fullVraag.VakID);
            Assert.AreEqual("this is an question", fullVraag.VraagText);
            Assert.AreEqual("",fullVraag.AndwoordText);
            Assert.IsFalse( fullVraag.IsFAQ);
            Assert.AreEqual(DateTime.Today, fullVraag.DateAdded);
            Assert.AreEqual(DateTime.Today, fullVraag.EndDate);
            Assert.AreEqual("wd.1.2.3", fullVraag.Locatie);
            Assert.IsFalse(fullVraag.isInProgress);
        }
        /*
         * this method is used to test all the types that vraag contains
         */
        [TestMethod]
        public void testTypes()
        {
            Assert.IsInstanceOfType(fullVraag.VraagID, typeof(int));
            Assert.IsInstanceOfType(fullVraag.UserID, typeof(int));
            Assert.IsInstanceOfType(fullVraag.VakID, typeof(int));
            Assert.IsInstanceOfType(fullVraag.VraagText, typeof(string));
            Assert.IsInstanceOfType(fullVraag.AndwoordText, typeof(string));
            Assert.IsInstanceOfType(fullVraag.DateAdded, typeof(DateTime));
            Assert.IsInstanceOfType(fullVraag.EndDate, typeof(DateTime));
            Assert.IsInstanceOfType(fullVraag.IsFAQ, typeof(bool));
            Assert.IsInstanceOfType(fullVraag.Locatie, typeof(string));
            Assert.IsInstanceOfType(fullVraag.WachtrijID, typeof(int));
            Assert.IsInstanceOfType(fullVraag.isInProgress, typeof(bool));
        }
        /*
         * this method test setter of vraag(D
         */
        [TestMethod]
        public void setVraagID()
        {
            emptyVraag.VraagID = 1;
            Assert.AreEqual(emptyVraag.VraagID, 1);
        }
        /*
         * this method test setter of UserID
         */
        [TestMethod]
        public void setUserID()
        {
            emptyVraag.UserID = 1;
            Assert.AreEqual(emptyVraag.UserID, 1);
        }
        /*
         * this method test setter of VakID
         */
        [TestMethod]
        public void setVakID()
        {
            emptyVraag.VakID = 1;
            Assert.AreEqual(emptyVraag.VakID, 1);
        }
        /*
         * this method test setter of vraagtext
         */
        [TestMethod]
        public void setVraagText()
        {
            emptyVraag.VraagText = "dit is een vraag";
            Assert.AreEqual(emptyVraag.VraagText, "dit is een vraag");
        }
        /*
         * this method test setter of vraagtext
         */
        [TestMethod]
        public void setAntwoordText()
        {
            emptyVraag.AndwoordText = "dit is een antwoord";
            Assert.AreEqual(emptyVraag.AndwoordText, "dit is een antwoord");
        }

        /*
         * this method test setter of vraagtext
         */
        [TestMethod]
        public void setDateAdded()
        {
            emptyVraag.DateAdded = DateTime.Today;
            Assert.AreEqual(emptyVraag.DateAdded, DateTime.Today);
        }
        [TestMethod]
        public void setEndDate()
        {
            emptyVraag.EndDate = DateTime.Today;
            Assert.AreEqual(emptyVraag.EndDate, DateTime.Today);
        }
        /*
         * this methods test the setLocatie
         */
        [TestMethod]
        public void setsetLocatie()
        {
            emptyVraag.Locatie = "WD.1.2.3";
            Assert.AreEqual(emptyVraag.Locatie, "WD.1.2.3");
        }
        /*
        * this method test setter of WachtrijID
        */
        [TestMethod]
        public void setWachtrijID()
        {
            emptyVraag.WachtrijID = 2;
            Assert.AreEqual(emptyVraag.WachtrijID, 2);
        }

        /*
        * this method test setter of isinProgress
        */
        [TestMethod]
        public void setIsinProgress()
        {
            emptyVraag.isInProgress = true;
            Assert.AreEqual(emptyVraag.isInProgress, true);
        }

        /*
         * this method test setter of isFaq
         */
        [TestMethod]
        public void setIsFAQ()
        {
            emptyVraag.IsFAQ = true;
            Assert.AreEqual(emptyVraag.IsFAQ, true);
        }

        //END OF GETTERS AND SETTERS


        /*
         * this method tests returnVraagLength
         */
        [TestMethod]
        public void testreturnVraagLength()
        {
            List<Vraag> vragenLijst = new List<Vraag>();
            vragenLijst.Add(vraag1);
            vragenLijst.Add(vraag2);
            vragenLijst.Add(vraag3);
            Assert.AreEqual(returnVraagLength(vragenLijst),4);
        }



        // start of functions to reproduce


        public int returnVraagLength(List<Vraag> vragenLijst)
        {
            if (returnstatement[0][0].Equals(""))
            {
                return 0;
            }
            int length = Convert.ToInt32(returnstatement[0][0]);
            return length + 1;
        }
    }
}
