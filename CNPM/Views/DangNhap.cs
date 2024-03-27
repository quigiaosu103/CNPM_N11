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
            form_DangKi dangKi = new form_DangKi();
            dangKi.ShowDialog();
        }

        private void button1_dangnhapbtn_Click(object sender, EventArgs e)
        {
            Form mainForm = new frMain();
            mainForm.Show();
        }
    }
}
