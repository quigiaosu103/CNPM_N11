using System.Runtime.CompilerServices;

using System.Net;
using System.Net.Mail;
using CNPM.Controller;
using System.Drawing;
using CNPM;


namespace DangKi__DangNhap__QuenMatKhau

{
    public partial class form_DangKi : Form
    {
        public form_DangKi()
        {
            InitializeComponent();
            SetUpFields();


        }

        private void SetUpFields()
        {
            txtOTP.Enabled = false;
            btnSignUp.Enabled = false;
            txtAlert.Hide();
        }

        private void dk_chonanh_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DangKi_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void form_anhdaidien_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_dangnhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form login = new form_DangNhap();
            if (login.ShowDialog() == DialogResult.OK)
            {
                Form main = new frMain();
                main.ShowDialog();
            }
            this.Close();
        }

        int vCode = 1000;
        private void button2_sendotp_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_user_TextChanged(object sender, EventArgs e)
        {

        }

        private void timvcode_Tick(object sender, EventArgs e)
        {
            vCode += 10;
            if (vCode == 9999)
            {
                vCode = 1000;
            }
        }

        private void textBox2_mail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_xacthuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_taotaikhoan_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            timvcode.Stop();
            string to, from, pass, mail;
            to = txtEmail.Text.Trim();
            if (to == "")
            {
                txtEmail.Focus();
                txtEmail.BorderColor = Color.Red;
                txtAlert.Show();
                txtAlert.Text = "Vui lòng điền email";
                return;
            }
            from = "leanhquan99982@gmail.com";
            mail = vCode.ToString();
            pass = "grmt hetg mfkc sxza";
            string verification_code = $"{DateTime.Now.Second}{DateTime.Now.Millisecond}";
            otp = verification_code;
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = "Mã xác thực của bạn là: " + verification_code;
            message.Subject = "WeFood - Mã xác thực";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Mã xác thực đã được gửi thành công, kiểm tra mail của bạn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtOTP.Enabled = true;
                btnSignUp.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text.Trim();
            string pass = MyLib.hashPassword(txtPass.Text.Trim());
            string confirmPass = MyLib.hashPassword(txtConfirmPass.Text.Trim());
            string inputOTP = txtOTP.Text.Trim();
            string email = txtEmail.Text.Trim();
            bool isAgree = cbxAgree.Checked;

            if (username == "")
            {
                txtUserName.Focus();
                txtAlert.Show();
                txtAlert.Text = "Vui lòng điền tên đăng nhập";
                return;
            }

            if (email == "")
            {
                txtEmail.Focus();
                txtAlert.Show();
                txtAlert.Text = "Vui lòng điền email";
                return;
            }
            if(pass == "")
            {
                txtPass.Focus();
                txtAlert.Show();
                txtAlert.Text = "Vui lòng điền mật khẩu";
                return;
            }
            if(confirmPass == "")
            {
                txtConfirmPass.Focus();
                txtAlert.Show();
                txtAlert.Text = "Vui lòng xác nhận mật khẩu";
                return;
            }
            if(!isAgree)
            {
                txtAlert.Show();
                txtAlert.Text = "Vui lòng ấn \"Tôi đã đồng ý điều khoản\"";
                return;
            }
            if(confirmPass!=pass)
            {
                txtAlert.Show();
                txtAlert.Text = "Mật khẩu không trùng khớp";
                return;
            }
            if(txtOTP.Text.Trim() != otp)
            {
                txtAlert.Show();
                txtAlert.Text = "OTP không đúng";
            }

            UserController.NewUAccount(username, pass, email);
            MessageBox.Show("Tạo tài khoản thành công!");

        }

        private string otp;

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            txtUserName.BorderColor = Color.BurlyWood;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            txtAlert.Hide();
        }

        private void txtOTP_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtAlert.Hide();
        }

        private void txtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            txtAlert.Hide();
        }
    }
}
