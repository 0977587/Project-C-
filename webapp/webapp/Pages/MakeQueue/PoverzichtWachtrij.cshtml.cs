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
        public int sluiten { get; set; }
        public int isalgemeen { get; set; }
        public string Title { get; set; }
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

        public int WachtrijID;
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
                WachtrijID = id;

                Title = Wachtrij.Name.Replace(";","");
                Vragen = Wachtrij.getVragen(0);
                Vragen2 = Wachtrij.getVragen(1);
                Amount = Wachtrij.getVragenAmount();
                Vakkenlijst = temp;
                Vraag vraag = new Vraag();
            }
            else{
                Title = "Algemeen";
                isalgemeen = 1;
                List <Vak> Vakken = new List<Vak>();

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
            //check of sluiten is ingedrukt
            if (Convert.ToInt32(Request.Form[nameof(sluiten)]) == 1)
            {
                new DatabaseController.DBConnection().Send("DELETE FROM `projectcdb`.`wachtrij` WHERE (`WachtrijId` = '" + Sessie.GetInstance.getChoice() + "');");

                Response.Redirect("/Menu/PMenu");
                sluiten = 1;
                Vragen = new List<Vraag>();
                Vragen2 = new List<Vraag>();
                return;
            }

            Vraag vraag = new Vraag();
            string temp = Request.Form[nameof(Choice)];
            int inttemp = Convert.ToInt32(temp);
            vraag.SelectOne(inttemp);

            string vaknaam = new DatabaseController.DBConnection().Send("SELECT Naam FROM projectcdb.vak where VakID = " + vraag.VakID + ";")[0][0];

            string isChecked = Request.Form[nameof(IsChecked)];
            string antwoord = Request.Form[nameof(Antwoord)];
            if (vraag.isInProgress)
            {
                if (antwoord == "")
                {
                    antwoord = "geen antwoord";
                }
                if (isChecked != "false")
                {
                    vraag.AndwoordText = antwoord;
                    vraag.InsertFaq(vaknaam);
                    new DatabaseController.DBConnection().Send("UPDATE `projectcdb`.`vraag` SET `AndwoordText` = '"+antwoord+"', `IsBehandeld` = '1' WHERE (`vraagID` = '"+vraag.VraagID+"');");
                }
                else
                {
                    new DatabaseController.DBConnection().Send("UPDATE `projectcdb`.`vraag` SET `AndwoordText` = '" + antwoord + "', `IsBehandeld` = '1' WHERE (`vraagID` = '" + vraag.VraagID + "');");
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