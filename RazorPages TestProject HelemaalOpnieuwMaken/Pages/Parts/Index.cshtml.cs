using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_TestProject_HelemaalOpnieuwMaken.Data;
using RazorPages_TestProject_HelemaalOpnieuwMaken.Models;

namespace RazorPages_TestProject_HelemaalOpnieuwMaken.Pages.Parts
{
    public class IndexModel : PageModel
    {
        private readonly RepairOrderDbContextCollection _context;

        public IndexModel(RepairOrderDbContextCollection context)
        {
            _context = context;
        }

        public IList<Part> Part { get;set; }

        public async Task OnGetAsync()
        {
            Part = await _context.Parts.ToListAsync();
        }
    }
}
