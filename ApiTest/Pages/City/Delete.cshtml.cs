using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ApiTest.Data;
using ApiTest.Models;

namespace ApiTest
{
    public class CityDeleteModel : PageModel
    {
        private readonly ApiTest.Data.ApiTestContext _context;

        public CityDeleteModel(ApiTest.Data.ApiTestContext context)
        {
            _context = context;
        }

        [BindProperty]
        public City City { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            City = await _context.City
                .Include(c => c.Country).FirstOrDefaultAsync(m => m.Id == id);

            if (City == null)
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

            City = await _context.City.FindAsync(id);

            if (City != null)
            {
                _context.City.Remove(City);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
