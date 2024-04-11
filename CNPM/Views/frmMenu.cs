﻿using CNPM.Controller;
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
                card.Controls["btnAdd"].Click += handleAddToCart;
            }
        }
      
        private void handleAddToCart(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                activeCard = button.Parent as CardView;
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
                paymentList.Add(new DataPayment() { idProduct = card.itemId, nameProduct = card.productName, priceProduct = card.itemPrice, numberProduct = card.itemAmount, priceProductTotal = card.totalPrice });
            }
            MyLib.InitUserProduct(paymentList);
        }



        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanelCart_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
