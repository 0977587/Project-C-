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

namespace webapp.Pages.MakeQueue
{
    public class EditModel : PageModel
    {
        private readonly webapp.Data.webappContext _context;

        public EditModel(webapp.Data.webappContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Queue Queue { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Queue = await _context.Queue.FirstOrDefaultAsync(m => m.ID == id);

            if (Queue == null)
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

            _context.Attach(Queue).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!QueueExists(Queue.ID))
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

        private bool QueueExists(string id)
        {
            return _context.Queue.Any(e => e.ID == id);
        }
    }
}
