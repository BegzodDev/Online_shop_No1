using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Order
    {

        public Order()
        {
            PaymentChecks= new HashSet<PaymentCheck>();
            OrderDetails = new HashSet<OrderDetail>();
        }
        public int Id { get; set; }

        public int? UserId { get; set; }

        public DateTime CreatedAt { get; set; }

        public PurchaseType PurchaseType { get; set; }

        public PaymentMonth PaymentMonth { get; set; }

        public User User { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }

        public ICollection<PaymentCheck> PaymentChecks { get; set; }
    }
}
