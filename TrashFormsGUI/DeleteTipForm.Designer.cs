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
            lblTips = new Label();
            lblSelectedTip = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new Point(83, 29);
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
            lblTitle.Location = new Point(101, 150);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(167, 21);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Delete Recycling Tip";
            // 
            // lblWasteType
            // 
            lblWasteType.AutoSize = true;
            lblWasteType.BackColor = Color.Transparent;
            lblWasteType.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblWasteType.ForeColor = Color.FromArgb(0, 64, 0);
            lblWasteType.Location = new Point(45, 189);
            lblWasteType.Name = "lblWasteType";
            lblWasteType.Size = new Size(99, 19);
            lblWasteType.TabIndex = 2;
            lblWasteType.Text = "Waste Type:";
            // 
            // cmbWasteType
            // 
            cmbWasteType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWasteType.Font = new Font("Century Gothic", 12F);
            cmbWasteType.Location = new Point(143, 185);
            cmbWasteType.Margin = new Padding(3, 2, 3, 2);
            cmbWasteType.Name = "cmbWasteType";
            cmbWasteType.Size = new Size(144, 29);
            cmbWasteType.TabIndex = 3;
            // 
            // lstTips
            // 
            lstTips.Font = new Font("Century Gothic", 12F);
            lstTips.ItemHeight = 21;
            lstTips.Location = new Point(143, 213);
            lstTips.Margin = new Padding(3, 2, 3, 2);
            lstTips.Name = "lstTips";
            lstTips.Size = new Size(215, 109);
            lstTips.TabIndex = 4;
            lstTips.SelectedIndexChanged += lstTips_SelectedIndexChanged;
            // 
            // lblTipNumber
            // 
            lblTipNumber.AutoSize = true;
            lblTipNumber.BackColor = Color.Transparent;
            lblTipNumber.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblTipNumber.ForeColor = Color.FromArgb(0, 64, 0);
            lblTipNumber.Location = new Point(367, 185);
            lblTipNumber.Name = "lblTipNumber";
            lblTipNumber.Size = new Size(103, 19);
            lblTipNumber.TabIndex = 5;
            lblTipNumber.Text = "Tip Number:";
            // 
            // txtTipNumber
            // 
            txtTipNumber.Font = new Font("Century Gothic", 12F);
            txtTipNumber.Location = new Point(468, 181);
            txtTipNumber.Margin = new Padding(3, 2, 3, 2);
            txtTipNumber.Name = "txtTipNumber";
            txtTipNumber.Size = new Size(49, 27);
            txtTipNumber.TabIndex = 6;
            // 
            // txtSelectedTip
            // 
            txtSelectedTip.Font = new Font("Century Gothic", 12F);
            txtSelectedTip.Location = new Point(468, 213);
            txtSelectedTip.Margin = new Padding(3, 2, 3, 2);
            txtSelectedTip.Multiline = true;
            txtSelectedTip.Name = "txtSelectedTip";
            txtSelectedTip.ReadOnly = true;
            txtSelectedTip.ScrollBars = ScrollBars.Vertical;
            txtSelectedTip.Size = new Size(269, 109);
            txtSelectedTip.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.SeaGreen;
            btnDelete.FlatStyle = FlatStyle.Popup;
            btnDelete.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(280, 345);
            btnDelete.Margin = new Padding(3, 2, 3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(105, 34);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SeaGreen;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(412, 345);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 34);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblTips
            // 
            lblTips.AutoSize = true;
            lblTips.BackColor = Color.Transparent;
            lblTips.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblTips.ForeColor = Color.FromArgb(0, 64, 0);
            lblTips.Location = new Point(103, 213);
            lblTips.Name = "lblTips";
            lblTips.Size = new Size(41, 19);
            lblTips.TabIndex = 10;
            lblTips.Text = "Tips:";
            // 
            // lblSelectedTip
            // 
            lblSelectedTip.AutoSize = true;
            lblSelectedTip.BackColor = Color.Transparent;
            lblSelectedTip.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            lblSelectedTip.ForeColor = Color.FromArgb(0, 64, 0);
            lblSelectedTip.Location = new Point(364, 213);
            lblSelectedTip.Name = "lblSelectedTip";
            lblSelectedTip.Size = new Size(106, 19);
            lblSelectedTip.TabIndex = 11;
            lblSelectedTip.Text = "Selected Tip:";
            // 
            // DeleteTipForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 400);
            Controls.Add(lblSelectedTip);
            Controls.Add(lblTips);
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
            Margin = new Padding(3, 2, 3, 2);
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

        private Label lblTips;
        private Label lblSelectedTip;
    }
}