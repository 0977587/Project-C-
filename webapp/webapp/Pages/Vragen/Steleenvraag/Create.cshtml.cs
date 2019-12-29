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
            Vak v = new Vak();
            v.SelectOne(Sessie.GetInstance.ZoekVak);
            vakT = v.Naam;
            Locatie = v.Locaal;
            List<String> zoektermlist = new List<string>();
            if(Sessie.GetInstance.Zoekterm1 != "")
            {
                zoektermlist.Add(Sessie.GetInstance.Zoekterm1);
            }
            if (Sessie.GetInstance.Zoekterm2 != "")
            {
                zoektermlist.Add(Sessie.GetInstance.Zoekterm2);
            }
            if (Sessie.GetInstance.Zoekterm3 != "")
            {
                zoektermlist.Add(Sessie.GetInstance.Zoekterm3);
            }
            if (Sessie.GetInstance.Zoekterm4 != "")
            {
                zoektermlist.Add(Sessie.GetInstance.Zoekterm4);
            }
            if (zoektermlist.Count != 0){
                if (Sessie.GetInstance.Zoekterm1 == "")
                {
                    Sessie.GetInstance.Zoekterm1 = zoektermlist[0];
                }
                if (Sessie.GetInstance.Zoekterm2 == "")
                {
                    Sessie.GetInstance.Zoekterm2 = zoektermlist[0];
                }
                if (Sessie.GetInstance.Zoekterm3 == "")
                {
                    Sessie.GetInstance.Zoekterm3 = zoektermlist[0];
                }
                if (Sessie.GetInstance.Zoekterm4 == "")
                {
                    Sessie.GetInstance.Zoekterm4 = zoektermlist[0];
                }
                Zoeklijst = new DatabaseController.DBConnection().Send("(SELECT * FROM projectcdb.faqvragen where vak = '" + vakT + "' and  vraag like '%" + Sessie.GetInstance.Zoekterm1 + "%' or antwoord like '%" + Sessie.GetInstance.Zoekterm1 + "%') union (SELECT * FROM projectcdb.faqvragen where vak = '" + vakT + "' and  vraag like '%" + Sessie.GetInstance.Zoekterm2 + "%' or antwoord like '%" + Sessie.GetInstance.Zoekterm2 + "%') union (SELECT * FROM projectcdb.faqvragen where vak = '" + vakT + "' and  vraag like '%" + Sessie.GetInstance.Zoekterm3 + "%' or antwoord like '%" + Sessie.GetInstance.Zoekterm3 + "%') union (SELECT * FROM projectcdb.faqvragen where vak = '" + vakT + "' and  vraag like '%" + Sessie.GetInstance.Zoekterm4 + "%' or antwoord like '%" + Sessie.GetInstance.Zoekterm4 + "%')");

            }
            else
            {
                Zoeklijst = new List<List<string>>();
            }
          
        }

        public void OnPost()
        {
            VraagID = 0;
                UserID = Sessie.GetInstance.getLoginUserID();
                VraagText = Request.Form[nameof(VraagText)];
                Locatie = Request.Form[nameof(Locatie)];
                AndwoordText = "";
                var Vaktemp2 = Request.Form[nameof(WachtrijID)];
                WachtrijID = Convert.ToInt32(Vaktemp2);

            

        
                string vraagt = Request.Form[nameof(VraagText)];
               
                VraagText = Request.Form[nameof(VraagText)];
                Locatie = Request.Form[nameof(Locatie)];
                var Vaktemp = Request.Form[nameof(VakID)];
                VakID = Convert.ToInt32(Vaktemp);



               
                if (Zoeklijst.Count == 0)
                {
                    Btntext = "Er zijn geen vergelijkbare vragen gevonden. klik hier om je vraag te stellen";
                }
                else
                {
                    Btntext = "Er zijn vergelijkbare vragen gevonden. klik hier om alsnog je vraag te stellen";
                }

            Vraag temp = new Vraag(0, UserID, Sessie.GetInstance.ZoekVak , VraagText, AndwoordText, false, DateTime.Now, DateTime.MinValue, Locatie, WachtrijID, false);
            int length = temp.returnVraagLength();
            temp.VraagID = length;
            temp.Insert();
            Response.Redirect("/Menu/SMenu");

        }
    }
}
