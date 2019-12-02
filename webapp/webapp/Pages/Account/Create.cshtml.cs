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
            Voornaam = Request.Form[nameof(Voornaam)];
            Achternaam = Request.Form[nameof(Achternaam)];
            Email = Request.Form[nameof(Email)];
            Klas = Request.Form[nameof(Klas)];
            nieuw = Request.Form[nameof(nieuw)];


            if(Voornaam == "1")
            {
                string n = nieuw;
                User temp = new User();
                temp.SelectOne(Sessie.GetInstance.getLoginUserID());
                temp.Voornaam = n;
                temp.Update();
                Response.Redirect("./Create");
            }
            else if(Achternaam == "1")
            {
                string n = nieuw;
                User temp = new User();
                temp.SelectOne(Sessie.GetInstance.getLoginUserID());
                temp.Achternaam = n;
                temp.Update();
                Response.Redirect("./Create");
            }
            else if (Email == "1")
            {
                string n = nieuw;
                User temp = new User();
                temp.SelectOne(Sessie.GetInstance.getLoginUserID());
                temp.Email = n;
                temp.Update();
                Response.Redirect("./Create");
            }
            else if (Klas == "1")
            {
                string n = nieuw;
                User temp = new User();
                temp.SelectOne(Sessie.GetInstance.getLoginUserID());
                temp.Wachtwoord = n;
                temp.Update();
                Response.Redirect("./Create");
            }

        }
    }
}
