using System.Windows.Forms;
using System.Windows.Markup;
using CNPM.Model;
using Microsoft.VisualBasic.ApplicationServices;
using static Guna.UI2.WinForms.Helpers.GraphicsHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using CNPM.Views;
using System.Runtime.CompilerServices;
using System.ComponentModel.DataAnnotations;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Windows.Media.Animation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using FontAwesome.Sharp;
using System.Xml.Linq;
using System.Text.RegularExpressions;
using static System.Windows.Forms.DataFormats;
using System.Globalization;
using System.Drawing.Imaging;
using System.ComponentModel.DataAnnotations.Schema;

namespace CNPM.Controller
{
    public class ManagerAccountController
    {
        public static void loadDataAccount(DataGridView data)
        {
            using (var context = new MyDatabaseContext())
            {
             
                data.Rows.Clear();
                Account account = new Account();
                var dataEmployee = context.Account.ToList();
               

                foreach (var i in dataEmployee)
                {
                    var phoneNumber = context.Users.Where(x=>x.UserId == i.UserId).FirstOrDefault();
                   
                    data.Rows.Add(i.UserName, phoneNumber.PhoneNumber, i.Role, i.Email);
                    
                }
                data.AllowUserToAddRows = false;
                data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
        }

        public static void InitAccount(Account data)
        {
            AccountInfor.dataAccount = new Model.Account
            {
                UserId = data.UserName,
                UserName = data.UserName,   
                Role = data.Role,
                Email = data.Email,
                HashedPassword = data.HashedPassword,
                AvatarUrl = data.AvatarUrl,
            };
        }

        public static string findIdAccount(string fullName)
        {
            using (var context = new MyDatabaseContext())
            {
                var newAccount = context.Account.FirstOrDefault(e => e.UserName == fullName); ;
                return newAccount.UserName;
            }
        }
        public static void updateAccount(Account data, string phone)
        {
            using (var context = new MyDatabaseContext())
            {
                
                var newAccount = context.Account.Find(data.UserId);
                var user = context.Users.Where(x=>x.UserId == data.UserId).FirstOrDefault();
                
                if (newAccount != null && user != null)
                {
                  
                    //newAccount.UserName = data.UserName;
                    newAccount.Role = data.Role;
                    newAccount.Email = data.Email;
                    newAccount.AvatarUrl = data.AvatarUrl;
                    //newAccount.UserId = data.UserId;
                    //newAccount.HashedPassword = data.HashedPassword;
                    user.PhoneNumber = phone;
                    int numEntitiesAdded = context.SaveChanges();
                    if (numEntitiesAdded > 0)
                    {
                        new CustomMessageBox("Cập nhật thông tin thành công", "Cập nhật thành công").ShowDialog();
                    }
                    else
                    {
                        new CustomMessageBox("Cập nhật thông tin thất bại", "Cập nhật không thành công").ShowDialog();
                    }
                } 

            }
        }

        public static List<Account> searchAccount(string name, string col)
        {
            using (var context = new MyDatabaseContext())
            {
               
                if (col == "Tên tài khoản")
                {
                    var dataEmployee = context.Account.Where(x => x.UserName.Contains(name)).ToList();
                    return dataEmployee;
                }
                else if (col == "Vai trò")
                {
                    var dataEmployee = context.Account.Where(x => x.Role.Contains(name)).ToList();
                    return dataEmployee;
                }
                else if (col == "Email")
                {
                    var dataEmployee = context.Account.Where(x => x.Email.Contains(name)).ToList();
                    return dataEmployee;
                }
                return null;
            }

            

        }

        public static void loadDataAccountSearch(DataGridView data, List<Account> dataAccount)
        {
            using (var context = new MyDatabaseContext())
            {
                data.Rows.Clear();
                foreach (Account i in dataAccount)
                {
                    var phoneNumber = context.Users.Where(x => x.UserId == i.UserId).FirstOrDefault();
                    
                   
                    data.Rows.Add(i.UserName, phoneNumber.PhoneNumber, i.Role, i.Email);
                }
                data.AllowUserToAddRows = false;
                data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
               
            }
           
        }
    }
}
