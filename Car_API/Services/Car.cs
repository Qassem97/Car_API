using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Car_API.Controllers
{
    public class Car
    {
        public int Id { get; set;}
        [Required]
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Year { get; set; }
    }
}
