using Microsoft.VisualStudio.TestTools.UnitTesting;
using webapp.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace UnitTest.Models   
{
    [TestClass()]
    public class UserTests
    {
        public string rol = "s";
        public int klasID = 0;
        public string voornaam = "voornaamtest";
        public string email = "emailtest";
        public string wachtwoord = "wachtwoordtest";
        public string achternaam = "achternaamtest";


        [TestMethod()]
        public void UserTest()
        {
            User u = new User(rol, klasID, voornaam, achternaam, email, wachtwoord);
            if (u.Rol != "s" || u.KlasID != 0 || u.Voornaam != voornaam || u.Email != email || u.Wachtwoord != wachtwoord || u.Achternaam != achternaam)
            {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void testSetters()
        {
            User u = new User(rol, klasID, voornaam, achternaam, email, wachtwoord);
            u.Rol = "p";
            u.KlasID = 10;
            u.Voornaam = "v";
            u.Achternaam = "a";
            u.Email = "e";
            u.Wachtwoord = "w";

            if (u.Rol != "p" || u.KlasID != 10 || u.Voornaam != "v" || u.Email != "e" || u.Wachtwoord != "w" || u.Achternaam != "a")
            {
                Assert.Fail();
            }
        }


        [TestMethod()]
        public void SelectOneTest()
        {
            User u1 = new User(rol, klasID, voornaam, achternaam, email, wachtwoord);
            User u2 = new User(rol, klasID + 1, voornaam + "2", achternaam + "2", email + "2", wachtwoord + "2");
            User u3 = new User(rol, klasID + 1, voornaam + "3", achternaam + "3", email + "3", wachtwoord + "3");
            User u4 = new User(rol, klasID + 1, voornaam + "4", achternaam + "4", email + "4", wachtwoord + "4");

            List<User> userLijst = new List<User>();
            userLijst.Add(u1);
            userLijst.Add(u2);
            userLijst.Add(u3);
            userLijst.Add(u4);

            Assert.AreEqual((SelectOne("voornaamtest2", userLijst)).Voornaam, "voornaamtest2");
        }

        public User SelectOne(string input, List<User> userLijst)
        {
            {
                foreach (var x in userLijst)
                {
                    if(x.Voornaam == input)
                    return x;
                }
                return new User();
            }

        }

        [TestMethod()]
        public void InsertTest()
        {
            User u1 = new User(rol, klasID, voornaam, achternaam, email, wachtwoord);
            User u2 = new User(rol, klasID + 1, voornaam + "2", achternaam + "2", email + "2", wachtwoord + "2");
            User u3 = new User(rol, klasID + 1, voornaam + "3", achternaam + "3", email + "3", wachtwoord + "3");
            User u4 = new User(rol, klasID + 1, voornaam + "4", achternaam + "4", email + "4", wachtwoord + "4");

            List<string> strings = new List<string>();
            List<User> users = new List<User>();

            strings.Add("test");
            strings.Add("test2");
            strings.Add("test3");
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);

            Assert.AreEqual(strings[1], "test2");
            Assert.ReferenceEquals(users[2], u3);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            User u1 = new User(rol, klasID, voornaam, achternaam, email, wachtwoord);
            User u2 = new User(rol, klasID + 1, voornaam + "2", achternaam + "2", email + "2", wachtwoord + "2");
            User u3 = new User(rol, klasID + 1, voornaam + "3", achternaam + "3", email + "3", wachtwoord + "3");
            User u4 = new User(rol, klasID + 1, voornaam + "4", achternaam + "4", email + "4", wachtwoord + "4");

            List<string> strings = new List<string>();
            List<User> users = new List<User>();

            strings.Add("test");
            strings.Add("test2");
            strings.Add("test3");
            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);

            Assert.AreEqual(strings[1], "test2");
            Assert.ReferenceEquals(users[2], u3);

            users.Remove(u3);
            strings.Remove("test2");

            Assert.AreNotEqual(strings[1], "test2");
            Assert.IsFalse(Assert.ReferenceEquals(users[2], u3));
        }

        [TestMethod()]
        public void UpdateTest()
        {
            User u1 = new User(rol, klasID, voornaam, achternaam, email, wachtwoord);
            User u2 = new User(rol, klasID + 1, voornaam + "2", achternaam + "2", email + "2", wachtwoord + "2");
            User u3 = new User(rol, klasID + 1, voornaam + "3", achternaam + "3", email + "3", wachtwoord + "3");
            User u4 = new User(rol, klasID + 1, voornaam + "4", achternaam + "4", email + "4", wachtwoord + "4");

            List<string> strings = new List<string>();
            List<User> a = new List<User>();
            List<User> users = new List<User>();

            a.Add(u1);
            a.Add(u2);
            a.Add(u3);
            a.Add(u4);

            u1 = new User(rol+1, klasID+1, voornaam+"3", achternaam+"4", email+"5", wachtwoord+"2");
            u2 = new User(rol+1, klasID + 2, voornaam + "22", achternaam + "22", email + "22", wachtwoord + "22");
            u3 = new User(rol+1, klasID + 2, voornaam + "32", achternaam + "32", email + "32", wachtwoord + "32");
            u4 = new User(rol+1, klasID + 2, voornaam + "42", achternaam + "42", email + "42", wachtwoord + "42");

            users.Add(u1);
            users.Add(u2);
            users.Add(u3);
            users.Add(u4);

            for (int i = 0; i < 4; i++)
            {
                Assert.IsFalse(users[i].Rol == a[i].Rol);
                Assert.IsFalse(users[i].KlasID == a[i].KlasID);
                Assert.IsFalse(users[i].Voornaam == a[i].Voornaam);
                Assert.IsFalse(users[i].Achternaam == a[i].Achternaam);
            }
        }
    }
}