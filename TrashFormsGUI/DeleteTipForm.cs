using System;
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
    public partial class DeleteTipForm : Form
    {
        private readonly DatabaseManager dbManager;
        private List<string> currentTips = new List<string>();

        public DeleteTipForm(DatabaseManager dbManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;
        }

        private void DeleteTipForm_Load(object sender, EventArgs e)
        {
            cmbWasteType.Items.AddRange(new object[] { "Plastic", "Glass", "Metal", "Organic", "Electronic" });
            cmbWasteType.SelectedIndex = 0;
            txtTipNumber.Clear();
            txtSelectedTip.Clear();
            LoadTips();
            cmbWasteType.SelectedIndexChanged += cmbWasteType_SelectedIndexChanged;
        }

        private void cmbWasteType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTips();
        }

        private void LoadTips()
        {
            lstTips.Items.Clear();
            txtSelectedTip.Clear();
            string wasteType = cmbWasteType.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(wasteType)) return;

            currentTips = dbManager.GetAllTipsByWasteType(wasteType) ?? new List<string>();
            if (currentTips.Count > 0)
            {
                for (int i = 0; i < currentTips.Count; i++)
                {
                    lstTips.Items.Add($"{i + 1}. {currentTips[i]}");
                }
            }
            else
            {
                lstTips.Items.Add("No tips found for this waste type.");
            }
        }

        private void lstTips_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTips.SelectedIndex >= 0 && currentTips.Count > lstTips.SelectedIndex)
            {
                txtTipNumber.Text = (lstTips.SelectedIndex + 1).ToString();
                txtSelectedTip.Text = currentTips[lstTips.SelectedIndex];
            }
            else
            {
                txtSelectedTip.Clear();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string wasteType = cmbWasteType.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(wasteType))
            {
                MessageBox.Show("Please select a waste type.");
                return;
            }

            if (!int.TryParse(txtTipNumber.Text.Trim(), out int tipNumber) || tipNumber <= 0)
            {
                MessageBox.Show("Please enter a valid tip number (positive integer).");
                return;
            }

            bool success = dbManager.DeleteRecyclingTip(wasteType, tipNumber);
            if (success)
            {
                MessageBox.Show("Recycling tip deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to delete recycling tip. Please check the tip number and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
