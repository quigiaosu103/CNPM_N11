using CNPM.Views;
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

namespace DangKi__DangNhap__QuenMatKhau
{
    public partial class form_QuenMatKhau : Form
    {
        public form_QuenMatKhau()
        {
            InitializeComponent();
            txtAlert.Hide();
        }

        private void label1_quenmatkhau_Click(object sender, EventArgs e)
        {

        }

        private void button1_laylaimatkhau_Click(object sender, EventArgs e)
        {

        }

        private void form_QuenMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            txtAlert.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panelGetOTP.Hide();
            UserControl resetPass = new frmResetPassword();
            Panel panel = new Panel();
            panel.Location = new Point(190, 79);
            panel.Size = new Size(230, 230);
            panel.Controls.Add(resetPass);
            this.Controls.Add(panel);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //location: 205, 79
    }
}
