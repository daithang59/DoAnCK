namespace Demo_UIDangKy
{
    partial class DangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            Dk_Avt = new PictureBox();
            label1 = new Label();
            tb_username = new TextBox();
            tb_password = new TextBox();
            label2 = new Label();
            tb_confirmpassword = new TextBox();
            label3 = new Label();
            tb_gmail = new TextBox();
            label4 = new Label();
            bt_registry = new Button();
            ((System.ComponentModel.ISupportInitialize)Dk_Avt).BeginInit();
            SuspendLayout();
            // 
            // Dk_Avt
            // 
            Dk_Avt.Image = (Image)resources.GetObject("Dk_Avt.Image");
            Dk_Avt.Location = new Point(167, 12);
            Dk_Avt.Name = "Dk_Avt";
            Dk_Avt.Size = new Size(166, 151);
            Dk_Avt.SizeMode = PictureBoxSizeMode.StretchImage;
            Dk_Avt.TabIndex = 0;
            Dk_Avt.TabStop = false;
            Dk_Avt.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 190);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên tài khoản:";
            label1.Click += label1_Click;
            // 
            // tb_username
            // 
            tb_username.Location = new Point(183, 183);
            tb_username.Name = "tb_username";
            tb_username.Size = new Size(250, 27);
            tb_username.TabIndex = 2;
            // 
            // tb_password
            // 
            tb_password.Location = new Point(183, 242);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(250, 27);
            tb_password.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 249);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // tb_confirmpassword
            // 
            tb_confirmpassword.Location = new Point(183, 302);
            tb_confirmpassword.Name = "tb_confirmpassword";
            tb_confirmpassword.Size = new Size(250, 27);
            tb_confirmpassword.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 309);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 5;
            label3.Text = "Nhập lại mật khẩu:";
            // 
            // tb_gmail
            // 
            tb_gmail.Location = new Point(183, 357);
            tb_gmail.Name = "tb_gmail";
            tb_gmail.Size = new Size(250, 27);
            tb_gmail.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 364);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 7;
            label4.Text = "Gmail:";
            // 
            // bt_registry
            // 
            bt_registry.Location = new Point(311, 417);
            bt_registry.Name = "bt_registry";
            bt_registry.Size = new Size(122, 45);
            bt_registry.TabIndex = 9;
            bt_registry.Text = "Đăng Ký";
            bt_registry.UseVisualStyleBackColor = true;
            bt_registry.Click += bt_registry_Click;
            // 
            // DangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 496);
            Controls.Add(bt_registry);
            Controls.Add(tb_gmail);
            Controls.Add(label4);
            Controls.Add(tb_confirmpassword);
            Controls.Add(label3);
            Controls.Add(tb_password);
            Controls.Add(label2);
            Controls.Add(tb_username);
            Controls.Add(label1);
            Controls.Add(Dk_Avt);
            Name = "DangKy";
            Text = "Đăng Ký";
            ((System.ComponentModel.ISupportInitialize)Dk_Avt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Dk_Avt;
        private Label label1;
        private TextBox tb_username;
        private TextBox tb_password;
        private Label label2;
        private TextBox tb_confirmpassword;
        private Label label3;
        private TextBox tb_gmail;
        private Label label4;
        private Button bt_registry;
    }
}
