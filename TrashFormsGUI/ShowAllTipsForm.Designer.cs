namespace TrashFormsGUI
{
    partial class ShowAllTipsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtAllTips;
        private System.Windows.Forms.Button btnOk;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            txtAllTips = new TextBox();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new Point(83, 48);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(618, 109);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Century Gothic", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(157, 176);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(144, 21);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "All Recycling Tips";
            // 
            // txtAllTips
            // 
            txtAllTips.BackColor = Color.FromArgb(192, 255, 192);
            txtAllTips.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAllTips.Location = new Point(157, 197);
            txtAllTips.Margin = new Padding(3, 2, 3, 2);
            txtAllTips.Multiline = true;
            txtAllTips.Name = "txtAllTips";
            txtAllTips.ReadOnly = true;
            txtAllTips.ScrollBars = ScrollBars.Vertical;
            txtAllTips.Size = new Size(479, 136);
            txtAllTips.TabIndex = 2;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.Green;
            btnOk.FlatStyle = FlatStyle.Popup;
            btnOk.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(337, 337);
            btnOk.Margin = new Padding(3, 2, 3, 2);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(105, 30);
            btnOk.TabIndex = 3;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // ShowAllTipsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 400);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(txtAllTips);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ShowAllTipsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "All Recycling Tips";
            Load += ShowAllTipsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}