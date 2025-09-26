using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PancilDelivery.Models;

namespace PancilDelivery.Pages.Products
{
    public class CreateModel : PageModel
    {
        private readonly PancilDelivery.Models.PencilDeliveryContext _context;

        public CreateModel(PancilDelivery.Models.PencilDeliveryContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["Categoryld"] = new SelectList(_context.Categories, "Id", "Id");
        ViewData["Manufactureld"] = new SelectList(_context.Manufacturers, "Id", "Id");
        ViewData["Unitid"] = new SelectList(_context.UnitsSamaraBoiler, "Id", "Id");
            return Page();
        }

        [BindProperty]
        public Product Product { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Products.Add(Product);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
