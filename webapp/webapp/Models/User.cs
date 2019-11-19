using DatabaseController;
using System;
using System.Collections.Generic;
using System.Text;

namespace webapp.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Rol { get; set; }
        public int KlasID { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public Boolean IsEmailGeverifieerd { get; set; }
        public string ActivatieCode { get; set; }
        public string ResetWachtwoordCode { get; set; }

        public User(int userID, string rol, int klasID, string voornaam, string achternaam, string email, string wachtwoord, bool isEmailGeverifieerd, string activatieCode, string resetWachtwoordcode)
        {
            UserID = userID;
            Rol = rol;
            KlasID = klasID;
            Voornaam = voornaam;
            Email = email;
            Wachtwoord = wachtwoord;
            Achternaam = achternaam;
            IsEmailGeverifieerd = isEmailGeverifieerd;
            ActivatieCode = activatieCode;
            ResetWachtwoordCode = resetWachtwoordcode;
        }
        //lege constructor
        public User()
        {

        }
        //constructor zonder resetWachtwoordcode
        public User(int userID, string rol, int klasID, string voornaam, string email, string wachtwoord, string achternaam, bool isEmailGeverifieerd, string activatieCode)
        {
            UserID = userID;
            Rol = rol;
            KlasID = klasID;
            Voornaam = voornaam;
            Achternaam = achternaam;
            Email = email;
            Wachtwoord = wachtwoord;
            IsEmailGeverifieerd = isEmailGeverifieerd;
            ActivatieCode = activatieCode;
        }

        public int returnUserlength()
        {
            List<List<string>> returnstatement = new DBConnection().Send("SELECT MAX(UserID) FROM projectcdb.user");
            if (returnstatement[0][0].Equals(""))
            {
                return 0;
            }
            int length = Convert.ToInt32(returnstatement[0][0]);
            return length + 1;
        }
        public void SelectOne(int input)
        {
            //geef vraagID mee

            List<List<string>> returnstatement = new DBConnection().Send("SELECT * FROM projectcdb.user WHERE UserID = " + input + ";");
            UserID = Convert.ToInt32(returnstatement[0][0]);
            if (returnstatement[0][1] != "")
                Rol = returnstatement[0][1];
            if (returnstatement[0][2] != "")
                KlasID = Convert.ToInt32(returnstatement[0][2]);
            if (returnstatement[0][3] != "")
                Voornaam = returnstatement[0][3];
            if (returnstatement[0][4] != "")
                Email = returnstatement[0][4];
            if (returnstatement[0][5] != "")
                Wachtwoord = returnstatement[0][5];
            if (returnstatement[0][6] != "")
                Achternaam = returnstatement[0][6];
            if (returnstatement[0][7] != "")
            {
                if (returnstatement[0][7] == "0")
                {
                    IsEmailGeverifieerd = false;
                }
                else
                {
                    IsEmailGeverifieerd = true;
                }
            }
            if (returnstatement[0][8] != "")
                ActivatieCode = returnstatement[0][8];
            if (returnstatement[0][9] != "")
                ResetWachtwoordCode = returnstatement[0][9];
        }
        public List<User> SelectAll()
        {
            //geef vraagID mee
            List<User> returnlist = new List<User>();
            List<List<string>> returnstatement = new DBConnection().Send("SELECT * FROM projectcdb.user;");
            foreach (List<string> returnstatement2 in returnstatement)
            {
                User u = new User();
                u.UserID = Convert.ToInt32(returnstatement2[0]);
                if (returnstatement2[1] != "")
                    u.Rol = returnstatement2[1];
                if (returnstatement2[2] != "")
                    u.KlasID = Convert.ToInt32(returnstatement2[2]);
                if (returnstatement2[3] != "")
                    u.Voornaam = returnstatement2[3];
                if (returnstatement2[4] != "")
                    u.Email = returnstatement[0][4];
                if (returnstatement2[5] != "")
                    u.Wachtwoord = returnstatement2[5];
                if (returnstatement2[6] != "")
                    u.Achternaam = returnstatement2[6];
                if (returnstatement2[7] != "")
                {
                    if (returnstatement2[7] == "0")
                    {
                        u.IsEmailGeverifieerd = false;
                    }
                    else
                    {
                        u.IsEmailGeverifieerd = true;
                    }
                }
                if (returnstatement2[8] != "")
                    u.ActivatieCode = returnstatement2[8];
                if (returnstatement2[9] != "")
                    u.ResetWachtwoordCode = returnstatement2[9];
                returnlist.Add(u);
            }
            return returnlist;
        }
        public void Delete()
        {
            //geef userID mee  
            List<List<string>> returnstatement = new DBConnection().Send("DELETE FROM `projectcdb`.`user` WHERE (`userID` = '" + UserID + "');");
        }
        public void Update()
        {
            int IsLeegbool;
            if (IsEmailGeverifieerd == true)
            {
                IsLeegbool = 1;
            }
            else
            {
                IsLeegbool = 0;
            }
            new DBConnection().Send("UPDATE `projectcdb`.`user` SET `Rol` = '" + Rol + "', `KlasID` = '" + KlasID + "', `voornaam` = '" + Voornaam + "', `Email` = '" + Email + "', `Wachtwoord` = '" + Wachtwoord + "',`Achternaam` = '" + Achternaam + "',`IsEmailGeverifieerd` = '" + IsLeegbool + "',`ActivatieCode` = '" + ActivatieCode + "',`ResetWachtwoordCode` = '" + ResetWachtwoordCode + "'WHERE (`UserID` = '" + UserID + "');");
        }
        public void Insert()
        {
            int IsLeegbool;
            if (IsEmailGeverifieerd == true)
            {
                IsLeegbool = 1;
            }
            else
            {
                IsLeegbool = 0;
            }
            new DBConnection().Send("INSERT `projectcdb`.`user` SET `UserID` = '" + UserID + "',`Rol` = '" + Rol + "', `KlasID` = '" + KlasID + "', `voornaam` = '" + Voornaam + "', `Email` = '" + Email + "', `Wachtwoord` = '" + Wachtwoord + "',`Achternaam` = '" + Achternaam + "',`IsEmailGeverifieerd` = '" + IsLeegbool + "',`ActivatieCode` = '" + ActivatieCode + "',`ResetWachtwoordCode` = '" + ResetWachtwoordCode + "'");
        }
    }
}
