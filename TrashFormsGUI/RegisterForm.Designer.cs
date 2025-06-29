﻿namespace TrashFormsGUI
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblRegister = new Label();
            lblUsername = new Label();
            lblPassword = new Label();
            lblRole = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            comboBoxRole = new ComboBox();
            btnRegister = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new Point(83, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(618, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.BackColor = Color.Transparent;
            lblRegister.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = Color.FromArgb(0, 64, 0);
            lblRegister.Location = new Point(224, 163);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(142, 21);
            lblRegister.TabIndex = 1;
            lblRegister.Text = "Register Account";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblUsername.ForeColor = Color.FromArgb(0, 64, 0);
            lblUsername.Location = new Point(229, 189);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(91, 19);
            lblUsername.TabIndex = 2;
            lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(0, 64, 0);
            lblPassword.Location = new Point(236, 223);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(84, 19);
            lblPassword.TabIndex = 4;
            lblPassword.Text = "Password:";
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.BackColor = Color.Transparent;
            lblRole.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblRole.ForeColor = Color.FromArgb(0, 64, 0);
            lblRole.Location = new Point(274, 257);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(46, 19);
            lblRole.TabIndex = 6;
            lblRole.Text = "Role:";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(321, 185);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(219, 27);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(321, 219);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(219, 27);
            txtPassword.TabIndex = 5;
            // 
            // comboBoxRole
            // 
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBoxRole.Location = new Point(321, 253);
            comboBoxRole.Margin = new Padding(3, 2, 3, 2);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(219, 29);
            comboBoxRole.TabIndex = 7;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(32, 93, 28);
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(259, 313);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(105, 34);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(32, 93, 28);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(395, 313);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 34);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 400);
            Controls.Add(pictureBox1);
            Controls.Add(lblRegister);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblRole);
            Controls.Add(comboBoxRole);
            Controls.Add(btnRegister);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += RegisterForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}