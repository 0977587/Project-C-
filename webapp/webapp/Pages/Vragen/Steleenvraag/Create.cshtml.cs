using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using webapp.Data;
using webapp.Models;

namespace webapp.Pages.Vragen.Steleenvraag
{
    public class CreateModel : PageModel
    {
        private readonly webapp.Data.webappContext _context;

        public CreateModel(webapp.Data.webappContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Vraag Vraag { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Vraag.Add(Vraag);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}