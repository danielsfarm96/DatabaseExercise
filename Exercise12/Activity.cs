using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    public class Activity
    {
        public Activity()
        {
            Vacations = new HashSet<Vacation>();
        }

        public int ActivityId { get; set; }
        public string Name { get; set; }
        public string Leader { get; set; }
        public decimal Cost { get; set; }

        public virtual ICollection<Vacation> Vacations { get; set; }
    }
}
