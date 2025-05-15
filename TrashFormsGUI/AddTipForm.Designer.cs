namespace TrashFormsGUI
{
    partial class AddTipForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWasteType;
        private System.Windows.Forms.ComboBox cmbWasteType;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.TextBox txtTip;
        private System.Windows.Forms.Button btnAdd;
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
            lblTip = new Label();
            txtTip = new TextBox();
            btnAdd = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new Point(82, 48);
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
            lblTitle.ForeColor = Color.FromArgb(0, 64, 0);
            lblTitle.Location = new Point(149, 176);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(151, 21);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Add Recycling Tip";
            // 
            // lblWasteType
            // 
            lblWasteType.AutoSize = true;
            lblWasteType.BackColor = Color.Transparent;
            lblWasteType.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            lblWasteType.ForeColor = Color.White;
            lblWasteType.Location = new Point(149, 209);
            lblWasteType.Name = "lblWasteType";
            lblWasteType.Size = new Size(120, 23);
            lblWasteType.TabIndex = 2;
            lblWasteType.Text = "Waste Type:";
            // 
            // cmbWasteType
            // 
            cmbWasteType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWasteType.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbWasteType.Location = new Point(275, 208);
            cmbWasteType.Margin = new Padding(3, 2, 3, 2);
            cmbWasteType.Name = "cmbWasteType";
            cmbWasteType.Size = new Size(219, 29);
            cmbWasteType.TabIndex = 3;
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.BackColor = Color.Transparent;
            lblTip.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            lblTip.ForeColor = Color.White;
            lblTip.Location = new Point(228, 243);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(41, 23);
            lblTip.TabIndex = 4;
            lblTip.Text = "Tip:";
            // 
            // txtTip
            // 
            txtTip.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTip.Location = new Point(275, 242);
            txtTip.Margin = new Padding(3, 2, 3, 2);
            txtTip.Multiline = true;
            txtTip.Name = "txtTip";
            txtTip.Size = new Size(368, 81);
            txtTip.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.SeaGreen;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(275, 339);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(105, 34);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SeaGreen;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(389, 339);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(105, 34);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddTipForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 400);
            Controls.Add(pictureBox1);
            Controls.Add(lblTitle);
            Controls.Add(lblWasteType);
            Controls.Add(cmbWasteType);
            Controls.Add(lblTip);
            Controls.Add(txtTip);
            Controls.Add(btnAdd);
            Controls.Add(btnCancel);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddTipForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add Recycling Tip";
            Load += AddTipForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}