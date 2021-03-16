using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Exercise12
{
    public class Context : DbContext
    {
        public DbSet<Vacation> Vacations { get; set; }
        public DbSet<Activity> Activities { get; set; }
    }
}
