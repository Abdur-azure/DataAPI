using DataAPI.Models.Validations;
using System.ComponentModel.DataAnnotations;

namespace DataAPI.Models
{
    public class Shirt
    {
        public int ShirtId { get; set; }

        [Required] 
        public string? Brand { get; set; }

        [Required]
        public string? Color { get; set;}

        [Shirt_EnsureCorrectSize]
        public int? Size { get; set; }

        [Required]
        public string? Gender { get; set; }

        public double? Price { get; set; }
    }
}
