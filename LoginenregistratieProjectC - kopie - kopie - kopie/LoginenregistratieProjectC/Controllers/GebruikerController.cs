using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginenregistratieProjectC.Models;
using System.Net.Mail;
using System.Net;
using System.Web.Security;


namespace LoginenregistratieProjectC.Controllers
{
    public class GebruikerController : Controller
    {
        //GET wordt gebruikt om gegevens op te vragen bij een opgegeven bron.
        //GET is een van de meest voorkomende HTTP-methoden.
        [HttpGet]
        //ActionResult zorgt ervoor dat je een View kan returnen
        public ActionResult Registratie()
        {
            

            return View();

        }
        //Het returned Registratie.cshtml 

        //Wat er na de registratie gebeurt.
        [HttpPost]
        //Het basisdoel van het kenmerk ValidateAntiForgeryToken is het voorkomen 
        //van vervalsingsaanvragen op meerdere sites.
        [ValidateAntiForgeryToken]
        //de eigenschappen isemailgeverifieerd en activatiecode horen er niet bij omdat ze geen input hebben.
        public ActionResult Registratie([Bind(Exclude = "IsEmailGeverifieerd, ActivatieCode")]Gebruiker gebruiker)
        {
            bool Status = false;
            string bericht = "";

            //Model validatie
            if (ModelState.IsValid)
            {
                #region Bestaal email al check
                bool bestaat = BestaatEmail(gebruiker.Emailadres);
                if (bestaat)
                {
                    ModelState.AddModelError("bestaatEmail", "Email bestaat al");
                    return View(gebruiker);
                }
                #endregion

                #region Activatie code genereren
                //Met de GUID method genereer je een unieke waarde dat een entiteit identificeert.
                gebruiker.ActivatieCode = Guid.NewGuid();
                #endregion

                #region Wachtwoord hashen
                gebruiker.Wachtwoord = WachtwoordHashen.Hash(gebruiker.Wachtwoord);
                gebruiker.BevestigWachtwoord = WachtwoordHashen.Hash(gebruiker.BevestigWachtwoord);
                gebruiker.IsEmailGeverifieerd = false;
                #endregion

                #region Opslaan naar database
                using (MijnDatabaseEntities dc = new MijnDatabaseEntities())
                {
                    dc.Gebruikers.Add(gebruiker);
                    dc.SaveChanges();

                    //Email verzenden naar de gebruiker
                    ZendVerificatieEmailLink(gebruiker.Emailadres, gebruiker.ActivatieCode.ToString());
                    bericht = "Registratie succesvol. Accountactivatielink is verzonden naar uw Emailadres: "
                        + gebruiker.Emailadres;

                    Status = true;



                }
                #endregion

            }
            else
            {
                bericht = "Ongeldig verzoek";
            }


            ViewBag.Message = bericht;
            ViewBag.Status = Status;
            return View(gebruiker);
        }

        //Verifieer Account
        [HttpGet]
        //parameter id is voor de activatiecode
        public ActionResult VerifieerAccount(string id)
        {
            bool Status = false;
            using (MijnDatabaseEntities dc = new MijnDatabaseEntities())
            {
                dc.Configuration.ValidateOnSaveEnabled = false; //Dit voorkomt dat bevestigd wachtwoord niet overeen 
                                                                //komt met wachtwoord bij het opslaan van wijzigingen.
                var veld = dc.Gebruikers.Where(a => a.ActivatieCode == new Guid(id)).FirstOrDefault();
                if (veld != null)
                {
                    veld.IsEmailGeverifieerd = true;
                    dc.SaveChanges();
                    Status = true;
                }
                else
                {
                    ViewBag.Message = "Ongeldig verzoek";
                }
            }
            ViewBag.Status = Status;
            return View();
        }

        //Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        //Login bericht
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(GebruikerLogin login, string ReturnUrl = "")
        {
            string bericht = "";
            using (MijnDatabaseEntities dc = new MijnDatabaseEntities())
            {
                Gebruiker veld = dc.Gebruikers.Where(a => a.Emailadres == login.EmailAdres).FirstOrDefault();
                if (veld != null)
                {
                    if (string.Compare(WachtwoordHashen.Hash(login.Wachtwoord), veld.Wachtwoord) == 0)
                    {
                        //ALs je bij het inloggen Onthoud mij aanzet, Onthoud hij de gegevens voor 1 jaar
                        //Anders voor 20 minuten.
                        int pauze = login.OnthoudMij ? 525600 : 20; //525600 minuten == 1 jaar                                                
                        //De klasse FormsAuthentication biedt een coderingsmethode
                        //om een ​​string value te maken die kan worden
                        //opgeslagen in een cookie of in de URL van een FormsAuthenticationTicket.
                        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(login.EmailAdres, login.OnthoudMij, pauze);
                        string encrypted = FormsAuthentication.Encrypt(ticket);
                        HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, encrypted);
                        cookie.Expires = DateTime.Now.AddMinutes(pauze);
                        cookie.HttpOnly = true;
                        Response.Cookies.Add(cookie);
                       

                        if (Url.IsLocalUrl(ReturnUrl))
                        {
                            return Redirect(ReturnUrl);
                        }
                        else
                        {
                            //return Redirect("https://webapp/Pages/Index");
                            //return Response("https://localhost:44319");
                            //return RedirectToAction("Index", "MakeQueque","webapp");
                            return RedirectToAction("Index", "Home");
                        //localhost: 44319
                        }

                    }
                    else
                    {
                        bericht = "Ongeldige inloggegevens";
                    }
                }
                else
                {
                    bericht = "Ongeldige inloggegevens";
                }
            }
            ViewBag.Message = bericht;
            return View();
        }


