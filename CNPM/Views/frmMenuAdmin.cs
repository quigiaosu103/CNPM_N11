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
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void cardView1_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            CardView item = MyLib.addNewProduct("Bánh quy hồi sức", 200000, "Bánh ngọt", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTPZMaHKjcxIEV3i5-2IImdnH1PlJfCCT7bXQ&usqp=CAU");
            flowLayoutPanel.Controls.Add(item);

        }
    }
}
