﻿using DatabaseController;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
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
        public string Locatie { get; set; }


        public void OnGet()
        {
            VraagText = "voer hier je vraag in";

        }

        public void OnPost()
        {
            
            VraagID = 0;
            UserID = Sessie.GetInstance.getLoginUserID();
            VraagText = Request.Form[nameof(VraagText)];
            Locatie = Request.Form[nameof(Locatie)];
            var Vaktemp = Request.Form[nameof(VakID)];
            VakID = Convert.ToInt32(Vaktemp);
            AndwoordText = "";
            Vraag temp = new Vraag(0, UserID, VakID, VraagText, AndwoordText,false, DateTime.Now, DateTime.MinValue, Locatie);
            int length = temp.returnVraagLength();
            temp.VraagID = length;
            temp.Insert();
        }

    }
}