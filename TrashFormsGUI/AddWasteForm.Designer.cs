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
            pictureBox1.Image = Properties.Resources.Sample_UI__1_2;
            pictureBox1.Location = new Point(97, 51);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(713, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            lblItemName.Location = new Point(318, 248);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(150, 28);
            lblItemName.TabIndex = 1;
            lblItemName.Text = "Item Name:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            lblQuantity.Location = new Point(318, 295);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(117, 28);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity:";
            // 
            // lblWasteType
            // 
            lblWasteType.AutoSize = true;
            lblWasteType.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            lblWasteType.Location = new Point(318, 343);
            lblWasteType.Name = "lblWasteType";
            lblWasteType.Size = new Size(152, 28);
            lblWasteType.TabIndex = 3;
            lblWasteType.Text = "Waste Type:";
            // 
            // txtItemName
            // 
            txtItemName.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            txtItemName.Location = new Point(462, 248);
            txtItemName.Margin = new Padding(3, 4, 3, 4);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(137, 32);
            txtItemName.TabIndex = 4;
            // 
            // numQuantity
            // 
            numQuantity.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            numQuantity.Location = new Point(462, 296);
            numQuantity.Margin = new Padding(3, 4, 3, 4);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(137, 32);
            numQuantity.TabIndex = 5;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cmbWasteType
            // 
            cmbWasteType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbWasteType.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            cmbWasteType.FormattingEnabled = true;
            cmbWasteType.Location = new Point(462, 343);
            cmbWasteType.Margin = new Padding(3, 4, 3, 4);
            cmbWasteType.Name = "cmbWasteType";
            cmbWasteType.Size = new Size(138, 31);
            cmbWasteType.TabIndex = 6;
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnSubmit.Location = new Point(393, 404);
            btnSubmit.Margin = new Padding(3, 4, 3, 4);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(133, 48);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click_1;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold);
            btnCancel.Location = new Point(394, 460);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 49);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click_1;
            // 
            // AddWasteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnCancel);
            Controls.Add(btnSubmit);
            Controls.Add(cmbWasteType);
            Controls.Add(numQuantity);
            Controls.Add(txtItemName);
            Controls.Add(lblWasteType);
            Controls.Add(lblQuantity);
            Controls.Add(lblItemName);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
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