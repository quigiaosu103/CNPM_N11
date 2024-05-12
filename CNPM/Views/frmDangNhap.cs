using CNPM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Security.Cryptography;
using CNPM.Controller;
using CNPM.Model;
using CNPM.Views;

namespace DangKi__DangNhap__QuenMatKhau
{
    public partial class form_DangNhap : Form
    {
        public form_DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_quenmatkhaubtn_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_taotaikhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            form_DangKi dangKi = new form_DangKi();
            dangKi.ShowDialog();
            this.Close();
        }

        private void button1_dangnhapbtn_Click(object sender, EventArgs e)
        {


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user_name = txtUserName.Text;
            string password = txtPassword.Text;

            if (user_name.Trim() == "")
            {
                (new CustomMessageBox("Vui lòng nhập tên đăng nhập!", "Đăng nhập")).ShowDialog();
                return;
            }

            else if (password.Trim() == "")
            {
                (new CustomMessageBox("Vui lòng nhập mật khẩu!", "Đăng nhập")).ShowDialog();
                return;
            }
            using (var context = new MyDatabaseContext())
            {
                Account account = context.Account.Find(user_name);

                Employee employee = context.Employees.Find(user_name);
          
                if (account == null)
                {
                    (new CustomMessageBox("Tên tài khoản hoăc mật khẩu không đúng!1", "Đăng nhập")).ShowDialog();
                    return;
                }
                if (MyLib.hashPassword(password) != account.HashedPassword)
                {
                    (new CustomMessageBox("Tên tài khoản hoăc mật khẩu không đúng!1", "Đăng nhập")).ShowDialog();
                    return;
                }
                User user;
                //if (account.Role != "customer")
                //{
                //    user = (User)context.Users.OfType<Employee>().Where(u => u.Account.UserName == account.UserName).FirstOrDefault();
                //}
                //else
                //{
                //    user = (User)context.Users.OfType<Customer>().Where(u => u.Account.UserName == account.UserName).FirstOrDefault();
                //}
                user = context.Users.Where(u => u.Account.UserName == account.UserName).FirstOrDefault();
                if(user == null)
                {
                    MyLib.AlertMessage("null");
                }
                UserAuthen.Email = account.Email;
                UserAuthen.currentUser = user;
                
                if(employee != null)
                {
                    UserAuthen.Position = employee.Position;
                }
             
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            frmQuenMatKhau quenMatKhau = new frmQuenMatKhau();
            quenMatKhau.ShowDialog();
        }
    }
}
