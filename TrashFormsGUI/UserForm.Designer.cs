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
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new Point(83, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(618, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblUserMenu
            // 
            lblUserMenu.AutoSize = true;
            lblUserMenu.BackColor = Color.Transparent;
            lblUserMenu.Font = new Font("Montserrat", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUserMenu.Location = new Point(273, 150);
            lblUserMenu.Name = "lblUserMenu";
            lblUserMenu.Size = new Size(98, 22);
            lblUserMenu.TabIndex = 1;
            lblUserMenu.Text = "User Menu";
            // 
            // btnAddWaste
            // 
            btnAddWaste.BackColor = Color.FromArgb(32, 93, 28);
            btnAddWaste.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddWaste.ForeColor = Color.White;
            btnAddWaste.Location = new Point(273, 188);
            btnAddWaste.Name = "btnAddWaste";
            btnAddWaste.Size = new Size(243, 34);
            btnAddWaste.TabIndex = 2;
            btnAddWaste.Text = "Add Waste Item";
            btnAddWaste.UseVisualStyleBackColor = false;
            btnAddWaste.Click += btnAddWaste_Click;
            // 
            // btnRecSummary
            // 
            btnRecSummary.BackColor = Color.FromArgb(32, 93, 28);
            btnRecSummary.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecSummary.ForeColor = Color.White;
            btnRecSummary.Location = new Point(273, 229);
            btnRecSummary.Name = "btnRecSummary";
            btnRecSummary.Size = new Size(243, 34);
            btnRecSummary.TabIndex = 3;
            btnRecSummary.Text = "Recycling Summary";
            btnRecSummary.UseVisualStyleBackColor = false;
            btnRecSummary.Click += btnRecSummary_Click;
            // 
            // btnRecTips
            // 
            btnRecTips.BackColor = Color.FromArgb(32, 93, 28);
            btnRecTips.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRecTips.ForeColor = Color.White;
            btnRecTips.Location = new Point(273, 270);
            btnRecTips.Name = "btnRecTips";
            btnRecTips.Size = new Size(243, 34);
            btnRecTips.TabIndex = 4;
            btnRecTips.Text = "Recycling Tips";
            btnRecTips.UseVisualStyleBackColor = false;
            btnRecTips.Click += btnRecTips_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(32, 93, 28);
            btnLogout.Font = new Font("Montserrat", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(273, 311);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(243, 34);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 400);
            Controls.Add(pictureBox1);
            Controls.Add(lblUserMenu);
            Controls.Add(btnAddWaste);
            Controls.Add(btnRecSummary);
            Controls.Add(btnRecTips);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
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