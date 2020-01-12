using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Pages.FAQ
{
    public class SoverzichtFAQModel : PageModel
    {
        public string Vraag { get; set; }
        public List<List<String>> Zoeklijst = new List<List<string>>();

        public void OnPost()
        {
            string vraagText = Request.Form[nameof(Vraag)];
            ZoekFAQ(vraagText);
        }

        //Er wordt gezocht met de de text die ingevoerd is
        public void ZoekFAQ(string vraagt)
        {
            Zoeklijst = new DatabaseController.DBConnection().Send("SELECT * FROM projectcdb.faqvragen where vraag like '%" + vraagt + "%' or vak like '%" + vraagt + "%' or antwoord like '%" + vraagt + "%';");
        }
    }
}