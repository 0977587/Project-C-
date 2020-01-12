using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using webapp.Models;

namespace UnitTest.Models
{
    [TestClass]
    public class VakTests
    {
        private Vak emptyVak;
        private Vak fullVak;
        private Vak vak1;
        private Vak vak2;

        [TestInitialize]
        public void dothisbeforeEach()
        {
            emptyVak = new Vak();
            fullVak = new Vak(20, "marijke", "wd.1.2.3", "skills", "winst", false);
            vak1 = new Vak(21, "a", "wd12", "dev", "doe", false);
            vak2 = new Vak(22, "aa", "wd123", "dev1", "doen", false);
        }
        /*
         * testing getters 
         */ 
        [TestMethod]
        public void gettersAndSettters()
        {
            Assert.AreNotEqual(emptyVak, fullVak);
            emptyVak.VakID = 1;
            Assert.AreNotEqual(emptyVak, fullVak);
            emptyVak.Docent = "marijke";
            emptyVak.Locaal = "wd.1.2.3";
            Assert.AreNotEqual(emptyVak, fullVak);
            emptyVak.Naam = "skills";
            emptyVak.Discriptie = "winst";
            Assert.AreNotEqual(emptyVak, fullVak);
            emptyVak.Isleeg = false;
            Assert.ReferenceEquals(emptyVak, fullVak);


        }

        /*
          * this method is used to test all the types that Vak contains
          */
        [TestMethod]
        public void testTypes()
        {
            Assert.IsInstanceOfType(fullVak.Isleeg, typeof(bool));
            Assert.IsInstanceOfType(fullVak.Docent, typeof(string));
            Assert.IsInstanceOfType(fullVak.VakID, typeof(int));
            Assert.IsInstanceOfType(fullVak.Naam, typeof(string));
            Assert.IsInstanceOfType(fullVak.Discriptie, typeof(string));
        }

        public void testreturnVakLength()
        {
            List<Vak> vakken = new List<Vak>();
            Assert.AreEqual(0, returnVaklength(vakken));
            vakken.Add(fullVak);
            Assert.AreEqual(1, returnVaklength(vakken));
        }

        [TestMethod]
        /*
        * this method tests selectOne with empty list of vakken
        */
        public void testSelectNone()
        {
            List<Vak> vakkenLijsta = new List<Vak>();
            Vak test = new Vak();
            Vak test2 = SelectOne(10, vakkenLijsta);
            Assert.ReferenceEquals(test, test2);
        }

        /*
        * this method tests selectOne with 1 Vak
        */
        [TestMethod]
        public void testSelectoneWithaVak()
        {
            List<Vak> vakkenLijst = new List<Vak>();
            vakkenLijst.Add(vak1);
            Assert.AreNotEqual(SelectOne(21, vakkenLijst), vak2);
            Assert.AreEqual(SelectOne(21, vakkenLijst), vak1);
        }


        /*
         * this method tests selectOne with Multiple Vakken
         */
        [TestMethod]
        public void testSelectoneWithMultipleVakken()
        {
            List<Vak> vakkenLijst = new List<Vak>();
            vakkenLijst.Add(vak1);
            vakkenLijst.Add(vak2);

            Assert.AreEqual(SelectOne(21, vakkenLijst), vak1);
            Assert.AreEqual(SelectOne(22, vakkenLijst), vak2);
        }

        /*
     * this method tests selectAll with empty list of vakken
     */
        [TestMethod]
        public void testSelectAllNone()
        {
            List<Vak> vakkenLijst = new List<Vak>();
            List<Vak> test = new List<Vak>();
            List<Vak> test2 = Selectall(vakkenLijst);
            Assert.ReferenceEquals(test2, test);

        }

        /*
        * this method tests selectAll with one Vak
        */
        [TestMethod]
        public void testSelectAllWithOne()
        {
            List<Vak> vakkenLijst = new List<Vak>();
            List<Vak> test = new List<Vak>();
            List<Vak> test2 = Selectall(vakkenLijst);
            Assert.ReferenceEquals(test2, test);


        }

