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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectAvatar_Click(object sender, EventArgs e)
        {
            var image = MyLib.openFileDialog();
            if (image != null)
            {
                imgAvatar.Image = image;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string name = inputFullName.Text;
            string gen = selectGender.Text;
            string phone = inputPhone.Text;
            string mail = inputMail.Text;
            string address = inputAddress.Text;
            if(name.Trim() == "")
            {
                inputFullName.Focus();
                return;
            }
            if (phone.Trim() == "")
            {
                inputPhone.Focus();
                return;
            }
            if (address.Trim() == "")
            {
                inputAddress.Focus();
                return;
            }
            if (mail.Trim() == "")
            {
                inputMail.Focus();
                return;
            }
            MyLib

        }
    }
}
