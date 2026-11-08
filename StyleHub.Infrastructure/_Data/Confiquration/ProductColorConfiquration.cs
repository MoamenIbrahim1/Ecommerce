using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StyleHub.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleHub.Infrastructure._Data.Confiquration
{
    public class ProductColorConfiquration : IEntityTypeConfiguration<ProductColors>
    {
        public void Configure(EntityTypeBuilder<ProductColors> builder)
        {
            builder.HasKey(ps => new {ps.ColorId,ps.ProductId});
            builder.HasOne(p => p.color)
          .WithMany(ps => ps.productColors)
          .HasForeignKey(ps => ps.ColorId);

            builder.HasOne(s => s.product)
            .WithMany(ps => ps.productColors)
            .HasForeignKey(ps => ps.ProductId);

        }
    }
}
