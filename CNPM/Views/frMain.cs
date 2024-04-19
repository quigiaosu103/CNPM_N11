using CNPM.Controller;
using CNPM.Model;
using CNPM.VIew;
using CNPM.Views;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace CNPM
{
    public partial class frMain : Form
    {
        public Form currentForm;
        public List<DataPayment> paymentList = new List<DataPayment>();
        public frMain()
        {
            InitializeComponent();
            MyLib.InitUser();
          
        }
   
        
        public void openCurrentForm(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            bodyPanel.Controls.Add(form);
            bodyPanel.Tag = form;
            form.BringToFront();
            form.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            openCurrentForm(new frmTrangChu());
        }

        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            openCurrentForm(new frmManagerAccount());
        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            openCurrentForm(new frmEmployee());
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            openCurrentForm(new frmHistory());
        }

        private void btnThucDon_Click(object sender, EventArgs e)
        {
            if (UserAuthen.currentUser.UserId == "admin")
            {
                openCurrentForm(new frmMenuAdmin());
            }
            else
            {
                openCurrentForm(new frmMenu());
            }
        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            openCurrentForm(new frmAccount());
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            openCurrentForm(new frmDiary());
        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

            openCurrentForm(new frmPayment());
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}