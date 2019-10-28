﻿using DatabaseController;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.ComponentModel.DataAnnotations;
using webapp.Models;


namespace webapp.Pages.Vragen.Steleenvraag
{
    public class IndexModel : PageModel
    {
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

        public void OnGet()
        {
            VraagText = "voer hier je vraag in";
        }

        public void OnPost()
        {
            VraagID = 1;
            UserID = 1;
            VakID = 1; //todo add this Request.Form[VakID];
            VraagText = Request.Form[nameof(VraagText)];

            AndwoordText = "";
            DateAdded = DateTime.UtcNow;
            EndDate = DateTime.MinValue;
            Vraag temp = new Vraag(VraagID, UserID, VakID, VraagText, AndwoordText,false, DateAdded, EndDate);
            //VraagID = int(New DBConnection().Send(temp)); //todo fix jurriaans query
            
        }
    }
}