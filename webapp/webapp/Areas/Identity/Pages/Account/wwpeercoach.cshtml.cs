using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Areas.Identity.Pages.Account
{
    public class wwpeercoachModel : PageModel
    {

        [BindProperty]
        public string wachtwoord { get; set; }

        public string bericht;


        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if(wachtwoord == "onlyforpeercoaches")
            {
                //HttpContext.Session.SetString("wachtwoord", wachtwoord);
                return Redirect("https://localhost:44319/Menu/PMenu?");
            }
            else
            {
                bericht = "Onjuist";
                return Page();
            }
        }
    }
}
