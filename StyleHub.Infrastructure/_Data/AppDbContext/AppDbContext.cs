using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StyleHub.Core.Models;
using StyleHub.Core.Models.Cart;
using StyleHub.Core.Models.Order;
using StyleHub.Core.Models.WishList;
using StyleHub.Infrastructure.User;
using StyleHub.Infrastructure._Data.Seed_Data;

namespace StyleHub.Infrastructure._Data.AppDbContext
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<WishlistItem> WishlistItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Address> Addresses { get; set; }

        // تعديل بسيط: جعلنا الحرف الأول كبيراً للـ DbSets المتأثرة تماشياً مع الـ Standard
        public DbSet<ProductColors> ProductColors { get; set; }
        public DbSet<ProductSize> ProductSizes { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Color> Colors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // يقوم بقراءة ProductSizeConfiguration و ProductColorConfiguration و ProductConfiguration تلقائياً
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

            // سطر الـ Seeding الخاص بك
            DbInitializer.Seed(modelBuilder);
        }
    }
}