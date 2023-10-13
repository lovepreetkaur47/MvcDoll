using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcDoll.Models
{
    public class Doll
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        [Display(Name = "Lauch Date")]
        [DataType(DataType.Date)]
        public DateTime LaunchDate { get; set; }
        public string Color { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Rating { get; set; }


    }
}
