using Application.Abstractions;
using Domain.Models;
using Infrostructure.Persistence.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Infrostructure.Persistence
{
    public class ApplicationDbContext : DbContext,IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<PaymentCheck> PaymentChecks { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserTypeConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrderTypeConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailsTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentCheckTypeConfiguration());

        }
    }
}
