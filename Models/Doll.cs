using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcDoll.Models
{
    public class Doll
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 4)]
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [Required]
        [StringLength(35)]
        public string Type { get; set; }


        [Display(Name = "Lauch Date")]
        [DataType(DataType.Date)]
        public DateTime LaunchDate { get; set; }

        [StringLength(100, MinimumLength = 4)]
        [Required]
        public string Color { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [StringLength(6)]
        [Required]
        public string Rating { get; set; }


    }
}
