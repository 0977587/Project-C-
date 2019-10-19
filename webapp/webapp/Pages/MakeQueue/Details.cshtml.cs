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
    public class DetailsModel : PageModel
    {
        private readonly webapp.Data.webappContext _context;

        public DetailsModel(webapp.Data.webappContext context)
        {
            _context = context;
        }

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
    }
}