        //Logout
        [Authorize]
        [HttpPost]
        public ActionResult Loguit()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Gebruiker");
        }

        [NonAction]
        public bool BestaatEmail(string emailAdres)
        {
            using (MijnDatabaseEntities dc = new MijnDatabaseEntities())
            {
                Gebruiker veld = dc.Gebruikers.Where(a => a.Emailadres == emailAdres).FirstOrDefault();
                if (veld == null)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

        }

        [NonAction]
        public void ZendVerificatieEmailLink(string emailAdres, string activatieCode, string emailFor = "VerifieerAccount")
        {
            //scheme = https
            string verifieerUrl = "/Gebruiker/"+emailFor+"/" + activatieCode;
            string link = Request.Url.AbsoluteUri.Replace(Request.Url.PathAndQuery, verifieerUrl);

            MailAddress fromEmail = new MailAddress("marnicktest@gmail.com", "Peercoach development team");
            MailAddress toEmail = new MailAddress(emailAdres);
            string fromEmailPassword = "%TGB6yhn^YHN5tgb";

            string Onderwerp = "";
            string body = "";

            if(emailFor == "VerifieerAccount")
            {
                Onderwerp = "Uw account is succesvol aangemaakt!";

                body = "</br><br/>We zijn blij om u te vertellen dat uw account succesvol is aangemaakt."
                    + " Klik op de onderstaande link om uw account te verifieren." + "<br/><br/><a href='" + link + "'>" + link +
                    "</a> ";

            }
            else if(emailFor == "ResetWachtwoord")
            {
                Onderwerp = "Reset wachtwoord";
                body = "Hallo, <br/><br/>We hebben een verzoek gekregen om uw wachtwoord te resetten. Klik op de onderstaande link" + 
                    " om uw wachtwoord te resetten." + "<br/><br/><a href="+link+">Reset wachtwoord link<a/>";
            }



            SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromEmail.Address, fromEmailPassword)
            };

            using (var bericht = new MailMessage(fromEmail, toEmail)
            {
                Subject = Onderwerp,
                Body = body,
                IsBodyHtml = true
            })
                smtp.Send(bericht);

        }

        //Wachtwoord vergeten
        public ActionResult VergeetWachtwoord()
        {
            return View();
        }

        [HttpPost]
        public ActionResult VergeetWachtwoord(string Emailadres)
        {
            //Verifieer emailadres
            string bericht = "";
            //bool status = false;

            using(MijnDatabaseEntities dc = new MijnDatabaseEntities())
            {
                //Er wordt gekeken of er een account gevonden kan worden met een email die opgeslagen staat in de database
                Gebruiker account = dc.Gebruikers.Where(a => a.Emailadres == Emailadres).FirstOrDefault();
                //Als het veld niet leeg is van het emailadres van het account
                if(account != null)
                {
                    //Email verzenden voor reset wachtwoord.
                    //De link bevat een uniek identificatie nummer.(Unique Identification Number)
                    //Dit nummer slaan we op in de Table.
                    string resetCode = Guid.NewGuid().ToString(); //Hiermee genereer je een resetcode
                    ZendVerificatieEmailLink(account.Emailadres, resetCode, "ResetWachtwoord");
                    account.ResetWachtwoordCode = resetCode;

                    dc.Configuration.ValidateOnSaveEnabled = false;
                    dc.SaveChanges(); //database updaten
                    bericht = "Reset wachtwoordlink is verzonden naar uw emailadres.";

                }
                else
                {
                    bericht = "Account niet gevonden";
                }
            }
            ViewBag.Message = bericht;
            return View();
        }

        public ActionResult ResetWachtwoord(string id)
        {
            using (MijnDatabaseEntities dc = new MijnDatabaseEntities())
            {
                Gebruiker gebruiker = dc.Gebruikers.Where(a => a.ResetWachtwoordCode == id).FirstOrDefault();
                if(gebruiker != null)
                {
                    ResetWachtwoordModel model = new ResetWachtwoordModel();
                    model.ResetCode = id;
                    return View(model);
                }
                else
                {
                    return HttpNotFound();
                }
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ResetWachtwoord(ResetWachtwoordModel model)
        {
            string bericht = "";
            if(ModelState.IsValid)
            {
                using(MijnDatabaseEntities dc = new MijnDatabaseEntities())
                {
                    Gebruiker gebruiker = dc.Gebruikers.Where(a => a.ResetWachtwoordCode == model.ResetCode).FirstOrDefault();
                    if(gebruiker != null)
                    {
                        gebruiker.Wachtwoord = WachtwoordHashen.Hash(model.NieuwWachtwoord);
                        gebruiker.ResetWachtwoordCode = "";

                        dc.Configuration.ValidateOnSaveEnabled = false;
                        dc.SaveChanges();
                        bericht = "Nieuw wachtwoord succesvol geüpdate";
                    }
                }
            }
            else
            {
                bericht = "Iets ongeldigs";
            }

            ViewBag.Message = bericht;
            return View(model);
        }

            
    }


}