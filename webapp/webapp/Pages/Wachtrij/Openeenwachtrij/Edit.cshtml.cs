using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using webapp.Data;
using webapp.Models;

namespace webapp.Pages.Wachtrij.Openeenwachtrij
{
    public class EditModel : PageModel
    {
        private readonly webapp.Data.webappContext _context;

        public EditModel(webapp.Data.webappContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Wachtrij Wachtrij { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Wachtrij = await _context.Wachtrij.FirstOrDefaultAsync(m => m.ID == id);

            if (Wachtrij == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Wachtrij).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WachtrijExists(Wachtrij.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool WachtrijExists(string id)
        {
            return _context.Wachtrij.Any(e => e.ID == id);
        }
    }
}
