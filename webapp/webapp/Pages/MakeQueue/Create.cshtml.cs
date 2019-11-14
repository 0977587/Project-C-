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
            var datetemp = Request.Form[nameof(DateAdded)];
            var enddatetemp = Request.Form[nameof(EndDate)];
            DateAdded = Convert.ToDateTime(datetemp);
            EndDate = Convert.ToDateTime(enddatetemp);
            Wachtrij temp = new Wachtrij(WachtrijID, DateAdded, EndDate, Name);
            temp.Insert();
        }
    }
}
 