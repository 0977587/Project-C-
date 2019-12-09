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

        public User(string rol, int klasID, string voornaam, string achternaam, string email, string wachtwoord)
        {
            Rol = rol;
            KlasID = klasID;
            Voornaam = voornaam;
            Email = email;
            Wachtwoord = wachtwoord;
            Achternaam = achternaam;
        }
        //lege constructor
        public User()
        {

        }

        public User(string rol, string voornaam, string achternaam, string email, string wachtwoord)
        {
            KlasID = 0;
            Rol = rol;
            Voornaam = voornaam;
            Email = email;
            Wachtwoord = wachtwoord;
            Achternaam = achternaam;
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

        }

        public void Delete()
        {
            //geef userID mee  
            List<List<string>> returnstatement = new DBConnection().Send("DELETE FROM `projectcdb`.`user` WHERE (`userID` = '" + UserID + "');");
        }
        public void Update()
        {
            new DBConnection().Send("UPDATE `projectcdb`.`user` SET `Rol` = '" + Rol + "', `KlasID` = '" + KlasID + "', `voornaam` = '" + Voornaam + "', `Email` = '" + Email + "', `Wachtwoord` = '" + Wachtwoord + "',`Achternaam` = '" + Achternaam + "' WHERE userID = '" + UserID + "';");
        }
        public void Insert()
        {
            Wachtwoord.GetHashCode();
            new DBConnection().Send("INSERT `projectcdb`.`user` SET `Rol` = '" + Rol + "', `KlasID` = '" + KlasID + "', `voornaam` = '" + Voornaam + "', `Email` = '" + Email + "', `Wachtwoord` = '" + Wachtwoord + "',`Achternaam` = '" + Achternaam + "';");
        }
    }
}