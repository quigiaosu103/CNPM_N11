<<<<<<< HEAD
﻿using CNPM;
=======
﻿using MySqlConnector;
>>>>>>> 52749a96e5c1555daecbd4db902cfd9e8bcd0b5f
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
            form_QuenMatKhau quenMatKhau = new form_QuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void linkLabel1_taotaikhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
<<<<<<< HEAD
=======
            this.Hide();
>>>>>>> 52749a96e5c1555daecbd4db902cfd9e8bcd0b5f
            form_DangKi dangKi = new form_DangKi();
            dangKi.ShowDialog();
            this.Close();
        }

        private void button1_dangnhapbtn_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            Form mainForm = new frMain();
            mainForm.Show();
        }
=======
            string user_name = textBox1_tendangnhap.Text;
            string password = textBox3_typepassword.Text;

            if(user_name.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!");
                return;
            }

            else if(password.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }

            //else 
        }

        
>>>>>>> 52749a96e5c1555daecbd4db902cfd9e8bcd0b5f
    }
}
