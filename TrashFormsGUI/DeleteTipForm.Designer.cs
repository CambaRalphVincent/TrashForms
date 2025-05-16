namespace TrashFormsGUI
{
    partial class DeleteTipForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWasteType;
        private System.Windows.Forms.ComboBox cmbWasteType;
        private System.Windows.Forms.TextBox txtTips;
        private System.Windows.Forms.Label lblTipNumber;
        private System.Windows.Forms.TextBox txtTipNumber;
        private System.Windows.Forms.TextBox txtSelectedTip;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.Label lblSelectedTip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pictureBox1 = new System.Windows.Forms.PictureBox();
            lblTitle = new System.Windows.Forms.Label();
            lblWasteType = new System.Windows.Forms.Label();
            cmbWasteType = new System.Windows.Forms.ComboBox();
            txtTips = new System.Windows.Forms.TextBox();
            lblTipNumber = new System.Windows.Forms.Label();
            txtTipNumber = new System.Windows.Forms.TextBox();
            txtSelectedTip = new System.Windows.Forms.TextBox();
            btnDelete = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            lblTips = new System.Windows.Forms.Label();
            lblSelectedTip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.Color.Transparent;
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new System.Drawing.Point(95, 39);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(706, 145);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = System.Drawing.Color.Transparent;
            lblTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, 0);
            lblTitle.ForeColor = System.Drawing.Color.White;
            lblTitle.Location = new System.Drawing.Point(115, 200);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(210, 23);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Delete Recycling Tip";
            // 
            // lblWasteType
            // 
            lblWasteType.AutoSize = true;
            lblWasteType.BackColor = System.Drawing.Color.Transparent;
            lblWasteType.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            lblWasteType.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
            lblWasteType.Location = new System.Drawing.Point(30, 250);
            lblWasteType.Name = "lblWasteType";
            lblWasteType.Size = new System.Drawing.Size(127, 23);
            lblWasteType.TabIndex = 2;
            lblWasteType.Text = "Waste Type:";
            // 
            // cmbWasteType
            // 
            cmbWasteType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbWasteType.Font = new System.Drawing.Font("Century Gothic", 12F);
            cmbWasteType.Location = new System.Drawing.Point(163, 247);
            cmbWasteType.Name = "cmbWasteType";
            cmbWasteType.Size = new System.Drawing.Size(164, 31);
            cmbWasteType.TabIndex = 3;
            // 
            // txtTips
            // 
            txtTips.Font = new System.Drawing.Font("Century Gothic", 12F);
            txtTips.Location = new System.Drawing.Point(163, 284);
            txtTips.Name = "txtTips";
            txtTips.Size = new System.Drawing.Size(245, 142);
            txtTips.Multiline = true;
            txtTips.ReadOnly = true;
            txtTips.WordWrap = true;
            txtTips.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtTips.TabIndex = 4;
            // 
            // lblTipNumber
            // 
            lblTipNumber.AutoSize = true;
            lblTipNumber.BackColor = System.Drawing.Color.Transparent;
            lblTipNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            lblTipNumber.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
            lblTipNumber.Location = new System.Drawing.Point(443, 247);
            lblTipNumber.Name = "lblTipNumber";
            lblTipNumber.Size = new System.Drawing.Size(126, 23);
            lblTipNumber.TabIndex = 5;
            lblTipNumber.Text = "Tip Number:";
            // 
            // txtTipNumber
            // 
            txtTipNumber.Font = new System.Drawing.Font("Century Gothic", 12F);
            txtTipNumber.Location = new System.Drawing.Point(575, 241);
            txtTipNumber.Name = "txtTipNumber";
            txtTipNumber.Size = new System.Drawing.Size(55, 32);
            txtTipNumber.TabIndex = 6;
            txtTipNumber.ReadOnly = false;
            // 
            // txtSelectedTip
            // 
            txtSelectedTip.Font = new System.Drawing.Font("Century Gothic", 12F);
            txtSelectedTip.Location = new System.Drawing.Point(575, 284);
            txtSelectedTip.Multiline = true;
            txtSelectedTip.Name = "txtSelectedTip";
            txtSelectedTip.ReadOnly = true;
            txtSelectedTip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            txtSelectedTip.Size = new System.Drawing.Size(307, 144);
            txtSelectedTip.TabIndex = 7;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = System.Drawing.Color.SeaGreen;
            btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnDelete.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            btnDelete.ForeColor = System.Drawing.Color.White;
            btnDelete.Location = new System.Drawing.Point(320, 460);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(120, 45);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = System.Drawing.Color.SeaGreen;
            btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            btnCancel.ForeColor = System.Drawing.Color.White;
            btnCancel.Location = new System.Drawing.Point(471, 460);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(120, 45);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // lblTips
            // 
            lblTips.AutoSize = true;
            lblTips.BackColor = System.Drawing.Color.Transparent;
            lblTips.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            lblTips.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
            lblTips.Location = new System.Drawing.Point(106, 287);
            lblTips.Name = "lblTips";
            lblTips.Size = new System.Drawing.Size(51, 23);
            lblTips.TabIndex = 10;
            lblTips.Text = "Tips:";
            // 
            // lblSelectedTip
            // 
            lblSelectedTip.AutoSize = true;
            lblSelectedTip.BackColor = System.Drawing.Color.Transparent;
            lblSelectedTip.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            lblSelectedTip.ForeColor = System.Drawing.Color.FromArgb(0, 64, 0);
            lblSelectedTip.Location = new System.Drawing.Point(435, 284);
            lblSelectedTip.Name = "lblSelectedTip";
            lblSelectedTip.Size = new System.Drawing.Size(134, 23);
            lblSelectedTip.TabIndex = 11;
            lblSelectedTip.Text = "Selected Tip:";
            // 
            // DeleteTipForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg2;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(914, 533);
            Controls.Add(lblSelectedTip);
            Controls.Add(lblTips);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblWasteType);
            Controls.Add(cmbWasteType);
            Controls.Add(txtTips);
            Controls.Add(lblTipNumber);
            Controls.Add(txtTipNumber);
            Controls.Add(txtSelectedTip);
            Controls.Add(btnDelete);
            Controls.Add(btnCancel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DeleteTipForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Delete Recycling Tip";
            Load += DeleteTipForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }

}