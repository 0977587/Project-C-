using DatabaseController;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Controller;
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

        public void OnPost()
        {
            Name = Request.Form[nameof(Name)];
            var datetemp = Request.Form[nameof(DateAdded)];
            var enddatetemp = Request.Form[nameof(EndDate)];
            DateAdded = Convert.ToDateTime(datetemp);
            EndDate = Convert.ToDateTime(enddatetemp);

            CreateQueue();
        }

        //Er wordt een wachtrij gemaakt
        private void CreateQueue()
        {
            Wachtrij temp = new Wachtrij(0, DateAdded, EndDate, Name);
            int length = temp.returnWachtrijLength();
            temp.WachtrijID = length;
            temp.Insert();
            Response.Redirect("/Menu/PMenu");
        }
    }
}
 