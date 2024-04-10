using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.Model
{
    public class Order
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int TotalPrice { get; set; }
        public DateTime Date { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public virtual ICollection<OrderItem> Products { get; set; }
    }
}
