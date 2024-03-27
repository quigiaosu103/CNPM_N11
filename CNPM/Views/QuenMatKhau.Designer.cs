namespace DangKi__DangNhap__QuenMatKhau
{
    partial class form_QuenMatKhau
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
            label1_quenmatkhau = new Label();
            label2_emaildadangki = new Label();
            textBox1_typeemail = new TextBox();
            button1_laylaimatkhau = new Button();
            SuspendLayout();
            // 
            // label1_quenmatkhau
            // 
            label1_quenmatkhau.AutoSize = true;
            label1_quenmatkhau.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1_quenmatkhau.ForeColor = Color.FromArgb(138, 76, 20);
            label1_quenmatkhau.Location = new Point(305, 48);
            label1_quenmatkhau.Name = "label1_quenmatkhau";
            label1_quenmatkhau.Size = new Size(195, 31);
            label1_quenmatkhau.TabIndex = 0;
            label1_quenmatkhau.Text = "Quên mật khẩu";
            label1_quenmatkhau.TextAlign = ContentAlignment.MiddleCenter;
            label1_quenmatkhau.Click += label1_quenmatkhau_Click;
            // 
            // label2_emaildadangki
            // 
            label2_emaildadangki.AutoSize = true;
            label2_emaildadangki.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2_emaildadangki.Location = new Point(245, 144);
            label2_emaildadangki.Name = "label2_emaildadangki";
            label2_emaildadangki.Size = new Size(332, 31);
            label2_emaildadangki.TabIndex = 1;
            label2_emaildadangki.Text = "Email đã đăng kí tài khoản";
            label2_emaildadangki.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1_typeemail
            // 
            textBox1_typeemail.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1_typeemail.Location = new Point(214, 216);
            textBox1_typeemail.Name = "textBox1_typeemail";
            textBox1_typeemail.Size = new Size(375, 41);
            textBox1_typeemail.TabIndex = 2;
            // 
            // button1_laylaimatkhau
            // 
            button1_laylaimatkhau.Cursor = Cursors.Hand;
            button1_laylaimatkhau.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1_laylaimatkhau.Location = new Point(279, 322);
            button1_laylaimatkhau.Name = "button1_laylaimatkhau";
            button1_laylaimatkhau.Size = new Size(245, 53);
            button1_laylaimatkhau.TabIndex = 3;
            button1_laylaimatkhau.Text = "Lấy lại mật khẩu";
            button1_laylaimatkhau.UseVisualStyleBackColor = true;
            // 
            // form_QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(217, 132, 28);
            ClientSize = new Size(800, 450);
            Controls.Add(button1_laylaimatkhau);
            Controls.Add(textBox1_typeemail);
            Controls.Add(label2_emaildadangki);
            Controls.Add(label1_quenmatkhau);
            MaximizeBox = false;
            Name = "form_QuenMatKhau";
            Text = "QuenMatKhau";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1_quenmatkhau;
        private Label label2_emaildadangki;
        private TextBox textBox1_typeemail;
        private Button button1_laylaimatkhau;
    }
}