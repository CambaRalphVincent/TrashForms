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
    public partial class RecyclingSummaryForm : Form
    {
        public RecyclingSummaryForm(string summary)
        {
            InitializeComponent();
            txtSummary.Text = summary;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
