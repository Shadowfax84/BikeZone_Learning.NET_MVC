using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeZone
{
    public class Order
    {
        [Key]
        [MaxLength(7)]
        [Required]
        public required string OrderID { get; set; }
        public required string CustomerID { get; set; }
        [DataType(DataType.Date)]
        public DateOnly Date { get; set; }
        [DataType(DataType.Currency)]
        public decimal TotalCost { get; set; }

        [ForeignKey("CustomerID")]
        public virtual required Customer Customer { get; set; }
    }
}