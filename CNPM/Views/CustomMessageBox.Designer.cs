namespace CNPM.Views
{
    partial class CustomMessageBox
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            btnClose = new Guna.UI2.WinForms.Guna2GradientButton();
            lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lbError = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(components);
            guna2CustomGradientPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2CustomGradientPanel1
            // 
            guna2CustomGradientPanel1.BackColor = Color.Transparent;
            guna2CustomGradientPanel1.BorderColor = Color.BurlyWood;
            guna2CustomGradientPanel1.BorderRadius = 4;
            guna2CustomGradientPanel1.BorderThickness = 1;
            guna2CustomGradientPanel1.Controls.Add(btnClose);
            guna2CustomGradientPanel1.Controls.Add(lbName);
            guna2CustomGradientPanel1.Controls.Add(lbError);
            guna2CustomGradientPanel1.Controls.Add(guna2ControlBox1);
            guna2CustomGradientPanel1.CustomizableEdges = customizableEdges5;
            guna2CustomGradientPanel1.Dock = DockStyle.Fill;
            guna2CustomGradientPanel1.FillColor = Color.FromArgb(241, 232, 216);
            guna2CustomGradientPanel1.FillColor2 = Color.FromArgb(241, 232, 216);
            guna2CustomGradientPanel1.FillColor3 = Color.FromArgb(241, 232, 216);
            guna2CustomGradientPanel1.FillColor4 = Color.FromArgb(241, 232, 216);
            guna2CustomGradientPanel1.Location = new Point(0, 0);
            guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            guna2CustomGradientPanel1.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2CustomGradientPanel1.Size = new Size(277, 199);
            guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Wheat;
            btnClose.BorderColor = Color.FromArgb(96, 56, 20);
            btnClose.BorderRadius = 4;
            btnClose.Cursor = Cursors.Hand;
            btnClose.CustomizableEdges = customizableEdges1;
            btnClose.DisabledState.BorderColor = Color.DarkGray;
            btnClose.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClose.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            btnClose.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClose.FillColor = Color.FromArgb(96, 56, 20);
            btnClose.FillColor2 = Color.FromArgb(96, 56, 20);
            btnClose.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(84, 155);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnClose.Size = new Size(99, 25);
            btnClose.TabIndex = 3;
            btnClose.Text = "Đóng";
            btnClose.Click += btnClose_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = false;
            lbName.BackColor = Color.Transparent;
            lbName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbName.ForeColor = Color.FromArgb(96, 56, 20);
            lbName.Location = new Point(3, 95);
            lbName.Name = "lbName";
            lbName.Size = new Size(274, 53);
            lbName.TabIndex = 2;
            lbName.Text = "Địa chỉ người nhận";
            lbName.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lbError
            // 
            lbError.AutoSize = false;
            lbError.BackColor = Color.Transparent;
            lbError.BackgroundImageLayout = ImageLayout.None;
            lbError.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbError.ForeColor = Color.FromArgb(96, 56, 20);
            lbError.Location = new Point(0, 43);
            lbError.Name = "lbError";
            lbError.Size = new Size(277, 47);
            lbError.TabIndex = 1;
            lbError.Text = "Thông tin nhập sai";
            lbError.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // guna2ControlBox1
            // 
            guna2ControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            guna2ControlBox1.BackColor = Color.Wheat;
            guna2ControlBox1.BorderColor = Color.Transparent;
            guna2ControlBox1.BorderRadius = 4;
            guna2ControlBox1.CustomizableEdges = customizableEdges3;
            guna2ControlBox1.FillColor = Color.FromArgb(96, 56, 20);
            guna2ControlBox1.IconColor = Color.White;
            guna2ControlBox1.Location = new Point(229, 4);
            guna2ControlBox1.Name = "guna2ControlBox1";
            guna2ControlBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ControlBox1.Size = new Size(44, 33);
            guna2ControlBox1.TabIndex = 0;
            // 
            // guna2DragControl1
            // 
            guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            guna2DragControl1.UseTransparentDrag = true;
            // 
            // CustomMessageBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(277, 199);
            Controls.Add(guna2CustomGradientPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomMessageBox";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CustomMessageBox";
            guna2CustomGradientPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbError;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private Guna.UI2.WinForms.Guna2GradientButton btnClose;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}