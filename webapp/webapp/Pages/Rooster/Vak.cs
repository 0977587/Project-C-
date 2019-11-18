using DatabaseController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using webapp;

namespace Vak1
{
    class Vak
    {
        public String Docent;
        public String Locaal;
        public String Naam;
        public String Discriptie;
        public Boolean Isleeg;

        public Vak(String a)
        {

            if (a.Contains("</font>"))
            {
                Isleeg = false;
                string[] l = a.Split("</font>");
                List<string> i = new List<string>();
                foreach (string s in l)
                {
                    i.Add(s);
                }
                i.RemoveAt(i.Count - 1);
                List<string> info = new List<string>();
                foreach (string s in i)
                {

                    string[] sf = s.Split("face=\"Arial\">");

                    info.Add(sf[1]);
                }

                this.Docent = info[0].Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
                if (Docent.Equals("RESCMI"))
                {
                    Isleeg = true;
                    return;
                }
                this.Locaal = info[2].Replace("\r\n", "").Replace("\r", "").Replace("\n", "").Replace("</b>", "").Replace("<b>", "");
                this.Naam = info[3].Replace("\r\n", "").Replace("\r", "").Replace("\n", "").Replace("</b>", "").Replace("<b>", "");
                if (this.Naam.Equals(this.Locaal))
                {
                    this.Naam = info[4].Replace("\r\n", "").Replace("\r", "").Replace("\n", "").Replace("</b>", "").Replace("<b>", "");
                    this.Discriptie = info[5].Replace("\r\n", "").Replace("\r", "").Replace("\n", "").Replace(","," ").Replace("'", "");
                }
                else
                {
                    this.Discriptie = info[4].Replace("\r\n", "").Replace("\r", "").Replace("\n", "").Replace(",", " ").Replace("'", "");
                }
                if(int.TryParse(this.Discriptie, out int n))
                {
                    this.Discriptie = "";
                }

            }
            else
            {
                Isleeg = true;
            }

        }
        public int VakInDb()
        {

            if (this.Isleeg == true)
            {

                return 0;
            }
            if (this.Naam.Equals("keuzevaktijd"))
            {
                return 0;
            }
            else
            {
                int vakid = Convert.ToInt32(new DBConnection().Send("INSERT INTO `projectcdb`.`vak` (`Docent`, `Locaal`, `Naam`, `Discriptie`, `Isleeg`) VALUES ('" + this.Docent + "', '" + this.Locaal + "', '" + this.Naam + "', '" + this.Discriptie + "', '0');SELECT LAST_INSERT_ID();")[0][0]);
                new DBConnection().Send("INSERT INTO `projectcdb`.`ingeschrevenvakken` (`UserID`, `vakID`) VALUES ('" + Sessie.GetInstance.getLoginUserID() + "', '" + vakid + "');");
                return vakid;
            }
        }
    }
}