using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleHub.Core.Models.Reviews
{
    public class Review
    {
        public int Id { get; set; }

        // FK → Product
        public int ProductId { get; set; }
        public Product Product { get; set; }

        // FK → User (Identity)
        public string UserId { get; set; }

        // Review Data
        public int Rating { get; set; }      // من 1 لـ 5
        public string Comment { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
