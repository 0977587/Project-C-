using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace webapp.Areas.Identity.Pages.Account
{

    public class wachtwoordpeercoach : PageModel
    {
        
           
        public ActionResult Wachtwoord()
        {
            string wachtwoord;
            wachtwoord = "onlyforpeercoaches";
            if(wachtwoord ==  "onlyforpeercoaches")
            {
                return Redirect("https://localhost:44319/Identity/Account/Login");
            }
            else
            {
                return Redirect("https://localhost:44319/Identity/Account/Login");
            }
        }
      
        
    }
}
