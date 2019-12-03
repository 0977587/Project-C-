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
            if (loguit != null)
            {
                Sessie.GetInstance.setLoginUserID(-1);
                Response.Redirect("../Index");
            }
            else
            {
                string temp = Request.Form[nameof(Choice)];
                int inttemp = Convert.ToInt32(temp);
                Sessie.GetInstance.setChoice(inttemp);
                string postit2 = Request.Form[nameof(postit)];
                Response.Redirect("../MakeQueue/PoverzichtWachtrij/");
            }

        }
    }
}