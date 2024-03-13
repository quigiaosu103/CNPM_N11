using CNPM.VIew;
using CNPM.Views;
using System.Windows.Forms;

namespace CNPM
{
    public partial class frMain : Form
    {
        public frMain()
        {
            InitializeComponent();
        }

        private Form currentForm;

        private void openCurrentForm(Form form)
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
            openCurrentForm(new frmMenuAdmin());
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
    }
}