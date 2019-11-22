using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using DatabaseController;
using Uurvak1;
using Roosterdag;
using Vak1;
using System.Globalization;
using webapp;

namespace Roosterzoeker
{

    /// <summary>
    /// new RoosterZoeker().Zoek("INF1A",47);
    /// </summary>
    class RoosterZoeker
    {
        List<int> idlist = new List<int>();
        public int klasnumber;
        public int week;
        public void Zoek(int Klasnumber)
        {
            klasnumber = Klasnumber;

            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            week = ciCurr.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            

            List<List<string>> checky = new DBConnection().Send("SELECT * FROM projectcdb.roosterweek Where WeekNummer = "+week+" AND KlasID = "+klasnumber+";");
            if (checky.Count != 0)
            {
                herlaad();
                return;
            }




            //Lijsten opstellen
            List<string> UrenList = new List<string>();
            List<Uurvak> Uurvakken = new List<Uurvak>();

            //HTML OPVRAGEN
            string html = string.Empty;
            string url = @"http://misc.hro.nl/roosterdienst/webroosters/CMI/kw2/" + week + "/c/c000" + klasnumber + ".htm";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            //Uren verdelen
            String L = html;
            for (int i = 0; i < 15; i++)
            {
                int count = i + 1;
                string Scount = "<b>" + count.ToString() + "</b>";
                string[] S = L.Split(Scount);
                UrenList.Add(S[0]);
                L = S[1];
                if (i == 14)
                {
                    string eind = S[1];
                    string[] S2 = L.Split("Nr.");
                    UrenList.Add(S2[0]);
                }
            }
            UrenList.RemoveAt(0);

            //uurvakken aanmaken
            for (int i = 1; i < 16; i++)
            {
                Uurvakken.Add(new Uurvak(i));
            }
            int count2 = 0;
            //Uren lostrekken
            foreach (string s in UrenList)
            {
                List<string> splitlist = new List<string>();

                string[] strings = s.Split("</tr></table></td>");

                foreach (string s1 in strings)
                {
                    splitlist.Add(s1);
                }

                splitlist.RemoveAt(0);
                splitlist.RemoveAt(splitlist.Count - 1);
                //Uurvakken vullen

                foreach (string uur in splitlist)
                {
                    if (uur.Contains("rowspan=\"2\""))
                    {
                        Uurvakken[count2].fillNextEmpty(uur);
                    }
                    if (uur.Contains("rowspan=\"4\""))
                    {
                        int a = Uurvakken[count2].fillNextEmpty(uur);
                        Uurvakken[count2 + 1].fillday(a, uur);
                    }
                    if (uur.Contains("rowspan=\"6\""))
                    {
                        int a = Uurvakken[count2].fillNextEmpty(uur);
                        Uurvakken[count2 + 1].fillday(a, uur);
                        Uurvakken[count2 + 2].fillday(a, uur);
                    }
                    if (uur.Contains("rowspan=\"8\""))
                    {
                        int a = Uurvakken[count2].fillNextEmpty(uur);
                        Uurvakken[count2 + 1].fillday(a, uur);
                        Uurvakken[count2 + 2].fillday(a, uur);
                        Uurvakken[count2 + 3].fillday(a, uur);
                    }
                    if (uur.Contains("rowspan=\"10\""))
                    {
                        int a = Uurvakken[count2].fillNextEmpty(uur);
                        Uurvakken[count2 + 1].fillday(a, uur);
                        Uurvakken[count2 + 2].fillday(a, uur);
                        Uurvakken[count2 + 3].fillday(a, uur);
                        Uurvakken[count2 + 4].fillday(a, uur);
                    }
                    if (uur.Contains("rowspan=\"12\""))
                    {
                        int a = Uurvakken[count2].fillNextEmpty(uur);
                        Uurvakken[count2 + 1].fillday(a, uur);
                        Uurvakken[count2 + 2].fillday(a, uur);
                        Uurvakken[count2 + 3].fillday(a, uur);
                        Uurvakken[count2 + 4].fillday(a, uur);
                        Uurvakken[count2 + 5].fillday(a, uur);
                    }

                }
                count2++;
            }
            RoosterDag r1 = new RoosterDag("Maandag", week);
            RoosterDag r2 = new RoosterDag("Dinsdag", week);
            RoosterDag r3 = new RoosterDag("Woensdag", week);
            RoosterDag r4 = new RoosterDag("Donderdag", week);
            RoosterDag r5 = new RoosterDag("Vrijdag", week);

            foreach (Uurvak s1 in Uurvakken)
            {
                r1.FillNext(new Vak(s1.maandag));
                r2.FillNext(new Vak(s1.dinsdag));
                r3.FillNext(new Vak(s1.woensdag));
                r4.FillNext(new Vak(s1.donderdag));
                r5.FillNext(new Vak(s1.vrijdag));

            }


            int roosterweekID = Convert.ToInt32(new DBConnection().Send("INSERT INTO `projectcdb`.`roosterweek` (`WeekNummer`, `KlasID`) VALUES ('" + week + "', '" + klasnumber + "');SELECT LAST_INSERT_ID();")[0][0]);
            r1.VakkenNaarDb(week, 1, klasnumber, roosterweekID);
            r2.VakkenNaarDb(week, 2, klasnumber, roosterweekID);
            r3.VakkenNaarDb(week, 3, klasnumber, roosterweekID);
            r4.VakkenNaarDb(week, 4, klasnumber, roosterweekID);
            r5.VakkenNaarDb(week, 5, klasnumber, roosterweekID);



            //new DBConnection().Send("INSERT INTO `projectcdb`.`roosterdag` (`RoosterDagID`, `Uur1`, `Uur2`, `Uur3`, `Uur4`, `Uur5`, `Uur6`, `Uur7`, `Uur8`, `Uur9`, `Uur10`, `Uur11`, `Uur12`, `Uur13`, `Uur14`, `Uur15`, `RoosterWeekID`, `DagnNaam`) VALUES ('" + klasnumber + week + "1', '" + week + "11', '" + week + "12', '" + week + "13', '" + week + "14', '" + week + "15', '" + week + "16', '" + week + "17', '" + week + "18', '" + week + "19', '" + week + "110', '" + week + "111', '" + week + "112', '" + week + "113', '" + week + "113', '" + week + "115', '" + week + "', 'Maandag');");



            //Zet dit in het zoek rooster knopje
            // RoosterZoeker a = new RoosterZoeker();

            // a.Zoek("INF1A", 44);
            // a.Zoek("INF1B", 44);
            //a.Zoek("INF1C", 44);
            //a.Zoek("INF1D", 44);
            //a.Zoek("INF1E", 44);
            //a.Zoek("INF1F", 44);
            // a.Zoek("INF1H", 44);
            // a.Zoek("INF1I", 44);
            //a.Zoek("INF1J", 44);
            //a.Zoek("INF1K", 44);



        }
        public void herlaad()
        {
            new DBConnection().Send("DELETE FROM `projectcdb`.`ingeschrevenvakken` WHERE (`UserID` = '"+Sessie.GetInstance.getLoginUserID()+"');");
            List<List<string>> rw = new DBConnection().Send("SELECT * FROM projectcdb.roosterweek Where WeekNummer = " + week + " AND KlasID = " + klasnumber + ";");
            List<List<string>> rd = new DBConnection().Send("SELECT * FROM projectcdb.roosterdag where RoosterWeekID = "+rw[0][0]+";");
            foreach (List<string> a in rd)
            {
                idcheck(Convert.ToInt32(a[1]));
                idcheck(Convert.ToInt32(a[2]));
                idcheck(Convert.ToInt32(a[3]));
                idcheck(Convert.ToInt32(a[4]));
                idcheck(Convert.ToInt32(a[5]));
                idcheck(Convert.ToInt32(a[6]));
                idcheck(Convert.ToInt32(a[7]));
                idcheck(Convert.ToInt32(a[8]));
                idcheck(Convert.ToInt32(a[9]));
                idcheck(Convert.ToInt32(a[10]));
                idcheck(Convert.ToInt32(a[11]));
                idcheck(Convert.ToInt32(a[12]));
                idcheck(Convert.ToInt32(a[13]));
                idcheck(Convert.ToInt32(a[14]));
                idcheck(Convert.ToInt32(a[15]));
            }






        }
        public void idcheck(int u1)
        {
            if (u1 != 0 && !idlist.Contains(u1))
            {

                idlist.Add(u1);
                new DBConnection().Send("INSERT INTO `projectcdb`.`ingeschrevenvakken` (`UserID`, `vakID`) VALUES ('" + Sessie.GetInstance.getLoginUserID() + "', '" + u1 + "');");

            }
        }
    }
}
