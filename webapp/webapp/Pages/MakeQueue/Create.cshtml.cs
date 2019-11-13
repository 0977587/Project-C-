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

        public void OnGet()
        {
        }

        public void OnPost()
        {
        }
    }
}
 