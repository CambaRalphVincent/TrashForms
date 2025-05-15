namespace TrashFormsGUI
{
    partial class UserForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUserMenu;
        private System.Windows.Forms.Button btnAddWaste;
        private System.Windows.Forms.Button btnRecSummary;
        private System.Windows.Forms.Button btnRecTips;
        private System.Windows.Forms.Button btnLogout;

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
            lblUserMenu = new Label();
            btnAddWaste = new Button();
            btnRecSummary = new Button();
            btnRecTips = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new Point(95, 39);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(706, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblUserMenu
            // 
            lblUserMenu.AutoSize = true;
            lblUserMenu.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUserMenu.Location = new Point(312, 200);
            lblUserMenu.Name = "lblUserMenu";
            lblUserMenu.Size = new Size(110, 23);
            lblUserMenu.TabIndex = 1;
            lblUserMenu.Text = "User Menu";
            // 
            // btnAddWaste
            // 
            btnAddWaste.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnAddWaste.Location = new Point(312, 250);
            btnAddWaste.Margin = new Padding(3, 4, 3, 4);
            btnAddWaste.Name = "btnAddWaste";
            btnAddWaste.Size = new Size(278, 45);
            btnAddWaste.TabIndex = 2;
            btnAddWaste.Text = "Add Waste Item";
            btnAddWaste.UseVisualStyleBackColor = true;
            btnAddWaste.Click += btnAddWaste_Click;
            // 
            // btnRecSummary
            // 
            btnRecSummary.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnRecSummary.Location = new Point(312, 305);
            btnRecSummary.Margin = new Padding(3, 4, 3, 4);
            btnRecSummary.Name = "btnRecSummary";
            btnRecSummary.Size = new Size(278, 45);
            btnRecSummary.TabIndex = 3;
            btnRecSummary.Text = "Recycling Summary";
            btnRecSummary.UseVisualStyleBackColor = true;
            btnRecSummary.Click += btnRecSummary_Click;
            // 
            // btnRecTips
            // 
            btnRecTips.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnRecTips.Location = new Point(312, 360);
            btnRecTips.Margin = new Padding(3, 4, 3, 4);
            btnRecTips.Name = "btnRecTips";
            btnRecTips.Size = new Size(278, 45);
            btnRecTips.TabIndex = 4;
            btnRecTips.Text = "Recycling Tips";
            btnRecTips.UseVisualStyleBackColor = true;
            btnRecTips.Click += btnRecTips_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnLogout.Location = new Point(312, 415);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(278, 45);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 533);
            Controls.Add(pictureBox1);
            Controls.Add(lblUserMenu);
            Controls.Add(btnAddWaste);
            Controls.Add(btnRecSummary);
            Controls.Add(btnRecTips);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User Menu";
            Load += UserForm_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}