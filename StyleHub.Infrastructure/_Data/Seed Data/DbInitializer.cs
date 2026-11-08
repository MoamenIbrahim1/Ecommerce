using Microsoft.EntityFrameworkCore;
using StyleHub.Core.Models;

namespace StyleHub.Infrastructure._Data.Seed_Data
{
    public static class DbInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // 1. Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Women" },
                new Category { Id = 2, Name = "Men" },
                new Category { Id = 3, Name = "Watches" },
                new Category { Id = 4, Name = "Shoes" }
            );

            // 2. Seed Products 
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Esprit Ruffle Shirt", Description = "A stylish ruffle shirt for a modern look.", Price = 16.64m, ImageUrl = "product-01.jpg", CategoryId = 1 },
                new Product { Id = 2, Name = "Herschel supply", Description = "Classic Herschel supply backpack for everyday use.", Price = 35.31m, ImageUrl = "product-02.jpg", CategoryId = 1 },
                new Product { Id = 3, Name = "Only Check Trouser", Description = "Comfortable check trousers with a slim fit.", Price = 25.50m, ImageUrl = "product-03.jpg", CategoryId = 2 },
                new Product { Id = 4, Name = "Classic Trench Coat", Description = "Elegant classic trench coat perfect for autumn.", Price = 75.00m, ImageUrl = "product-04.jpg", CategoryId = 1 },
                new Product { Id = 5, Name = "Front Pocket Jumper", Description = "Cozy jumper featuring a convenient front pocket.", Price = 34.75m, ImageUrl = "product-05.jpg", CategoryId = 1 },
                new Product { Id = 6, Name = "Vintage Inspired Classic", Description = "Timeless vintage inspired watch design.", Price = 93.20m, ImageUrl = "product-06.jpg", CategoryId = 3 },
                new Product { Id = 7, Name = "Shirt in Stretch Cotton", Description = "Breathable stretch cotton shirt for all-day comfort.", Price = 52.66m, ImageUrl = "product-07.jpg", CategoryId = 1 },
                new Product { Id = 8, Name = "Pieces Metallic Printed", Description = "Trendy metallic printed top for special occasions.", Price = 18.96m, ImageUrl = "product-08.jpg", CategoryId = 1 },
                new Product { Id = 9, Name = "Converse All Star Hi Plimsolls", Description = "Iconic Converse high-top sneakers.", Price = 75.00m, ImageUrl = "product-09.jpg", CategoryId = 4 },
                new Product { Id = 10, Name = "Femme T-Shirt In Stripe", Description = "Casual striped t-shirt for a relaxed vibe.", Price = 25.85m, ImageUrl = "product-10.jpg", CategoryId = 1 },
                new Product { Id = 11, Name = "Herschel supply", Description = "Premium quality bag from Herschel supply.", Price = 63.16m, ImageUrl = "product-11.jpg", CategoryId = 2 },
                new Product { Id = 12, Name = "Herschel supply", Description = "Versatile accessory for the modern man.", Price = 63.15m, ImageUrl = "product-12.jpg", CategoryId = 2 },
                new Product { Id = 13, Name = "T-Shirt with Sleeve", Description = "Simple and clean t-shirt design with detailed sleeves.", Price = 18.49m, ImageUrl = "product-13.jpg", CategoryId = 1 },
                new Product { Id = 14, Name = "Pretty Little Thing", Description = "Fashionable piece from Pretty Littlae Thing collection.", Price = 54.79m, ImageUrl = "product-14.jpg", CategoryId = 1 },
                new Product { Id = 15, Name = "Mini Silver Mesh Watch", Description = "Minimalist silver mesh watch for a subtle touch of luxury.", Price = 86.85m, ImageUrl = "product-15.jpg", CategoryId = 3 },
                new Product { Id = 16, Name = "Square Neck Back", Price = 29.64m, Description = "Chic square neck top with a stylish back design.", ImageUrl = "product-16.jpg", CategoryId = 1 }
            );
        }
    }
}