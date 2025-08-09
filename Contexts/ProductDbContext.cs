using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCoreAssignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAssignment.Contexts
{
    class ProductDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseSqlServer("Server = .; Database = NewCompany; Trusted_Connection = True; Encrypt = False");
        public DbSet<Product> Product { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
