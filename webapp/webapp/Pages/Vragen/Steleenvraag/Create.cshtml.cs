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
        public Question Question { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }


            //Question is eigenlijk al gemaakt en wil ik naar de locale databse versturen


            _context.Question.Add(Question);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}