using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleHub.Core.Models.Order
{
    public class Order
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string Status { get; set; }
        public int AddressId { get; set; }        // ✅ FK
        public Address Address { get; set; }      // ✅ Navigation
        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
