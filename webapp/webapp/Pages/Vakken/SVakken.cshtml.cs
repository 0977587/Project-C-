using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseController;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp;
using webapp.Models;

namespace webapp.Pages.Vakken
{
    public class SVakkenModel : PageModel
    {

        public string postit { get; set; }
        public void OnPost()
        {
            string postit2 = Request.Form[nameof(postit)];
            int id = Convert.ToInt32(postit2);
            if (id == 0)
            {
                User a = new User();
                a.SelectOne(Sessie.GetInstance.getLoginUserID());
                new Roosterzoeker.RoosterZoeker().Zoek(a.KlasID);
            }
            else
            {



                new DBConnection().Send("DELETE FROM `projectcdb`.`ingeschrevenvakken` WHERE(`vakID` = '" + id + "' AND `UserID` = '" + Sessie.GetInstance.getLoginUserID() + "');");

            }


        }
        public void OnGet()
        {

        }


    }
}
