using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleHub.Core.Models
{
    public class ProductColors
    {
        public int ProductId { get; set; }
        public Product product { get; set; }
        public int ColorId {  get; set; }
        public Color color { get; set; }
        public int stock {  get; set; }

    }
}
