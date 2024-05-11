using CNPM.Model;
using CNPM.Properties;
using CNPM.Views;
using ExcelDataReader;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Security;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CNPM.Controller
{
    public class PaymentController
    {
        MyDatabaseContext db = new MyDatabaseContext();
        public int totalPriceProduct(FlowLayoutPanel flowLayoutPanel)
        { 
            int totalPrice = 0;
            foreach(CartItemPaymentView data in flowLayoutPanel.Controls)
            {
                totalPrice += data.itemPrice;

            }
            return totalPrice;
        }

        public void loadInforBill(Guna2HtmlLabel txtTotal, Guna2HtmlLabel txtVAT, Guna2HtmlLabel txtDiscont, Guna2HtmlLabel txtFinalTotal)
        {
            txtDiscont.Text = "0%";
            txtVAT.Text = "10%";
            getFinalTotal(txtTotal, txtVAT, txtDiscont, txtFinalTotal);

        }
      
        public double getCodeDiscount(Guna2TextBox txtCodeDiscount)
        {
          
            double discountValue = 0;
            if (txtCodeDiscount.Text == "" || excelFileReader(txtCodeDiscount.Text) == 0)
            {
                return discountValue;
            }
            return excelFileReader(txtCodeDiscount.Text);
        }

        public void getFinalTotal(Guna2HtmlLabel txtTotal, Guna2HtmlLabel txtVAT, Guna2HtmlLabel txtDiscount, Guna2HtmlLabel txtFinalTotal)
        {
           
            double discount = double.Parse(txtDiscount.Text.Replace("%", ""));
            double vat = double.Parse(txtVAT.Text.Replace("%", ""));
            double total = double.Parse(txtTotal.Text) * (1 + 1 * (vat /100) - 1 * (discount / 100));
            txtFinalTotal.Text = total.ToString("N0");
        }

        public int excelFileReader(string code)
        {
            var stream = File.Open(Path.Combine(Application.StartupPath, "DataCodeDiscount.xlsx"), FileMode.Open, FileAccess.Read);
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            var reader = ExcelReaderFactory.CreateReader(stream);
            var result = reader.AsDataSet();
            var tables = result.Tables.Cast<DataTable>();
            foreach (DataTable table1 in tables)
            {
                for(int i=0; i<table1.Rows.Count-1; i++)
                {
                    if (code == table1.Rows[i][0].ToString())
                    {
                        stream.Close();
                        return int.Parse(table1.Rows[i][1].ToString());
                    }
                }
            }
            new CustomMessageBox("Mã giảm giá của bạn sai. Vui lòng nhập lại!", "Mã giảm giá").ShowDialog();
            stream.Close();
            return 0;
        }

        public bool insertOder(string totalPrice, string paymentMethods, List<DataPayment> data)
        {
            using (var context = new MyDatabaseContext())
            {
                var orderId = context.Orders.Max(p => (int?)p.Id) ?? 0;
                int newOrderId = orderId + 1;
                var test = new Employee();
                int index = UserAuthen.currentUser.UserId.IndexOf("admin");
                var order = new Model.Order();
              

                //if (index >= 0)
                //{
                //    var idCustomer = context.Customers.Where(x => x.UserId == UserAuthen.currentUser.UserId).FirstOrDefault();
                //    order = new Model.Order { Id = newOrderId, Status = paymentMethods, TotalPrice = int.Parse(totalPrice.Replace(",", "")), Date = DateTime.Now, Customer = idCustomer, Employee = null };
                //}
                //else
                //{
                //    var idEmployee = context.Employees.Where(x => x.UserId == UserAuthen.currentUser.UserId).FirstOrDefault();
                //    order = new Model.Order { Id = newOrderId, Status = paymentMethods, TotalPrice = int.Parse(totalPrice.Replace(",", "")), Date = DateTime.Now, Customer = null, Employee = idEmployee };
                //}
                var idCustomer = context.Customers.Where(x => x.UserId == UserAuthen.currentUser.UserId).FirstOrDefault();
                order = new Model.Order { Id = newOrderId, Status = paymentMethods, TotalPrice = int.Parse(totalPrice.Replace(",", "")), Date = DateTime.Now, Customer = idCustomer, Employee = null };
                context.Orders.Add(order);
                //////////////
               
                ///////////////
                int numEntitiesAdded = context.SaveChanges();
                if (numEntitiesAdded > 0)
                {
                    foreach (var item in data)
                    {
                        var orderItem = new Model.OrderItem();
                        var productInfor = context.Products.Where(x => x.Id == int.Parse(item.idProduct)).FirstOrDefault();
                        //productInfor = new Product() { Id = int.Parse(item.idProduct), Name = item.nameProduct, Price = item.priceProduct, ImageUrl = null };
                        //var orderItemId = context.OrderItems.Max(p => (int?)p.Id) ?? 0;
                        //orderItem.Id = orderItemId + 1;
                        orderItem.Amount = item.numberProduct;
                        orderItem.Product = productInfor;
                        orderItem.Order = order;
                        context.OrderItems.Add(orderItem);
                        context.SaveChanges();

                    }
                    new CustomMessageBox("Đơn hàng của bạn đặt thành công", "Đặt hàng thành công").ShowDialog();
                    UserListProduct.dataPayment.Clear();
                    return true;
                }
                else
                {
                    new CustomMessageBox("Đơn hàng của bạn đặt thất bại", "Đặt hàng không thành công").ShowDialog();
                    return false;
                }
            }
        }

        public bool checkInforCustomer(Guna2TextBox lbNamePayment, Guna2TextBox lbPhonePayment, Guna2TextBox lbAddressPayment)
        {
            if (lbNamePayment.Text == lbAddressPayment.Text && lbPhonePayment.Text == lbAddressPayment.Text && lbAddressPayment.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập đầy đủ thông tin", "Thông tin nhập sai").ShowDialog();
                return false;
            }
            else
            {
                if (lbNamePayment.Text == "")
                {
                    new CustomMessageBox("Vui lòng nhập thông tin", "Thông tin nhập sai").ShowDialog();
                    return false;
                }
                else if (lbPhonePayment.Text == "")
                {
                    new CustomMessageBox("Vui lòng nhập đúng só điện thoại", "Thông tin nhập sai").ShowDialog();
                    return false;

                }
                else if (lbAddressPayment.Text == "")
                {
                    new CustomMessageBox("Vui lòng địa chỉ người nhận", "Thông tin nhập sai").ShowDialog();
                    return false;
                }
            }
            return true;
        }
        public void changeNumberic(FlowLayoutPanel flowLayoutPanel, CartItemPaymentView cartItemPaymentView)
        {
            foreach (Control control in flowLayoutPanel.Controls)
            {
                var card = (CartItemPaymentView)control;
                if (cartItemPaymentView.itemId == card.itemId)
                {
                    var numeric = (Guna2NumericUpDown)card.Controls["inputCartItemAmount"];
                    numeric.Value += 1;
                    return;
                }
            }
            MessageBox.Show("ha");
        }

        public static void getTotal(int total) 
        {
            MessageBox.Show(total.ToString());
        }

    }
}
