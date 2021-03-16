using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Exercise12
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new DropCreateWithSeedInit());

            using (Context db = new Context())
            {
                var results = from oneVacation in db.Vacations
                              from oneActivity in oneVacation.Activities
                              where oneActivity.Name == "Boating"
                              select new
                              {
                                  oneVacation.Location,
                                  oneVacation.StartDate
                              };

                Console.WriteLine("Vacations With Boating:");
                foreach(var bv in results)
                {
                    Console.WriteLine("Location: {0}, Start Date: {1}", bv.Location, bv.StartDate);
                }

                var startDate = DateTime.Parse("5/5/20");
                var endDate = DateTime.Parse("5/10/20");

                var secondResults = from oneActivity in db.Activities
                                    from oneVacation in oneActivity.Vacations
                                    where oneVacation.StartDate == startDate
                                    && oneVacation.EndDate == endDate
                                    && oneActivity.Leader == "Uncle Sam"
                                    select new
                                    {
                                        oneActivity.Name,
                                        oneActivity.Cost
                                    };

                Console.WriteLine("Activities led by Uncle Sam in May:");
                foreach (var am in secondResults)
                {
                    Console.WriteLine("Name: {0}, Cost: {1}", am.Name, am.Cost);
                }

                Console.Write("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
