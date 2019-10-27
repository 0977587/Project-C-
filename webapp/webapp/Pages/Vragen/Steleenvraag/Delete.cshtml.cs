using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webapp.Data;
using webapp.Models;

namespace webapp.Pages.Vragen.Steleenvraag
{
    public class DeleteModel : PageModel
    {
        private readonly webapp.Data.webappContext _context;

        public DeleteModel(webapp.Data.webappContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Vraag = await _context.Vraag.FindAsync(id);

            if (Vraag != null)
            {
                _context.Vraag.Remove(Vraag);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
