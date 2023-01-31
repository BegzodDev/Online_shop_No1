using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrostructure.Persistence.EntityTypeConfiguration
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x=>x.OrderDetails).WithOne(x=>x.Product).HasForeignKey(x=>x.ProductId);
            builder.Property(x=>x.Price).IsRequired();
            builder.Property(x=>x.Name).HasMaxLength(50).IsRequired();

        }
    }
}
