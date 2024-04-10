using CNPM.Controller;
using CNPM.Model;
using Guna.UI2.WinForms;
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
    public partial class frmEmployee : Form
    {
        EmployeeController controller = new EmployeeController();
        Employee employee = new Employee();
        public frmEmployee()
        {
            InitializeComponent();
            controller.loadDataEmployee(emplyeeDatagridView);
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            new MessageBoxAddEmployee("Thêm nhân viên mới", "Thêm").ShowDialog();
            controller.loadDataEmployee(emplyeeDatagridView);
        }
        int indexRow;
        private void emplyeeDatagridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = emplyeeDatagridView.Rows[indexRow];
            employee.FullName = row.Cells[0].Value.ToString();
            employee.Address = row.Cells[1].Value.ToString();
            employee.PhoneNumber = row.Cells[2].Value.ToString();
            employee.Gender = int.Parse(row.Cells[3].Value.ToString());
            employee.BirthDay = DateTime.Parse(row.Cells[4].Value.ToString());
            employee.IdCard = row.Cells[5].Value.ToString();
            employee.Position = row.Cells[6].Value.ToString();
            employee.Salary = int.Parse(row.Cells[7].Value.ToString());
            employee.WorkingTime = row.Cells[8].Value.ToString();
            employee.ApplyDate = row.Cells[9].Value.ToString();
            employee.UserId =  EmployeeController.findIdEmployee(employee.FullName, employee.IdCard);
            //EmployeeController.findIdEmployee(employee.FullName, employee.IdCard);
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            new MessageBoxAddEmployee("Sửa tin nhân viên", "Lưu", employee).ShowDialog();
            controller.loadDataEmployee(emplyeeDatagridView);
        }
    }
}
