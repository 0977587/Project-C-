using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using DatabaseController;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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
        public string IsChecked { get; set; }
        [Required]
        public string Antwoord { get; set; }

        public List<Vak> Vakken {get;set;}
        public string Vak { get; set; }
        public List<string> Vakkenlijst { get; set; }


        
        public void OnGet()
        {
            int id = Sessie.GetInstance.getChoice();
            if(id != -1)
            {
                List<Vak> Vakken = new List<Vak>();

                DBConnection dbc = new DBConnection();
                List<List<string>> returnstatement = dbc.Send("SELECT * FROM projectcdb.vak;");

                List<string> temp = new List<string>();
                if (returnstatement != null)
                {
                    foreach (var i in returnstatement)
                    {
                        Vak a = new Vak();
                        var tempstring = i[3];
                        if (!temp.Contains(tempstring))
                        {
                            temp.Add(tempstring);
                        }

                    }
                }

                Wachtrij Wachtrij = new Wachtrij();
                Wachtrij.SelectOne(id);
                Vragen = Wachtrij.getVragen(0);
                Vragen2 = Wachtrij.getVragen(1);
                Amount = Wachtrij.getVragenAmount();
                Vakkenlijst = temp;
                Vraag vraag = new Vraag();
            }
            else{
                List<Vak> Vakken = new List<Vak>();

                DBConnection dbc = new DBConnection();
                List<List<string>> returnstatement = dbc.Send("SELECT * FROM projectcdb.vak;");

                List<string> temp = new List<string>();
                if (returnstatement != null)
                {
                    foreach (var i in returnstatement)
                    {
                        Vak a = new Vak();
                        var tempstring = i[3];
                        if (!temp.Contains(tempstring))
                        {
                            temp.Add(tempstring);
                        }

                    }
                }

                Wachtrij Wachtrij = new Wachtrij();
                Wachtrij.SelectOne(0);
                Vragen = Wachtrij.getVragen(0);
                Vragen2 = Wachtrij.getVragen(1);
                Amount = Wachtrij.getVragenAmount();
                Vakkenlijst = temp;
                Vraag vraag = new Vraag();
            }
           
        }
        public void OnPost()
        {
            Vraag vraag = new Vraag();
            string temp = Request.Form[nameof(Choice)];
            int inttemp = Convert.ToInt32(temp);
            vraag.SelectOne(inttemp);

            string isChecked = Request.Form[nameof(IsChecked)];
            string selected = Request.Form[nameof(Vak)];
            string antwoord = Request.Form[nameof(Antwoord)];
            if (vraag.isInProgress)
            {
                if (isChecked != "false")
                {
                    vraag.AndwoordText = antwoord;
                    vraag.InsertFaq(selected);
                    vraag.Delete();
                }
                else
                {
                    vraag.Delete();
                }
            }
            else
            {
                vraag.isInProgress = true;
                vraag.Update();
            }
            OnGet();
            //TODO:: Peercoach nummer aan toevoegen 
        }
    }
}