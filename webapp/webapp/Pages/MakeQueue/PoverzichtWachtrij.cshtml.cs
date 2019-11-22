using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using webapp.Models;

namespace webapp.Pages.MakeQueue
{
    public class PWachtrij : PageModel
    {
        public int Choice { get; set; }
        public Wachtrij Wachtrij { get; set; }
        public List<Vraag> Vragen { get; set; }
        public List<Vraag> Vragen2 { get; set; }
        public int Amount { get; set; }
        public bool IsChecked { get; set; }
        public string Antwoord { get; set; }


        public void OnGet()
        {
            Wachtrij Wachtrij = new Wachtrij();
            Wachtrij.SelectOne(0);
            Vragen = Wachtrij.getVragen(0);
            Vragen2 = Wachtrij.getVragen(1);
            Amount = Wachtrij.getVragenAmount();
        }
        public void OnPost()
        {
            Vraag vraag = new Vraag();
            int temp = int.Parse(Request.Form[nameof(Choice)]);
            vraag.SelectOne(temp);
            vraag.isInProgress = true;
            vraag.Update();
            Wachtrij Wachtrij = new Wachtrij();
            Wachtrij.SelectOne(0);
            Vragen = Wachtrij.getVragen(0);
            Vragen2 = Wachtrij.getVragen(1);
            Amount = Wachtrij.getVragenAmount();
            //TODO:: Peercoach nummer aan toevoegen 
        }

        public void OnChange()
        {

            Vraag vraag = new Vraag();
            int temp = int.Parse(Request.Form[nameof(Choice)]);
            vraag.SelectOne(temp);
            vraag.isInProgress = true;
            vraag.Update();
           
        }

    }
}