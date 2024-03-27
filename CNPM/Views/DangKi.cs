using System.Runtime.CompilerServices;

using System.Net;
using System.Net.Mail;



namespace DangKi__DangNhap__QuenMatKhau

{
    public partial class form_DangKi : Form
    {
        public form_DangKi()
        {
            InitializeComponent();


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
            this.Hide();
            form_DangNhap dangNhap = new form_DangNhap();
            dangNhap.ShowDialog();
            this.Close();
        }

        int vCode = 1000;
        private void button2_sendotp_Click(object sender, EventArgs e)
        {
            timvcode.Stop();
            string to, from, pass, mail;
            to = textBox2_mail.Text;
            from = "leanhquan99982@gmail.com";
            mail = vCode.ToString();
            pass = "grmt hetg mfkc sxza";
            string verification_code = $"{DateTime.Now.Second}{DateTime.Now.Millisecond}";
            MailMessage message = new MailMessage();
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = "Ma xac thuc cua ban la: " + verification_code;
            message.Subject = "Tiem Banh - Ma xac thuc";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);
            try
            {
                smtp.Send(message);
                MessageBox.Show("Ma xac thuc da duoc gui thanh cong! Hay kiem tra email cua ban", "Thong tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1_xacthuc.Enabled = true;
                button1_taotaikhoan.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
