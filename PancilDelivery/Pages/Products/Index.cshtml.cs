using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PancilDelivery.Models;

namespace PancilDelivery.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly PancilDelivery.Models.PencilDeliveryContext _context;

        public IndexModel(PancilDelivery.Models.PencilDeliveryContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Products
                .Include(p => p.CategoryldNavigation)
                .Include(p => p.ManufactureldNavigation)
                .Include(p => p.Unit).ToListAsync();
        }
    }
}
