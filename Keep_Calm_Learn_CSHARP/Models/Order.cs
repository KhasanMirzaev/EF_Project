using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keep_Calm_Learn_CSHARP.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<OrderDetails> Details { get; set; }
    }
}
