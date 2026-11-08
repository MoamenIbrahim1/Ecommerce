using StyleHub.Core.Models.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleHub.Core.Models
{
    public class Address
    {
        public int Id { get; set; }

        public string UserId { get; set; }   // بس ID بدون Navigation

        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string PostalCode { get; set; }
       public ICollection<StyleHub.Core.Models.Order.Order>Orders { get; set; }
    }
}
