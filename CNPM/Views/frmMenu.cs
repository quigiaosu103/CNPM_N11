using CNPM.Controller;
using CNPM.Model;
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

namespace CNPM.Views
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            LoadProduct();

        }

        private void LoadProduct()
        {
            using (var context = new MyDatabaseContext())
            {
                var products = context.Products.Include(p => p.category).ToList();
                setProductList(products);
            }
        }

        private void searchProduct(object sender, EventArgs e)
        {
            string keyword = inputSearchValue.Text.Trim();
            if(!(keyword == ""))
            {
                using (var context = new MyDatabaseContext())
                {
                    var products = context.Products
                        .Include(p => p.category)
                        .Where(pr => pr.Name
                        .Contains(keyword) || pr.category.Name.Contains(keyword)).ToList();
                    setProductList(products);
                }
            }
        }

        private void setProductList(List<Product> list)
        {
            flowLayoutCustomer.Controls.Clear();
            foreach (Product product in list)
            {
                for (int i = 0; i < 5; i++)
                {
                    CardView item = MyLib.addNewProduct(product.Id + "", product.Name, product.Price, product.category, product.ImageUrl, product.Description);
                    flowLayoutCustomer.Controls.Add(item);
                }
            }
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
                CartItemView cartItemView = new CartItemView();
                cartItemView.productName = activeCard.productName;
                cartItemView.itemId = activeCard.productId;
                cartItemView.itemPrice = Int32.Parse(activeCard.productPrice);
                cartItemView.totalPrice = Int32.Parse(activeCard.productPrice);
                cartItemView.itemAmount = 1;
                flowLayoutPanelCart.Controls.Add(cartItemView);
            }
           

        }

        private CardView activeCard;
    }
}
