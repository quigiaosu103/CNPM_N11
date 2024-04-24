using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM.Controller;
using CNPM.Model;
namespace CNPM.Views
{
    public partial class MessageBoxAddEmployee : Form
    {
        public MessageBoxAddEmployee()
        {
            InitializeComponent();
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            Account data = new Account();
            data.Email = txtEmail.Text;
            data.UserName = txtUsername.Text;
            EmployeeController.addEmployeeAccount(data);
            this.Close();
        }

        private void MessageBoxAddEmployee_Load(object sender, EventArgs e)
        {
           
        }
    }
}
