using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleHub.Core.Models.WishList
{
    public class Wishlist
    {
        public int Id { get; set; }

        public string UserId { get; set; }


        public ICollection<WishlistItem> WishListItems { get; set; }
    }
}
