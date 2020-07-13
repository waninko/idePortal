using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ideportal.backend.Models
{
    public class SubmitDbContext : DbContext
    {
        public SubmitDbContext(DbContextOptions<SubmitDbContext> options) : base(options)
        {

        }

        public DbSet<Submit> SubmittedProjects { get; set; }
    }
}
