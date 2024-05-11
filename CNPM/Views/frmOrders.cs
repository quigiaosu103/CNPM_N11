using CNPM.Controller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM.Views
{
    public partial class frmOrders : Form
    {
        public frmOrders()
        {
            InitializeComponent();
            fillDataToList();
            loadTypes();
        }

        private void loadTypes()
        {
            string[] types = new[]
            {
                "Đang xử lý",
                "Đang giao",
                "Đã giao",
                "Đã hủy"
            };
            selectType.DataSource = types;
        }


        private void fillDataToList()
        {
            tableOrders.Rows.Clear();
            using (var context = new MyDatabaseContext())
            {
                var orders = context.Orders.Select(o => new
                {
                    Id = o.Id,
                    CustomerName = o.Customer.FullName,
                    Address = o.Customer.Address,
                    TotalPrice = o.TotalPrice,
                    Status = o.Status,
                    Date = o.Date,
                    EmployeeName = o.Employee.FullName,

                }).OrderByDescending(o => o.Date).ToList();
                foreach (var order in orders)
                {
                    tableOrders.Rows.Add(MyLib.RandomString(10) + order.Id, order.CustomerName, order.Address, order.TotalPrice, order.Status, order.EmployeeName, order.Date);
                }
            }
        }

        private void OnCellClicked(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = e.RowIndex;
            DataGridViewRow row = tableOrders.Rows[currentIndex];
            if (row != null)
            {
                txtId.Text = row.Cells[0].Value.ToString();
                txtCustomer.Text = row.Cells[1].Value.ToString();
                txtAddress.Text = row.Cells[2].Value.ToString();
                txtCreateDate.Text = row.Cells[6].Value.ToString();
                if(row.Cells[5].Value != null)
                {
                    txtEmployee.Text = row.Cells[5].Value.ToString();

                }
                txtTotal.Text = row.Cells[3].Value.ToString();
                switch (row.Cells[4].Value.ToString())
                {
                    case "Đang xử lý":
                        {
                            selectType.SelectedIndex = 0;
                            break;
                        }
                    case "Đã giao":
                        {
                            selectType.SelectedIndex = 2;
                            break;
                        }
                    case "Đang giao":
                        {
                            selectType.SelectedIndex = 1;
                            break;
                        }
                    case "Đã hủy":
                        {
                            selectType.SelectedIndex = 3;
                            break;
                        }
                    default:
                        {
                            MyLib.AlertMessage(row.Cells[4].Value.ToString());
                            break;
                        }
                }
            }

        }




        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private int currentIndex = -1;

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime start = inputDateStart.Value;
            DateTime end = inputDateEnd.Value;
            if (start <= end)
            {
                tableOrders.Rows.Clear();
                using (var context = new MyDatabaseContext())
                {
                    var orders = context.Orders.Select(o => new
                    {
                        Id = o.Id,
                        CustomerName = o.Customer.FullName,
                        Address = o.Customer.Address,
                        TotalPrice = o.TotalPrice,
                        Status = o.Status,
                        Date = o.Date,
                        EmployeeName = o.Employee.FullName,

                    }).Where(o => o.Date > start && o.Date < end).OrderByDescending(o => o.Date).ToList();
                    foreach (var order in orders)
                    {
                        tableOrders.Rows.Add(MyLib.RandomString(10) + order.Id, order.CustomerName, order.Address, order.TotalPrice, order.Status, order.EmployeeName, order.Date);
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            fillDataToList();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = tableOrders.Rows[currentIndex];
            if (row != null)
            {
                if(currentStatus!="" && txtAddress.Text != "")
                {

                    OrderController.UpdateOrder(
                        txtId.Text.ToString().Substring(10), 
                        txtAddress.Text.ToString(), 
                        selectType.SelectedValue.ToString()
                        );
                    row.Cells[4].Value = selectType.SelectedValue.ToString();
                }
                row.Cells[5].Value = UserAuthen.currentUser.FullName;
            }
        }

        private void txtId_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tableOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private string currentStatus = "";

        private void selectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentStatus = selectType.SelectedValue.ToString();
        }
    }
}
