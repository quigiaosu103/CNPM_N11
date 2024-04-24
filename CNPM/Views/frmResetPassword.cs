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

namespace CNPM.Views
{
    public partial class frmResetPassword : UserControl
    {
        public frmResetPassword()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string newPass  = MyLib.hashPassword(txtNewPass.Text.Trim());
            string confirmPass  = MyLib.hashPassword(txtConfirmPass.Text.Trim());
            if(newPass == confirmPass)
            {
                bool result = UserController.UpdatePassword(newPass, UserAuthen.Email);
   
            }else
            {
                txtAlert.Show();
            }
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            txtAlert.Hide();
        }

        private void frmResetPassword_Load(object sender, EventArgs e)
        {
            txtAlert.Hide();
        }
    }
}
