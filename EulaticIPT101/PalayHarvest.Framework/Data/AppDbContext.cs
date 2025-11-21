using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PalayHarvest.Domain.Entities;

namespace PalayHarvest.Framework.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Farmer> Farmers { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
