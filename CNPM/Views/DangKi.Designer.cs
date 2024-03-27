namespace DangKi__DangNhap__QuenMatKhau
{
    partial class form_DangKi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_DangKi));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupbox_taotaikhoan = new GroupBox();
            linkLabel1_dangnhap = new LinkLabel();
            textBox1_xacthuc = new TextBox();
            label1_otp = new Label();
            pictureBox1_otp = new PictureBox();
            button2_sendotp = new Button();
            button1_taotaikhoan = new Button();
            pictureBox4_retypepass = new PictureBox();
            pictureBox5_password = new PictureBox();
            pictureBox3_mail = new PictureBox();
            pictureBox1_user = new PictureBox();
            checkBox1 = new CheckBox();
            label5 = new Label();
            textBox4_retypepass = new TextBox();
            textBox3_password = new TextBox();
            textBox2_mail = new TextBox();
            textBox1_user = new TextBox();
            label4_retypepass = new Label();
            label3_password = new Label();
            label2_email = new Label();
            label_tendangnhap = new Label();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            timvcode = new System.Windows.Forms.Timer(components);
            groupbox_taotaikhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_otp).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4_retypepass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5_password).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3_mail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_user).BeginInit();
            SuspendLayout();
            // 
            // groupbox_taotaikhoan
            // 
            groupbox_taotaikhoan.BackColor = Color.FromArgb(241, 232, 216);
            groupbox_taotaikhoan.Controls.Add(linkLabel1_dangnhap);
            groupbox_taotaikhoan.Controls.Add(textBox1_xacthuc);
            groupbox_taotaikhoan.Controls.Add(label1_otp);
            groupbox_taotaikhoan.Controls.Add(pictureBox1_otp);
            groupbox_taotaikhoan.Controls.Add(button2_sendotp);
            groupbox_taotaikhoan.Controls.Add(button1_taotaikhoan);
            groupbox_taotaikhoan.Controls.Add(pictureBox4_retypepass);
            groupbox_taotaikhoan.Controls.Add(pictureBox5_password);
            groupbox_taotaikhoan.Controls.Add(pictureBox3_mail);
            groupbox_taotaikhoan.Controls.Add(pictureBox1_user);
            groupbox_taotaikhoan.Controls.Add(checkBox1);
            groupbox_taotaikhoan.Controls.Add(label5);
            groupbox_taotaikhoan.Controls.Add(textBox4_retypepass);
            groupbox_taotaikhoan.Controls.Add(textBox3_password);
            groupbox_taotaikhoan.Controls.Add(textBox2_mail);
            groupbox_taotaikhoan.Controls.Add(textBox1_user);
            groupbox_taotaikhoan.Controls.Add(label4_retypepass);
            groupbox_taotaikhoan.Controls.Add(label3_password);
            groupbox_taotaikhoan.Controls.Add(label2_email);
            groupbox_taotaikhoan.Controls.Add(label_tendangnhap);
            groupbox_taotaikhoan.Dock = DockStyle.Left;
            groupbox_taotaikhoan.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            groupbox_taotaikhoan.Location = new Point(0, 0);
            groupbox_taotaikhoan.Name = "groupbox_taotaikhoan";
            groupbox_taotaikhoan.Size = new Size(391, 717);
            groupbox_taotaikhoan.TabIndex = 0;
            groupbox_taotaikhoan.TabStop = false;
            groupbox_taotaikhoan.Text = "TẠO TÀI KHOẢN";
            groupbox_taotaikhoan.Enter += groupBox1_Enter_1;
            // 
            // linkLabel1_dangnhap
            // 
            linkLabel1_dangnhap.AutoSize = true;
            linkLabel1_dangnhap.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1_dangnhap.Location = new Point(124, 651);
            linkLabel1_dangnhap.Name = "linkLabel1_dangnhap";
            linkLabel1_dangnhap.Size = new Size(143, 23);
            linkLabel1_dangnhap.TabIndex = 19;
            linkLabel1_dangnhap.TabStop = true;
            linkLabel1_dangnhap.Text = "Đã có tài khoản ?";
            linkLabel1_dangnhap.LinkClicked += linkLabel1_dangnhap_LinkClicked;
            // 
            // textBox1_xacthuc
            // 
            textBox1_xacthuc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1_xacthuc.Location = new Point(69, 284);
            textBox1_xacthuc.MaxLength = 5;
            textBox1_xacthuc.Multiline = true;
            textBox1_xacthuc.Name = "textBox1_xacthuc";
            textBox1_xacthuc.Size = new Size(209, 42);
            textBox1_xacthuc.TabIndex = 18;
            // 
            // label1_otp
            // 
            label1_otp.AutoSize = true;
            label1_otp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1_otp.Location = new Point(69, 247);
            label1_otp.Name = "label1_otp";
            label1_otp.Size = new Size(103, 23);
            label1_otp.TabIndex = 17;
            label1_otp.Text = "Mã xác thực";
            // 
            // pictureBox1_otp
            // 
            pictureBox1_otp.Image = (Image)resources.GetObject("pictureBox1_otp.Image");
            pictureBox1_otp.Location = new Point(23, 284);
            pictureBox1_otp.Name = "pictureBox1_otp";
            pictureBox1_otp.Size = new Size(40, 40);
            pictureBox1_otp.TabIndex = 16;
            pictureBox1_otp.TabStop = false;
            // 
            // button2_sendotp
            // 
            button2_sendotp.Cursor = Cursors.Hand;
            button2_sendotp.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button2_sendotp.Location = new Point(284, 284);
            button2_sendotp.Name = "button2_sendotp";
            button2_sendotp.Size = new Size(67, 42);
            button2_sendotp.TabIndex = 15;
            button2_sendotp.Text = "Gửi";
            button2_sendotp.UseVisualStyleBackColor = true;
            button2_sendotp.Click += button2_sendotp_Click;
            // 
            // button1_taotaikhoan
            // 
            button1_taotaikhoan.BackColor = Color.FromArgb(219, 144, 76);
            button1_taotaikhoan.Cursor = Cursors.Hand;
            button1_taotaikhoan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button1_taotaikhoan.ForeColor = Color.Black;
            button1_taotaikhoan.Location = new Point(121, 584);
            button1_taotaikhoan.Name = "button1_taotaikhoan";
            button1_taotaikhoan.Size = new Size(148, 48);
            button1_taotaikhoan.TabIndex = 14;
            button1_taotaikhoan.Text = "TẠO TÀI KHOẢN";
            button1_taotaikhoan.UseVisualStyleBackColor = false;
            // 
            // pictureBox4_retypepass
            // 
            pictureBox4_retypepass.Image = (Image)resources.GetObject("pictureBox4_retypepass.Image");
            pictureBox4_retypepass.Location = new Point(23, 469);
            pictureBox4_retypepass.Name = "pictureBox4_retypepass";
            pictureBox4_retypepass.Size = new Size(40, 40);
            pictureBox4_retypepass.TabIndex = 13;
            pictureBox4_retypepass.TabStop = false;
            // 
            // pictureBox5_password
            // 
            pictureBox5_password.Image = (Image)resources.GetObject("pictureBox5_password.Image");
            pictureBox5_password.Location = new Point(23, 380);
            pictureBox5_password.Name = "pictureBox5_password";
            pictureBox5_password.Size = new Size(40, 40);
            pictureBox5_password.TabIndex = 12;
            pictureBox5_password.TabStop = false;
            // 
            // pictureBox3_mail
            // 
            pictureBox3_mail.Image = (Image)resources.GetObject("pictureBox3_mail.Image");
            pictureBox3_mail.Location = new Point(23, 187);
            pictureBox3_mail.Name = "pictureBox3_mail";
            pictureBox3_mail.Size = new Size(40, 40);
            pictureBox3_mail.TabIndex = 11;
            pictureBox3_mail.TabStop = false;
            // 
            // pictureBox1_user
            // 
            pictureBox1_user.Image = (Image)resources.GetObject("pictureBox1_user.Image");
            pictureBox1_user.Location = new Point(23, 100);
            pictureBox1_user.Name = "pictureBox1_user";
            pictureBox1_user.Size = new Size(40, 40);
            pictureBox1_user.TabIndex = 9;
            pictureBox1_user.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(69, 536);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(238, 27);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Đồng ý với mọi điều khoản";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(69, 540);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 1;
            label5.Click += label5_Click;
            // 
            // textBox4_retypepass
            // 
            textBox4_retypepass.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4_retypepass.Location = new Point(69, 469);
            textBox4_retypepass.Multiline = true;
            textBox4_retypepass.Name = "textBox4_retypepass";
            textBox4_retypepass.PasswordChar = '*';
            textBox4_retypepass.Size = new Size(282, 42);
            textBox4_retypepass.TabIndex = 7;
            // 
            // textBox3_password
            // 
            textBox3_password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3_password.Location = new Point(69, 378);
            textBox3_password.Multiline = true;
            textBox3_password.Name = "textBox3_password";
            textBox3_password.PasswordChar = '*';
            textBox3_password.Size = new Size(282, 42);
            textBox3_password.TabIndex = 6;
            // 
            // textBox2_mail
            // 
            textBox2_mail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2_mail.Location = new Point(69, 187);
            textBox2_mail.Multiline = true;
            textBox2_mail.Name = "textBox2_mail";
            textBox2_mail.Size = new Size(282, 42);
            textBox2_mail.TabIndex = 5;
            textBox2_mail.TextChanged += textBox2_mail_TextChanged;
            // 
            // textBox1_user
            // 
            textBox1_user.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1_user.Location = new Point(69, 100);
            textBox1_user.Multiline = true;
            textBox1_user.Name = "textBox1_user";
            textBox1_user.Size = new Size(282, 40);
            textBox1_user.TabIndex = 4;
            textBox1_user.TextChanged += textBox1_user_TextChanged;
            // 
            // label4_retypepass
            // 
            label4_retypepass.AutoSize = true;
            label4_retypepass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4_retypepass.Location = new Point(69, 434);
            label4_retypepass.Name = "label4_retypepass";
            label4_retypepass.Size = new Size(151, 23);
            label4_retypepass.TabIndex = 3;
            label4_retypepass.Text = "Nhập lại mật khẩu";
            // 
            // label3_password
            // 
            label3_password.AutoSize = true;
            label3_password.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3_password.Location = new Point(69, 342);
            label3_password.Name = "label3_password";
            label3_password.Size = new Size(82, 23);
            label3_password.TabIndex = 2;
            label3_password.Text = "Mật khẩu";
            // 
            // label2_email
            // 
            label2_email.AutoSize = true;
            label2_email.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2_email.Location = new Point(69, 152);
            label2_email.Name = "label2_email";
            label2_email.Size = new Size(51, 23);
            label2_email.TabIndex = 1;
            label2_email.Text = "Email";
            // 
            // label_tendangnhap
            // 
            label_tendangnhap.AutoSize = true;
            label_tendangnhap.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label_tendangnhap.Location = new Point(69, 64);
            label_tendangnhap.Name = "label_tendangnhap";
            label_tendangnhap.Size = new Size(124, 23);
            label_tendangnhap.TabIndex = 0;
            label_tendangnhap.Text = "Tên đăng nhập";
            label_tendangnhap.Click += label1_Click_1;
            // 
            // timvcode
            // 
            timvcode.Tick += timvcode_Tick;
            // 
            // form_DangKi
            // 
            AutoSize = true;
            BackColor = Color.Wheat;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1266, 717);
            Controls.Add(groupbox_taotaikhoan);
            ForeColor = Color.FromArgb(199, 128, 46);
            MaximizeBox = false;
            Name = "form_DangKi";
            Load += DangKi_Load;
            groupbox_taotaikhoan.ResumeLayout(false);
            groupbox_taotaikhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_otp).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4_retypepass).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5_password).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3_mail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1_user).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox groupbox_taotaikhoan;
        private Label label_tendangnhap;
        private Label label4_retypepass;
        private Label label3_password;
        private Label label2_email;
        private TextBox textBox3_password;
        private TextBox textBox2_mail;
        private TextBox textBox1_user;
        private Label label5;
        private TextBox textBox4_retypepass;
        private PictureBox pictureBox4_retypepass;
        private PictureBox pictureBox5_password;
        private PictureBox pictureBox3_mail;
        private PictureBox pictureBox1_user;
        private CheckBox checkBox1;
        private Button button1_taotaikhoan;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button button2_sendotp;
        private PictureBox pictureBox1_otp;
        private TextBox textBox1_xacthuc;
        private Label label1_otp;
        private LinkLabel linkLabel1_dangnhap;
        private System.Windows.Forms.Timer timvcode;
    }
}
