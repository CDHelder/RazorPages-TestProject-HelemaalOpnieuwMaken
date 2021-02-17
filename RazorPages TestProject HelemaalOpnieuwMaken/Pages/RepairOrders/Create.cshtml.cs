using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPages_TestProject_HelemaalOpnieuwMaken.Data;
using RazorPages_TestProject_HelemaalOpnieuwMaken.Models;

namespace RazorPages_TestProject_HelemaalOpnieuwMaken.Pages.RepairOrders
{
    public class CreateModel : PageModel
    {
        private readonly RepairOrderDbContextCollection _context;

        public CreateModel(RepairOrderDbContextCollection context)
        {
            _context = context;
        }

        public List<RepairOrderDetail> RepairOrderDetails;

        public IActionResult OnGet()
        {
        ViewData["CustomerID"] = new SelectList(_context.Set<Customer>(), "ID", "Name");
        ViewData["EmployeeID"] = new SelectList(_context.Set<Employee>(), "EmployeeID", "EmployeeID");

            RepairOrderDetail repairOrderDetail = new RepairOrderDetail();
            RepairOrderDetails = repairOrderDetail.FindAll();
            ViewData["RepairOrderDetails"] = new SelectList(RepairOrderDetails);

            return Page();
        }

        [BindProperty]
        public RepairOrder RepairOrder { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.RepairOrders.Add(RepairOrder);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
