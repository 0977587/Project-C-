using System;
using System.Collections.Generic;
using System.Text;
using Vak1;
using Uurvak1;
using DatabaseController;

namespace Roosterdag
{
    class RoosterDag
    {
        string Dagnaam;
        int week;
        Vak Uur1;
        Vak Uur2;
        Vak Uur3;
        Vak Uur4;
        Vak Uur5;
        Vak Uur6;
        Vak Uur7;
        Vak Uur8;
        Vak Uur9;
        Vak Uur10;
        Vak Uur11;
        Vak Uur12;
        Vak Uur13;
        Vak Uur14;
        Vak Uur15;


        public RoosterDag(string a, int b)
        {
            Dagnaam = a;
            week = b;
        }
        public int FillNext(Vak a)
        {
            if (Uur1 == null)
            {
                Uur1 = a;
                return 1;
            }
            if (Uur2 == null)
            {
                Uur2 = a;
                return 2;
            }
            if (Uur3 == null)
            {
                Uur3 = a;
                return 3;
            }
            if (Uur4 == null)
            {
                Uur4 = a;
                return 4;
            }
            if (Uur5 == null)
            {
                Uur5 = a;
                return 5;
            }
            if (Uur6 == null)
            {
                Uur6 = a;
                return 6;
            }
            if (Uur7 == null)
            {
                Uur7 = a;
                return 7;
            }
            if (Uur8 == null)
            {
                Uur8 = a;
                return 8;
            }
            if (Uur9 == null)
            {
                Uur9 = a;
                return 9;
            }
            if (Uur10 == null)
            {
                Uur10 = a;
                return 10;
            }
            if (Uur11 == null)
            {
                Uur11 = a;
                return 11;
            }
            if (Uur12 == null)
            {
                Uur12 = a;
                return 12;
            }
            if (Uur13 == null)
            {
                Uur13 = a;
                return 13;
            }
            if (Uur14 == null)
            {
                Uur14 = a;
                return 14;
            }
            if (Uur15 == null)
            {
                Uur15 = a;
                return 15;
            }

            return 0;
        }
        public void VakkenNaarDb(int weeknummer, int dagnummer, int klasnumber, int roosterweekID)
        {
            int u1;
            int u2;
            int u3;
            int u4;
            int u5;
            int u6;
            int u7;
            int u8;
            int u9;
            int u10;
            int u11;
            int u12;
            int u13;
            int u14;
            int u15;

            u1 = Uur1.VakInDb();
            u2 = Check(Uur1, Uur2, u1);
            u3 = Check(Uur2, Uur3, u2);
            u4 = Check(Uur3, Uur4, u3);
            u5 = Check(Uur4, Uur5, u4);
            u6 = Check(Uur5, Uur6, u5);
            u7 = Check(Uur6, Uur7, u6);
            u8 = Check(Uur7, Uur8, u7);
            u9 = Check(Uur8, Uur9, u8);
            u10 = Check(Uur9, Uur10, u9);
            u11 = Check(Uur10, Uur11, u10);
            u12 = Check(Uur11, Uur12, u11);
            u13 = Check(Uur12, Uur13, u12);
            u14 = Check(Uur13, Uur14, u13);
            u15 = Check(Uur14, Uur15, u14);

            new DBConnection().Send("INSERT INTO `projectcdb`.`roosterdag` (`Uur1`, `Uur2`, `Uur3`, `Uur4`, `Uur5`, `Uur6`, `Uur7`, `Uur8`, `Uur9`, `Uur10`, `Uur11`, `Uur12`, `Uur13`, `Uur14`, `Uur15`, `RoosterWeekID`, `DagnNaam`) VALUES ('" + u1 + "', '" + u2 + "', '" + u3 + "', '" + u4 + "', '" + u5 + "', '" + u6 + "', '" + u7 + "', '" + u8 + "', '" + u9 + "', '" + u10 + "', '" + u11 + "', '" + u12 + "', '" + u13 + "', '" + u14 + "','" + u15 + "', '" + roosterweekID + "', '" + this.Dagnaam + " ');");



        }

        private int Check(Vak v1, Vak v2, int n1)
        {
            if (v1.Naam == null)
            {
                return v2.VakInDb();
            }
            if (v1.Naam.Equals(v2.Naam))
            {
                return n1;
            }
            else
            {
                return v2.VakInDb();
            }
        }
    }
}
