using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp.Models;

namespace webapp.Pages.MakeQueue
{
    public class PWachtrij : PageModel
    {
        public string postit { get; set; }
        public void OnPost()
        {

            string postit2 = Request.Form[nameof(postit)];
            int id = Convert.ToInt32(postit2);
            Vraag vraag = new Vraag();
            vraag.SelectOne(id);
            vraag.isInProgress = true;
            vraag.Update();
           
        }

    }
}