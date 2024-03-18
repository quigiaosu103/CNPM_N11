using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.Model
{
    public class Customer:User
    {
        public ICollection<Order> Orders { get; set; }

    }
}
