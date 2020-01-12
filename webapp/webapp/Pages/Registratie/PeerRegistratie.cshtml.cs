using DatabaseController;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using webapp.Models;



namespace webapp.Pages.Registratie
{
    public class PeerRegistratiemodel : PageModel
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public string peercoach { get; set; }
        public string PeercoachW { get; set; }


        public void OnPost()
        {
            PeercoachW = Request.Form[nameof(PeercoachW)];

            //Kijkt als de peercoach wachtwoord goed is
            if (PeercoachW == "pc")
            {
                NewPeerCoach();
            }
        }

        //Er wordt een Peercoach gemaakt
        private void NewPeerCoach()
        {
            Voornaam = Request.Form[nameof(Voornaam)];
            Achternaam = Request.Form[nameof(Achternaam)];
            Email = Request.Form[nameof(Email)];
            Wachtwoord = Request.Form[nameof(Wachtwoord)];
            User u = new User("p", Voornaam, Achternaam, Email, Wachtwoord);
            u.Insert();
            Response.Redirect("../Index");
        }
    }
}