using CNPM.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {

            txtUserAuthenName.Text = "Hi, " + UserAuthen.currentUser.FullName;
            inputAddress.Text = UserAuthen.currentUser.Address;
            inputFullName.Text = UserAuthen.currentUser.FullName;
            inputPhone.Text = UserAuthen.currentUser.PhoneNumber;
            inputBirthDay.Value = UserAuthen.currentUser.BirthDay;
            //MessageBox.Show(UserAuthen.Email.ToString());
            inputMail.Text = UserAuthen.Email;
            selectGender.SelectedIndex = UserAuthen.currentUser.Gender;
            var base64 = UserAuthen.currentUser.Account.AvatarUrl;
            if (base64 != "")
            {
                Image avt = MyLib.Base64ToImage(base64);
                imgAvatar.Image = avt;
                currImage = MyLib.ImageToBase64(avt, ImageFormat.Jpeg);
            }

            txtUserName.Text = UserAuthen.currentUser.Account.UserName;

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
            currImage = MyLib.ImageToBase64(image, ImageFormat.Jpeg);
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
            DateTime birDay = inputBirthDay.Value;

            if (name.Trim() == "")
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
            MyLib.updateUserInfo(new string[4] { name, phone, address, currImage }, selectGender.SelectedIndex, birDay);
            LoadUserInfo();

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel13_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            Form changePassForm = new ChangePassword();
            if (changePassForm.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private string currImage = "";

        private void selectGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
