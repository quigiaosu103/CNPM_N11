using CNPM.Controller;
using CNPM.Model;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Markup;

namespace CNPM.Views
{
    public partial class MessageBoxEditsEmployee : Form
    {
        public MessageBoxEditsEmployee()
        {
            InitializeComponent();
        }

        public MessageBoxEditsEmployee(string htmlLabel, string button, Employee data)
        {
            InitializeComponent();
            lbTitle.Text = htmlLabel;
            btnTitle.Text = button;
            txtName.Text = data.FullName;
            txtPhone.Text = data.PhoneNumber;
            txtSalary.Text = data.Salary.ToString("N0");
            txtIdCard.Text = data.IdCard;
            txtAddress.Text = data.Address;
            cbGender.SelectedIndex = data.Gender;
            ////MessageBox.Show(data.BirthDay.ToString());
            dttBirthday.CustomFormat = "dd/mm/yy";
            dttBirthday.Value = data.BirthDay;
            if(data.Position == "Nhân viên" || data.Position == "Employee") 
            {
                cbPosition.SelectedIndex = 0;
            } else if(data.Position == "Manager")
            {
                cbPosition.SelectedIndex = 1;
            }
           
            txtTimeWork.Text = data.WorkingTime.ToString();
            txtTimeApply.Text = data.ApplyDate.ToString();
            txtId.Text = data.UserId.ToString();
            txtEmail.Text = data.Email.ToString();
            //lbId.Visible = false;
        }
        public MessageBoxEditsEmployee(string htmlLabel, string button)
        {
            InitializeComponent();
            lbTitle.Text = htmlLabel;
            btnTitle.Text = button;
            //lbId.Visible = false;
        }
        private void btnTitle_Click(object sender, EventArgs e)
        {
            if (lbTitle.Text == "Sửa tin nhân viên")
            {
                Employee data = new Employee();
                data.FullName = txtName.Text;
                data.PhoneNumber = txtPhone.Text;
                data.Salary = long.Parse(txtSalary.Text.Replace(",", ""));
                data.IdCard = txtIdCard.Text;
                data.Address = txtAddress.Text;
                data.Gender = cbGender.SelectedIndex;
                data.BirthDay = dttBirthday.Value;
                if (cbPosition.SelectedIndex == 0)
                {
                    data.Position = "Employee";
                }
                else if (cbPosition.SelectedIndex == 1)
                {
                    data.Position = "Manager";
                }
                //data.Position = cbPosition.Text;
                data.WorkingTime = txtTimeWork.Text;
                data.ApplyDate = txtTimeApply.Text;
                data.UserId = txtId.Text;
                data.Email = txtEmail.Text;
                EmployeeController.InitEmployee(data);
                EmployeeController.updateEmployee(data);
                this.Close();
            }
            //if (lbTitle.Text == "Thêm nhân viên mới")
            //{
            //    Employee data = new Employee();
            //    data.FullName = txtName.Text;
            //    data.PhoneNumber = txtPhone.Text;
            //    data.Salary = long.Parse(txtSalary.Text);
            //    data.IdCard = txtIdCard.Text;
            //    data.Address = txtAddress.Text;
            //    data.Gender = cbGender.SelectedIndex;
            //    data.BirthDay = dttBirthday.Value;
            //    data.Position = cbPosition.Text;
            //    data.WorkingTime = txtTimeWork.Text;
            //    data.ApplyDate = txtTimeApply.Text;
            //    data.UserId = txtId.Text;
            //    data.Email = txtEmail.Text;
            //    EmployeeController.addEmployee(data);
            //    this.Close();
            //}

        }

        private void MessageBoxAddEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
