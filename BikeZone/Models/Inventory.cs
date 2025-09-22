using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BikeZone.Models;

namespace BikeZone
{
    class Inventory
    {
        [Key][MaxLength(7)][Required]
        public required string InventoryID { get; set; }
        [ForeignKey("ProductID")]
        public required virtual Products Product { get; set; }

        public string ? InvQuantity { get; set; } = null!;
    }
}