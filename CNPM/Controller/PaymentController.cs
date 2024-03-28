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
        Cart spn = new Cart();
        List<Cart> dssp = new List<Cart>();
        //CustomMessageBox customMessageBox = new CustomMessageBox();
        public void dsSanPham(DataGridView dataGridView, Guna2HtmlLabel txtTotal, Guna2HtmlLabel txtVAT, Guna2HtmlLabel txtDiscont, Guna2HtmlLabel txtFinalTotal)
        {
     
            spn = new Cart() { nameSanPham = "Banh 1", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 2", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 3", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 4", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 5", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 6", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 7", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 8", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 9", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 10", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 1", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 2", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 3", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 4", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 5", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 6", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 7", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 8", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 9", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 10", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 1", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 2", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 3", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 4", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 5", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 6", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 7", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 8", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 9", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            spn = new Cart() { nameSanPham = "Banh 100", soLuong = 2, total = 100000 };
            dssp.Add(spn);
            //dssp.Reverse();

            foreach (var i in dssp)
            {
                dataGridView.Rows.Add(i.nameSanPham, i.soLuong, i.total);
            }
            dataGridView.AllowUserToAddRows = false;
            double total = 0;
            foreach (DataGridViewRow i in dataGridView.Rows)
            {
                try
                { 
                    total += double.Parse(i.Cells["cPrice"]!.Value.ToString());
                }
                catch (NullReferenceException w) { }

            }

            txtTotal.Text = total.ToString("N0");
            txtDiscont.Text = "0%";
            txtVAT.Text = "10%";
            //txtFinalTotal.Text = getFinalTotal(txtTotal, txtVAT, txtDiscont).ToString("N0");
            getFinalTotal(txtTotal, txtVAT, txtDiscont, txtFinalTotal);

            //dataGridView.ColumnWidthChanged()
        }
      
        public double getCodeDiscount(Guna2TextBox txtCodeDiscount)
        {
          
            double discountValue = 0;
            if (txtCodeDiscount.Text == "" || excelFileReader(txtCodeDiscount.Text) == 0)
            {
                return discountValue;
            }
            //MessageBox.Show( txtCodeDiscount.Text.GetType().ToString());
            return excelFileReader(txtCodeDiscount.Text);
        }

        public void getFinalTotal(Guna2HtmlLabel txtTotal, Guna2HtmlLabel txtVAT, Guna2HtmlLabel txtDiscount, Guna2HtmlLabel txtFinalTotal)
        {
           
            double discount = double.Parse(txtDiscount.Text.Replace("%", ""));
            double vat = double.Parse(txtVAT.Text.Replace("%", ""));
            double total = double.Parse(txtTotal.Text) * (1 + 1 * (vat /100) - 1 * (discount / 100));
            txtFinalTotal.Text = total.ToString("N0");
            //return total;
        }

        public void getBill(Guna2HtmlLabel txtTotal, Guna2HtmlLabel txtVAT, Guna2HtmlLabel txtDiscont, Guna2HtmlLabel txtFinalTotal, Guna2TextBox lbNamePayment, Guna2TextBox lbPhonePayment, Guna2TextBox lbAddressPayment)
        {
            if(lbNamePayment.Text == lbAddressPayment.Text && lbPhonePayment.Text == lbAddressPayment.Text && lbAddressPayment.Text == "")
            {
                new CustomMessageBox("Vui lòng nhập đầy đủ thông tin", "Thông tin nhập sai").ShowDialog();
            } else
            {
                if (lbNamePayment.Text == "")
                {
                    new CustomMessageBox("Vui lòng nhập thông tin", "Thông tin nhập sai").ShowDialog();
                }
                else if (lbPhonePayment.Text == "")


                {
                    new CustomMessageBox("Vui lòng nhập đúng só điện thoại", "Thông tin nhập sai").ShowDialog();

                }
                else if (lbAddressPayment.Text == "")
                {
                    new CustomMessageBox("Vui lòng địa chỉ người nhận", "Thông tin nhập sai").ShowDialog();
                }

            }

           
        }

        public static bool IsPhoneNbr(string number)
        {
            Match match = Regex.Match(number, @"[^\d]");
            if (number != null)
                return match.Success;
            else return false;
        }

        public int excelFileReader(string code)
        {
            var stream = File.Open("C:\\Users\\thanh\\Desktop\\New folder (2)\\CNPM_N11-main\\CNPM\\Resources\\DataCodeDiscount.xlsx", FileMode.Open, FileAccess.Read);
        
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
                        //new CustomMessageBox(code.ToString(), "Thông tin nhập sai").ShowDialog();
                        stream.Close();
                        return int.Parse(table1.Rows[i][1].ToString());
                    }
                }
            }
            stream.Close();
            return 0;
        }
       
        public void deleteShopCart( DataGridViewButtonColumn btnEdits)
        {

        }

    }
}
