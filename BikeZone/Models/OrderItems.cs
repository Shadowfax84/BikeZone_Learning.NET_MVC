using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BikeZone.Models;

namespace BikeZone
{
    class OrderItems
    {
        [Key]
        [MaxLength(7)]
        [Required]
        public required string OrderItemID { get; set; }
        [ForeignKey("OrderID")]
        public required virtual Order Order { get; set; }

        [ForeignKey("ProductID")]
        public required virtual Products Product { get; set; }

        public int Quantity { get; set; } 
    }
}