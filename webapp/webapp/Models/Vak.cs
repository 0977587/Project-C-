using DatabaseController;
using System;
using System.Collections.Generic;
using System.Text;

namespace webapp.Models
{
    public class Vak
    {
        public int VakID { get; set; }
        public string Docent { get; set; }
        public string Locaal { get; set; }
        public string Naam { get; set; }
        public string Discriptie { get; set; }
        public Boolean Isleeg { get; set; }

        //alternative variable
        public string dagnaam;
        public string van;
        public string tot;

        public Vak(int vakID, string docent, string locaal, string naam, string discriptie, Boolean isleeg)
        {
            VakID = vakID;
            Docent = docent;
            Locaal = locaal;
            Naam = naam;
            Discriptie = discriptie;
            Isleeg = isleeg;
        }
        public Vak()
        {
        //lege constructor altijd handig
        }
        public int returnVaklength()
        {
            List<List<string>> returnstatement = new DBConnection().Send("SELECT MAX(VakID) FROM projectcdb.vak");
            int length = Convert.ToInt32(returnstatement[0][0]);
            return length + 1;
        }

        public void SelectOne(int input)
        {
            //geef vakID mee

            List<List<string>> returnstatement = new DBConnection().Send("SELECT * FROM projectcdb.vak WHERE vakID = " + input + ";");
            VakID = Convert.ToInt32(returnstatement[0][0]);
            if (returnstatement[0][1] != "")
                Docent = returnstatement[0][1];
            if (returnstatement[0][2] != "")
                Locaal = returnstatement[0][2];
            if (returnstatement[0][3] != "")
                Naam = returnstatement[0][3];
            if (returnstatement[0][4] != "")
                Discriptie = returnstatement[0][4];
            if (returnstatement[0][5] != "")
            {
                if (returnstatement[0][5] == "0")
                {
                    Isleeg = false;
                }
                else
                {
                    Isleeg = true;
                }
            }
        }
        public List<Vak> SelectAll()
        {
            //geef vraagID mee
            List<Vak> returnlist = new List<Vak>();
            List<List<string>> returnstatement = new DBConnection().Send("SELECT * FROM projectcdb.vak;");
            foreach (List<string> returnstatement2 in returnstatement)
            {
                Vak v = new Vak();
                v.VakID = Convert.ToInt32(returnstatement2[0]);
                if (returnstatement2[1] != "")
                    v.Docent = returnstatement2[1];
                if (returnstatement2[2] != "")
                    v.Locaal = returnstatement2[2];
                if (returnstatement2[3] != "")
                    v.Naam = returnstatement2[3];
                if (returnstatement2[4] != "")
                    v.Discriptie = returnstatement2[4];
                if (returnstatement2[5] != "")
                {
                    if (returnstatement2[5] == "0")
                    {
                        v.Isleeg = false;
                    }
                    else
                    {
                        v.Isleeg = true;
                    }
                }
                returnlist.Add(v);
            }
            return returnlist;
        }
        public void Delete()
        {
            //geef vraagID mee  
            List<List<string>> returnstatement = new DBConnection().Send("DELETE FROM `projectcdb`.`vak` WHERE (`vakID` = '" + VakID + "');");
        }
        public void Update()
        {
            int IsLeegbool;
            if (Isleeg == true)
            {
                IsLeegbool = 1;
            }
            else
            {
                IsLeegbool = 0;
            }
            new DBConnection().Send("UPDATE `projectcdb`.`vak` SET `Docent` = '" + Docent + "', `Locaal` = '" + Locaal + "', `Naam` = '" + Naam + "', `Discriptie` = '" + Discriptie + "', `Isleeg` = '" + IsLeegbool + "'WHERE (`VakID` = '" + VakID + "');");
        }
        public void Insert()
        {
            int IsLeegbool;
            if (Isleeg == true)
            {
                IsLeegbool = 1;
            }
            else
            {
                IsLeegbool = 0;
            }
            new DBConnection().Send("INSERT `projectcdb`.`vak` SET `VakID` = '" + VakID + "',`Docent` = '" + Docent + "', `Locaal` = '" + Locaal + "', `Naam` = '" + Naam + "', `Discriptie` = '" + Discriptie + "', `Isleeg` = '" + IsLeegbool + "';");
        }
        public void setinfo()
        {
            List<List<string>> returnstatement2 = new DBConnection().Send("SELECT * FROM projectcdb.roosterdag where Uur1 = " + this.VakID + " Or Uur2 = " + this.VakID + " Or Uur3 = " + this.VakID + " Or Uur4 = " + this.VakID + " Or Uur5 = " + this.VakID + " Or Uur6 = " + this.VakID + " Or Uur7 = " + this.VakID + " Or Uur8 = " + this.VakID + " Or Uur9 = " + this.VakID + " Or Uur10 = " + this.VakID + " Or Uur11 = " + this.VakID + " Or Uur12 = " + this.VakID + " Or Uur13 = " + this.VakID + " Or Uur14 = " + this.VakID + " Or Uur15 = " + this.VakID + ";");
            this.dagnaam = returnstatement2[0][17];
            List<int> ulist = new List<int>();
            if (Convert.ToInt32(returnstatement2[0][1]) == this.VakID)
            {
                ulist.Add(1);
            }
            if (Convert.ToInt32(returnstatement2[0][2]) == this.VakID)
            {
                ulist.Add(2);
            }
            if (Convert.ToInt32(returnstatement2[0][3]) == this.VakID)
            {
                ulist.Add(3);
            }
            if (Convert.ToInt32(returnstatement2[0][4]) == this.VakID)
            {
                ulist.Add(4);
            }
            if (Convert.ToInt32(returnstatement2[0][5]) == this.VakID)
            {
                ulist.Add(5);
            }
            if (Convert.ToInt32(returnstatement2[0][6]) == this.VakID)
            {
                ulist.Add(6);
            }
            if (Convert.ToInt32(returnstatement2[0][7]) == this.VakID)
            {
                ulist.Add(7);
            }
            if (Convert.ToInt32(returnstatement2[0][8]) == this.VakID)
            {
                ulist.Add(8);
            }
            if (Convert.ToInt32(returnstatement2[0][9]) == this.VakID)
            {
                ulist.Add(9);
            }
            if (Convert.ToInt32(returnstatement2[0][10]) == this.VakID)
            {
                ulist.Add(10);
            }
            if (Convert.ToInt32(returnstatement2[0][11]) == this.VakID)
            {
                ulist.Add(11);
            }
            if (Convert.ToInt32(returnstatement2[0][12]) == this.VakID)
            {
                ulist.Add(12);
            }
            if (Convert.ToInt32(returnstatement2[0][13]) == this.VakID)
            {
                ulist.Add(13);
            }
            if (Convert.ToInt32(returnstatement2[0][14]) == this.VakID)
            {
                ulist.Add(14);
            }
            if (Convert.ToInt32(returnstatement2[0][15]) == this.VakID)
            {
                ulist.Add(15);
            }


            if (ulist[0] == 1) 
            {
                van = "8:30";
            }
            if (ulist[0] == 2)
            {
                van = "9:20";
            }
            if (ulist[0] == 3)
            {
                van = "10:30";
            }
            if (ulist[0] == 4)
            {
                van = "11:20";
            }
            if (ulist[0] == 5)
            {
                van = "12:10";
            }
            if (ulist[0] == 6)
            {
                van = "13:00";
            }
            if (ulist[0] == 7)
            {
                van = "13:50";
            }
            if (ulist[0] == 8)
            {
                van = "15:00";
            }
            if (ulist[0] == 9)
            {
                van = "15:50";
            }
            if (ulist[0] == 10)
            {
                van = "17:00";
            }
            if (ulist[0] == 11)
            {
                van = "17:50";
            }
            if (ulist[0] == 12)
            {
                van = "18:40";
            }
            if (ulist[0] == 13)
            {
                van = "19:30";
            }
            if (ulist[0] == 14)
            {
                van = "20:20";
            }
            if (ulist[0] == 15)
            {
                van = "21:10";
            }

            ulist.Reverse();
            //reverse time

            if (ulist[0] == 1)
            {
                tot = "9:20";
            }
            if (ulist[0] == 2)
            {
                tot = "10:10";
            }
            if (ulist[0] == 3)
            {
                tot = "11:20";
            }
            if (ulist[0] == 4)
            {
                tot = "12:10";
            }
            if (ulist[0] == 5)
            {
                tot = "13:00";
            }
            if (ulist[0] == 6)
            {
                tot = "13:50";
            }
            if (ulist[0] == 7)
            {
                tot = "14:40";
            }
            if (ulist[0] == 8)
            {
                tot = "15:50";
            }
            if (ulist[0] == 9)
            {
                tot = "16:40";
            }
            if (ulist[0] == 10)
            {
                tot = "17:50";
            }
            if (ulist[0] == 11)
            {
                tot = "18:40";
            }
            if (ulist[0] == 12)
            {
                tot = "19:30";
            }
            if (ulist[0] == 13)
            {
                tot = "20:20";
            }
            if (ulist[0] == 14)
            {
                tot = "21:10";
            }
            if (ulist[0] == 15)
            {
                tot = "22:00";
            }

        }

    }
}
