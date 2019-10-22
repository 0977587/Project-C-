using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1;
using DatabaseController;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace webapp.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            List<List<string>> test = new DBConnection().Send("SELECT * FROM projectcdb.vak;");
        }
    }
}
