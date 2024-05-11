namespace CNPM.Views
{
    partial class CartItemView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartItemView));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtCartItemName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtCartItemTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnRemoveItem = new Guna.UI2.WinForms.Guna2ImageButton();
            inputCartItemAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)inputCartItemAmount).BeginInit();
            SuspendLayout();
            // 
            // txtCartItemName
            // 
            txtCartItemName.BackColor = Color.Transparent;
            txtCartItemName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCartItemName.Location = new Point(3, 10);
            txtCartItemName.Name = "txtCartItemName";
            txtCartItemName.Size = new Size(53, 19);
            txtCartItemName.TabIndex = 0;
            txtCartItemName.Text = "Bánh mì";
            // 
            // txtCartItemTotal
            // 
            txtCartItemTotal.BackColor = Color.Transparent;
            txtCartItemTotal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            txtCartItemTotal.Location = new Point(166, 10);
            txtCartItemTotal.Name = "txtCartItemTotal";
            txtCartItemTotal.Size = new Size(43, 19);
            txtCartItemTotal.TabIndex = 1;
            txtCartItemTotal.Text = "100000";
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.CheckedState.ImageSize = new Size(16, 16);
            btnRemoveItem.Cursor = Cursors.Hand;
            btnRemoveItem.HoverState.ImageSize = new Size(16, 16);
            btnRemoveItem.Image = (Image)resources.GetObject("btnRemoveItem.Image");
            btnRemoveItem.ImageOffset = new Point(0, 0);
            btnRemoveItem.ImageRotate = 0F;
            btnRemoveItem.ImageSize = new Size(16, 16);
            btnRemoveItem.Location = new Point(215, 13);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.PressedState.ImageSize = new Size(16, 16);
            btnRemoveItem.ShadowDecoration.CustomizableEdges = customizableEdges1;
            btnRemoveItem.Size = new Size(16, 16);
            btnRemoveItem.TabIndex = 2;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // inputCartItemAmount
            // 
            inputCartItemAmount.BackColor = Color.Transparent;
            inputCartItemAmount.CustomizableEdges = customizableEdges2;
            inputCartItemAmount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inputCartItemAmount.Location = new Point(86, 7);
            inputCartItemAmount.Name = "inputCartItemAmount";
            inputCartItemAmount.ShadowDecoration.CustomizableEdges = customizableEdges3;
            inputCartItemAmount.Size = new Size(54, 26);
            inputCartItemAmount.TabIndex = 3;
            inputCartItemAmount.ValueChanged += inputCartItemAmount_ValueChanged;
            // 
            // CartItemView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtCartItemTotal);
            Controls.Add(inputCartItemAmount);
            Controls.Add(btnRemoveItem);
            Controls.Add(txtCartItemName);
            Name = "CartItemView";
            Size = new Size(235, 38);
            Load += CartItemView_Load;
            ((System.ComponentModel.ISupportInitialize)inputCartItemAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel txtCartItemName;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtCartItemTotal;
        private Guna.UI2.WinForms.Guna2ImageButton btnRemoveItem;
        private Guna.UI2.WinForms.Guna2NumericUpDown inputCartItemAmount;
    }
}
