using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapp;

namespace webapp
{
    public class Sessie
    {
        public static Sessie instance = new Sessie();


        public string Zoekterm1;
        public string Zoekterm2;
        public string Zoekterm3;
        public string Zoekterm4;
        public int ZoekVak;
        int LoginUserID = -1;
        int Choice = -1;
        public DatabaseController.DBConnection dbc = new DatabaseController.DBConnection();
        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Sessie()
        {
        }

        public Sessie()
        {
            


        }
        public int getLoginUserID()
        {
            return LoginUserID;

        }
        public void setLoginUserID(int a)
        {
            LoginUserID = a;

        }
        public int getChoice()
        {
            return Choice;

        }
        public void setChoice(int a)
        {
            Choice = a;

        }


        public static Sessie GetInstance
        {
            get
            {
                return instance;
            }
        }
    }
}
