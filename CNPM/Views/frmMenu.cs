using CNPM.Controller;
using CNPM.Model;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CNPM.Views
{
    public partial class frmMenu : Form
    {
        public frMain _frMain;
        public MyLib myLib;
        public frmMenu()
        {
            InitializeComponent();
            LoadProduct();
            LoadUserInfo();
            var count = MyLib.checkList(UserListProduct.dataPayment);
            if (count > 0)
            {
                loadProduct();
            }

        }

        private void handleAddToCart(DataPayment data)
        {
            CartItemView cartItemView = new CartItemView();
            cartItemView.productName = data.nameProduct;
            cartItemView.itemId = data.idProduct;
            cartItemView.itemPrice = int.Parse(data.priceProduct.ToString());
            cartItemView.totalPrice = int.Parse(data.priceProductTotal.ToString());
            cartItemView.itemAmount = data.numberProduct;
            flowLayoutPanelCart.Controls.Add(cartItemView);
        }
        private void loadProduct()
        {


            List<DataPayment> data = UserListProduct.dataPayment;
            if (data != null)
            {
                foreach (DataPayment us in data)
                {
                    handleAddToCart(us);
                    //loadDataPayment();
                }
            }


        }

        private void LoadUserInfo()
        {
            txtAuthenName.Text = "Hi, " + UserAuthen.currentUser.FullName;
        }

        private void LoadProduct()
        {
            using (var context = new MyDatabaseContext())
            {
                var products = context.Products.Include(p => p.category).ToList();
                MyLib.setProductList(products, flowLayoutCustomer);
            }
        }

        private void searchProduct(object sender, EventArgs e)
        {
            string searchValue = inputSearchValue.Text.Trim();
            MyLib.searchProduct(searchValue, flowLayoutCustomer);
        }



        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutCustomer_Paint(object sender, PaintEventArgs e)
        {
            foreach (Control control in flowLayoutCustomer.Controls)
            {
                CardView card = (CardView)control;
                card.Controls["boundPanel"].Controls["btnAdd"].Click += handleAddToCart;
            }
        }

        private void handleAddToCart(object sender, EventArgs e)
        {
            if (sender is Guna2Button button)
            {
                activeCard = button.Parent.Parent as CardView;
                foreach (Control control in flowLayoutPanelCart.Controls)
                {
                    var card = (CartItemView)control;
                    if (activeCard.productId == card.itemId)
                    {
                        var numeric = (Guna2NumericUpDown)card.Controls["inputCartItemAmount"];
                        numeric.Value += 1;
                        return;
                    }
                }
                CartItemView cartItemView = new CartItemView();
                cartItemView.productName = activeCard.productName;
                cartItemView.itemId = activeCard.productId;
                cartItemView.itemPrice = int.Parse(activeCard.productPrice);
                cartItemView.totalPrice = int.Parse(activeCard.productPrice);
                cartItemView.itemAmount = 1;
                flowLayoutPanelCart.Controls.Add(cartItemView);

            }
        }

        private CardView activeCard;

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            
            List<DataPayment> paymentList = new List<DataPayment>();
            foreach (Control control in flowLayoutPanelCart.Controls)
            {
                CartItemView card = (CartItemView)control;
                
                //paymentList.Add(new DataPayment() { idProduct = card.itemId, nameProduct = card.productName, priceProduct = card.itemPrice, numberProduct = card.itemAmount, priceProductTotal = card.totalPrice });
                paymentList.Add(new DataPayment() { idProduct = card.itemId, nameProduct = MyLib.getProductName(card.itemId), priceProduct = card.itemPrice, numberProduct = card.itemAmount, priceProductTotal = card.totalPrice });
                //MessageBox.Show(card.productName.ToString());
            }
            MyLib.InitUserProduct(paymentList);
            if(sender is Guna2GradientButton btn)
            {
                var mainForm = btn.Parent.Parent.Parent.Parent.Parent as frMain;
                if (mainForm != null)
                    mainForm.openCurrentForm(new frmPayment());
                else
                {
                    MyLib.AlertMessage("null");
                }
            }else
            {
                MyLib.AlertMessage("not a btn");
            }
        }



        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelCart_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelCart_EnabledChanged(object sender, EventArgs e)
        {
            int rows = MyLib.GetRowCount(flowLayoutPanelCart);
            MessageBox.Show(rows.ToString());
        }
    }
}
