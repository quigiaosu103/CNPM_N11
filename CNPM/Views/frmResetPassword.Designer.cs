namespace CNPM.Views
{
    partial class frmResetPassword
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            txtConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            txtAlert = new Guna.UI2.WinForms.Guna2HtmlLabel();
            SuspendLayout();
            // 
            // guna2Button1
            // 
            guna2Button1.BorderRadius = 4;
            guna2Button1.CustomizableEdges = customizableEdges1;
            guna2Button1.DisabledState.BorderColor = Color.DarkGray;
            guna2Button1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button1.FillColor = Color.FromArgb(96, 56, 20);
            guna2Button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            guna2Button1.ForeColor = Color.White;
            guna2Button1.Location = new Point(52, 174);
            guna2Button1.Name = "guna2Button1";
            guna2Button1.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2Button1.Size = new Size(107, 36);
            guna2Button1.TabIndex = 16;
            guna2Button1.Text = "Cập nhật";
            guna2Button1.Click += guna2Button1_Click;
            // 
            // guna2HtmlLabel4
            // 
            guna2HtmlLabel4.BackColor = Color.Transparent;
            guna2HtmlLabel4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel4.ForeColor = Color.FromArgb(96, 56, 20);
            guna2HtmlLabel4.Location = new Point(12, 80);
            guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            guna2HtmlLabel4.Size = new Size(115, 19);
            guna2HtmlLabel4.TabIndex = 15;
            guna2HtmlLabel4.Text = "Nhập lại mật khẩu";
            // 
            // guna2HtmlLabel3
            // 
            guna2HtmlLabel3.BackColor = Color.Transparent;
            guna2HtmlLabel3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel3.ForeColor = Color.FromArgb(96, 56, 20);
            guna2HtmlLabel3.Location = new Point(13, 11);
            guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            guna2HtmlLabel3.Size = new Size(88, 19);
            guna2HtmlLabel3.TabIndex = 14;
            guna2HtmlLabel3.Text = "Mật khẩu mới";
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.BorderColor = Color.BurlyWood;
            txtConfirmPass.BorderRadius = 4;
            txtConfirmPass.CustomizableEdges = customizableEdges3;
            txtConfirmPass.DefaultText = "";
            txtConfirmPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConfirmPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConfirmPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPass.ForeColor = Color.FromArgb(96, 56, 20);
            txtConfirmPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmPass.Location = new Point(12, 104);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.PlaceholderText = "";
            txtConfirmPass.SelectedText = "";
            txtConfirmPass.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtConfirmPass.Size = new Size(200, 36);
            txtConfirmPass.TabIndex = 12;
            txtConfirmPass.TextChanged += txtConfirmPass_TextChanged;
            // 
            // txtNewPass
            // 
            txtNewPass.BorderColor = Color.BurlyWood;
            txtNewPass.BorderRadius = 4;
            txtNewPass.CustomizableEdges = customizableEdges5;
            txtNewPass.DefaultText = "";
            txtNewPass.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtNewPass.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtNewPass.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtNewPass.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtNewPass.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNewPass.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtNewPass.ForeColor = Color.FromArgb(96, 56, 20);
            txtNewPass.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtNewPass.Location = new Point(12, 34);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '*';
            txtNewPass.PlaceholderText = "";
            txtNewPass.SelectedText = "";
            txtNewPass.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtNewPass.Size = new Size(200, 36);
            txtNewPass.TabIndex = 11;
            // 
            // txtAlert
            // 
            txtAlert.BackColor = Color.Transparent;
            txtAlert.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtAlert.ForeColor = Color.IndianRed;
            txtAlert.Location = new Point(12, 148);
            txtAlert.Name = "txtAlert";
            txtAlert.Size = new Size(152, 15);
            txtAlert.TabIndex = 17;
            txtAlert.Text = "Mật khẩu không trùng khớp";
            // 
            // frmResetPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtAlert);
            Controls.Add(guna2Button1);
            Controls.Add(guna2HtmlLabel4);
            Controls.Add(guna2HtmlLabel3);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtNewPass);
            Name = "frmResetPassword";
            Size = new Size(230, 230);
            Load += frmResetPassword_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPass;
        private Guna.UI2.WinForms.Guna2TextBox txtNewPass;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtAlert;
    }
}
