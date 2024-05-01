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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string oldPass = MyLib.hashPassword(txtOldPass.Text.Trim());
            string newPass = MyLib.hashPassword(txtNewPass.Text.Trim());
            string confirmPass = MyLib.hashPassword(txtConfirmPass.Text.Trim());
            if(confirmPass == newPass)
            {
                if (UserController.CheckAndUpdatePassword(
                    UserAuthen.currentUser.Account.UserName, oldPass, newPass)
                 )
                {
                    MyLib.AlertMessage("Đổi mật khẩu thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MyLib.AlertMessage("Mật khẩu không đúng!");
                }
            }else
            {
                MyLib.AlertMessage("Mật khẩu không trùng khớp!");
            }
                
         
        }
    }
}
