namespace TrashFormsGUI
{
    partial class UserForm
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
            pictureBox1 = new PictureBox();
            btnAddWaste = new Button();
            btnRecSummary = new Button();
            btnRecTips = new Button();
            btnLogout = new Button();
            lblUsermenu = new Label();
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
<<<<<<< Updated upstream
=======
            // lblUserMenu
            // 
            lblUserMenu.AutoSize = true;
            lblUserMenu.BackColor = Color.Transparent;
            lblUserMenu.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUserMenu.Location = new Point(273, 150);
            lblUserMenu.Name = "lblUserMenu";
            lblUserMenu.Size = new Size(88, 19);
            lblUserMenu.TabIndex = 1;
            lblUserMenu.Text = "User Menu";
            // 
>>>>>>> Stashed changes
            // btnAddWaste
            // 
            btnAddWaste.BackColor = Color.FromArgb(32, 93, 28);
            btnAddWaste.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
<<<<<<< Updated upstream
            btnAddWaste.Location = new Point(273, 203);
            btnAddWaste.Name = "btnAddWaste";
            btnAddWaste.Size = new Size(243, 38);
            btnAddWaste.TabIndex = 1;
=======
            btnAddWaste.ForeColor = Color.White;
            btnAddWaste.Location = new Point(273, 188);
            btnAddWaste.Name = "btnAddWaste";
            btnAddWaste.Size = new Size(243, 34);
            btnAddWaste.TabIndex = 2;
>>>>>>> Stashed changes
            btnAddWaste.Text = "Add Waste Item";
            btnAddWaste.UseVisualStyleBackColor = false;
            btnAddWaste.Click += btnAddWaste_Click;
            // 
            // btnRecSummary
            // 
            btnRecSummary.BackColor = Color.FromArgb(32, 93, 28);
            btnRecSummary.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
<<<<<<< Updated upstream
            btnRecSummary.Location = new Point(273, 251);
            btnRecSummary.Name = "btnRecSummary";
            btnRecSummary.Size = new Size(243, 38);
            btnRecSummary.TabIndex = 2;
=======
            btnRecSummary.ForeColor = Color.White;
            btnRecSummary.Location = new Point(273, 229);
            btnRecSummary.Name = "btnRecSummary";
            btnRecSummary.Size = new Size(243, 34);
            btnRecSummary.TabIndex = 3;
>>>>>>> Stashed changes
            btnRecSummary.Text = "Recycling Summary";
            btnRecSummary.UseVisualStyleBackColor = false;
            btnRecSummary.Click += btnRecSummary_Click;
            // 
            // btnRecTips
            // 
            btnRecTips.BackColor = Color.FromArgb(32, 93, 28);
            btnRecTips.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
<<<<<<< Updated upstream
            btnRecTips.Location = new Point(273, 300);
            btnRecTips.Name = "btnRecTips";
            btnRecTips.Size = new Size(243, 38);
            btnRecTips.TabIndex = 3;
            btnRecTips.Text = "Recycling Tips";
            btnRecTips.UseVisualStyleBackColor = true;
=======
            btnRecTips.ForeColor = Color.White;
            btnRecTips.Location = new Point(273, 270);
            btnRecTips.Name = "btnRecTips";
            btnRecTips.Size = new Size(243, 34);
            btnRecTips.TabIndex = 4;
            btnRecTips.Text = "Recycling Tips";
            btnRecTips.UseVisualStyleBackColor = false;
            btnRecTips.Click += btnRecTips_Click;
>>>>>>> Stashed changes
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(32, 93, 28);
            btnLogout.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
<<<<<<< Updated upstream
            btnLogout.Location = new Point(273, 353);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(243, 38);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // lblUsermenu
            // 
            lblUsermenu.AutoSize = true;
            lblUsermenu.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsermenu.Location = new Point(273, 181);
            lblUsermenu.Name = "lblUsermenu";
            lblUsermenu.Size = new Size(88, 19);
            lblUsermenu.TabIndex = 5;
            lblUsermenu.Text = "User Menu";
=======
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(273, 311);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(243, 34);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
>>>>>>> Stashed changes
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
<<<<<<< Updated upstream
            ClientSize = new Size(800, 450);
            Controls.Add(lblUsermenu);
            Controls.Add(btnLogout);
            Controls.Add(btnRecTips);
            Controls.Add(btnRecSummary);
            Controls.Add(btnAddWaste);
            Controls.Add(pictureBox1);
=======
            BackgroundImage = Properties.Resources.primary_bg;
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
>>>>>>> Stashed changes
            Name = "UserForm";
            Text = "UserForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnAddWaste;
        private Button btnRecSummary;
        private Button btnRecTips;
        private Button btnLogout;
        private Label lblUsermenu;
    }
}