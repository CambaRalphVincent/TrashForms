namespace TrashFormsGUI
{
    partial class RecyclingTipsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWasteType;
        private System.Windows.Forms.ComboBox cmbWasteType;
        private System.Windows.Forms.Button btnShowTips;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTips;

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
            lblWasteType = new Label();
            cmbWasteType = new ComboBox();
            btnShowTips = new Button();
            btnCancel = new Button();
            txtTips = new TextBox();
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(312, 200);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(145, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Recycling Tips";
            lblTitle.Click += lblTitle_Click;
            // 
            // lblWasteType
            // 
            lblWasteType.AutoSize = true;
            lblWasteType.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWasteType.Location = new Point(220, 250);
            lblWasteType.Name = "lblWasteType";
            lblWasteType.Size = new Size(126, 23);
            lblWasteType.TabIndex = 2;
            lblWasteType.Text = "Waste Type:";
            // 
            // cmbWasteType
            // 
            cmbWasteType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWasteType.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbWasteType.Location = new Point(350, 247);
            cmbWasteType.Name = "cmbWasteType";
            cmbWasteType.Size = new Size(250, 31);
            cmbWasteType.TabIndex = 3;
            // 
            // btnShowTips
            // 
            btnShowTips.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnShowTips.Location = new Point(312, 300);
            btnShowTips.Margin = new Padding(3, 4, 3, 4);
            btnShowTips.Name = "btnShowTips";
            btnShowTips.Size = new Size(120, 45);
            btnShowTips.TabIndex = 4;
            btnShowTips.Text = "Show Tips";
            btnShowTips.UseVisualStyleBackColor = true;
            btnShowTips.Click += btnShowTips_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnCancel.Location = new Point(470, 300);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 45);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtTips
            // 
            txtTips.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTips.Location = new Point(146, 371);
            txtTips.Multiline = true;
            txtTips.Name = "txtTips";
            txtTips.ReadOnly = true;
            txtTips.ScrollBars = ScrollBars.Vertical;
            txtTips.Size = new Size(581, 120);
            txtTips.TabIndex = 6;
            txtTips.TextChanged += txtTips_TextChanged;
            // 
            // RecyclingTipsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 533);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblWasteType);
            Controls.Add(cmbWasteType);
            Controls.Add(btnShowTips);
            Controls.Add(btnCancel);
            Controls.Add(txtTips);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RecyclingTipsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Recycling Tips";
            Load += RecyclingTipsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}