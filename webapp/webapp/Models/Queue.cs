﻿using DatabaseController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Models
{
    public class Wachtrij
    {
        public int WachtrijID { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime EndDate { get; set; }
        public String Name { get; set; }

        public Wachtrij(int wachtrijID, DateTime dateAdded, DateTime endDate, string name)
        {
            WachtrijID = wachtrijID;
            DateAdded = dateAdded;
            EndDate = endDate;
            Name = name;
        }

        // lege constructor 

        public Wachtrij()
        {

        }

        // constructor zonder naam
        public Wachtrij(int wachtrijID, DateTime dateAdded, DateTime endDate)
        {
            WachtrijID = wachtrijID;
            DateAdded = dateAdded;
            EndDate = endDate;
            Name = null;
        }

        public void SelectOne(int input)
        {
            // geef WachtrijID mee
            List<List<string>> returnstatement = new DBConnection().Send("SELECT * FROM projectcdb.user WHERE UserID = " + input + ";");
            WachtrijID = Convert.ToInt32(returnstatement[0][0]);
            if (returnstatement[0][1] != "")
                DateAdded = Convert.ToDateTime(returnstatement[0][1]);
            if (returnstatement[0][2] != "")
                EndDate = Convert.ToDateTime(returnstatement[0][2]);
            if (returnstatement[0][3] != "")
                Name = returnstatement[0][3];
        }

        public void Delete()
        {
            //geef WachtrijID mee  
            List<List<string>> returnstatement = new DBConnection().Send("DELETE FROM `projectcdb`.`Wachtrij` WHERE (`WachtrijID` = '" + WachtrijID + "';");
        }

        public void Update()
        {
            new DBConnection().Send("UPDATE `projectcdb`.`Wachtrij` SET `WachtrijID` = '" + WachtrijID + "', `DateAdded` = STR_TO_DATE('" + DateAdded + "','%d/%m/%Y %H:%i:%s'), `EndDate` = STR_TO_DATE('" + EndDate + "','%d/%m/%Y %H:%i:%s'), `Name` = '" + Name + "';");
        }

        public void Insert()
        {
            new DBConnection().Send("INSERT `projectcdb`.`Wachtrij` SET `WachtrijID` = '" + WachtrijID + "', `DateAdded` = STR_TO_DATE('" + DateAdded + "','%d/%m/%Y %H:%i:%s'), `EndDate` = STR_TO_DATE('" + EndDate + "','%d/%m/%Y %H:%i:%s'), `Name` = '" + Name + "';");
        }
    }
}
