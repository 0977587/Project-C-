using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp.Models;

namespace Test_webapp.Pages
{
    public class PWachtrij : PageModel
    {
        public void OnGet()
        {
            
        }
        public ActionResult BehandelVraag(int choice)
        {
            Vraag vraag = new Vraag();
            vraag.SelectOne(choice);
            vraag.isInProgress = true;
            vraag.Update();
            return Redirect(Request.Path);
        }
    }
}