using Microsoft.AspNetCore.Identity;
using StyleHub.Core.Models;
using StyleHub.Core.Models.Cart;
using StyleHub.Core.Models.Order;
using StyleHub.Core.Models.Reviews;
using StyleHub.Core.Models.WishList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StyleHub.Infrastructure.User
{
    public class ApplicationUser:IdentityUser
    {
        public string FullName { get; set; }
        //relations
        public ICollection<Order> Orders { get; set; }
        public Cart Cart { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public Wishlist Wishlist { get; set; }
    }
}
