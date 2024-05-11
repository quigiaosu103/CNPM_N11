using CNPM.Controller;
using Guna.UI2.WinForms;
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
    public partial class CardView : UserControl
    {
        public string productId;
        public string description;
        public int cateId;

        public Image itemmImage
        {
            get { return itemImage.Image; }
            set { itemImage.Image = value; }
        }

        public string productName
        {
            get { return txtProductName.Text; }
            set { txtProductName.Text = value; }
        }

        public string productPrice
        {
            get { return txtProductPrice.Text; }
            set { txtProductPrice.Text = value; }
        }

        public string productCategory
        {
            get { return txtproductCategory.Text; }
            set { txtproductCategory.Text = value; }
        }

        public string addButton
        {
            get { return btnAdd.Text; }
            set { btnAdd.Text = value; }
        }

        public CardView()
        {
            InitializeComponent();
            if (UserAuthen.currentUser.Account.Role != "customer")
            {

                btnAdd.Hide();

            }

            txtProductName.MaximumSize = new System.Drawing.Size(134, 0);
            txtProductName.AutoSize = true;

        }

        private void txtProductName_Click(object sender, EventArgs e)
        {

            // MyLib.loadProductInfo(this.productId, this.productName, this,productPrice, this.productCategory);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void itemImage_Click(object sender, EventArgs e)
        {

        }

        private void CardView_Load(object sender, EventArgs e)
        {
            if (UserAuthen.currentUser.UserId == "admin")
            {
                btnAdd.Hide();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if(sender is Guna2ImageButton button)
            //{
            //    var card = button.Parent as CardView;
            //    var flowLayout = button.Parent.Parent as FlowLayoutPanel;
            //    var parent = button.Parent.Parent.Parent as CardView;

            //    MyLib.AlertMessage(parent.Name);
            //}
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}
