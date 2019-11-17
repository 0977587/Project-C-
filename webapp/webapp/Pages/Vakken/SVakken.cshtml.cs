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
        public void OnPost()
        {

            User a = new User();
            a.SelectOne(Sessie.GetInstance.getLoginUserID());
            new Roosterzoeker.RoosterZoeker().Zoek(a.KlasID);


        }
        public void OnGet()
        {

        }
        public ActionResult BehandelVak(int choice)
        {
            new DBConnection().Send("DELETE FROM `projectcdb`.`ingeschrevenvakken` WHERE(`vakID` = '"+ choice + "' AND `UserID` = '"+ Sessie.GetInstance.getLoginUserID() + "');");
                
            return Redirect(Request.Path);
        }
    }
}

