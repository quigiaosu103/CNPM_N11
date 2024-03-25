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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            itemImage = new Guna2PictureBox();
            txtProductName = new Guna2HtmlLabel();
            txtProductPrice = new Guna2HtmlLabel();
            txtproductCategory = new Guna2HtmlLabel();
            btnAdd = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)itemImage).BeginInit();
            SuspendLayout();
            // 
            // itemImage
            // 
            itemImage.BackColor = SystemColors.Highlight;
            itemImage.BackgroundImage = Properties.Resources.icons8_card_100;
            itemImage.BorderStyle = BorderStyle.FixedSingle;
            itemImage.CustomizableEdges = customizableEdges1;
            itemImage.ImageRotate = 0F;
            itemImage.Location = new Point(3, 3);
            itemImage.Name = "itemImage";
            itemImage.ShadowDecoration.CustomizableEdges = customizableEdges2;
            itemImage.Size = new Size(201, 137);
            itemImage.TabIndex = 0;
            itemImage.TabStop = false;
            itemImage.Click += itemImage_Click;
            // 
            // txtProductName
            // 
            txtProductName.BackColor = Color.Transparent;
            txtProductName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductName.Location = new Point(3, 153);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(99, 19);
            txtProductName.TabIndex = 1;
            txtProductName.Text = "Banh abc vi bcd";
            txtProductName.TextAlignment = ContentAlignment.MiddleCenter;
            txtProductName.Click += txtProductName_Click;
            // 
            // txtProductPrice
            // 
            txtProductPrice.Anchor = AnchorStyles.Right;
            txtProductPrice.BackColor = Color.Transparent;
            txtProductPrice.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            txtProductPrice.Location = new Point(154, 153);
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
            txtproductCategory.Location = new Point(3, 178);
            txtproductCategory.Name = "txtproductCategory";
            txtproductCategory.Size = new Size(50, 17);
            txtproductCategory.TabIndex = 3;
            txtproductCategory.Text = "Category";
            txtproductCategory.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.IconChar = FontAwesome.Sharp.IconChar.None;
            btnAdd.IconColor = Color.Black;
            btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdd.Location = new Point(146, 178);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(58, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // CardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAdd);
            Controls.Add(txtproductCategory);
            Controls.Add(txtProductPrice);
            Controls.Add(txtProductName);
            Controls.Add(itemImage);
            ForeColor = Color.FromArgb(45, 67, 112);
            Name = "CardView";
            Size = new Size(207, 209);
            Load += CardView_Load;
            ((System.ComponentModel.ISupportInitialize)itemImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox itemImage;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtProductName;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtProductPrice;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtproductCategory;
        private FontAwesome.Sharp.IconButton btnAdd;
    }
}
