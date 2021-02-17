using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPages_TestProject_HelemaalOpnieuwMaken.Data;
using RazorPages_TestProject_HelemaalOpnieuwMaken.Models;

namespace RazorPages_TestProject_HelemaalOpnieuwMaken.Pages.RepairOrders
{
    public class IndexModel : PageModel
    {
        private readonly RazorPages_TestProject_HelemaalOpnieuwMaken.Data.RepairOrderDbContextCollection _context;

        public IndexModel(RazorPages_TestProject_HelemaalOpnieuwMaken.Data.RepairOrderDbContextCollection context)
        {
            _context = context;
        }

        public IList<RepairOrder> RepairOrder { get;set; }

        public async Task OnGetAsync()
        {
            RepairOrder = await _context.RepairOrders
                .Include(r => r.Customer)
                .Include(r => r.Employee).ToListAsync();
        }
    }
}
