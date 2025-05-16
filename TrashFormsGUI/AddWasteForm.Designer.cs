namespace TrashFormsGUI
{
    partial class AddWasteForm
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
            lblItemName = new Label();
            lblQuantity = new Label();
            lblWasteType = new Label();
            txtItemName = new TextBox();
            numQuantity = new NumericUpDown();
            cmbWasteType = new ComboBox();
            btnSubmit = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new Point(85, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(624, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.BackColor = Color.Transparent;
            lblItemName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblItemName.ForeColor = Color.FromArgb(0, 64, 0);
            lblItemName.Location = new Point(271, 187);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(116, 24);
            lblItemName.TabIndex = 1;
            lblItemName.Text = "Item Name:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.BackColor = Color.Transparent;
            lblQuantity.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = Color.FromArgb(0, 64, 0);
            lblQuantity.Location = new Point(295, 222);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(92, 24);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity:";
            lblQuantity.Click += lblQuantity_Click;
            // 
            // lblWasteType
            // 
            lblWasteType.AutoSize = true;
            lblWasteType.BackColor = Color.Transparent;
            lblWasteType.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWasteType.ForeColor = Color.FromArgb(0, 64, 0);
            lblWasteType.Location = new Point(261, 257);
            lblWasteType.Name = "lblWasteType";
            lblWasteType.Size = new Size(126, 24);
            lblWasteType.TabIndex = 3;
            lblWasteType.Text = "Waste Type:";
            // 
            // txtItemName
            // 
            txtItemName.BackColor = Color.White;
            txtItemName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtItemName.Location = new Point(393, 186);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(120, 26);
            txtItemName.TabIndex = 4;
            // 
            // numQuantity
            // 
            numQuantity.BackColor = Color.White;
            numQuantity.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            numQuantity.Location = new Point(393, 222);
            numQuantity.Margin = new Padding(3, 2, 3, 2);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(120, 26);
            numQuantity.TabIndex = 5;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbWasteType
            // 
            cmbWasteType.BackColor = Color.White;
            cmbWasteType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWasteType.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cmbWasteType.FormattingEnabled = true;
            cmbWasteType.Location = new Point(393, 257);
            cmbWasteType.Name = "cmbWasteType";
            cmbWasteType.Size = new Size(121, 28);
            cmbWasteType.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.SeaGreen;
            btnSubmit.FlatStyle = FlatStyle.Popup;
            btnSubmit.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.Location = new Point(344, 303);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(116, 36);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.SeaGreen;
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(345, 345);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(115, 37);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // AddWasteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(cmbWasteType);
            Controls.Add(numQuantity);
            Controls.Add(txtItemName);
            Controls.Add(lblWasteType);
            Controls.Add(lblQuantity);
            Controls.Add(lblItemName);
            Controls.Add(pictureBox1);
            Name = "AddWasteForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddWasteForm";
            Load += AddWasteForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblItemName;
        private Label lblQuantity;
        private Label lblWasteType;
        private TextBox txtItemName;
        private NumericUpDown numQuantity;
        private ComboBox cmbWasteType;
        private Button btnSubmit;
        private Button btnCancel;
    }
}