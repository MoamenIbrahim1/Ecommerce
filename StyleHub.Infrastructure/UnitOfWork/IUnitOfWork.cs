using StyleHub.Core.Models;
using StyleHub.Core.Models.Cart;
using StyleHub.Core.Models.Order;
using StyleHub.Core.Models.Reviews;
using StyleHub.Core.Models.WishList;
using StyleHub.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleHub.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Address> Addresses { get; }
        IGenericRepository<Cart> Carts { get; }
        IGenericRepository<CartItem>CartItems { get; }
        IGenericRepository<Wishlist> Wishlists { get; }
        IGenericRepository<WishlistItem> WishlistItems { get; }
        IGenericRepository<Review> Reviews { get; }
        Task<int> CompleteAsync();

            

    }
}
