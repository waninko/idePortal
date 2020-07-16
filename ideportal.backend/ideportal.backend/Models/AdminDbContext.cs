using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ideportal.backend.Models
{
    public class AdminDbContext : DbContext
    {
       public AdminDbContext(DbContextOptions<AdminDbContext> options) : base(options)
        {

        }

        public DbSet<Admin> Administrators { get; set; }
    }
}
