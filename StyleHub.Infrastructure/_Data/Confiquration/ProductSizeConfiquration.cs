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
   public class ProductSizeConfiquration: IEntityTypeConfiguration<ProductSize>
    {
        public void Configure(EntityTypeBuilder<ProductSize> builder)
        {
            builder.HasKey(ps => new { ps.ProductId, ps.SizeId });
            builder.HasOne(p => p.Product)
                .WithMany(ps => ps.productSizes)
                .HasForeignKey(ps => ps.ProductId);
                
                builder.HasOne(s=>s.Size)
                .WithMany(ps=>ps.ProductSizes)
                .HasForeignKey(ps=>ps.SizeId);         
        }
    }
}
