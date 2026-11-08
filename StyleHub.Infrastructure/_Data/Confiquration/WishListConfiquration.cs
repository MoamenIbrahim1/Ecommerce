using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StyleHub.Core.Models.WishList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleHub.Infrastructure._Data.Confiquration
{
    internal class WishListConfiquration : IEntityTypeConfiguration<WishlistItem>
    {
        public void Configure(EntityTypeBuilder<WishlistItem> entity)
        {
           entity.HasKey(w=>w.Id);
            entity.HasOne(w => w.Product)
                .WithMany(w => w.wishlistItems)
                .HasForeignKey(w => w.ProductId);
            entity.HasOne(w=>w.Wishlist)
                .WithMany(w=>w.WishListItems)
                .HasForeignKey(w=>w.WishlistId);
        }
    }
}
