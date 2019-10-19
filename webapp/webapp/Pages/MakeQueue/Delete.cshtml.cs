using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using webapp.Data;
using webapp.Models;

namespace webapp.Pages.MakeQueue
{
    public class DeleteModel : PageModel
    {
        private readonly webapp.Data.webappContext _context;

        public DeleteModel(webapp.Data.webappContext context)
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Queue = await _context.Queue.FindAsync(id);

            if (Queue != null)
            {
                _context.Queue.Remove(Queue);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
