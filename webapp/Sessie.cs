﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webapp;

namespace webapp
{
    public class Sessie
    {
        public static Sessie instance = new Sessie();


        int LoginUserID = -1;
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


        public static Sessie GetInstance
        {
            get
            {
                return instance;
            }
        }
    }
}