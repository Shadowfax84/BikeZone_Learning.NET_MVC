using System.ComponentModel.DataAnnotations;

namespace BikeZone
{
    public class Customer
    {
        [Key]
        [StringLength(7)]
        [Required]
        public required string CustomerID { get; set; }
        public required string Name { get; set; }
        [Phone]
        public long Phone { get; set; }
        [EmailAddress]
        public string? Email { get; set; } = null!;
        public ICollection<Order> Orders = new List<Order>();
        
    }
}