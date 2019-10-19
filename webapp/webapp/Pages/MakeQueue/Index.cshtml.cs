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
    public class IndexModel : PageModel
    {
        private readonly webapp.Data.webappContext _context;

        public IndexModel(webapp.Data.webappContext context)
        {
            _context = context;
        }

        public IList<Queue> Queue { get;set; }

        public async Task OnGetAsync()
        {
            Queue = await _context.Queue.ToListAsync();
        }
    }
}
