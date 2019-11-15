using DatabaseController;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webapp.Models
{
    //info over vragen 
    public class Vraag
    {
      
        public int VraagID { get; set; }
       
        public int UserID { get; set; }
        public int VakID { get; set; }
        public string VraagText { get; set; }
        public string AndwoordText { get; set; }
        public Boolean IsFAQ { get; set; }
        public DateTime DateAdded  { get; set; }
        public DateTime EndDate { get; set; }

        public string Locatie { get; set; }
        
        public Boolean isInProgress { get; set; }

        //constructor met andwoordtext
        public Vraag(int vraagID, int userID, int vakID, string vraagText, string andwoordText, bool isFAQ, DateTime dateAdded, DateTime endDate, string locatie, Boolean isinprogress)
        {
            VraagID = vraagID;
            UserID = userID;
            VakID = vakID;
            VraagText = vraagText;
            AndwoordText = andwoordText;
            IsFAQ = isFAQ;
            DateAdded = dateAdded;
            EndDate = endDate;
            Locatie = locatie;
            isInProgress = isinprogress; 
        }

        public int returnVraagLength()
        {
            List<List<string>> returnstatement = new DBConnection().Send("SELECT MAX(vraagId) FROM projectcdb.vraag");
            int length = Convert.ToInt32(returnstatement[0][0]);
            return length + 1;
        }

        //constructor zonder andwoordtext
        public Vraag(int vraagID, int userID, int vakID, string vraagText, bool isFAQ, string andwoordText, DateTime dateAdded, DateTime endDate)
        {
            VraagID = vraagID;
            UserID = userID;
            VakID = vakID;
            VraagText = vraagText;
            IsFAQ = isFAQ;
            DateAdded = dateAdded;
            EndDate = endDate;
        }
        //lege constructor
        public Vraag(string v)
        {

        }

        public Vraag()
        {
        }

        public void SelectOne(int input)
        {
            //geef vraagID mee

            List<List<string>> returnstatement = new DBConnection().Send("SELECT * FROM projectcdb.vraag WHERE vraagID = " + input + ";");
            VraagID = Convert.ToInt32(returnstatement[0][0]);
            if (returnstatement[0][1] != "") 
                UserID = Convert.ToInt32(returnstatement[0][1]);
            if (returnstatement[0][2] != "")
                VakID = Convert.ToInt32(returnstatement[0][2]);
            if (returnstatement[0][3] != "")
                VraagText = returnstatement[0][3];
            if (returnstatement[0][4] != "")
                AndwoordText = returnstatement[0][4];
            if (returnstatement[0][5] != "")
            {
                if (returnstatement[0][5] == "0")
                {
                    IsFAQ = false;
                }
                else
                {
                    IsFAQ = true;
                }
            }
            if (returnstatement[0][6] != "")
                DateAdded = Convert.ToDateTime(returnstatement[0][6]);
            if (returnstatement[0][7] != "")
                EndDate = Convert.ToDateTime(returnstatement[0][7]);

        }
        public static List<Vraag> SelectAll()
        {
            //geef vraagID mee
            List<Vraag> returnlist = new List<Vraag>();
            List<List<string>> returnstatement = new DBConnection().Send("SELECT * FROM projectcdb.vraag;");
            foreach (List<string> returnstatement2 in returnstatement)
            {
                Vraag v = new Vraag();
                v.VraagID = Convert.ToInt32(returnstatement2[0]);
                if (returnstatement2[1] != "")
                    v.UserID = Convert.ToInt32(returnstatement2[1]);
                if (returnstatement2[2] != "")
                    v.VakID = Convert.ToInt32(returnstatement2[2]);
                if (returnstatement2[3] != "")
                    v.VraagText = returnstatement2[3];
                if (returnstatement2[4] != "")
                    v.AndwoordText = returnstatement2[4];
                if (returnstatement2[5] != "")
                {
                    if (returnstatement2[5] == "0")
                    {
                        v.IsFAQ = false;
                    }
                    else
                    {
                        v.IsFAQ = true;
                    }
                }
                if (returnstatement2[6] != "")
                    v.DateAdded = Convert.ToDateTime(returnstatement2[6]);
                if (returnstatement2[7] != "")
                    v.EndDate = Convert.ToDateTime(returnstatement2[7]);
                returnlist.Add(v);
            }
            return returnlist;
        }
        public void Delete()
        {
             //geef vraagID mee  
            List<List<string>> returnstatement = new DBConnection().Send("DELETE FROM `projectcdb`.`vraag` WHERE (`vraagID` = '"+ VraagID + "');");      
        }
        public void Update()
        {
            int IsFAQbool;
            if (IsFAQ == true)
            {
                IsFAQbool = 1;
            }
            else
            {
                IsFAQbool = 0;
            }
            new DBConnection().Send("UPDATE `projectcdb`.`vraag` SET `UserID` = '"+UserID+"', `VakID` = '"+VakID+"', `VraagText` = '"+VraagText+"', `AndwoordText` = '"+AndwoordText+"', `IsFAQ` = '"+IsFAQbool+ "', `DateAdded` = STR_TO_DATE('" + DateAdded + "','%d/%m/%Y %H:%i:%s'), `EndDate` = STR_TO_DATE('" + EndDate + "','%d/%m/%Y %H:%i:%s') WHERE (`vraagID` = '" + VraagID+"');");
        }
        public void Insert()
        {
            int IsFAQbool;
            if (IsFAQ == true)
            {
                IsFAQbool = 1;
            }
            else
            {
                IsFAQbool = 0;
            }
            new DBConnection().Send("INSERT `projectcdb`.`vraag` SET `VraagID` = '" + VraagID + "',`UserID` = '" + UserID + "', `VakID` = '" + VakID + "', `VraagText` = '" + VraagText + "', `AndwoordText` = '" + AndwoordText + "', `IsFAQ` = '" + IsFAQbool + "', `DateAdded` = STR_TO_DATE('" + DateAdded + "','%d/%m/%Y %H:%i:%s'), `EndDate` = STR_TO_DATE('" + EndDate + "','%d/%m/%Y %H:%i:%s');");
        }
    }


}
