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
        public string TotalPrice { get; set; }
        public int Date { get; set; }
        public Customer Customer { get; set; }
        public Employee Employee { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
