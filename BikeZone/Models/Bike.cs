using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BikeZone.Models
{
    class Bike
    {
        [Key][MaxLength(7)][Required]
        public required string BikeID { get; set; }
        [Required]
        public required string BikeName { get; set; }
        [DataType(DataType.Currency)]
        public decimal BikePrice { get; set; }
        [ForeignKey("BrandID")]
        public virtual required Brand BikeBrand { get; set; }
    }
}