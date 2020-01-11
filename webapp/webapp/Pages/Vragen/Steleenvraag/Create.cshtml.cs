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

        public List<String> zoektermlist = new List<string>();

        public void OnGet()
        {
            Vak v = new Vak();
            v.SelectOne(Sessie.GetInstance.ZoekVak);
            vakT = v.Naam;
            Locatie = v.Locaal;

            FilledCheck();

            //kijkt welke zoektermen zijn ingevuld, en als er niets is ingevuld zorgt hij dat er "" wordt ingevuld IPV NULL
            if (zoektermlist.Count != 0){
                FillSearchList();
            }
            else
            {
                Zoeklijst = new List<List<string>>();
            }
          
        }

        public void OnPost()
        {
            NewQuestion();
        }
        

        //Maakt een nieuwe vraag in met de ingevoerde gegevens
        private void NewQuestion()
        {
            VraagID = 0;
            UserID = Sessie.GetInstance.getLoginUserID();
            VraagText = Request.Form[nameof(VraagText)];
            Locatie = Request.Form[nameof(Locatie)];
            AndwoordText = "";
            var Vaktemp2 = Request.Form[nameof(WachtrijID)];
            WachtrijID = Convert.ToInt32(Vaktemp2);
            VraagText = Request.Form[nameof(VraagText)];
            Locatie = Request.Form[nameof(Locatie)];
            var Vaktemp = Request.Form[nameof(VakID)];
            VakID = Convert.ToInt32(Vaktemp);

            Vraag temp = new Vraag(0, UserID, Sessie.GetInstance.ZoekVak, VraagText, AndwoordText, false, DateTime.Now, DateTime.MinValue, Locatie, WachtrijID, false);
            int length = temp.returnVraagLength();
            temp.VraagID = length;
            temp.Insert();
            Response.Redirect("/Menu/SMenu");
        }

        //kijkt of de zoektermen ingevuld zijn
        private void FilledCheck()
        {
            if (Sessie.GetInstance.Zoekterm1 != "")
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
        }

        //Vult de zoeklijst
        private void FillSearchList()
        {
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
    }
}
