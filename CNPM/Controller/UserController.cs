using CNPM.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CNPM.Controller
{
    public class UserController
    {
        public static void NewUAccount(string userName, string password, string email)
        {
            

            var user = new Model.Customer()
            {
                UserId = userName,
                FullName = "",
                Address = "",
                PhoneNumber = "",
                Gender = 0,
                BirthDay = new DateTime(1975,01,01)
            };
            var account = new Account
            {
                UserName = userName,
                HashedPassword = password,
                Email = email,
                AvatarUrl = "",
                Role = "customer",
                User = user
            };

            using (var context = new MyDatabaseContext())
            {
                context.Account.Add(account);
                context.SaveChanges();
            }
        }
    }
}
