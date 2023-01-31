using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Infrostructure.Persistence.EntityTypeConfiguration
{
    public class UserTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasMany(x => x.Orders).WithOne(x => x.User).HasForeignKey(x=>x.UserId);
            builder.HasMany(x => x.PaymentChecks).WithOne(x => x.User).HasForeignKey(x => x.UserId);
            builder.HasIndex(x => x.Email).IsUnique();
            builder.Property(x =>x.Email).IsRequired();
            builder.Property(x=>x.Fullname).HasMaxLength(50).IsRequired();


        }
    }
}
