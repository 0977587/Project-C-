using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Pages
{
    public class PMenuModel : PageModel
    {
        public static void OnGet()
        {

        }



        public void OnPost()
        {

            Sessie.GetInstance.setLoginUserID(-1);

            Response.Redirect("../Index");
        }
    }
}
