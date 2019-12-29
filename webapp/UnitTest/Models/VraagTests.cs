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
            vraag2 = new Vraag(3, 1, 21, "this is vraag2", "", false, DateTime.Today, DateTime.Today, "wd.1.2", 1, false);
            vraag3 = new Vraag(4, 1, 22, "this is vraag3", "", false, DateTime.Today, DateTime.Today, "wd.3.4", 1, false);
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
            Assert.AreEqual("", fullVraag.AndwoordText);
            Assert.IsFalse(fullVraag.IsFAQ);
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
         * this m   ethod test setter of vraagiD
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
        * this method tests returnVraagLength with empty list of questions
        */
        [TestMethod]
        public void testreturnVraagLength()
        {
            List<Vraag> vragenLijst = new List<Vraag>();

            Assert.AreEqual(returnVraagLength(vragenLijst), 0);
        }

        /*
       * this method tests returnVraagLength with a list of 1 question
       */
        [TestMethod]
        public void testreturnVraagLengthWithaQuestions()
        {
            List<Vraag> vragenLijst = new List<Vraag>();
            vragenLijst.Add(vraag1);
            Assert.AreEqual(returnVraagLength(vragenLijst), 2);
        }

        /*
         * this method tests returnVraagLength with different size of questions
         */
        [TestMethod]
        public void testreturnVraagLengthWithMultipleQuestions()
        {
            List<Vraag> vragenLijst = new List<Vraag>();
            vragenLijst.Add(vraag1);
            vragenLijst.Add(vraag2);

            Assert.AreEqual(returnVraagLength(vragenLijst), 3);
            vragenLijst.Add(vraag3);
            Assert.AreEqual(returnVraagLength(vragenLijst), 4);
        }

        /*
        * this method tests selectOne with empty list of questions
        */
        [TestMethod]
        public void testSelectNone()
        {
            List<Vraag> vragenLijsta = new List<Vraag>();
            Vraag test = new Vraag();
            Vraag test2 = SelectOne(10, vragenLijsta);
            Assert.ReferenceEquals(test, test2);
        }

        /*
      * this method tests selectOne with 1 question
      */
        [TestMethod]
        public void testSelectoneWithaQuestion()
        {
            List<Vraag> vragenLijst = new List<Vraag>();
            vragenLijst.Add(vraag1);
            Assert.AreNotEqual(SelectOne(2, vragenLijst), vraag2);
            Assert.AreEqual(SelectOne(2, vragenLijst), vraag1);
        }

        /*
     * this method tests selectOne with Multiple Questions
     */
        [TestMethod]
        public void testSelectoneWithMultipleQuestions()
        {
            List<Vraag> vragenLijst = new List<Vraag>();
            vragenLijst.Add(vraag1);
            vragenLijst.Add(vraag2);
            vragenLijst.Add(vraag3);

            Assert.AreEqual(SelectOne(2, vragenLijst), vraag1);
            Assert.AreEqual(SelectOne(3, vragenLijst), vraag2);
            Assert.AreEqual(SelectOne(4, vragenLijst), vraag3);
        }


        /*
      * this method tests selectAll with empty list of questions
      */
        [TestMethod]
        public void testSelectAllNone()
        {
            List<Vraag> vragenLijst = new List<Vraag>();
            List<Vraag> test = new List<Vraag>();
            List<Vraag> test2 = Selectall(vragenLijst);
            Assert.ReferenceEquals(test2, test);

        }

        /*
        * this method tests selectAll with one question
        */
        [TestMethod]
        public void testSelectAllWithOne()
        {
            List<Vraag> vragenLijst = new List<Vraag>();
            List<Vraag> test = new List<Vraag>();
            List<Vraag> test2 = Selectall(vragenLijst);
            Assert.ReferenceEquals(test2, test);


        }

        /*
       * this method tests selectAll with multiple questions
       */
        [TestMethod]
        public void testSelectAllWithMultipleQuestions()
        {
            List<Vraag> vragenLijst = new List<Vraag>();
            vragenLijst.Add(vraag1);
            vragenLijst.Add(vraag2);
            vragenLijst.Add(vraag3);

            List<Vraag> test = new List<Vraag>();
            test.Add(vraag1);
            test.Add(vraag2);
            test.Add(vraag3);
            List<Vraag> test2 = Selectall(vragenLijst);
            Assert.ReferenceEquals(test2, test);


            List<Vraag> test3 = new List<Vraag>();
            test.Add(vraag1);
            List<Vraag> vragenLijst2 = new List<Vraag>();
            vragenLijst2.Add(vraag1);
            List<Vraag> test4 = Selectall(vragenLijst2);
            Assert.ReferenceEquals(test3, test4);

        }



        /*
          * this method tests Delete with empty list of questions
          */
        [TestMethod]
        public void testDeleteNone()
        {
            List<Vraag> vragenLijst = new List<Vraag>();
            List<Vraag> test = new List<Vraag>();
            List<Vraag> test2 = Delete(1,vragenLijst);
            Assert.ReferenceEquals(test2, test);

        }

        /*
          * this method tests Delete with 1 question
          */
        [TestMethod]
        public void testDeleteOneQuestion()
        {
            List<Vraag> vragenLijst = new List<Vraag>();
            vragenLijst.Add(vraag1);
            List<Vraag> test = new List<Vraag>();
            List<Vraag> test2 = Delete(2,vragenLijst);
            Assert.ReferenceEquals(test2, test);

        }

        /*
          * this method tests Delete with multiple questions
          */
        [TestMethod]
        public void testDeleteMultipleQuestions()
        {
            List<Vraag> vragenLijst = new List<Vraag>();
            vragenLijst.Add(vraag1);
            vragenLijst.Add(vraag2);
            vragenLijst.Add(vraag3);


            List<Vraag> copy = new List<Vraag>();
            copy.Add(vraag1);
            copy.Add(vraag2);
            copy.Add(vraag3);

            vragenLijst = Delete(2, vragenLijst);
            Assert.IsFalse(vragenLijst.Count == copy.Count);

            Assert.IsTrue(vragenLijst.Count == 2);

            vragenLijst = Delete(3, vragenLijst);
            Assert.AreNotEqual(vragenLijst, copy);
            Assert.IsTrue(vragenLijst.Count == 1);

        }


        /*
         * this method tests Insert with a Question
         */
        [TestMethod]
        public void testInsertOneQuestion()
        {
            List<Vraag> vragenLijst = new List<Vraag>();
            vragenLijst.Add(vraag1);
            List<Vraag> test2 = Insert(vraag1, vragenLijst);
            Assert.AreEqual(test2, vragenLijst);
        }

        /*
        * this method tests Insert with multiple Questions
        */
        [TestMethod]
        public void testInsertMultipleQuestion()
        {
            List<Vraag> vragenLijst = new List<Vraag>();
            List<Vraag> test2 = new List<Vraag>();
            vragenLijst.Add(vraag1);
            vragenLijst.Add(vraag2);
            vragenLijst.Add(vraag3);

            test2 = Insert(vraag1, test2);
            Assert.AreNotEqual(test2, vragenLijst);
            test2 = Insert(vraag2, test2);
            Assert.AreNotEqual(test2, vragenLijst);
            test2 = Insert(vraag3, test2);
            foreach(var x in test2)
            {
                Assert.IsTrue(vragenLijst.Contains(x));
            }
        }



        // start of functions to reproduce

        /*
         * this method mocks the length of Vraag
         */
        public int returnVraagLength(List<Vraag> vragenLijst)
        {
            if (vragenLijst.Count == 0)
            {
                return 0;
            }
            else
            {
                return vragenLijst.Count + 1;
            }
        }
        /*
        * this method mocks the selectOne of Vraag
        */
        public Vraag SelectOne(int input, List<Vraag> vragenLijst)
        {
            foreach (var x in vragenLijst)
            {
                if (x.VraagID == input)
                {
                    return x;
                }
            }
            return new Vraag();

        }
        /*
       * this method mocks the selectAll of Vraag
       */
        public List<Vraag> Selectall(List<Vraag> vragenLijst)
        {
            List<Vraag> test = new List<Vraag>();
            foreach (var x in vragenLijst)
            {
                test.Add(x);
            }
            return test;

        }

        /*
          * this method mocks the Delete of Vraag
          */
        public List<Vraag> Delete(int input, List<Vraag> vragenLijst)
        {
            foreach (var x in vragenLijst)
            {
                if (x.VraagID == input)
                {
                    vragenLijst.Remove(x);
                    return vragenLijst;
                }
            }
            return vragenLijst;
        }

        /*
         * this method mocks the Update of Vraag
         */
        public List<Vraag> Update(Vraag vraag, List<Vraag> vragenLijst)
        {
            foreach (var x in vragenLijst)
            {
                if (x.VraagID == vraag.VraagID)
                {
                    vragenLijst.Remove(x);
                    vragenLijst.Add(vraag);
                }
            }
            return vragenLijst;
        }

        /*
         * this method mocks the Insert of Vraag
         */
        public List<Vraag> Insert(Vraag vraag, List<Vraag> vragenLijst)
        {
            vragenLijst.Add(vraag);
            return vragenLijst;
        }

        /*
         * this method mocks the InsertFaq of Vraag
         */
        public List<Vraag> InsertFaq(Vraag vraag, List<Vraag> vragenLijst)
        {
            vragenLijst.Add(vraag);
            return vragenLijst;
        }
    }
}
