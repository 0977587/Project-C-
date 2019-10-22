using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
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
        public void VakkenNaarDb(int weeknummer, int dagnummer,int klasnumber)
        {
            Uur1.VakInDb(weeknummer, dagnummer,1, klasnumber);
            Uur2.VakInDb(weeknummer, dagnummer, 2, klasnumber);
            Uur3.VakInDb(weeknummer, dagnummer, 3, klasnumber);
            Uur4.VakInDb(weeknummer, dagnummer, 4, klasnumber);
            Uur5.VakInDb(weeknummer, dagnummer, 5, klasnumber);
            Uur6.VakInDb(weeknummer, dagnummer, 6, klasnumber);
            Uur7.VakInDb(weeknummer, dagnummer, 7, klasnumber);
            Uur8.VakInDb(weeknummer, dagnummer, 8, klasnumber);
            Uur9.VakInDb(weeknummer, dagnummer, 9, klasnumber);
            Uur10.VakInDb(weeknummer, dagnummer, 10, klasnumber);
            Uur11.VakInDb(weeknummer, dagnummer, 11, klasnumber);
            Uur12.VakInDb(weeknummer, dagnummer, 12, klasnumber);
            Uur13.VakInDb(weeknummer, dagnummer, 13, klasnumber);
            Uur14.VakInDb(weeknummer, dagnummer, 14, klasnumber);
            Uur15.VakInDb(weeknummer, dagnummer, 15, klasnumber);


        }


    }
}
