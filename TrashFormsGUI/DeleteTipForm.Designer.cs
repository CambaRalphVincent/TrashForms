namespace TrashFormsGUI
{
    partial class DeleteTipForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWasteType;
        private System.Windows.Forms.ComboBox cmbWasteType;
        private System.Windows.Forms.ListBox lstTips;
        private System.Windows.Forms.Label lblTipNumber;
        private System.Windows.Forms.TextBox txtTipNumber;
        private System.Windows.Forms.TextBox txtSelectedTip;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;

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
            lblWasteType = new Label();
            cmbWasteType = new ComboBox();
            lstTips = new ListBox();
            lblTipNumber = new Label();
            txtTipNumber = new TextBox();
            txtSelectedTip = new TextBox();
            btnDelete = new Button();
            btnCancel = new Button();
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
            lblTitle.Size = new Size(209, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Delete Recycling Tip";
            // 
            // lblWasteType
            // 
            lblWasteType.AutoSize = true;
            lblWasteType.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWasteType.Location = new Point(95, 247);
            lblWasteType.Name = "lblWasteType";
            lblWasteType.Size = new Size(126, 23);
            lblWasteType.TabIndex = 2;
            lblWasteType.Text = "Waste Type:";
            // 
            // cmbWasteType
            // 
            cmbWasteType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWasteType.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbWasteType.Location = new Point(227, 247);
            cmbWasteType.Name = "cmbWasteType";
            cmbWasteType.Size = new Size(250, 31);
            cmbWasteType.TabIndex = 3;
            // 
            // lstTips
            // 
            lstTips.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstTips.ItemHeight = 21;
            lstTips.Location = new Point(227, 284);
            lstTips.Name = "lstTips";
            lstTips.Size = new Size(250, 88);
            lstTips.TabIndex = 4;
            lstTips.SelectedIndexChanged += lstTips_SelectedIndexChanged;
            // 
            // lblTipNumber
            // 
            lblTipNumber.AutoSize = true;
            lblTipNumber.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipNumber.Location = new Point(95, 397);
            lblTipNumber.Name = "lblTipNumber";
            lblTipNumber.Size = new Size(125, 23);
            lblTipNumber.TabIndex = 5;
            lblTipNumber.Text = "Tip Number:";
            // 
            // txtTipNumber
            // 
            txtTipNumber.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTipNumber.Location = new Point(226, 397);
            txtTipNumber.Name = "txtTipNumber";
            txtTipNumber.Size = new Size(250, 32);
            txtTipNumber.TabIndex = 6;
            // 
            // txtSelectedTip
            // 
            txtSelectedTip.Font = new Font("Century Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSelectedTip.Location = new Point(227, 440);
            txtSelectedTip.Multiline = true;
            txtSelectedTip.Name = "txtSelectedTip";
            txtSelectedTip.ReadOnly = true;
            txtSelectedTip.ScrollBars = ScrollBars.Vertical;
            txtSelectedTip.Size = new Size(366, 60);
            txtSelectedTip.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnDelete.Location = new Point(620, 397);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(120, 45);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnCancel.Location = new Point(620, 455);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(120, 45);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // DeleteTipForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 533);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblWasteType);
            Controls.Add(cmbWasteType);
            Controls.Add(lstTips);
            Controls.Add(lblTipNumber);
            Controls.Add(txtTipNumber);
            Controls.Add(txtSelectedTip);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteTipForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Delete Recycling Tip";
            Load += DeleteTipForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}