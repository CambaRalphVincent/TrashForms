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
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new Point(83, 29);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(618, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnAddWaste
            // 
            btnAddWaste.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnAddWaste.Location = new Point(273, 203);
            btnAddWaste.Name = "btnAddWaste";
            btnAddWaste.Size = new Size(243, 38);
            btnAddWaste.TabIndex = 1;
            btnAddWaste.Text = "Add Waste Item";
            btnAddWaste.UseVisualStyleBackColor = true;
            btnAddWaste.Click += btnAddWaste_Click;
            // 
            // btnRecSummary
            // 
            btnRecSummary.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnRecSummary.Location = new Point(273, 251);
            btnRecSummary.Name = "btnRecSummary";
            btnRecSummary.Size = new Size(243, 38);
            btnRecSummary.TabIndex = 2;
            btnRecSummary.Text = "Recycling Summary";
            btnRecSummary.UseVisualStyleBackColor = true;
            btnRecSummary.Click += btnRecSummary_Click;
            // 
            // btnRecTips
            // 
            btnRecTips.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnRecTips.Location = new Point(273, 300);
            btnRecTips.Name = "btnRecTips";
            btnRecTips.Size = new Size(243, 38);
            btnRecTips.TabIndex = 3;
            btnRecTips.Text = "Recycling Tips";
            btnRecTips.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
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
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblUsermenu);
            Controls.Add(btnLogout);
            Controls.Add(btnRecTips);
            Controls.Add(btnRecSummary);
            Controls.Add(btnAddWaste);
            Controls.Add(pictureBox1);
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