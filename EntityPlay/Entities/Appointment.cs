using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EntityPlay.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public string AppointmentName { get; set; }
        public DateTimeOffset Date { get; set; }
        public int CustomerId { get; set; }

        [Required] public string Notes { get; set; }
        public string Location { get; set; }
    }
}
