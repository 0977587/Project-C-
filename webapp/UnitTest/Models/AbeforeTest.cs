using DatabaseController;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnitTest.Models;
using webapp.Models;
using FakeItEasy;
using NUnit;
using Microsoft.EntityFrameworkCore.Metadata;
using DocumentFormat.OpenXml.Math;

namespace UnitTest.Models
{



    

    [TestClass]
    public class PutinDatabaseTest
    {

        [TestInitialize]
        public void dothisbeforeEach()
        {

            List<List<String>> Vakken = new List<List<String>>();
            DBConnection dbc = new DBConnection();
            Vakken = dbc.Send("SELECT distinct isDatabase FROM projectcdb.testdatabase;");
            foreach (List<string> temp2 in Vakken)
            {
                if (temp2[0] == "1")
                {
                    clear();
                    dbc = new DBConnection();
                    Vakken = dbc.Send("UPDATE `projectcdb`.`testdatabase` SET `isDatabase` = '0' WHERE (`isDatabase` = '1');");
                }
            }

        }

        private void clear()
        {
            DBConnection dbc = new DBConnection();
            dbc.Send("DELETE FROM user;");
            dbc = new DBConnection();
            dbc.Send("DELETE FROM faqvragen;");
            dbc = new DBConnection();
            dbc.Send("DELETE FROM vraag;");
            dbc = new DBConnection();
            dbc.Send("DELETE FROM wachtrij;");
            dbc = new DBConnection();
            dbc.Send("DELETE FROM vak;");
            dbc = new DBConnection();

            insertAnnouncements();
            insertIngeschrevenVakken();
            insertUsers();
            insertVragen();
            insertWachtrij();
            insertVakken(); 

        }

        public void insertVragen()
        {
            DBConnection dbc = new DBConnection();

            Vraag emptyVraag;
            Vraag fullVraag;
            Vraag vraag1;
            Vraag vraag2;
            Vraag vraag3;
            //create an empty vraag statement
            fullVraag = new Vraag(1, 2, 20, "this is an question", "", false, DateTime.Today, DateTime.Today, "wd.1.2.3", 1, false);
            vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 1, false);
            vraag2 = new Vraag(3, 1, 21, "this is vraag2", "", false, DateTime.Today, DateTime.Today, "wd.1.2", 1, false);
            vraag3 = new Vraag(4, 1, 22, "this is vraag3", "", false, DateTime.Today, DateTime.Today, "wd.3.4", 1, false);
            vraag1.Insert();
            vraag2.Insert();
            vraag3.Insert();
            fullVraag.Insert();
            Assert.IsTrue(1 == 1);

        }

        public void insertWachtrij()
        {
            DateTime currentTime = DateTime.Now;
            int wachtrijid = 2;
            string name = "wachtrij";
            Wachtrij w = new Wachtrij(wachtrijid, currentTime, currentTime, name); 
        }

        public void insertVakken()
        {

            Vak emptyVak;
            Vak fullVak;
            Vak vak1;
            Vak vak2;
            emptyVak = new Vak();
            fullVak = new Vak(20, "marijke", "wd.1.2.3", "skills", "winst", false);
            vak1 = new Vak(21, "a", "wd12", "dev", "doe", false);
            vak2 = new Vak(22, "aa", "wd123", "dev1", "doen", false);
            fullVak.Insert();
            vak1.Insert();
            vak2.Insert();
        }

        public void insertAnnouncements()
        {
           Announcements fullAnnouncement = new Announcements("this is an testAnnouncement", DateTime.MinValue, DateTime.MinValue);
           fullAnnouncement.deleteAnnouncement();
           fullAnnouncement.insertAnnouncement();
        }
        
        public void insertUsers()
        {
            string rol = "s";
            int klasID = 0;
            string voornaam = "voornaamtest";
            string email = "emailtest";
            string wachtwoord = "wachtwoordtest";
            string achternaam = "achternaamtest";
            User u = new User(rol, klasID, voornaam, achternaam, email, wachtwoord);
            u.Insert();

        }

        public void insertIngeschrevenVakken()
        {
            Vak vara = new Vak(1, "x", "x", "x", "x", false);
            User r = new User("s", 1, "x", "x", "x", "x");
            vara.Insert();
            r.Insert();  
        }

        /*
         * this method mocks the Insert of Announcement and test if the announcement in the database is put in correctly
         * 
         */
        [TestMethod]
       public void testInsertAnnouncement()
        {
            List<Announcements> announcementLijst = new List<Announcements>();
            Announcements fullAnnouncement = new Announcements("this is an testAnnouncement", DateTime.MinValue, DateTime.MinValue);
            Announcements tempa = new Announcements();
            tempa.getAnnouncements();
            fullAnnouncement.startdate = tempa.startdate;
            Assert.IsTrue(fullAnnouncement.startdate == tempa.startdate);
            Assert.IsTrue(fullAnnouncement.enddate == tempa.enddate);
            Assert.IsTrue(fullAnnouncement.announcement == tempa.announcement);
        }
        /*
        * this method mocks the Insert of Announcement and test if the announcement in the database is put in correctly
        * 
        */
        [TestMethod]
        public void testInsertwrongAnnouncement()
        {
            List<Announcements> announcementLijst = new List<Announcements>();
            Announcements fullAnnouncement = new Announcements("this is an testAnnouncements", DateTime.MaxValue, DateTime.MaxValue);
            Announcements tempa = new Announcements();
            tempa.getAnnouncements();
            fullAnnouncement.startdate = tempa.startdate;
            Assert.IsFalse(fullAnnouncement.startdate == tempa.startdate);
            Assert.IsFalse(fullAnnouncement.enddate == tempa.enddate);
            Assert.IsFalse(fullAnnouncement.announcement == tempa.announcement);
        }

        /*
       * this method mocks the Insert of Announcement and test if the announcement in the database is put in correctly
       * 
       */
        [TestMethod]
        public void testEmptygAnnouncement()
        {
            List<Announcements> announcementLijst = new List<Announcements>();
            Announcements fullAnnouncement = new Announcements("this is an testAnnouncements", DateTime.MaxValue, DateTime.MaxValue);
            Announcements tempa = new Announcements();
            tempa.getAnnouncements();
            var tempa2 = new Announcements();
            tempa2 = tempa;
            tempa.deleteAnnouncement();
            tempa.getAnnouncements();
            Assert.IsTrue(tempa.startdate == DateTime.MinValue);
            Assert.IsTrue(tempa.enddate == DateTime.MinValue);
            Assert.IsTrue(tempa.announcement == "");
            tempa2.insertAnnouncement();
        }
    }


}
