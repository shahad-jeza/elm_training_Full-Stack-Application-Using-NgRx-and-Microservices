using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace OrderMicroservice.Models
{
    public class OrderItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "ProductId is required.")]
        public int ProductId { get; set; } // Reference to the product

        [Required(ErrorMessage = "Quantity is required.")]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        // Foreign key for Order
        public int OrderId { get; set; }

        [JsonIgnore] // Add this attribute to break the circular reference
        public Order Order { get; set; } // Navigation property
    }
}