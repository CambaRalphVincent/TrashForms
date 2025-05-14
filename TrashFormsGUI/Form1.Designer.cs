namespace TrashFormsGUI
{
    partial class Form1
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
            lblUsername = new Label();
            lblPassword = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnRegister = new Button();
            btnExit = new Button();
            pictureBox1 = new PictureBox();
            comboBoxRole = new ComboBox();
            lblRole = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.FlatStyle = FlatStyle.Flat;
            lblUsername.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            lblUsername.Location = new Point(254, 168);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(108, 23);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            lblPassword.Location = new Point(254, 206);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 23);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password:";
            lblPassword.Click += lblPassword_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Century Gothic", 12F);
            txtUsername.Location = new Point(370, 167);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(193, 27);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 12F);
            txtPassword.Location = new Point(370, 206);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(193, 27);
            txtPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnLogin.Location = new Point(352, 289);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(118, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnRegister.Location = new Point(352, 341);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(118, 45);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnExit.Location = new Point(352, 392);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(118, 46);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new Point(133, 47);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(558, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // comboBoxRole
            // 
            comboBoxRole.AllowDrop = true;
            comboBoxRole.Font = new Font("Century Gothic", 12F);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "User", "Admin" });
            comboBoxRole.Location = new Point(370, 243);
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.SelectedIndex = 0;
            comboBoxRole.Size = new Size(77, 29);
            comboBoxRole.TabIndex = 8;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(254, 244);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(55, 23);
            lblRole.TabIndex = 9;
            lblRole.Text = "Role:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(lblRole);
            Controls.Add(comboBoxRole);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnExit;
        private PictureBox pictureBox1;
        private ComboBox comboBoxRole;
        private Label lblRole;
    }
}
