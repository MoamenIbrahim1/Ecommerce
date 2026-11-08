using StyleHub.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleHub.Core.Models.Cart
{
    public class Cart
    {
        public int Id { get; set; }
        public string UserID {  get; set; }
        public ICollection<CartItem> cartItems { get; set; }
    }
}
