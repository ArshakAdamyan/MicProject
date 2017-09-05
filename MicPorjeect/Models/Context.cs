using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicPorjeect.Models
{
    public class Context : DbContext
    {
        public DbSet<WashingMachine> WashingMachine { get; set; }
        public DbSet<AirConditioner> AirConditioners { get; set; }
        public DbSet<VacuumCleaner> VacuumCleaners { get; set; }
        public DbSet<Freezer> Freezers { get; set; }

        public Context(DbContextOptions<Context> options):base(options)
        {

        }

    }
}
