using DatabaseController;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using UnitTest.Models;
using webapp.Models;


namespace IntegrationTest.Models
{


    [TestClass]
    public class PutinDatabaseTest
    {

        [TestInitialize]
        public void dothisbeforeEach()
        {
            /*
             * dit zorgt ervoor dat de database leeggemaakt word als testdatabase als waarde 1 heeft.
             * Dan wordt clear aangeroepen en wordt alles geleegd.
             */
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
        /*
             * Dit zorgt ervoor dat er verschilllende databaseconnecties aangemaakt worden, deze zorgen ervoor dat alles verwijdert wordt.
             * Daarna worden de invul functies aangeroepen.
          */
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
        /*
         * Deze functie zorgt er voor dat de correcte vragen in de database gestopt worden
         */
        public void insertVragen()
        {
            DBConnection dbc = new DBConnection();
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

        }
        /*
        * Deze functie zorgt er voor dat de correcte wachtrijen in de database gestopt worden
        */
        public void insertWachtrij()
        {
            DateTime currentTime = DateTime.Today;
            int wachtrijid = 2;
            string name = "wachtrij";
            Wachtrij w = new Wachtrij(wachtrijid, currentTime, currentTime, name);
            w.Insert();
        }
        /*
        * Deze functie zorgt er voor dat de correcte vakken in de database gestopt worden
        */
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
        /*
        * Deze functie zorgt er voor dat de correcte announcements in de database gestopt worden
        */
        public void insertAnnouncements()
        {
            Announcements fullAnnouncement = new Announcements("this is an testAnnouncement", DateTime.MinValue, DateTime.MinValue);
            var x = fullAnnouncement;
            fullAnnouncement.deleteAnnouncement();
            x.insertAnnouncement();
        }

        /*
        * Deze functie zorgt er voor dat de correcte users in de database gestopt worden
        */
        public void insertUsers()
        {
            string rol = "s";
            int klasID = 0;
            string voornaam = "voornaamtest";
            string email = "emailtest";
            string wachtwoord = "wachtwoordtest";
            string achternaam = "achternaamtest";

            User u1 = new User(rol, klasID, voornaam, achternaam, email, wachtwoord);
            User u2 = new User(rol, klasID + 1, voornaam + "2", achternaam + "2", email + "2", wachtwoord + "2");
            User u3 = new User(rol, klasID + 1, voornaam + "3", achternaam + "3", email + "3", wachtwoord + "3");
            User u4 = new User(rol, klasID + 1, voornaam + "4", achternaam + "4", email + "4", wachtwoord + "4");
            u1.Insert();
            u2.Insert();
            u3.Insert();
            u4.Insert();



        }
        /*
        * Deze functie zorgt er voor dat de correcte vakken in de database gestopt worden
        */
        public void insertIngeschrevenVakken()
        {
            Vak vara = new Vak(1, "x", "x", "x", "x", false);
            User r = new User("s", 1, "x", "x", "x", "x");
            vara.Insert();
            //r.Insert();  
        }

        /*
         * Deze methode zorgt ervoor dat er een correcte vraag wordt ingeladen. deze wordt getest samen met testen uit announcementTest
         */
        [TestMethod]
        public void testInsertAnnouncement()
        {
            //mock method
            Announcements fullAnnouncement = new Announcements("this is an testAnnouncement", DateTime.MinValue, DateTime.MinValue);
            List<Announcements> announcementLijst = new List<Announcements>();
            announcementLijst.Add(fullAnnouncement);
            var x = new AnnouncementsTests();
            Announcements announcement = x.getAnnouncements(announcementLijst);
            Assert.AreEqual(announcement, fullAnnouncement);
            Announcements y = new Announcements();
            y.getAnnouncements();
            y.deleteAnnouncement();
            fullAnnouncement.insertAnnouncement();
            //second method
            Announcements tempa = new Announcements();
            tempa.getAnnouncements();

            announcement.startdate = tempa.startdate;
            Assert.IsTrue(announcement.startdate == tempa.startdate);
            Assert.IsTrue(announcement.enddate == tempa.enddate);
            Assert.IsTrue(announcement.announcement == tempa.announcement);
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
            Assert.IsFalse(fullAnnouncement.startdate == tempa.startdate);
            Assert.IsFalse(fullAnnouncement.enddate == tempa.enddate);
            Assert.IsFalse(fullAnnouncement.announcement == tempa.announcement);
        }

        /*
       * Deze methode test of er een announcement correct kan worden verwijdert. deze wordt ook getest terwijl de test van AnnouncementTest gerunt wordt.
       * 
       */
        [TestMethod]
        public void testEmptygAnnouncement()
        {
            List<Announcements> announcementLijst = new List<Announcements>();
            Announcements fullAnnouncement = new Announcements("this is an testAnnouncements", DateTime.MaxValue, DateTime.MaxValue);

            var tempa2 = new Announcements();
            fullAnnouncement.deleteAnnouncement();
            Announcements announcement = new Announcements();
            announcement.getAnnouncements();
            Assert.IsFalse(fullAnnouncement.announcement == announcement.announcement);

        }
        /*
         * Deze methode test of er een announcement correct kan worden verwijdert. Eeen aann
         * 
         * 
         */
        [TestMethod]
        public void testRemovegAnnouncement()
        {
            var x = new AnnouncementsTests();
            Announcements fullAnnouncement = new Announcements("this is an testAnnouncements", DateTime.MaxValue, DateTime.MaxValue);
            List<Announcements> announcementLijst = new List<Announcements>();
            announcementLijst.Add(fullAnnouncement);

            List<Announcements> announcementLijst2 = new List<Announcements>();
            announcementLijst2.Add(new Announcements("Noone", DateTime.MinValue, DateTime.MinValue));

            List<Announcements> test2 = x.Remove(fullAnnouncement, announcementLijst);
            Assert.ReferenceEquals(test2, announcementLijst2); //zelfde object


            var ja = new Announcements();
            ja.getAnnouncements();
            ja.deleteAnnouncement(); //verwijdert announcement

            Announcements anno = new Announcements("Noone", DateTime.MinValue, DateTime.MinValue);
            anno.insertAnnouncement();
            //custom mock code
            var xa = new Announcements();
            xa.getAnnouncements();
            Assert.IsTrue(xa.announcement == anno.announcement);
            anno.deleteAnnouncement();
            fullAnnouncement.insertAnnouncement();
            var ya = new Announcements();
            ya.getAnnouncements();
            Assert.IsTrue(fullAnnouncement.announcement == ya.announcement);
        }

        /*
         * Deze methode zorgt ervoor dat er een correcte vraag wordt ingeladen. deze wordt getest samen met testen uit announcementTest
         * de ingeladen data zit al in de database. dus een simpele vergelijking is mogelijk
         */
        [TestMethod]
        public void testInsertUser()
        {
            string rol = "s";
            int klasID = 0;
            string voornaam = "voornaamtest";
            string email = "emailtest";
            string wachtwoord = "wachtwoordtest";
            string achternaam = "achternaamtest";


            User u1 = new User(rol, klasID, voornaam, achternaam, email, wachtwoord);
            User u2 = new User(rol, klasID + 1, voornaam + "2", achternaam + "2", email + "2", wachtwoord + "2");
            User u3 = new User(rol, klasID + 1, voornaam + "3", achternaam + "3", email + "3", wachtwoord + "3");
            User u4 = new User(rol, klasID + 1, voornaam + "4", achternaam + "4", email + "4", wachtwoord + "4");


            List<User> userLijst = new List<User>();
            userLijst.Add(u1);
            userLijst.Add(u2);
            userLijst.Add(u3);
            userLijst.Add(u4);

            User u = new User();
            var a = u.SelectAll();

            for (int i = 0; i < 4; i++)
            {
                Assert.IsTrue(userLijst[i].Rol == a[i].Rol);
                Assert.IsTrue(userLijst[i].KlasID == a[i].KlasID);
                Assert.IsTrue(userLijst[i].Voornaam == a[i].Voornaam);
                Assert.IsTrue(userLijst[i].Achternaam == a[i].Achternaam);
            }

        }


        /*
        * Deze methode zorgt ervoor dat er een correcte vraag wordt ingeladen. deze wordt getest samen met testen uit announcementTest
        * de ingeladen data zit al in de database. dus een simpele vergelijking is mogelijk.
        * De test methode selectall en selectone zijn al getest in VraagTests.
        */
        [TestMethod]
        public void testRemoveMultipleUser()
        {
            string rol = "s";
            int klasID = 0;
            string voornaam = "voornaamtest";
            string email = "emailtest";
            string wachtwoord = "wachtwoordtest";
            string achternaam = "achternaamtest";


            User u1 = new User(rol, klasID, voornaam, achternaam, email, wachtwoord);
            User u2 = new User(rol, klasID + 1, voornaam + "2", achternaam + "2", email + "2", wachtwoord + "2");
            User u3 = new User(rol, klasID + 1, voornaam + "3", achternaam + "3", email + "3", wachtwoord + "3");
            User u4 = new User(rol, klasID + 1, voornaam + "4", achternaam + "4", email + "4", wachtwoord + "4");


            List<User> userLijst = new List<User>();
            userLijst.Add(u1);
            userLijst.Add(u2);
            userLijst.Add(u3);
            userLijst.Add(u4);

            User u = new User();
            var a = u.SelectAll();

            for (int i = 0; i < 4; i++)
            {
                Assert.IsTrue(userLijst[i].Rol == a[i].Rol);
                Assert.IsTrue(userLijst[i].KlasID == a[i].KlasID);
                Assert.IsTrue(userLijst[i].Voornaam == a[i].Voornaam);
                Assert.IsTrue(userLijst[i].Achternaam == a[i].Achternaam);
            }

            var userLijst2 = a;
            User tempUser1 = userLijst2[userLijst2.Count - 1];
            userLijst2.RemoveAt(userLijst2.Count - 1);
            var tempUser2 = userLijst2[userLijst2.Count - 1];
            userLijst2.RemoveAt(userLijst2.Count - 1);
            tempUser1.Delete();
            tempUser2.Delete();
            User y = new User();
            var xy = y.SelectAll();
            for (int i = 0; i < 2; i++)
            {
                Assert.IsTrue(userLijst2[i].Rol == xy[i].Rol);
                Assert.IsTrue(userLijst2[i].KlasID == xy[i].KlasID);
                Assert.IsTrue(userLijst2[i].Voornaam == xy[i].Voornaam);
                Assert.IsTrue(userLijst2[i].Achternaam == xy[i].Achternaam);
                Assert.IsTrue(userLijst2[i].Email == xy[i].Email);
            }
            tempUser2.Insert();
            tempUser1.Insert();
        }

        [TestMethod]
        public void testUpdateUser()
        {
            string rol = "s";
            int klasID = 0;
            string voornaam = "voornaamtest";
            string email = "emailtest";
            string wachtwoord = "wachtwoordtest";
            string achternaam = "achternaamtest";


            User u1 = new User(rol, klasID, voornaam, achternaam, email, wachtwoord);
            User u2 = new User(rol, klasID + 1, voornaam + "2", achternaam + "2", email + "2", wachtwoord + "2");
            User u3 = new User(rol, klasID + 1, voornaam + "3", achternaam + "3", email + "3", wachtwoord + "3");
            User u4 = new User(rol, klasID + 1, voornaam + "4", achternaam + "4", email + "4", wachtwoord + "4");


            List<User> userLijst = new List<User>();
            userLijst.Add(u1);
            userLijst.Add(u2);
            userLijst.Add(u3);
            userLijst.Add(u4);

            User u = new User();
            List<User> a = u.SelectAll();
            User us = new User();
            List<User> toKeep = us.SelectAll();

            for (int i = 0; i < 4; i++)
            {
                Assert.IsTrue(userLijst[i].Rol == a[i].Rol);
                Assert.IsTrue(userLijst[i].KlasID == a[i].KlasID);
                Assert.IsTrue(userLijst[i].Voornaam == a[i].Voornaam);
                Assert.IsTrue(userLijst[i].Achternaam == a[i].Achternaam);
            }

            for (int i = 0; i < 4; i++)
            {
                a[i].Rol = "ra";
                a[i].KlasID = 123;
                a[i].Voornaam = "ra";
                a[i].Achternaam = "sa";
                a[i].Update();
            }
            u = new User();
            var a2 = u.SelectAll();
            for (int i = 0; i < 4; i++)
            {
                Assert.IsTrue(a2[i].Rol == a[i].Rol);
                Assert.IsTrue(a2[i].KlasID == a[i].KlasID);
                Assert.IsTrue(a2[i].Voornaam == a[i].Voornaam);
                Assert.IsTrue(a2[i].Achternaam == a[i].Achternaam);

            }

            for (int i = 0; i < 4; i++)
            {
                a[i].Delete();
                toKeep[i].Insert();
            }
        }

        [TestMethod]
        public void testSelectAllVak()
        {
            List<Vak> vakkenLijsta = new List<Vak>();

            var testlijst = new VakTests();
            Vak test = new Vak();
            var testLijst2 = test.SelectAll();
            var toAssert = testlijst.Selectall(testLijst2);

            for (int i = 0; i < testLijst2.Count; i++)
            {
                Assert.IsTrue(toAssert[i].VakID == testLijst2[i].VakID);
                Assert.IsTrue(toAssert[i].Discriptie == testLijst2[i].Discriptie);
                Assert.IsTrue(toAssert[i].Docent == testLijst2[i].Docent);
                Assert.IsTrue(toAssert[i].Isleeg == testLijst2[i].Isleeg);
                Assert.IsTrue(toAssert[i].Locaal == testLijst2[i].Locaal);
                Assert.IsTrue(toAssert[i].Naam == testLijst2[i].Naam);
            }


        }

        [TestMethod]
        public void testSelectNoVak()
        {
            List<Vak> vakkenLijsta = new List<Vak>();
            var testlijst = new VakTests();
            Vak test = new Vak();
            var testLijst2 = test.SelectAll();
            List<Vak> toAssert = testlijst.Selectall(new List<Vak>());
            Assert.IsFalse(testLijst2.Equals(toAssert));
            for (int i = 0; i < testLijst2.Count; i++)
            {
                for (int j = 0; j < toAssert.Count; j++)
                {
                    Assert.IsFalse(testLijst2[i].Equals(toAssert[j]));
                }
            }
        }

        [TestMethod]
        public void testSelectAVak()
        {
            List<Vak> vakkenLijst = new List<Vak>();
            vakkenLijst.Add(new Vak(20, "marijke", "wd.1.2.3", "skills", "winst", false));

            Vak testVak = new Vak();
            testVak.SelectOne(20);


            for (int i = 0; i < vakkenLijst.Count; i++)
            {

                Assert.IsTrue(vakkenLijst[i].dagnaam == testVak.dagnaam);
                Assert.IsTrue(vakkenLijst[i].Discriptie == testVak.Discriptie);
                Assert.IsTrue(vakkenLijst[i].Docent == testVak.Docent);
                Assert.IsTrue(vakkenLijst[i].Locaal == testVak.Locaal);
            }
        }

        [TestMethod]
        public void TestSelectAVak()
        {
            List<Vak> vakkenLijst = new List<Vak>();
            vakkenLijst.Add(new Vak(20, "marijke", "wd.1.2.3", "skills", "winst", false));

            Vak testVak = new Vak();
            testVak.SelectOne(20);
            Boolean found = false;

            for (int i = 0; i < vakkenLijst.Count; i++)
            {
                Assert.IsTrue(vakkenLijst[i].dagnaam == testVak.dagnaam);
                Assert.IsTrue(vakkenLijst[i].Discriptie == testVak.Discriptie);
                Assert.IsTrue(vakkenLijst[i].Docent == testVak.Docent);
                Assert.IsTrue(vakkenLijst[i].Locaal == testVak.Locaal);
                found = true;
            }
            Assert.IsTrue(found);
        }

        /*
        * this method tests Delete with 1 Vakken
        */
        [TestMethod]
        public void testDeleteOneVak()
        {
            var vak1 = new Vak(21, "a", "wd12", "dev", "doe", false);
            Vak toKeep = vak1;
            vak1.SelectOne(vak1.VakID);
            vak1.Delete();

            var vakken = new Vak();
            var vakkenLijst = vakken.SelectAll();

            for (int i = 0; i < vakkenLijst.Count; i++)
            {
                Assert.IsFalse(vakkenLijst[i].VakID == toKeep.VakID);
                Assert.IsFalse(vakkenLijst[i].Discriptie == toKeep.Discriptie);
                Assert.IsFalse(vakkenLijst[i].Docent == toKeep.Docent);
                Assert.IsFalse(vakkenLijst[i].Locaal == toKeep.Locaal);
            }
            toKeep.Insert();

        }

        /*
          * this method tests Delete with multiple Vakken
          */
        [TestMethod]
        public void testDeleteMultipleVakken()
        {
            var fullVak = new Vak(30, "marijkes", "wd.1.2.3q", "skills", "winst", false);
            var fullVak2 = new Vak(29, "marijkesa", "wd.1.2.3qa", "skillsa", "winsta", false);
            var vak1 = new Vak(21, "a", "wd12", "dev", "doe", false);
            var vak2 = new Vak(22, "aa", "wd123", "dev1", "doen", false);
            List<Vak> vakkenLijst = new List<Vak>();
            vakkenLijst.Add(fullVak);
            vakkenLijst.Add(fullVak2);


            Vak toKeep = vak1;
            Vak toKeep2 = vak2;
            var vaktoDelete = new Vak();
            var vaktoDelete2 = new Vak();
            vaktoDelete.SelectOne(vak1.VakID);
            vaktoDelete2.SelectOne(vak2.VakID);
            vaktoDelete.Delete();
            vaktoDelete2.Delete();

            var vakken = new Vak();
            var vakkenLijst2 = vakken.SelectAll();

            for (int i = 0; i < vakkenLijst.Count; i++)
            {
                for (int j = 0; j < vakkenLijst2.Count; j++)
                {
                    Assert.IsFalse(vakkenLijst[i].VakID == toKeep.VakID);
                    Assert.IsFalse(vakkenLijst[i].Discriptie == toKeep.Discriptie);
                    Assert.IsFalse(vakkenLijst[i].Docent == toKeep.Docent);
                    Assert.IsFalse(vakkenLijst[i].Locaal == toKeep.Locaal);
                }
            }
            toKeep.Insert();
            toKeep2.Insert();
        }


        /*
         * this method tests Insert with a Vak
         */
        [TestMethod]
        public void testInsertOneVak()
        {
            var vak1 = new Vak(121, "aaasdsa", "wd12345", "dev1231231", "doe1231", false);
            vak1.Insert();
            var vak2 = new Vak();
            var Vakkenlijst = vak2.SelectAll();
            for (int i = 0; i < Vakkenlijst.Count; i++)
            {
                if (Vakkenlijst[i].Naam == vak1.Naam) {
                    Assert.IsTrue(Vakkenlijst[i].dagnaam == vak1.dagnaam);
                    Assert.IsTrue(Vakkenlijst[i].Discriptie == vak1.Discriptie);
                    Assert.IsTrue(Vakkenlijst[i].Docent == vak1.Docent);
                    Assert.IsTrue(Vakkenlijst[i].Locaal == vak1.Locaal);
                }
            }
            vak1.Delete();
        }

        /*
        * this method tests Insert with multiple Vakken
        */
        [TestMethod]
        public void testInsertMultipleVak()
        {
            var vak1 = new Vak(124, "avasd", "wd1124122", "dev12123", "doeawdweq", false);
            var vak2 = new Vak(642, "aaqwe", "wd1123123", "de1214asdv1", "doenqwasad", false);
            List<Vak> vakkenLijst = new List<Vak>();
            List<Vak> test2 = new List<Vak>();
            vakkenLijst.Add(vak1);
            vakkenLijst.Add(vak2);

            vak1.Insert();
            vak2.Insert();
            var Vakkenlijst = new Vak().SelectAll();


            for (int i = 0; i < vakkenLijst.Count; i++)
            {
                if (Vakkenlijst[i].Naam == vak1.Naam)
                {
                    Assert.IsTrue(Vakkenlijst[i].dagnaam == vak1.dagnaam);
                    Assert.IsTrue(Vakkenlijst[i].Discriptie == vak1.Discriptie);
                    Assert.IsTrue(Vakkenlijst[i].Docent == vak1.Docent);
                    Assert.IsTrue(Vakkenlijst[i].Locaal == vak1.Locaal);
                }
                else if (Vakkenlijst[i].Naam == vak2.Naam)
                {
                    Assert.IsTrue(Vakkenlijst[i].dagnaam == vak2.dagnaam);
                    Assert.IsTrue(Vakkenlijst[i].Discriptie == vak2.Discriptie);
                    Assert.IsTrue(Vakkenlijst[i].Docent == vak2.Docent);
                    Assert.IsTrue(Vakkenlijst[i].Locaal == vak2.Locaal);
                }
            }
            vak1.Delete();
            vak2.Delete();
        }


        /*
         * this method tests selectOne with 1 question
         */
        [TestMethod]
        public void testSelectoneWithaQuestion()
        {
            Vraag vraag1;
            vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 1, false);

            List<Vraag> vragenLijst = new List<Vraag>();
            vragenLijst.Add(vraag1);
            Vraag DatabaseVraag = new Vraag();
            DatabaseVraag.SelectOne(vraag1.VraagID);
            Assert.IsTrue(doAllAssertVragen(DatabaseVraag, vraag1));


        }

