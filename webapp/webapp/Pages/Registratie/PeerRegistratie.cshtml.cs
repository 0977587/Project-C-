using DatabaseController;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
        public void OnGet()
        {

        }

        public void OnPost()
        {
            string p = Request.Form[nameof(peercoach)];
            if(Convert.ToInt32(p) != 1)
            {

            }
            else
            {
                Response.Redirect("./PeerRegistratie");
            }
        }
    }
}
