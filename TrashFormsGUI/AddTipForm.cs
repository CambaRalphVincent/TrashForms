﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrashFormsGUI
{
    public partial class AddTipForm : Form
    {
        private readonly DatabaseManager dbManager;

        public AddTipForm(DatabaseManager dbManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;
        }

        private void AddTipForm_Load(object sender, EventArgs e)
        {
            cmbWasteType.Items.AddRange(new object[] { "Plastic", "Glass", "Metal", "Organic", "Electronic" });
            cmbWasteType.SelectedIndex = 0;
            txtTip.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string wasteType = cmbWasteType.SelectedItem?.ToString();
            string tip = txtTip.Text.Trim();

            if (string.IsNullOrEmpty(wasteType) || string.IsNullOrEmpty(tip))
            {
                MessageBox.Show("Please select a waste type and enter a tip.");
                return;
            }

            try
            {
                dbManager.InsertOrUpdateTip(wasteType, tip);
                MessageBox.Show(
                    $"Recycling tip added successfully!\n\nWaste Type: {wasteType}\nTip: {tip}",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                txtTip.Clear(); // Clear the tip input for the next entry
                txtTip.Focus(); // Set focus back to the tip input
                                // Optionally reset waste type selection:
                                // cmbWasteType.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding recycling tip: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
