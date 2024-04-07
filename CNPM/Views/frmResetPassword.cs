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

        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            txtAlert.Hide();
        }
    }
}
