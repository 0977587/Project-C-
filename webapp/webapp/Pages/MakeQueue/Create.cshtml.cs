using DatabaseController;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using webapp.Models;


namespace webapp.Pages.MakeQueue
{
    public class Queue : PageModel
    {
        public int WachtrijID { get; set; }
        public List<string> Peercoaches { get; set; }
        public List<Vraag> Vragen { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime EndDate { get; set; }
        public String Name {get;set;}



        public void OnGet()
        {
        }

        public void OnPost()
        {
            Name = Request.Form[nameof(Name)];
            List<string> Peercoaches = new List<string>();
            List<Vraag> Vragen = new List<Vraag>();
            WachtrijID = 0;
            DateAdded = DateTime.UtcNow;
            EndDate = DateTime.MinValue;
            Wachtrij temp = new Wachtrij(WachtrijID, DateTime.Now, DateTime.Now, Name);
            temp.Insert();
        }
    }
}
 