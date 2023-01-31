using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
