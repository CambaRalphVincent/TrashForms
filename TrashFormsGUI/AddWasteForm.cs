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
    public partial class AddWasteForm : Form
    {
        private readonly DatabaseManager dbManager;
        private readonly int userId;

        public AddWasteForm(int userId, DatabaseManager dbManager)
        {
            InitializeComponent();
            this.userId = userId;
            this.dbManager = dbManager;

            cmbWasteType.Items.AddRange(new object[] { "Plastic", "Glass", "Metal", "Organic", "Electronic" });
            cmbWasteType.SelectedIndex = 0;
            numQuantity.Value = 1;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text.Trim();
            int quantity = (int)numQuantity.Value;
            string wasteType = cmbWasteType.SelectedItem.ToString();

            if (string.IsNullOrEmpty(itemName))
            {
                MessageBox.Show("Item name cannot be empty.");
                return;
            }

            bool success = dbManager.InsertWasteItem(userId, itemName, quantity, wasteType);

            if (success)
            {
                // Show all tips for the selected waste type
                var allTips = dbManager.GetAllTipsByWasteType(wasteType);
                using (var allTipsForm = new ShowAllTipsForm(wasteType, allTips))
                {
                    allTipsForm.ShowDialog(this);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add waste item.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            string itemName = txtItemName.Text.Trim();
            string wasteType = cmbWasteType.SelectedItem?.ToString();
            int quantity = (int)numQuantity.Value;

            if (string.IsNullOrEmpty(itemName) || string.IsNullOrEmpty(wasteType))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than 0.");
                return;
            }

            bool success = dbManager.InsertWasteItem(userId, itemName, quantity, wasteType);

            if (success)
            {
                var allTips = dbManager.GetAllTipsByWasteType(wasteType);
                using (var allTipsForm = new ShowAllTipsForm(wasteType, allTips))
                {
                    allTipsForm.ShowDialog(this);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to add waste item.");
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddWasteForm_Load(object sender, EventArgs e)
        {

        }

        private void lblQuantity_Click(object sender, EventArgs e)
        {

        }
    }
}