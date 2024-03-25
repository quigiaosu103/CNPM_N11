using CNPM.Controller;
using Guna.UI2.WinForms;
using Microsoft.Win32;
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
            string id = "dsa";
            string name = inputName.Text;
            string price = inputPrice.Text;
            string description = inputDescription.Text;
            string type = inputType.Text;
            if (tempImage != null
                && name != ""
                && price != ""
                && description != ""
                && type != "")
            {
                CardView item = MyLib.addNewProduct(id, name, Int32.Parse(price), type, tempImage);
                flowLayoutPanel.Controls.Add(item);
                MyLib.clearText(new Guna2TextBox[4] { inputName, inputPrice, inputDescription, inputType });

                //handle insert database
            }
            else
            {
                Form f = new Form();
                Label lab = new Label();
                lab.Text = "fail to insert!";
                f.Controls.Add(lab);
                f.ShowDialog();
            }

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            tempImage = MyLib.openFileDialog();
            if (tempImage != null)
            {

            }
        }
        private Image tempImage;

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control control in flowLayoutPanel.Controls)
            {
                control.Click += cardItemClicked;
            }
        }
        
        private void cardItemClicked(object sender, EventArgs e)
        {
            CardView control = (CardView)sender;
            if (control.Controls["txtProductName"] !=null)
            {
                inputName.Text = control.Controls["txtProductName"].Text;
            }
            if (control.Controls["txtProductPrice"] != null)
            {
                inputPrice.Text = control.Controls["txtProductPrice"].Text;
            }
            if (control.Controls["txtproductCategory"] != null)
            {
                inputType.Text = control.Controls["txtproductCategory"].Text;
            }
            
        }
    }
}
