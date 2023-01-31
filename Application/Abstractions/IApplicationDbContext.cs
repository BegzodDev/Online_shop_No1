using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading;

namespace Application.Abstractions
{
    public interface IApplicationDbContext
    {
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
        DbSet<PaymentCheck> PaymentChecks { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<User> Users { get; set; }

        Task<int> SaveChangesAsync(CancellationToken token =default);
    }
}
