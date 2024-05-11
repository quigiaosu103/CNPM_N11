using CNPM.Controller;
using CNPM.Model;
using Guna.UI2.WinForms;
using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CNPM.Views
{
    public partial class frmMenuAdmin : Form
    {
        public frmMenuAdmin()
        {
            InitializeComponent();
            LoadTypes();
            LoadProducts();
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            txtUsername.Text = UserAuthen.currentUser.FullName;
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void cardView1_Load(object sender, EventArgs e)
        {

        }

        private void LoadTypes()
        {
            using (var context = new MyDatabaseContext())
            {
                var categories = context.Categories.ToList();
                selectType.DataSource = categories;
                selectType.ValueMember = "Id";
                selectType.DisplayMember = "Name";
            }
        }

        private void LoadProducts()
        {
            using (var context = new MyDatabaseContext())
            {
                var products = context.Products.Include(p => p.category).ToList();
                foreach (Product product in products)
                {
                    CardView item = MyLib.addNewProduct(product.Id + "", product.Name, product.Price, product.category, product.ImageUrl, product.Description);
                    flowLayoutPanel.Controls.Add(item);
                }
            }
        }


        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            int id = ProductController.GetNewProductId();
            string name = inputName.Text;
            string price = inputPrice.Text;
            string description = inputDescription.Text;
            Category type = selectType.SelectedItem as Category;
            if (tempImage != null
                && name != ""
                && price != ""
                && description != ""
                && type != null)
            {
                string imageSrting = MyLib.ImageToBase64(tempImage, ImageFormat.Jpeg);
                Product newItem = new Product()
                {
                    Id = id,
                    Name = name,
                    Price = Int32.Parse(price),
                    Description = description,
                    ImageUrl = imageSrting,
                    category = type
                };
                CardView item = MyLib.addNewProduct(id + "", name, Int32.Parse(price), type, imageSrting);
                flowLayoutPanel.Controls.Add(item);
                flowLayoutPanel.Controls.SetChildIndex(item, 0);
                ProductController.storeProduct(newItem);
                tempImage = null;
                MyLib.clearText(new Guna2TextBox[3] { inputName, inputPrice, inputDescription });
            }
            else
            {
                MyLib.AlertMessage("Fail to insert data");
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
                control.Controls["boundPanel"].Click += cardItemClicked;
            }
        }

        private void cardItemClicked(object sender, EventArgs e)
        {

            Guna2CustomGradientPanel panel = (Guna2CustomGradientPanel)sender;
            activeCardView = (CardView)panel.Parent;
            if (activeCardView.Controls["boundPanel"].Controls["txtProductName"] != null)
            {
                inputName.Text = activeCardView.Controls["boundPanel"].Controls["txtProductName"].Text;
            }
            if (activeCardView.Controls["boundPanel"].Controls["txtProductPrice"] != null)
            {
                inputPrice.Text = activeCardView.Controls["boundPanel"].Controls["txtProductPrice"].Text;
            }
            if (activeCardView.Controls["boundPanel"].Controls["txtproductCategory"] != null)
            {
                selectType.SelectedValue = activeCardView.cateId;
            }

        }

        private void selectType_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeSelectIndex = selectType.SelectedIndex;
        }



        private void onUpdateClick(Object sender, EventArgs e)
        {
            int id = Int32.Parse(activeCardView.productId);
            string name = inputName.Text;
            string price = inputPrice.Text;
            string description = inputDescription.Text;
            Category type = selectType.SelectedItem as Category;
            if (name != ""
                && price != ""
                && description != ""
                && type != null)
            {
                Product newItem = new Product()
                {
                    Id = id,
                    Name = name,
                    Price = Int32.Parse(price),
                    Description = description,
                    ImageUrl = "",
                    category = type
                };
                if (tempImage != null)
                {
                    newItem.ImageUrl = MyLib.ImageToBase64(tempImage, ImageFormat.Jpeg);

                }

                ProductController.updateProduct(newItem);
                CardView item = MyLib.updateProductView(activeCardView, newItem);
                MyLib.clearText(new Guna2TextBox[3] { inputName, inputPrice, inputDescription });
            }
            else
            {
                MyLib.AlertMessage("Fail to insert data");
            }

            activeCardView = null;
        }

        private CardView activeCardView;
        private int activeSelectIndex = 0;

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            if (activeCardView != null)
            {
                activeCardView.Hide();
                ProductController.removeProduct(activeCardView.productId);
                MyLib.clearText(new Guna2TextBox[3] { inputName, inputPrice, inputDescription });
            }
        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            string searchValue = inputSearchValue.Text.Trim();
            MyLib.searchProduct(searchValue, flowLayoutPanel);
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            LoadProducts();
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
