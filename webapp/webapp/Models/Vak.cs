using DatabaseController;
using System;
using System.Collections.Generic;
using System.Text;

namespace Vakken
{
    class Vak
    {
        public int VakID { get; set; }
        public string Docent { get; set; }
        public string Locaal { get; set; }
        public string Naam { get; set; }
        public string Discriptie { get; set; }
        public Boolean Isleeg { get; set; }

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

    }
}
