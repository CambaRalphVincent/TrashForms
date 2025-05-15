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
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new Point(95, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(706, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblAdminMenu
            // 
            lblAdminMenu.AutoSize = true;
            lblAdminMenu.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblAdminMenu.Location = new Point(312, 200);
            lblAdminMenu.Name = "lblAdminMenu";
            lblAdminMenu.Size = new Size(133, 23);
            lblAdminMenu.TabIndex = 1;
            lblAdminMenu.Text = "Admin Menu";
            // 
            // btnAddTip
            // 
            btnAddTip.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnAddTip.Location = new Point(312, 250);
            btnAddTip.Name = "btnAddTip";
            btnAddTip.Size = new Size(278, 45);
            btnAddTip.TabIndex = 2;
            btnAddTip.Text = "Add Recycling Tip";
            btnAddTip.UseVisualStyleBackColor = true;
            btnAddTip.Click += btnAddTip_Click;
            // 
            // btnDeleteTip
            // 
            btnDeleteTip.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnDeleteTip.Location = new Point(312, 305);
            btnDeleteTip.Name = "btnDeleteTip";
            btnDeleteTip.Size = new Size(278, 45);
            btnDeleteTip.TabIndex = 3;
            btnDeleteTip.Text = "Delete Recycling Tip";
            btnDeleteTip.UseVisualStyleBackColor = true;
            btnDeleteTip.Click += btnDeleteTip_Click;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnLogout.Location = new Point(312, 360);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(278, 45);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 533);
            Controls.Add(pictureBox1);
            Controls.Add(lblAdminMenu);
            Controls.Add(btnAddTip);
            Controls.Add(btnDeleteTip);
            Controls.Add(btnLogout);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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