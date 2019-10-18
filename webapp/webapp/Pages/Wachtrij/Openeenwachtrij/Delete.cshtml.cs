using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webapp.Data;
using webapp.Models;

namespace webapp.Pages.Wachtrij.Openeenwachtrij
{
    public class DeleteModel : PageModel
    {
        private readonly webapp.Data.webappContext _context;

        public DeleteModel(webapp.Data.webappContext context)
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Wachtrij = await _context.Wachtrij.FindAsync(id);

            if (Wachtrij != null)
            {
                _context.Wachtrij.Remove(Wachtrij);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
