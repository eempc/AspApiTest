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
    public class CityIndexModel : PageModel
    {
        private readonly ApiTest.Data.ApiTestContext _context;

        public CityIndexModel(ApiTest.Data.ApiTestContext context)
        {
            _context = context;
        }

        public IList<City> City { get;set; }

        public async Task OnGetAsync()
        {
            City = await _context.City
                .Include(c => c.Country).ToListAsync();
        }
    }
}
