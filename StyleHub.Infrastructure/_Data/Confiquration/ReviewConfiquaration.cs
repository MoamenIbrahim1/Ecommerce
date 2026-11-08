using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StyleHub.Core.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleHub.Infrastructure._Data.Confiquration
{
    internal class ReviewConfiquaration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> entity)
        {
            entity.HasKey(r=>r.Id);
            entity.HasOne(p=>p.Product)
                .WithMany(r=>r.Reviews)
                .HasForeignKey(r=>r.ProductId);

        }
    }
}
