using System.ComponentModel.DataAnnotations;

namespace BikeZone.Models
{
    enum ProdType
    {
        Bike = 1,
        Spare
    }
    class Products
    {
        [Key][MaxLength(7)][Required]
        public required string ProductID { get; set; }
        public ProdType ProductType { get; set; } 
    }
}