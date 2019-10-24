using System;
using System.Collections.Generic;
using System.Text;

namespace Uurvak1
{
    public class Uurvak
    {
        int uur;
        public string maandag;
        public string dinsdag;
        public string woensdag;
        public string donderdag;
        public string vrijdag;
        public Uurvak(int uur)
        {
            this.uur = uur;

        }

        internal int fillNextEmpty(string a)
        {
            if( maandag == null){
                maandag = a;
                return 1;
            }
            if (dinsdag == null)
            {
                dinsdag = a;
                return 2;
            }
            if (woensdag == null)
            {
                woensdag = a;
                return 3;
            }
            if (donderdag == null)
            {
                donderdag = a;
                return 4;
            }
            if (vrijdag == null)
            {
                vrijdag = a;
                return 5;
            }
            return 0;
        }

        internal void fillday(int a,string s)
        {
            if(a == 1)
            {
                maandag = s;
            }
            if (a == 2)
            {
                dinsdag = s;
            }
            if (a == 3)
            {
                woensdag = s;
            }
            if (a == 4)
            {
                donderdag = s;
            }
            if (a == 5)
            {
                vrijdag = s;
            }

        }
    }
}
