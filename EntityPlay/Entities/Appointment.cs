using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityPlay.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTimeOffset Date { get; set; }
        public int CustomerId { get; set; }

        public string Notes { get; set; }
    }
}
