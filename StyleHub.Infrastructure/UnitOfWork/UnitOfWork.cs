using StyleHub.Core.Models;
using StyleHub.Core.Models.Cart;
using StyleHub.Core.Models.Order;
using StyleHub.Core.Models.Reviews;
using StyleHub.Core.Models.WishList;
using StyleHub.Infrastructure._Data.AppDbContext;
using StyleHub.Infrastructure.Repositories;

namespace StyleHub.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;

            Orders = new GenericRepository<Order>(_context);

            Products = new GenericRepository<Product>(_context);

            Categories = new GenericRepository<Category>(_context);

            Addresses = new GenericRepository<Address>(_context);

            Carts = new GenericRepository<Cart>(_context);

            CartItems = new GenericRepository<CartItem>(_context);

            Wishlists = new GenericRepository<Wishlist>(_context);

            WishlistItems = new GenericRepository<WishlistItem>(_context);

            Reviews = new GenericRepository<Review>(_context);
        }

        public IGenericRepository<Order> Orders { get; private set; }

        public IGenericRepository<Product> Products { get; private set; }

        public IGenericRepository<Category> Categories { get; private set; }

        public IGenericRepository<Address> Addresses { get; private set; }

        public IGenericRepository<Cart> Carts { get; private set; }

        public IGenericRepository<CartItem> CartItems { get; private set; }

        public IGenericRepository<Wishlist> Wishlists { get; private set; }

        public IGenericRepository<WishlistItem> WishlistItems { get; private set; }

        public IGenericRepository<Review> Reviews { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}