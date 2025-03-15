using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderMicroservice.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal Total { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Pending";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
    }

    public class OrderProduct
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [Required]
        public int ProductId { get; set; } 

        [Required]
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; }
    }
}