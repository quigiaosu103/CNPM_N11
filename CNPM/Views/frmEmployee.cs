using CNPM.Controller;
using CNPM.Model;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM.Views
{
    public partial class frmEmployee : Form
    {
        EmployeeController controller = new EmployeeController();
        Employee employee = new Employee();

        public frmEmployee()
        {
            InitializeComponent();
            controller.loadDataEmployee(emplyeeDatagridView);
            loadUserInfo();
        }

        private void loadUserInfo()
        {
            txtName.Text = UserAuthen.currentUser.FullName;
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            new MessageBoxAddEmployee().ShowDialog();
            emplyeeDatagridView.Rows.Clear();
            controller.loadDataEmployee(emplyeeDatagridView);
        }
        int indexRow;

        //private object checkData(string data)
        //{
        //    if (data == null)
        //    {
        //        return null;
        ////    }
        //}
        private string checkValue(string data)
        {

            if (data == null || data == "")
            {
                return "Chưa cập nhật";
            }
            return data;

        }
        private void emplyeeDatagridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            indexRow = e.RowIndex;
            if (indexRow >= 0)
            {
                DataGridViewRow row = emplyeeDatagridView.Rows[indexRow];
                employee.UserId = checkValue(row.Cells["clUserId"].Value?.ToString());
                employee.FullName = checkValue(row.Cells[1].Value?.ToString());
                employee.Address = checkValue(row.Cells[2].Value?.ToString());
                employee.PhoneNumber = checkValue(row.Cells[3].Value?.ToString());
                employee.Email = checkValue(row.Cells[4].Value?.ToString());
                var clGender = 0;
                if (row.Cells[5].Value.ToString() == "Nam")
                {
                    clGender = 0;
                }
                else
                {
                    clGender = 1;
                }
                employee.Gender = clGender;
                employee.BirthDay = DateTime.Parse(row.Cells[6].Value?.ToString());
                employee.IdCard = checkValue(row.Cells[7].Value?.ToString());
                employee.Position = checkValue(row.Cells[8].Value?.ToString());
                employee.Salary = int.Parse(row.Cells[9].Value?.ToString());
                employee.WorkingTime = checkValue(row.Cells[10].Value?.ToString());
                employee.ApplyDate = checkValue(row.Cells[11].Value?.ToString());
            }

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

            if (employee.UserId == null)
            {
                new CustomMessageBox("Vui lòng chọn dữ liệu muốn thay đổi", "Lỗi").ShowDialog();
                return;
            }
            new MessageBoxEditsEmployee("Sửa tin nhân viên", "Lưu", employee).ShowDialog();
            emplyeeDatagridView.Rows.Clear();
            controller.loadDataEmployee(emplyeeDatagridView);
        }

        private void emplyeeDatagridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            //EmployeeController.searchEmployee(txtSearch.Text, cbSearch.Text);

            //MessageBox.Show(EmployeeController.searchEmployee(txtSearch.Text, cbSearch.Text).ToString());
            EmployeeController.loadDataEmployeeSearch(emplyeeDatagridView, EmployeeController.searchEmployee(txtSearch.Text, cbSearch.Text));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            controller.loadDataEmployee(emplyeeDatagridView);
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void emplyeeDatagridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
