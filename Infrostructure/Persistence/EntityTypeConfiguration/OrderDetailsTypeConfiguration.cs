using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrostructure.Persistence.EntityTypeConfiguration
{
    public class OrderDetailsTypeConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.HasKey(x=> x.Id);
            builder.Property(x=>x.Quantity).IsRequired();
            

        }
    }
}
