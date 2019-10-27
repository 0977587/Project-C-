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

namespace webapp.Pages.Vragen.Steleenvraag
{
    public class EditModel : PageModel
    {
        private readonly webapp.Data.webappContext _context;

        public EditModel(webapp.Data.webappContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Vraag Vraag { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vraag = await _context.Vraag.FirstOrDefaultAsync(m => m.VraagID == id);

            if (Vraag == null)
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

            _context.Attach(Vraag).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VraagExists(Vraag.VraagID))
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

        private bool VraagExists(int id)
        {
            return _context.Vraag.Any(e => e.VraagID == id);
        }
    }
}
