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
                //Id voor wachtrij wordt opgezocht voordat deze wordt gemaakt
                Wachtrij Wachtrij = new Wachtrij();
                Wachtrij.SelectOne(id);

                WachtrijID = id;
                Title = Wachtrij.Name.Replace(";","");
                SetVakkenlijst(Wachtrij);
            }
            else{
                //Id voor de algemene wachtrij wordt gezet, en daarna pas aangemaakt
                Title = "Algemeen";
                isalgemeen = 1;
 
                Wachtrij Wachtrij = new Wachtrij();
                Wachtrij.SelectOne(0);
                SetVakkenlijst(Wachtrij);
            }
        }

        public void OnPost()
        {
            //check of sluiten is ingedrukt
            if (Convert.ToInt32(Request.Form[nameof(sluiten)]) == 1)
            {
                int test = Sessie.GetInstance.getChoice();
                if (test != 0)
                {
                    ExitQueue();
                    return;
                }

            }

            Vraag vraag = new Vraag();
            string temp = Request.Form[nameof(Choice)];
            int inttemp = Convert.ToInt32(temp);
            vraag.SelectOne(inttemp);
            string vaknaam = new DatabaseController.DBConnection().Send("SELECT Naam FROM projectcdb.vak where VakID = " + vraag.VakID + ";")[0][0];
            string isChecked = Request.Form[nameof(IsChecked)];
            string antwoord = Request.Form[nameof(Antwoord)];

            //Kijgt als de vraag behaldeld is, zo ja: maakt wordt hij beandwoord, zo nee: dan wordt hij behandeld.
            if (vraag.isInProgress)
            {
                //Als er geen andwoord is gegeven wordt er alsnog een andrwoord aan gegeven
                if (antwoord == "")
                {
                    antwoord = "geen antwoord";
                }

                //Als FAQ gechecked is dan wordt het een FAQ gemaakt
                if (isChecked != "false")
                {
                    vraag.AndwoordText = antwoord;
                    vraag.InsertFaq(vaknaam);
                    UpdateQuestion(antwoord,vraag);
                }
                else
                {
                    UpdateQuestion(antwoord,vraag);
                }
            }
            else
            {
                vraag.isInProgress = true;
                vraag.Update();
            }
            OnGet();
        }

        //vakken worden gezocht
        private List<string> ZoekVakken()
        {
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
            return temp;
        }

        //vakkenlijst wordt geset
        private void SetVakkenlijst(Wachtrij Wachtrij)
        {
            List<string> temp = ZoekVakken();
            Vragen = Wachtrij.getVragen(0);
            Vragen2 = Wachtrij.getVragen(1);
            Amount = Wachtrij.getVragenAmount();
            Vakkenlijst = temp;
        }

        //De wachtrij wordt verwijderd
        private void ExitQueue()
        {
            new DatabaseController.DBConnection().Send("DELETE FROM `projectcdb`.`wachtrij` WHERE (`WachtrijId` = '" + Sessie.GetInstance.getChoice() + "');");

            Response.Redirect("/Menu/PMenu");
            sluiten = 1;
            Vragen = new List<Vraag>();
            Vragen2 = new List<Vraag>();
        }
        
        //De vraag wordt geupdate
        private void UpdateQuestion(string antwoord, Vraag vraag)
        {
            new DatabaseController.DBConnection().Send("UPDATE `projectcdb`.`vraag` SET `AndwoordText` = '" + antwoord + "', `IsBehandeld` = '1' WHERE (`vraagID` = '" + vraag.VraagID + "');");
        }

    }
}