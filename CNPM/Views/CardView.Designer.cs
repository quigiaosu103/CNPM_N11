using Guna.UI2.WinForms;

namespace CNPM.Views
{
    partial class CardView
    {

        
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardView));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            itemImage = new Guna2PictureBox();
            txtProductName = new Guna2HtmlLabel();
            txtProductPrice = new Guna2HtmlLabel();
            txtproductCategory = new Guna2HtmlLabel();
            btnAdd = new Guna2Button();
            boundPanel = new Guna2CustomGradientPanel();
            ((System.ComponentModel.ISupportInitialize)itemImage).BeginInit();
            boundPanel.SuspendLayout();
            SuspendLayout();
            // 
            // itemImage
            // 
            itemImage.BackColor = Color.Transparent;
            itemImage.BorderRadius = 4;
            itemImage.CustomizableEdges = customizableEdges1;
            itemImage.Image = (Image)resources.GetObject("itemImage.Image");
            itemImage.ImageRotate = 0F;
            itemImage.Location = new Point(6, 4);
            itemImage.Name = "itemImage";
            itemImage.ShadowDecoration.CustomizableEdges = customizableEdges2;
            itemImage.Size = new Size(201, 137);
            itemImage.SizeMode = PictureBoxSizeMode.StretchImage;
            itemImage.TabIndex = 0;
            itemImage.TabStop = false;
            itemImage.Click += itemImage_Click;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.Transparent;
            txtProductName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductName.ForeColor = Color.FromArgb(219, 144, 76);
            txtProductName.Location = new Point(6, 144);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(133, 19);
            txtProductName.TabIndex = 1;
            txtProductName.Text = "Banh abc vi bcd dasd";
            txtProductName.TextAlignment = ContentAlignment.MiddleCenter;
            txtProductName.Click += txtProductName_Click;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Anchor = AnchorStyles.Right;
            txtProductPrice.BackColor = Color.Transparent;
            txtProductPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductPrice.ForeColor = Color.FromArgb(219, 144, 76);
            txtProductPrice.Location = new Point(155, 145);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(50, 19);
            txtProductPrice.TabIndex = 2;
            txtProductPrice.Text = "23000\r\n d";
            txtProductPrice.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // txtproductCategory
            // 
            txtproductCategory.BackColor = Color.Transparent;
            txtproductCategory.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtproductCategory.Location = new Point(7, 175);
            txtproductCategory.Name = "txtproductCategory";
            txtproductCategory.Size = new Size(50, 17);
            txtproductCategory.TabIndex = 3;
            txtproductCategory.Text = "Category";
            txtproductCategory.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.BorderRadius = 4;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.CustomizableEdges = customizableEdges3;
            btnAdd.DisabledState.BorderColor = Color.DarkGray;
            btnAdd.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdd.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdd.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdd.FillColor = Color.FromArgb(219, 144, 76);
            btnAdd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(140, 174);
            btnAdd.Name = "btnAdd";
            btnAdd.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnAdd.Size = new Size(65, 23);
            btnAdd.TabIndex = 28;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click_1;
            // 
            // boundPanel
            // 
            boundPanel.BorderColor = Color.FromArgb(219, 144, 76);
            boundPanel.BorderRadius = 4;
            boundPanel.BorderThickness = 1;
            boundPanel.Controls.Add(itemImage);
            boundPanel.Controls.Add(txtProductPrice);
            boundPanel.Controls.Add(btnAdd);
            boundPanel.Controls.Add(txtproductCategory);
            boundPanel.Controls.Add(txtProductName);
            boundPanel.CustomizableEdges = customizableEdges5;
            boundPanel.Location = new Point(3, 6);
            boundPanel.Name = "boundPanel";
            boundPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            boundPanel.Size = new Size(213, 204);
            boundPanel.TabIndex = 29;
            // 
            // CardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(boundPanel);
            ForeColor = Color.FromArgb(45, 67, 112);
            Name = "CardView";
            Size = new Size(220, 216);
            Load += CardView_Load;
            ((System.ComponentModel.ISupportInitialize)itemImage).EndInit();
            boundPanel.ResumeLayout(false);
            boundPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox itemImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtProductName;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtProductPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtproductCategory;
        private Guna2Button btnAdd;
        private Guna2CustomGradientPanel boundPanel;
    }
}
