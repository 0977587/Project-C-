using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using DatabaseController;
using Uurvak1;
using Roosterdag;
using Vak1;

namespace Roosterzoeker
{
    class RoosterZoeker
    {
        public void Zoek(String klas,int week)
        {
            int klasnumber = 0;
            if (klas == "INF1A")
            {
                klasnumber = 77;
            }
            if (klas == "INF1B")
            {
                klasnumber = 78;
            }
            if (klas == "INF1C")
            {
                klasnumber = 79;
            }
            if (klas == "INF1D")
            {
                klasnumber = 80;
            }
            if (klas == "INF1E")
            {
                klasnumber = 81;
            }
            if (klas == "INF1F")
            {
                klasnumber =82;
            }
            if (klas == "INF1G")
            {
                klasnumber = 83;
            }
            if (klas == "INF1H")
            {
                klasnumber = 84;
            }
            if (klas == "INF1I")
            {
                klasnumber = 85;
            }
            if (klas == "INF1J")
            {
                klasnumber = 86;
            }
            //Lijsten opstellen
            List<string> UrenList = new List<string>();
            List<Uurvak> Uurvakken = new List<Uurvak>();

            //HTML OPVRAGEN
            string html = string.Empty;
            string url = @"http://misc.hro.nl/roosterdienst/webroosters/CMI/kw1/"+week+"/c/c000"+klasnumber+".htm";

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
            RoosterDag r1 = new RoosterDag("Maandag",44);
            RoosterDag r2 = new RoosterDag("Dinsdag",44);
            RoosterDag r3 = new RoosterDag("Woensdag",44);
            RoosterDag r4 = new RoosterDag("Donderdag",44);
            RoosterDag r5 = new RoosterDag("Vrijdag",44);

            foreach (Uurvak s1 in Uurvakken)
            {
                r1.FillNext(new Vak(s1.maandag));
                r2.FillNext(new Vak(s1.dinsdag));
                r3.FillNext(new Vak(s1.woensdag));
                r4.FillNext(new Vak(s1.donderdag));
                r5.FillNext(new Vak(s1.vrijdag));

            }

            int weeknummer = week - 37;
            new DBConnection().Send("INSERT INTO `projectcdb`.`roosterweek` (`RoosterWeekID`, `WeekNummer`, `KlasID`) VALUES ('" + klasnumber + week + "', '" + weeknummer + "', '" + klasnumber + "');");
            new DBConnection().Send("INSERT INTO `projectcdb`.`roosterdag` (`RoosterDagID`, `Uur1`, `Uur2`, `Uur3`, `Uur4`, `Uur5`, `Uur6`, `Uur7`, `Uur8`, `Uur9`, `Uur10`, `Uur11`, `Uur12`, `Uur13`, `Uur14`, `Uur15`, `RoosterWeekID`, `DagnNaam`) VALUES ('" + klasnumber + week + "1', '" + week + "11', '" + week + "12', '" + week + "13', '" + week + "14', '" + week + "15', '" + week + "16', '" + week + "17', '" + week + "18', '" + week + "19', '" + week + "110', '" + week + "111', '" + week + "112', '" + week + "113', '" + week + "113', '" + week + "115', '" + week + "', 'Maandag');");
            new DBConnection().Send("INSERT INTO `projectcdb`.`roosterdag` (`RoosterDagID`, `Uur1`, `Uur2`, `Uur3`, `Uur4`, `Uur5`, `Uur6`, `Uur7`, `Uur8`, `Uur9`, `Uur10`, `Uur11`, `Uur12`, `Uur13`, `Uur14`, `Uur15`, `RoosterWeekID`, `DagnNaam`) VALUES ('" + klasnumber + week + "2', '" + week + "21', '" + week + "22', '" + week + "23', '" + week + "24', '" + week + "25', '" + week + "26', '" + week + "27', '" + week + "28', '" + week + "29', '" + week + "210', '" + week + "211', '" + week + "212', '" + week + "213', '" + week + "213', '" + week + "215', '" + week + "', 'Dinsdag');");
            new DBConnection().Send("INSERT INTO `projectcdb`.`roosterdag` (`RoosterDagID`, `Uur1`, `Uur2`, `Uur3`, `Uur4`, `Uur5`, `Uur6`, `Uur7`, `Uur8`, `Uur9`, `Uur10`, `Uur11`, `Uur12`, `Uur13`, `Uur14`, `Uur15`, `RoosterWeekID`, `DagnNaam`) VALUES ('" + klasnumber + week + "3', '" + week + "31', '" + week + "32', '" + week + "33', '" + week + "34', '" + week + "35', '" + week + "36', '" + week + "37', '" + week + "38', '" + week + "39', '" + week + "310', '" + week + "311', '" + week + "312', '" + week + "313', '" + week + "313', '" + week + "315', '" + week + "', 'Woensdag');");
            new DBConnection().Send("INSERT INTO `projectcdb`.`roosterdag` (`RoosterDagID`, `Uur1`, `Uur2`, `Uur3`, `Uur4`, `Uur5`, `Uur6`, `Uur7`, `Uur8`, `Uur9`, `Uur10`, `Uur11`, `Uur12`, `Uur13`, `Uur14`, `Uur15`, `RoosterWeekID`, `DagnNaam`) VALUES ('" + klasnumber + week + "4', '" + week + "41', '" + week + "42', '" + week + "43', '" + week + "44', '" + week + "45', '" + week + "46', '" + week + "47', '" + week + "48', '" + week + "49', '" + week + "410', '" + week + "411', '" + week + "412', '" + week + "413', '" + week + "413', '" + week + "415', '" + week + "', 'Donderdag');");
            new DBConnection().Send("INSERT INTO `projectcdb`.`roosterdag` (`RoosterDagID`, `Uur1`, `Uur2`, `Uur3`, `Uur4`, `Uur5`, `Uur6`, `Uur7`, `Uur8`, `Uur9`, `Uur10`, `Uur11`, `Uur12`, `Uur13`, `Uur14`, `Uur15`, `RoosterWeekID`, `DagnNaam`) VALUES ('" + klasnumber + week + "5', '" + week + "51', '" + week + "52', '" + week + "53', '" + week + "54', '" + week + "55', '" + week + "56', '" + week + "57', '" + week + "58', '" + week + "59', '" + week + "510', '" + week + "511', '" + week + "512', '" + week + "513', '" + week + "513', '" + week + "515', '" + week + "', 'Vrijdag');");

            r1.VakkenNaarDb(week, 1, klasnumber);
            r2.VakkenNaarDb(week, 2, klasnumber);
            r3.VakkenNaarDb(week, 3, klasnumber);
            r4.VakkenNaarDb(week, 4, klasnumber);
            r5.VakkenNaarDb(week, 5, klasnumber);

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
    }
}
