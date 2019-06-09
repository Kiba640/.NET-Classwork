using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using My_Scripture_Journal.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace My_Scripture_Journal.Pages
{
    public class IndexModel : PageModel
    {
        private readonly My_Scripture_Journal.Models.My_Scripture_JournalContext _context;

        public IndexModel(My_Scripture_Journal.Models.My_Scripture_JournalContext context)
        {
            _context = context;
        }

        public IList<Scripture> Scripture { get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        // Requires using Microsoft.AspNetCore.Mvc.Rendering;
        public SelectList StandardWorks { get; set; }
        [BindProperty(SupportsGet = true)]
        public string StandardWorkBook { get; set; }

        public async Task OnGetAsync()
        {
            var scriptures = from m in _context.Scripture
                         select m;
            if (!string.IsNullOrEmpty(SearchString))
            {
                scriptures = scriptures.Where(s => s.StandardWork.Contains(SearchString));
            }

            Scripture = await scriptures.ToListAsync();
        }
    }
}
