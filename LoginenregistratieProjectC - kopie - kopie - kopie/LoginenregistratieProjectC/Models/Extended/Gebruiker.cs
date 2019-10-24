using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LoginenregistratieProjectC.Models
{
    [MetadataType(typeof(GebruikerMetaData))]
    public partial class Gebruiker
    {
        public string BevestigWachtwoord { get; set; }
    }
    //Deze klasse verwijst naar de andere Gerbuiker klasse in Models
    //In deze klasse staan de eigenschappen/Metadata en de validatie ervan
    public class GebruikerMetaData
    {
        [Display(Name="Voornaam")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Voornaam vereist")]
        public string Voornaam { get; set; }

        [Display(Name="Achernaam")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Achternaam vereist")]
        public string Achternaam { get; set; }

        [Display(Name ="Klas")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Klas vereist")]
        public string Klas { get; set; }

        [Display(Name = "Peercoach of Student")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Rol vereist")]
        public string Rol { get; set; }

        //Display is wat je op het scherm ziet
        [Display(Name = "Emailadres")]
        //Required is voor dat het vak niet leeg mag zijn. En welke error er anders komt
        [Required(AllowEmptyStrings = false, ErrorMessage = "Emailadres vereist")]
        //Datatype is om de email te verifieren
        [DataType(DataType.EmailAddress)]
        public string Emailadres { get; set; }

        [Display(Name ="Wachtwoord")]
        [Required(AllowEmptyStrings =false,ErrorMessage ="Wachtwoord vereist")]
        [DataType(DataType.Password)]
        [MinLength(6,ErrorMessage ="Minimaal 6 tekens vereist")]
        public string Wachtwoord { get; set; }

        [Display(Name ="Bevestig wachtwoord")]
        [DataType(DataType.Password)]
        [Compare("Wachtwoord",ErrorMessage ="Bevestigd wachtwoord en wachtwoord komen niet overeen")]
        public string BevestigWachtwoord { get; set; }
    }
}