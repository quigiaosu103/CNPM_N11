using CNPM.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM.Model;
using Guna.UI2.WinForms;
using System.Xml.Linq;
namespace CNPM
{
    public partial class frmDiary : Form
    {
        private DiaryController diary = new DiaryController();
        public frmDiary()
        {
            InitializeComponent();
            LoadData();
            LoadUserInfo();
        }
        private void LoadUserInfo()
        {
            txtName.Text = "Hi, " + UserAuthen.currentUser.FullName.ToString();
        }
        private void LoadData()
        {
            DataTable dt = diary.GetCombinedData();
            foreach (DataRow row in dt.Rows)
            {
                object[] rowData = new object[row.ItemArray.Length];
                row.ItemArray.CopyTo(rowData, 0);
                guna2DataGridView1.Rows.Add(rowData);
            }

        }
        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton2_Click_1(object sender, EventArgs e)
        {
            DateTime startDate = guna2DateTimePicker1.Value;
            DateTime endDate = guna2DateTimePicker2.Value;
            int columnIndex = 3;
            foreach (DataGridViewRow row in guna2DataGridView1.Rows)
            {
                if (!row.IsNewRow && row.Cells[columnIndex].Value != null)
                {
                    DateTime rowDate = Convert.ToDateTime(row.Cells[columnIndex].Value);
                    if (rowDate >= startDate && rowDate <= endDate)
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }

        }

        private void guna2GradientButton3_Click_1(object sender, EventArgs e)
        {
            guna2DataGridView1.Rows.Clear();
            LoadData();
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime selectedDate = guna2DateTimePicker1.Value;
            guna2DateTimePicker1.Value = selectedDate.Date;
        }

        private void guna2DateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {
            DateTime selectedDate = guna2DateTimePicker2.Value;
            guna2DateTimePicker2.Value = selectedDate.Date;
        }
    }
}
