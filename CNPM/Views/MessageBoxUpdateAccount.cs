using CNPM.Controller;
using CNPM.Model;
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
using System.Xml.Linq;

namespace CNPM.Views
{
    public partial class MessageBoxUpdateAccount : Form
    {
        public MessageBoxUpdateAccount()
        {
            InitializeComponent();
        }

        public MessageBoxUpdateAccount(string htmlLabel, string button, Account data)
        {

            InitializeComponent();
            lbTitle.Text = htmlLabel;
            btnSave.Text = button;
            txtEmail.Text = data.Email;
            txtRole.Text = data.Role;
            txtPass.Text = data.HashedPassword;
            txtUserName.Text = data.UserId;
            //linkImage.Text = data.AvatarUrl;
            //txtUserName.Enabled = true;
            //lbId.Visible = false;
        }
        private Image tempImage;
        private void btnSave_Click(object sender, EventArgs e)
        {

            Account data = new Account();
            data.HashedPassword = txtPass.Text;
            data.UserName = txtUserName.Text;
            data.Email = txtEmail.Text;
            data.Role = txtRole.Text;
            data.AvatarUrl = MyLib.ImageToBase64(tempImage, ImageFormat.Jpeg); 
            //data.AvatarUrl = linkImage.Text;
            ManagerAccountController.InitAccount(data);
            ManagerAccountController.updateAccount(data);
            this.Close();

        }
      
        
        private void linkImage_Click(object sender, EventArgs e)
        {
            string linkImage;
            tempImage = MyLib.openFileDialog();
            linkImage = MyLib.ImageToBase64(tempImage, ImageFormat.Jpeg);
            if (tempImage != null)
            {

            }
            PB.Image = MyLib.Base64ToImage(linkImage);

        }
        
        private void PB_Click(object sender, EventArgs e)
        {

        }
    }
}
