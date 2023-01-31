using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrostructure.Persistence.EntityTypeConfiguration
{
    public class PaymentCheckTypeConfiguration : IEntityTypeConfiguration<PaymentCheck>
    {
        public void Configure(EntityTypeBuilder<PaymentCheck> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
