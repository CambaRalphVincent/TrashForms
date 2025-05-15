namespace TrashFormsGUI
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdminMenu;
        private System.Windows.Forms.Button btnAddTip;
        private System.Windows.Forms.Button btnDeleteTip;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblAdminMenu = new Label();
            btnAddTip = new Button();
            btnDeleteTip = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new Point(81, 52);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(618, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblAdminMenu
            // 
            lblAdminMenu.AutoSize = true;
            lblAdminMenu.BackColor = Color.Transparent;
            lblAdminMenu.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAdminMenu.ForeColor = Color.White;
            lblAdminMenu.Location = new Point(274, 195);
            lblAdminMenu.Name = "lblAdminMenu";
            lblAdminMenu.Size = new Size(110, 21);
            lblAdminMenu.TabIndex = 1;
            lblAdminMenu.Text = "Admin Menu";
            // 
            // btnAddTip
            // 
            btnAddTip.BackColor = Color.SeaGreen;
            btnAddTip.FlatStyle = FlatStyle.Popup;
            btnAddTip.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnAddTip.ForeColor = Color.White;
            btnAddTip.Location = new Point(274, 216);
            btnAddTip.Margin = new Padding(3, 2, 3, 2);
            btnAddTip.Name = "btnAddTip";
            btnAddTip.Size = new Size(243, 34);
            btnAddTip.TabIndex = 2;
            btnAddTip.Text = "Add Recycling Tip";
            btnAddTip.UseVisualStyleBackColor = false;
            btnAddTip.Click += btnAddTip_Click;
            // 
            // btnDeleteTip
            // 
            btnDeleteTip.BackColor = Color.SeaGreen;
            btnDeleteTip.FlatStyle = FlatStyle.Popup;
            btnDeleteTip.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnDeleteTip.ForeColor = Color.White;
            btnDeleteTip.Location = new Point(274, 257);
            btnDeleteTip.Margin = new Padding(3, 2, 3, 2);
            btnDeleteTip.Name = "btnDeleteTip";
            btnDeleteTip.Size = new Size(243, 34);
            btnDeleteTip.TabIndex = 3;
            btnDeleteTip.Text = "Delete Recycling Tip";
            btnDeleteTip.UseVisualStyleBackColor = false;
            btnDeleteTip.Click += btnDeleteTip_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.SeaGreen;
            btnLogout.FlatStyle = FlatStyle.Popup;
            btnLogout.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(274, 298);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(243, 34);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 400);
            Controls.Add(pictureBox1);
            Controls.Add(lblAdminMenu);
            Controls.Add(btnAddTip);
            Controls.Add(btnDeleteTip);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Admin Menu";
            Load += AdminForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}