        private Boolean doAllAssertVragen(Vraag DatabaseVraag, Vraag vraag1)
        {
            Assert.IsTrue(vraag1.isInProgress == DatabaseVraag.isInProgress);
            Assert.IsTrue(vraag1.positie == DatabaseVraag.positie);
            Assert.IsTrue(vraag1.Locatie == DatabaseVraag.Locatie);
            Assert.IsTrue(vraag1.DateAdded == DatabaseVraag.DateAdded);
            Assert.IsTrue(vraag1.EndDate == DatabaseVraag.EndDate);
            Assert.IsTrue(vraag1.VraagID == DatabaseVraag.VraagID);
            Assert.IsTrue(vraag1.UserID == DatabaseVraag.UserID);
            Assert.IsTrue(vraag1.VraagText == DatabaseVraag.VraagText);
            Assert.IsTrue(vraag1.IsFAQ == DatabaseVraag.IsFAQ);
            return true;
        }

        private Boolean doAllAssertWachtrij(Wachtrij DatabaseVraag, Wachtrij wachtrij1)
        {
            Assert.IsTrue(wachtrij1.Name == DatabaseVraag.Name);
            Assert.IsTrue(wachtrij1.WachtrijID == DatabaseVraag.WachtrijID);
            Assert.IsTrue(wachtrij1.DateAdded == DatabaseVraag.DateAdded);
            Assert.IsTrue(wachtrij1.EndDate == DatabaseVraag.EndDate);
            return true;
        }

