using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Pages.Vragen.Steleenvraag
{
    public class Zoek : PageModel
    {

        public string Zoek1 { get; set; }
        public string Zoek2 { get; set; }
        public string Zoek3 { get; set; }
        public string Zoek4 { get; set; }
        public int VakID { get; set; }

        public void OnPost()
        {
            SearchQuestion();
        }

        //Zoek vragen op basis van zoektermen
        private void SearchQuestion()
        {
            Sessie.GetInstance.Zoekterm1 = Request.Form[nameof(Zoek1)];
            Sessie.GetInstance.Zoekterm2 = Request.Form[nameof(Zoek2)];
            Sessie.GetInstance.Zoekterm3 = Request.Form[nameof(Zoek3)];
            Sessie.GetInstance.Zoekterm4 = Request.Form[nameof(Zoek4)];
            Sessie.GetInstance.ZoekVak = Convert.ToInt32(Request.Form[nameof(VakID)]);

            Response.Redirect("/Vragen/Steleenvraag/Create");
        }
    }
}
