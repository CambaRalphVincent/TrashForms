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
    public partial class RecyclingTipsForm : Form
    {
        private readonly DatabaseManager dbManager;

        public RecyclingTipsForm(DatabaseManager dbManager)
        {
            InitializeComponent();
            this.dbManager = dbManager;
        }

        private void RecyclingTipsForm_Load(object sender, EventArgs e)
        {
            // Populate waste types
            cmbWasteType.Items.AddRange(new object[] { "Plastic", "Glass", "Metal", "Organic", "Electronic" });
            cmbWasteType.SelectedIndex = 0;
            txtTips.Clear();
        }

        private void btnShowTips_Click(object sender, EventArgs e)
        {
            string wasteType = cmbWasteType.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(wasteType))
            {
                MessageBox.Show("Please select a waste type.");
                return;
            }

            var tips = dbManager.GetAllTipsByWasteType(wasteType);
            if (tips != null && tips.Count > 0)
            {
                // Join tips with new lines for proper formatting
                txtTips.Text = string.Join(Environment.NewLine + Environment.NewLine, tips.Select((tip, i) => $"{i + 1}. {tip}"));
            }
            else
            {
                txtTips.Text = "No tips found for this waste type.";
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTips_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
