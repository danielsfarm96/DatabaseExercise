using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class Vacation
    {
        public Vacation()
        {
            Activities = new HashSet<Activity>();
        }

        public int VacationId { get; set; }
        public string Location { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }
    }
}
