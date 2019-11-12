using DatabaseController;
using Microsoft.AspNetCore.Mvc.RazorPages;
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

        public void OnGet()
        {
            //VraagText = "voer hier je vraag in";

        }

        public void OnPost()
        {
            VraagID = 0;
            UserID = Sessie.GetInstance.getLoginUserID();
            VraagText = Request.Form[nameof(VraagText)];

            
            
            AndwoordText = "";
            DateAdded = DateTime.UtcNow;
            EndDate = DateTime.MinValue;
            Vraag temp = new Vraag(0, UserID, 1, VraagText, AndwoordText,false, DateAdded, EndDate);
            temp.Insert();
        }
    }
}