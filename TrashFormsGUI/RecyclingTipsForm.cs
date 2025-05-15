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
            cmbWasteType.Items.AddRange(new object[] { "Plastic", "Glass", "Metal", "Organic", "Paper" });
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

            string tips = dbManager.GetTipByWasteType(wasteType);
            txtTips.Text = tips;
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
