using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderMicroservice.Models
{
    public class Order
    {
        public int Id { get; set; }


        // Navigation property for OrderItems
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}