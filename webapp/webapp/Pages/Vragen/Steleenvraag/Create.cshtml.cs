using DatabaseController;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using webapp.Models;



namespace webapp.Pages.Vragen.Steleenvraag
{
    public class StelEenVraagModel : PageModel
    {
        public int Case { get; set; } = 0;
        public int VraagID { get; set; }
        public int UserID { get; set; }
        public int VakID { get; set; }

        [StringLength(400, MinimumLength = 3)]
        [Required]
        public string VraagText { get; set; }
        public string AndwoordText { get; set; }
        public Boolean IsFAQ { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime EndDate { get; set; }
        public string Locatie { get; set; }
        public int WachtrijID { get; set; }

        public string Vraag { get; set; }
        public List<List<String>> Zoeklijst = new List<List<string>>();
        public string Btntext { get; set; } = "Zoek voordat je vraag gesteld kan worden";
        public string vakT { get; set; }
        public void OnGet()
        {
            //VraagText = "voer hier je vraag in";
        }

        public void OnPost()
        {
            if (Case == 1)
            {
                VraagID = 0;
                UserID = Sessie.GetInstance.getLoginUserID();
                VraagText = Request.Form[nameof(VraagText)];
                Locatie = Request.Form[nameof(Locatie)];
                AndwoordText = "";
                var Vaktemp2 = Request.Form[nameof(WachtrijID)];
                WachtrijID = Convert.ToInt32(Vaktemp2);

                Vraag temp = new Vraag(0, UserID, VakID, VraagText, AndwoordText, false, DateTime.Now, DateTime.MinValue, Locatie, WachtrijID, false);
                int length = temp.returnVraagLength();
                temp.VraagID = length;
                temp.Insert();
                Response.Redirect("/Menu/SMenu");
            }
            if (Case == 0)
            {
                string vraagt = Request.Form[nameof(VraagText)];
               
                VraagText = Request.Form[nameof(VraagText)];
                Locatie = Request.Form[nameof(Locatie)];
                var Vaktemp = Request.Form[nameof(VakID)];
                VakID = Convert.ToInt32(Vaktemp);
                Vak v = new Vak();
                v.SelectOne(VakID);
                vakT = v.Naam;
                Locatie = v.Locaal;


                Zoeklijst = new DatabaseController.DBConnection().Send("SELECT * FROM projectcdb.faqvragen where vak = '"+vakT+"' and  vraag like '%"+VraagText+"%' or antwoord like '%"+VraagText+"%';");
                Case = 1;
                if (Zoeklijst.Count == 0)
                {
                    Btntext = "Er zijn geen vergelijkbare vragen gevonden. klik hier om je vraag te stellen";
                }
                else
                {
                    Btntext = "Er zijn vergelijkbare vragen gevonden. klik hier om alsnog je vraag te stellen";
                }
            }
        }
    }
}
