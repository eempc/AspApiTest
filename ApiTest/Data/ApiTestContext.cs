using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiTest.Models;

namespace ApiTest.Data
{
    public class ApiTestContext : DbContext
    {
        public ApiTestContext (DbContextOptions<ApiTestContext> options)
            : base(options)
        {
        }

        public DbSet<ApiTest.Models.Country> Country { get; set; }

        public DbSet<ApiTest.Models.City> City { get; set; }
    }
}
