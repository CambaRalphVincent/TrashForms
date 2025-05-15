namespace TrashFormsGUI
{
    partial class ShowTipForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Button btnOk;

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
            lblTitle = new Label();
            txtTip = new TextBox();
            btnOk = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new Point(40, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(500, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(200, 130);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(137, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Recycling Tip";
            // 
            // txtTip
            // 
            txtTip.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTip.Location = new Point(60, 170);
            txtTip.Multiline = true;
            txtTip.Name = "txtTip";
            txtTip.ReadOnly = true;
            txtTip.ScrollBars = ScrollBars.Vertical;
            txtTip.Size = new Size(460, 100);
            txtTip.TabIndex = 2;
            txtTip.TextChanged += txtTip_TextChanged;
            // 
            // btnOk
            // 
            btnOk.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnOk.Location = new Point(230, 290);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(120, 40);
            btnOk.TabIndex = 3;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // ShowTipForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(txtTip);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ShowTipForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recycling Tip";
            Load += ShowTipForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}