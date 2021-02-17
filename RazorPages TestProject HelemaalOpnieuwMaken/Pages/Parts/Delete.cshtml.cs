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
    public class DeleteModel : PageModel
    {
        private readonly RazorPages_TestProject_HelemaalOpnieuwMaken.Data.RepairOrderDbContextCollection _context;

        public DeleteModel(RazorPages_TestProject_HelemaalOpnieuwMaken.Data.RepairOrderDbContextCollection context)
        {
            _context = context;
        }

        [BindProperty]
        public Part Part { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Part = await _context.Parts.FirstOrDefaultAsync(m => m.PartID == id);

            if (Part == null)
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

            Part = await _context.Parts.FindAsync(id);

            if (Part != null)
            {
                _context.Parts.Remove(Part);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
