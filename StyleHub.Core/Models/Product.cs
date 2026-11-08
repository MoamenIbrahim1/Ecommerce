using StyleHub.Core.Models.Reviews;
using StyleHub.Core.Models.WishList;

namespace StyleHub.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        //forign key
        public int CategoryId {  get; set; }
        public string Name { get; set; }
        public string  ImageUrl { get; set; }
        public int StockQuantity { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        //Navigation Property
        public Category Category { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<WishlistItem>wishlistItems { get; set; }
        public ICollection<ProductSize> productSizes { get; set; }
        public ICollection<ProductColors> productColors { get; set; }
      
    }
}
