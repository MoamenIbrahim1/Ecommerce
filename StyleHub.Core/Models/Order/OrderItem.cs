using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleHub.Core.Models.Order
{
    public class OrderItem
    {
        public int Id { get; set; }

        // FK
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        // Data snapshot (مهم)
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
