using CNPM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CNPM.Controller;
namespace CNPM.Views
{
    public partial class frmPayment : Form
    {
        PaymentController controller = new PaymentController();

        MyDatabaseContext databaseContext = new MyDatabaseContext();
        public frmPayment()
        {
            InitializeComponent();
            controller.dsSanPham(dsSanPham, txtTotal, txtVAT, txtDiscount, txtFinalTotal);
            //btnDeletePayment.HeaderText = "";
            //btnDeletePayment.Width = 30;
        }



        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmPayment_Load(object sender, EventArgs e)
        {


        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            txtDiscount.Text = controller.getCodeDiscount(txtCodeDiscount).ToString() + "%";
            controller.getFinalTotal(txtTotal, txtVAT, txtDiscount, txtFinalTotal);
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            controller.getBill(txtTotal, txtVAT, txtDiscount, txtFinalTotal, lbNamePayment, lbPhonePayment, lbAddressPayment);
        }

        private void dsSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //btnEdits
        }
    }
}
