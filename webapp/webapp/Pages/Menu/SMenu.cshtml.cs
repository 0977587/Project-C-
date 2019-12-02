using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseController;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp.Models;

namespace webapp.Pages.Menu
{
    public class SMenuModel : PageModel
    {
        public string postit { get; set; }
        public int LU { get; set; }
        public string announceText { get; set; }
        public static void OnGet()
        {
           
        }
        public void OnPost()
        {
            string loguit = Request.Form[nameof(LU)];
            if(loguit != null)
            {
                Sessie.GetInstance.setLoginUserID(-1);
                Response.Redirect("../Index");
            }
            else
            {
                string postit2 = Request.Form[nameof(postit)];
                int id = Convert.ToInt32(postit2);
                new DBConnection().Send("DELETE FROM `projectcdb`.`vraag` WHERE(`vraagID` = '" + id + "');");
            }

        }
    }
}
