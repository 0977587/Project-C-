using DatabaseController;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using webapp.Models;



namespace Test_webapp.Pages
{
    public class PWachtrij : PageModel
    {
        public void OnGet()
        {
            Wachtrij Wachtrij = Wachtrij();
        }
    }
}