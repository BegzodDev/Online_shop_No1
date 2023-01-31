using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product
    {

        public Product()
        {
            OrderDetails= new HashSet<OrderDetail>();
        }
        public int Id { get; set; }

        public string? Name { get; set; }

        public decimal Price { get; set; }

        public Category? Category { get; set; }

        public string? CompanyName { get; set; }

        public int TotalCount { get; set; }

        public int Percent { get; set; }

        public ICollection<OrderDetail> OrderDetails { get; set; }


    }
}
