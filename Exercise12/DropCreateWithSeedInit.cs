using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Sql;

namespace Exercise12
{
    public class DropCreateWithSeedInit : DropCreateDatabaseIfModelChanges<Context>
    {
        protected override void Seed(Context db)
        {
            Vacation v1 = new Vacation
            {
                Location = "Florida",
                StartDate = DateTime.Parse("5/5/20"),
                EndDate = DateTime.Parse("5/10/20")
            };
            db.Vacations.Add(v1);
            Vacation v2 = new Vacation
            {
                Location = "Nepal",
                StartDate = DateTime.Parse("1/15/20"),
                EndDate = DateTime.Parse("1/30/20")
            };
            db.Vacations.Add(v2);
            Vacation v3 = new Vacation
            {
                Location = "New Jersey",
                StartDate = DateTime.Parse("7/1/20"),
                EndDate = DateTime.Parse("7/3/20")
            };
            db.Vacations.Add(v3);
            Activity a1 = new Activity
            {
                Name = "Boating",
                Leader = "Uncle Sam",
                Cost = 500.00M
            };
            v1.Activities.Add(a1);
            v2.Activities.Add(a1);
            Activity a2 = new Activity
            {
                Name = "Mountain Climbing",
                Leader = "Mr. Mt. Man",
                Cost = 2000.00M
            };
            v3.Activities.Add(a2);
            Activity a3 = new Activity
            {
                Name = "Shopping",
                Leader = "Aunt Beth",
                Cost = 200.00M
            };
            db.Activities.Add(a3);
        }
    }
}
