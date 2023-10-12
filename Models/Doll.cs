using System;
using System.ComponentModel.DataAnnotations;

namespace MvcDoll.Models
{
    public class Doll
    {
        public int Id { get; set; }
        public string Type { get; set; }

        [DataType(DataType.Date)]
        public DateTime LaunchDate { get; set; }
        public string Color { get; set; }
        public decimal Price { get; set; }

    
    }
}
