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
    public partial class ShowAllTipsForm : Form
    {
        public ShowAllTipsForm(string wasteType, List<string> tips)
        {
            InitializeComponent();
            lblTitle.Text = $"All Recycling Tips - {wasteType}";
            txtAllTips.Text = FormatTips(tips, wasteType);
        }

        private string FormatTips(List<string> tips, string wasteType)
        {
            if (tips == null || tips.Count == 0)
                return $"No tips found for {wasteType}.";

            var sb = new StringBuilder();
            for (int i = 0; i < tips.Count; i++)
            {
                sb.AppendLine($"{i + 1}. {tips[i]}");
            }
            return sb.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowAllTipsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
