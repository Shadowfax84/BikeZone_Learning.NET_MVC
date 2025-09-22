using System.ComponentModel.DataAnnotations;

namespace BikeZone
{
    class Spares
    {
        [Key][MaxLength(7)][Required]
        public required string SparesID { get; set; }
        [Required]
        public required string SparesName { get; set; }
        [DataType(DataType.Currency)]
        public decimal SparesPrice { get; set; }
        public required string BikeID { get; set; }
    }
}