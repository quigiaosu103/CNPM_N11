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
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                return;
            }

            else if (password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            using (var context = new MyDatabaseContext())
            {
                Account account = context.Account.Find(user_name);

                Employee employee = context.Employees.Find(user_name);
          
                if (account == null || employee == null)
                {
                    MessageBox.Show("Tên tài khoản hoăc mật khẩu không đúng!");
                    return;
                }
                if (MyLib.hashPassword(password) != account.HashedPassword)
                {
                    MessageBox.Show("Tên tài khoản hoăc mật khẩu không đúng!");
                    return;
                }
                User user;
                if (account.Role != "customer")
                {
                    user = (User)context.Users.OfType<Employee>().Where(u => u.Account.UserName == account.UserName).FirstOrDefault();
                }
                else
                {
                    user = (User)context.Users.OfType<Customer>().Where(u => u.Account.UserName == account.UserName).FirstOrDefault();
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
