using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StyleHub.Core.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleHub.Infrastructure._Data.Confiquration
{
    internal class CartConfiquration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem>entity)
        {
            entity.HasKey(c=>c.Id);
            entity.HasOne(c => c.Cart)
                .WithMany(c => c.cartItems)
                .HasForeignKey(c => c.CartId);
        }
    }
}
