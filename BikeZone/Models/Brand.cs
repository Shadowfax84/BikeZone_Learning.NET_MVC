using System.ComponentModel.DataAnnotations;

namespace BikeZone.Models
{
    class Brand
    {
        [Key][MaxLength(7)][Required]
        public required string BrandID { get; set; }
        [Required]
        public required string BrandName { get; set; }

        public ICollection<Bike> Bikes { get; set; } = new List<Bike>();
    }
}