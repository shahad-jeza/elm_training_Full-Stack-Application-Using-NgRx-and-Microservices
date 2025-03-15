using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OrderMicroservice.Models
{
public class Order
{
    public int Id { get; set; }
    public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
}