using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityPlay.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        [Required, MaxLength(200)] public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
    }
}
