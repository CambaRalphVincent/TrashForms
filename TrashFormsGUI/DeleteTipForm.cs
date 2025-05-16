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

            cmbWasteType.SelectedIndexChanged += cmbWasteType_SelectedIndexChanged;
            btnDelete.Click += btnDelete_Click;
            btnCancel.Click += btnCancel_Click;
            txtTipNumber.TextChanged += txtTipNumber_TextChanged;
        }

        private void DeleteTipForm_Load(object sender, EventArgs e)
        {
            cmbWasteType.Items.AddRange(new object[] { "Plastic", "Glass", "Metal", "Organic", "Electronic" });
            cmbWasteType.SelectedIndex = 0;
            txtTipNumber.Clear();
            txtSelectedTip.Clear();
            LoadTips();
        }

        private void cmbWasteType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTips();
        }

        private void LoadTips()
        {
            txtTips.Clear();
            txtSelectedTip.Clear();
            txtTipNumber.Clear();
            string wasteType = cmbWasteType.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(wasteType)) return;

            currentTips = dbManager.GetAllTipsByWasteType(wasteType) ?? new List<string>();
            if (currentTips.Count > 0)
            {
                var sb = new StringBuilder();
                for (int i = 0; i < currentTips.Count; i++)
                {
                    sb.AppendLine($"{i + 1}. {currentTips[i]}");
                    sb.AppendLine();
                }
                txtTips.Text = sb.ToString();
            }
            else
            {
                txtTips.Text = "No tips found for this waste type.";
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

            if (!int.TryParse(txtTipNumber.Text.Trim(), out int tipNumber) || tipNumber <= 0 || tipNumber > currentTips.Count)
            {
                MessageBox.Show("Please enter a valid tip number.");
                return;
            }

            bool success = dbManager.DeleteRecyclingTip(wasteType, tipNumber);
            if (success)
            {
                MessageBox.Show("Recycling tip deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTips();
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

        private void txtTipNumber_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtTipNumber.Text.Trim(), out int tipNumber) &&
                tipNumber > 0 && tipNumber <= currentTips.Count)
            {
                txtSelectedTip.Text = currentTips[tipNumber - 1];
            }
            else
            {
                txtSelectedTip.Clear();
            }
        }
    }
}
