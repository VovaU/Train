using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Models;

namespace WebApplication3.Persistence
{
    public class VegaDbContext:DbContext
    {
        public DbSet<Make> Makes { get; set; }
        public DbSet<Feature> Features11 { get; set; }

        public VegaDbContext(DbContextOptions<VegaDbContext> options)
            : base(options)
        {

        }
    }
}
