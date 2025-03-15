using System.ComponentModel.DataAnnotations;

namespace ProductMicroservice.Models
{
    public class Product
    {
        [Key] // Specifies that Id is the primary key
        public int Id { get; set; }

        [Required] // Ensures Name is not null or empty
        [StringLength(100, MinimumLength = 2)] // Limits the length of the Name
        public string Name { get; set; }

        [StringLength(500)] // Limits the length of the Description
        public string Description { get; set; }

        [Required] // Ensures Category is not null or empty
        public string Category { get; set; }

        [Required] // Ensures Price is not null
        [Range(0.01, 10000)] // Sets a valid range for Price
        public decimal Price { get; set; }
    }
}