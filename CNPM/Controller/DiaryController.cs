using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM.Views;
using Guna.UI2.WinForms;

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
                var query = from products in context.Products 
                            join orders in context.Orders on products.OrderID equals orders.Id
                            select new
                            {
                                ProductId = products.Id,
                                ProductName = products.Name,
                                Price = products.Price,
                                Date = orders.Date
                            };
                foreach (var item in query)
                {
                    dataTable.Rows.Add(item.ProductId, item.ProductName, item.Price, item.Date, DateTime.Now);
                }
            }
            return dataTable;
        }
    }
}
