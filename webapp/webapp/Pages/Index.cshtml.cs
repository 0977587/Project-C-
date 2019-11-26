using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseController;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using NUnit.Framework;
using webapp.Models;

namespace webapp.Pages
{
    public class IndexModel : PageModel
    {
        public string UName { get; set; }
        public string PWord { get; set; }

        public void OnGet(int? index)
        {

            int id = Sessie.GetInstance.getLoginUserID();





            int x = 5;
            if(id != -1)
            {
                User u = new User();
                u.SelectOne(id);

                if(u.Rol == "p")
                {
                    Response.Redirect("/Menu/PMenu");
                }
                else if(u.Rol == "s")
                {
                    Response.Redirect("/Menu/SMenu");
                }
            }

        }
        public void OnPost()
        {
            string u = Request.Form[nameof(UName)];
            string p = Request.Form[nameof(PWord)];


            List<List<string>> connect = new DBConnection().Send("SELECT * FROM projectcdb.user where voornaam = '" + u + "' AND Wachtwoord = '"+ p +"';");

            if (connect.Any())
            {
                User LoggedInUser = new User();

                foreach (List<string> temp in connect)
                {
                    User user = new User();
                    user.SelectOne(Convert.ToInt32(temp[0]));
                    LoggedInUser = user;
                }

                Sessie.GetInstance.setLoginUserID(LoggedInUser.UserID);

                Response.Redirect("./Index");

            }




            
        }

    }
}