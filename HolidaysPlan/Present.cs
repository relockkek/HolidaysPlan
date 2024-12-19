using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolidaysPlan
{
    internal class Present
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public Person IdPerson { get; set; }
        public Holiday IdHoliday { get; set; }
    }
}
