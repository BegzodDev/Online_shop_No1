using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

            builder.HasData(new User
            {
                Id = 1,
                Fullname = "Admin Adminov",
                Email = "admin@gmail.com",
                Role = Domain.Enums.UserRole.Admin,
                Balance = 100000000,
                CardNumber = "1111 2222 3333 4444",
                PasswordHash = "123456"
            });
        }
    }
}
