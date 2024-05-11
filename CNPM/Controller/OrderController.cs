using CNPM.Model;
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
                var user = context.Users.Find(UserAuthen.currentUser.UserId);
                int id = Int32.Parse(orderId);
                var order = context.Orders.Find(id);
                if(order != null)
                {
                    //order.Customer.Address = address;
                    order.Status  = status;
                    if(user!= null)
                    {
                        order.Employee = (Employee)user;
                    }
                    context.Orders.Update(order);
                    context.SaveChanges();
                }
            }
        }
    }
}
