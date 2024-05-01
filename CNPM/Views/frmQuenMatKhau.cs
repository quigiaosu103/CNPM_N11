using CNPM.Controller;
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
    public partial class frmQuenMatKhau : Form
    {
        private string otp = "";
        public frmQuenMatKhau()
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
            string inputOtp = txtOtpInput.Text;
            if(inputOtp.Trim()!="" && inputOtp == otp)
            {
                panelGetOTP.Hide();
                UserControl resetPass = new frmResetPassword();
                Panel panel = new Panel();
                panel.Location = new Point(190, 79);
                panel.Size = new Size(230, 230);
                panel.Controls.Add(resetPass);
                this.Controls.Add(panel);
                otp = "";
            }else
            {
                MyLib.AlertMessage("OTP không đúng!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSendOTP_Click(object sender, EventArgs e)
        {
            string mail = txtMail.Text;
            if(mail.Trim() != "")
            {
                otp = MyLib.SendOTP(mail);
                UserAuthen.Email = mail;
            }
        }

    }
}
