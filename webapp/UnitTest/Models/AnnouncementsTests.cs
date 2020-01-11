using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using webapp.Models;

namespace UnitTest.Models
{
    [TestClass]
    public class AnnouncementsTests
    {
        private Announcements emptyAnnouncement;
        private Announcements fullAnnouncement;

        /*
         * before each test this is ran
         */
        [TestInitialize]
        public void dothisbeforeEach()
        {
            //create an empty announcement statement
            emptyAnnouncement = new Announcements();
            fullAnnouncement = new Announcements("this is an testAnnouncement", DateTime.Today, DateTime.Today);
        }

        //begin OF GETTERS AND SETTERS

        /*
          * this method is used to test all the getters that Announcement contains
          */
        [TestMethod]
        public void testGetters()
        {
            Assert.AreEqual("this is an testAnnouncement", fullAnnouncement.announcement);
            Assert.AreEqual(DateTime.Today, fullAnnouncement.startdate);
            Assert.AreEqual(DateTime.Today, fullAnnouncement.enddate);
        }

        /*
         * this method is used to test all the types that Announcement contains
         */
        [TestMethod]
        public void testTypes()
        {

            Assert.IsInstanceOfType(fullAnnouncement.announcement, typeof(string));
            Assert.IsInstanceOfType(fullAnnouncement.startdate, typeof(DateTime));
            Assert.IsInstanceOfType(fullAnnouncement.enddate, typeof(DateTime));
        }

        /*
         * this method test setter of announcement
         */
        [TestMethod]
        public void setVraagID()
        {
            emptyAnnouncement.announcement = "this is somethign";
            Assert.AreEqual(emptyAnnouncement.announcement, "this is somethign");
        }


        /*
        * this method test setter of startdate
        */
        [TestMethod]
        public void setStartDate()
        {
            emptyAnnouncement.startdate = DateTime.Today;
            Assert.AreEqual(emptyAnnouncement.startdate, DateTime.Today);
        }


        /*
        * this method test setter of enddate
        */
        [TestMethod]
        public void setEndDate()
        {
            emptyAnnouncement.enddate = DateTime.Today;
            Assert.AreEqual(emptyAnnouncement.enddate, DateTime.Today);
        }

        //END OF GETTERS AND SETTERS


        /*
        * this method tests Insert with a Question
        */
        [TestMethod]
        public void testInsertAnnouncement()
        {
            List<Announcements> announcementLijst = new List<Announcements>();
            announcementLijst.Add(fullAnnouncement);
            List<Announcements> test2 = insertAnnouncement(fullAnnouncement, announcementLijst);
            Assert.AreEqual(test2, announcementLijst);
        }

        /*
      * this method tests Remove with a Question
      */
        [TestMethod]
        public void testRemoveAnnouncement()
        {
            List<Announcements> announcementLijst = new List<Announcements>();
            announcementLijst.Add(fullAnnouncement);

            List<Announcements> announcementLijst2 = new List<Announcements>();

            List<Announcements> test2 = Remove(fullAnnouncement, announcementLijst);
            Assert.ReferenceEquals(test2, announcementLijst2);
        }

        /*
          * this method tests Remove with a Question
          */
        [TestMethod]
        public void testgetAnnouncements()
        {
            List<Announcements> announcementLijst = new List<Announcements>();
            announcementLijst.Add(fullAnnouncement);
            Announcements announcement = getAnnouncements(announcementLijst);
            Assert.AreEqual(announcement, fullAnnouncement);

        }

        /*
         * this method mocks the Insert of Announcement
         */
        public List<Announcements> insertAnnouncement(Announcements temp, List<Announcements> announcementLijst)
        {
            announcementLijst.Add(temp);
            return announcementLijst;
        }

   

        /*
       * this method mocks the Remove of Announcement
       */
        public List<Announcements> Remove(Announcements announcement, List<Announcements> announcementLijst)
        {

            announcementLijst.Remove(announcement);
            announcementLijst.Add(new Announcements("Noone", DateTime.MinValue, DateTime.MinValue));
            return announcementLijst;
        }

        public Announcements getAnnouncements(List<Announcements> announcementLijst)
        { 
            if(announcementLijst.Count != 0)
            {
                foreach(var x in announcementLijst)
                {
                    return x;
                }
            }
            return new Announcements();
           
        }
    }
}
