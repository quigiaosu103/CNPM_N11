using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM.Model;
using CNPM.Views;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;

namespace CNPM.Controller
{
    internal class DiaryController
    {
        public DataTable GetCombinedData()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ProductId", typeof(int));
            dataTable.Columns.Add("ProductName", typeof(string));
            dataTable.Columns.Add("Price", typeof(decimal));
            dataTable.Columns.Add("Date", typeof(DateTime));
            dataTable.Columns.Add("Date2", typeof(DateTime));
            using (var context = new MyDatabaseContext())
            {
                var orderItems = context.OrderItems.Include(o => o.Product).Include(o=>o.Order).ToList();
                foreach (var orderItem in orderItems)
                {
                    dataTable.Rows.Add(orderItem.Product.Id, orderItem.Product.Name, orderItem.Product.Price, orderItem.Order.Date, DateTime.Now);
                    
                }
            }
            return dataTable;
        }
    }
}
