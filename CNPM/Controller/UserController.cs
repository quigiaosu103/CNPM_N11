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
        public static bool UpdatePassword(string newPass, string email) 
        {
            using(var context = new MyDatabaseContext())
            {
                Account account = context.Account.Where(a => a.Email == email).FirstOrDefault();
                if(account != null)
                {
                    account.HashedPassword = newPass;
                    context.Account.Update(account);
                    context.SaveChanges();
                    MyLib.AlertMessage("Đổi mật khẩu thành công");
                    return true;
                }
            }
            return false;
        }

        public static bool CheckAndUpdatePassword(string username, string pass, string newPass)
        {
            using (var context = new MyDatabaseContext())
            {
                Account user = context.Account.Find(username);
                if(user != null)
                {
                    if(user.HashedPassword == pass)
                    {
                        user.HashedPassword = newPass;
                        context.Account.Update(user);
                        context.SaveChanges();
                        return true;
                    }
                }
            }
            return false;
        }
    }

}
