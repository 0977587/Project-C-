using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseController;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Pages
{
    public class PMenuModel : PageModel
    {
        public int Choice { get; set; }
        public string postit { get; set; }
        public int LU { get; set; }
        public static void OnGet()
        {

        }



        public void OnPost()
        {
            string loguit = Request.Form[nameof(LU)];

            //Er wordt gekeken of de gebruiker wilt uitloggen of naar een wachtrij wilt gaan
            if (loguit != null)
            {
                Logout();
            }
            else
            {
                GoToQueue();
            }
        }

        //De user wordt uitgelogt
        private void Logout()
        {
            Sessie.GetInstance.setLoginUserID(-1);
            Response.Redirect("../Index");
        }

        //De gebruiker gaat naar de wachtrij, en het ID wordt opgeslagen in de Sessie
        private void GoToQueue()
        {
            string temp = Request.Form[nameof(Choice)];
            int inttemp = Convert.ToInt32(temp);
            Sessie.GetInstance.setChoice(inttemp);
            Response.Redirect("../MakeQueue/PoverzichtWachtrij/");
        }
    }
}