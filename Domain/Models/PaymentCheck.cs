using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PaymentCheck
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int OrderId { get; set; }

        public int NumberMonth { get; set; }


        public User? User { get; set; }

        public Order? Order { get; set; }
    }
}
