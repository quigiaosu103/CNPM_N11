namespace CNPM.Views
{
    partial class CartItemPaymentView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            txtCartItemName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            inputCartItemAmount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            txtCartItemTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnRemoveItem = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)inputCartItemAmount).BeginInit();
            SuspendLayout();
            // 
            // txtCartItemName
            // 
            txtCartItemName.BackColor = Color.Transparent;
            txtCartItemName.Location = new Point(28, 12);
            txtCartItemName.Name = "txtCartItemName";
            txtCartItemName.Size = new Size(52, 17);
            txtCartItemName.TabIndex = 0;
            txtCartItemName.Text = "Tên bánh";
            // 
            // inputCartItemAmount
            // 
            inputCartItemAmount.BackColor = Color.Transparent;
            inputCartItemAmount.CustomizableEdges = customizableEdges1;
            inputCartItemAmount.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            inputCartItemAmount.Location = new Point(301, 7);
            inputCartItemAmount.Name = "inputCartItemAmount";
            inputCartItemAmount.ShadowDecoration.CustomizableEdges = customizableEdges2;
            inputCartItemAmount.Size = new Size(100, 27);
            inputCartItemAmount.TabIndex = 1;
            inputCartItemAmount.ValueChanged += inputCartItemAmount_ValueChanged_1;
            // 
            // txtCartItemTotal
            // 
            txtCartItemTotal.BackColor = Color.Transparent;
            txtCartItemTotal.Location = new Point(489, 12);
            txtCartItemTotal.Name = "txtCartItemTotal";
            txtCartItemTotal.Size = new Size(45, 17);
            txtCartItemTotal.TabIndex = 2;
            txtCartItemTotal.Text = "0000000";
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.CheckedState.ImageSize = new Size(64, 64);
            btnRemoveItem.HoverState.ImageSize = new Size(64, 64);
            btnRemoveItem.Image = Properties.Resources.icons8_menu_501;
            btnRemoveItem.ImageOffset = new Point(0, 0);
            btnRemoveItem.ImageRotate = 0F;
            btnRemoveItem.Location = new Point(565, 12);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.PressedState.ImageSize = new Size(64, 64);
            btnRemoveItem.ShadowDecoration.CustomizableEdges = customizableEdges3;
            btnRemoveItem.Size = new Size(25, 17);
            btnRemoveItem.TabIndex = 3;
            btnRemoveItem.Click += btnRemoveItem_Click_1;
            // 
            // CartItemPaymentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRemoveItem);
            Controls.Add(txtCartItemTotal);
            Controls.Add(inputCartItemAmount);
            Controls.Add(txtCartItemName);
            Name = "CartItemPaymentView";
            Size = new Size(602, 42);
            ((System.ComponentModel.ISupportInitialize)inputCartItemAmount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel txtCartItemName;
        private Guna.UI2.WinForms.Guna2NumericUpDown inputCartItemAmount;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtCartItemTotal;
        private Guna.UI2.WinForms.Guna2ImageButton btnRemoveItem;
    }
}
