using DatabaseController;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class Vak
    {
        String Docent;
        String Locaal;
        String Naam;
        String Discriptie;
        Boolean Isleeg;

        public Vak(String a)
        {
            
            if (a.Contains("</font>")) {
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
                this.Locaal = info[2].Replace("\r\n", "").Replace("\r", "").Replace("\n", "").Replace("</b>", "").Replace("<b>", "");
                this.Naam = info[3].Replace("\r\n", "").Replace("\r", "").Replace("\n", "").Replace("</b>", "").Replace("<b>", "");
                if (info.Count() == 5)
                {
                    this.Discriptie = info[4].Replace("\r\n", "").Replace("\r", "").Replace("\n", "");
                 }



            }
            else
            {
                Isleeg = true;
            }

        }
        public void VakInDb(int weeknummer, int dagnummer,int uurnummer,int klasnumber)
        {
            if (this.Isleeg == true)
            {
                
                //new DBConnection().Send("INSERT INTO `projectcdb`.`vak` (`VakID`, `Isleeg`) VALUES ('"+ klasnumber + weeknummer.ToString() + dagnummer.ToString() + uurnummer.ToString() + "', '1');");
            }
            else
            {
                DBConnection DBC = new DBConnection();
                new DBConnection().Send("INSERT INTO `projectcdb`.`vak` (`VakID`, `Docent`, `Locaal`, `Naam`, `Discriptie`, `Isleeg`) VALUES ('" + klasnumber + weeknummer.ToString() + dagnummer.ToString() +uurnummer.ToString()+ "', '"+this.Docent+"', '"+this.Locaal+"', '"+this.Naam+"', '"+this.Discriptie+"', '0');");
            }

        }




    }
}