        /*
     * this method tests selectAll with multiple Vakken
     */
        [TestMethod]
        public void testSelectAllWithMultipleVakken()
        {
            List<Vak> vakkenLijst = new List<Vak>();
            vakkenLijst.Add(vak1);
            vakkenLijst.Add(vak2);

            List<Vak> test = new List<Vak>();
            test.Add(vak1);
            test.Add(vak2);
            List<Vak> test2 = Selectall(vakkenLijst);
            Assert.ReferenceEquals(test2, test);


            List<Vak> test3 = new List<Vak>();
            test.Add(vak1);
            List<Vak> vakkenLijst2 = new List<Vak>();
            vakkenLijst2.Add(vak1);
            List<Vak> test4 = Selectall(vakkenLijst2);
            Assert.ReferenceEquals(test3, test4);

        }


        /*
          * this method tests Delete with 1 Vakken
          */
        [TestMethod]
        public void testDeleteOneVak()
        {
            List<Vak> vakkenLijst = new List<Vak>();
            vakkenLijst.Add(vak1);
            List<Vak> test = new List<Vak>();
            List<Vak> test2 = Delete(2, vakkenLijst);
            Assert.ReferenceEquals(test2, test);

        }

        /*
          * this method tests Delete with multiple Vakken
          */
        [TestMethod]
        public void testDeleteMultipleVakken()
        {
            List<Vak> vakkenLijst = new List<Vak>();
            vakkenLijst.Add(vak1);
            vakkenLijst.Add(vak2);


            List<Vak> copy = new List<Vak>();
            copy.Add(vak1);
            copy.Add(vak2);

            vakkenLijst = Delete(21, vakkenLijst);
            Assert.IsFalse(vakkenLijst.Count == copy.Count);

            Assert.IsTrue(vakkenLijst.Count == 1);

            vakkenLijst = Delete(3, vakkenLijst);
            Assert.AreNotEqual(vakkenLijst, copy);
            Assert.IsTrue(vakkenLijst.Count == 1);

        }


        /*
         * this method tests Insert with a Vak
         */
        [TestMethod]
        public void testInsertOneVak()
        {
            List<Vak> vakkenLijst = new List<Vak>();
            vakkenLijst.Add(vak1);
            List<Vak> test2 = Insert(vak1, vakkenLijst);
            Assert.AreEqual(test2, vakkenLijst);
        }

        /*
        * this method tests Insert with multiple Vakken
        */
        [TestMethod]
        public void testInsertMultipleVak()
        {
            List<Vak> vakkenLijst = new List<Vak>();
            List<Vak> test2 = new List<Vak>();
            vakkenLijst.Add(vak1);
            vakkenLijst.Add(vak2);

            test2 = Insert(vak1, test2);
            Assert.AreNotEqual(test2, vakkenLijst);
            test2 = Insert(vak2, test2);
            Assert.AreNotEqual(test2, vakkenLijst);
            foreach (var x in vakkenLijst)
            {
                Assert.IsTrue(vakkenLijst.Contains(x));
            }
        }




        // methods to reproduce

        /*
       * this method mocks the selectOne of Vak
       */
        public Vak SelectOne(int input, List<Vak> vakkenLijst)
        {
            foreach (var x in vakkenLijst)
            {
                if (x.VakID == input)
                {
                    return x;
                }
            }
            return new Vak();

        }
        public int returnVaklength(List<Vak> vakken)
        {
            if (vakken.Count != 0)
            {

                return vakken.Count + 1;
            }
            else return 0;
        }
        /*
      * this method mocks the selectAll of Vak
      */
        public List<Vak> Selectall(List<Vak> vakkenLijst)
        {
            List<Vak> test = new List<Vak>();
            foreach (var x in vakkenLijst)
            {
                test.Add(x);
            }
            return test;

        }

        /*
      * this method mocks the Insert of Vak
      */
        public List<Vak> Insert(Vak Vak, List<Vak> vakkenLijst)
        {
            vakkenLijst.Add(Vak);
            return vakkenLijst;
        }

        /*
         * this method mocks the InsertFaq of Vak
         */
        public List<Vak> InsertFaq(Vak Vak, List<Vak> vakkenLijst)
        {
            vakkenLijst.Add(Vak);
            return vakkenLijst;
        }

        /*
          * this method mocks the Delete of Vak
          */
        public List<Vak> Delete(int input, List<Vak> vakkenLijst)
        {
            foreach (var x in vakkenLijst)
            {
                if (x.VakID == input)
                {
                    vakkenLijst.Remove(x);
                    return vakkenLijst;
                }
            }
            return vakkenLijst;
        }
    }

    
}
