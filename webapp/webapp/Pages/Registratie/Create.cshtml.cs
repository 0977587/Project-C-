﻿using DatabaseController;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using webapp.Models;



namespace webapp.Pages.Registratie
{
    public class Registratiemodel : PageModel
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public string Klas { get; set; }
        public string peercoach { get; set; }

        public void OnPost()
        {
            string p = Request.Form[nameof(peercoach)];

            //Er wordt gekeken of de gebruiker een student wilt maken, of een peercoach wilt maken.
            if (Convert.ToInt32(p) != 1)
            {
                MakeUser();
            }
            else
            {
                ToPeerCoach();
            }
        }

        //Er wordt een student aangemaakt
        private void MakeUser()
        {
            Voornaam = Request.Form[nameof(Voornaam)];
            Achternaam = Request.Form[nameof(Achternaam)];
            Email = Request.Form[nameof(Email)];
            Wachtwoord = Request.Form[nameof(Wachtwoord)];
            Klas = Request.Form[nameof(Klas)];
            User u = new User("s", Convert.ToInt32(Klas), Voornaam, Achternaam, Email, Wachtwoord);
            u.Insert();
            Response.Redirect("../Index");
        }

        //De gebruiker wordt naar PeerRegistratie gestuurd
        private void ToPeerCoach()
        {
            Response.Redirect("./PeerRegistratie");
        }
    }
}