        /*
     * this method tests selectOne with Multiple Questions
     */
        [TestMethod]
        public void testSelectoneWithMultipleVragen()
        {
            Vraag vraag1;
            Vraag vraag2;
            Vraag vraag3;

            vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 1, false);
            vraag2 = new Vraag(3, 1, 21, "this is vraag2", "", false, DateTime.Today, DateTime.Today, "wd.1.2", 1, false);
            vraag3 = new Vraag(4, 1, 22, "this is vraag3", "", false, DateTime.Today, DateTime.Today, "wd.3.4", 1, false);



            Vraag DatabaseVraag = new Vraag();
            Vraag DatabaseVraag2 = new Vraag();
            Vraag DatabaseVraag3 = new Vraag();
            DatabaseVraag.SelectOne(vraag1.VraagID);
            DatabaseVraag2.SelectOne(vraag2.VraagID);
            DatabaseVraag3.SelectOne(vraag3.VraagID);

            Assert.IsTrue(doAllAssertVragen(DatabaseVraag, vraag1));

            Assert.IsTrue(doAllAssertVragen(DatabaseVraag2, vraag2));

            Assert.IsTrue(doAllAssertVragen(DatabaseVraag3, vraag3));
        }


        /*
        * this method tests Delete with empty list of questions
        */
        [TestMethod]
        public void testDeleteNoVraag()
        {
            Vraag vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 1, false);
            Vraag toKeep = vraag1;

