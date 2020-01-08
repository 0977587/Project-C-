using DatabaseController;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using webapp.Models;



namespace webapp.Pages.Account
{
    public class AccountModel : PageModel
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public string Klas { get; set; }
        public string nieuw { get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            //gegevens worden gepakt
            Voornaam = Request.Form[nameof(Voornaam)];
            Achternaam = Request.Form[nameof(Achternaam)];
            Email = Request.Form[nameof(Email)];
            Wachtwoord = Request.Form[nameof(Wachtwoord)];
            nieuw = Request.Form[nameof(nieuw)];

            ChangeInfo();
        }

        //De informatie van de user wordt veranderd
        public void ChangeInfo()
        {
            string n = nieuw;
            User temp = new User();
            temp.SelectOne(Sessie.GetInstance.getLoginUserID());
            if (Voornaam == "1")
            {
                temp.Voornaam = n;
            }
            else if (Achternaam == "1")
            {
                temp.Achternaam = n;
            }
            else if (Email == "1")
            {
                temp.Email = n;
            }
            else if (Wachtwoord == "1")
            {
                temp.Wachtwoord = n;
            }
            temp.Update();
            Response.Redirect("./Create");
        }
    }
}
