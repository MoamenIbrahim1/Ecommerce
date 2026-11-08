using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StyleHub.Core.Models;

namespace StyleHub.Infrastructure._Data.Confiquration
{
    internal class ProductConfiquration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> entity)
        {
           entity.HasKey(p => p.Id);
            entity.HasOne(p => p.Category)
                .WithMany(p=> p.Products)
                .HasForeignKey(p=> p.CategoryId);
         
        }
    }
}
