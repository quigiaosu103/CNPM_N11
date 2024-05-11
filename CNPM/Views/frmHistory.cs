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
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
            LoadHistory();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            txtName.Text = "Hi, " + UserAuthen.currentUser.FullName;
        }

        private void LoadHistory()
        {
            tableHistory.Rows.Clear();
            using (var context = new MyDatabaseContext())
            {
                var orderItems = context.OrderItems.Where(o => o.Order.Customer.UserId == UserAuthen.currentUser.UserId).Include(o => o.Product).Include(o => o.Order).OrderByDescending(o => o.Order.Date).ToList();
                foreach (var orderItem in orderItems)
                {
                    tableHistory.Rows.Add(orderItem.Product.Name, orderItem.Amount, orderItem.Product.Price, orderItem.Order.Date);

                }
            }
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime start = inputDateStart.Value;
            DateTime end = inputDateEnd.Value;
            if (start <= end)
            {
                tableHistory.Rows.Clear();
                using (var context = new MyDatabaseContext())
                {
                    var orderItems = context.OrderItems
                        .Where(o =>
                            o.Order.Customer.UserId == UserAuthen.currentUser.UserId
                            && o.Order.Date > start
                            && o.Order.Date < end
                            )
                        .Include(o => o.Product).Include(o => o.Order)
                        .ToList();
                    foreach (var orderItem in orderItems)
                    {
                        tableHistory.Rows.Add(orderItem.Product.Name, orderItem.Amount, orderItem.Product.Price, orderItem.Order.Date);

                    }
                }
            }
            else
            {
                return;
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
