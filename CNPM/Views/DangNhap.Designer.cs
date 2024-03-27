namespace DangKi__DangNhap__QuenMatKhau
{
    partial class form_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_DangNhap));
            groupBox1_dangnhap = new GroupBox();
            linkLabel1_taotaikhoan = new LinkLabel();
            button3_quenmatkhaubtn = new Button();
            button1_dangnhapbtn = new Button();
            pictureBox5_passwordicon = new PictureBox();
            pictureBox1_usericon = new PictureBox();
            checkBox1_remember = new CheckBox();
            label5 = new Label();
            textBox3_typepassword = new TextBox();
            textBox1_tendangnhap = new TextBox();
            label3_matkhau = new Label();
            label1_tendangnhap = new Label();
            groupBox1_dangnhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5_passwordicon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_usericon).BeginInit();
            SuspendLayout();
            // 
            // groupBox1_dangnhap
            // 
            groupBox1_dangnhap.BackColor = Color.FromArgb(241, 232, 216);
            groupBox1_dangnhap.Controls.Add(linkLabel1_taotaikhoan);
            groupBox1_dangnhap.Controls.Add(button3_quenmatkhaubtn);
            groupBox1_dangnhap.Controls.Add(button1_dangnhapbtn);
            groupBox1_dangnhap.Controls.Add(pictureBox5_passwordicon);
            groupBox1_dangnhap.Controls.Add(pictureBox1_usericon);
            groupBox1_dangnhap.Controls.Add(checkBox1_remember);
            groupBox1_dangnhap.Controls.Add(label5);
            groupBox1_dangnhap.Controls.Add(textBox3_typepassword);
            groupBox1_dangnhap.Controls.Add(textBox1_tendangnhap);
            groupBox1_dangnhap.Controls.Add(label3_matkhau);
            groupBox1_dangnhap.Controls.Add(label1_tendangnhap);
            groupBox1_dangnhap.Dock = DockStyle.Left;
            groupBox1_dangnhap.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1_dangnhap.Location = new Point(0, 0);
            groupBox1_dangnhap.Name = "groupBox1_dangnhap";
            groupBox1_dangnhap.Size = new Size(389, 642);
            groupBox1_dangnhap.TabIndex = 1;
            groupBox1_dangnhap.TabStop = false;
            groupBox1_dangnhap.Text = "ĐĂNG NHẬP";
            groupBox1_dangnhap.Enter += groupBox1_Enter;
            // 
            // linkLabel1_taotaikhoan
            // 
            linkLabel1_taotaikhoan.AutoSize = true;
            linkLabel1_taotaikhoan.DisabledLinkColor = Color.FromArgb(192, 178, 178);
            linkLabel1_taotaikhoan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1_taotaikhoan.Location = new Point(136, 488);
            linkLabel1_taotaikhoan.Name = "linkLabel1_taotaikhoan";
            linkLabel1_taotaikhoan.Size = new Size(148, 23);
            linkLabel1_taotaikhoan.TabIndex = 3;
            linkLabel1_taotaikhoan.TabStop = true;
            linkLabel1_taotaikhoan.Text = "Tạo tài khoản mới";
            linkLabel1_taotaikhoan.LinkClicked += linkLabel1_taotaikhoan_LinkClicked;
            // 
            // button3_quenmatkhaubtn
            // 
            button3_quenmatkhaubtn.BackColor = Color.FromArgb(130, 75, 27);
            button3_quenmatkhaubtn.Cursor = Cursors.Hand;
            button3_quenmatkhaubtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button3_quenmatkhaubtn.ForeColor = Color.White;
            button3_quenmatkhaubtn.Location = new Point(123, 408);
            button3_quenmatkhaubtn.Name = "button3_quenmatkhaubtn";
            button3_quenmatkhaubtn.Size = new Size(174, 56);
            button3_quenmatkhaubtn.TabIndex = 15;
            button3_quenmatkhaubtn.Text = "QUÊN MẬT KHẨU";
            button3_quenmatkhaubtn.UseVisualStyleBackColor = false;
            button3_quenmatkhaubtn.Click += button3_quenmatkhaubtn_Click;
            // 
            // button1_dangnhapbtn
            // 
            button1_dangnhapbtn.BackColor = Color.FromArgb(219, 144, 76);
            button1_dangnhapbtn.Cursor = Cursors.Hand;
            button1_dangnhapbtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1_dangnhapbtn.ForeColor = Color.White;
            button1_dangnhapbtn.Location = new Point(136, 339);
            button1_dangnhapbtn.Name = "button1_dangnhapbtn";
            button1_dangnhapbtn.Size = new Size(148, 48);
            button1_dangnhapbtn.TabIndex = 14;
            button1_dangnhapbtn.Text = "ĐĂNG NHẬP";
            button1_dangnhapbtn.UseVisualStyleBackColor = false;
            button1_dangnhapbtn.Click += button1_dangnhapbtn_Click;
            // 
            // pictureBox5_passwordicon
            // 
            pictureBox5_passwordicon.Image = (Image)resources.GetObject("pictureBox5_passwordicon.Image");
            pictureBox5_passwordicon.Location = new Point(23, 221);
            pictureBox5_passwordicon.Name = "pictureBox5_passwordicon";
            pictureBox5_passwordicon.Size = new Size(40, 40);
            pictureBox5_passwordicon.TabIndex = 12;
            pictureBox5_passwordicon.TabStop = false;
            // 
            // pictureBox1_usericon
            // 
            pictureBox1_usericon.Image = (Image)resources.GetObject("pictureBox1_usericon.Image");
            pictureBox1_usericon.Location = new Point(23, 128);
            pictureBox1_usericon.Name = "pictureBox1_usericon";
            pictureBox1_usericon.Size = new Size(40, 40);
            pictureBox1_usericon.TabIndex = 9;
            pictureBox1_usericon.TabStop = false;
            // 
            // checkBox1_remember
            // 
            checkBox1_remember.AutoSize = true;
            checkBox1_remember.Cursor = Cursors.Hand;
            checkBox1_remember.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1_remember.ForeColor = Color.FromArgb(199, 128, 46);
            checkBox1_remember.Location = new Point(69, 281);
            checkBox1_remember.Name = "checkBox1_remember";
            checkBox1_remember.Size = new Size(181, 27);
            checkBox1_remember.TabIndex = 8;
            checkBox1_remember.Text = "Ghi nhớ đăng nhập";
            checkBox1_remember.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(69, 441);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 1;
            // 
            // textBox3_typepassword
            // 
            textBox3_typepassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3_typepassword.Location = new Point(69, 219);
            textBox3_typepassword.Multiline = true;
            textBox3_typepassword.Name = "textBox3_typepassword";
            textBox3_typepassword.PasswordChar = '*';
            textBox3_typepassword.Size = new Size(282, 42);
            textBox3_typepassword.TabIndex = 6;
            // 
            // textBox1_tendangnhap
            // 
            textBox1_tendangnhap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1_tendangnhap.Location = new Point(69, 128);
            textBox1_tendangnhap.Multiline = true;
            textBox1_tendangnhap.Name = "textBox1_tendangnhap";
            textBox1_tendangnhap.Size = new Size(282, 40);
            textBox1_tendangnhap.TabIndex = 4;
            textBox1_tendangnhap.TextChanged += textBox1_TextChanged;
            // 
            // label3_matkhau
            // 
            label3_matkhau.AutoSize = true;
            label3_matkhau.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3_matkhau.ForeColor = Color.FromArgb(199, 128, 46);
            label3_matkhau.Location = new Point(69, 184);
            label3_matkhau.Name = "label3_matkhau";
            label3_matkhau.Size = new Size(82, 23);
            label3_matkhau.TabIndex = 2;
            label3_matkhau.Text = "Mật khẩu";
            // 
            // label1_tendangnhap
            // 
            label1_tendangnhap.AutoSize = true;
            label1_tendangnhap.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1_tendangnhap.ForeColor = Color.FromArgb(199, 128, 46);
            label1_tendangnhap.Location = new Point(69, 92);
            label1_tendangnhap.Name = "label1_tendangnhap";
            label1_tendangnhap.Size = new Size(124, 23);
            label1_tendangnhap.TabIndex = 0;
            label1_tendangnhap.Text = "Tên đăng nhập";
            // 
            // form_DangNhap
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.Wheat;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(791, 642);
            Controls.Add(groupBox1_dangnhap);
            MaximizeBox = false;
            Name = "form_DangNhap";
            Text = "DangNhap";
            Load += DangNhap_Load;
            groupBox1_dangnhap.ResumeLayout(false);
            groupBox1_dangnhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5_passwordicon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_usericon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1_dangnhap;
        private Button button3_quenmatkhaubtn;
        private Button button1_dangnhapbtn;
        private PictureBox pictureBox5_passwordicon;
        private PictureBox pictureBox1_usericon;
        private CheckBox checkBox1_remember;
        private Label label5;
        private TextBox textBox3_typepassword;
        private TextBox textBox1_tendangnhap;
        private Label label3_matkhau;
        private Label label1_tendangnhap;
        private LinkLabel linkLabel1_taotaikhoan;
    }
}