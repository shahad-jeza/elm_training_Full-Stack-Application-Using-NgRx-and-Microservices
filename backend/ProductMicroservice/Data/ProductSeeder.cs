using Microsoft.EntityFrameworkCore;
using ProductMicroservice.Models;
using System;
using System.Collections.Generic;

namespace ProductMicroservice.Data
{
    public static class ProductSeeder
    {
        public static void SeedProducts(ModelBuilder modelBuilder)
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Laptop", Description = "High-performance laptop", Category = "Electronics", Price = 1200.00m },
                new Product { Id = 2, Name = "Smartphone", Description = "Latest smartphone model", Category = "Electronics", Price = 800.00m },
                new Product { Id = 3, Name = "Tablet", Description = "Portable tablet device", Category = "Electronics", Price = 500.00m },
                new Product { Id = 4, Name = "Headphones", Description = "Noise-cancelling headphones", Category = "Electronics", Price = 150.00m },
                new Product { Id = 5, Name = "Smartwatch", Description = "Fitness tracking smartwatch", Category = "Electronics", Price = 250.00m },
                new Product { Id = 6, Name = "Monitor", Description = "27-inch 4K monitor", Category = "Electronics", Price = 400.00m },
                new Product { Id = 7, Name = "Keyboard", Description = "Mechanical gaming keyboard", Category = "Electronics", Price = 120.00m },
                new Product { Id = 8, Name = "Mouse", Description = "Wireless ergonomic mouse", Category = "Electronics", Price = 80.00m },
                new Product { Id = 9, Name = "Printer", Description = "All-in-one laser printer", Category = "Electronics", Price = 300.00m },
                new Product { Id = 10, Name = "Camera", Description = "DSLR camera with 24MP", Category = "Electronics", Price = 700.00m },
                new Product { Id = 11, Name = "Speaker", Description = "Bluetooth portable speaker", Category = "Electronics", Price = 100.00m },
                new Product { Id = 12, Name = "Drone", Description = "4K HD drone with camera", Category = "Electronics", Price = 600.00m },
                new Product { Id = 13, Name = "Router", Description = "Wi-Fi 6 router", Category = "Electronics", Price = 200.00m },
                new Product { Id = 14, Name = "External SSD", Description = "1TB portable SSD", Category = "Electronics", Price = 150.00m },
                new Product { Id = 15, Name = "Gaming Console", Description = "Next-gen gaming console", Category = "Electronics", Price = 500.00m },
                new Product { Id = 16, Name = "Coffee Maker", Description = "Automatic drip coffee maker", Category = "Home Appliances", Price = 80.00m },
                new Product { Id = 17, Name = "Blender", Description = "High-speed blender", Category = "Home Appliances", Price = 120.00m },
                new Product { Id = 18, Name = "Microwave", Description = "Compact microwave oven", Category = "Home Appliances", Price = 150.00m },
                new Product { Id = 19, Name = "Toaster", Description = "4-slice toaster", Category = "Home Appliances", Price = 50.00m },
                new Product { Id = 20, Name = "Vacuum Cleaner", Description = "Bagless vacuum cleaner", Category = "Home Appliances", Price = 200.00m },
                new Product { Id = 21, Name = "Air Purifier", Description = "HEPA air purifier", Category = "Home Appliances", Price = 250.00m },
                new Product { Id = 22, Name = "Electric Kettle", Description = "Stainless steel electric kettle", Category = "Home Appliances", Price = 40.00m },
                new Product { Id = 23, Name = "Rice Cooker", Description = "Automatic rice cooker", Category = "Home Appliances", Price = 60.00m },
                new Product { Id = 24, Name = "Desk Lamp", Description = "LED desk lamp", Category = "Home & Office", Price = 40.00m },
                new Product { Id = 25, Name = "Office Chair", Description = "Ergonomic office chair", Category = "Home & Office", Price = 200.00m },
                new Product { Id = 26, Name = "Desk", Description = "Adjustable standing desk", Category = "Home & Office", Price = 300.00m },
                new Product { Id = 27, Name = "Notebook", Description = "Spiral-bound notebook", Category = "Stationery", Price = 5.00m },
                new Product { Id = 28, Name = "Pen", Description = "Ballpoint pen (pack of 10)", Category = "Stationery", Price = 10.00m },
                new Product { Id = 29, Name = "Stapler", Description = "Heavy-duty stapler", Category = "Stationery", Price = 15.00m },
                new Product { Id = 30, Name = "Paper Shredder", Description = "Cross-cut paper shredder", Category = "Home & Office", Price = 100.00m }
            };

            modelBuilder.Entity<Product>().HasData(products);
        }
    }
}