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
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new Point(95, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(706, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(312, 200);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(174, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "All Recycling Tips";
            // 
            // txtAllTips
            // 
            txtAllTips.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAllTips.Location = new Point(178, 240);
            txtAllTips.Multiline = true;
            txtAllTips.Name = "txtAllTips";
            txtAllTips.ReadOnly = true;
            txtAllTips.ScrollBars = ScrollBars.Vertical;
            txtAllTips.Size = new Size(547, 180);
            txtAllTips.TabIndex = 2;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnOk.Location = new Point(370, 440);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(120, 40);
            btnOk.TabIndex = 3;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // ShowAllTipsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 533);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(txtAllTips);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
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