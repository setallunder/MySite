using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace MySite.Data
{
    public class MySiteContext : DbContext
    {
        public MySiteContext (DbContextOptions<MySiteContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Company> Company { get; set; }
    }
}