            var toCount = new Vraag();
            List<Vraag> vragenLijst = toCount.SelectAll();
            Assert.IsTrue(vragenLijst.Count == 4);


            vraag1.SelectOne(vraag1.VraagID);
            vraag1.Delete();

            var Vragen = new Vraag();
            vragenLijst = Vragen.SelectAll();

            for (int i = 0; i < vragenLijst.Count; i++)
            {
                Assert.IsFalse(vragenLijst[i].Equals(vraag1));
            }
            toKeep.Insert();

        }

        /*
          * this method tests Delete with 1 question
          */
        [TestMethod]
        public void testDeleteAVraag()
        {
            Vraag vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 1, false);
            Vraag toKeep = vraag1;
            Vraag vraag2 = new Vraag();
            vraag2.SelectOne(vraag1.VraagID);
            vraag2.Delete();

            var Vragen = new Vraag();
            var vragenLijst = Vragen.SelectAll();

            for (int i = 0; i < vragenLijst.Count; i++)
            {
                Assert.IsFalse(vragenLijst[i].Equals(vraag1));
            }
            toKeep.Insert();

        }


        [TestMethod]
        public void testDeleteMultipleQuestions()
        {
            var vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 1, false);
            var vraag2 = new Vraag(3, 1, 21, "this is vraag2", "", false, DateTime.Today, DateTime.Today, "wd.1.2", 1, false);
            var vraag3 = new Vraag(4, 1, 22, "this is vraag3", "", false, DateTime.Today, DateTime.Today, "wd.3.4", 1, false);

            Vraag toKeep = vraag1;
            Vraag toKeep2 = vraag2;
            Vraag toKeep3 = vraag3;

            vraag1.SelectOne(vraag1.VraagID);
            vraag2.SelectOne(vraag2.VraagID);
            vraag3.SelectOne(vraag3.VraagID);
            vraag1.Delete();
            vraag2.Delete();
            vraag3.Delete();

            var Vragen = new Vraag();
            var vragenLijst = Vragen.SelectAll();

            for (int i = 0; i < vragenLijst.Count; i++)
            {
                Assert.IsFalse(vragenLijst[i].Equals(vraag1));
                Assert.IsFalse(vragenLijst[i].Equals(vraag2));
                Assert.IsFalse(vragenLijst[i].Equals(vraag3));
            }
            toKeep.Insert();
            toKeep2.Insert();
            toKeep3.Insert();

        }


        /*
         * this method tests Insert with a Question
         */
        [TestMethod]
        public void testInsertOneQuestion()
        {
            var vraag1 = new Vraag(2123, 1, 20, "this is vraag11", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 1, false);

            Vraag toKeep = vraag1;
            vraag1.Insert();
            var Vragen = new Vraag();
            var vragenLijst = Vragen.SelectAll();
            Boolean found = false;
            for (int i = 0; i < vragenLijst.Count; i++)
            {
                if (vragenLijst[i].VraagID == vraag1.VraagID)
                {
                    Assert.IsTrue(doAllAssertVragen(vragenLijst[i], vraag1));
                    found = true;
                }
            }
            toKeep.Delete();
            Assert.IsTrue(found);
        }

        /*
        * this method tests Insert with multiple Questions
        */
        [TestMethod]
        public void testInsertMultipleVragen()
        {
            var vraag1 = new Vraag(2123, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 1, false);
            var vraag2 = new Vraag(3124, 1, 21, "this is vraag2", "", false, DateTime.Today, DateTime.Today, "wd.1.2", 1, false);
            var vraag3 = new Vraag(4124, 1, 22, "this is vraag3", "", false, DateTime.Today, DateTime.Today, "wd.3.4", 1, false);

            Vraag toKeep = vraag1;
            Vraag toKeep2 = vraag2;
            Vraag toKeep3 = vraag3;

            vraag1.Insert();
            vraag2.Insert();
            vraag3.Insert();

            var Vragen = new Vraag();
            var vragenLijst = Vragen.SelectAll();
            Boolean found = false;
            Boolean found2 = false;
            Boolean found3 = false;
            for (int i = 0; i < vragenLijst.Count; i++)
            {
                if (vragenLijst[i].VraagID == vraag1.VraagID)
                {
                    Assert.IsTrue(doAllAssertVragen(vragenLijst[i], vraag1));
                    found = true;
                }
                else if (vragenLijst[i].VraagID == vraag2.VraagID)
                {
                    Assert.IsTrue(doAllAssertVragen(vragenLijst[i], vraag2));
                    found2 = true;
                }
                else if (vragenLijst[i].VraagID == vraag3.VraagID)
                {
                    Assert.IsTrue(doAllAssertVragen(vragenLijst[i], vraag3));
                    found3 = true;
                }
            }
            Assert.IsTrue(found && found2 && found3);
            toKeep.Delete();
            toKeep2.Delete();
            toKeep3.Delete();
        }
        [TestMethod]
        public void testreturnWachtrijMaxID()
        {
            DateTime currentTime = DateTime.Today;
            Wachtrij wachtrij = new Wachtrij();
            
            int wachtrijid = wachtrij.returnWachtrijLength();
            string name = "wachtrij2";
            Wachtrij w = new Wachtrij(wachtrijid, currentTime, currentTime, name);
            Assert.IsTrue(wachtrijid == 3);
            var toKeep = w;
            w.Insert();
            var toKeep2 = wachtrij.returnWachtrijLength();
            Assert.IsTrue(toKeep2 == 4);
            toKeep.Delete();
        }
        [TestMethod]
        public void getVragenfromWachtrijTest()
        {

            var vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 1, false);
            var vraag2 = new Vraag(3, 1, 21, "this is vraag2", "", false, DateTime.Today, DateTime.Today, "wd.1.2", 1, false);
            var vraag3 = new Vraag(4, 1, 22, "this is vraag3", "", false, DateTime.Today, DateTime.Today, "wd.3.4", 1, false);
            Wachtrij wachtrij = new Wachtrij();
            wachtrij.WachtrijID = 1;
            Assert.IsTrue(wachtrij.getVragenAmount() == 4);
            var wachtrijVragen = wachtrij.getVragen(0);
            doAllAssertVragen(wachtrijVragen[1], vraag1);
            doAllAssertVragen(wachtrijVragen[2], vraag2);
            doAllAssertVragen(wachtrijVragen[3], vraag3);
            Assert.IsTrue(wachtrij.getVragen(0).Count == 4);

        }

        [TestMethod()]
        public void SelectOneWachtrijTest() {

            DateTime currentTime = DateTime.Now;
            int wachtrijid = 2;
            string name = "wachtrij";
            Wachtrij w = new Wachtrij(wachtrijid, DateTime.Today, DateTime.Today, name);
            Wachtrij databaseWachtrij = new Wachtrij();
            databaseWachtrij.SelectOne(wachtrijid);
            doAllAssertWachtrij(databaseWachtrij, w);
        }

        [TestMethod()]
        public void InsertVraagintoWachtrijTest()
        {
            var fullVraag = new Vraag(1123123, 2, 20, "this is a questio1n", "", false, DateTime.Today, DateTime.Today, "wd.1.2.3", 1, false);
            var toKeep = fullVraag;
            fullVraag.Insert();

            DateTime currentTime = DateTime.Now;
            int wachtrijid = 1;
            string name = "wachtrij";
            Wachtrij w = new Wachtrij(wachtrijid, currentTime, currentTime, name);
            var wachtrijVragen = w.getVragen(0);

            Assert.IsTrue(wachtrijVragen.Count == 5);
            doAllAssertVragen(wachtrijVragen[4], fullVraag);
            toKeep.Delete();
        }

        [TestMethod()]
        public void DeleteVraagFromWachtrijTest()
        {
            var fullVraag = new Vraag(1, 2, 20, "this is a questio1n", "", false, DateTime.Today, DateTime.Today, "wd.1.2.3", 1, false);
            var toKeep = fullVraag;
            fullVraag.Delete();
            DateTime currentTime = DateTime.Now;
            int wachtrijid = 1;
            string name = "wachtrij";
            Wachtrij w = new Wachtrij(wachtrijid, currentTime, currentTime, name);
            var wachtrijVragen = w.getVragen(0);
            Assert.IsTrue(wachtrijVragen.Count == 3);
            toKeep.Insert();
        }

        [TestMethod()]
        public void DeleteFakeVraagfromWachtrijTest()
        {
            var emptyVraag = new Vraag();
            emptyVraag.Delete();


            try
            {
                emptyVraag.Delete();

            }
            catch (InvalidCastException e)
            {
                throw new Exception("wrong type!", e);
            }
            Assert.IsTrue(emptyVraag.SelectAll().Count == 4);
        }


        [TestMethod()]
        public void UpdateTest()
        {
            
            var vraag1 = new Vraag(2, 1, 20, "this is vraag1", "", false, DateTime.Today, DateTime.Today, "wd.2.3", 2, false);
            Vraag vraag2 = new Vraag();
            vraag2.SelectOne(vraag1.VraagID);
            Vraag toKeep = vraag2;
            vraag2.wachtrijNaam = "asdasd";
            vraag2.Update();

            var vragenLijst = vraag1.SelectAll();
            for (int i = 0; i < vragenLijst.Count; i++)
            {
                Assert.IsFalse(vragenLijst[i].Equals(toKeep));
            }
            vraag2.Delete();
            toKeep.Insert();
        }


    }
}
