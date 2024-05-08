using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.Controller
{
    public class OrderController
    {
        public static void UpdateOrder(string orderId, string address, string status)
        {
            using(var context = new MyDatabaseContext())
            {
                int id = Int32.Parse(orderId);
                var order = context.Orders.Find(id);
                if(order != null)
                {
                    //order.Customer.Address = address;
                    order.Status  = status;
                    context.Orders.Update(order);
                    context.SaveChanges();
                }
            }
        }
    }
}
