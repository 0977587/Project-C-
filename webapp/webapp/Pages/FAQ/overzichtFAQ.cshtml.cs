using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Pages.FAQ
{
    public class overzichtFAQModel : PageModel
    {
        public string Vraag { get; set; }
        public List<List<String>> Zoeklijst = new List<List<string>>();

        public void OnGet()
        {

        }
        public void OnPost()
        {
            string vraagt = Request.Form[nameof(Vraag)];
            Zoeklijst = new DatabaseController.DBConnection().Send("SELECT * FROM projectcdb.faqvragen where vraag like '%" + vraagt + "%' or vak like '%" + vraagt + "%' or antwoord like '%" + vraagt + "%';");


        }
    }
}